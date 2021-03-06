USE [master]
GO
/****** Object:  Database [HotelesRichTexan]    Script Date: 25/7/2022 19:55:56 ******/
CREATE DATABASE [HotelesRichTexan]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HotelesRichTexan', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\HotelesRichTexan.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HotelesRichTexan_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\HotelesRichTexan_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HotelesRichTexan] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HotelesRichTexan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HotelesRichTexan] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HotelesRichTexan] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HotelesRichTexan] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HotelesRichTexan] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HotelesRichTexan] SET ARITHABORT OFF 
GO
ALTER DATABASE [HotelesRichTexan] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HotelesRichTexan] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HotelesRichTexan] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HotelesRichTexan] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HotelesRichTexan] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HotelesRichTexan] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HotelesRichTexan] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HotelesRichTexan] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HotelesRichTexan] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HotelesRichTexan] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HotelesRichTexan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HotelesRichTexan] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HotelesRichTexan] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HotelesRichTexan] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HotelesRichTexan] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HotelesRichTexan] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HotelesRichTexan] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HotelesRichTexan] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HotelesRichTexan] SET  MULTI_USER 
GO
ALTER DATABASE [HotelesRichTexan] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HotelesRichTexan] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HotelesRichTexan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HotelesRichTexan] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HotelesRichTexan] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HotelesRichTexan] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [HotelesRichTexan] SET QUERY_STORE = OFF
GO
USE [HotelesRichTexan]
GO
/****** Object:  User [test]    Script Date: 25/7/2022 19:55:56 ******/
CREATE USER [test] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 25/7/2022 19:55:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fechaAlta] [datetime] NOT NULL,
	[activo] [bit] NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[direccion] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
	[mail] [varchar](50) NULL,
	[fechaNacimiento] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Habitacion]    Script Date: 25/7/2022 19:55:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Habitacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idHotel] [int] NOT NULL,
	[categoria] [varchar](50) NOT NULL,
	[cantidadPlazas] [int] NOT NULL,
	[cancelacion] [bit] NULL,
	[precio] [decimal](5, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hotel]    Script Date: 25/7/2022 19:55:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hotel](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[estrellas] [int] NOT NULL,
	[amenities] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 25/7/2022 19:55:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[telefono] [int] NOT NULL,
	[mail] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 25/7/2022 19:55:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idCliente] [int] NOT NULL,
	[idHabitacion] [int] NOT NULL,
	[cantidadHuespedes] [int] NOT NULL,
	[fechaIngreso] [datetime] NOT NULL,
	[fechaEgreso] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([id], [fechaAlta], [activo], [nombre], [apellido], [direccion], [telefono], [mail], [fechaNacimiento]) VALUES (11, CAST(N'2022-07-07T00:00:00.000' AS DateTime), 0, N'Damián', N'Gimenez', N'Charcas 4325 PB g', N'543534534', N'dg@gmail.com', CAST(N'1989-09-26T00:00:00.000' AS DateTime))
INSERT [dbo].[Cliente] ([id], [fechaAlta], [activo], [nombre], [apellido], [direccion], [telefono], [mail], [fechaNacimiento]) VALUES (12, CAST(N'2022-07-07T00:00:00.000' AS DateTime), 0, N'Gerardo', N'Jacowit', N'Corrientes 989', N'523534324', N'gj@gmail.com', CAST(N'1970-09-25T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Habitacion] ON 

INSERT [dbo].[Habitacion] ([id], [idHotel], [categoria], [cantidadPlazas], [cancelacion], [precio]) VALUES (1, 1, N'normal', 5, 0, CAST(500.00 AS Decimal(5, 2)))
INSERT [dbo].[Habitacion] ([id], [idHotel], [categoria], [cantidadPlazas], [cancelacion], [precio]) VALUES (2, 1, N'Mas grosa', 6, 1, CAST(700.00 AS Decimal(5, 2)))
INSERT [dbo].[Habitacion] ([id], [idHotel], [categoria], [cantidadPlazas], [cancelacion], [precio]) VALUES (3, 1, N'mas o menos', 2, 0, CAST(200.00 AS Decimal(5, 2)))
INSERT [dbo].[Habitacion] ([id], [idHotel], [categoria], [cantidadPlazas], [cancelacion], [precio]) VALUES (4, 1, N'ahí nomás', 2, 0, CAST(150.00 AS Decimal(5, 2)))
SET IDENTITY_INSERT [dbo].[Habitacion] OFF
GO
SET IDENTITY_INSERT [dbo].[Hotel] ON 

INSERT [dbo].[Hotel] ([id], [nombre], [direccion], [estrellas], [amenities]) VALUES (1, N'Rich hotel de Valley', N'St AVE 1234', 3, 1)
INSERT [dbo].[Hotel] ([id], [nombre], [direccion], [estrellas], [amenities]) VALUES (2, N'Luchos hotel very important', N'Av Moe 78', 5, 1)
INSERT [dbo].[Hotel] ([id], [nombre], [direccion], [estrellas], [amenities]) VALUES (4, N'Hotel uno, dos, tres cuatro', N'McGill street 5654', 4, 0)
INSERT [dbo].[Hotel] ([id], [nombre], [direccion], [estrellas], [amenities]) VALUES (5, N'Otro hotel de allá', N'Av texan luxury 98989', 2, 0)
SET IDENTITY_INSERT [dbo].[Hotel] OFF
GO
ALTER TABLE [dbo].[Habitacion]  WITH CHECK ADD  CONSTRAINT [fk_id_Hotel] FOREIGN KEY([idHotel])
REFERENCES [dbo].[Hotel] ([id])
GO
ALTER TABLE [dbo].[Habitacion] CHECK CONSTRAINT [fk_id_Hotel]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [fk_id] FOREIGN KEY([id])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [fk_id]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [fk_idCliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [fk_idCliente]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [fk_idHabitacion] FOREIGN KEY([idHabitacion])
REFERENCES [dbo].[Habitacion] ([id])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [fk_idHabitacion]
GO
USE [master]
GO
ALTER DATABASE [HotelesRichTexan] SET  READ_WRITE 
GO
