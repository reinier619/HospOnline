USE [HospOnline]
GO
/****** Object:  Table [dbo].[Cama]    Script Date: 06/12/2016 1:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cama](
	[camaID] [bigint] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[numero] [varchar](50) NULL,
	[salaID] [bigint] NULL,
 CONSTRAINT [PK_Cama] PRIMARY KEY CLUSTERED 
(
	[camaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Diagnostico]    Script Date: 06/12/2016 1:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Diagnostico](
	[diagnosticoID] [bigint] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](250) NULL,
	[fecha_diagnostico] [datetime] NULL,
	[ingresoID] [bigint] NULL,
 CONSTRAINT [PK_Diagnostico] PRIMARY KEY CLUSTERED 
(
	[diagnosticoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Egreso]    Script Date: 06/12/2016 1:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Egreso](
	[egresoID] [bigint] IDENTITY(1,1) NOT NULL,
	[fecha_egreso] [datetime] NULL,
	[descripcion] [varchar](250) NULL,
	[ingresoID] [bigint] NULL,
 CONSTRAINT [PK_Egreso] PRIMARY KEY CLUSTERED 
(
	[egresoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FormulaMedicamento]    Script Date: 06/12/2016 1:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FormulaMedicamento](
	[formulamedicamentoID] [bigint] IDENTITY(1,1) NOT NULL,
	[medicamento] [varchar](250) NULL,
	[cantidad] [varchar](250) NULL,
	[medida] [varchar](50) NULL,
	[unidad_medida] [varchar](50) NULL,
	[ingresoID] [bigint] NOT NULL,
 CONSTRAINT [PK_FormularioMedicamento] PRIMARY KEY CLUSTERED 
(
	[formulamedicamentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ingreso]    Script Date: 06/12/2016 1:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ingreso](
	[ingresoID] [bigint] IDENTITY(1,1) NOT NULL,
	[estado] [varchar](50) NOT NULL,
	[enfermedad] [varchar](250) NULL,
	[unidadID] [bigint] NULL,
	[salaID] [bigint] NULL,
	[camaID] [bigint] NULL,
	[descripcion] [varchar](250) NULL,
	[pacienteID] [bigint] NULL,
	[fecha_ingreso] [datetime] NULL,
	[hora_ingreso] [varchar](50) NULL,
 CONSTRAINT [PK_Ingreso] PRIMARY KEY CLUSTERED 
(
	[ingresoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Medicamento]    Script Date: 06/12/2016 1:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Medicamento](
	[medicamentoID] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](250) NULL,
 CONSTRAINT [PK_Medicamento] PRIMARY KEY CLUSTERED 
(
	[medicamentoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 06/12/2016 1:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Paciente](
	[pacienteID] [bigint] IDENTITY(1,1) NOT NULL,
	[personaID] [bigint] NULL,
	[fecha_registro] [datetime] NULL,
	[codigo] [varchar](50) NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[pacienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 06/12/2016 1:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Persona](
	[personaID] [bigint] IDENTITY(1,1) NOT NULL,
	[rut] [varchar](50) NULL,
	[dv] [varchar](50) NULL,
	[nombres] [varchar](250) NULL,
	[ap_paterno] [varchar](250) NULL,
	[ap_materno] [varchar](250) NULL,
	[direccion] [varchar](250) NULL,
	[telefono] [varchar](250) NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[personaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Personal]    Script Date: 06/12/2016 1:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personal](
	[personalID] [bigint] IDENTITY(1,1) NOT NULL,
	[personaID] [bigint] NULL,
	[cargoID] [bigint] NULL,
	[unidadID] [bigint] NOT NULL,
 CONSTRAINT [PK_Personal] PRIMARY KEY CLUSTERED 
(
	[personalID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Procedimiento]    Script Date: 06/12/2016 1:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Procedimiento](
	[procedimientoID] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](250) NULL,
	[cantidad] [varchar](250) NULL,
	[periodo] [varchar](250) NULL,
	[fecha_inicio_procedimiento] [datetime] NULL,
	[ingresoID] [bigint] NULL,
 CONSTRAINT [PK_Procedimiento] PRIMARY KEY CLUSTERED 
(
	[procedimientoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sala]    Script Date: 06/12/2016 1:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sala](
	[salaID] [bigint] IDENTITY(1,1) NOT NULL,
	[numero] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
	[unidadID] [bigint] NULL,
 CONSTRAINT [PK_Sala] PRIMARY KEY CLUSTERED 
(
	[salaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Tratamiento]    Script Date: 06/12/2016 1:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tratamiento](
	[tratamientoID] [bigint] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](250) NULL,
	[egresoID] [bigint] NULL,
	[pacienteID] [bigint] NULL,
 CONSTRAINT [PK_Tratamiento] PRIMARY KEY CLUSTERED 
(
	[tratamientoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Unidad]    Script Date: 06/12/2016 1:31:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Unidad](
	[unidadID] [bigint] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](250) NULL,
	[descripcion] [varchar](250) NULL,
 CONSTRAINT [PK_Unidad] PRIMARY KEY CLUSTERED 
(
	[unidadID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
