USE [master]
GO
/****** Object:  Database [Hospital]    Script Date: 14/09/2017 13:25:34 ******/
CREATE DATABASE [Hospital]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hospital', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Hospital.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Hospital_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\Hospital_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Hospital] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hospital].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hospital] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hospital] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hospital] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hospital] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hospital] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hospital] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hospital] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Hospital] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hospital] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hospital] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hospital] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hospital] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hospital] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hospital] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hospital] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hospital] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hospital] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hospital] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hospital] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hospital] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hospital] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hospital] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hospital] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hospital] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Hospital] SET  MULTI_USER 
GO
ALTER DATABASE [Hospital] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hospital] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hospital] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hospital] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Hospital]
GO
/****** Object:  Table [dbo].[Date]    Script Date: 14/09/2017 13:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Date](
	[id] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department]    Script Date: 14/09/2017 13:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[id] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Phone] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 14/09/2017 13:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[SurName] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NOT NULL,
	[DepartmentId] [int] NOT NULL,
	[ScheduleId] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NULL,
	[ShiftId] [int] NULL,
	[DateID] [int] NULL,
 CONSTRAINT [PK__Doctor__3213E83FDB61447D] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Doctor_to_Nurse]    Script Date: 14/09/2017 13:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor_to_Nurse](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[doctor_id] [int] NOT NULL,
	[nurse_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nurse]    Script Date: 14/09/2017 13:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nurse](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[SurName] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NOT NULL,
	[DepartmentId] [int] NOT NULL,
	[ScheduleId] [int] NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NULL,
	[ShiftID] [int] NULL,
	[TimeID] [nchar](10) NULL,
 CONSTRAINT [PK__Nurse__3213E83FB36B83BF] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Qeydiyyat_sobesi]    Script Date: 14/09/2017 13:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Qeydiyyat_sobesi](
	[id] [int] NULL,
	[Department] [nvarchar](50) NULL,
	[Doctor] [nvarchar](50) NULL,
	[Date] [date] NULL,
	[Shift] [int] NULL,
	[Ad] [nvarchar](50) NULL,
	[Soyad] [nvarchar](50) NULL,
	[Yas] [date] NULL,
	[Tel] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Shift]    Script Date: 14/09/2017 13:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shift](
	[id] [int] NULL,
	[Name] [nchar](10) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Time]    Script Date: 14/09/2017 13:25:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Time](
	[id] [nchar](10) NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Doctor_to_Nurse]  WITH CHECK ADD  CONSTRAINT [doctor_relation] FOREIGN KEY([doctor_id])
REFERENCES [dbo].[Doctor] ([id])
GO
ALTER TABLE [dbo].[Doctor_to_Nurse] CHECK CONSTRAINT [doctor_relation]
GO
ALTER TABLE [dbo].[Doctor_to_Nurse]  WITH CHECK ADD  CONSTRAINT [nurse_relation] FOREIGN KEY([nurse_id])
REFERENCES [dbo].[Nurse] ([id])
GO
ALTER TABLE [dbo].[Doctor_to_Nurse] CHECK CONSTRAINT [nurse_relation]
GO
USE [master]
GO
ALTER DATABASE [Hospital] SET  READ_WRITE 
GO
