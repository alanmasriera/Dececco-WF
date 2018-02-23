USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Actividad_proyecto_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Actividad_proyecto_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Actividad_proyecto_Insert]
    @id_actividad_proyecto    int  output,
    @id_proyecto    int  ,
    @id_actividad    int  ,
    @fecha_inicio    datetime  ,
    @fecha_fin_previsto    datetime  ,
    @fecha_fin_real    datetime  ,
    @cantidad_hora    decimal  (10,2),
    @objetivo    varchar  (200),
    @prioridad    decimal  (10,2),
    @complejidad    decimal  (10,2),
    @avance    decimal  (10,2),
    @observacion    varchar  (500),
    @orden    decimal  (18,0),
    @id_controlador_1    int  ,
    @id_controlador_2    int  ,
    @nro    int  
AS

INSERT INTO [dbo].[Actividad_proyecto]
(
    [id_proyecto],
    [id_actividad],
    [fecha_inicio],
    [fecha_fin_previsto],
    [fecha_fin_real],
    [cantidad_hora],
    [objetivo],
    [prioridad],
    [complejidad],
    [avance],
    [observacion],
    [orden],
    [id_controlador_1],
    [id_controlador_2],
    [nro]
)
VALUES
(
    @id_proyecto,
    @id_actividad,
    @fecha_inicio,
    @fecha_fin_previsto,
    @fecha_fin_real,
    @cantidad_hora,
    @objetivo,
    @prioridad,
    @complejidad,
    @avance,
    @observacion,
    @orden,
    @id_controlador_1,
    @id_controlador_2,
    @nro
)
SET @id_actividad_proyecto = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Actividad_proyecto_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Actividad_proyecto_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Actividad_proyecto_Delete]
    @id_actividad_proyecto    int
AS

DELETE FROM [dbo].[Actividad_proyecto]
WHERE
    [id_actividad_proyecto]  =  @id_actividad_proyecto
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Actividad_proyecto_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Actividad_proyecto_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Actividad_proyecto_GetAll]
AS

SELECT TOP 100
    [id_actividad_proyecto] AS [Id actividad proyecto] ,
    [id_proyecto] AS [Id proyecto] ,
    [id_actividad] AS [Id actividad] ,
    [fecha_inicio] AS [Fecha inicio] ,
    [fecha_fin_previsto] AS [Fecha fin previsto] ,
    [fecha_fin_real] AS [Fecha fin real] ,
    [cantidad_hora] AS [Cantidad hora] ,
    RTRIM(objetivo) AS [Objetivo] ,
    [prioridad] AS [Prioridad] ,
    [complejidad] AS [Complejidad] ,
    [avance] AS [Avance] ,
    RTRIM(observacion) AS [Observacion] ,
    [orden] AS [Orden] ,
    [id_controlador_1] AS [Id controlador 1] ,
    [id_controlador_2] AS [Id controlador 2] ,
    [nro] AS [Nro]
FROM
    [dbo].[Actividad_proyecto]
ORDER BY
    [id_proyecto]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Actividad_proyecto_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Actividad_proyecto_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Actividad_proyecto_GetCmb]
AS

SELECT
    [id_actividad_proyecto],
    [id_proyecto],
    [id_actividad],
    [fecha_inicio],
    [fecha_fin_previsto],
    [fecha_fin_real],
    [cantidad_hora],
    [objetivo],
    [prioridad],
    [complejidad],
    [avance],
    [observacion],
    [orden],
    [id_controlador_1],
    [id_controlador_2],
    [nro]
FROM
    [dbo].[Actividad_proyecto]
ORDER BY
    [id_proyecto]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Actividad_proyecto_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Actividad_proyecto_Update]
GO

CREATE PROCEDURE [dbo].[cop_Actividad_proyecto_Update]
    @id_actividad_proyecto    int  output,
    @id_proyecto    int  ,
    @id_actividad    int  ,
    @fecha_inicio    datetime  ,
    @fecha_fin_previsto    datetime  ,
    @fecha_fin_real    datetime  ,
    @cantidad_hora    decimal  (10,2),
    @objetivo    varchar  (200),
    @prioridad    decimal  (10,2),
    @complejidad    decimal  (10,2),
    @avance    decimal  (10,2),
    @observacion    varchar  (500),
    @orden    decimal  (18,0),
    @id_controlador_1    int  ,
    @id_controlador_2    int  ,
    @nro    int  
AS

UPDATE [dbo].[Actividad_proyecto] SET
    [id_proyecto] = @id_proyecto,
    [id_actividad] = @id_actividad,
    [fecha_inicio] = @fecha_inicio,
    [fecha_fin_previsto] = @fecha_fin_previsto,
    [fecha_fin_real] = @fecha_fin_real,
    [cantidad_hora] = @cantidad_hora,
    [objetivo] = @objetivo,
    [prioridad] = @prioridad,
    [complejidad] = @complejidad,
    [avance] = @avance,
    [observacion] = @observacion,
    [orden] = @orden,
    [id_controlador_1] = @id_controlador_1,
    [id_controlador_2] = @id_controlador_2,
    [nro] = @nro
