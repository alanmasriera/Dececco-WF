USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Precio_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Precio_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Precio_Insert]
    @id_precio    int  output,
    @id_producto    int  ,
    @id_proveedor    int  ,
    @precio    decimal  (18,2),
    @alicuota    decimal  (18,2),
    @iva    decimal  (18,2),
    @impuesto_interno    decimal  (18,2),
    @pack    decimal  (18,2),
    @margen_ganancia    decimal  (18,2),
    @cod_producto_proveedor    varchar  (50),
    @precio_venta_unitario    decimal  (18,2),
    @precio_venta_mayorista    decimal  (18,2),
    @precio_venta_publico    decimal  (18,2),
    @bonificacion1    decimal  (18,2),
    @bonificacion2    decimal  (18,2)
AS

INSERT INTO [dbo].[Precio]
(
    [id_producto],
    [id_proveedor],
    [precio],
    [alicuota],
    [iva],
    [impuesto_interno],
    [pack],
    [margen_ganancia],
    [cod_producto_proveedor],
    [precio_venta_unitario],
    [precio_venta_mayorista],
    [precio_venta_publico],
    [bonificacion1],
    [bonificacion2]
)
VALUES
(
    @id_producto,
    @id_proveedor,
    @precio,
    @alicuota,
    @iva,
    @impuesto_interno,
    @pack,
    @margen_ganancia,
    @cod_producto_proveedor,
    @precio_venta_unitario,
    @precio_venta_mayorista,
    @precio_venta_publico,
    @bonificacion1,
    @bonificacion2
)
SET @id_precio = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Precio_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Precio_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Precio_Delete]
    @id_precio    int
AS

DELETE FROM [dbo].[Precio]
WHERE
    [id_precio]  =  @id_precio
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Precio_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Precio_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Precio_GetAll]
AS

SELECT TOP 100
    [id_precio] AS [Id precio] ,
    [id_producto] AS [Id producto] ,
    [id_proveedor] AS [Id proveedor] ,
    [precio] AS [Precio] ,
    [alicuota] AS [Alicuota] ,
    [iva] AS [Iva] ,
    [impuesto_interno] AS [Impuesto interno] ,
    [pack] AS [Pack] ,
    [margen_ganancia] AS [Margen ganancia] ,
    RTRIM(cod_producto_proveedor) AS [Cod producto proveedor] ,
    [precio_venta_unitario] AS [Precio venta unitario] ,
    [precio_venta_mayorista] AS [Precio venta mayorista] ,
    [precio_venta_publico] AS [Precio venta publico] ,
    [bonificacion1] AS [Bonificacion1] ,
    [bonificacion2] AS [Bonificacion2]
FROM
    [dbo].[Precio]
ORDER BY
    [id_producto]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Precio_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Precio_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Precio_GetCmb]
AS

SELECT
    [id_precio],
    [id_producto],
    [id_proveedor],
    [precio],
    [alicuota],
    [iva],
    [impuesto_interno],
    [pack],
    [margen_ganancia],
    [cod_producto_proveedor],
    [precio_venta_unitario],
    [precio_venta_mayorista],
    [precio_venta_publico],
    [bonificacion1],
    [bonificacion2]
FROM
    [dbo].[Precio]
ORDER BY
    [id_producto]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Precio_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Precio_Update]
GO

CREATE PROCEDURE [dbo].[cop_Precio_Update]
    @id_precio    int  output,
    @id_producto    int  ,
    @id_proveedor    int  ,
    @precio    decimal  (18,2),
    @alicuota    decimal  (18,2),
    @iva    decimal  (18,2),
    @impuesto_interno    decimal  (18,2),
    @pack    decimal  (18,2),
    @margen_ganancia    decimal  (18,2),
    @cod_producto_proveedor    varchar  (50),
    @precio_venta_unitario    decimal  (18,2),
    @precio_venta_mayorista    decimal  (18,2),
    @precio_venta_publico    decimal  (18,2),
    @bonificacion1    decimal  (18,2),
    @bonificacion2    decimal  (18,2)
AS

UPDATE [dbo].[Precio] SET
    [id_producto] = @id_producto,
    [id_proveedor] = @id_proveedor,
    [precio] = @precio,
    [alicuota] = @alicuota,
    [iva] = @iva,
    [impuesto_interno] = @impuesto_interno,
    [pack] = @pack,
    [margen_ganancia] = @margen_ganancia,
    [cod_producto_proveedor] = @cod_producto_proveedor,
    [precio_venta_unitario] = @precio_venta_unitario,
    [precio_venta_mayorista] = @precio_venta_mayorista,
    [precio_venta_publico] = @precio_venta_publico,
    [bonificacion1] = @bonificacion1,
    [bonificacion2] = @bonificacion2
