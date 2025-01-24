USE [DbYTAKutuphane]
GO
/****** Object:  User [library]    Script Date: 2025-01-24 17:07:48 ******/
CREATE USER [library] FOR LOGIN [library] WITH DEFAULT_SCHEMA=[library]
GO
/****** Object:  Schema [library]    Script Date: 2025-01-24 17:07:48 ******/
CREATE SCHEMA [library]
GO
/****** Object:  Table [dbo].[TableKitaplar]    Script Date: 2025-01-24 17:07:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableKitaplar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KitapAdi] [nvarchar](200) NOT NULL,
	[YazarAdi] [varchar](40) NOT NULL,
	[YazarSoyadi] [varchar](40) NULL,
	[ISBN] [varchar](20) NULL,
	[Durum] [bit] NOT NULL,
	[OduncAlan] [int] NULL,
	[OdunAlmaTarihi] [date] NULL,
	[KitapTurKodu] [tinyint] NOT NULL,
 CONSTRAINT [PK_TableKitaplar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableKitapTurleri]    Script Date: 2025-01-24 17:07:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableKitapTurleri](
	[KitapTurKodu] [tinyint] IDENTITY(101,1) NOT NULL,
	[Aciklama] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TableKitapTurleri] PRIMARY KEY CLUSTERED 
(
	[KitapTurKodu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableKutuphaneYoneticileri]    Script Date: 2025-01-24 17:07:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableKutuphaneYoneticileri](
	[Kullaniciadi] [varchar](20) NOT NULL,
	[Sifre] [varchar](20) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TableKitaplar]  WITH CHECK ADD  CONSTRAINT [FK_TableKitaplar_TableKitapTurleri] FOREIGN KEY([KitapTurKodu])
REFERENCES [dbo].[TableKitapTurleri] ([KitapTurKodu])
GO
ALTER TABLE [dbo].[TableKitaplar] CHECK CONSTRAINT [FK_TableKitaplar_TableKitapTurleri]
GO
