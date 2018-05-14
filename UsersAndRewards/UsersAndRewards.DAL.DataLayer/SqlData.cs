using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersAndRewards.Shared;

namespace UsersAndRewards.DAL.DataLayer
{
    public class SqlData : IData
    {
        string connectionString = ConfigurationManager.ConnectionStrings["myconnectionString"].ConnectionString;

        public void AddReward(Reward reward)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                command.CommandText = "AddReward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@title", reward.Title);
                if (reward.Description is null)
                {
                    reward.Description = string.Empty;
                }
                command.Parameters.AddWithValue("@description", reward.Description);
                connection.Open();
                var result = command.ExecuteScalar();
                var rewardId = result as int?;
                if (rewardId.HasValue)
                {
                    reward.ID = rewardId.Value;
                }

            }
        }

        public void AddUser(User user)
        {
            var rewardsIDs = user.Rewards.Select(r => r.ID).ToList();
            var list = new List<int>();
            DataTable data = new DataTable();
            data.Columns.Add("id", typeof(int));
            foreach (var r in rewardsIDs)
            {
                data.Rows.Add(r);
            }
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                command.CommandText = "AddUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.Add("@ids", SqlDbType.Structured);
                command.Parameters["@ids"].TypeName = "intTable";
                command.Parameters["@ids"].Value = data;
                command.Parameters.AddWithValue("@firstName", user.FirstName);
                command.Parameters.AddWithValue("@lastName", user.LastName);
                command.Parameters.AddWithValue("@dateOfBirth", user.DateOfBirth);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteReward(int rewardId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                command.CommandText = "DeleteReward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@id", rewardId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteUser(int userId)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                command.CommandText = "DeleteUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@id", userId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public Reward GetRewardById(int rewardId)
        {
            var reward = new Reward();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                command.CommandText = "GetRewardById";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@id", rewardId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var title = reader.GetString(1);
                        var description = reader.GetString(2);
                        reward.ID = rewardId;
                        reward.Title = title;
                        reward.Description = description;
                    }
                }
            }
            return reward;
        }

        public List<Reward> GetRewards()
        {
            var rewards = new List<Reward>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                command.CommandText = "GetRewards";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var rewardId = reader.GetInt32(0);
                        var title = reader.GetString(1);
                        var description = String.Empty;
                        if (!reader.IsDBNull(2))
                        {
                            description = reader.GetString(2);
                        }
                        var reward = new Reward();
                        reward.ID = rewardId;
                        reward.Title = title;
                        reward.Description = description;
                        rewards.Add(reward);
                    }
                }
            }

            return rewards;
        }

        public User GetUserById(int userId)
        {
            var user = new User();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                command.CommandText = "GetUserById";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;

                command.Parameters.AddWithValue("@id", userId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ID = reader.GetInt32(0);
                        var firstName = reader.GetString(1);
                        var lastName = reader.GetString(2);
                        var birthdate = reader.GetDateTime(3);
                        user.ID = userId;
                        user.FirstName = firstName;
                        user.LastName = lastName;
                        user.DateOfBirth = birthdate;
                        user.Rewards = GetRewardsByUserID(userId);
                    }
                }
            }
            return user;
        }

        public List<User> GetUsers()
        {
            var users = new List<User>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                command.CommandText = "GetUsers";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var userId = reader.GetInt32(0);
                        var firstName = reader.GetString(1);
                        var lastName = reader.GetString(2);
                        var birthdate = reader.GetDateTime(3);
                        var user = new User();
                        user.ID = userId;
                        user.FirstName = firstName;
                        user.LastName = lastName;
                        user.DateOfBirth = birthdate;
                        user.Rewards = GetRewardsByUserID(userId);
                        users.Add(user);
                    }
                }
            }

            return users;
        }
        private List<Reward> GetRewardsByUserID(int userId)
        {
            var rewards = new List<Reward>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                command.CommandText = "ShowRewardsOfUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@id", userId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var rewardID = reader.GetInt32(0);
                        var title = reader.GetString(1);
                        var description = String.Empty;
                        if (!reader.IsDBNull(2))
                        {
                            description = reader.GetString(2);
                        }
                        var reward = new Reward();
                        reward.ID = rewardID;
                        reward.Title = title;
                        reward.Description = description;
                        rewards.Add(reward);
                    }
                }
            }

            return rewards;
        }

        public void UpdateReward(Reward reward)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                command.CommandText = "UpdateReward";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.AddWithValue("@id", reward.ID);
                command.Parameters.AddWithValue("@title", reward.Title);
                command.Parameters.AddWithValue("@description", reward.Description);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateUser(User user)
        {
            var rewardsIDs = user.Rewards.Select(r => r.ID).ToList();
            var list = new List<int>();
            DataTable data = new DataTable();
            data.Columns.Add("id", typeof(int));
            foreach (var r in rewardsIDs)
            {
                data.Rows.Add(r);
            }
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand();
                command.CommandText = "UpdateUser";
                command.CommandType = CommandType.StoredProcedure;
                command.Connection = connection;
                command.Parameters.Add("@ids", SqlDbType.Structured);
                command.Parameters["@ids"].TypeName = "intTable";
                command.Parameters["@ids"].Value = data;
                command.Parameters.AddWithValue("@id", user.ID);
                command.Parameters.AddWithValue("@firstName", user.FirstName);
                command.Parameters.AddWithValue("@lastName", user.LastName);
                command.Parameters.AddWithValue("@dateOfBirth", user.DateOfBirth);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}
