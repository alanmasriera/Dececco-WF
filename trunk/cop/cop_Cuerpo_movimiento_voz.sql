USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Cuerpo_movimiento_voz_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Cuerpo_movimiento_voz_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Cuerpo_movimiento_voz_Insert]
    @id_cuerpo_movimiento_voz    int  output,
    @id_voz    int  ,
    @nc1    bit  ,
    @ok1    bit  ,
    @corresponde1    bit  ,
    @conforme1    bit  ,
    @no_conforme1    bit  ,
    @tipo1    varchar  (50),
    @detalle1    varchar  (5000),
    @correccion1    bit  ,
    @id_movimiento_voz    int  ,
    @id_usuario    int  ,
    @corresponde2    bit  ,
    @conforme2    bit  ,
    @no_conforme2    bit  ,
    @tipo2    varchar  (50),
    @detalle2    varchar  (5000),
    @correccion2    bit  ,
    @random    decimal  (18,0),
    @completado    bit  ,
    @completado_pm    bit  ,
    @control1    bit  ,
    @control2    bit  ,
    @control3    bit  ,
    @pedido_segundo_control    bit  ,
    @numero_revision    decimal  (18,0),
    @corresponde    bit  
AS

INSERT INTO [dbo].[Cuerpo_movimiento_voz]
(
    [id_voz],
    [nc1],
    [ok1],
    [corresponde1],
    [conforme1],
    [no_conforme1],
    [tipo1],
    [detalle1],
    [correccion1],
    [id_movimiento_voz],
    [id_usuario],
    [corresponde2],
    [conforme2],
    [no_conforme2],
    [tipo2],
    [detalle2],
    [correccion2],
    [random],
    [completado],
    [completado_pm],
    [control1],
    [control2],
    [control3],
    [pedido_segundo_control],
    [numero_revision],
    [corresponde]
)
VALUES
(
    @id_voz,
    @nc1,
    @ok1,
    @corresponde1,
    @conforme1,
    @no_conforme1,
    @tipo1,
    @detalle1,
    @correccion1,
    @id_movimiento_voz,
    @id_usuario,
    @corresponde2,
    @conforme2,
    @no_conforme2,
    @tipo2,
    @detalle2,
    @correccion2,
    @random,
    @completado,
    @completado_pm,
    @control1,
    @control2,
    @control3,
    @pedido_segundo_control,
    @numero_revision,
    @corresponde
)
SET @id_cuerpo_movimiento_voz = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Cuerpo_movimiento_voz_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Cuerpo_movimiento_voz_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Cuerpo_movimiento_voz_Delete]
    @id_cuerpo_movimiento_voz    int
AS

DELETE FROM [dbo].[Cuerpo_movimiento_voz]
WHERE
    [id_cuerpo_movimiento_voz]  =  @id_cuerpo_movimiento_voz
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Cuerpo_movimiento_voz_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Cuerpo_movimiento_voz_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Cuerpo_movimiento_voz_GetAll]
AS

SELECT TOP 100
    [id_cuerpo_movimiento_voz] AS [Id cuerpo movimiento voz] ,
    [id_voz] AS [Id voz] ,
    [nc1] AS [Nc1] ,
    [ok1] AS [Ok1] ,
    [corresponde1] AS [Corresponde1] ,
    [conforme1] AS [Conforme1] ,
    [no_conforme1] AS [No conforme1] ,
    RTRIM(tipo1) AS [Tipo1] ,
    RTRIM(detalle1) AS [Detalle1] ,
    [correccion1] AS [Correccion1] ,
    [id_movimiento_voz] AS [Id movimiento voz] ,
    [id_usuario] AS [Id usuario] ,
    [corresponde2] AS [Corresponde2] ,
    [conforme2] AS [Conforme2] ,
    [no_conforme2] AS [No conforme2] ,
    RTRIM(tipo2) AS [Tipo2] ,
    RTRIM(detalle2) AS [Detalle2] ,
    [correccion2] AS [Correccion2] ,
    [random] AS [Random] ,
    [completado] AS [Completado] ,
    [completado_pm] AS [Completado pm] ,
    [control1] AS [Control1] ,
    [control2] AS [Control2] ,
    [control3] AS [Control3] ,
    [pedido_segundo_control] AS [Pedido segundo control] ,
    [numero_revision] AS [Numero revision] ,
    [corresponde] AS [Corresponde]
FROM
    [dbo].[Cuerpo_movimiento_voz]
ORDER BY
    [id_voz]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Cuerpo_movimiento_voz_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Cuerpo_movimiento_voz_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Cuerpo_movimiento_voz_GetCmb]
AS

