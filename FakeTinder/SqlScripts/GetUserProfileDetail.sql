USE [Dating]
GO
CREATE PROCEDURE [dbo].[usp_GetUserProfileDetail]
AS BEGIN
SELECT [UserProfile].[Id], [UserProfile].[UserName], [UserProfile].[BirthDate], [UserProfile].[Height],
	[UserProfile].[AboutMe], [City].[CityName] AS [City], [Gender].[GenderName] AS Gender, [Users].[FirstName], [Users].[LastName]
	FROM UserProfile
	JOIN [Users] ON [UserProfile].[UsersId] = [Users].[Id]
	 JOIN [City] ON [UserProfile].[CityId] = [City].[Id]
	 JOIN [Gender] ON [UserProfile].[GenderId] = [Gender].[Id]	
END;