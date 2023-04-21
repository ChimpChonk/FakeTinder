USE [Dating]
GO
CREATE PROCEDURE [dbo].[usp_DeleteUser] @Id int
AS
BEGIN
DELETE FROM [dbo].[Users] WHERE Id = @Id
END