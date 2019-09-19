USE [master]
GO
/****** Object:  Database [HomeStayHotels]    Script Date: 1/22/2018 3:17:35 PM ******/
CREATE DATABASE [HomeStayHotels]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HomeStayHotels', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\HomeStayHotels.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HomeStayHotels_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\HomeStayHotels_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [HomeStayHotels] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HomeStayHotels].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HomeStayHotels] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HomeStayHotels] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HomeStayHotels] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HomeStayHotels] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HomeStayHotels] SET ARITHABORT OFF 
GO
ALTER DATABASE [HomeStayHotels] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HomeStayHotels] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HomeStayHotels] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HomeStayHotels] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HomeStayHotels] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HomeStayHotels] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HomeStayHotels] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HomeStayHotels] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HomeStayHotels] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HomeStayHotels] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HomeStayHotels] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HomeStayHotels] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HomeStayHotels] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HomeStayHotels] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HomeStayHotels] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HomeStayHotels] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HomeStayHotels] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HomeStayHotels] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [HomeStayHotels] SET  MULTI_USER 
GO
ALTER DATABASE [HomeStayHotels] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HomeStayHotels] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HomeStayHotels] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HomeStayHotels] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HomeStayHotels] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HomeStayHotels] SET QUERY_STORE = OFF
GO
USE [HomeStayHotels]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [HomeStayHotels]
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 1/22/2018 3:17:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[BillID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[ReserveID] [int] NULL,
	[Code] [nvarchar](50) NULL,
	[ReleaseDate] [datetime] NULL,
	[Details] [xml] NULL,
	[SubTotal] [decimal](18, 0) NULL,
	[Discount] [decimal](3, 2) NULL,
	[Total] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 1/22/2018 3:17:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Birthday] [date] NULL,
	[Birthplace] [nvarchar](50) NULL,
	[Address] [nvarchar](250) NULL,
	[IDNumber] [int] NULL,
	[Email] [nvarchar](250) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Email]    Script Date: 1/22/2018 3:17:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Email](
	[EmailID] [int] IDENTITY(1,1) NOT NULL,
	[ClientID] [int] NULL,
	[Title] [nvarchar](50) NULL,
	[Type] [nvarchar](50) NULL,
	[Content] [nvarchar](1000) NULL,
	[SendDate] [datetime] NULL,
	[LinkOfImage] [nvarchar](250) NULL,
 CONSTRAINT [PK_Email] PRIMARY KEY CLUSTERED 
(
	[EmailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Event]    Script Date: 1/22/2018 3:17:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Event](
	[EventID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](250) NULL,
	[Discount] [decimal](3, 2) NULL,
	[StartDay] [datetime] NULL,
	[EndDay] [datetime] NULL,
 CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED 
(
	[EventID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hotel]    Script Date: 1/22/2018 3:17:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hotel](
	[HotelID] [int] IDENTITY(1,1) NOT NULL,
	[EventID] [int] NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](250) NULL,
	[Description] [nvarchar](250) NULL,
	[Level] [int] NULL,
	[Email] [nvarchar](250) NULL,
 CONSTRAINT [PK_Hotel] PRIMARY KEY CLUSTERED 
(
	[HotelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Image]    Script Date: 1/22/2018 3:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Image](
	[ImageID] [int] IDENTITY(1,1) NOT NULL,
	[HotelID] [int] NULL,
	[RoomID] [int] NULL,
	[UserID] [int] NULL,
	[EventID] [int] NULL,
	[Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED 
(
	[ImageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rating]    Script Date: 1/22/2018 3:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rating](
	[RatingID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](250) NULL,
	[MultiPrice] [float] NULL,
 CONSTRAINT [PK_Rating] PRIMARY KEY CLUSTERED 
(
	[RatingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 1/22/2018 3:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation](
	[ReserveID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NULL,
	[ClientID] [int] NULL,
	[StartTime] [datetime] NULL,
	[EndTime] [datetime] NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED 
(
	[ReserveID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 1/22/2018 3:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](250) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role_Rule]    Script Date: 1/22/2018 3:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role_Rule](
	[RoleID] [int] NOT NULL,
	[RuleID] [int] NOT NULL,
 CONSTRAINT [PK_Role_Rule] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC,
	[RuleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 1/22/2018 3:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[RoomID] [int] IDENTITY(1,1) NOT NULL,
	[HotelID] [int] NULL,
	[TypeID] [int] NULL,
	[RatingID] [int] NULL,
	[RoomNumber] [int] NULL,
	[Description] [nvarchar](250) NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room_Reserve]    Script Date: 1/22/2018 3:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room_Reserve](
	[RoomID] [int] NOT NULL,
	[ReserveID] [int] NOT NULL,
 CONSTRAINT [PK_Room_Reserve] PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC,
	[ReserveID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room_Service]    Script Date: 1/22/2018 3:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room_Service](
	[RoomID] [int] NOT NULL,
	[ServiceID] [int] NOT NULL,
 CONSTRAINT [PK_Room_Service] PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC,
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rule]    Script Date: 1/22/2018 3:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rule](
	[RuleID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](250) NULL,
 CONSTRAINT [PK_Rule] PRIMARY KEY CLUSTERED 
(
	[RuleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 1/22/2018 3:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[ServiceID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](250) NULL,
	[Price] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[ServiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 1/22/2018 3:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[TypeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](250) NULL,
	[PriceHour] [decimal](18, 0) NULL,
	[PriceDay] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 1/22/2018 3:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[RoleID] [int] NULL,
	[UserName] [nvarchar](50) NULL,
	[UserPassword] [binary](256) NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
	[Birthday] [date] NULL,
	[Address] [nvarchar](250) NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[Email] [nvarchar](250) NULL,
	[Image] [nvarchar](max) NULL,
	[ContainerName] [nvarchar](250) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_Email]    Script Date: 1/22/2018 3:17:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Email](
	[UserID] [int] NOT NULL,
	[EmailID] [int] NOT NULL,
 CONSTRAINT [PK_User_Email] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC,
	[EmailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleID], [Name], [Description]) VALUES (2, N'admin123123', N'admin123123')
INSERT [dbo].[Role] ([RoleID], [Name], [Description]) VALUES (4, N'administrator', N'quan tri vien')
SET IDENTITY_INSERT [dbo].[Role] OFF
INSERT [dbo].[Role_Rule] ([RoleID], [RuleID]) VALUES (2, 2)
SET IDENTITY_INSERT [dbo].[Rule] ON 

INSERT [dbo].[Rule] ([RuleID], [Name], [Description]) VALUES (1, N'login', N'login')
INSERT [dbo].[Rule] ([RuleID], [Name], [Description]) VALUES (2, N'login2', N'login2')
SET IDENTITY_INSERT [dbo].[Rule] OFF
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserID], [RoleID], [UserName], [UserPassword], [FirstName], [LastName], [Gender], [Birthday], [Address], [PhoneNumber], [Email], [Image], [ContainerName]) VALUES (32, 4, N'Administrator', 0xAB6212DFE66DC08CA26739BD99A62D96440C9D33B4C0A8BB6851F5A871EC0A541905B6E295D607CF614A66FD414967ADBB1857D83CBF12FBBF0534BAC787575E472B33930C480DAEBB9EB5B6299C79426EE78073A98AA1D6BEA7E353B795B8FAE3AD86C9DF5B066FAD9F854B4605E656280F3522F8C5B8A7D8A23B523FA946E9F9A640A8360A196DD27E61035E39493C2321B2D0741CF5B07FB43592DE286820E5C5A1DD6B06F5EAE5026B25810740B3C97AD9C805EDFF5DD50888C9596514165F28347A64EB959D513F8CA2547415795537FB6BC17B343FAB5A8BAD1334048B6D29DD0CF0FAEBF17A53E551CB5E4A3F9CD633F5E2654F5F03771C109CB43FEA, N'Felis', N'Silvestris', N'Male', CAST(N'2018-01-21' AS Date), N'Somewhere I Belong', N'128-937-1298', N'felissilvestris@live.com', N'C:\Users\Felis\Documents\My Projects\HomeStay\HomeStay\bin\Debug\Images\User\1489315586-148923157760998-13.jpg', N'50585_Administrator')
INSERT [dbo].[User] ([UserID], [RoleID], [UserName], [UserPassword], [FirstName], [LastName], [Gender], [Birthday], [Address], [PhoneNumber], [Email], [Image], [ContainerName]) VALUES (33, 4, N'YooSangGem', 0x39B3892E0DBE9FD71F307C861620767AE8B143E9FDB76FA5DF9094F5ECBA653BC69BE363D1305858B044C8D380C1B056604EB629FDF4F7890FECD87E2111D87930837D5B7335FFF991EAE4FACED56BF1CD556AC78297319551EB702C126BAA3CC60D33EEF99D19AC7FCAA0ECCC622707AF4C41A237170491D80BA3B35F1881F467980D461F9F7A3ADB6921773D17E6E1E42D545415B6B00CEB932D06F09F2D5F93F051D4CCCAF3DDE663958CDFBFF6188A020772B93F9E1EC0FBCEF5AEBC1C1923EE7D079CCECBDE36A6467236076E1449789A725FCCCA44D562110A9CA18EF6F5E434832BBDE44CE9E811C805033FA73D09959AEB0CF437F36A474B87B426DD, N'Nguyễn', N'Sang', N'Male', CAST(N'2018-01-22' AS Date), N'Somewhere I Belong', N'120-387-1283', N'nguyenminhsang5692@gmail.com', N'C:\Users\Felis\Documents\My Projects\HomeStay\HomeStay\bin\Debug\Images\User\me-man-khuon-mat-gay-nghien-cua-hot-girl-han-quoc-sexy.jpg', N'97588_YooSangGem')
SET IDENTITY_INSERT [dbo].[User] OFF
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_Reservation] FOREIGN KEY([ReserveID])
REFERENCES [dbo].[Reservation] ([ReserveID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_Reservation]
GO
ALTER TABLE [dbo].[Bill]  WITH CHECK ADD  CONSTRAINT [FK_Bill_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Bill] CHECK CONSTRAINT [FK_Bill_User]
GO
ALTER TABLE [dbo].[Email]  WITH CHECK ADD  CONSTRAINT [FK_Email_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
GO
ALTER TABLE [dbo].[Email] CHECK CONSTRAINT [FK_Email_Client]
GO
ALTER TABLE [dbo].[Hotel]  WITH CHECK ADD  CONSTRAINT [FK_Hotel_Event1] FOREIGN KEY([EventID])
REFERENCES [dbo].[Event] ([EventID])
GO
ALTER TABLE [dbo].[Hotel] CHECK CONSTRAINT [FK_Hotel_Event1]
GO
ALTER TABLE [dbo].[Image]  WITH CHECK ADD  CONSTRAINT [FK_Image_Event] FOREIGN KEY([EventID])
REFERENCES [dbo].[Event] ([EventID])
GO
ALTER TABLE [dbo].[Image] CHECK CONSTRAINT [FK_Image_Event]
GO
ALTER TABLE [dbo].[Image]  WITH CHECK ADD  CONSTRAINT [FK_Image_Hotel] FOREIGN KEY([HotelID])
REFERENCES [dbo].[Hotel] ([HotelID])
GO
ALTER TABLE [dbo].[Image] CHECK CONSTRAINT [FK_Image_Hotel]
GO
ALTER TABLE [dbo].[Image]  WITH CHECK ADD  CONSTRAINT [FK_Image_Room] FOREIGN KEY([RoomID])
REFERENCES [dbo].[Room] ([RoomID])
GO
ALTER TABLE [dbo].[Image] CHECK CONSTRAINT [FK_Image_Room]
GO
ALTER TABLE [dbo].[Image]  WITH CHECK ADD  CONSTRAINT [FK_Image_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Image] CHECK CONSTRAINT [FK_Image_User]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_Client] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_Client]
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_User]
GO
ALTER TABLE [dbo].[Role_Rule]  WITH CHECK ADD  CONSTRAINT [FK_Role&Rule_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[Role_Rule] CHECK CONSTRAINT [FK_Role&Rule_Role]
GO
ALTER TABLE [dbo].[Role_Rule]  WITH CHECK ADD  CONSTRAINT [FK_Role&Rule_Rule] FOREIGN KEY([RuleID])
REFERENCES [dbo].[Rule] ([RuleID])
GO
ALTER TABLE [dbo].[Role_Rule] CHECK CONSTRAINT [FK_Role&Rule_Rule]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Hotel] FOREIGN KEY([HotelID])
REFERENCES [dbo].[Hotel] ([HotelID])
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_Hotel]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Rating] FOREIGN KEY([RatingID])
REFERENCES [dbo].[Rating] ([RatingID])
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_Rating]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Type] FOREIGN KEY([TypeID])
REFERENCES [dbo].[Type] ([TypeID])
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_Type]
GO
ALTER TABLE [dbo].[Room_Reserve]  WITH CHECK ADD  CONSTRAINT [FK_Room_Reserve_Reservation] FOREIGN KEY([ReserveID])
REFERENCES [dbo].[Reservation] ([ReserveID])
GO
ALTER TABLE [dbo].[Room_Reserve] CHECK CONSTRAINT [FK_Room_Reserve_Reservation]
GO
ALTER TABLE [dbo].[Room_Reserve]  WITH CHECK ADD  CONSTRAINT [FK_Room_Reserve_Room] FOREIGN KEY([RoomID])
REFERENCES [dbo].[Room] ([RoomID])
GO
ALTER TABLE [dbo].[Room_Reserve] CHECK CONSTRAINT [FK_Room_Reserve_Room]
GO
ALTER TABLE [dbo].[Room_Service]  WITH CHECK ADD  CONSTRAINT [FK_Room&Service_Room] FOREIGN KEY([RoomID])
REFERENCES [dbo].[Room] ([RoomID])
GO
ALTER TABLE [dbo].[Room_Service] CHECK CONSTRAINT [FK_Room&Service_Room]
GO
ALTER TABLE [dbo].[Room_Service]  WITH CHECK ADD  CONSTRAINT [FK_Room_Service_Service] FOREIGN KEY([ServiceID])
REFERENCES [dbo].[Service] ([ServiceID])
GO
ALTER TABLE [dbo].[Room_Service] CHECK CONSTRAINT [FK_Room_Service_Service]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
ALTER TABLE [dbo].[User_Email]  WITH CHECK ADD  CONSTRAINT [FK_User_Email_Email] FOREIGN KEY([EmailID])
REFERENCES [dbo].[Email] ([EmailID])
GO
ALTER TABLE [dbo].[User_Email] CHECK CONSTRAINT [FK_User_Email_Email]
GO
ALTER TABLE [dbo].[User_Email]  WITH CHECK ADD  CONSTRAINT [FK_User_Email_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[User_Email] CHECK CONSTRAINT [FK_User_Email_User]
GO
USE [master]
GO
ALTER DATABASE [HomeStayHotels] SET  READ_WRITE 
GO
