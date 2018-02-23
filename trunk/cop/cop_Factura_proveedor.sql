USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Factura_proveedor_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Factura_proveedor_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Factura_proveedor_Insert]
    @id_factura_proveedor    int  output,
    @numero_factura    char  (12),
    @id_empresa    int  ,
    @id_tipo_comprobante    int  ,
    @fecha    datetime  ,
    @fecha_factura    datetime  ,
    @fecha_vencimiento    datetime  ,
    @id_proveedor    int  ,
    @observacion    varchar  (500),
    @saldo    decimal  (18,2),
    @estado    char  (1),
    @alicuota_iva    decimal  (18,2),
    @iva_21    decimal  (18,2),
    @iva_10_5    decimal  (18,2),
    @importe_21    decimal  (18,2),
    @importe_10_5    decimal  (18,2),
    @retencion_iva    decimal  (18,2),
    @percepcion_iva    decimal  (18,2),
    @retencion_ingreso_bruto    decimal  (18,2),
    @percepcion_ingreso_bruto    decimal  (18,2),
    @retencion_ganancia    decimal  (18,2),
    @impuesto_interno    decimal  (18,2),
    @otro    decimal  (18,2),
    @total_21    decimal  (18,2),
    @total_10_5    decimal  (18,2),
    @total_sin    decimal  (18,2),
    @total_factura    decimal  (18,2),
    @id_almacen    int  ,
    @id_cuenta_contable    int  ,
    @id_usuario    int  ,
    @tilde    bit  ,
    @referencia    varchar  (50),
    @saldo_factura    decimal  (18,2),
    @pagada    bit  ,
    @numero_certificado    int  ,
    @pago_a_cuenta    bit  ,
    @sin_pago    bit  
AS

INSERT INTO [dbo].[Factura_proveedor]
(
    [numero_factura],
    [id_empresa],
    [id_tipo_comprobante],
    [fecha],
    [fecha_factura],
    [fecha_vencimiento],
    [id_proveedor],
    [observacion],
    [saldo],
    [estado],
    [alicuota_iva],
    [iva_21],
    [iva_10_5],
    [importe_21],
    [importe_10_5],
    [retencion_iva],
    [percepcion_iva],
    [retencion_ingreso_bruto],
    [percepcion_ingreso_bruto],
    [retencion_ganancia],
    [impuesto_interno],
    [otro],
    [total_21],
    [total_10_5],
    [total_sin],
    [total_factura],
    [id_almacen],
    [id_cuenta_contable],
    [id_usuario],
    [tilde],
    [referencia],
    [saldo_factura],
    [pagada],
    [numero_certificado],
    [pago_a_cuenta],
    [sin_pago]
)
VALUES
(
    @numero_factura,
    @id_empresa,
    @id_tipo_comprobante,
    @fecha,
    @fecha_factura,
    @fecha_vencimiento,
    @id_proveedor,
    @observacion,
    @saldo,
    @estado,
    @alicuota_iva,
    @iva_21,
    @iva_10_5,
    @importe_21,
    @importe_10_5,
    @retencion_iva,
    @percepcion_iva,
    @retencion_ingreso_bruto,
    @percepcion_ingreso_bruto,
    @retencion_ganancia,
    @impuesto_interno,
    @otro,
    @total_21,
    @total_10_5,
    @total_sin,
    @total_factura,
    @id_almacen,
    @id_cuenta_contable,
    @id_usuario,
    @tilde,
    @referencia,
    @saldo_factura,
    @pagada,
    @numero_certificado,
    @pago_a_cuenta,
    @sin_pago
)
SET @id_factura_proveedor = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Factura_proveedor_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Factura_proveedor_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Factura_proveedor_Delete]
    @id_factura_proveedor    int
AS

DELETE FROM [dbo].[Factura_proveedor]
WHERE
    [id_factura_proveedor]  =  @id_factura_proveedor
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Factura_proveedor_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Factura_proveedor_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Factura_proveedor_GetAll]
AS

