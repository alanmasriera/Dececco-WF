USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Temp_actividad_proyecto_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Temp_actividad_proyecto_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Temp_actividad_proyecto_Insert]
    @id_temp_actividad_proyecto    int  output,
    @id_actividad    int  ,
    @id_proyecto    int  ,
    @id_actividad_proyecto    int  ,
    @id_usuario    int  
AS

INSERT INTO [dbo].[Temp_actividad_proyecto]
(
    [id_actividad],
    [id_proyecto],
    [id_actividad_proyecto],
    [id_usuario]
)
VALUES
(
    @id_actividad,
    @id_proyecto,
    @id_actividad_proyecto,
    @id_usuario
)
SET @id_temp_actividad_proyecto = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Temp_actividad_proyecto_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Temp_actividad_proyecto_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Temp_actividad_proyecto_Delete]
    @id_temp_actividad_proyecto    int
AS

DELETE FROM [dbo].[Temp_actividad_proyecto]
WHERE
    [id_temp_actividad_proyecto]  =  @id_temp_actividad_proyecto
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Temp_actividad_proyecto_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Temp_actividad_proyecto_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Temp_actividad_proyecto_GetAll]
AS

SELECT TOP 100
    [id_temp_actividad_proyecto] AS [Id temp actividad proyecto] ,
    [id_actividad] AS [Id actividad] ,
    [id_proyecto] AS [Id proyecto] ,
    [id_actividad_proyecto] AS [Id actividad proyecto] ,
    [id_usuario] AS [Id usuario]
FROM
    [dbo].[Temp_actividad_proyecto]
ORDER BY
    [id_actividad]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Temp_actividad_proyecto_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Temp_actividad_proyecto_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Temp_actividad_proyecto_GetCmb]
AS

SELECT
    [id_temp_actividad_proyecto],
    [id_actividad],
    [id_proyecto],
    [id_actividad_proyecto],
    [id_usuario]
FROM
    [dbo].[Temp_actividad_proyecto]
ORDER BY
    [id_actividad]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Temp_actividad_proyecto_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Temp_actividad_proyecto_Update]
GO

CREATE PROCEDURE [dbo].[cop_Temp_actividad_proyecto_Update]
    @id_temp_actividad_proyecto    int  output,
    @id_actividad    int  ,
    @id_proyecto    int  ,
    @id_actividad_proyecto    int  ,
    @id_usuario    int  
AS

UPDATE [dbo].[Temp_actividad_proyecto] SET
    [id_actividad] = @id_actividad,
    [id_proyecto] = @id_proyecto,
    [id_actividad_proyecto] = @id_actividad_proyecto,
    [id_usuario] = @id_usuario
WHERE
    [id_temp_actividad_proyecto]  =  @id_temp_actividad_proyecto
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Temp_actividad_proyecto_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Temp_actividad_proyecto_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Temp_actividad_proyecto_Exist]
    @id_actividad    int  ,
    @id_proyecto    int  ,
    @id_actividad_proyecto    int  ,
    @id_usuario    int  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_temp_actividad_proyecto
FROM
    [dbo].[Temp_actividad_proyecto]
WHERE
    [id_actividad] = @id_actividad AND
    [id_proyecto] = @id_proyecto AND
    [id_actividad_proyecto] = @id_actividad_proyecto AND
    [id_usuario] = @id_usuario

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Temp_actividad_proyecto_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Temp_actividad_proyecto_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Temp_actividad_proyecto_GetOne]
    @id_temp_actividad_proyecto    int
AS

SELECT
    [id_temp_actividad_proyecto] AS [Id temp actividad proyecto] ,
    [id_actividad] AS [Id actividad] ,
    [id_proyecto] AS [Id proyecto] ,
    [id_actividad_proyecto] AS [Id actividad proyecto] ,
    [id_usuario] AS [Id usuario]
FROM
    [dbo].[Temp_actividad_proyecto]
WHERE
    [id_temp_actividad_proyecto]  =  @id_temp_actividad_proyecto
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Temp_actividad_proyecto_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Temp_actividad_proyecto_Find]
GO

CREATE PROCEDURE [dbo].[cop_Temp_actividad_proyecto_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_temp_actividad_proyecto] AS [Id temp actividad proyecto] ,
    [id_actividad] AS [Id actividad] ,
    [id_proyecto] AS [Id proyecto] ,
    [id_actividad_proyecto] AS [Id actividad proyecto] ,
    [id_usuario] AS [Id usuario]
FROM
    [dbo].[Temp_actividad_proyecto]
WHERE
    [id_actividad] LIKE @nombre+'%'
ORDER BY
    [id_actividad]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Temp_actividad_proyecto_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Temp_actividad_proyecto_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Temp_actividad_proyecto_InsertOne]
AS

INSERT INTO [dbo].[Temp_actividad_proyecto]
(
    [id_actividad],
    [id_proyecto],
    [id_actividad_proyecto],
    [id_usuario]
)
VALUES
(
    1,
    1,
    1,
     1 
)
GO

