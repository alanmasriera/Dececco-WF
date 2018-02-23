USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Egreso_efectivo_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Egreso_efectivo_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Egreso_efectivo_Insert]
    @id_Egreso_efectivo    int  output,
    @fecha    datetime  ,
    @comprobante    varchar  (50),
    @importe    decimal  (18,2),
    @iva    decimal  (18,2),
    @detalle    varchar  (50),
    @id_empresa    int  ,
    @control    bit  ,
    @a_rendir    bit  ,
    @id_proveedor    int  ,
    @archivado    bit  ,
    @id_tipo_egreso    int  
AS

INSERT INTO [dbo].[Egreso_efectivo]
(
    [fecha],
    [comprobante],
    [importe],
    [iva],
    [detalle],
    [id_empresa],
    [control],
    [a_rendir],
    [id_proveedor],
    [archivado],
    [id_tipo_egreso]
)
VALUES
(
    @fecha,
    @comprobante,
    @importe,
    @iva,
    @detalle,
    @id_empresa,
    @control,
    @a_rendir,
    @id_proveedor,
    @archivado,
    @id_tipo_egreso
)
SET @id_Egreso_efectivo = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Egreso_efectivo_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Egreso_efectivo_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Egreso_efectivo_Delete]
    @id_Egreso_efectivo    int
AS

DELETE FROM [dbo].[Egreso_efectivo]
WHERE
    [id_Egreso_efectivo]  =  @id_Egreso_efectivo
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Egreso_efectivo_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Egreso_efectivo_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Egreso_efectivo_GetAll]
AS

SELECT TOP 100
    [id_Egreso_efectivo] AS [Id egreso efectivo] ,
    [fecha] AS [Fecha] ,
    RTRIM(comprobante) AS [Comprobante] ,
    [importe] AS [Importe] ,
    [iva] AS [Iva] ,
    RTRIM(detalle) AS [Detalle] ,
    [id_empresa] AS [Id empresa] ,
    [control] AS [Control] ,
    [a_rendir] AS [A rendir] ,
    [id_proveedor] AS [Id proveedor] ,
    [archivado] AS [Archivado] ,
    [id_tipo_egreso] AS [Id tipo egreso]
FROM
    [dbo].[Egreso_efectivo]
ORDER BY
    [fecha]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Egreso_efectivo_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Egreso_efectivo_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Egreso_efectivo_GetCmb]
AS

SELECT
    [id_Egreso_efectivo],
    [fecha],
    [comprobante],
    [importe],
    [iva],
    [detalle],
    [id_empresa],
    [control],
    [a_rendir],
    [id_proveedor],
    [archivado],
    [id_tipo_egreso]
FROM
    [dbo].[Egreso_efectivo]
ORDER BY
    [fecha]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Egreso_efectivo_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Egreso_efectivo_Update]
GO

CREATE PROCEDURE [dbo].[cop_Egreso_efectivo_Update]
    @id_Egreso_efectivo    int  output,
    @fecha    datetime  ,
    @comprobante    varchar  (50),
    @importe    decimal  (18,2),
    @iva    decimal  (18,2),
    @detalle    varchar  (50),
    @id_empresa    int  ,
    @control    bit  ,
    @a_rendir    bit  ,
    @id_proveedor    int  ,
    @archivado    bit  ,
    @id_tipo_egreso    int  
AS

UPDATE [dbo].[Egreso_efectivo] SET
    [fecha] = @fecha,
    [comprobante] = @comprobante,
    [importe] = @importe,
    [iva] = @iva,
    [detalle] = @detalle,
    [id_empresa] = @id_empresa,
    [control] = @control,
    [a_rendir] = @a_rendir,
    [id_proveedor] = @id_proveedor,
    [archivado] = @archivado,
    [id_tipo_egreso] = @id_tipo_egreso
WHERE
    [id_Egreso_efectivo]  =  @id_Egreso_efectivo
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Egreso_efectivo_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Egreso_efectivo_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Egreso_efectivo_Exist]
    @fecha    datetime  ,
    @comprobante    varchar  (50),
    @importe    decimal  (18,2),
    @iva    decimal  (18,2),
    @detalle    varchar  (50),
    @id_empresa    int  ,
    @control    bit  ,
    @a_rendir    bit  ,
    @id_proveedor    int  ,
    @archivado    bit  ,
    @id_tipo_egreso    int  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_Egreso_efectivo
FROM
    [dbo].[Egreso_efectivo]
WHERE
    [fecha] = @fecha AND
    [comprobante] = @comprobante AND
    [importe] = @importe AND
    [iva] = @iva AND
    [detalle] = @detalle AND
    [id_empresa] = @id_empresa AND
    [control] = @control AND
    [a_rendir] = @a_rendir AND
    [id_proveedor] = @id_proveedor AND
    [archivado] = @archivado AND
    [id_tipo_egreso] = @id_tipo_egreso

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Egreso_efectivo_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Egreso_efectivo_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Egreso_efectivo_GetOne]
    @id_Egreso_efectivo    int
AS

SELECT
    [id_Egreso_efectivo] AS [Id egreso efectivo] ,
    [fecha] AS [Fecha] ,
    [comprobante] AS [Comprobante] ,
    [importe] AS [Importe] ,
    [iva] AS [Iva] ,
    [detalle] AS [Detalle] ,
    [id_empresa] AS [Id empresa] ,
    [control] AS [Control] ,
    [a_rendir] AS [A rendir] ,
    [id_proveedor] AS [Id proveedor] ,
    [archivado] AS [Archivado] ,
    [id_tipo_egreso] AS [Id tipo egreso]
FROM
    [dbo].[Egreso_efectivo]
WHERE
    [id_Egreso_efectivo]  =  @id_Egreso_efectivo
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Egreso_efectivo_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Egreso_efectivo_Find]
GO

CREATE PROCEDURE [dbo].[cop_Egreso_efectivo_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_Egreso_efectivo] AS [Id egreso efectivo] ,
    [fecha] AS [Fecha] ,
    RTRIM(comprobante) AS [Comprobante] ,
    [importe] AS [Importe] ,
    [iva] AS [Iva] ,
    RTRIM(detalle) AS [Detalle] ,
    [id_empresa] AS [Id empresa] ,
    [control] AS [Control] ,
    [a_rendir] AS [A rendir] ,
    [id_proveedor] AS [Id proveedor] ,
    [archivado] AS [Archivado] ,
    [id_tipo_egreso] AS [Id tipo egreso]
FROM
    [dbo].[Egreso_efectivo]
WHERE
    [fecha] LIKE @nombre+'%'
ORDER BY
    [fecha]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Egreso_efectivo_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Egreso_efectivo_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Egreso_efectivo_InsertOne]
AS

INSERT INTO [dbo].[Egreso_efectivo]
(
    [fecha],
    [comprobante],
    [importe],
    [iva],
    [detalle],
    [id_empresa],
    [control],
    [a_rendir],
    [id_proveedor],
    [archivado],
    [id_tipo_egreso]
)
VALUES
(
    '01-01-2000',
    'Ninguno',
    0,
    0,
    'Ninguno',
    1,
    0,
    0,
    1,
    0,
     1 
)
GO

