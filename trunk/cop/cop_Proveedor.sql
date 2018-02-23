USE [Dececco]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Proveedor_Insert]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Proveedor_Insert]
GO

CREATE PROCEDURE [dbo].[cop_Proveedor_Insert]
    @id_proveedor    int  output,
    @nombre_proveedor    varchar  (50),
    @contacto    varchar  (50),
    @cuit    varchar  (50),
    @ingreso_bruto    varchar  (50),
    @direccion    varchar  (100),
    @localidad    varchar  (50),
    @provincia    varchar  (50),
    @telefono    varchar  (50),
    @email    varchar  (50),
    @web    varchar  (50),
    @id_condicion_iva    int  ,
    @id_tipo_proveedor    int  
AS

INSERT INTO [dbo].[Proveedor]
(
    [nombre_proveedor],
    [contacto],
    [cuit],
    [ingreso_bruto],
    [direccion],
    [localidad],
    [provincia],
    [telefono],
    [email],
    [web],
    [id_condicion_iva],
    [id_tipo_proveedor]
)
VALUES
(
    @nombre_proveedor,
    @contacto,
    @cuit,
    @ingreso_bruto,
    @direccion,
    @localidad,
    @provincia,
    @telefono,
    @email,
    @web,
    @id_condicion_iva,
    @id_tipo_proveedor
)
SET @id_proveedor = @@IDENTITY
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Proveedor_Delete]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Proveedor_Delete]
GO

CREATE PROCEDURE [dbo].[cop_Proveedor_Delete]
    @id_proveedor    int
AS

DELETE FROM [dbo].[Proveedor]
WHERE
    [id_proveedor]  =  @id_proveedor
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Proveedor_GetAll]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Proveedor_GetAll]
GO

CREATE PROCEDURE [dbo].[cop_Proveedor_GetAll]
AS

SELECT TOP 100
    [id_proveedor] AS [Id proveedor] ,
    RTRIM(nombre_proveedor) AS [Nombre proveedor] ,
    RTRIM(contacto) AS [Contacto] ,
    RTRIM(cuit) AS [Cuit] ,
    RTRIM(ingreso_bruto) AS [Ingreso bruto] ,
    RTRIM(direccion) AS [Direccion] ,
    RTRIM(localidad) AS [Localidad] ,
    RTRIM(provincia) AS [Provincia] ,
    RTRIM(telefono) AS [Telefono] ,
    RTRIM(email) AS [Email] ,
    RTRIM(web) AS [Web] ,
    [id_condicion_iva] AS [Id condicion iva] ,
    [id_tipo_proveedor] AS [Id tipo proveedor]
FROM
    [dbo].[Proveedor]
ORDER BY
    [nombre_proveedor]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Proveedor_GetCmb]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Proveedor_GetCmb]
GO

CREATE PROCEDURE [dbo].[cop_Proveedor_GetCmb]
AS

SELECT
    [id_proveedor],
    [nombre_proveedor],
    [contacto],
    [cuit],
    [ingreso_bruto],
    [direccion],
    [localidad],
    [provincia],
    [telefono],
    [email],
    [web],
    [id_condicion_iva],
    [id_tipo_proveedor]
FROM
    [dbo].[Proveedor]
ORDER BY
    [nombre_proveedor]
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Proveedor_Update]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Proveedor_Update]
GO

CREATE PROCEDURE [dbo].[cop_Proveedor_Update]
    @id_proveedor    int  output,
    @nombre_proveedor    varchar  (50),
    @contacto    varchar  (50),
    @cuit    varchar  (50),
    @ingreso_bruto    varchar  (50),
    @direccion    varchar  (100),
    @localidad    varchar  (50),
    @provincia    varchar  (50),
    @telefono    varchar  (50),
    @email    varchar  (50),
    @web    varchar  (50),
    @id_condicion_iva    int  ,
    @id_tipo_proveedor    int  
AS

UPDATE [dbo].[Proveedor] SET
    [nombre_proveedor] = @nombre_proveedor,
    [contacto] = @contacto,
    [cuit] = @cuit,
    [ingreso_bruto] = @ingreso_bruto,
    [direccion] = @direccion,
    [localidad] = @localidad,
    [provincia] = @provincia,
    [telefono] = @telefono,
    [email] = @email,
    [web] = @web,
    [id_condicion_iva] = @id_condicion_iva,
    [id_tipo_proveedor] = @id_tipo_proveedor
WHERE
    [id_proveedor]  =  @id_proveedor
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Proveedor_Exist]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Proveedor_Exist]
GO

