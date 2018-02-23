USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Condicion_venta_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Condicion_venta_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Condicion_venta_Insert]
    @id_condicion_venta    int  output,
    @nombre_condicion_venta    varchar  (50)
AS

INSERT INTO [dbo].[Condicion_venta]
(
    [nombre_condicion_venta]
)
VALUES
(
    @nombre_condicion_venta
)
SET @id_condicion_venta = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Condicion_venta_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Condicion_venta_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Condicion_venta_Delete]
    @id_condicion_venta    int
AS

DELETE FROM [dbo].[Condicion_venta]
WHERE
    [id_condicion_venta]  =  @id_condicion_venta
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Condicion_venta_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Condicion_venta_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Condicion_venta_GetAll]
AS

SELECT TOP 100
    [id_condicion_venta] AS [Id condicion venta] ,
    RTRIM(nombre_condicion_venta) AS [Nombre condicion venta]
FROM
    [dbo].[Condicion_venta]
ORDER BY
    [nombre_condicion_venta]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Condicion_venta_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Condicion_venta_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Condicion_venta_GetCmb]
AS

SELECT
    [id_condicion_venta],
    [nombre_condicion_venta]
FROM
    [dbo].[Condicion_venta]
ORDER BY
    [nombre_condicion_venta]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Condicion_venta_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Condicion_venta_Update]
GO

CREATE PROCEDURE [dbo].[cop_Condicion_venta_Update]
    @id_condicion_venta    int  output,
    @nombre_condicion_venta    varchar  (50)
AS

UPDATE [dbo].[Condicion_venta] SET
    [nombre_condicion_venta] = @nombre_condicion_venta
WHERE
    [id_condicion_venta]  =  @id_condicion_venta
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Condicion_venta_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Condicion_venta_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Condicion_venta_Exist]
    @nombre_condicion_venta    varchar  (50)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_condicion_venta
FROM
    [dbo].[Condicion_venta]
WHERE
    [nombre_condicion_venta] = @nombre_condicion_venta

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Condicion_venta_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Condicion_venta_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Condicion_venta_GetOne]
    @id_condicion_venta    int
AS

SELECT
    [id_condicion_venta] AS [Id condicion venta] ,
    [nombre_condicion_venta] AS [Nombre condicion venta]
FROM
    [dbo].[Condicion_venta]
WHERE
    [id_condicion_venta]  =  @id_condicion_venta
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Condicion_venta_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Condicion_venta_Find]
GO

CREATE PROCEDURE [dbo].[cop_Condicion_venta_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_condicion_venta] AS [Id condicion venta] ,
    RTRIM(nombre_condicion_venta) AS [Nombre condicion venta]
FROM
    [dbo].[Condicion_venta]
WHERE
    [nombre_condicion_venta] LIKE @nombre+'%'
ORDER BY
    [nombre_condicion_venta]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Condicion_venta_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Condicion_venta_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Condicion_venta_InsertOne]
AS

INSERT INTO [dbo].[Condicion_venta]
(
    [nombre_condicion_venta]
)
VALUES
(
    'Ninguno'
)
GO

