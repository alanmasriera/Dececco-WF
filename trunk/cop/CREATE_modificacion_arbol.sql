USE [Dececco]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[modificacion_arbol]') AND type in (N'U'))
DROP TABLE [dbo].[modificacion_arbol]
GO

CREATE TABLE [dbo].[modificacion_arbol](
   [id_modificacion_arbol] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
   [nombre_modificacion_arbol] [varchar](500) COLLATE Modern_Spanish_CI_AS NULL,
   [id_usuario] [int] NULL,
   [realizado] [bit] NULL,
 CONSTRAINT [PK_modificacion_arbol] PRIMARY KEY CLUSTERED 
(
   [id_modificacion_arbol] ASC
)WITH (PAD_INDEX  = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

