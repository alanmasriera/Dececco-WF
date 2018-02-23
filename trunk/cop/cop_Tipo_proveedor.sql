USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_proveedor_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_proveedor_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_proveedor_Insert]
    @id_tipo_proveedor    int  output,
    @nombre_tipo_cliente    varchar  (50)
AS

INSERT INTO [dbo].[Tipo_proveedor]
(
    [nombre_tipo_cliente]
)
VALUES
(
    @nombre_tipo_cliente
)
SET @id_tipo_proveedor = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_proveedor_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_proveedor_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_proveedor_Delete]
    @id_tipo_proveedor    int
AS

DELETE FROM [dbo].[Tipo_proveedor]
WHERE
    [id_tipo_proveedor]  =  @id_tipo_proveedor
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_proveedor_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_proveedor_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_proveedor_GetAll]
AS

SELECT TOP 100
    [id_tipo_proveedor] AS [Id tipo proveedor] ,
    RTRIM(nombre_tipo_cliente) AS [Nombre tipo cliente]
FROM
    [dbo].[Tipo_proveedor]
ORDER BY
    [nombre_tipo_cliente]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_proveedor_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_proveedor_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_proveedor_GetCmb]
AS

SELECT
    [id_tipo_proveedor],
    [nombre_tipo_cliente]
FROM
    [dbo].[Tipo_proveedor]
ORDER BY
    [nombre_tipo_cliente]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_proveedor_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_proveedor_Update]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_proveedor_Update]
    @id_tipo_proveedor    int  output,
    @nombre_tipo_cliente    varchar  (50)
AS

UPDATE [dbo].[Tipo_proveedor] SET
    [nombre_tipo_cliente] = @nombre_tipo_cliente
WHERE
    [id_tipo_proveedor]  =  @id_tipo_proveedor
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_proveedor_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_proveedor_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_proveedor_Exist]
    @nombre_tipo_cliente    varchar  (50)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_tipo_proveedor
FROM
    [dbo].[Tipo_proveedor]
WHERE
    [nombre_tipo_cliente] = @nombre_tipo_cliente

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_proveedor_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_proveedor_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_proveedor_GetOne]
    @id_tipo_proveedor    int
AS

SELECT
    [id_tipo_proveedor] AS [Id tipo proveedor] ,
    [nombre_tipo_cliente] AS [Nombre tipo cliente]
FROM
    [dbo].[Tipo_proveedor]
WHERE
    [id_tipo_proveedor]  =  @id_tipo_proveedor
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_proveedor_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_proveedor_Find]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_proveedor_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_tipo_proveedor] AS [Id tipo proveedor] ,
    RTRIM(nombre_tipo_cliente) AS [Nombre tipo cliente]
FROM
    [dbo].[Tipo_proveedor]
WHERE
    [nombre_tipo_cliente] LIKE @nombre+'%'
ORDER BY
    [nombre_tipo_cliente]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_proveedor_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_proveedor_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_proveedor_InsertOne]
AS

INSERT INTO [dbo].[Tipo_proveedor]
(
    [nombre_tipo_cliente]
)
VALUES
(
    'Ninguno'
)
GO

