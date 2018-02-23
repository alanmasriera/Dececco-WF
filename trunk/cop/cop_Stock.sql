USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Stock_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Stock_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Stock_Insert]
    @id_stock    int  output,
    @id_producto    int  ,
    @id_almacen    int  ,
    @stock    decimal  (18,2),
    @actualizado    bit  ,
    @stock_oferta    decimal  (18,2)
AS

INSERT INTO [dbo].[Stock]
(
    [id_producto],
    [id_almacen],
    [stock],
    [actualizado],
    [stock_oferta]
)
VALUES
(
    @id_producto,
    @id_almacen,
    @stock,
    @actualizado,
    @stock_oferta
)
SET @id_stock = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Stock_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Stock_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Stock_Delete]
    @id_stock    int
AS

DELETE FROM [dbo].[Stock]
WHERE
    [id_stock]  =  @id_stock
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Stock_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Stock_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Stock_GetAll]
AS

SELECT TOP 100
    [id_stock] AS [Id stock] ,
    [id_producto] AS [Id producto] ,
    [id_almacen] AS [Id almacen] ,
    [stock] AS [Stock] ,
    [actualizado] AS [Actualizado] ,
    [stock_oferta] AS [Stock oferta]
FROM
    [dbo].[Stock]
ORDER BY
    [id_producto]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Stock_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Stock_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Stock_GetCmb]
AS

SELECT
    [id_stock],
    [id_producto],
    [id_almacen],
    [stock],
    [actualizado],
    [stock_oferta]
FROM
    [dbo].[Stock]
ORDER BY
    [id_producto]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Stock_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Stock_Update]
GO

CREATE PROCEDURE [dbo].[cop_Stock_Update]
    @id_stock    int  output,
    @id_producto    int  ,
    @id_almacen    int  ,
    @stock    decimal  (18,2),
    @actualizado    bit  ,
    @stock_oferta    decimal  (18,2)
AS

UPDATE [dbo].[Stock] SET
    [id_producto] = @id_producto,
    [id_almacen] = @id_almacen,
    [stock] = @stock,
    [actualizado] = @actualizado,
    [stock_oferta] = @stock_oferta
WHERE
    [id_stock]  =  @id_stock
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Stock_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Stock_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Stock_Exist]
    @id_producto    int  ,
    @id_almacen    int  ,
    @stock    decimal  (18,2),
    @actualizado    bit  ,
    @stock_oferta    decimal  (18,2)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_stock
FROM
    [dbo].[Stock]
WHERE
    [id_producto] = @id_producto AND
    [id_almacen] = @id_almacen AND
    [stock] = @stock AND
    [actualizado] = @actualizado AND
    [stock_oferta] = @stock_oferta

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Stock_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Stock_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Stock_GetOne]
    @id_stock    int
AS

SELECT
    [id_stock] AS [Id stock] ,
    [id_producto] AS [Id producto] ,
    [id_almacen] AS [Id almacen] ,
    [stock] AS [Stock] ,
    [actualizado] AS [Actualizado] ,
    [stock_oferta] AS [Stock oferta]
FROM
    [dbo].[Stock]
WHERE
    [id_stock]  =  @id_stock
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Stock_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Stock_Find]
GO

CREATE PROCEDURE [dbo].[cop_Stock_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_stock] AS [Id stock] ,
    [id_producto] AS [Id producto] ,
    [id_almacen] AS [Id almacen] ,
    [stock] AS [Stock] ,
    [actualizado] AS [Actualizado] ,
    [stock_oferta] AS [Stock oferta]
FROM
    [dbo].[Stock]
WHERE
    [id_producto] LIKE @nombre+'%'
ORDER BY
    [id_producto]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Stock_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Stock_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Stock_InsertOne]
AS

INSERT INTO [dbo].[Stock]
(
    [id_producto],
    [id_almacen],
    [stock],
    [actualizado],
    [stock_oferta]
)
VALUES
(
    1,
    1,
    0,
    0,
     0 
)
GO

