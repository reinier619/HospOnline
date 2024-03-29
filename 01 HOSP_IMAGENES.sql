USE [HOSP_IMAGENES]
GO
/****** Object:  Table [dbo].[Imagen]    Script Date: 06/12/2016 1:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Imagen](
	[imagenID] [bigint] IDENTITY(1,1) NOT NULL,
	[fecha_informe] [datetime] NULL,
	[descripcion] [varchar](250) NULL,
	[diagnostico] [varchar](250) NULL,
	[ingresoID] [bigint] NULL,
	[pacienteID] [bigint] NULL,
 CONSTRAINT [PK_Imagen] PRIMARY KEY CLUSTERED 
(
	[imagenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Informe]    Script Date: 06/12/2016 1:30:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Informe](
	[informeID] [bigint] IDENTITY(1,1) NOT NULL,
	[fecha_informe] [datetime] NULL,
	[descripcion] [varchar](250) NULL,
	[diagnostico] [varchar](250) NULL,
	[ingresoID] [bigint] NULL,
	[pacienteID] [bigint] NULL,
 CONSTRAINT [PK_Informe] PRIMARY KEY CLUSTERED 
(
	[informeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
