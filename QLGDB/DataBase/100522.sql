USE [QLGDB]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 5/10/2022 10:53:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CauThu]    Script Date: 5/10/2022 10:53:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauThu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Msv] [nvarchar](50) NULL,
	[HoTen] [nvarchar](50) NULL,
	[TenLop] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_dbo.CauThu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoiBong]    Script Date: 5/10/2022 10:53:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoiBong](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenDoi] [nvarchar](50) NULL,
	[Tenkhoa] [nvarchar](50) NULL,
	[IdGiaiDau] [int] NULL,
 CONSTRAINT [PK_dbo.DoiBong] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoiBongCauThu]    Script Date: 5/10/2022 10:53:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoiBongCauThu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdDoi] [int] NULL,
	[IdCauThu] [int] NULL,
 CONSTRAINT [PK_dbo.DoiBongCauThu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaiDau]    Script Date: 5/10/2022 10:53:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaiDau](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TenGiaiDau] [nvarchar](50) NULL,
	[ThoiGianBatDau] [datetime] NULL,
	[ThoiGianKetThuc] [datetime] NULL,
 CONSTRAINT [PK_dbo.GiaiDau] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichThiDau]    Script Date: 5/10/2022 10:53:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichThiDau](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdGiai] [int] NULL,
	[IdDoi1] [int] NULL,
	[IdDoi2] [int] NULL,
	[ThoiThiDau] [datetime] NULL,
	[SBTDOI1] [int] NULL,
	[SBTDOI2] [int] NULL,
 CONSTRAINT [PK_dbo.LichThiDau] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DoiBongCauThu]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DoiBongCauThu_dbo.CauThu_IdCauThu] FOREIGN KEY([IdCauThu])
REFERENCES [dbo].[CauThu] ([Id])
GO
ALTER TABLE [dbo].[DoiBongCauThu] CHECK CONSTRAINT [FK_dbo.DoiBongCauThu_dbo.CauThu_IdCauThu]
GO
ALTER TABLE [dbo].[DoiBongCauThu]  WITH CHECK ADD  CONSTRAINT [FK_dbo.DoiBongCauThu_dbo.DoiBong_IdDoi] FOREIGN KEY([IdDoi])
REFERENCES [dbo].[DoiBong] ([Id])
GO
ALTER TABLE [dbo].[DoiBongCauThu] CHECK CONSTRAINT [FK_dbo.DoiBongCauThu_dbo.DoiBong_IdDoi]
GO
ALTER TABLE [dbo].[LichThiDau]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichThiDau_dbo.DoiBong_IdDoi1] FOREIGN KEY([IdDoi1])
REFERENCES [dbo].[DoiBong] ([Id])
GO
ALTER TABLE [dbo].[LichThiDau] CHECK CONSTRAINT [FK_dbo.LichThiDau_dbo.DoiBong_IdDoi1]
GO
ALTER TABLE [dbo].[LichThiDau]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichThiDau_dbo.DoiBong_IdDoi2] FOREIGN KEY([IdDoi2])
REFERENCES [dbo].[DoiBong] ([Id])
GO
ALTER TABLE [dbo].[LichThiDau] CHECK CONSTRAINT [FK_dbo.LichThiDau_dbo.DoiBong_IdDoi2]
GO
ALTER TABLE [dbo].[LichThiDau]  WITH CHECK ADD  CONSTRAINT [FK_dbo.LichThiDau_dbo.GiaiDau_IdGiai] FOREIGN KEY([IdGiai])
REFERENCES [dbo].[GiaiDau] ([Id])
GO
ALTER TABLE [dbo].[LichThiDau] CHECK CONSTRAINT [FK_dbo.LichThiDau_dbo.GiaiDau_IdGiai]
GO