SELECT TOP 100
    [id_factura_proveedor] AS [Id factura proveedor] ,
    [numero_factura] AS [Numero factura] ,
    [id_empresa] AS [Id empresa] ,
    [id_tipo_comprobante] AS [Id tipo comprobante] ,
    [fecha] AS [Fecha] ,
    [fecha_factura] AS [Fecha factura] ,
    [fecha_vencimiento] AS [Fecha vencimiento] ,
    [id_proveedor] AS [Id proveedor] ,
    RTRIM(observacion) AS [Observacion] ,
    [saldo] AS [Saldo] ,
    [estado] AS [Estado] ,
    [alicuota_iva] AS [Alicuota iva] ,
    [iva_21] AS [Iva 21] ,
    [iva_10_5] AS [Iva 10 5] ,
    [importe_21] AS [Importe 21] ,
    [importe_10_5] AS [Importe 10 5] ,
    [retencion_iva] AS [Retencion iva] ,
    [percepcion_iva] AS [Percepcion iva] ,
    [retencion_ingreso_bruto] AS [Retencion ingreso bruto] ,
    [percepcion_ingreso_bruto] AS [Percepcion ingreso bruto] ,
    [retencion_ganancia] AS [Retencion ganancia] ,
    [impuesto_interno] AS [Impuesto interno] ,
    [otro] AS [Otro] ,
    [total_21] AS [Total 21] ,
    [total_10_5] AS [Total 10 5] ,
    [total_sin] AS [Total sin] ,
    [total_factura] AS [Total factura] ,
    [id_almacen] AS [Id almacen] ,
    [id_cuenta_contable] AS [Id cuenta contable] ,
    [id_usuario] AS [Id usuario] ,
    [tilde] AS [Tilde] ,
    RTRIM(referencia) AS [Referencia] ,
    [saldo_factura] AS [Saldo factura] ,
    [pagada] AS [Pagada] ,
    [numero_certificado] AS [Numero certificado] ,
    [pago_a_cuenta] AS [Pago a cuenta] ,
    [sin_pago] AS [Sin pago]
FROM
    [dbo].[Factura_proveedor]
ORDER BY
    [numero_factura]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Factura_proveedor_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Factura_proveedor_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Factura_proveedor_GetCmb]
AS

SELECT
    [id_factura_proveedor],
    [numero_factura],
    [id_empresa],
    [id_tipo_comprobante],
    [fecha],
    [fecha_factura],
    [fecha_vencimiento],
    [id_proveedor],
    [observacion],
    [saldo],
    [estado],
    [alicuota_iva],
    [iva_21],
    [iva_10_5],
    [importe_21],
    [importe_10_5],
    [retencion_iva],
    [percepcion_iva],
    [retencion_ingreso_bruto],
    [percepcion_ingreso_bruto],
    [retencion_ganancia],
    [impuesto_interno],
    [otro],
    [total_21],
    [total_10_5],
    [total_sin],
    [total_factura],
    [id_almacen],
    [id_cuenta_contable],
    [id_usuario],
    [tilde],
    [referencia],
    [saldo_factura],
    [pagada],
    [numero_certificado],
    [pago_a_cuenta],
    [sin_pago]
FROM
    [dbo].[Factura_proveedor]
ORDER BY
    [numero_factura]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Factura_proveedor_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Factura_proveedor_Update]
GO

