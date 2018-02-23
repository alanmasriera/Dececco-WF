USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Usuario_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Usuario_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Usuario_Insert]
    @id_usuario    int  output,
    @nombre_usuario    varchar  (50),
    @password_usuario    varchar  (50),
    @id_grupo_usuario    int  ,
    @legajo    varchar  (50),
    @apellido    varchar  (50),
    @nombre    varchar  (50),
    @session_activa    datetime  
AS

INSERT INTO [dbo].[Usuario]
(
    [nombre_usuario],
    [password_usuario],
    [id_grupo_usuario],
    [legajo],
    [apellido],
    [nombre],
    [session_activa]
)
VALUES
(
    @nombre_usuario,
    @password_usuario,
    @id_grupo_usuario,
    @legajo,
    @apellido,
    @nombre,
    @session_activa
)
SET @id_usuario = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Usuario_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Usuario_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Usuario_Delete]
    @id_usuario    int
AS

DELETE FROM [dbo].[Usuario]
WHERE
    [id_usuario]  =  @id_usuario
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Usuario_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Usuario_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Usuario_GetAll]
AS

SELECT TOP 100
    [id_usuario] AS [Id usuario] ,
    RTRIM(nombre_usuario) AS [Nombre usuario] ,
    RTRIM(password_usuario) AS [Password usuario] ,
    [id_grupo_usuario] AS [Id grupo usuario] ,
    RTRIM(legajo) AS [Legajo] ,
    RTRIM(apellido) AS [Apellido] ,
    RTRIM(nombre) AS [Nombre] ,
    [session_activa] AS [Session activa]
FROM
    [dbo].[Usuario]
ORDER BY
    [nombre_usuario]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Usuario_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Usuario_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Usuario_GetCmb]
AS

SELECT
    [id_usuario],
    [nombre_usuario],
    [password_usuario],
    [id_grupo_usuario],
    [legajo],
    [apellido],
    [nombre],
    [session_activa]
FROM
    [dbo].[Usuario]
ORDER BY
    [nombre_usuario]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Usuario_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Usuario_Update]
GO

CREATE PROCEDURE [dbo].[cop_Usuario_Update]
    @id_usuario    int  output,
    @nombre_usuario    varchar  (50),
    @password_usuario    varchar  (50),
    @id_grupo_usuario    int  ,
    @legajo    varchar  (50),
    @apellido    varchar  (50),
    @nombre    varchar  (50),
    @session_activa    datetime  
AS

UPDATE [dbo].[Usuario] SET
    [nombre_usuario] = @nombre_usuario,
    [password_usuario] = @password_usuario,
    [id_grupo_usuario] = @id_grupo_usuario,
    [legajo] = @legajo,
    [apellido] = @apellido,
    [nombre] = @nombre,
    [session_activa] = @session_activa
WHERE
    [id_usuario]  =  @id_usuario
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Usuario_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Usuario_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Usuario_Exist]
    @nombre_usuario    varchar  (50),
    @password_usuario    varchar  (50),
    @id_grupo_usuario    int  ,
    @legajo    varchar  (50),
    @apellido    varchar  (50),
    @nombre    varchar  (50),
    @session_activa    datetime  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_usuario
FROM
    [dbo].[Usuario]
WHERE
    [nombre_usuario] = @nombre_usuario AND
    [password_usuario] = @password_usuario AND
    [id_grupo_usuario] = @id_grupo_usuario AND
    [legajo] = @legajo AND
    [apellido] = @apellido AND
    [nombre] = @nombre AND
    [session_activa] = @session_activa

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Usuario_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Usuario_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Usuario_GetOne]
    @id_usuario    int
AS

SELECT
    [id_usuario] AS [Id usuario] ,
    [nombre_usuario] AS [Nombre usuario] ,
    [password_usuario] AS [Password usuario] ,
    [id_grupo_usuario] AS [Id grupo usuario] ,
    [legajo] AS [Legajo] ,
    [apellido] AS [Apellido] ,
    [nombre] AS [Nombre] ,
    [session_activa] AS [Session activa]
FROM
    [dbo].[Usuario]
WHERE
    [id_usuario]  =  @id_usuario
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Usuario_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Usuario_Find]
GO

CREATE PROCEDURE [dbo].[cop_Usuario_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_usuario] AS [Id usuario] ,
    RTRIM(nombre_usuario) AS [Nombre usuario] ,
    RTRIM(password_usuario) AS [Password usuario] ,
    [id_grupo_usuario] AS [Id grupo usuario] ,
    RTRIM(legajo) AS [Legajo] ,
    RTRIM(apellido) AS [Apellido] ,
    RTRIM(nombre) AS [Nombre] ,
    [session_activa] AS [Session activa]
FROM
    [dbo].[Usuario]
WHERE
    [nombre_usuario] LIKE @nombre+'%'
ORDER BY
    [nombre_usuario]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Usuario_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Usuario_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Usuario_InsertOne]
AS

INSERT INTO [dbo].[Usuario]
(
    [nombre_usuario],
    [password_usuario],
    [id_grupo_usuario],
    [legajo],
    [apellido],
    [nombre],
    [session_activa]
)
VALUES
(
    'Ninguno',
    'Ninguno',
    1,
    'Ninguno',
    'Ninguno',
    'Ninguno',
    '01-01-2000'
)
GO

