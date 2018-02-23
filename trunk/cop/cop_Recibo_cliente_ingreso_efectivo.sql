USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_ingreso_efectivo_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_ingreso_efectivo_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_ingreso_efectivo_Insert]
    @id_Recibo_cliente_ingreso_efectivo    int  output,
    @id_pago_cliente    int  ,
    @id_ingreso_efectivo    int  ,
    @importe_pagado    decimal  (18,2)
AS

INSERT INTO [dbo].[Recibo_cliente_ingreso_efectivo]
(
    [id_pago_cliente],
    [id_ingreso_efectivo],
    [importe_pagado]
)
VALUES
(
    @id_pago_cliente,
    @id_ingreso_efectivo,
    @importe_pagado
)
SET @id_Recibo_cliente_ingreso_efectivo = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_ingreso_efectivo_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_ingreso_efectivo_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_ingreso_efectivo_Delete]
    @id_Recibo_cliente_ingreso_efectivo    int
AS

DELETE FROM [dbo].[Recibo_cliente_ingreso_efectivo]
WHERE
    [id_Recibo_cliente_ingreso_efectivo]  =  @id_Recibo_cliente_ingreso_efectivo
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_ingreso_efectivo_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_ingreso_efectivo_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_ingreso_efectivo_GetAll]
AS

SELECT TOP 100
    [id_Recibo_cliente_ingreso_efectivo] AS [Id recibo cliente ingreso efectivo] ,
    [id_pago_cliente] AS [Id pago cliente] ,
    [id_ingreso_efectivo] AS [Id ingreso efectivo] ,
    [importe_pagado] AS [Importe pagado]
FROM
    [dbo].[Recibo_cliente_ingreso_efectivo]
ORDER BY
    [id_pago_cliente]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_ingreso_efectivo_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_ingreso_efectivo_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_ingreso_efectivo_GetCmb]
AS

SELECT
    [id_Recibo_cliente_ingreso_efectivo],
    [id_pago_cliente],
    [id_ingreso_efectivo],
    [importe_pagado]
FROM
    [dbo].[Recibo_cliente_ingreso_efectivo]
ORDER BY
    [id_pago_cliente]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_ingreso_efectivo_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_ingreso_efectivo_Update]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_ingreso_efectivo_Update]
    @id_Recibo_cliente_ingreso_efectivo    int  output,
    @id_pago_cliente    int  ,
    @id_ingreso_efectivo    int  ,
    @importe_pagado    decimal  (18,2)
AS

UPDATE [dbo].[Recibo_cliente_ingreso_efectivo] SET
    [id_pago_cliente] = @id_pago_cliente,
    [id_ingreso_efectivo] = @id_ingreso_efectivo,
    [importe_pagado] = @importe_pagado
WHERE
    [id_Recibo_cliente_ingreso_efectivo]  =  @id_Recibo_cliente_ingreso_efectivo
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_ingreso_efectivo_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_ingreso_efectivo_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_ingreso_efectivo_Exist]
    @id_pago_cliente    int  ,
    @id_ingreso_efectivo    int  ,
    @importe_pagado    decimal  (18,2)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_Recibo_cliente_ingreso_efectivo
FROM
    [dbo].[Recibo_cliente_ingreso_efectivo]
WHERE
    [id_pago_cliente] = @id_pago_cliente AND
    [id_ingreso_efectivo] = @id_ingreso_efectivo AND
    [importe_pagado] = @importe_pagado

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_ingreso_efectivo_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_ingreso_efectivo_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_ingreso_efectivo_GetOne]
    @id_Recibo_cliente_ingreso_efectivo    int
AS

SELECT
    [id_Recibo_cliente_ingreso_efectivo] AS [Id recibo cliente ingreso efectivo] ,
    [id_pago_cliente] AS [Id pago cliente] ,
    [id_ingreso_efectivo] AS [Id ingreso efectivo] ,
    [importe_pagado] AS [Importe pagado]
FROM
    [dbo].[Recibo_cliente_ingreso_efectivo]
WHERE
    [id_Recibo_cliente_ingreso_efectivo]  =  @id_Recibo_cliente_ingreso_efectivo
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_ingreso_efectivo_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_ingreso_efectivo_Find]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_ingreso_efectivo_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_Recibo_cliente_ingreso_efectivo] AS [Id recibo cliente ingreso efectivo] ,
    [id_pago_cliente] AS [Id pago cliente] ,
    [id_ingreso_efectivo] AS [Id ingreso efectivo] ,
    [importe_pagado] AS [Importe pagado]
FROM
    [dbo].[Recibo_cliente_ingreso_efectivo]
WHERE
    [id_pago_cliente] LIKE @nombre+'%'
ORDER BY
    [id_pago_cliente]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_ingreso_efectivo_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_ingreso_efectivo_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_ingreso_efectivo_InsertOne]
AS

INSERT INTO [dbo].[Recibo_cliente_ingreso_efectivo]
(
    [id_pago_cliente],
    [id_ingreso_efectivo],
    [importe_pagado]
)
VALUES
(
    1,
    1,
     0 
)
GO