CREATE PROCEDURE [dbo].[cop_Factura_proveedor_Update]
    @id_factura_proveedor    int  output,
    @numero_factura    char  (12),
    @id_empresa    int  ,
    @id_tipo_comprobante    int  ,
    @fecha    datetime  ,
    @fecha_factura    datetime  ,
    @fecha_vencimiento    datetime  ,
    @id_proveedor    int  ,
    @observacion    varchar  (500),
    @saldo    decimal  (18,2),
    @estado    char  (1),
    @alicuota_iva    decimal  (18,2),
    @iva_21    decimal  (18,2),
    @iva_10_5    decimal  (18,2),
    @importe_21    decimal  (18,2),
    @importe_10_5    decimal  (18,2),
    @retencion_iva    decimal  (18,2),
    @percepcion_iva    decimal  (18,2),
    @retencion_ingreso_bruto    decimal  (18,2),
    @percepcion_ingreso_bruto    decimal  (18,2),
    @retencion_ganancia    decimal  (18,2),
    @impuesto_interno    decimal  (18,2),
    @otro    decimal  (18,2),
    @total_21    decimal  (18,2),
    @total_10_5    decimal  (18,2),
    @total_sin    decimal  (18,2),
    @total_factura    decimal  (18,2),
    @id_almacen    int  ,
    @id_cuenta_contable    int  ,
    @id_usuario    int  ,
    @tilde    bit  ,
    @referencia    varchar  (50),
    @saldo_factura    decimal  (18,2),
    @pagada    bit  ,
    @numero_certificado    int  ,
    @pago_a_cuenta    bit  ,
    @sin_pago    bit  
AS

UPDATE [dbo].[Factura_proveedor] SET
    [numero_factura] = @numero_factura,
    [id_empresa] = @id_empresa,
    [id_tipo_comprobante] = @id_tipo_comprobante,
    [fecha] = @fecha,
    [fecha_factura] = @fecha_factura,
    [fecha_vencimiento] = @fecha_vencimiento,
    [id_proveedor] = @id_proveedor,
    [observacion] = @observacion,
    [saldo] = @saldo,
    [estado] = @estado,
    [alicuota_iva] = @alicuota_iva,
    [iva_21] = @iva_21,
    [iva_10_5] = @iva_10_5,
    [importe_21] = @importe_21,
    [importe_10_5] = @importe_10_5,
    [retencion_iva] = @retencion_iva,
    [percepcion_iva] = @percepcion_iva,
    [retencion_ingreso_bruto] = @retencion_ingreso_bruto,
    [percepcion_ingreso_bruto] = @percepcion_ingreso_bruto,
    [retencion_ganancia] = @retencion_ganancia,
    [impuesto_interno] = @impuesto_interno,
    [otro] = @otro,
    [total_21] = @total_21,
    [total_10_5] = @total_10_5,
    [total_sin] = @total_sin,
    [total_factura] = @total_factura,
    [id_almacen] = @id_almacen,
    [id_cuenta_contable] = @id_cuenta_contable,
    [id_usuario] = @id_usuario,
    [tilde] = @tilde,
    [referencia] = @referencia,
    [saldo_factura] = @saldo_factura,
    [pagada] = @pagada,
    [numero_certificado] = @numero_certificado,
    [pago_a_cuenta] = @pago_a_cuenta,
    [sin_pago] = @sin_pago
WHERE
    [id_factura_proveedor]  =  @id_factura_proveedor
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Factura_proveedor_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Factura_proveedor_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Factura_proveedor_Exist]
    @numero_factura    char  (12),
    @id_empresa    int  ,
    @id_tipo_comprobante    int  ,
    @fecha    datetime  ,
    @fecha_factura    datetime  ,
    @fecha_vencimiento    datetime  ,
    @id_proveedor    int  ,
    @observacion    varchar  (500),
    @saldo    decimal  (18,2),
    @estado    char  (1),
    @alicuota_iva    decimal  (18,2),
    @iva_21    decimal  (18,2),
    @iva_10_5    decimal  (18,2),
    @importe_21    decimal  (18,2),
    @importe_10_5    decimal  (18,2),
    @retencion_iva    decimal  (18,2),
    @percepcion_iva    decimal  (18,2),
    @retencion_ingreso_bruto    decimal  (18,2),
    @percepcion_ingreso_bruto    decimal  (18,2),
    @retencion_ganancia    decimal  (18,2),
    @impuesto_interno    decimal  (18,2),
    @otro    decimal  (18,2),
    @total_21    decimal  (18,2),
    @total_10_5    decimal  (18,2),
    @total_sin    decimal  (18,2),
    @total_factura    decimal  (18,2),
    @id_almacen    int  ,
    @id_cuenta_contable    int  ,
    @id_usuario    int  ,
    @tilde    bit  ,
    @referencia    varchar  (50),
    @saldo_factura    decimal  (18,2),
    @pagada    bit  ,
    @numero_certificado    int  ,
    @pago_a_cuenta    bit  ,
    @sin_pago    bit  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_factura_proveedor
