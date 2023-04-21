USE [Dating]
GO

CREATE PROCEDURE [dbo].[usp_GetUserByLoginAndPassword] @login nvarchar(50), @password nvarchar(50)
AS
BEGIN
	SELECT Id,[Login],[Password] from [dbo].Users where [Login] = @login AND [Password] = @password
	end