USE [master]
GO
/****** Object:  Database [PruebaTik]    Script Date: 12/09/2022 20:07:24 ******/
CREATE DATABASE [PruebaTik]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PruebaTik', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\PruebaTik.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'PruebaTik_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\PruebaTik_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [PruebaTik] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PruebaTik].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PruebaTik] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PruebaTik] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PruebaTik] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PruebaTik] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PruebaTik] SET ARITHABORT OFF 
GO
ALTER DATABASE [PruebaTik] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PruebaTik] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [PruebaTik] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PruebaTik] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PruebaTik] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PruebaTik] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PruebaTik] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PruebaTik] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PruebaTik] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PruebaTik] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PruebaTik] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PruebaTik] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PruebaTik] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PruebaTik] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PruebaTik] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PruebaTik] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PruebaTik] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PruebaTik] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PruebaTik] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [PruebaTik] SET  MULTI_USER 
GO
ALTER DATABASE [PruebaTik] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PruebaTik] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PruebaTik] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PruebaTik] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [PruebaTik]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 12/09/2022 20:07:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Venta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Num] [varchar](50) NULL,
	[Cliente] [varchar](250) NULL,
	[Fecha] [datetime] NULL,
	[TOTAL] [decimal](8, 2) NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VentaDetalle]    Script Date: 12/09/2022 20:07:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VentaDetalle](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdVenta] [int] NULL,
	[Cantidad] [int] NULL,
	[Descripcion] [varchar](100) NULL,
	[PrecioUnitario] [decimal](8, 2) NULL,
	[Importe] [decimal](8, 2) NULL,
 CONSTRAINT [PK_VentaDetalle] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([Id], [Num], [Cliente], [Fecha], [TOTAL]) VALUES (1, N'00000001', N'Alfredo Mendez ', CAST(N'2022-12-09 16:06:58.167' AS DateTime), CAST(300.00 AS Decimal(8, 2)))
