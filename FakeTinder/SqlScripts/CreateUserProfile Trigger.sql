USE [Dating]
GO 

CREATE TRIGGER [dbo].[trg_CreateUserProfile]
ON [dbo].[Users]
AFTER INSERT 
AS 
BEGIN 
	
	DECLARE @userId int
	DECLARE @userName NVARCHAR(50)
	DECLARE @birthDate DATETIME

	SELECT @userId = inserted.Id,
	@userName = [inserted].[Login],
	@birthDate = inserted.CreateDate
	FROM inserted

	INSERT INTO [dbo].[UserProfile] (UsersId, UserName, BirthDate)
	VALUES (@userId, @userName, @birthDate)
END;

--DROP TRIGGER trg_CreateUserProfile;