FROM
    [dbo].[Factura_proveedor]
WHERE
    [numero_factura] = @numero_factura AND
    [id_empresa] = @id_empresa AND
    [id_tipo_comprobante] = @id_tipo_comprobante AND
    [fecha] = @fecha AND
    [fecha_factura] = @fecha_factura AND
    [fecha_vencimiento] = @fecha_vencimiento AND
    [id_proveedor] = @id_proveedor AND
    [observacion] = @observacion AND
    [saldo] = @saldo AND
    [estado] = @estado AND
    [alicuota_iva] = @alicuota_iva AND
    [iva_21] = @iva_21 AND
    [iva_10_5] = @iva_10_5 AND
    [importe_21] = @importe_21 AND
    [importe_10_5] = @importe_10_5 AND
    [retencion_iva] = @retencion_iva AND
    [percepcion_iva] = @percepcion_iva AND
    [retencion_ingreso_bruto] = @retencion_ingreso_bruto AND
    [percepcion_ingreso_bruto] = @percepcion_ingreso_bruto AND
    [retencion_ganancia] = @retencion_ganancia AND
    [impuesto_interno] = @impuesto_interno AND
    [otro] = @otro AND
    [total_21] = @total_21 AND
    [total_10_5] = @total_10_5 AND
    [total_sin] = @total_sin AND
    [total_factura] = @total_factura AND
    [id_almacen] = @id_almacen AND
    [id_cuenta_contable] = @id_cuenta_contable AND
    [id_usuario] = @id_usuario AND
    [tilde] = @tilde AND
    [referencia] = @referencia AND
    [saldo_factura] = @saldo_factura AND
    [pagada] = @pagada AND
    [numero_certificado] = @numero_certificado AND
    [pago_a_cuenta] = @pago_a_cuenta AND
    [sin_pago] = @sin_pago

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Factura_proveedor_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Factura_proveedor_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Factura_proveedor_GetOne]
    @id_factura_proveedor    int
AS

SELECT
    [id_factura_proveedor] AS [Id factura proveedor] ,
    [numero_factura] AS [Numero factura] ,
    [id_empresa] AS [Id empresa] ,
    [id_tipo_comprobante] AS [Id tipo comprobante] ,
    [fecha] AS [Fecha] ,
    [fecha_factura] AS [Fecha factura] ,
    [fecha_vencimiento] AS [Fecha vencimiento] ,
    [id_proveedor] AS [Id proveedor] ,
    [observacion] AS [Observacion] ,
    [saldo] AS [Saldo] ,
    [estado] AS [Estado] ,
    [alicuota_iva] AS [Alicuota iva] ,
    [iva_21] AS [Iva 21] ,
    [iva_10_5] AS [Iva 10 5] ,
    [importe_21] AS [Importe 21] ,
    [importe_10_5] AS [Importe 10 5] ,
    [retencion_iva] AS [Retencion iva] ,
    [percepcion_iva] AS [Percepcion iva] ,
    [retencion_ingreso_bruto] AS [Retencion ingreso bruto] ,
    [percepcion_ingreso_bruto] AS [Percepcion ingreso bruto] ,
    [retencion_ganancia] AS [Retencion ganancia] ,
    [impuesto_interno] AS [Impuesto interno] ,
    [otro] AS [Otro] ,
    [total_21] AS [Total 21] ,
    [total_10_5] AS [Total 10 5] ,
    [total_sin] AS [Total sin] ,
    [total_factura] AS [Total factura] ,
    [id_almacen] AS [Id almacen] ,
    [id_cuenta_contable] AS [Id cuenta contable] ,
    [id_usuario] AS [Id usuario] ,
    [tilde] AS [Tilde] ,
    [referencia] AS [Referencia] ,
    [saldo_factura] AS [Saldo factura] ,
    [pagada] AS [Pagada] ,
    [numero_certificado] AS [Numero certificado] ,
    [pago_a_cuenta] AS [Pago a cuenta] ,
    [sin_pago] AS [Sin pago]