CREATE PROCEDURE [dbo].[cop_Proveedor_Exist]
    @nombre_proveedor    varchar  (50),
    @contacto    varchar  (50),
    @cuit    varchar  (50),
    @ingreso_bruto    varchar  (50),
    @direccion    varchar  (100),
    @localidad    varchar  (50),
    @provincia    varchar  (50),
    @telefono    varchar  (50),
    @email    varchar  (50),
    @web    varchar  (50),
    @id_condicion_iva    int  ,
    @id_tipo_proveedor    int  
AS

DECLARE @total int
SET @total = 0

SELECT
    @total = id_proveedor
FROM
    [dbo].[Proveedor]
WHERE
    [nombre_proveedor] = @nombre_proveedor AND
    [contacto] = @contacto AND
    [cuit] = @cuit AND
    [ingreso_bruto] = @ingreso_bruto AND
    [direccion] = @direccion AND
    [localidad] = @localidad AND
    [provincia] = @provincia AND
    [telefono] = @telefono AND
    [email] = @email AND
    [web] = @web AND
    [id_condicion_iva] = @id_condicion_iva AND
    [id_tipo_proveedor] = @id_tipo_proveedor

IF @total IS NULL
BEGIN
    SET @total=0
END
SELECT @total AS Total
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Proveedor_GetOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Proveedor_GetOne]
GO

CREATE PROCEDURE [dbo].[cop_Proveedor_GetOne]
    @id_proveedor    int
AS

SELECT
    [id_proveedor] AS [Id proveedor] ,
    [nombre_proveedor] AS [Nombre proveedor] ,
    [contacto] AS [Contacto] ,
    [cuit] AS [Cuit] ,
    [ingreso_bruto] AS [Ingreso bruto] ,
    [direccion] AS [Direccion] ,
    [localidad] AS [Localidad] ,
    [provincia] AS [Provincia] ,
    [telefono] AS [Telefono] ,
    [email] AS [Email] ,
    [web] AS [Web] ,
    [id_condicion_iva] AS [Id condicion iva] ,
    [id_tipo_proveedor] AS [Id tipo proveedor]
FROM
    [dbo].[Proveedor]
WHERE
    [id_proveedor]  =  @id_proveedor
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Proveedor_Find]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Proveedor_Find]
GO

CREATE PROCEDURE [dbo].[cop_Proveedor_Find]
    @nombre NVARCHAR (30)=NULL
AS SET NOCOUNT ON

IF @nombre IS NOT NULL
BEGIN
SELECT @nombre=RTRIM(@nombre)+'%'
SELECT TOP 100
    [id_proveedor] AS [Id proveedor] ,
    RTRIM(nombre_proveedor) AS [Nombre proveedor] ,
    RTRIM(contacto) AS [Contacto] ,
    RTRIM(cuit) AS [Cuit] ,
    RTRIM(ingreso_bruto) AS [Ingreso bruto] ,
    RTRIM(direccion) AS [Direccion] ,
    RTRIM(localidad) AS [Localidad] ,
    RTRIM(provincia) AS [Provincia] ,
    RTRIM(telefono) AS [Telefono] ,
    RTRIM(email) AS [Email] ,
    RTRIM(web) AS [Web] ,
    [id_condicion_iva] AS [Id condicion iva] ,
    [id_tipo_proveedor] AS [Id tipo proveedor]
FROM
    [dbo].[Proveedor]
WHERE
    [nombre_proveedor] LIKE @nombre+'%'
ORDER BY
    [nombre_proveedor]
END
GO

IF exists (SELECT * FROM dbo.sysobjects WHERE ID = object_id(N'[dbo].[cop_Proveedor_InsertOne]') and OBJECTPROPERTY(ID, N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[cop_Proveedor_InsertOne]
GO

CREATE PROCEDURE [dbo].[cop_Proveedor_InsertOne]
AS

INSERT INTO [dbo].[Proveedor]
(
    [nombre_proveedor],
    [contacto],
    [cuit],
    [ingreso_bruto],
    [direccion],
    [localidad],
    [provincia],
    [telefono],
    [email],
    [web],
    [id_condicion_iva],
    [id_tipo_proveedor]
)
VALUES
(
    'Ninguno',
    'Ninguno',
    'Ninguno',
    'Ninguno',
    'Ninguno',
    'Ninguno',
    'Ninguno',
    'Ninguno',
    'Ninguno',
    'Ninguno',
    1,
     1 
)
GO

