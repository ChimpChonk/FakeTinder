USE [Dating]
GO
CREATE PROCEDURE [dbo].[usp_UpdateUser]
@Id int, 
@FirstName nvarchar(50), 
@LastName nvarchar(50), 
@Email nvarchar(50), 
@Login nvarchar(50), 
@Password nvarchar(50), 
@Password2 nvarchar(50), 
@CreateDate datetime,
@DeleteDate datetime
AS
BEGIN
UPDATE [dbo].[Users]
SET
[FirstName] = @FirstName,
[LastName] = @LastName,
[Email] = @Email,
[Login] = @Login,
[Password] = @Password,
[Password2] = @Password2,
[CreateDate] = @CreateDate,
[DeleteDate] = @DeleteDate
WHERE Id = @Id
END