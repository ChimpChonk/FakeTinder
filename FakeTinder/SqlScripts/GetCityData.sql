USE [Dating]
GO
CREATE PROCEDURE [dbo].[usp_GetCityData]
AS BEGIN
SELECT [Id], [CityName] FROM [Dating].[dbo].[City]
END