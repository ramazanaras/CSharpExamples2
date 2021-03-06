USE [master]
GO
/****** Object:  Database [MasrafOtomasyonuDB]    Script Date: 23.10.2016 02:10:03 ******/
CREATE DATABASE [MasrafOtomasyonuDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MasrafOtomasyonuDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MasrafOtomasyonuDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MasrafOtomasyonuDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\MasrafOtomasyonuDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MasrafOtomasyonuDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET RECOVERY FULL 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET  MULTI_USER 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MasrafOtomasyonuDB', N'ON'
GO
USE [MasrafOtomasyonuDB]
GO
/****** Object:  Table [dbo].[Durum]    Script Date: 23.10.2016 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Durum](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[DurumMetni] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Durum] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Masraf]    Script Date: 23.10.2016 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Masraf](
	[Id] [uniqueidentifier] NOT NULL,
	[Baslik] [nvarchar](50) NOT NULL,
	[Tarih] [date] NOT NULL,
	[Tutar] [decimal](8, 2) NOT NULL,
	[Aciklama] [nvarchar](150) NOT NULL,
	[PersonelId] [int] NOT NULL,
	[DurumId] [tinyint] NOT NULL,
 CONSTRAINT [PK_Masraf] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Personel]    Script Date: 23.10.2016 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](20) NOT NULL,
	[Soyadi] [nvarchar](20) NOT NULL,
	[Eposta] [nvarchar](150) NOT NULL,
	[KullaniciAdi] [nvarchar](20) NOT NULL,
	[Sifre] [nvarchar](10) NOT NULL,
	[AktifMi] [bit] NOT NULL,
	[SorumlusuId] [int] NULL,
	[PersonelTurId] [tinyint] NOT NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PersonelTuru]    Script Date: 23.10.2016 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonelTuru](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Tur] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PersonelTuru] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Durum] ON 

INSERT [dbo].[Durum] ([Id], [DurumMetni]) VALUES (1, N'Onay Bekliyor')
INSERT [dbo].[Durum] ([Id], [DurumMetni]) VALUES (2, N'Reddedildi')
INSERT [dbo].[Durum] ([Id], [DurumMetni]) VALUES (3, N'Düzeltilecek')
INSERT [dbo].[Durum] ([Id], [DurumMetni]) VALUES (4, N'Ödendi')
INSERT [dbo].[Durum] ([Id], [DurumMetni]) VALUES (5, N'Onaylandı')
SET IDENTITY_INSERT [dbo].[Durum] OFF
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'f5773354-27db-4a04-9ca4-2876f56a3f79', N'Test4', CAST(N'2016-10-22' AS Date), CAST(15.00 AS Decimal(8, 2)), N'Denemeee4', 1, 4)
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'b91c593f-c09d-4bd2-847d-3eb414a438a7', N'masraf 1', CAST(N'2016-10-23' AS Date), CAST(12.00 AS Decimal(8, 2)), N'asdasd', 3, 5)
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'383dc7d2-2abc-4e10-a176-85b38891724f', N'Yemek', CAST(N'2016-10-22' AS Date), CAST(15.00 AS Decimal(8, 2)), N'Öğle yemeği', 5, 1)
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'ab694541-59e4-4b31-81ce-98e23e150bc3', N'Yemek 2', CAST(N'2016-10-22' AS Date), CAST(24.00 AS Decimal(8, 2)), N'Sabah yemeği', 5, 1)
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'617cebc9-f2cb-4050-9416-9c08aad99cce', N'Test3', CAST(N'2016-10-22' AS Date), CAST(27.00 AS Decimal(8, 2)), N'Deneme3', 1, 5)
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'd225de5c-39e2-4145-a1d2-cf8edd97116f', N'Test1', CAST(N'2016-10-22' AS Date), CAST(12.00 AS Decimal(8, 2)), N'Deneme111', 2, 2)
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'320e84c6-1136-4a3b-a966-d3e8ce8f254c', N'Test90', CAST(N'2016-10-22' AS Date), CAST(15.00 AS Decimal(8, 2)), N'Denemeee4', 1, 5)
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'6fc2b73e-9208-40cf-8693-d610f4f66703', N'Test8', CAST(N'2016-10-22' AS Date), CAST(15.00 AS Decimal(8, 2)), N'Denemeee88', 1, 5)
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'98c74eff-5791-4563-852b-ed6421ad1234', N'tessst2', CAST(N'2016-10-22' AS Date), CAST(35.00 AS Decimal(8, 2)), N'bu bir deneme masrafıdırrrr', 6, 4)
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([Id], [Adi], [Soyadi], [Eposta], [KullaniciAdi], [Sifre], [AktifMi], [SorumlusuId], [PersonelTurId]) VALUES (1, N'Murat', N'Başeren', N'abc@hotmail.com', N'murat', N'123', 1, NULL, 3)
INSERT [dbo].[Personel] ([Id], [Adi], [Soyadi], [Eposta], [KullaniciAdi], [Sifre], [AktifMi], [SorumlusuId], [PersonelTurId]) VALUES (2, N'Belinay', N'Başeren', N'aaa@aaa.com', N'belinay', N'123', 1, 1, 2)
INSERT [dbo].[Personel] ([Id], [Adi], [Soyadi], [Eposta], [KullaniciAdi], [Sifre], [AktifMi], [SorumlusuId], [PersonelTurId]) VALUES (3, N'Şükran', N'Başeren', N'ccc@hotmail.com', N'sukran', N'123', 1, 2, 1)
INSERT [dbo].[Personel] ([Id], [Adi], [Soyadi], [Eposta], [KullaniciAdi], [Sifre], [AktifMi], [SorumlusuId], [PersonelTurId]) VALUES (5, N'Kadir', N'Başeren', N'bb@hotmai.com', N'kadir', N'123', 1, NULL, 4)
INSERT [dbo].[Personel] ([Id], [Adi], [Soyadi], [Eposta], [KullaniciAdi], [Sifre], [AktifMi], [SorumlusuId], [PersonelTurId]) VALUES (6, N'Ramazan', N'Aras', N'ra@hotmail.com', N'ramazan', N'123', 1, 1, 2)
SET IDENTITY_INSERT [dbo].[Personel] OFF
SET IDENTITY_INSERT [dbo].[PersonelTuru] ON 

INSERT [dbo].[PersonelTuru] ([Id], [Tur]) VALUES (1, N'Çalışan')
INSERT [dbo].[PersonelTuru] ([Id], [Tur]) VALUES (2, N'Birim Yöneticisi')
INSERT [dbo].[PersonelTuru] ([Id], [Tur]) VALUES (3, N'Yönetici')
INSERT [dbo].[PersonelTuru] ([Id], [Tur]) VALUES (4, N'Muhasebe')
SET IDENTITY_INSERT [dbo].[PersonelTuru] OFF
ALTER TABLE [dbo].[Masraf]  WITH CHECK ADD  CONSTRAINT [FK_Masraf_Durum] FOREIGN KEY([DurumId])
REFERENCES [dbo].[Durum] ([Id])
GO
ALTER TABLE [dbo].[Masraf] CHECK CONSTRAINT [FK_Masraf_Durum]
GO
ALTER TABLE [dbo].[Masraf]  WITH CHECK ADD  CONSTRAINT [FK_Masraf_Personel] FOREIGN KEY([PersonelId])
REFERENCES [dbo].[Personel] ([Id])
GO
ALTER TABLE [dbo].[Masraf] CHECK CONSTRAINT [FK_Masraf_Personel]
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD  CONSTRAINT [FK_Personel_Personel] FOREIGN KEY([SorumlusuId])
REFERENCES [dbo].[Personel] ([Id])
GO
ALTER TABLE [dbo].[Personel] CHECK CONSTRAINT [FK_Personel_Personel]
GO
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD  CONSTRAINT [FK_Personel_PersonelTuru] FOREIGN KEY([PersonelTurId])
REFERENCES [dbo].[PersonelTuru] ([Id])
GO
ALTER TABLE [dbo].[Personel] CHECK CONSTRAINT [FK_Personel_PersonelTuru]
GO
USE [master]
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET  READ_WRITE 
GO
