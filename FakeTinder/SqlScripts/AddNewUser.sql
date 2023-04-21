USE [Dating]
GO
CREATE PROCEDURE [dbo].[usp_AddNewUser]
	@FirstName nvarchar(50),
	@LastName nvarchar(50),
	@Email nvarchar(50),
	@Login nvarchar(50),
	@Password nvarchar(50),
	@Password2 nvarchar(50),
	@CreateDate datetime
	AS
	BEGIN
	INSERT INTO [Users] (FirstName, LastName, Email, [Login], [Password], [Password2], CreateDate)
	VALUES (@FirstName, @LastName, @Email, @Login, @Password, @Password2, @CreateDate)
	END