WHERE
    [id_actividad_proyecto]  =  @id_actividad_proyecto
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Actividad_proyecto_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Actividad_proyecto_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Actividad_proyecto_Exist]
    @id_proyecto    int  ,
    @id_actividad    int  ,
    @fecha_inicio    datetime  ,
    @fecha_fin_previsto    datetime  ,
    @fecha_fin_real    datetime  ,
    @cantidad_hora    decimal  (10,2),
    @objetivo    varchar  (200),
    @prioridad    decimal  (10,2),
    @complejidad    decimal  (10,2),
    @avance    decimal  (10,2),
    @observacion    varchar  (500),
    @orden    decimal  (18,0),
    @id_controlador_1    int  ,
    @id_controlador_2    int  ,
    @nro    int  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_actividad_proyecto
FROM
    [dbo].[Actividad_proyecto]
WHERE
    [id_proyecto] = @id_proyecto AND
    [id_actividad] = @id_actividad AND
    [fecha_inicio] = @fecha_inicio AND
    [fecha_fin_previsto] = @fecha_fin_previsto AND
    [fecha_fin_real] = @fecha_fin_real AND
    [cantidad_hora] = @cantidad_hora AND
    [objetivo] = @objetivo AND
    [prioridad] = @prioridad AND
    [complejidad] = @complejidad AND
    [avance] = @avance AND
    [observacion] = @observacion AND
    [orden] = @orden AND
    [id_controlador_1] = @id_controlador_1 AND
    [id_controlador_2] = @id_controlador_2 AND
    [nro] = @nro

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Actividad_proyecto_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Actividad_proyecto_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Actividad_proyecto_GetOne]
    @id_actividad_proyecto    int
AS

SELECT
    [id_actividad_proyecto] AS [Id actividad proyecto] ,
    [id_proyecto] AS [Id proyecto] ,
    [id_actividad] AS [Id actividad] ,
    [fecha_inicio] AS [Fecha inicio] ,
    [fecha_fin_previsto] AS [Fecha fin previsto] ,
    [fecha_fin_real] AS [Fecha fin real] ,
    [cantidad_hora] AS [Cantidad hora] ,
    [objetivo] AS [Objetivo] ,
    [prioridad] AS [Prioridad] ,
    [complejidad] AS [Complejidad] ,
    [avance] AS [Avance] ,
    [observacion] AS [Observacion] ,
    [orden] AS [Orden] ,
    [id_controlador_1] AS [Id controlador 1] ,
    [id_controlador_2] AS [Id controlador 2] ,
    [nro] AS [Nro]
FROM
    [dbo].[Actividad_proyecto]
WHERE
    [id_actividad_proyecto]  =  @id_actividad_proyecto
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Actividad_proyecto_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Actividad_proyecto_Find]
GO

CREATE PROCEDURE [dbo].[cop_Actividad_proyecto_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_actividad_proyecto] AS [Id actividad proyecto] ,
    [id_proyecto] AS [Id proyecto] ,
    [id_actividad] AS [Id actividad] ,
    [fecha_inicio] AS [Fecha inicio] ,
    [fecha_fin_previsto] AS [Fecha fin previsto] ,
    [fecha_fin_real] AS [Fecha fin real] ,
    [cantidad_hora] AS [Cantidad hora] ,
    RTRIM(objetivo) AS [Objetivo] ,
    [prioridad] AS [Prioridad] ,
    [complejidad] AS [Complejidad] ,
    [avance] AS [Avance] ,
    RTRIM(observacion) AS [Observacion] ,
    [orden] AS [Orden] ,
    [id_controlador_1] AS [Id controlador 1] ,
    [id_controlador_2] AS [Id controlador 2] ,
    [nro] AS [Nro]
FROM
    [dbo].[Actividad_proyecto]
WHERE
    [id_proyecto] LIKE @nombre+'%'
ORDER BY
    [id_proyecto]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Actividad_proyecto_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Actividad_proyecto_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Actividad_proyecto_InsertOne]
AS

INSERT INTO [dbo].[Actividad_proyecto]
(
    [id_proyecto],
    [id_actividad],
    [fecha_inicio],
    [fecha_fin_previsto],
    [fecha_fin_real],
    [cantidad_hora],
    [objetivo],
    [prioridad],
    [complejidad],
    [avance],
    [observacion],
    [orden],
    [id_controlador_1],
    [id_controlador_2],
    [nro]
)
VALUES
(
    1,
    1,
    '01-01-2000',
    '01-01-2000',
    '01-01-2000',
    0,
    'Ninguno',
    0,
    0,
    0,
    'Ninguno',
    0,
    1,
    1,
     1 
)
GO

