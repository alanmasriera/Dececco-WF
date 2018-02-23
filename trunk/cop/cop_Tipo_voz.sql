USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_voz_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_voz_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_voz_Insert]
    @id_tipo_voz    int  output,
    @nombre_tipo_voz    varchar  (50),
    @codigo    varchar  (50),
    @ponderacion    decimal  (18,2),
    @id_control    int  ,
    @nro    int  ,
    @indice    int  
AS

INSERT INTO [dbo].[Tipo_voz]
(
    [nombre_tipo_voz],
    [codigo],
    [ponderacion],
    [id_control],
    [nro],
    [indice]
)
VALUES
(
    @nombre_tipo_voz,
    @codigo,
    @ponderacion,
    @id_control,
    @nro,
    @indice
)
SET @id_tipo_voz = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_voz_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_voz_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_voz_Delete]
    @id_tipo_voz    int
AS

DELETE FROM [dbo].[Tipo_voz]
WHERE
    [id_tipo_voz]  =  @id_tipo_voz
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_voz_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_voz_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_voz_GetAll]
AS

SELECT TOP 100
    [id_tipo_voz] AS [Id tipo voz] ,
    RTRIM(nombre_tipo_voz) AS [Nombre tipo voz] ,
    RTRIM(codigo) AS [Codigo] ,
    [ponderacion] AS [Ponderacion] ,
    [id_control] AS [Id control] ,
    [nro] AS [Nro] ,
    [indice] AS [Indice]
FROM
    [dbo].[Tipo_voz]
ORDER BY
    [nombre_tipo_voz]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_voz_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_voz_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_voz_GetCmb]
AS

SELECT
    [id_tipo_voz],
    [nombre_tipo_voz],
    [codigo],
    [ponderacion],
    [id_control],
    [nro],
    [indice]
FROM
    [dbo].[Tipo_voz]
ORDER BY
    [nombre_tipo_voz]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_voz_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_voz_Update]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_voz_Update]
    @id_tipo_voz    int  output,
    @nombre_tipo_voz    varchar  (50),
    @codigo    varchar  (50),
    @ponderacion    decimal  (18,2),
    @id_control    int  ,
    @nro    int  ,
    @indice    int  
AS

UPDATE [dbo].[Tipo_voz] SET
    [nombre_tipo_voz] = @nombre_tipo_voz,
    [codigo] = @codigo,
    [ponderacion] = @ponderacion,
    [id_control] = @id_control,
    [nro] = @nro,
    [indice] = @indice
WHERE
    [id_tipo_voz]  =  @id_tipo_voz
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_voz_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_voz_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_voz_Exist]
    @nombre_tipo_voz    varchar  (50),
    @codigo    varchar  (50),
    @ponderacion    decimal  (18,2),
    @id_control    int  ,
    @nro    int  ,
    @indice    int  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_tipo_voz
FROM
    [dbo].[Tipo_voz]
WHERE
    [nombre_tipo_voz] = @nombre_tipo_voz AND
    [codigo] = @codigo AND
    [ponderacion] = @ponderacion AND
    [id_control] = @id_control AND
    [nro] = @nro AND
    [indice] = @indice

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_voz_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_voz_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_voz_GetOne]
    @id_tipo_voz    int
AS

SELECT
    [id_tipo_voz] AS [Id tipo voz] ,
    [nombre_tipo_voz] AS [Nombre tipo voz] ,
    [codigo] AS [Codigo] ,
    [ponderacion] AS [Ponderacion] ,
    [id_control] AS [Id control] ,
    [nro] AS [Nro] ,
    [indice] AS [Indice]
FROM
    [dbo].[Tipo_voz]
WHERE
    [id_tipo_voz]  =  @id_tipo_voz
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_voz_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_voz_Find]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_voz_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_tipo_voz] AS [Id tipo voz] ,
    RTRIM(nombre_tipo_voz) AS [Nombre tipo voz] ,
    RTRIM(codigo) AS [Codigo] ,
    [ponderacion] AS [Ponderacion] ,
    [id_control] AS [Id control] ,
    [nro] AS [Nro] ,
    [indice] AS [Indice]
FROM
    [dbo].[Tipo_voz]
WHERE
    [nombre_tipo_voz] LIKE @nombre+'%'
ORDER BY
    [nombre_tipo_voz]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_voz_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_voz_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_voz_InsertOne]
AS

INSERT INTO [dbo].[Tipo_voz]
(
    [nombre_tipo_voz],
    [codigo],
    [ponderacion],
    [id_control],
    [nro],
    [indice]
)
VALUES
(
    'Ninguno',
    'Ninguno',
    0,
    1,
    1,
     1 
)
GO