SELECT
    [id_cuerpo_movimiento_voz],
    [id_voz],
    [nc1],
    [ok1],
    [corresponde1],
    [conforme1],
    [no_conforme1],
    [tipo1],
    [detalle1],
    [correccion1],
    [id_movimiento_voz],
    [id_usuario],
    [corresponde2],
    [conforme2],
    [no_conforme2],
    [tipo2],
    [detalle2],
    [correccion2],
    [random],
    [completado],
    [completado_pm],
    [control1],
    [control2],
    [control3],
    [pedido_segundo_control],
    [numero_revision],
    [corresponde]
FROM
    [dbo].[Cuerpo_movimiento_voz]
ORDER BY
    [id_voz]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Cuerpo_movimiento_voz_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Cuerpo_movimiento_voz_Update]
GO

CREATE PROCEDURE [dbo].[cop_Cuerpo_movimiento_voz_Update]
    @id_cuerpo_movimiento_voz    int  output,
    @id_voz    int  ,
    @nc1    bit  ,
    @ok1    bit  ,
    @corresponde1    bit  ,
    @conforme1    bit  ,
    @no_conforme1    bit  ,
    @tipo1    varchar  (50),
    @detalle1    varchar  (5000),
    @correccion1    bit  ,
    @id_movimiento_voz    int  ,
    @id_usuario    int  ,
    @corresponde2    bit  ,
    @conforme2    bit  ,
    @no_conforme2    bit  ,
    @tipo2    varchar  (50),
    @detalle2    varchar  (5000),
    @correccion2    bit  ,
    @random    decimal  (18,0),
    @completado    bit  ,
    @completado_pm    bit  ,
    @control1    bit  ,
    @control2    bit  ,
    @control3    bit  ,
    @pedido_segundo_control    bit  ,
    @numero_revision    decimal  (18,0),
    @corresponde    bit  
AS

UPDATE [dbo].[Cuerpo_movimiento_voz] SET
    [id_voz] = @id_voz,
    [nc1] = @nc1,
    [ok1] = @ok1,
    [corresponde1] = @corresponde1,
    [conforme1] = @conforme1,
    [no_conforme1] = @no_conforme1,
    [tipo1] = @tipo1,
    [detalle1] = @detalle1,
    [correccion1] = @correccion1,
    [id_movimiento_voz] = @id_movimiento_voz,
    [id_usuario] = @id_usuario,
    [corresponde2] = @corresponde2,
    [conforme2] = @conforme2,
    [no_conforme2] = @no_conforme2,
    [tipo2] = @tipo2,
    [detalle2] = @detalle2,
    [correccion2] = @correccion2,
    [random] = @random,
    [completado] = @completado,
    [completado_pm] = @completado_pm,
    [control1] = @control1,
    [control2] = @control2,
    [control3] = @control3,
    [pedido_segundo_control] = @pedido_segundo_control,
    [numero_revision] = @numero_revision,
    [corresponde] = @corresponde
WHERE
    [id_cuerpo_movimiento_voz]  =  @id_cuerpo_movimiento_voz
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Cuerpo_movimiento_voz_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Cuerpo_movimiento_voz_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Cuerpo_movimiento_voz_Exist]
    @id_voz    int  ,
    @nc1    bit  ,
    @ok1    bit  ,
    @corresponde1    bit  ,
    @conforme1    bit  ,
    @no_conforme1    bit  ,
    @tipo1    varchar  (50),
    @detalle1    varchar  (5000),
    @correccion1    bit  ,
    @id_movimiento_voz    int  ,
    @id_usuario    int  ,
    @corresponde2    bit  ,
    @conforme2    bit  ,
    @no_conforme2    bit  ,
    @tipo2    varchar  (50),
    @detalle2    varchar  (5000),
    @correccion2    bit  ,
    @random    decimal  (18,0),
    @completado    bit  ,
    @completado_pm    bit  ,
    @control1    bit  ,
    @control2    bit  ,
    @control3    bit  ,
    @pedido_segundo_control    bit  ,
    @numero_revision    decimal  (18,0),
    @corresponde    bit  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_cuerpo_movimiento_voz
FROM
    [dbo].[Cuerpo_movimiento_voz]
WHERE
    [id_voz] = @id_voz AND
    [nc1] = @nc1 AND
    [ok1] = @ok1 AND
    [corresponde1] = @corresponde1 AND
    [conforme1] = @conforme1 AND
    [no_conforme1] = @no_conforme1 AND
    [tipo1] = @tipo1 AND
    [detalle1] = @detalle1 AND
    [correccion1] = @correccion1 AND
    [id_movimiento_voz] = @id_movimiento_voz AND
    [id_usuario] = @id_usuario AND
    [corresponde2] = @corresponde2 AND
    [conforme2] = @conforme2 AND
    [no_conforme2] = @no_conforme2 AND
    [tipo2] = @tipo2 AND
    [detalle2] = @detalle2 AND
    [correccion2] = @correccion2 AND
    [random] = @random AND
    [completado] = @completado AND
    [completado_pm] = @completado_pm AND
    [control1] = @control1 AND
    [control2] = @control2 AND
    [control3] = @control3 AND
    [pedido_segundo_control] = @pedido_segundo_control AND
    [numero_revision] = @numero_revision AND
    [corresponde] = @corresponde

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Cuerpo_movimiento_voz_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Cuerpo_movimiento_voz_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Cuerpo_movimiento_voz_GetOne]
    @id_cuerpo_movimiento_voz    int
