USE master
USE UsersAndRewards
	GO
	

	CREATE TABLE Users 
		(ID INT PRIMARY KEY NOT NULL identity(1,1),
		[FirstName]  NVARCHAR(50) NOT NULL,
		[LastName]  NVARCHAR(50) NOT NULL,
		[DateOfBirth]  DATE NOT NULL)
	GO

	CREATE TABLE Rewards 
		(ID INT PRIMARY KEY NOT NULL identity(1,1),
		Title  NVARCHAR(50) NOT null,
		[Description]  NVARCHAR(250))
	GO

	CREATE TABLE RewardsOfUsers 
		(ID_User INT NOT NULL,
		 ID_Reward INT NOt Null,
		 CONSTRAINT PK_RewardsOfUsers Primary key (ID_User, ID_Reward),
		 CONSTRAINT FK_RewardsOfUsers_Users foreign key (ID_User) references Users(ID) on delete cascade,
		 CONSTRAINT FK_RewardsOfUsers_Rewards foreign key (ID_Reward) references Rewards(ID) on delete cascade)
	GO
