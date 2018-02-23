USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Codigo_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Codigo_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Codigo_Insert]
    @id_codigo    int  output,
    @nombre_codigo    varchar  (50)
AS

INSERT INTO [dbo].[Codigo]
(
    [nombre_codigo]
)
VALUES
(
    @nombre_codigo
)
SET @id_codigo = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Codigo_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Codigo_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Codigo_Delete]
    @id_codigo    int
AS

DELETE FROM [dbo].[Codigo]
WHERE
    [id_codigo]  =  @id_codigo
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Codigo_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Codigo_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Codigo_GetAll]
AS

SELECT TOP 100
    [id_codigo] AS [Id codigo] ,
    RTRIM(nombre_codigo) AS [Nombre codigo]
FROM
    [dbo].[Codigo]
ORDER BY
    [nombre_codigo]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Codigo_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Codigo_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Codigo_GetCmb]
AS

SELECT
    [id_codigo],
    [nombre_codigo]
FROM
    [dbo].[Codigo]
ORDER BY
    [nombre_codigo]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Codigo_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Codigo_Update]
GO

CREATE PROCEDURE [dbo].[cop_Codigo_Update]
    @id_codigo    int  output,
    @nombre_codigo    varchar  (50)
AS

UPDATE [dbo].[Codigo] SET
    [nombre_codigo] = @nombre_codigo
WHERE
    [id_codigo]  =  @id_codigo
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Codigo_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Codigo_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Codigo_Exist]
    @nombre_codigo    varchar  (50)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_codigo
FROM
    [dbo].[Codigo]
WHERE
    [nombre_codigo] = @nombre_codigo

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Codigo_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Codigo_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Codigo_GetOne]
    @id_codigo    int
AS

SELECT
    [id_codigo] AS [Id codigo] ,
    [nombre_codigo] AS [Nombre codigo]
FROM
    [dbo].[Codigo]
WHERE
    [id_codigo]  =  @id_codigo
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Codigo_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Codigo_Find]
GO

CREATE PROCEDURE [dbo].[cop_Codigo_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_codigo] AS [Id codigo] ,
    RTRIM(nombre_codigo) AS [Nombre codigo]
FROM
    [dbo].[Codigo]
WHERE
    [nombre_codigo] LIKE @nombre+'%'
ORDER BY
    [nombre_codigo]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Codigo_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Codigo_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Codigo_InsertOne]
AS

INSERT INTO [dbo].[Codigo]
(
    [nombre_codigo]
)
VALUES
(
    'Ninguno'
)
GO

