USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Control_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Control_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Control_Insert]
    @id_control    int  output,
    @nombre_control    varchar  (500),
    @indice    int  
AS

INSERT INTO [dbo].[Control]
(
    [nombre_control],
    [indice]
)
VALUES
(
    @nombre_control,
    @indice
)
SET @id_control = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Control_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Control_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Control_Delete]
    @id_control    int
AS

DELETE FROM [dbo].[Control]
WHERE
    [id_control]  =  @id_control
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Control_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Control_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Control_GetAll]
AS

SELECT TOP 100
    [id_control] AS [Id control] ,
    RTRIM(nombre_control) AS [Nombre control] ,
    [indice] AS [Indice]
FROM
    [dbo].[Control]
ORDER BY
    [nombre_control]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Control_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Control_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Control_GetCmb]
AS

SELECT
    [id_control],
    [nombre_control],
    [indice]
FROM
    [dbo].[Control]
ORDER BY
    [nombre_control]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Control_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Control_Update]
GO

CREATE PROCEDURE [dbo].[cop_Control_Update]
    @id_control    int  output,
    @nombre_control    varchar  (500),
    @indice    int  
AS

UPDATE [dbo].[Control] SET
    [nombre_control] = @nombre_control,
    [indice] = @indice
WHERE
    [id_control]  =  @id_control
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Control_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Control_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Control_Exist]
    @nombre_control    varchar  (500),
    @indice    int  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_control
FROM
    [dbo].[Control]
WHERE
    [nombre_control] = @nombre_control AND
    [indice] = @indice

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Control_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Control_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Control_GetOne]
    @id_control    int
AS

SELECT
    [id_control] AS [Id control] ,
    [nombre_control] AS [Nombre control] ,
    [indice] AS [Indice]
FROM
    [dbo].[Control]
WHERE
    [id_control]  =  @id_control
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Control_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Control_Find]
GO

CREATE PROCEDURE [dbo].[cop_Control_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_control] AS [Id control] ,
    RTRIM(nombre_control) AS [Nombre control] ,
    [indice] AS [Indice]
FROM
    [dbo].[Control]
WHERE
    [nombre_control] LIKE @nombre+'%'
ORDER BY
    [nombre_control]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Control_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Control_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Control_InsertOne]
AS

INSERT INTO [dbo].[Control]
(
    [nombre_control],
    [indice]
)
VALUES
(
    'Ninguno',
     1 
)
GO

