USE [master]
GO
/****** Object:  Database [TecnoShop]    Script Date: 17.11.2022 17:44:31 ******/
CREATE DATABASE [TecnoShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TecnoShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TecnoShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TecnoShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TecnoShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TecnoShop] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TecnoShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TecnoShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TecnoShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TecnoShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TecnoShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TecnoShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [TecnoShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TecnoShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TecnoShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TecnoShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TecnoShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TecnoShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TecnoShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TecnoShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TecnoShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TecnoShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TecnoShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TecnoShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TecnoShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TecnoShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TecnoShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TecnoShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TecnoShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TecnoShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TecnoShop] SET  MULTI_USER 
GO
ALTER DATABASE [TecnoShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TecnoShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TecnoShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TecnoShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TecnoShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TecnoShop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TecnoShop] SET QUERY_STORE = OFF
GO
USE [TecnoShop]
GO
/****** Object:  Table [dbo].[Musteriler]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteriler](
	[MusteriNo] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAdi] [varchar](50) NULL,
	[MTelefon] [int] NULL,
	[MAdres] [varchar](50) NULL,
	[PersonelNo] [int] NULL,
 CONSTRAINT [PK_Urunler] PRIMARY KEY CLUSTERED 
(
	[MusteriNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personeller]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personeller](
	[PersonelNo] [int] IDENTITY(1,1) NOT NULL,
	[PersonelAdi] [varchar](50) NULL,
	[Telefon] [int] NULL,
	[Adres] [varchar](50) NULL,
	[Maas] [money] NULL,
	[Prim] [money] NULL,
	[SubeNo] [int] NULL,
 CONSTRAINT [PK_Personeller] PRIMARY KEY CLUSTERED 
(
	[PersonelNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subeler]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subeler](
	[SubeNo] [int] IDENTITY(1,1) NOT NULL,
	[SubeAdi] [varchar](50) NULL,
	[Subeil] [varchar](50) NULL,
	[Subeilce] [varchar](50) NULL,
 CONSTRAINT [PK_Subeler] PRIMARY KEY CLUSTERED 
(
	[SubeNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urunler]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urunler](
	[UrunNo] [int] IDENTITY(1,1) NOT NULL,
	[UrunTipi] [varchar](50) NULL,
	[UrunAdi] [varchar](50) NULL,
	[UrunFiyat] [money] NULL,
	[MusteriNo] [int] NULL,
 CONSTRAINT [PK_Urun] PRIMARY KEY CLUSTERED 
(
	[UrunNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Musteriler]  WITH CHECK ADD  CONSTRAINT [FK_Musteriler_Personeller] FOREIGN KEY([PersonelNo])
REFERENCES [dbo].[Personeller] ([PersonelNo])
GO
ALTER TABLE [dbo].[Musteriler] CHECK CONSTRAINT [FK_Musteriler_Personeller]
GO
ALTER TABLE [dbo].[Personeller]  WITH CHECK ADD  CONSTRAINT [FK_Personeller_Subeler] FOREIGN KEY([SubeNo])
REFERENCES [dbo].[Subeler] ([SubeNo])
GO
ALTER TABLE [dbo].[Personeller] CHECK CONSTRAINT [FK_Personeller_Subeler]
GO
ALTER TABLE [dbo].[Urunler]  WITH CHECK ADD  CONSTRAINT [FK_Urunler_Musteriler] FOREIGN KEY([MusteriNo])
REFERENCES [dbo].[Musteriler] ([MusteriNo])
GO
ALTER TABLE [dbo].[Urunler] CHECK CONSTRAINT [FK_Urunler_Musteriler]
GO
/****** Object:  StoredProcedure [dbo].[MEkle]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MEkle] 
@MusteriAdi varchar(50),
@MTelefon int,
@MAdres varchar(50),
@PersonelNo int
as begin 
insert into Musteriler(MusteriAdi,MTelefon,MAdres,PersonelNo)
values(@MusteriAdi,@MTelefon,@MAdres,@PersonelNo)
end
GO
/****** Object:  StoredProcedure [dbo].[MListele]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MListele]
as begin 
select * from Musteriler
end
GO
/****** Object:  StoredProcedure [dbo].[MSil]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MSil]
@MusteriNo int
as begin 
delete from Musteriler where MusteriNo=@MusteriNo
end
GO
/****** Object:  StoredProcedure [dbo].[MYenile]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MYenile]
@MusterilNo int,
@MusteriAdi varchar(50),
@MTelefon int,
@MAdres varchar(50),
@PersonelNo int
as begin 
update Musteriler set MusteriAdi=@MusteriAdi,MTelefon=@MTelefon,MAdres=@MAdres, PersonelNo=@PersonelNo where MusteriNo=@MusterilNo
end
GO
/****** Object:  StoredProcedure [dbo].[PEkle]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PEkle] 
@PersonelAdi varchar(50),
@Telefon int,
@Adres varchar(50),
@Maas money,
@Prim money,
@SubeNo int
as begin 
insert into Personeller(PersonelAdi,Telefon,Adres,Maas,Prim,SubeNo)
values(@PersonelAdi,@Telefon,@Adres, @Maas,@Prim,@SubeNo)
end
GO
/****** Object:  StoredProcedure [dbo].[PListele]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PListele]
as begin 
select * from Personeller
end
GO
/****** Object:  StoredProcedure [dbo].[PSil]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PSil]
@PersonelNo int
as begin 
delete from Personeller where PersonelNo=@PersonelNo
end
GO
/****** Object:  StoredProcedure [dbo].[PYenile]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PYenile]
@PersonelNo int,
@PersonelAdi varchar(50),
@Telefon int,
@Adres varchar(50),
@Maas money,
@Prim money,
@SubeNo int
as begin 
update Personeller set PersonelAdi=@PersonelAdi,Telefon=@Telefon,Adres=@Adres, Maas=@Maas,Prim=@Prim where PersonelNo=@PersonelNo
end
GO
/****** Object:  StoredProcedure [dbo].[SEkle]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SEkle] 
@SubeAdi varchar(50),
@Subeil varchar(50),
@Subeilce varchar(50)
as begin 
insert into Subeler(SubeAdi,Subeil,Subeilce)
values(@SubeAdi,@Subeil,@Subeilce)
end
GO
/****** Object:  StoredProcedure [dbo].[SListele]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SListele]
as begin 
select * from Subeler
end
GO
/****** Object:  StoredProcedure [dbo].[SSil]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SSil]
@SubeNo int
as begin 
delete from Subeler where SubeNo=@SubeNo
end
GO
/****** Object:  StoredProcedure [dbo].[SYenile]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SYenile]
@SubeNo int,
@SubeAdi varchar(50),
@Subeil varchar(50),
@Subeilce varchar(50)
as begin 
update Subeler set SubeAdi=@SubeAdi,Subeil=@Subeil,Subeilce=@Subeilce where SubeNo=@SubeNo
end
GO
/****** Object:  StoredProcedure [dbo].[UEkle]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UEkle] 
@UrunTipi varchar(50),
@UrunAdi varchar(50),
@UrunFiyat money,
@MusteriNo int
as begin 
insert into Urunler(UrunTipi,UrunAdi,UrunFiyat,MusteriNo)
values(@UrunTipi,@UrunAdi,@UrunFiyat,@MusteriNo)
end
GO
/****** Object:  StoredProcedure [dbo].[UListele]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UListele]
as begin 
select * from Urunler
end
GO
/****** Object:  StoredProcedure [dbo].[USil]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[USil]
@UrumNo int
as begin 
delete from Urunler where UrunNo=@UrumNo
end
GO
/****** Object:  StoredProcedure [dbo].[UYenile]    Script Date: 17.11.2022 17:44:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[UYenile]
@UrunNo int,
@UrunTipi varchar(50),
@UrunAdi varchar(50),
@UrunFiyat money,
@MusteriNo int
as begin 
update Urunler set UrunTipi=@UrunTipi,UrunAdi=@UrunAdi,UrunFiyat=@UrunFiyat, MusteriNo=@MusteriNo where UrunNo=@UrunNo
end
GO
USE [master]
GO
ALTER DATABASE [TecnoShop] SET  READ_WRITE 
GO
