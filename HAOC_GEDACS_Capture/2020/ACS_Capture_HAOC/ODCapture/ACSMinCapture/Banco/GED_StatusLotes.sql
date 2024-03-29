USE [GEDPES_OI_PRD]
GO
/****** Object:  Table [dbo].[GEDStatusLote]    Script Date: 08/11/2014 17:04:07 ******/
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
INSERT [dbo].[GEDStatusLote] ([STL_Id], [STL_Descricao]) VALUES (1, N'Capturando')
INSERT [dbo].[GEDStatusLote] ([STL_Id], [STL_Descricao]) VALUES (2, N'Capturado')
INSERT [dbo].[GEDStatusLote] ([STL_Id], [STL_Descricao]) VALUES (3, N'Captura Cancelada')
INSERT [dbo].[GEDStatusLote] ([STL_Id], [STL_Descricao]) VALUES (4, N'Processando')
INSERT [dbo].[GEDStatusLote] ([STL_Id], [STL_Descricao]) VALUES (5, N'Processado')
INSERT [dbo].[GEDStatusLote] ([STL_Id], [STL_Descricao]) VALUES (6, N'Processamento Cancelado')
SET IDENTITY_INSERT [dbo].[GEDStatusLote] OFF