WHERE
    [id_precio]  =  @id_precio
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Precio_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Precio_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Precio_Exist]
    @id_producto    int  ,
    @id_proveedor    int  ,
    @precio    decimal  (18,2),
    @alicuota    decimal  (18,2),
    @iva    decimal  (18,2),
    @impuesto_interno    decimal  (18,2),
    @pack    decimal  (18,2),
    @margen_ganancia    decimal  (18,2),
    @cod_producto_proveedor    varchar  (50),
    @precio_venta_unitario    decimal  (18,2),
    @precio_venta_mayorista    decimal  (18,2),
    @precio_venta_publico    decimal  (18,2),
    @bonificacion1    decimal  (18,2),
    @bonificacion2    decimal  (18,2)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_precio
FROM
    [dbo].[Precio]
WHERE
    [id_producto] = @id_producto AND
    [id_proveedor] = @id_proveedor AND
    [precio] = @precio AND
    [alicuota] = @alicuota AND
    [iva] = @iva AND
    [impuesto_interno] = @impuesto_interno AND
    [pack] = @pack AND
    [margen_ganancia] = @margen_ganancia AND
    [cod_producto_proveedor] = @cod_producto_proveedor AND
    [precio_venta_unitario] = @precio_venta_unitario AND
    [precio_venta_mayorista] = @precio_venta_mayorista AND
    [precio_venta_publico] = @precio_venta_publico AND
    [bonificacion1] = @bonificacion1 AND
    [bonificacion2] = @bonificacion2

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Precio_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Precio_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Precio_GetOne]
    @id_precio    int
AS

SELECT
    [id_precio] AS [Id precio] ,
    [id_producto] AS [Id producto] ,
    [id_proveedor] AS [Id proveedor] ,
    [precio] AS [Precio] ,
    [alicuota] AS [Alicuota] ,
    [iva] AS [Iva] ,
    [impuesto_interno] AS [Impuesto interno] ,
    [pack] AS [Pack] ,
    [margen_ganancia] AS [Margen ganancia] ,
    [cod_producto_proveedor] AS [Cod producto proveedor] ,
    [precio_venta_unitario] AS [Precio venta unitario] ,
    [precio_venta_mayorista] AS [Precio venta mayorista] ,
    [precio_venta_publico] AS [Precio venta publico] ,
    [bonificacion1] AS [Bonificacion1] ,
    [bonificacion2] AS [Bonificacion2]
FROM
    [dbo].[Precio]
WHERE
    [id_precio]  =  @id_precio
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Precio_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Precio_Find]
GO

CREATE PROCEDURE [dbo].[cop_Precio_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_precio] AS [Id precio] ,
    [id_producto] AS [Id producto] ,
    [id_proveedor] AS [Id proveedor] ,
    [precio] AS [Precio] ,
    [alicuota] AS [Alicuota] ,
    [iva] AS [Iva] ,
    [impuesto_interno] AS [Impuesto interno] ,
    [pack] AS [Pack] ,
    [margen_ganancia] AS [Margen ganancia] ,
    RTRIM(cod_producto_proveedor) AS [Cod producto proveedor] ,
    [precio_venta_unitario] AS [Precio venta unitario] ,
    [precio_venta_mayorista] AS [Precio venta mayorista] ,
    [precio_venta_publico] AS [Precio venta publico] ,
    [bonificacion1] AS [Bonificacion1] ,
    [bonificacion2] AS [Bonificacion2]
FROM
    [dbo].[Precio]
WHERE
    [id_producto] LIKE @nombre+'%'
ORDER BY
    [id_producto]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Precio_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Precio_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Precio_InsertOne]
AS

INSERT INTO [dbo].[Precio]
(
    [id_producto],
    [id_proveedor],
    [precio],
    [alicuota],
    [iva],
    [impuesto_interno],
    [pack],
    [margen_ganancia],
    [cod_producto_proveedor],
    [precio_venta_unitario],
    [precio_venta_mayorista],
    [precio_venta_publico],
    [bonificacion1],
    [bonificacion2]
)
VALUES
(
    1,
    1,
    0,
    0,
    0,
    0,
    0,
    0,
    'Ninguno',
    0,
    0,
    0,
    0,
     0 
)
GO

