USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Modificacion_arbol_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Modificacion_arbol_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Modificacion_arbol_Insert]
    @id_modificacion_arbol    int  output,
    @nombre_modificacion_arbol    varchar  (500),
    @id_usuario    int  ,
    @realizado    bit  ,
    @id_actividad    int  ,
    @id_proyecto    int  ,
    @id_actividad_proyecto    int  ,
    @tipo_nodo    char  (1),
    @nodo    decimal  (18,0),
    @nodo_padre    decimal  (18,0),
    @nombre    varchar  (50),
    @id_usuario_modificador    int  
AS

INSERT INTO [dbo].[Modificacion_arbol]
(
    [nombre_modificacion_arbol],
    [id_usuario],
    [realizado],
    [id_actividad],
    [id_proyecto],
    [id_actividad_proyecto],
    [tipo_nodo],
    [nodo],
    [nodo_padre],
    [nombre],
    [id_usuario_modificador]
)
VALUES
(
    @nombre_modificacion_arbol,
    @id_usuario,
    @realizado,
    @id_actividad,
    @id_proyecto,
    @id_actividad_proyecto,
    @tipo_nodo,
    @nodo,
    @nodo_padre,
    @nombre,
    @id_usuario_modificador
)
SET @id_modificacion_arbol = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Modificacion_arbol_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Modificacion_arbol_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Modificacion_arbol_Delete]
    @id_modificacion_arbol    int
AS

DELETE FROM [dbo].[Modificacion_arbol]
WHERE
    [id_modificacion_arbol]  =  @id_modificacion_arbol
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Modificacion_arbol_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Modificacion_arbol_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Modificacion_arbol_GetAll]
AS

SELECT TOP 100
    [id_modificacion_arbol] AS [Id modificacion arbol] ,
    RTRIM(nombre_modificacion_arbol) AS [Nombre modificacion arbol] ,
    [id_usuario] AS [Id usuario] ,
    [realizado] AS [Realizado] ,
    [id_actividad] AS [Id actividad] ,
    [id_proyecto] AS [Id proyecto] ,
    [id_actividad_proyecto] AS [Id actividad proyecto] ,
    [tipo_nodo] AS [Tipo nodo] ,
    [nodo] AS [Nodo] ,
    [nodo_padre] AS [Nodo padre] ,
    RTRIM(nombre) AS [Nombre] ,
    [id_usuario_modificador] AS [Id usuario modificador]
FROM
    [dbo].[Modificacion_arbol]
ORDER BY
    [nombre_modificacion_arbol]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Modificacion_arbol_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Modificacion_arbol_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Modificacion_arbol_GetCmb]
AS

SELECT
    [id_modificacion_arbol],
    [nombre_modificacion_arbol],
    [id_usuario],
    [realizado],
    [id_actividad],
    [id_proyecto],
    [id_actividad_proyecto],
    [tipo_nodo],
    [nodo],
    [nodo_padre],
    [nombre],
    [id_usuario_modificador]
FROM
    [dbo].[Modificacion_arbol]
ORDER BY
    [nombre_modificacion_arbol]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Modificacion_arbol_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Modificacion_arbol_Update]
GO

CREATE PROCEDURE [dbo].[cop_Modificacion_arbol_Update]
    @id_modificacion_arbol    int  output,
    @nombre_modificacion_arbol    varchar  (500),
    @id_usuario    int  ,
    @realizado    bit  ,
    @id_actividad    int  ,
    @id_proyecto    int  ,
    @id_actividad_proyecto    int  ,
    @tipo_nodo    char  (1),
    @nodo    decimal  (18,0),
    @nodo_padre    decimal  (18,0),
    @nombre    varchar  (50),
    @id_usuario_modificador    int  
AS

UPDATE [dbo].[Modificacion_arbol] SET
    [nombre_modificacion_arbol] = @nombre_modificacion_arbol,
    [id_usuario] = @id_usuario,
    [realizado] = @realizado,
    [id_actividad] = @id_actividad,
    [id_proyecto] = @id_proyecto,
    [id_actividad_proyecto] = @id_actividad_proyecto,
    [tipo_nodo] = @tipo_nodo,
    [nodo] = @nodo,
    [nodo_padre] = @nodo_padre,
    [nombre] = @nombre,
    [id_usuario_modificador] = @id_usuario_modificador