AS

SELECT
    [id_cuerpo_movimiento_voz] AS [Id cuerpo movimiento voz] ,
    [id_voz] AS [Id voz] ,
    [nc1] AS [Nc1] ,
    [ok1] AS [Ok1] ,
    [corresponde1] AS [Corresponde1] ,
    [conforme1] AS [Conforme1] ,
    [no_conforme1] AS [No conforme1] ,
    [tipo1] AS [Tipo1] ,
    [detalle1] AS [Detalle1] ,
    [correccion1] AS [Correccion1] ,
    [id_movimiento_voz] AS [Id movimiento voz] ,
    [id_usuario] AS [Id usuario] ,
    [corresponde2] AS [Corresponde2] ,
    [conforme2] AS [Conforme2] ,
    [no_conforme2] AS [No conforme2] ,
    [tipo2] AS [Tipo2] ,
    [detalle2] AS [Detalle2] ,
    [correccion2] AS [Correccion2] ,
    [random] AS [Random] ,
    [completado] AS [Completado] ,
    [completado_pm] AS [Completado pm] ,
    [control1] AS [Control1] ,
    [control2] AS [Control2] ,
    [control3] AS [Control3] ,
    [pedido_segundo_control] AS [Pedido segundo control] ,
    [numero_revision] AS [Numero revision] ,
    [corresponde] AS [Corresponde]
FROM
    [dbo].[Cuerpo_movimiento_voz]
WHERE
    [id_cuerpo_movimiento_voz]  =  @id_cuerpo_movimiento_voz
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Cuerpo_movimiento_voz_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Cuerpo_movimiento_voz_Find]
GO

CREATE PROCEDURE [dbo].[cop_Cuerpo_movimiento_voz_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_cuerpo_movimiento_voz] AS [Id cuerpo movimiento voz] ,
    [id_voz] AS [Id voz] ,
    [nc1] AS [Nc1] ,
    [ok1] AS [Ok1] ,
    [corresponde1] AS [Corresponde1] ,
    [conforme1] AS [Conforme1] ,
    [no_conforme1] AS [No conforme1] ,
    RTRIM(tipo1) AS [Tipo1] ,
    RTRIM(detalle1) AS [Detalle1] ,
    [correccion1] AS [Correccion1] ,
    [id_movimiento_voz] AS [Id movimiento voz] ,
    [id_usuario] AS [Id usuario] ,
    [corresponde2] AS [Corresponde2] ,
    [conforme2] AS [Conforme2] ,
    [no_conforme2] AS [No conforme2] ,
    RTRIM(tipo2) AS [Tipo2] ,
    RTRIM(detalle2) AS [Detalle2] ,
    [correccion2] AS [Correccion2] ,
    [random] AS [Random] ,
    [completado] AS [Completado] ,
    [completado_pm] AS [Completado pm] ,
    [control1] AS [Control1] ,
    [control2] AS [Control2] ,
    [control3] AS [Control3] ,
    [pedido_segundo_control] AS [Pedido segundo control] ,
    [numero_revision] AS [Numero revision] ,
    [corresponde] AS [Corresponde]
FROM
    [dbo].[Cuerpo_movimiento_voz]
WHERE
    [id_voz] LIKE @nombre+'%'
ORDER BY
    [id_voz]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Cuerpo_movimiento_voz_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Cuerpo_movimiento_voz_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Cuerpo_movimiento_voz_InsertOne]
AS

INSERT INTO [dbo].[Cuerpo_movimiento_voz]
(
    [id_voz],
    [nc1],
    [ok1],
    [corresponde1],
    [conforme1],
    [no_conforme1],
    [tipo1],
    [detalle1],
    [correccion1],
    [id_movimiento_voz],
    [id_usuario],
    [corresponde2],
    [conforme2],
    [no_conforme2],
    [tipo2],
    [detalle2],
    [correccion2],
    [random],
    [completado],
    [completado_pm],
    [control1],
    [control2],
    [control3],
    [pedido_segundo_control],
    [numero_revision],
    [corresponde]
)
VALUES
(
    1,
    0,
    0,
    0,
    0,
    0,
    'Ninguno',
    'Ninguno',
    0,
    1,
    1,
    0,
    0,
    0,
    'Ninguno',
    'Ninguno',
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
     0 
)
GO

