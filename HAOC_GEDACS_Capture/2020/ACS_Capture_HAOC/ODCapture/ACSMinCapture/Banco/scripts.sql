USE [GEDPES_OI_PRD]
GO
/****** Object:  Table [dbo].[GEDStatusLote]    Script Date: 08/01/2014 20:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GEDStatusLote](
	[STL_Id] [int] IDENTITY(1,1) NOT NULL,
	[STL_Descricao] [varchar](50) NULL,
 CONSTRAINT [PK_GEDStatusLote] PRIMARY KEY CLUSTERED 
(
	[STL_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[GEDStatusLote] ON
INSERT [dbo].[GEDStatusLote] ([STL_Id], [STL_Descricao]) VALUES (1, N'Pendênte')
INSERT [dbo].[GEDStatusLote] ([STL_Id], [STL_Descricao]) VALUES (2, N'Capturado')
INSERT [dbo].[GEDStatusLote] ([STL_Id], [STL_Descricao]) VALUES (3, N'Processado')
SET IDENTITY_INSERT [dbo].[GEDStatusLote] OFF
/****** Object:  Table [dbo].[GEDLotes]    Script Date: 08/01/2014 20:48:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[GEDLotes](
	[LTS_Id] [int] IDENTITY(1,1) NOT NULL,
	[LTS_IdUsuarioCaptura] [int] NULL,
	[LTS_IdUsuarioProcesso] [int] NULL,
	[LTS_idStatusLote] [int] NOT NULL,
	[LTS_CodigoPassagem] [varchar](50) NOT NULL,
	[LTS_PathImagens] [varchar](max) NOT NULL,
	[LTS_DataCaptura] [datetime] NULL,
	[LTS_DataProcesso] [datetime] NULL,
 CONSTRAINT [PK_GEDLotes] PRIMARY KEY CLUSTERED 
(
	[LTS_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_GEDLotes_GEDStatusLote]    Script Date: 08/01/2014 20:48:34 ******/
ALTER TABLE [dbo].[GEDLotes]  WITH CHECK ADD  CONSTRAINT [FK_GEDLotes_GEDStatusLote] FOREIGN KEY([LTS_idStatusLote])
REFERENCES [dbo].[GEDStatusLote] ([STL_Id])
GO
ALTER TABLE [dbo].[GEDLotes] CHECK CONSTRAINT [FK_GEDLotes_GEDStatusLote]
GO
/****** Object:  ForeignKey [FK_GEDLotes_GEDUsuarios]    Script Date: 08/01/2014 20:48:34 ******/
ALTER TABLE [dbo].[GEDLotes]  WITH CHECK ADD  CONSTRAINT [FK_GEDLotes_GEDUsuarios] FOREIGN KEY([LTS_IdUsuarioCaptura])
REFERENCES [dbo].[GEDUsuarios] ([USR_idUsuario])
GO
ALTER TABLE [dbo].[GEDLotes] CHECK CONSTRAINT [FK_GEDLotes_GEDUsuarios]
GO
/****** Object:  ForeignKey [FK_GEDLotes_GEDUsuarios1]    Script Date: 08/01/2014 20:48:34 ******/
ALTER TABLE [dbo].[GEDLotes]  WITH CHECK ADD  CONSTRAINT [FK_GEDLotes_GEDUsuarios1] FOREIGN KEY([LTS_IdUsuarioProcesso])
REFERENCES [dbo].[GEDUsuarios] ([USR_idUsuario])
GO
ALTER TABLE [dbo].[GEDLotes] CHECK CONSTRAINT [FK_GEDLotes_GEDUsuarios1]
GO
