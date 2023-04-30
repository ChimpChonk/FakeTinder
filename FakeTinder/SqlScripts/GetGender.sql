USE [Dating]
GO
CREATE PROCEDURE [dbo].[usp_GetGender]
AS BEGIN
SELECT [Id], [GenderName], [Elaborate] from [Dating].[dbo].[Gender]
END