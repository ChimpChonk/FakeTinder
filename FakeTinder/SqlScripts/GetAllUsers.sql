USE [Dating]
GO 
CREATE PROCEDURE [dbo].[usp_GetAllUsers]
AS BEGIN 
SELECT [Id], [FirstName], [LastName], [Email], [Login], [Password], [Password2], [CreateDate] FROM [Dating].[dbo].[Users]
END