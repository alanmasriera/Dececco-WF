USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_Insert]
    @id_recibo_cliente    int  output,
    @id_pago_cliente    int  ,
    @id_factura    int  ,
    @importe_pagado    decimal  (18,2)
AS

INSERT INTO [dbo].[Recibo_cliente]
(
    [id_pago_cliente],
    [id_factura],
    [importe_pagado]
)
VALUES
(
    @id_pago_cliente,
    @id_factura,
    @importe_pagado
)
SET @id_recibo_cliente = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_Delete]
    @id_recibo_cliente    int
AS

DELETE FROM [dbo].[Recibo_cliente]
WHERE
    [id_recibo_cliente]  =  @id_recibo_cliente
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_GetAll]
AS

SELECT TOP 100
    [id_recibo_cliente] AS [Id recibo cliente] ,
    [id_pago_cliente] AS [Id pago cliente] ,
    [id_factura] AS [Id factura] ,
    [importe_pagado] AS [Importe pagado]
FROM
    [dbo].[Recibo_cliente]
ORDER BY
    [id_pago_cliente]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_GetCmb]
AS

SELECT
    [id_recibo_cliente],
    [id_pago_cliente],
    [id_factura],
    [importe_pagado]
FROM
    [dbo].[Recibo_cliente]
ORDER BY
    [id_pago_cliente]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_Update]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_Update]
    @id_recibo_cliente    int  output,
    @id_pago_cliente    int  ,
    @id_factura    int  ,
    @importe_pagado    decimal  (18,2)
AS

UPDATE [dbo].[Recibo_cliente] SET
    [id_pago_cliente] = @id_pago_cliente,
    [id_factura] = @id_factura,
    [importe_pagado] = @importe_pagado
WHERE
    [id_recibo_cliente]  =  @id_recibo_cliente
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_Exist]
    @id_pago_cliente    int  ,
    @id_factura    int  ,
    @importe_pagado    decimal  (18,2)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_recibo_cliente
FROM
    [dbo].[Recibo_cliente]
WHERE
    [id_pago_cliente] = @id_pago_cliente AND
    [id_factura] = @id_factura AND
    [importe_pagado] = @importe_pagado

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_GetOne]
    @id_recibo_cliente    int
AS

SELECT
    [id_recibo_cliente] AS [Id recibo cliente] ,
    [id_pago_cliente] AS [Id pago cliente] ,
    [id_factura] AS [Id factura] ,
    [importe_pagado] AS [Importe pagado]
FROM
    [dbo].[Recibo_cliente]
WHERE
    [id_recibo_cliente]  =  @id_recibo_cliente
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_Find]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_recibo_cliente] AS [Id recibo cliente] ,
    [id_pago_cliente] AS [Id pago cliente] ,
    [id_factura] AS [Id factura] ,
    [importe_pagado] AS [Importe pagado]
FROM
    [dbo].[Recibo_cliente]
WHERE
    [id_pago_cliente] LIKE @nombre+'%'
ORDER BY
    [id_pago_cliente]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_InsertOne]
AS

INSERT INTO [dbo].[Recibo_cliente]
(
    [id_pago_cliente],
    [id_factura],
    [importe_pagado]
)
VALUES
(
    1,
    1,
     0 
)
GO

