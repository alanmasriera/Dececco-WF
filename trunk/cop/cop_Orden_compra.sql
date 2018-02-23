USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Orden_compra_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Orden_compra_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Orden_compra_Insert]
    @id_orden_compra    int  output,
    @fecha_orden_compra    datetime  ,
    @id_cliente    int  ,
    @observacion    varchar  (5000),
    @acepto_orden_compra    varchar  (50),
    @total_orden_compra    decimal  (18,2),
    @id_usuario    int  ,
    @id_presupuesto    int  
AS

INSERT INTO [dbo].[Orden_compra]
(
    [fecha_orden_compra],
    [id_cliente],
    [observacion],
    [acepto_orden_compra],
    [total_orden_compra],
    [id_usuario],
    [id_presupuesto]
)
VALUES
(
    @fecha_orden_compra,
    @id_cliente,
    @observacion,
    @acepto_orden_compra,
    @total_orden_compra,
    @id_usuario,
    @id_presupuesto
)
SET @id_orden_compra = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Orden_compra_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Orden_compra_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Orden_compra_Delete]
    @id_orden_compra    int
AS

DELETE FROM [dbo].[Orden_compra]
WHERE
    [id_orden_compra]  =  @id_orden_compra
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Orden_compra_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Orden_compra_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Orden_compra_GetAll]
AS

SELECT TOP 100
    [id_orden_compra] AS [Id orden compra] ,
    [fecha_orden_compra] AS [Fecha orden compra] ,
    [id_cliente] AS [Id cliente] ,
    RTRIM(observacion) AS [Observacion] ,
    RTRIM(acepto_orden_compra) AS [Acepto orden compra] ,
    [total_orden_compra] AS [Total orden compra] ,
    [id_usuario] AS [Id usuario] ,
    [id_presupuesto] AS [Id presupuesto]
FROM
    [dbo].[Orden_compra]
ORDER BY
    [fecha_orden_compra]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Orden_compra_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Orden_compra_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Orden_compra_GetCmb]
AS

SELECT
    [id_orden_compra],
    [fecha_orden_compra],
    [id_cliente],
    [observacion],
    [acepto_orden_compra],
    [total_orden_compra],
    [id_usuario],
    [id_presupuesto]
FROM
    [dbo].[Orden_compra]
ORDER BY
    [fecha_orden_compra]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Orden_compra_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Orden_compra_Update]
GO

CREATE PROCEDURE [dbo].[cop_Orden_compra_Update]
    @id_orden_compra    int  output,
    @fecha_orden_compra    datetime  ,
    @id_cliente    int  ,
    @observacion    varchar  (5000),
    @acepto_orden_compra    varchar  (50),
    @total_orden_compra    decimal  (18,2),
    @id_usuario    int  ,
    @id_presupuesto    int  
AS

UPDATE [dbo].[Orden_compra] SET
    [fecha_orden_compra] = @fecha_orden_compra,
    [id_cliente] = @id_cliente,
    [observacion] = @observacion,
    [acepto_orden_compra] = @acepto_orden_compra,
    [total_orden_compra] = @total_orden_compra,
    [id_usuario] = @id_usuario,
    [id_presupuesto] = @id_presupuesto
WHERE
    [id_orden_compra]  =  @id_orden_compra
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Orden_compra_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Orden_compra_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Orden_compra_Exist]
    @fecha_orden_compra    datetime  ,
    @id_cliente    int  ,
    @observacion    varchar  (5000),
    @acepto_orden_compra    varchar  (50),
    @total_orden_compra    decimal  (18,2),
    @id_usuario    int  ,
    @id_presupuesto    int  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_orden_compra
FROM
    [dbo].[Orden_compra]
WHERE
    [fecha_orden_compra] = @fecha_orden_compra AND
    [id_cliente] = @id_cliente AND
    [observacion] = @observacion AND
    [acepto_orden_compra] = @acepto_orden_compra AND
    [total_orden_compra] = @total_orden_compra AND
    [id_usuario] = @id_usuario AND
    [id_presupuesto] = @id_presupuesto

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Orden_compra_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Orden_compra_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Orden_compra_GetOne]
    @id_orden_compra    int
AS

SELECT
    [id_orden_compra] AS [Id orden compra] ,
    [fecha_orden_compra] AS [Fecha orden compra] ,
    [id_cliente] AS [Id cliente] ,
    [observacion] AS [Observacion] ,
    [acepto_orden_compra] AS [Acepto orden compra] ,
    [total_orden_compra] AS [Total orden compra] ,
    [id_usuario] AS [Id usuario] ,
    [id_presupuesto] AS [Id presupuesto]
FROM
    [dbo].[Orden_compra]
WHERE
    [id_orden_compra]  =  @id_orden_compra
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Orden_compra_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Orden_compra_Find]
GO

CREATE PROCEDURE [dbo].[cop_Orden_compra_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_orden_compra] AS [Id orden compra] ,
    [fecha_orden_compra] AS [Fecha orden compra] ,
    [id_cliente] AS [Id cliente] ,
    RTRIM(observacion) AS [Observacion] ,
    RTRIM(acepto_orden_compra) AS [Acepto orden compra] ,
    [total_orden_compra] AS [Total orden compra] ,
    [id_usuario] AS [Id usuario] ,
    [id_presupuesto] AS [Id presupuesto]
FROM
    [dbo].[Orden_compra]
WHERE
    [fecha_orden_compra] LIKE @nombre+'%'
ORDER BY
    [fecha_orden_compra]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Orden_compra_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Orden_compra_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Orden_compra_InsertOne]
AS

INSERT INTO [dbo].[Orden_compra]
(
    [fecha_orden_compra],
    [id_cliente],
    [observacion],
    [acepto_orden_compra],
    [total_orden_compra],
    [id_usuario],
    [id_presupuesto]
)
VALUES
(
    '01-01-2000',
    1,
    'Ninguno',
    'Ninguno',
    0,
    1,
     1 
)
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Cuerpo_Orden_compra_DeleteOrden_compra]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Cuerpo_Orden_compra_DeleteOrden_compra]
GO

CREATE PROCEDURE [dbo].[cop_Cuerpo_Orden_compra_DeleteOrden_compra]
    @id_Orden_compra    int,
    @id_usuario int
AS

DELETE FROM [dbo].[Cuerpo_Orden_compra]
WHERE
    [id_Orden_compra] = @id_Orden_compra AND
    [id_usuario] = @id_usuario
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Cuerpo_Orden_compra_UpdateID]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Cuerpo_Orden_compra_UpdateID]
GO

CREATE PROCEDURE [dbo].[cop_Cuerpo_Orden_compra_UpdateID]
    @id_Orden_compra int,
    @id_usuario int
AS

UPDATE [dbo].[Cuerpo_Orden_compra] SET
    [id_Orden_compra] = @id_Orden_compra
WHERE
    [id_Orden_compra] = 0 AND
    [id_usuario] = @id_usuario
GO

