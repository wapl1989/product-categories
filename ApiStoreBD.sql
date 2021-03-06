USE [BDStore]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 25/05/2022 1:15:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name_Categorie] [varchar](50) NOT NULL,
	[Active] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 25/05/2022 1:15:02 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name_Product] [varchar](50) NOT NULL,
	[Description] [varchar](500) NOT NULL,
	[URL_Image] [varchar](max) NOT NULL,
	[Id_Categorie] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Id], [Name_Categorie], [Active]) VALUES (1, N'Aseo', 1)
INSERT [dbo].[Categories] ([Id], [Name_Categorie], [Active]) VALUES (2, N'Enlataados', 1)
INSERT [dbo].[Categories] ([Id], [Name_Categorie], [Active]) VALUES (3, N'Frutas', 1)
INSERT [dbo].[Categories] ([Id], [Name_Categorie], [Active]) VALUES (4, N'Verduras', 1)
INSERT [dbo].[Categories] ([Id], [Name_Categorie], [Active]) VALUES (5, N'Legumbres', 1)
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name_Product], [Description], [URL_Image], [Id_Categorie], [Price]) VALUES (1, N'Limpido', N'Blanqueador', N'https://jumbocolombiaio.vtexassets.com/arquivos/ids/360957-800-800?v=637865199418970000&width=800&height=800&aspect=true', 1, CAST(15000.00 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([Id], [Name_Product], [Description], [URL_Image], [Id_Categorie], [Price]) VALUES (3, N'Fab', N'Fab en polvo', N'https://olimpica.vtexassets.com/arquivos/ids/634347-800-auto?v=637626559270100000&width=800&height=auto&aspect=true', 1, CAST(20000.00 AS Decimal(18, 2)))
INSERT [dbo].[Products] ([Id], [Name_Product], [Description], [URL_Image], [Id_Categorie], [Price]) VALUES (4, N'Manzana', N'Manzana importada', N'https://walmarthn.vtexassets.com/arquivos/ids/171881-800-600?v=637666370378830000&width=800&height=600&aspect=true', 3, CAST(7000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories] FOREIGN KEY([Id_Categorie])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories]
GO
