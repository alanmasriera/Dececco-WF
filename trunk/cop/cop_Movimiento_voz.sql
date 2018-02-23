USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Movimiento_voz_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Movimiento_voz_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Movimiento_voz_Insert]
    @id_movimiento_voz    int  output,
    @id_control    int  ,
    @fecha    datetime  ,
    @ot    varchar  (50),
    @id_actividad_proyecto    int  ,
    @id_cadista    int  ,
    @id_proyect_manager    int  ,
    @id_controlador_1    int  ,
    @id_controlador_2    int  ,
    @completado    bit  ,
    @id_usuario_anterior    int  
AS

INSERT INTO [dbo].[Movimiento_voz]
(
    [id_control],
    [fecha],
    [ot],
    [id_actividad_proyecto],
    [id_cadista],
    [id_proyect_manager],
    [id_controlador_1],
    [id_controlador_2],
    [completado],
    [id_usuario_anterior]
)
VALUES
(
    @id_control,
    @fecha,
    @ot,
    @id_actividad_proyecto,
    @id_cadista,
    @id_proyect_manager,
    @id_controlador_1,
    @id_controlador_2,
    @completado,
    @id_usuario_anterior
)
SET @id_movimiento_voz = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Movimiento_voz_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Movimiento_voz_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Movimiento_voz_Delete]
    @id_movimiento_voz    int
AS

DELETE FROM [dbo].[Movimiento_voz]
WHERE
    [id_movimiento_voz]  =  @id_movimiento_voz
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Movimiento_voz_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Movimiento_voz_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Movimiento_voz_GetAll]
AS

SELECT TOP 100
    [id_movimiento_voz] AS [Id movimiento voz] ,
    [id_control] AS [Id control] ,
    [fecha] AS [Fecha] ,
    RTRIM(ot) AS [Ot] ,
    [id_actividad_proyecto] AS [Id actividad proyecto] ,
    [id_cadista] AS [Id cadista] ,
    [id_proyect_manager] AS [Id proyect manager] ,
    [id_controlador_1] AS [Id controlador 1] ,
    [id_controlador_2] AS [Id controlador 2] ,
    [completado] AS [Completado] ,
    [id_usuario_anterior] AS [Id usuario anterior]
FROM
    [dbo].[Movimiento_voz]
ORDER BY
    [id_control]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Movimiento_voz_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Movimiento_voz_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Movimiento_voz_GetCmb]
AS

SELECT
    [id_movimiento_voz],
    [id_control],
    [fecha],
    [ot],
    [id_actividad_proyecto],
    [id_cadista],
    [id_proyect_manager],
    [id_controlador_1],
    [id_controlador_2],
    [completado],
    [id_usuario_anterior]
FROM
    [dbo].[Movimiento_voz]
ORDER BY
    [id_control]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Movimiento_voz_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Movimiento_voz_Update]
GO

CREATE PROCEDURE [dbo].[cop_Movimiento_voz_Update]
    @id_movimiento_voz    int  output,
    @id_control    int  ,
    @fecha    datetime  ,
    @ot    varchar  (50),
    @id_actividad_proyecto    int  ,
    @id_cadista    int  ,
    @id_proyect_manager    int  ,
    @id_controlador_1    int  ,
    @id_controlador_2    int  ,
    @completado    bit  ,
    @id_usuario_anterior    int  
AS

UPDATE [dbo].[Movimiento_voz] SET
    [id_control] = @id_control,
    [fecha] = @fecha,
    [ot] = @ot,
    [id_actividad_proyecto] = @id_actividad_proyecto,
    [id_cadista] = @id_cadista,
    [id_proyect_manager] = @id_proyect_manager,
    [id_controlador_1] = @id_controlador_1,
    [id_controlador_2] = @id_controlador_2,
    [completado] = @completado,
    [id_usuario_anterior] = @id_usuario_anterior
WHERE
    [id_movimiento_voz]  =  @id_movimiento_voz
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Movimiento_voz_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Movimiento_voz_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Movimiento_voz_Exist]
    @id_control    int  ,
    @fecha    datetime  ,
    @ot    varchar  (50),
    @id_actividad_proyecto    int  ,
    @id_cadista    int  ,
    @id_proyect_manager    int  ,
    @id_controlador_1    int  ,
    @id_controlador_2    int  ,
    @completado    bit  ,
    @id_usuario_anterior    int  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_movimiento_voz
FROM
    [dbo].[Movimiento_voz]
WHERE
    [id_control] = @id_control AND
    [fecha] = @fecha AND
    [ot] = @ot AND
    [id_actividad_proyecto] = @id_actividad_proyecto AND
    [id_cadista] = @id_cadista AND
    [id_proyect_manager] = @id_proyect_manager AND
    [id_controlador_1] = @id_controlador_1 AND
    [id_controlador_2] = @id_controlador_2 AND
    [completado] = @completado AND
    [id_usuario_anterior] = @id_usuario_anterior

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Movimiento_voz_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Movimiento_voz_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Movimiento_voz_GetOne]
    @id_movimiento_voz    int
AS

SELECT
    [id_movimiento_voz] AS [Id movimiento voz] ,
    [id_control] AS [Id control] ,
    [fecha] AS [Fecha] ,
    [ot] AS [Ot] ,
    [id_actividad_proyecto] AS [Id actividad proyecto] ,
    [id_cadista] AS [Id cadista] ,
    [id_proyect_manager] AS [Id proyect manager] ,
    [id_controlador_1] AS [Id controlador 1] ,
    [id_controlador_2] AS [Id controlador 2] ,
    [completado] AS [Completado] ,
    [id_usuario_anterior] AS [Id usuario anterior]
FROM
    [dbo].[Movimiento_voz]
WHERE
    [id_movimiento_voz]  =  @id_movimiento_voz
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Movimiento_voz_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Movimiento_voz_Find]
GO

CREATE PROCEDURE [dbo].[cop_Movimiento_voz_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_movimiento_voz] AS [Id movimiento voz] ,
    [id_control] AS [Id control] ,
    [fecha] AS [Fecha] ,
    RTRIM(ot) AS [Ot] ,
    [id_actividad_proyecto] AS [Id actividad proyecto] ,
    [id_cadista] AS [Id cadista] ,
    [id_proyect_manager] AS [Id proyect manager] ,
    [id_controlador_1] AS [Id controlador 1] ,
    [id_controlador_2] AS [Id controlador 2] ,
    [completado] AS [Completado] ,
    [id_usuario_anterior] AS [Id usuario anterior]
FROM
    [dbo].[Movimiento_voz]
WHERE
    [id_control] LIKE @nombre+'%'
ORDER BY
    [id_control]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Movimiento_voz_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Movimiento_voz_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Movimiento_voz_InsertOne]
AS

INSERT INTO [dbo].[Movimiento_voz]
(
    [id_control],
    [fecha],
    [ot],
    [id_actividad_proyecto],
    [id_cadista],
    [id_proyect_manager],
    [id_controlador_1],
    [id_controlador_2],
    [completado],
    [id_usuario_anterior]
)
VALUES
(
    1,
    '01-01-2000',
    'Ninguno',
    1,
    1,
    1,
    1,
    1,
    0,
     1 
)
GO