WHERE
    [id_modificacion_arbol]  =  @id_modificacion_arbol
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Modificacion_arbol_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Modificacion_arbol_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Modificacion_arbol_Exist]
    @nombre_modificacion_arbol    varchar  (500),
    @id_usuario    int  ,
    @realizado    bit  ,
    @id_actividad    int  ,
    @id_proyecto    int  ,
    @id_actividad_proyecto    int  ,
    @tipo_nodo    char  (1),
    @nodo    decimal  (18,0),
    @nodo_padre    decimal  (18,0),
    @nombre    varchar  (50),
    @id_usuario_modificador    int  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_modificacion_arbol
FROM
    [dbo].[Modificacion_arbol]
WHERE
    [nombre_modificacion_arbol] = @nombre_modificacion_arbol AND
    [id_usuario] = @id_usuario AND
    [realizado] = @realizado AND
    [id_actividad] = @id_actividad AND
    [id_proyecto] = @id_proyecto AND
    [id_actividad_proyecto] = @id_actividad_proyecto AND
    [tipo_nodo] = @tipo_nodo AND
    [nodo] = @nodo AND
    [nodo_padre] = @nodo_padre AND
    [nombre] = @nombre AND
    [id_usuario_modificador] = @id_usuario_modificador

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Modificacion_arbol_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Modificacion_arbol_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Modificacion_arbol_GetOne]
    @id_modificacion_arbol    int
AS

SELECT
    [id_modificacion_arbol] AS [Id modificacion arbol] ,
    [nombre_modificacion_arbol] AS [Nombre modificacion arbol] ,
    [id_usuario] AS [Id usuario] ,
    [realizado] AS [Realizado] ,
    [id_actividad] AS [Id actividad] ,
    [id_proyecto] AS [Id proyecto] ,
    [id_actividad_proyecto] AS [Id actividad proyecto] ,
    [tipo_nodo] AS [Tipo nodo] ,
    [nodo] AS [Nodo] ,
    [nodo_padre] AS [Nodo padre] ,
    [nombre] AS [Nombre] ,
    [id_usuario_modificador] AS [Id usuario modificador]
FROM
    [dbo].[Modificacion_arbol]
WHERE
    [id_modificacion_arbol]  =  @id_modificacion_arbol
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Modificacion_arbol_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Modificacion_arbol_Find]
GO

CREATE PROCEDURE [dbo].[cop_Modificacion_arbol_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_modificacion_arbol] AS [Id modificacion arbol] ,
    RTRIM(nombre_modificacion_arbol) AS [Nombre modificacion arbol] ,
    [id_usuario] AS [Id usuario] ,
    [realizado] AS [Realizado] ,
    [id_actividad] AS [Id actividad] ,
    [id_proyecto] AS [Id proyecto] ,
    [id_actividad_proyecto] AS [Id actividad proyecto] ,
    [tipo_nodo] AS [Tipo nodo] ,
    [nodo] AS [Nodo] ,
    [nodo_padre] AS [Nodo padre] ,
    RTRIM(nombre) AS [Nombre] ,
    [id_usuario_modificador] AS [Id usuario modificador]
FROM
    [dbo].[Modificacion_arbol]
WHERE
    [nombre_modificacion_arbol] LIKE @nombre+'%'
ORDER BY
    [nombre_modificacion_arbol]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Modificacion_arbol_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Modificacion_arbol_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Modificacion_arbol_InsertOne]
AS

INSERT INTO [dbo].[Modificacion_arbol]
(
    [nombre_modificacion_arbol],
    [id_usuario],
    [realizado],
    [id_actividad],
    [id_proyecto],
    [id_actividad_proyecto],
    [tipo_nodo],
    [nodo],
    [nodo_padre],
    [nombre],
    [id_usuario_modificador]
)
VALUES
(
    'Ninguno',
    1,
    0,
    1,
    1,
    1,
    '',
    0,
    0,
    'Ninguno',
     1 
)
GO

