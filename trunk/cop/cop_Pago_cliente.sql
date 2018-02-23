USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Pago_cliente_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Pago_cliente_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Pago_cliente_Insert]
    @id_pago_cliente    int  output,
    @id_cliente    int  ,
    @fecha    datetime  ,
    @pago    decimal  (18,2),
    @detalle    varchar  (5000),
    @efectivo    bit  ,
    @numero_recibo    varchar  (50),
    @retencion_iva    decimal  (18,2),
    @ingreso_bruto    decimal  (18,2),
    @impuesto_ganancia    decimal  (18,2),
    @suss    decimal  (18,2),
    @total_letra    varchar  (5000),
    @observacion    varchar  (5000)
AS

INSERT INTO [dbo].[Pago_cliente]
(
    [id_cliente],
    [fecha],
    [pago],
    [detalle],
    [efectivo],
    [numero_recibo],
    [retencion_iva],
    [ingreso_bruto],
    [impuesto_ganancia],
    [suss],
    [total_letra],
    [observacion]
)
VALUES
(
    @id_cliente,
    @fecha,
    @pago,
    @detalle,
    @efectivo,
    @numero_recibo,
    @retencion_iva,
    @ingreso_bruto,
    @impuesto_ganancia,
    @suss,
    @total_letra,
    @observacion
)
SET @id_pago_cliente = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Pago_cliente_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Pago_cliente_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Pago_cliente_Delete]
    @id_pago_cliente    int
AS

DELETE FROM [dbo].[Pago_cliente]
WHERE
    [id_pago_cliente]  =  @id_pago_cliente
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Pago_cliente_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Pago_cliente_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Pago_cliente_GetAll]
AS

SELECT TOP 100
    [id_pago_cliente] AS [Id pago cliente] ,
    [id_cliente] AS [Id cliente] ,
    [fecha] AS [Fecha] ,
    [pago] AS [Pago] ,
    RTRIM(detalle) AS [Detalle] ,
    [efectivo] AS [Efectivo] ,
    RTRIM(numero_recibo) AS [Numero recibo] ,
    [retencion_iva] AS [Retencion iva] ,
    [ingreso_bruto] AS [Ingreso bruto] ,
    [impuesto_ganancia] AS [Impuesto ganancia] ,
    [suss] AS [Suss] ,
    RTRIM(total_letra) AS [Total letra] ,
    RTRIM(observacion) AS [Observacion]
FROM
    [dbo].[Pago_cliente]
ORDER BY
    [id_cliente]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Pago_cliente_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Pago_cliente_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Pago_cliente_GetCmb]
AS

SELECT
    [id_pago_cliente],
    [id_cliente],
    [fecha],
    [pago],
    [detalle],
    [efectivo],
    [numero_recibo],
    [retencion_iva],
    [ingreso_bruto],
    [impuesto_ganancia],
    [suss],
    [total_letra],
    [observacion]
FROM
    [dbo].[Pago_cliente]
ORDER BY
    [id_cliente]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Pago_cliente_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Pago_cliente_Update]
GO

CREATE PROCEDURE [dbo].[cop_Pago_cliente_Update]
    @id_pago_cliente    int  output,
    @id_cliente    int  ,
    @fecha    datetime  ,
    @pago    decimal  (18,2),
    @detalle    varchar  (5000),
    @efectivo    bit  ,
    @numero_recibo    varchar  (50),
    @retencion_iva    decimal  (18,2),
    @ingreso_bruto    decimal  (18,2),
    @impuesto_ganancia    decimal  (18,2),
    @suss    decimal  (18,2),
    @total_letra    varchar  (5000),
    @observacion    varchar  (5000)
AS

UPDATE [dbo].[Pago_cliente] SET
    [id_cliente] = @id_cliente,
    [fecha] = @fecha,
    [pago] = @pago,
    [detalle] = @detalle,
    [efectivo] = @efectivo,
    [numero_recibo] = @numero_recibo,
    [retencion_iva] = @retencion_iva,
    [ingreso_bruto] = @ingreso_bruto,
    [impuesto_ganancia] = @impuesto_ganancia,
    [suss] = @suss,
    [total_letra] = @total_letra,
    [observacion] = @observacion
