USE master
GO
	CREATE DATABASE UsersAndRewards
		ON
			(NAME='UsersAndRewards',
			FILENAME='d:\Data base\Users and Rewards\UsersAndRewards.mdf',
			SIZE=5,
			MAXSIZE=10,
			FILEGROWTH=1
			)
		LOG ON
			(NAME='UsersAndRewards-L',
			FILENAME='d:\Data base\Users and Rewards\UsersAndRewards-L.ldf',
			SIZE=1,
			MAXSIZE=10,
			FILEGROWTH=1
			)
	GO