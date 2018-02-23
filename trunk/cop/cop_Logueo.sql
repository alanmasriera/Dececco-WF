USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Logueo_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Logueo_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Logueo_Insert]
    @id_logueo    int  output,
    @id_usuario    int  ,
    @fecha    datetime  
AS

INSERT INTO [dbo].[Logueo]
(
    [id_usuario],
    [fecha]
)
VALUES
(
    @id_usuario,
    @fecha
)
SET @id_logueo = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Logueo_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Logueo_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Logueo_Delete]
    @id_logueo    int
AS

DELETE FROM [dbo].[Logueo]
WHERE
    [id_logueo]  =  @id_logueo
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Logueo_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Logueo_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Logueo_GetAll]
AS

SELECT TOP 100
    [id_logueo] AS [Id logueo] ,
    [id_usuario] AS [Id usuario] ,
    [fecha] AS [Fecha]
FROM
    [dbo].[Logueo]
ORDER BY
    [id_usuario]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Logueo_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Logueo_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Logueo_GetCmb]
AS

SELECT
    [id_logueo],
    [id_usuario],
    [fecha]
FROM
    [dbo].[Logueo]
ORDER BY
    [id_usuario]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Logueo_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Logueo_Update]
GO

CREATE PROCEDURE [dbo].[cop_Logueo_Update]
    @id_logueo    int  output,
    @id_usuario    int  ,
    @fecha    datetime  
AS

UPDATE [dbo].[Logueo] SET
    [id_usuario] = @id_usuario,
    [fecha] = @fecha
WHERE
    [id_logueo]  =  @id_logueo
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Logueo_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Logueo_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Logueo_Exist]
    @id_usuario    int  ,
    @fecha    datetime  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_logueo
FROM
    [dbo].[Logueo]
WHERE
    [id_usuario] = @id_usuario AND
    [fecha] = @fecha

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Logueo_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Logueo_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Logueo_GetOne]
    @id_logueo    int
AS

SELECT
    [id_logueo] AS [Id logueo] ,
    [id_usuario] AS [Id usuario] ,
    [fecha] AS [Fecha]
FROM
    [dbo].[Logueo]
WHERE
    [id_logueo]  =  @id_logueo
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Logueo_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Logueo_Find]
GO

CREATE PROCEDURE [dbo].[cop_Logueo_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_logueo] AS [Id logueo] ,
    [id_usuario] AS [Id usuario] ,
    [fecha] AS [Fecha]
FROM
    [dbo].[Logueo]
WHERE
    [id_usuario] LIKE @nombre+'%'
ORDER BY
    [id_usuario]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Logueo_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Logueo_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Logueo_InsertOne]
AS

INSERT INTO [dbo].[Logueo]
(
    [id_usuario],
    [fecha]
)
VALUES
(
    1,
    '01-01-2000'
)
GO

