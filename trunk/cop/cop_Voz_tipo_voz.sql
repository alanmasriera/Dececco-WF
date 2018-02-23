USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Voz_tipo_voz_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Voz_tipo_voz_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Voz_tipo_voz_Insert]
    @id_voz_tipo_voz    int  output,
    @id_voz    int  ,
    @id_tipo_voz    int  ,
    @porcentaje_voz    decimal  (18,2),
    @porcentaje_tipo_voz    decimal  (18,2),
    @indice    int  ,
    @nro    int  
AS

INSERT INTO [dbo].[Voz_tipo_voz]
(
    [id_voz],
    [id_tipo_voz],
    [porcentaje_voz],
    [porcentaje_tipo_voz],
    [indice],
    [nro]
)
VALUES
(
    @id_voz,
    @id_tipo_voz,
    @porcentaje_voz,
    @porcentaje_tipo_voz,
    @indice,
    @nro
)
SET @id_voz_tipo_voz = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Voz_tipo_voz_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Voz_tipo_voz_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Voz_tipo_voz_Delete]
    @id_voz_tipo_voz    int
AS

DELETE FROM [dbo].[Voz_tipo_voz]
WHERE
    [id_voz_tipo_voz]  =  @id_voz_tipo_voz
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Voz_tipo_voz_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Voz_tipo_voz_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Voz_tipo_voz_GetAll]
AS

SELECT TOP 100
    [id_voz_tipo_voz] AS [Id voz tipo voz] ,
    [id_voz] AS [Id voz] ,
    [id_tipo_voz] AS [Id tipo voz] ,
    [porcentaje_voz] AS [Porcentaje voz] ,
    [porcentaje_tipo_voz] AS [Porcentaje tipo voz] ,
    [indice] AS [Indice] ,
    [nro] AS [Nro]
FROM
    [dbo].[Voz_tipo_voz]
ORDER BY
    [id_voz]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Voz_tipo_voz_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Voz_tipo_voz_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Voz_tipo_voz_GetCmb]
AS

SELECT
    [id_voz_tipo_voz],
    [id_voz],
    [id_tipo_voz],
    [porcentaje_voz],
    [porcentaje_tipo_voz],
    [indice],
    [nro]
FROM
    [dbo].[Voz_tipo_voz]
ORDER BY
    [id_voz]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Voz_tipo_voz_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Voz_tipo_voz_Update]
GO

CREATE PROCEDURE [dbo].[cop_Voz_tipo_voz_Update]
    @id_voz_tipo_voz    int  output,
    @id_voz    int  ,
    @id_tipo_voz    int  ,
    @porcentaje_voz    decimal  (18,2),
    @porcentaje_tipo_voz    decimal  (18,2),
    @indice    int  ,
    @nro    int  
AS

UPDATE [dbo].[Voz_tipo_voz] SET
    [id_voz] = @id_voz,
    [id_tipo_voz] = @id_tipo_voz,
    [porcentaje_voz] = @porcentaje_voz,
    [porcentaje_tipo_voz] = @porcentaje_tipo_voz,
    [indice] = @indice,
    [nro] = @nro
WHERE
    [id_voz_tipo_voz]  =  @id_voz_tipo_voz
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Voz_tipo_voz_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Voz_tipo_voz_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Voz_tipo_voz_Exist]
    @id_voz    int  ,
    @id_tipo_voz    int  ,
    @porcentaje_voz    decimal  (18,2),
    @porcentaje_tipo_voz    decimal  (18,2),
    @indice    int  ,
    @nro    int  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_voz_tipo_voz
FROM
    [dbo].[Voz_tipo_voz]
WHERE
    [id_voz] = @id_voz AND
    [id_tipo_voz] = @id_tipo_voz AND
    [porcentaje_voz] = @porcentaje_voz AND
    [porcentaje_tipo_voz] = @porcentaje_tipo_voz AND
    [indice] = @indice AND
    [nro] = @nro

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Voz_tipo_voz_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Voz_tipo_voz_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Voz_tipo_voz_GetOne]
    @id_voz_tipo_voz    int
AS

SELECT
    [id_voz_tipo_voz] AS [Id voz tipo voz] ,
    [id_voz] AS [Id voz] ,
    [id_tipo_voz] AS [Id tipo voz] ,
    [porcentaje_voz] AS [Porcentaje voz] ,
    [porcentaje_tipo_voz] AS [Porcentaje tipo voz] ,
    [indice] AS [Indice] ,
    [nro] AS [Nro]
FROM
    [dbo].[Voz_tipo_voz]
WHERE
    [id_voz_tipo_voz]  =  @id_voz_tipo_voz
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Voz_tipo_voz_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Voz_tipo_voz_Find]
GO

CREATE PROCEDURE [dbo].[cop_Voz_tipo_voz_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_voz_tipo_voz] AS [Id voz tipo voz] ,
    [id_voz] AS [Id voz] ,
    [id_tipo_voz] AS [Id tipo voz] ,
    [porcentaje_voz] AS [Porcentaje voz] ,
    [porcentaje_tipo_voz] AS [Porcentaje tipo voz] ,
    [indice] AS [Indice] ,
    [nro] AS [Nro]
FROM
    [dbo].[Voz_tipo_voz]
WHERE
    [id_voz] LIKE @nombre+'%'
ORDER BY
    [id_voz]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Voz_tipo_voz_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Voz_tipo_voz_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Voz_tipo_voz_InsertOne]
AS

INSERT INTO [dbo].[Voz_tipo_voz]
(
    [id_voz],
    [id_tipo_voz],
    [porcentaje_voz],
    [porcentaje_tipo_voz],
    [indice],
    [nro]
)
VALUES
(
    1,
    1,
    0,
    0,
    1,
     1 
)
GO

