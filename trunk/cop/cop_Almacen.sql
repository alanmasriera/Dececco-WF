USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Almacen_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Almacen_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Almacen_Insert]
    @id_almacen    int  output,
    @nombre_almacen    varchar  (50),
    @tilde    bit  ,
    @id_cliente    int  
AS

INSERT INTO [dbo].[Almacen]
(
    [nombre_almacen],
    [tilde],
    [id_cliente]
)
VALUES
(
    @nombre_almacen,
    @tilde,
    @id_cliente
)
SET @id_almacen = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Almacen_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Almacen_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Almacen_Delete]
    @id_almacen    int
AS

DELETE FROM [dbo].[Almacen]
WHERE
    [id_almacen]  =  @id_almacen
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Almacen_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Almacen_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Almacen_GetAll]
AS

SELECT TOP 100
    [id_almacen] AS [Id almacen] ,
    RTRIM(nombre_almacen) AS [Nombre almacen] ,
    [tilde] AS [Tilde] ,
    [id_cliente] AS [Id cliente]
FROM
    [dbo].[Almacen]
ORDER BY
    [nombre_almacen]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Almacen_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Almacen_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Almacen_GetCmb]
AS

SELECT
    [id_almacen],
    [nombre_almacen],
    [tilde],
    [id_cliente]
FROM
    [dbo].[Almacen]
ORDER BY
    [nombre_almacen]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Almacen_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Almacen_Update]
GO

CREATE PROCEDURE [dbo].[cop_Almacen_Update]
    @id_almacen    int  output,
    @nombre_almacen    varchar  (50),
    @tilde    bit  ,
    @id_cliente    int  
AS

UPDATE [dbo].[Almacen] SET
    [nombre_almacen] = @nombre_almacen,
    [tilde] = @tilde,
    [id_cliente] = @id_cliente
WHERE
    [id_almacen]  =  @id_almacen
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Almacen_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Almacen_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Almacen_Exist]
    @nombre_almacen    varchar  (50),
    @tilde    bit  ,
    @id_cliente    int  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_almacen
FROM
    [dbo].[Almacen]
WHERE
    [nombre_almacen] = @nombre_almacen AND
    [tilde] = @tilde AND
    [id_cliente] = @id_cliente

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Almacen_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Almacen_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Almacen_GetOne]
    @id_almacen    int
AS

SELECT
    [id_almacen] AS [Id almacen] ,
    [nombre_almacen] AS [Nombre almacen] ,
    [tilde] AS [Tilde] ,
    [id_cliente] AS [Id cliente]
FROM
    [dbo].[Almacen]
WHERE
    [id_almacen]  =  @id_almacen
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Almacen_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Almacen_Find]
GO

CREATE PROCEDURE [dbo].[cop_Almacen_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_almacen] AS [Id almacen] ,
    RTRIM(nombre_almacen) AS [Nombre almacen] ,
    [tilde] AS [Tilde] ,
    [id_cliente] AS [Id cliente]
FROM
    [dbo].[Almacen]
WHERE
    [nombre_almacen] LIKE @nombre+'%'
ORDER BY
    [nombre_almacen]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Almacen_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Almacen_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Almacen_InsertOne]
AS

INSERT INTO [dbo].[Almacen]
(
    [nombre_almacen],
    [tilde],
    [id_cliente]
)
VALUES
(
    'Ninguno',
    0,
     1 
)
GO