INSERT [dbo].[Venta] ([Id], [Num], [Cliente], [Fecha], [TOTAL]) VALUES (2, N'00000002', N'Susana Torres', CAST(N'2022-12-09 16:09:26.373' AS DateTime), CAST(1763.00 AS Decimal(8, 2)))
INSERT [dbo].[Venta] ([Id], [Num], [Cliente], [Fecha], [TOTAL]) VALUES (3, N'00000003', N'Jeaneth Moreno', CAST(N'2022-12-09 16:39:16.227' AS DateTime), CAST(840.00 AS Decimal(8, 2)))
INSERT [dbo].[Venta] ([Id], [Num], [Cliente], [Fecha], [TOTAL]) VALUES (4, N'00000004', N'Cecilia Gomez', CAST(N'2022-09-12 19:43:36.873' AS DateTime), CAST(650.00 AS Decimal(8, 2)))
INSERT [dbo].[Venta] ([Id], [Num], [Cliente], [Fecha], [TOTAL]) VALUES (5, N'00000005', N'Carmen Suarez', CAST(N'2022-09-12 19:47:26.547' AS DateTime), CAST(570.00 AS Decimal(8, 2)))
INSERT [dbo].[Venta] ([Id], [Num], [Cliente], [Fecha], [TOTAL]) VALUES (6, N'00000006', N'Paulina Morello', CAST(N'2022-09-12 19:52:18.870' AS DateTime), CAST(1050.00 AS Decimal(8, 2)))
INSERT [dbo].[Venta] ([Id], [Num], [Cliente], [Fecha], [TOTAL]) VALUES (7, N'00000007', N'Jessica Valencia', CAST(N'2022-09-12 19:56:50.393' AS DateTime), CAST(63.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[Venta] OFF
SET IDENTITY_INSERT [dbo].[VentaDetalle] ON 

INSERT [dbo].[VentaDetalle] ([Id], [IdVenta], [Cantidad], [Descripcion], [PrecioUnitario], [Importe]) VALUES (2, 1, 1, N'Case Thermaltek', CAST(180.00 AS Decimal(8, 2)), CAST(180.00 AS Decimal(8, 2)))
INSERT [dbo].[VentaDetalle] ([Id], [IdVenta], [Cantidad], [Descripcion], [PrecioUnitario], [Importe]) VALUES (3, 1, 1, N'Teclado Mecanico', CAST(120.00 AS Decimal(8, 2)), CAST(120.00 AS Decimal(8, 2)))
INSERT [dbo].[VentaDetalle] ([Id], [IdVenta], [Cantidad], [Descripcion], [PrecioUnitario], [Importe]) VALUES (4, 2, 1, N'Cartera Vesace', CAST(850.00 AS Decimal(8, 2)), CAST(850.00 AS Decimal(8, 2)))
INSERT [dbo].[VentaDetalle] ([Id], [IdVenta], [Cantidad], [Descripcion], [PrecioUnitario], [Importe]) VALUES (5, 2, 1, N'Zapatos Coco Channel', CAST(625.00 AS Decimal(8, 2)), CAST(625.00 AS Decimal(8, 2)))
INSERT [dbo].[VentaDetalle] ([Id], [IdVenta], [Cantidad], [Descripcion], [PrecioUnitario], [Importe]) VALUES (6, 2, 1, N'Lenceria Victoria Secret', CAST(288.00 AS Decimal(8, 2)), CAST(288.00 AS Decimal(8, 2)))
INSERT [dbo].[VentaDetalle] ([Id], [IdVenta], [Cantidad], [Descripcion], [PrecioUnitario], [Importe]) VALUES (7, 3, 1, N'Gafas Prada', CAST(520.00 AS Decimal(8, 2)), CAST(520.00 AS Decimal(8, 2)))
INSERT [dbo].[VentaDetalle] ([Id], [IdVenta], [Cantidad], [Descripcion], [PrecioUnitario], [Importe]) VALUES (8, 3, 1, N'Perfume Tommi Hilfiger', CAST(320.00 AS Decimal(8, 2)), CAST(320.00 AS Decimal(8, 2)))
INSERT [dbo].[VentaDetalle] ([Id], [IdVenta], [Cantidad], [Descripcion], [PrecioUnitario], [Importe]) VALUES (9, 4, 1, N'Monitor 32"', CAST(580.00 AS Decimal(8, 2)), CAST(580.00 AS Decimal(8, 2)))
INSERT [dbo].[VentaDetalle] ([Id], [IdVenta], [Cantidad], [Descripcion], [PrecioUnitario], [Importe]) VALUES (10, 4, 2, N'Estabilizador Forza', CAST(70.00 AS Decimal(8, 2)), CAST(140.00 AS Decimal(8, 2)))
INSERT [dbo].[VentaDetalle] ([Id], [IdVenta], [Cantidad], [Descripcion], [PrecioUnitario], [Importe]) VALUES (11, 5, 1, N'Perfume Carolina Herrera', CAST(250.00 AS Decimal(8, 2)), CAST(250.00 AS Decimal(8, 2)))
INSERT [dbo].[VentaDetalle] ([Id], [IdVenta], [Cantidad], [Descripcion], [PrecioUnitario], [Importe]) VALUES (12, 5, 1, N'Audifonos JBL', CAST(320.00 AS Decimal(8, 2)), CAST(320.00 AS Decimal(8, 2)))
INSERT [dbo].[VentaDetalle] ([Id], [IdVenta], [Cantidad], [Descripcion], [PrecioUnitario], [Importe]) VALUES (13, 6, 1, N'Mesa Cómputo', CAST(250.00 AS Decimal(8, 2)), CAST(250.00 AS Decimal(8, 2)))
INSERT [dbo].[VentaDetalle] ([Id], [IdVenta], [Cantidad], [Descripcion], [PrecioUnitario], [Importe]) VALUES (14, 6, 1, N'Silla Gamer', CAST(800.00 AS Decimal(8, 2)), CAST(800.00 AS Decimal(8, 2)))
INSERT [dbo].[VentaDetalle] ([Id], [IdVenta], [Cantidad], [Descripcion], [PrecioUnitario], [Importe]) VALUES (15, 7, 1, N'Frasco Menthol', CAST(5.00 AS Decimal(8, 2)), CAST(5.00 AS Decimal(8, 2)))
INSERT [dbo].[VentaDetalle] ([Id], [IdVenta], [Cantidad], [Descripcion], [PrecioUnitario], [Importe]) VALUES (16, 7, 1, N'Bolsa de Algodon', CAST(8.00 AS Decimal(8, 2)), CAST(8.00 AS Decimal(8, 2)))
INSERT [dbo].[VentaDetalle] ([Id], [IdVenta], [Cantidad], [Descripcion], [PrecioUnitario], [Importe]) VALUES (17, 7, 1, N'Café Gourmet', CAST(50.00 AS Decimal(8, 2)), CAST(50.00 AS Decimal(8, 2)))
SET IDENTITY_INSERT [dbo].[VentaDetalle] OFF
ALTER TABLE [dbo].[VentaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_VentaDetalle_Venta] FOREIGN KEY([IdVenta])
REFERENCES [dbo].[Venta] ([Id])
GO
ALTER TABLE [dbo].[VentaDetalle] CHECK CONSTRAINT [FK_VentaDetalle_Venta]
GO
USE [master]
GO
ALTER DATABASE [PruebaTik] SET  READ_WRITE 
GO
