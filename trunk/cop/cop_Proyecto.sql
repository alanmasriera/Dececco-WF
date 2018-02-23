USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Proyecto_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Proyecto_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Proyecto_Insert]
    @id_proyecto    int  output,
    @descripcion    varchar  (500),
    @nombre_proyecto    varchar  (500),
    @id_cliente    int  ,
    @id_proyecto_padre    int  ,
    @id_proyect_manager    int  ,
    @fecha_inicio    datetime  ,
    @fecha_fin_prevista    datetime  ,
    @fecha_fin_real    datetime  ,
    @orden    varchar  (50),
    @id_estado    int  ,
    @total_hora    decimal  (10,2),
    @prioridad    decimal  (10,2),
    @observacion    varchar  (500),
    @id_controlador_1    int  ,
    @id_controlador_2    int  ,
    @path    varchar  (5000),
    @archivado    bit  ,
    @indice    int  ,
    @nro    int  
AS

INSERT INTO [dbo].[Proyecto]
(
    [descripcion],
    [nombre_proyecto],
    [id_cliente],
    [id_proyecto_padre],
    [id_proyect_manager],
    [fecha_inicio],
    [fecha_fin_prevista],
    [fecha_fin_real],
    [orden],
    [id_estado],
    [total_hora],
    [prioridad],
    [observacion],
    [id_controlador_1],
    [id_controlador_2],
    [path],
    [archivado],
    [indice],
    [nro]
)
VALUES
(
    @descripcion,
    @nombre_proyecto,
    @id_cliente,
    @id_proyecto_padre,
    @id_proyect_manager,
    @fecha_inicio,
    @fecha_fin_prevista,
    @fecha_fin_real,
    @orden,
    @id_estado,
    @total_hora,
    @prioridad,
    @observacion,
    @id_controlador_1,
    @id_controlador_2,
    @path,
    @archivado,
    @indice,
    @nro
)
SET @id_proyecto = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Proyecto_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Proyecto_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Proyecto_Delete]
    @id_proyecto    int
AS

DELETE FROM [dbo].[Proyecto]
WHERE
    [id_proyecto]  =  @id_proyecto
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Proyecto_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Proyecto_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Proyecto_GetAll]
AS

SELECT TOP 100
    [id_proyecto] AS [Id proyecto] ,
    RTRIM(descripcion) AS [Descripcion] ,
    RTRIM(nombre_proyecto) AS [Nombre proyecto] ,
    [id_cliente] AS [Id cliente] ,
    [id_proyecto_padre] AS [Id proyecto padre] ,
    [id_proyect_manager] AS [Id proyect manager] ,
    [fecha_inicio] AS [Fecha inicio] ,
    [fecha_fin_prevista] AS [Fecha fin prevista] ,
    [fecha_fin_real] AS [Fecha fin real] ,
    RTRIM(orden) AS [Orden] ,
    [id_estado] AS [Id estado] ,
    [total_hora] AS [Total hora] ,
    [prioridad] AS [Prioridad] ,
    RTRIM(observacion) AS [Observacion] ,
    [id_controlador_1] AS [Id controlador 1] ,
    [id_controlador_2] AS [Id controlador 2] ,
    RTRIM(path) AS [Path] ,
    [archivado] AS [Archivado] ,
    [indice] AS [Indice] ,
    [nro] AS [Nro]
FROM
    [dbo].[Proyecto]
ORDER BY
    [descripcion]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Proyecto_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Proyecto_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Proyecto_GetCmb]
AS

SELECT
    [id_proyecto],
    [descripcion],
    [nombre_proyecto],
    [id_cliente],
    [id_proyecto_padre],
    [id_proyect_manager],
    [fecha_inicio],
    [fecha_fin_prevista],
    [fecha_fin_real],
    [orden],
    [id_estado],
    [total_hora],
    [prioridad],
    [observacion],
    [id_controlador_1],
    [id_controlador_2],
    [path],
    [archivado],
    [indice],
    [nro]
FROM
    [dbo].[Proyecto]
ORDER BY
    [descripcion]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Proyecto_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Proyecto_Update]
GO

CREATE PROCEDURE [dbo].[cop_Proyecto_Update]
    @id_proyecto    int  output,
    @descripcion    varchar  (500),
    @nombre_proyecto    varchar  (500),
    @id_cliente    int  ,
    @id_proyecto_padre    int  ,
    @id_proyect_manager    int  ,
    @fecha_inicio    datetime  ,
    @fecha_fin_prevista    datetime  ,
    @fecha_fin_real    datetime  ,
    @orden    varchar  (50),
    @id_estado    int  ,
    @total_hora    decimal  (10,2),
    @prioridad    decimal  (10,2),
    @observacion    varchar  (500),
    @id_controlador_1    int  ,
    @id_controlador_2    int  ,
    @path    varchar  (5000),
    @archivado    bit  ,
    @indice    int  ,
    @nro    int  
AS

UPDATE [dbo].[Proyecto] SET
    [descripcion] = @descripcion,
    [nombre_proyecto] = @nombre_proyecto,
    [id_cliente] = @id_cliente,
    [id_proyecto_padre] = @id_proyecto_padre,
    [id_proyect_manager] = @id_proyect_manager,
    [fecha_inicio] = @fecha_inicio,
    [fecha_fin_prevista] = @fecha_fin_prevista,
    [fecha_fin_real] = @fecha_fin_real,
    [orden] = @orden,
    [id_estado] = @id_estado,
    [total_hora] = @total_hora,
    [prioridad] = @prioridad,
    [observacion] = @observacion,
    [id_controlador_1] = @id_controlador_1,
    [id_controlador_2] = @id_controlador_2,
    [path] = @path,
    [archivado] = @archivado,
    [indice] = @indice,
    [nro] = @nro
