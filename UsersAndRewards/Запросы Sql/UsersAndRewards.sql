USE master
GO
	CREATE DATABASE UsersAndRewards
		ON
			(NAME='UsersAndRewards-D',
			FILENAME='C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\UsersAndRewards-D.mdf',
			SIZE=5,
			MAXSIZE=10,
			FILEGROWTH=1
			)
		LOG ON
			(NAME='UsersAndRewards-L',
			FILENAME='C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\UsersAndRewards-L.ldf',
			SIZE=1,
			MAXSIZE=10,
			FILEGROWTH=1
			)
	GO

	use UsersAndRewards
	GO
	CREATE TABLE Users
		(ID INT PRIMARY KEY NOT NULL identity(1,1),
		Name nvarchar(100) NOT NULL,
		LastName nvarchar(150) NOT NULL,
		DateOfBirth date NOT NULL)
	GO

	CREATE TABLE Rewards
		(ID INT PRIMARY KEY NOT NULL identity(1,1),
		Title nvarchar(100) NOT NULL,
		[Description] nvarchar(100) NULL)
	GO
	CREATE TABLE RewardsOfUsers
		(IDUser INT NOT NULL,
		IDReward INT NOT NULL
		CONSTRAINT PK_RewardsOfUsers PRIMARY KEY ( IDUser, IDReward),
		CONSTRAINT FK_RewardsOfUsers_IDUser FOREIGN KEY (IDUser) REFERENCES Users(ID) on delete cascade,
		CONSTRAINT FK_RewardsOfUsers_IDReward FOREIGN KEY (IDReward) REFERENCES Rewards(ID)on delete cascade)
	GO
	drop table RewardsOfUsers
	INSERT INTO Users VALUES
('Лилия','Голубова','04.09.2009'),
('Руслан','Шикалов','07.12.2000'),
('Павел','Полунин','04.02.2008'),
('Анастасия','Бойкова','01.07.1997');
GO
SELECT * FROM RewardsOfUsers
GO
INSERT INTO Rewards VALUES
('Нобелевская премия','По матиматике'),
('Золотой глобус',NULL),
('Нобелевская премия','По физике');
GO
SELECT * FROM Users
GO
INSERT INTO RewardsOfUsers VALUES
(1,2),
(3,1),
(1,1);
GO

SELECT Users.Name,Users.LastName,Rewards.Title, Rewards.[Description]
FROM (RewardsOfUsers left join Users on IDUser = ID)
		left join Rewards on IDReward = Rewards.ID
GO

create type [intTable] 
as Table([id] int)
GO

CREATE PROC AddUser
(@firstName nvarchar(50), @lastName nvarchar(50), @dateOfBirth date, @ids [intTable] readOnly)
as
declare @usersID table(id int)
declare @userID int
insert into Users
Output inserted.ID into @usersID
 values (@firstName, @lastName, @dateOfBirth)
 set @userID = (select * from @usersID)
 insert into RewardsOfUsers 
 select @userID, id 
 from @ids
 go

 --drop proc AddUser
 --exec AddUser 'Виталий','Баренин','08.03.1997'

 CREATE PROC DeleteUser(@ID int)
AS
  delete
  from Users
  where ID = @ID
 GO

 --drop proc DeleteUser
 --exec DeleteUser 1

 CREATE PROC UpdateUser
 (@id int,@firstName nvarchar(50), @lastName nvarchar(50), @dateOfBirth date, @ids [intTable] readOnly)
as
delete 
from RewardsOfUsers 
where IDUser = @id
update Users
set Name = @firstName,
LastName = @lastName,
DateOfBirth = @dateOfBirth
where ID = @id 
insert into RewardsOfUsers select @id, id from @ids
go

 --drop proc UpdateUser
 --exec UpdateUser 7,'Виталий','Баренин','08.03.1997'

 CREATE PROC AddReward(@Title nvarchar(100), @Description nvarchar(100))
AS
 INSERT INTO Rewards
 VALUES(@Title, @Description)
 GO

 exec AddReward 'Диплом','1 степени'

 CREATE PROC DeleteReward(@ID int)
 AS
  delete
  from Rewards
  where ID = @ID
 GO
 --drop proc DeleteReward
 --exec DeleteReward 12

 CREATE PROC UpdateReward(@ID int,@Title nvarchar(100), @Description nvarchar(100))
 AS
update Rewards
set Title = @Title,
[Description] = @Description
where ID = @ID
GO

--drop proc UpdateReward
-- exec UpdateReward 14,'gjgj',''

create proc GetUsers
as 
select Users.ID,Users.Name, Users.LastName, Users.DateOfBirth
from Users
go

create proc GetRewards
as 
select ID,Title,[Description]
from Rewards
go

create proc GetUserById (@id int)
as
select ID,Name, LastName, DateOfBirth
from Users
where ID=@id
go

create proc GetRewardById (@id int)
as
select ID,Title, [Description]
from Rewards
where ID=@id
go

 CREATE PROC AddRewardsOfUsers(@IDUser INT, @IDReward int)
AS
 IF NOT EXISTS(select*
			from Rewards
			where ID = @IDReward)
BEGIN
print 'Reward is not exist!'
END
ELSE
BEGIN
 IF NOT EXISTS(select*
			from Users
			where ID = @IDUser)
BEGIN
print 'User is not exist!'
END
ELSE
BEGIN
 INSERT INTO RewardsOfUsers
 VALUES(@IDUser, @IDReward)
 END
 END
 GO

 exec AddRewardsOfUsers 1,12

 CREATE PROC DeleteRewardsOfUsers(@IDUser INT, @IDReward int)
 AS
  delete
  from RewardsOfUsers
  where IDUser = @IDUser and IDReward = @IDReward
 GO
 drop proc DeleteRewardsOfUsers
 exec DeleteRewardsOfUsers 7,7


 create proc ShowRewardsOfUser (@id int)
as
select Rewards.ID, Title,[Description]
from Rewards right join RewardsOfUsers on  ID=IDReward
where IDUser=@id
go

 --drop proc ShowRewardsOfUser
 --exec ShowRewardsOfUser 1

