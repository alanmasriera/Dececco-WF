USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_cheque_2_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_cheque_2_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_cheque_2_Insert]
    @id_recibo_cliente_cheque_2    int  output,
    @id_pago_cliente    int  ,
    @id_cheque_recibo    int  ,
    @control    bit  
AS

INSERT INTO [dbo].[Recibo_cliente_cheque_2]
(
    [id_pago_cliente],
    [id_cheque_recibo],
    [control]
)
VALUES
(
    @id_pago_cliente,
    @id_cheque_recibo,
    @control
)
SET @id_recibo_cliente_cheque_2 = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_cheque_2_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_cheque_2_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_cheque_2_Delete]
    @id_recibo_cliente_cheque_2    int
AS

DELETE FROM [dbo].[Recibo_cliente_cheque_2]
WHERE
    [id_recibo_cliente_cheque_2]  =  @id_recibo_cliente_cheque_2
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_cheque_2_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_cheque_2_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_cheque_2_GetAll]
AS

SELECT TOP 100
    [id_recibo_cliente_cheque_2] AS [Id recibo cliente cheque 2] ,
    [id_pago_cliente] AS [Id pago cliente] ,
    [id_cheque_recibo] AS [Id cheque recibo] ,
    [control] AS [Control]
FROM
    [dbo].[Recibo_cliente_cheque_2]
ORDER BY
    [id_pago_cliente]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_cheque_2_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_cheque_2_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_cheque_2_GetCmb]
AS

SELECT
    [id_recibo_cliente_cheque_2],
    [id_pago_cliente],
    [id_cheque_recibo],
    [control]
FROM
    [dbo].[Recibo_cliente_cheque_2]
ORDER BY
    [id_pago_cliente]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_cheque_2_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_cheque_2_Update]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_cheque_2_Update]
    @id_recibo_cliente_cheque_2    int  output,
    @id_pago_cliente    int  ,
    @id_cheque_recibo    int  ,
    @control    bit  
AS

UPDATE [dbo].[Recibo_cliente_cheque_2] SET
    [id_pago_cliente] = @id_pago_cliente,
    [id_cheque_recibo] = @id_cheque_recibo,
    [control] = @control
WHERE
    [id_recibo_cliente_cheque_2]  =  @id_recibo_cliente_cheque_2
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_cheque_2_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_cheque_2_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_cheque_2_Exist]
    @id_pago_cliente    int  ,
    @id_cheque_recibo    int  ,
    @control    bit  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_recibo_cliente_cheque_2
FROM
    [dbo].[Recibo_cliente_cheque_2]
WHERE
    [id_pago_cliente] = @id_pago_cliente AND
    [id_cheque_recibo] = @id_cheque_recibo AND
    [control] = @control

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_cheque_2_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_cheque_2_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_cheque_2_GetOne]
    @id_recibo_cliente_cheque_2    int
AS

SELECT
    [id_recibo_cliente_cheque_2] AS [Id recibo cliente cheque 2] ,
    [id_pago_cliente] AS [Id pago cliente] ,
    [id_cheque_recibo] AS [Id cheque recibo] ,
    [control] AS [Control]
FROM
    [dbo].[Recibo_cliente_cheque_2]
WHERE
    [id_recibo_cliente_cheque_2]  =  @id_recibo_cliente_cheque_2
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_cheque_2_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_cheque_2_Find]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_cheque_2_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_recibo_cliente_cheque_2] AS [Id recibo cliente cheque 2] ,
    [id_pago_cliente] AS [Id pago cliente] ,
    [id_cheque_recibo] AS [Id cheque recibo] ,
    [control] AS [Control]
FROM
    [dbo].[Recibo_cliente_cheque_2]
WHERE
    [id_pago_cliente] LIKE @nombre+'%'
ORDER BY
    [id_pago_cliente]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Recibo_cliente_cheque_2_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Recibo_cliente_cheque_2_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Recibo_cliente_cheque_2_InsertOne]
AS

INSERT INTO [dbo].[Recibo_cliente_cheque_2]
(
    [id_pago_cliente],
    [id_cheque_recibo],
    [control]
)
VALUES
(
    1,
    1,
     0 
)
GO

