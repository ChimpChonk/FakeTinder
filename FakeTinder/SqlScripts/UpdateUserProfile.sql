USE [Dating]
GO
CREATE PROCEDURE [dbo].[usp_UpdateUserProfilByUserId] @birthdate DATETIME, @height INT, @cityid int, @genderid int, @aboutme NVARCHAR(255), @usersid INT
AS
BEGIN
    UPDATE [dbo].[UserProfile] set
    BirthDate = @birthdate,
    Height = @height,
    AboutMe = @aboutme,
    CityId = @cityid,
    GenderId = @genderid
    WHERE UsersId = @usersid
END