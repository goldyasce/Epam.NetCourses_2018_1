Use UsersAndRewards

Insert into Users values
('Иванов', 'Иван', '04.09.2009'),
('Петров', 'Петр', '08.04.1997'),
('Степанов', 'Степан', '17.05.2001')

Insert into Rewards values
('Нобелевская премия', 'Достаточно престижная премия'),
('Премия Дарвина', '')

Insert into RewardsOfUsers values
(1, 2),
(2, 1),
(2, 2)


select Users.[FirstName], Users.[LastName], Rewards.Title
from (RewardsOfUsers left join Users on ID_User = ID) 
		left join Rewards on RewardsOfUsers.ID_Reward = Rewards.ID 
go

create Proc AddUser
(@firstName nvarchar(50), @lastName nvarchar(50), @dateOfBirth date, @ids [intTable] readOnly)
as
declare @usersID table(id int)
declare @userID int
insert into Users
Output inserted.ID into @usersID
 values (@firstName, @lastName, @dateOfBirth)
 set @userID = (select * from @usersID)
 declare @rewardID int 
 declare cur Cursor scroll
 for 
 select * from @ids
 open cur 
 fetch first
 from cur
 into @rewardID
 while @@FETCH_STATUS=0
 begin 
 insert into RewardsOfUsers Values (@userID, @rewardID)
 fetch next 
 from cur 
 into @rewardID
 end
 close cur
 deallocate cur
 go

 create Proc AddUser1
(@firstName nvarchar(50), @lastName nvarchar(50), @dateOfBirth date, @ids [intTable] readOnly)
as
declare @usersID table(id int)
declare @userID int
insert into Users
Output inserted.ID into @usersID
 values (@firstName, @lastName, @dateOfBirth)
 set @userID = (select * from @usersID)
 insert into RewardsOfUsers select @userID, id from @ids
 go

create Proc UpdateUser
(@id int,@firstName nvarchar(50), @lastName nvarchar(50), @dateOfBirth date, @ids [intTable] readOnly)
as
delete 
from RewardsOfUsers 
where ID_User = @id
update Users
set [FirstName] = @firstName,
[LastName] = @lastName,
[DateOfBirth] = @dateOfBirth
where ID = @id 
insert into RewardsOfUsers select @id, id from @ids
go

create proc DeleteUser (@id int)
as 
delete
from Users
Where ID = @id
go

create proc AddReward (@title nvarchar(50), @description nvarchar(150))
as
insert into Rewards values (@title, @description)
go

create proc UpdateReward
(@id int,@title nvarchar(50), @description nvarchar(150))
as
update Rewards
set [Title] = @title,
[Description] = @description
where ID = @id 
go

create proc DeleteReward (@id int)
as 
delete
from Rewards
Where ID = @id
go

create proc GetUsers
as 
select Users.ID,Users.FirstName, Users.LastName, Users.DateOfBirth
from Users
go

create proc GetRewards
as 
select ID,Title,[Description]
from Rewards
go

create proc GetUserById (@id int)
as
select ID,FirstName, LastName, DateOfBirth
from Users
where ID=@id
go

create proc GetRewardById (@id int)
as
select ID,Title, [Description]
from Rewards
where ID=@id
go

create type [intTable] 
as Table([id] int)
go

create proc ShowRewardsOfUser (@id int)
as
select ID
from Rewards right join RewardsOfUsers on  ID=ID_Reward
where ID_User=@id
go