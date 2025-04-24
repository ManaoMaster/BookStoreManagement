USE [master]
GO
/****** Object:  Database [library_db]    Script Date: 4/24/2025 8:32:26 AM ******/
CREATE DATABASE [library_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'library_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\library_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'library_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\library_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [library_db] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [library_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [library_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [library_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [library_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [library_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [library_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [library_db] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [library_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [library_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [library_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [library_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [library_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [library_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [library_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [library_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [library_db] SET  ENABLE_BROKER 
GO
ALTER DATABASE [library_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [library_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [library_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [library_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [library_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [library_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [library_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [library_db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [library_db] SET  MULTI_USER 
GO
ALTER DATABASE [library_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [library_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [library_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [library_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [library_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [library_db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [library_db] SET QUERY_STORE = ON
GO
ALTER DATABASE [library_db] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [library_db]
GO
/****** Object:  Table [dbo].[book_inventory_logs]    Script Date: 4/24/2025 8:32:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[book_inventory_logs](
	[log_id] [int] IDENTITY(1,1) NOT NULL,
	[book_id] [int] NULL,
	[quantity_added] [int] NULL,
	[added_by_staff_id] [int] NULL,
	[added_date] [date] NULL,
	[book_title] [nvarchar](255) NULL,
	[status] [nvarchar](50) NULL,
 CONSTRAINT [PK__book_inv__9E2397E0E4958BA1] PRIMARY KEY CLUSTERED 
(
	[log_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[book_types]    Script Date: 4/24/2025 8:32:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[book_types](
	[book_type_id] [int] NOT NULL,
	[type_name] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[book_type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[books]    Script Date: 4/24/2025 8:32:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[books](
	[book_id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](255) NULL,
	[book_type_id] [int] NULL,
	[price] [decimal](10, 2) NULL,
	[rent_price] [decimal](10, 2) NULL,
	[quantity] [int] NULL,
 CONSTRAINT [PK__books__490D1AE16CE51A90] PRIMARY KEY CLUSTERED 
(
	[book_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[member_types]    Script Date: 4/24/2025 8:32:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[member_types](
	[member_type_id] [int] IDENTITY(1,1) NOT NULL,
	[member_type_name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[member_type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[members]    Script Date: 4/24/2025 8:32:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[members](
	[member_id] [int] IDENTITY(1,1) NOT NULL,
	[full_name] [varchar](255) NULL,
	[birth_date] [date] NULL,
	[email] [varchar](255) NULL,
	[phone] [varchar](20) NULL,
	[address] [text] NULL,
	[id_card] [varchar](20) NULL,
	[registered_date] [date] NULL,
	[member_type_id] [int] NULL,
 CONSTRAINT [PK__members__B29B85342CC22DC1] PRIMARY KEY CLUSTERED 
(
	[member_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rentals]    Script Date: 4/24/2025 8:32:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rentals](
	[rental_id] [int] IDENTITY(1,1) NOT NULL,
	[book_id] [int] NULL,
	[member_id] [varchar](10) NULL,
	[staff_id] [varchar](10) NULL,
	[quantity] [int] NULL,
	[rent_date] [date] NULL,
	[due_date] [date] NULL,
	[rent_price_per_unit] [decimal](10, 2) NULL,
	[status] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[rental_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[returns]    Script Date: 4/24/2025 8:32:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[returns](
	[return_id] [int] IDENTITY(1,1) NOT NULL,
	[rental_id] [int] NULL,
	[staff_id] [varchar](10) NULL,
	[return_date] [date] NULL,
	[total_rent_price] [decimal](10, 2) NULL,
	[fine_amount] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[return_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sales]    Script Date: 4/24/2025 8:32:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sales](
	[sale_id] [int] IDENTITY(1,1) NOT NULL,
	[book_id] [int] NULL,
	[member_id] [varchar](10) NULL,
	[staff_id] [varchar](10) NULL,
	[quantity] [int] NULL,
	[price_per_unit] [decimal](10, 2) NULL,
	[sale_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[sale_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[staff]    Script Date: 4/24/2025 8:32:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[staff](
	[staff_id] [varchar](10) NOT NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](255) NULL,
	[full_name] [varchar](255) NULL,
	[role] [varchar](50) NULL,
	[status] [varchar](50) NULL,
	[email] [varchar](255) NULL,
	[phone] [varchar](20) NULL,
	[registered_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[staff_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[members]  WITH CHECK ADD  CONSTRAINT [FK_members_member_types] FOREIGN KEY([member_type_id])
REFERENCES [dbo].[member_types] ([member_type_id])
GO
ALTER TABLE [dbo].[members] CHECK CONSTRAINT [FK_members_member_types]
GO
USE [master]
GO
ALTER DATABASE [library_db] SET  READ_WRITE 
GO