WHERE
    [id_pago_cliente]  =  @id_pago_cliente
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Pago_cliente_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Pago_cliente_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Pago_cliente_Exist]
    @id_cliente    int  ,
    @fecha    datetime  ,
    @pago    decimal  (18,2),
    @detalle    varchar  (5000),
    @efectivo    bit  ,
    @numero_recibo    varchar  (50),
    @retencion_iva    decimal  (18,2),
    @ingreso_bruto    decimal  (18,2),
    @impuesto_ganancia    decimal  (18,2),
    @suss    decimal  (18,2),
    @total_letra    varchar  (5000),
    @observacion    varchar  (5000)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_pago_cliente
FROM
    [dbo].[Pago_cliente]
WHERE
    [id_cliente] = @id_cliente AND
    [fecha] = @fecha AND
    [pago] = @pago AND
    [detalle] = @detalle AND
    [efectivo] = @efectivo AND
    [numero_recibo] = @numero_recibo AND
    [retencion_iva] = @retencion_iva AND
    [ingreso_bruto] = @ingreso_bruto AND
    [impuesto_ganancia] = @impuesto_ganancia AND
    [suss] = @suss AND
    [total_letra] = @total_letra AND
    [observacion] = @observacion

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Pago_cliente_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Pago_cliente_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Pago_cliente_GetOne]
    @id_pago_cliente    int
AS

SELECT
    [id_pago_cliente] AS [Id pago cliente] ,
    [id_cliente] AS [Id cliente] ,
    [fecha] AS [Fecha] ,
    [pago] AS [Pago] ,
    [detalle] AS [Detalle] ,
    [efectivo] AS [Efectivo] ,
    [numero_recibo] AS [Numero recibo] ,
    [retencion_iva] AS [Retencion iva] ,
    [ingreso_bruto] AS [Ingreso bruto] ,
    [impuesto_ganancia] AS [Impuesto ganancia] ,
    [suss] AS [Suss] ,
    [total_letra] AS [Total letra] ,
    [observacion] AS [Observacion]
FROM
    [dbo].[Pago_cliente]
WHERE
    [id_pago_cliente]  =  @id_pago_cliente
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Pago_cliente_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Pago_cliente_Find]
GO

CREATE PROCEDURE [dbo].[cop_Pago_cliente_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_pago_cliente] AS [Id pago cliente] ,
    [id_cliente] AS [Id cliente] ,
    [fecha] AS [Fecha] ,
    [pago] AS [Pago] ,
    RTRIM(detalle) AS [Detalle] ,
    [efectivo] AS [Efectivo] ,
    RTRIM(numero_recibo) AS [Numero recibo] ,
    [retencion_iva] AS [Retencion iva] ,
    [ingreso_bruto] AS [Ingreso bruto] ,
    [impuesto_ganancia] AS [Impuesto ganancia] ,
    [suss] AS [Suss] ,
    RTRIM(total_letra) AS [Total letra] ,
    RTRIM(observacion) AS [Observacion]
FROM
    [dbo].[Pago_cliente]
WHERE
    [id_cliente] LIKE @nombre+'%'
ORDER BY
    [id_cliente]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Pago_cliente_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Pago_cliente_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Pago_cliente_InsertOne]
AS

INSERT INTO [dbo].[Pago_cliente]
(
    [id_cliente],
    [fecha],
    [pago],
    [detalle],
    [efectivo],
    [numero_recibo],
    [retencion_iva],
    [ingreso_bruto],
    [impuesto_ganancia],
    [suss],
    [total_letra],
    [observacion]
)
VALUES
(
    1,
    '01-01-2000',
    0,
    'Ninguno',
    0,
    'Ninguno',
    0,
    0,
    0,
    0,
    'Ninguno',
    'Ninguno'
)
GO