WHERE
    [id_proyecto]  =  @id_proyecto
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Proyecto_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Proyecto_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Proyecto_Exist]
    @descripcion    varchar  (500),
    @nombre_proyecto    varchar  (500),
    @id_cliente    int  ,
    @id_proyecto_padre    int  ,
    @id_proyect_manager    int  ,
    @fecha_inicio    datetime  ,
    @fecha_fin_prevista    datetime  ,
    @fecha_fin_real    datetime  ,
    @orden    varchar  (50),
    @id_estado    int  ,
    @total_hora    decimal  (10,2),
    @prioridad    decimal  (10,2),
    @observacion    varchar  (500),
    @id_controlador_1    int  ,
    @id_controlador_2    int  ,
    @path    varchar  (5000),
    @archivado    bit  ,
    @indice    int  ,
    @nro    int  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_proyecto
FROM
    [dbo].[Proyecto]
WHERE
    [descripcion] = @descripcion AND
    [nombre_proyecto] = @nombre_proyecto AND
    [id_cliente] = @id_cliente AND
    [id_proyecto_padre] = @id_proyecto_padre AND
    [id_proyect_manager] = @id_proyect_manager AND
    [fecha_inicio] = @fecha_inicio AND
    [fecha_fin_prevista] = @fecha_fin_prevista AND
    [fecha_fin_real] = @fecha_fin_real AND
    [orden] = @orden AND
    [id_estado] = @id_estado AND
    [total_hora] = @total_hora AND
    [prioridad] = @prioridad AND
    [observacion] = @observacion AND
    [id_controlador_1] = @id_controlador_1 AND
    [id_controlador_2] = @id_controlador_2 AND
    [path] = @path AND
    [archivado] = @archivado AND
    [indice] = @indice AND
    [nro] = @nro

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Proyecto_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Proyecto_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Proyecto_GetOne]
    @id_proyecto    int
AS

SELECT
    [id_proyecto] AS [Id proyecto] ,
    [descripcion] AS [Descripcion] ,
    [nombre_proyecto] AS [Nombre proyecto] ,
    [id_cliente] AS [Id cliente] ,
    [id_proyecto_padre] AS [Id proyecto padre] ,
    [id_proyect_manager] AS [Id proyect manager] ,
    [fecha_inicio] AS [Fecha inicio] ,
    [fecha_fin_prevista] AS [Fecha fin prevista] ,
    [fecha_fin_real] AS [Fecha fin real] ,
    [orden] AS [Orden] ,
    [id_estado] AS [Id estado] ,
    [total_hora] AS [Total hora] ,
    [prioridad] AS [Prioridad] ,
    [observacion] AS [Observacion] ,
    [id_controlador_1] AS [Id controlador 1] ,
    [id_controlador_2] AS [Id controlador 2] ,
    [path] AS [Path] ,
    [archivado] AS [Archivado] ,
    [indice] AS [Indice] ,
    [nro] AS [Nro]
FROM
    [dbo].[Proyecto]
WHERE
    [id_proyecto]  =  @id_proyecto
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Proyecto_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Proyecto_Find]
GO

CREATE PROCEDURE [dbo].[cop_Proyecto_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_proyecto] AS [Id proyecto] ,
    RTRIM(descripcion) AS [Descripcion] ,
    RTRIM(nombre_proyecto) AS [Nombre proyecto] ,
    [id_cliente] AS [Id cliente] ,
    [id_proyecto_padre] AS [Id proyecto padre] ,
    [id_proyect_manager] AS [Id proyect manager] ,
    [fecha_inicio] AS [Fecha inicio] ,
    [fecha_fin_prevista] AS [Fecha fin prevista] ,
    [fecha_fin_real] AS [Fecha fin real] ,
    RTRIM(orden) AS [Orden] ,
    [id_estado] AS [Id estado] ,
    [total_hora] AS [Total hora] ,
    [prioridad] AS [Prioridad] ,
    RTRIM(observacion) AS [Observacion] ,
    [id_controlador_1] AS [Id controlador 1] ,
    [id_controlador_2] AS [Id controlador 2] ,
    RTRIM(path) AS [Path] ,
    [archivado] AS [Archivado] ,
    [indice] AS [Indice] ,
    [nro] AS [Nro]
FROM
    [dbo].[Proyecto]
WHERE
    [descripcion] LIKE @nombre+'%'
ORDER BY
    [descripcion]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Proyecto_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Proyecto_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Proyecto_InsertOne]
AS

INSERT INTO [dbo].[Proyecto]
(
    [descripcion],
    [nombre_proyecto],
    [id_cliente],
    [id_proyecto_padre],
    [id_proyect_manager],
    [fecha_inicio],
    [fecha_fin_prevista],
    [fecha_fin_real],
    [orden],
    [id_estado],
    [total_hora],
    [prioridad],
    [observacion],
    [id_controlador_1],
    [id_controlador_2],
    [path],
    [archivado],
    [indice],
    [nro]
)
VALUES
(
    'Ninguno',
    'Ninguno',
    1,
    1,
    1,
    '01-01-2000',
    '01-01-2000',
    '01-01-2000',
    'Ninguno',
    1,
    0,
    0,
    'Ninguno',
    1,
    1,
    'Ninguno',
    0,
    1,
     1 
)
GO

