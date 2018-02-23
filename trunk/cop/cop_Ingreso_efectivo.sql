USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Ingreso_efectivo_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Ingreso_efectivo_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Ingreso_efectivo_Insert]
    @id_ingreso_efectivo    int  output,
    @fecha    datetime  ,
    @comprobante    varchar  (50),
    @importe    decimal  (18,2),
    @iva    decimal  (18,2),
    @detalle    varchar  (50),
    @id_empresa    int  ,
    @control    bit  ,
    @id_cliente    int  ,
    @archivado    bit  
AS

INSERT INTO [dbo].[Ingreso_efectivo]
(
    [fecha],
    [comprobante],
    [importe],
    [iva],
    [detalle],
    [id_empresa],
    [control],
    [id_cliente],
    [archivado]
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
    @id_cliente,
    @archivado
)
SET @id_ingreso_efectivo = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Ingreso_efectivo_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Ingreso_efectivo_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Ingreso_efectivo_Delete]
    @id_ingreso_efectivo    int
AS

DELETE FROM [dbo].[Ingreso_efectivo]
WHERE
    [id_ingreso_efectivo]  =  @id_ingreso_efectivo
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Ingreso_efectivo_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Ingreso_efectivo_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Ingreso_efectivo_GetAll]
AS

SELECT TOP 100
    [id_ingreso_efectivo] AS [Id ingreso efectivo] ,
    [fecha] AS [Fecha] ,
    RTRIM(comprobante) AS [Comprobante] ,
    [importe] AS [Importe] ,
    [iva] AS [Iva] ,
    RTRIM(detalle) AS [Detalle] ,
    [id_empresa] AS [Id empresa] ,
    [control] AS [Control] ,
    [id_cliente] AS [Id cliente] ,
    [archivado] AS [Archivado]
FROM
    [dbo].[Ingreso_efectivo]
ORDER BY
    [fecha]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Ingreso_efectivo_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Ingreso_efectivo_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Ingreso_efectivo_GetCmb]
AS

SELECT
    [id_ingreso_efectivo],
    [fecha],
    [comprobante],
    [importe],
    [iva],
    [detalle],
    [id_empresa],
    [control],
    [id_cliente],
    [archivado]
FROM
    [dbo].[Ingreso_efectivo]
ORDER BY
    [fecha]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Ingreso_efectivo_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Ingreso_efectivo_Update]
GO

CREATE PROCEDURE [dbo].[cop_Ingreso_efectivo_Update]
    @id_ingreso_efectivo    int  output,
    @fecha    datetime  ,
    @comprobante    varchar  (50),
    @importe    decimal  (18,2),
    @iva    decimal  (18,2),
    @detalle    varchar  (50),
    @id_empresa    int  ,
    @control    bit  ,
    @id_cliente    int  ,
    @archivado    bit  
AS

UPDATE [dbo].[Ingreso_efectivo] SET
    [fecha] = @fecha,
    [comprobante] = @comprobante,
    [importe] = @importe,
    [iva] = @iva,
    [detalle] = @detalle,
    [id_empresa] = @id_empresa,
    [control] = @control,
    [id_cliente] = @id_cliente,
    [archivado] = @archivado
WHERE
    [id_ingreso_efectivo]  =  @id_ingreso_efectivo
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Ingreso_efectivo_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Ingreso_efectivo_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Ingreso_efectivo_Exist]
    @fecha    datetime  ,
    @comprobante    varchar  (50),
    @importe    decimal  (18,2),
    @iva    decimal  (18,2),
    @detalle    varchar  (50),
    @id_empresa    int  ,
    @control    bit  ,
    @id_cliente    int  ,
    @archivado    bit  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_ingreso_efectivo
FROM
    [dbo].[Ingreso_efectivo]
WHERE
    [fecha] = @fecha AND
    [comprobante] = @comprobante AND
    [importe] = @importe AND
    [iva] = @iva AND
    [detalle] = @detalle AND
    [id_empresa] = @id_empresa AND
    [control] = @control AND
    [id_cliente] = @id_cliente AND
    [archivado] = @archivado

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Ingreso_efectivo_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Ingreso_efectivo_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Ingreso_efectivo_GetOne]
    @id_ingreso_efectivo    int
AS

SELECT
    [id_ingreso_efectivo] AS [Id ingreso efectivo] ,
    [fecha] AS [Fecha] ,
    [comprobante] AS [Comprobante] ,
    [importe] AS [Importe] ,
    [iva] AS [Iva] ,
    [detalle] AS [Detalle] ,
    [id_empresa] AS [Id empresa] ,
    [control] AS [Control] ,
    [id_cliente] AS [Id cliente] ,
    [archivado] AS [Archivado]
FROM
    [dbo].[Ingreso_efectivo]
WHERE
    [id_ingreso_efectivo]  =  @id_ingreso_efectivo
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Ingreso_efectivo_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Ingreso_efectivo_Find]
GO

CREATE PROCEDURE [dbo].[cop_Ingreso_efectivo_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_ingreso_efectivo] AS [Id ingreso efectivo] ,
    [fecha] AS [Fecha] ,
    RTRIM(comprobante) AS [Comprobante] ,
    [importe] AS [Importe] ,
    [iva] AS [Iva] ,
    RTRIM(detalle) AS [Detalle] ,
    [id_empresa] AS [Id empresa] ,
    [control] AS [Control] ,
    [id_cliente] AS [Id cliente] ,
    [archivado] AS [Archivado]
FROM
    [dbo].[Ingreso_efectivo]
WHERE
    [fecha] LIKE @nombre+'%'
ORDER BY
    [fecha]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Ingreso_efectivo_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Ingreso_efectivo_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Ingreso_efectivo_InsertOne]
AS

INSERT INTO [dbo].[Ingreso_efectivo]
(
    [fecha],
    [comprobante],
    [importe],
    [iva],
    [detalle],
    [id_empresa],
    [control],
    [id_cliente],
    [archivado]
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
    1,
     0 
)
GO

