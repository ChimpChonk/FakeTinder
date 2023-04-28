USE [Dating]
GO
CREATE PROCEDURE [dbo].[usp_DeleteUserProfile] @Id int
AS
BEGIN
DELETE FROM [dbo].[UserProfile] WHERE Id = @Id
END

