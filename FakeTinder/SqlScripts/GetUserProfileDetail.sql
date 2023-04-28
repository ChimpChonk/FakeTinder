USE [Dating]
GO
CREATE PROCEDURE [dbo].[usp_GetUserProfileDetail]
AS BEGIN
SELECT 
        up.Id as ProfileId, 
        up.UserName, 
        up.BirthDate, 
        up.Height, 
        up.AboutMe, 
        c.CityName, 
        g.GenderName, 
        u.FirstName, 
        u.LastName, 
        u.Email 
    FROM UserProfile up
    JOIN Users u ON u.Id = up.UsersId
    JOIN Gender g ON g.Id = up.GenderId
    JOIN City c ON c.Id = up.CityId
END;