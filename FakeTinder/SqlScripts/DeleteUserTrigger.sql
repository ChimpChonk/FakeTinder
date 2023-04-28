USE [Dating]
GO

CREATE TRIGGER [dbo].[trg_DeleteUserProfile]
ON [dbo].[UserProfile]
AFTER DELETE
AS BEGIN
SET NOCOUNT ON;
DELETE FROM [dbo].[Users] WHERE Id = (SELECT UsersId FROM deleted)
END;