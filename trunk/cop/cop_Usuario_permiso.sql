USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Usuario_permiso_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Usuario_permiso_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Usuario_permiso_Insert]
    @id_usuario_permiso    int  output,
    @id_usuario    int  ,
    @id_permiso    int  ,
    @habilitado    bit  
AS

INSERT INTO [dbo].[Usuario_permiso]
(
    [id_usuario],
    [id_permiso],
    [habilitado]
)
VALUES
(
    @id_usuario,
    @id_permiso,
    @habilitado
)
SET @id_usuario_permiso = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Usuario_permiso_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Usuario_permiso_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Usuario_permiso_Delete]
    @id_usuario_permiso    int
AS

DELETE FROM [dbo].[Usuario_permiso]
WHERE
    [id_usuario_permiso]  =  @id_usuario_permiso
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Usuario_permiso_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Usuario_permiso_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Usuario_permiso_GetAll]
AS

SELECT TOP 100
    [id_usuario_permiso] AS [Id usuario permiso] ,
    [id_usuario] AS [Id usuario] ,
    [id_permiso] AS [Id permiso] ,
    [habilitado] AS [Habilitado]
FROM
    [dbo].[Usuario_permiso]
ORDER BY
    [id_usuario]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Usuario_permiso_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Usuario_permiso_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Usuario_permiso_GetCmb]
AS

SELECT
    [id_usuario_permiso],
    [id_usuario],
    [id_permiso],
    [habilitado]
FROM
    [dbo].[Usuario_permiso]
ORDER BY
    [id_usuario]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Usuario_permiso_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Usuario_permiso_Update]
GO

CREATE PROCEDURE [dbo].[cop_Usuario_permiso_Update]
    @id_usuario_permiso    int  output,
    @id_usuario    int  ,
    @id_permiso    int  ,
    @habilitado    bit  
AS

UPDATE [dbo].[Usuario_permiso] SET
    [id_usuario] = @id_usuario,
    [id_permiso] = @id_permiso,
    [habilitado] = @habilitado
WHERE
    [id_usuario_permiso]  =  @id_usuario_permiso
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Usuario_permiso_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Usuario_permiso_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Usuario_permiso_Exist]
    @id_usuario    int  ,
    @id_permiso    int  ,
    @habilitado    bit  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_usuario_permiso
FROM
    [dbo].[Usuario_permiso]
WHERE
    [id_usuario] = @id_usuario AND
    [id_permiso] = @id_permiso AND
    [habilitado] = @habilitado

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Usuario_permiso_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Usuario_permiso_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Usuario_permiso_GetOne]
    @id_usuario_permiso    int
AS

SELECT
    [id_usuario_permiso] AS [Id usuario permiso] ,
    [id_usuario] AS [Id usuario] ,
    [id_permiso] AS [Id permiso] ,
    [habilitado] AS [Habilitado]
FROM
    [dbo].[Usuario_permiso]
WHERE
    [id_usuario_permiso]  =  @id_usuario_permiso
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Usuario_permiso_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Usuario_permiso_Find]
GO

CREATE PROCEDURE [dbo].[cop_Usuario_permiso_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_usuario_permiso] AS [Id usuario permiso] ,
    [id_usuario] AS [Id usuario] ,
    [id_permiso] AS [Id permiso] ,
    [habilitado] AS [Habilitado]
FROM
    [dbo].[Usuario_permiso]
WHERE
    [id_usuario] LIKE @nombre+'%'
ORDER BY
    [id_usuario]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Usuario_permiso_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Usuario_permiso_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Usuario_permiso_InsertOne]
AS

INSERT INTO [dbo].[Usuario_permiso]
(
    [id_usuario],
    [id_permiso],
    [habilitado]
)
VALUES
(
    1,
    1,
     0 
)
GO

