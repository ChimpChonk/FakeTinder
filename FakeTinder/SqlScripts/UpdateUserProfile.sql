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
--USE [DATING]
--GO 
--CREATE PROCEDURE [dbo].[usp_UpdateUserProfile]
--	@Id INT,
--	@UserName NVARCHAR(50),
--	@BirthDate DATETIME,
--	@Height INT,
--	@AboutMe NVARCHAR(255),
--	@CityId INT,
--	@GenderId INT
--AS
--BEGIN
--	UPDATE UserProfile
--	SET UserName = @UserName,
--		BirthDate = @BirthDate,
--		Height = @Height,
--		AboutMe = @AboutMe,
--		CityId = @CityId,
--		GenderId = @GenderId
--	WHERE Id = @Id
--END

