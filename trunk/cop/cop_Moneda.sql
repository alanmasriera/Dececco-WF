USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Moneda_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Moneda_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Moneda_Insert]
    @id_moneda    int  output,
    @simbolo    varchar  (5),
    @nombre_moneda    varchar  (50),
    @abreviatura    varchar  (50)
AS

INSERT INTO [dbo].[Moneda]
(
    [simbolo],
    [nombre_moneda],
    [abreviatura]
)
VALUES
(
    @simbolo,
    @nombre_moneda,
    @abreviatura
)
SET @id_moneda = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Moneda_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Moneda_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Moneda_Delete]
    @id_moneda    int
AS

DELETE FROM [dbo].[Moneda]
WHERE
    [id_moneda]  =  @id_moneda
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Moneda_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Moneda_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Moneda_GetAll]
AS

SELECT TOP 100
    [id_moneda] AS [Id moneda] ,
    RTRIM(simbolo) AS [Simbolo] ,
    RTRIM(nombre_moneda) AS [Nombre moneda] ,
    RTRIM(abreviatura) AS [Abreviatura]
FROM
    [dbo].[Moneda]
ORDER BY
    [simbolo]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Moneda_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Moneda_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Moneda_GetCmb]
AS

SELECT
    [id_moneda],
    [simbolo],
    [nombre_moneda],
    [abreviatura]
FROM
    [dbo].[Moneda]
ORDER BY
    [simbolo]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Moneda_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Moneda_Update]
GO

CREATE PROCEDURE [dbo].[cop_Moneda_Update]
    @id_moneda    int  output,
    @simbolo    varchar  (5),
    @nombre_moneda    varchar  (50),
    @abreviatura    varchar  (50)
AS

UPDATE [dbo].[Moneda] SET
    [simbolo] = @simbolo,
    [nombre_moneda] = @nombre_moneda,
    [abreviatura] = @abreviatura
WHERE
    [id_moneda]  =  @id_moneda
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Moneda_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Moneda_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Moneda_Exist]
    @simbolo    varchar  (5),
    @nombre_moneda    varchar  (50),
    @abreviatura    varchar  (50)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_moneda
FROM
    [dbo].[Moneda]
WHERE
    [simbolo] = @simbolo AND
    [nombre_moneda] = @nombre_moneda AND
    [abreviatura] = @abreviatura

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Moneda_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Moneda_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Moneda_GetOne]
    @id_moneda    int
AS

SELECT
    [id_moneda] AS [Id moneda] ,
    [simbolo] AS [Simbolo] ,
    [nombre_moneda] AS [Nombre moneda] ,
    [abreviatura] AS [Abreviatura]
FROM
    [dbo].[Moneda]
WHERE
    [id_moneda]  =  @id_moneda
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Moneda_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Moneda_Find]
GO

CREATE PROCEDURE [dbo].[cop_Moneda_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_moneda] AS [Id moneda] ,
    RTRIM(simbolo) AS [Simbolo] ,
    RTRIM(nombre_moneda) AS [Nombre moneda] ,
    RTRIM(abreviatura) AS [Abreviatura]
FROM
    [dbo].[Moneda]
WHERE
    [simbolo] LIKE @nombre+'%'
ORDER BY
    [simbolo]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Moneda_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Moneda_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Moneda_InsertOne]
AS

INSERT INTO [dbo].[Moneda]
(
    [simbolo],
    [nombre_moneda],
    [abreviatura]
)
VALUES
(
    'Ninguno',
    'Ninguno',
    'Ninguno'
)
GO

