USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_egreso_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_egreso_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_egreso_Insert]
    @id_tipo_egreso    int  output,
    @nombre_tipo_egreso    varchar  (50)
AS

INSERT INTO [dbo].[Tipo_egreso]
(
    [nombre_tipo_egreso]
)
VALUES
(
    @nombre_tipo_egreso
)
SET @id_tipo_egreso = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_egreso_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_egreso_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_egreso_Delete]
    @id_tipo_egreso    int
AS

DELETE FROM [dbo].[Tipo_egreso]
WHERE
    [id_tipo_egreso]  =  @id_tipo_egreso
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_egreso_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_egreso_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_egreso_GetAll]
AS

SELECT TOP 100
    [id_tipo_egreso] AS [Id tipo egreso] ,
    RTRIM(nombre_tipo_egreso) AS [Nombre tipo egreso]
FROM
    [dbo].[Tipo_egreso]
ORDER BY
    [nombre_tipo_egreso]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_egreso_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_egreso_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_egreso_GetCmb]
AS

SELECT
    [id_tipo_egreso],
    [nombre_tipo_egreso]
FROM
    [dbo].[Tipo_egreso]
ORDER BY
    [nombre_tipo_egreso]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_egreso_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_egreso_Update]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_egreso_Update]
    @id_tipo_egreso    int  output,
    @nombre_tipo_egreso    varchar  (50)
AS

UPDATE [dbo].[Tipo_egreso] SET
    [nombre_tipo_egreso] = @nombre_tipo_egreso
WHERE
    [id_tipo_egreso]  =  @id_tipo_egreso
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_egreso_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_egreso_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_egreso_Exist]
    @nombre_tipo_egreso    varchar  (50)
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_tipo_egreso
FROM
    [dbo].[Tipo_egreso]
WHERE
    [nombre_tipo_egreso] = @nombre_tipo_egreso

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_egreso_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_egreso_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_egreso_GetOne]
    @id_tipo_egreso    int
AS

SELECT
    [id_tipo_egreso] AS [Id tipo egreso] ,
    [nombre_tipo_egreso] AS [Nombre tipo egreso]
FROM
    [dbo].[Tipo_egreso]
WHERE
    [id_tipo_egreso]  =  @id_tipo_egreso
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_egreso_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_egreso_Find]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_egreso_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_tipo_egreso] AS [Id tipo egreso] ,
    RTRIM(nombre_tipo_egreso) AS [Nombre tipo egreso]
FROM
    [dbo].[Tipo_egreso]
WHERE
    [nombre_tipo_egreso] LIKE @nombre+'%'
ORDER BY
    [nombre_tipo_egreso]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Tipo_egreso_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Tipo_egreso_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Tipo_egreso_InsertOne]
AS

INSERT INTO [dbo].[Tipo_egreso]
(
    [nombre_tipo_egreso]
)
VALUES
(
    'Ninguno'
)
GO