FROM
    [dbo].[Factura_proveedor]
WHERE
    [id_factura_proveedor]  =  @id_factura_proveedor
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Factura_proveedor_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Factura_proveedor_Find]
GO

CREATE PROCEDURE [dbo].[cop_Factura_proveedor_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_factura_proveedor] AS [Id factura proveedor] ,
    [numero_factura] AS [Numero factura] ,
    [id_empresa] AS [Id empresa] ,
    [id_tipo_comprobante] AS [Id tipo comprobante] ,
    [fecha] AS [Fecha] ,
    [fecha_factura] AS [Fecha factura] ,
    [fecha_vencimiento] AS [Fecha vencimiento] ,
    [id_proveedor] AS [Id proveedor] ,
    RTRIM(observacion) AS [Observacion] ,
    [saldo] AS [Saldo] ,
    [estado] AS [Estado] ,
    [alicuota_iva] AS [Alicuota iva] ,
    [iva_21] AS [Iva 21] ,
    [iva_10_5] AS [Iva 10 5] ,
    [importe_21] AS [Importe 21] ,
    [importe_10_5] AS [Importe 10 5] ,
    [retencion_iva] AS [Retencion iva] ,
    [percepcion_iva] AS [Percepcion iva] ,
    [retencion_ingreso_bruto] AS [Retencion ingreso bruto] ,
    [percepcion_ingreso_bruto] AS [Percepcion ingreso bruto] ,
    [retencion_ganancia] AS [Retencion ganancia] ,
    [impuesto_interno] AS [Impuesto interno] ,
    [otro] AS [Otro] ,
    [total_21] AS [Total 21] ,
    [total_10_5] AS [Total 10 5] ,
    [total_sin] AS [Total sin] ,
    [total_factura] AS [Total factura] ,
    [id_almacen] AS [Id almacen] ,
    [id_cuenta_contable] AS [Id cuenta contable] ,
    [id_usuario] AS [Id usuario] ,
    [tilde] AS [Tilde] ,
    RTRIM(referencia) AS [Referencia] ,
    [saldo_factura] AS [Saldo factura] ,
    [pagada] AS [Pagada] ,
    [numero_certificado] AS [Numero certificado] ,
    [pago_a_cuenta] AS [Pago a cuenta] ,
    [sin_pago] AS [Sin pago]
FROM
    [dbo].[Factura_proveedor]
WHERE
    [numero_factura] LIKE @nombre+'%'
ORDER BY
    [numero_factura]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Factura_proveedor_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Factura_proveedor_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Factura_proveedor_InsertOne]
AS

INSERT INTO [dbo].[Factura_proveedor]
(
    [numero_factura],
    [id_empresa],
    [id_tipo_comprobante],
    [fecha],
    [fecha_factura],
    [fecha_vencimiento],
    [id_proveedor],
    [observacion],
    [saldo],
    [estado],
    [alicuota_iva],
    [iva_21],
    [iva_10_5],
    [importe_21],
    [importe_10_5],
    [retencion_iva],
    [percepcion_iva],
    [retencion_ingreso_bruto],
    [percepcion_ingreso_bruto],
    [retencion_ganancia],
    [impuesto_interno],
    [otro],
    [total_21],
    [total_10_5],
    [total_sin],
    [total_factura],
    [id_almacen],
    [id_cuenta_contable],
    [id_usuario],
    [tilde],
    [referencia],
    [saldo_factura],
    [pagada],
    [numero_certificado],
    [pago_a_cuenta],
    [sin_pago]
)
VALUES
(
    '',
    1,
    1,
    '01-01-2000',
    '01-01-2000',
    '01-01-2000',
    1,
    'Ninguno',
    0,
    '',
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    1,
    1,
    1,
    0,
    'Ninguno',
    0,
    0,
    1,
    0,
     0 
)
GO

