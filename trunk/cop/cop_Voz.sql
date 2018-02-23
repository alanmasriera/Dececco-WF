USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Voz_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Voz_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Voz_Insert]
    @id_voz    int  output,
    @nombre_voz    varchar  (500),
    @icono    varchar  (5000),
    @codigo    varchar  (50),
    @codigo_2    varchar  (50),
    @ponderacion    decimal  (18,2),
    @random    decimal  (18,0),
    @corresp    bit  
AS

INSERT INTO [dbo].[Voz]
(
    [nombre_voz],
    [icono],
    [codigo],
    [codigo_2],
    [ponderacion],
    [random],
    [corresp]
)
VALUES
(
    @nombre_voz,
    @icono,
    @codigo,
    @codigo_2,
    @ponderacion,
    @random,
    @corresp
)
SET @id_voz = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Voz_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Voz_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Voz_Delete]
    @id_voz    int
AS

DELETE FROM [dbo].[Voz]
WHERE
    [id_voz]  =  @id_voz
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Voz_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Voz_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Voz_GetAll]
AS

SELECT TOP 100
    [id_voz] AS [Id voz] ,
    RTRIM(nombre_voz) AS [Nombre voz] ,
    RTRIM(icono) AS [Icono] ,
    RTRIM(codigo) AS [Codigo] ,
    RTRIM(codigo_2) AS [Codigo 2] ,
    [ponderacion] AS [Ponderacion] ,
    [random] AS [Random] ,
    [corresp] AS [Corresp]
FROM
    [dbo].[Voz]
ORDER BY
    [nombre_voz]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Voz_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Voz_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Voz_GetCmb]
AS

SELECT
    [id_voz],
    [nombre_voz],
    [icono],
    [codigo],
    [codigo_2],
    [ponderacion],
    [random],
    [corresp]
FROM
    [dbo].[Voz]
ORDER BY
    [nombre_voz]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Voz_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Voz_Update]
GO

CREATE PROCEDURE [dbo].[cop_Voz_Update]
    @id_voz    int  output,
    @nombre_voz    varchar  (500),
    @icono    varchar  (5000),
    @codigo    varchar  (50),
    @codigo_2    varchar  (50),
    @ponderacion    decimal  (18,2),
    @random    decimal  (18,0),
    @corresp    bit  
AS

UPDATE [dbo].[Voz] SET
    [nombre_voz] = @nombre_voz,
    [icono] = @icono,
    [codigo] = @codigo,
    [codigo_2] = @codigo_2,
    [ponderacion] = @ponderacion,
    [random] = @random,
    [corresp] = @corresp
WHERE
    [id_voz]  =  @id_voz
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Voz_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Voz_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Voz_Exist]
    @nombre_voz    varchar  (500),
    @icono    varchar  (5000),
    @codigo    varchar  (50),
    @codigo_2    varchar  (50),
    @ponderacion    decimal  (18,2),
    @random    decimal  (18,0),
    @corresp    bit  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_voz
FROM
    [dbo].[Voz]
WHERE
    [nombre_voz] = @nombre_voz AND
    [icono] = @icono AND
    [codigo] = @codigo AND
    [codigo_2] = @codigo_2 AND
    [ponderacion] = @ponderacion AND
    [random] = @random AND
    [corresp] = @corresp

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Voz_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Voz_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Voz_GetOne]
    @id_voz    int
AS

SELECT
    [id_voz] AS [Id voz] ,
    [nombre_voz] AS [Nombre voz] ,
    [icono] AS [Icono] ,
    [codigo] AS [Codigo] ,
    [codigo_2] AS [Codigo 2] ,
    [ponderacion] AS [Ponderacion] ,
    [random] AS [Random] ,
    [corresp] AS [Corresp]
FROM
    [dbo].[Voz]
WHERE
    [id_voz]  =  @id_voz
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Voz_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Voz_Find]
GO

CREATE PROCEDURE [dbo].[cop_Voz_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_voz] AS [Id voz] ,
    RTRIM(nombre_voz) AS [Nombre voz] ,
    RTRIM(icono) AS [Icono] ,
    RTRIM(codigo) AS [Codigo] ,
    RTRIM(codigo_2) AS [Codigo 2] ,
    [ponderacion] AS [Ponderacion] ,
    [random] AS [Random] ,
    [corresp] AS [Corresp]
FROM
    [dbo].[Voz]
WHERE
    [nombre_voz] LIKE @nombre+'%'
ORDER BY
    [nombre_voz]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Voz_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Voz_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Voz_InsertOne]
AS

INSERT INTO [dbo].[Voz]
(
    [nombre_voz],
    [icono],
    [codigo],
    [codigo_2],
    [ponderacion],
    [random],
    [corresp]
)
VALUES
(
    'Ninguno',
    'Ninguno',
    'Ninguno',
    'Ninguno',
    0,
    0,
     0 
)
GO

