USE [Dating]
GO
CREATE TRIGGER [dbo].[trg_CreateProfilePicture]
ON [dbo].[UserProfile]
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @UserProfileId int;
	SELECT @UserProfileId = inserted.Id FROM inserted;

	INSERT INTO [dbo].[ProfilePictures] (PicURL , UserProfileId)
	VALUES ('https://st3.depositphotos.com/6672868/13701/v/450/depositphotos_137014128-stock-illustration-user-profile-icon.jpg', @UserProfileId);
END;