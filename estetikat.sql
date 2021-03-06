USE [estetika]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 17.6.2021. 19:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointments]    Script Date: 17.6.2021. 19:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstNameLastName] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Time] [datetime2](7) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[ServiceTypeId] [int] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contacts]    Script Date: 17.6.2021. 19:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[Fax] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dentists]    Script Date: 17.6.2021. 19:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dentists](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](30) NOT NULL,
	[LastName] [nvarchar](30) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsActive] [bit] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
 CONSTRAINT [PK_Dentists] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EKartons]    Script Date: 17.6.2021. 19:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EKartons](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[ServiceTypeId] [int] NOT NULL,
	[JawJawSideToothId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DentistId] [int] NOT NULL,
 CONSTRAINT [PK_EKartons] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JawJawSideTeeth]    Script Date: 17.6.2021. 19:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JawJawSideTeeth](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JawId] [int] NOT NULL,
	[JawSideId] [int] NOT NULL,
	[ToothId] [int] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_JawJawSideTeeth] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jaws]    Script Date: 17.6.2021. 19:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jaws](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JawName] [nvarchar](10) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Jaws] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JawSides]    Script Date: 17.6.2021. 19:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JawSides](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[JawSideName] [nvarchar](10) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_JawSides] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 17.6.2021. 19:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](30) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceTypes]    Script Date: 17.6.2021. 19:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ServiceName] [nvarchar](30) NOT NULL,
	[ServiceDescription] [nvarchar](max) NULL,
	[ServicePrice] [decimal](18, 2) NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_ServiceTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teeths]    Script Date: 17.6.2021. 19:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teeths](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ToothNumber] [int] NOT NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Teeths] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UseCaseLog]    Script Date: 17.6.2021. 19:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UseCaseLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[UseCaseName] [nvarchar](max) NULL,
	[Data] [nvarchar](max) NULL,
	[Actor] [nvarchar](max) NULL,
 CONSTRAINT [PK_UseCaseLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 17.6.2021. 19:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[RoleId] [int] NULL,
	[CreatedAt] [datetime2](7) NOT NULL,
	[ModifiedAt] [datetime2](7) NULL,
	[DeletedAt] [datetime2](7) NULL,
	[IsDeleted] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserUseCases]    Script Date: 17.6.2021. 19:45:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserUseCases](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[UseCaseId] [int] NOT NULL,
 CONSTRAINT [PK_UserUseCases] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210509150925_added dentists table', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210509152928_added entityBase class with additional fields for all tables', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210509153920_added configuration for dentist', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210509154350_added roles and roles configuration', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210509155606_added user and user configuration, changed roles configuration', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210525155815_added all configuration', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210615180215_added userusecase table', N'5.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210616203801_added relation between dentis and ekarton', N'5.0.5')
GO
SET IDENTITY_INSERT [dbo].[Appointments] ON 

INSERT [dbo].[Appointments] ([Id], [FirstNameLastName], [Email], [Date], [Time], [Phone], [ServiceTypeId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (1, N'Milutin Velisic', N'mvelisic@gmail.com', CAST(N'2021-06-14T18:38:05.6530000' AS DateTime2), CAST(N'2021-06-14T18:38:05.6530000' AS DateTime2), N'0613006462', 1, CAST(N'2021-06-14T20:39:17.3048473' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[Appointments] ([Id], [FirstNameLastName], [Email], [Date], [Time], [Phone], [ServiceTypeId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (2, N'pera peric', N'pera@gmail.com', CAST(N'2021-06-14T18:43:00.2100000' AS DateTime2), CAST(N'2021-06-14T18:43:00.2100000' AS DateTime2), N'061300642', 1, CAST(N'2021-06-14T20:43:17.3920228' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[Appointments] ([Id], [FirstNameLastName], [Email], [Date], [Time], [Phone], [ServiceTypeId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (3, N'pera peric', N'pera@gmail.com', CAST(N'2021-06-14T18:43:00.2100000' AS DateTime2), CAST(N'2021-06-14T18:43:00.2100000' AS DateTime2), N'061300642', 3, CAST(N'2021-06-14T20:44:37.9424414' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[Appointments] ([Id], [FirstNameLastName], [Email], [Date], [Time], [Phone], [ServiceTypeId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (4, N'pera', N'pera@gmail.com', CAST(N'2021-06-14T18:48:48.9740000' AS DateTime2), CAST(N'2021-06-14T18:48:48.9740000' AS DateTime2), N'0642', 1, CAST(N'2021-06-14T20:49:48.4937453' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[Appointments] ([Id], [FirstNameLastName], [Email], [Date], [Time], [Phone], [ServiceTypeId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (5, N'Milutin Velisic', N'mvelisic@gmail.com', CAST(N'2021-06-16T19:34:13.2340000' AS DateTime2), CAST(N'2021-06-16T19:34:13.2340000' AS DateTime2), N'0613006462', 1, CAST(N'2021-06-16T21:34:42.8908856' AS DateTime2), NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[Appointments] OFF
GO
SET IDENTITY_INSERT [dbo].[Dentists] ON 

INSERT [dbo].[Dentists] ([Id], [FirstName], [LastName], [CreatedAt], [DeletedAt], [IsActive], [IsDeleted], [ModifiedAt]) VALUES (1, N'pera', N'peric', CAST(N'2021-06-12T20:37:42.3076273' AS DateTime2), CAST(N'2021-06-16T22:33:03.7564270' AS DateTime2), 0, 1, CAST(N'2021-06-16T22:33:03.7736407' AS DateTime2))
INSERT [dbo].[Dentists] ([Id], [FirstName], [LastName], [CreatedAt], [DeletedAt], [IsActive], [IsDeleted], [ModifiedAt]) VALUES (2, N'pera1', N'peric1', CAST(N'2021-06-12T20:46:26.6750942' AS DateTime2), CAST(N'2021-06-12T20:56:34.5874600' AS DateTime2), 0, 1, CAST(N'2021-06-12T20:56:34.5876814' AS DateTime2))
INSERT [dbo].[Dentists] ([Id], [FirstName], [LastName], [CreatedAt], [DeletedAt], [IsActive], [IsDeleted], [ModifiedAt]) VALUES (3, N'pera12', N'peric12', CAST(N'2021-06-12T20:53:40.1229749' AS DateTime2), CAST(N'2021-06-12T20:56:20.7089125' AS DateTime2), 0, 1, CAST(N'2021-06-12T20:56:20.7352426' AS DateTime2))
INSERT [dbo].[Dentists] ([Id], [FirstName], [LastName], [CreatedAt], [DeletedAt], [IsActive], [IsDeleted], [ModifiedAt]) VALUES (4, N'pera', N'peric', CAST(N'2021-06-12T21:04:04.3669187' AS DateTime2), CAST(N'2021-06-16T22:33:07.5531934' AS DateTime2), 0, 1, CAST(N'2021-06-16T22:33:07.5532561' AS DateTime2))
INSERT [dbo].[Dentists] ([Id], [FirstName], [LastName], [CreatedAt], [DeletedAt], [IsActive], [IsDeleted], [ModifiedAt]) VALUES (5, N'Milutin', N'Velisic', CAST(N'2021-06-16T22:33:24.2710350' AS DateTime2), NULL, 1, 0, NULL)
INSERT [dbo].[Dentists] ([Id], [FirstName], [LastName], [CreatedAt], [DeletedAt], [IsActive], [IsDeleted], [ModifiedAt]) VALUES (6, N'Veljko', N'Rajkovic', CAST(N'2021-06-16T22:33:33.5403019' AS DateTime2), NULL, 1, 0, NULL)
INSERT [dbo].[Dentists] ([Id], [FirstName], [LastName], [CreatedAt], [DeletedAt], [IsActive], [IsDeleted], [ModifiedAt]) VALUES (7, N'Luka', N'Lukic', CAST(N'2021-06-16T22:33:41.7733288' AS DateTime2), NULL, 1, 0, NULL)
INSERT [dbo].[Dentists] ([Id], [FirstName], [LastName], [CreatedAt], [DeletedAt], [IsActive], [IsDeleted], [ModifiedAt]) VALUES (8, N'Megan', N'Fox', CAST(N'2021-06-16T22:33:49.5288540' AS DateTime2), NULL, 1, 0, NULL)
INSERT [dbo].[Dentists] ([Id], [FirstName], [LastName], [CreatedAt], [DeletedAt], [IsActive], [IsDeleted], [ModifiedAt]) VALUES (9, N'Milena', N'Vesic', CAST(N'2021-06-16T22:33:59.7707670' AS DateTime2), NULL, 1, 0, NULL)
INSERT [dbo].[Dentists] ([Id], [FirstName], [LastName], [CreatedAt], [DeletedAt], [IsActive], [IsDeleted], [ModifiedAt]) VALUES (10, N'Danijela', N'Nikitin', CAST(N'2021-06-16T22:34:07.3418261' AS DateTime2), NULL, 1, 0, NULL)
SET IDENTITY_INSERT [dbo].[Dentists] OFF
GO
SET IDENTITY_INSERT [dbo].[EKartons] ON 

INSERT [dbo].[EKartons] ([Id], [Date], [Price], [ServiceTypeId], [JawJawSideToothId], [UserId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive], [DentistId]) VALUES (1, CAST(N'2021-06-18T22:18:11.9210000' AS DateTime2), CAST(100.00 AS Decimal(18, 2)), 1, 1, 2, CAST(N'2021-06-17T00:18:42.6337585' AS DateTime2), NULL, NULL, 0, 1, 7)
INSERT [dbo].[EKartons] ([Id], [Date], [Price], [ServiceTypeId], [JawJawSideToothId], [UserId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive], [DentistId]) VALUES (2, CAST(N'2021-06-20T22:52:03.8090000' AS DateTime2), CAST(3000.00 AS Decimal(18, 2)), 3, 5, 2, CAST(N'2021-06-17T00:25:53.8889986' AS DateTime2), CAST(N'2021-06-17T00:54:27.5899232' AS DateTime2), NULL, 0, 1, 8)
INSERT [dbo].[EKartons] ([Id], [Date], [Price], [ServiceTypeId], [JawJawSideToothId], [UserId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive], [DentistId]) VALUES (3, CAST(N'2021-06-18T15:23:20.3080000' AS DateTime2), CAST(10.00 AS Decimal(18, 2)), 1, 1, 2, CAST(N'2021-06-17T17:23:36.9591473' AS DateTime2), CAST(N'2021-06-17T17:25:01.2128277' AS DateTime2), CAST(N'2021-06-17T17:25:01.1998506' AS DateTime2), 1, 0, 7)
SET IDENTITY_INSERT [dbo].[EKartons] OFF
GO
SET IDENTITY_INSERT [dbo].[JawJawSideTeeth] ON 

INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (1, 17, 1, 1, CAST(N'2021-06-14T19:43:45.2053972' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (2, 17, 1, 2, CAST(N'2021-06-14T21:15:31.6354213' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (3, 17, 1, 3, CAST(N'2021-06-14T21:15:40.8091822' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (4, 17, 1, 4, CAST(N'2021-06-14T21:15:43.8124205' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (5, 17, 1, 5, CAST(N'2021-06-14T21:15:46.8340582' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (6, 17, 1, 6, CAST(N'2021-06-14T21:15:50.3944184' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (7, 17, 1, 7, CAST(N'2021-06-14T21:15:54.9962295' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (8, 17, 1, 8, CAST(N'2021-06-14T21:15:57.5775054' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (9, 17, 2, 1, CAST(N'2021-06-14T21:16:37.9671066' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (10, 17, 2, 2, CAST(N'2021-06-14T21:16:41.0227778' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (11, 17, 2, 3, CAST(N'2021-06-14T21:16:43.7128178' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (12, 17, 2, 4, CAST(N'2021-06-14T21:16:46.4198247' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (13, 17, 2, 5, CAST(N'2021-06-14T21:16:49.3281740' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (14, 17, 2, 6, CAST(N'2021-06-14T21:16:51.5785890' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (15, 17, 2, 7, CAST(N'2021-06-14T21:16:54.0389880' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (16, 17, 2, 8, CAST(N'2021-06-14T21:16:56.2072263' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (17, 18, 1, 1, CAST(N'2021-06-14T21:17:39.4990822' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (18, 18, 1, 2, CAST(N'2021-06-14T21:17:43.4863074' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (19, 18, 1, 3, CAST(N'2021-06-14T21:17:45.8682755' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (20, 18, 1, 4, CAST(N'2021-06-14T21:17:48.1406399' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (21, 18, 1, 5, CAST(N'2021-06-14T21:17:50.3306718' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (22, 18, 1, 6, CAST(N'2021-06-14T21:17:52.8564182' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (23, 18, 1, 7, CAST(N'2021-06-14T21:17:54.9305206' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (24, 18, 1, 8, CAST(N'2021-06-14T21:17:56.8857622' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (25, 18, 2, 1, CAST(N'2021-06-14T21:18:01.2534611' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (26, 18, 2, 2, CAST(N'2021-06-14T21:18:03.9359874' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (27, 18, 2, 3, CAST(N'2021-06-14T21:18:05.9870234' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (28, 18, 2, 4, CAST(N'2021-06-14T21:18:08.3767685' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (29, 18, 2, 5, CAST(N'2021-06-14T21:18:10.5654402' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (30, 18, 2, 6, CAST(N'2021-06-14T21:18:14.1254542' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (31, 18, 2, 7, CAST(N'2021-06-14T21:18:16.1431257' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawJawSideTeeth] ([Id], [JawId], [JawSideId], [ToothId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (32, 18, 2, 8, CAST(N'2021-06-14T21:18:19.2855788' AS DateTime2), NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[JawJawSideTeeth] OFF
GO
SET IDENTITY_INSERT [dbo].[Jaws] ON 

INSERT [dbo].[Jaws] ([Id], [JawName], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (17, N'Upper', CAST(N'2021-06-13T14:24:28.8092208' AS DateTime2), CAST(N'2021-06-13T15:53:19.7275742' AS DateTime2), NULL, 0, 1)
INSERT [dbo].[Jaws] ([Id], [JawName], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (18, N'Lower', CAST(N'2021-06-13T15:51:55.8005219' AS DateTime2), NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[Jaws] OFF
GO
SET IDENTITY_INSERT [dbo].[JawSides] ON 

INSERT [dbo].[JawSides] ([Id], [JawSideName], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (1, N'Left', CAST(N'2021-06-13T16:24:47.1931028' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[JawSides] ([Id], [JawSideName], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (2, N'Right', CAST(N'2021-06-13T16:24:55.1170643' AS DateTime2), CAST(N'2021-06-13T16:33:42.3506173' AS DateTime2), NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[JawSides] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id], [RoleName], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (1, N'admin', CAST(N'2021-05-09T18:31:20.0487397' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[Roles] ([Id], [RoleName], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (2, N'user', CAST(N'2021-05-09T18:34:30.2783314' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[Roles] ([Id], [RoleName], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (3, N'proba', CAST(N'2021-05-09T18:40:00.8730635' AS DateTime2), NULL, CAST(N'2021-05-09T18:44:29.8549706' AS DateTime2), 1, 1)
INSERT [dbo].[Roles] ([Id], [RoleName], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (5, N'novanova', CAST(N'2021-05-09T19:00:00.9256864' AS DateTime2), CAST(N'2021-05-09T19:17:25.9867863' AS DateTime2), NULL, 1, 1)
INSERT [dbo].[Roles] ([Id], [RoleName], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (7, N'novo ime', CAST(N'2021-05-31T19:25:55.7935385' AS DateTime2), CAST(N'2021-06-12T19:59:59.2771642' AS DateTime2), NULL, 0, 1)
INSERT [dbo].[Roles] ([Id], [RoleName], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (1011, N'idemooo', CAST(N'2021-06-12T14:52:00.5832454' AS DateTime2), CAST(N'2021-06-12T19:38:25.7648000' AS DateTime2), CAST(N'2021-06-12T19:38:25.7377485' AS DateTime2), 1, 0)
INSERT [dbo].[Roles] ([Id], [RoleName], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (1017, N'nova uloga', CAST(N'2021-06-12T20:15:55.7971023' AS DateTime2), CAST(N'2021-06-12T20:20:54.7251274' AS DateTime2), NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[ServiceTypes] ON 

INSERT [dbo].[ServiceTypes] ([Id], [ServiceName], [ServiceDescription], [ServicePrice], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (1, N'Whitening - both jaws', N'Teeth whitening for both jaws', CAST(1000.00 AS Decimal(18, 2)), CAST(N'2021-06-13T17:07:52.6955886' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[ServiceTypes] ([Id], [ServiceName], [ServiceDescription], [ServicePrice], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (2, N'Proba1', N'proba1', CAST(1100.00 AS Decimal(18, 2)), CAST(N'2021-06-13T17:08:15.1133768' AS DateTime2), CAST(N'2021-06-13T17:08:42.9461747' AS DateTime2), CAST(N'2021-06-13T17:08:42.9460881' AS DateTime2), 1, 0)
INSERT [dbo].[ServiceTypes] ([Id], [ServiceName], [ServiceDescription], [ServicePrice], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (3, N'Whitening - one jaw', N'Teeth whitenining for one jaw', CAST(700.00 AS Decimal(18, 2)), CAST(N'2021-06-14T17:49:13.2139116' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[ServiceTypes] ([Id], [ServiceName], [ServiceDescription], [ServicePrice], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (4, N'Teeth removal', N'Teeth removal - simple procedure', CAST(700.00 AS Decimal(18, 2)), CAST(N'2021-06-14T17:59:30.4040900' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[ServiceTypes] ([Id], [ServiceName], [ServiceDescription], [ServicePrice], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (5, N'Teeth removal - Surgical', N'Teeth removal - surgical procedure', CAST(1000.00 AS Decimal(18, 2)), CAST(N'2021-06-14T18:01:07.1199711' AS DateTime2), CAST(N'2021-06-14T18:02:03.1219902' AS DateTime2), NULL, 0, 1)
INSERT [dbo].[ServiceTypes] ([Id], [ServiceName], [ServiceDescription], [ServicePrice], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (6, N'Descaling', N'Cleaning scale from teeth', CAST(1200.00 AS Decimal(18, 2)), CAST(N'2021-06-14T18:04:21.9733884' AS DateTime2), NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[ServiceTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Teeths] ON 

INSERT [dbo].[Teeths] ([Id], [ToothNumber], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (1, 1, CAST(N'2021-06-12T21:39:36.5506800' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[Teeths] ([Id], [ToothNumber], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (2, 2, CAST(N'2021-06-12T21:39:50.6194607' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[Teeths] ([Id], [ToothNumber], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (3, 3, CAST(N'2021-06-12T21:39:55.5207587' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[Teeths] ([Id], [ToothNumber], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (4, 4, CAST(N'2021-06-12T21:39:58.2473728' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[Teeths] ([Id], [ToothNumber], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (5, 5, CAST(N'2021-06-12T21:40:00.6631933' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[Teeths] ([Id], [ToothNumber], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (6, 6, CAST(N'2021-06-12T21:40:03.0489307' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[Teeths] ([Id], [ToothNumber], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (7, 7, CAST(N'2021-06-12T21:40:05.9991451' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[Teeths] ([Id], [ToothNumber], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (8, 8, CAST(N'2021-06-12T21:40:08.5102302' AS DateTime2), NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[Teeths] OFF
GO
SET IDENTITY_INSERT [dbo].[UseCaseLog] ON 

INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (1, CAST(N'2021-06-13T18:57:03.7584003' AS DateTime2), N'Get one role using EF', N'2', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (2, CAST(N'2021-06-13T19:05:54.7432529' AS DateTime2), N'Search roles using EF', N'{"RoleName":null,"PerPage":10,"Page":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (3, CAST(N'2021-06-14T14:47:46.5558514' AS DateTime2), N'Create jaw using EF', N'{"Id":0,"JawName":"0","JawType":0}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (4, CAST(N'2021-06-14T14:51:11.4973307' AS DateTime2), N'Create jaw using EF', N'{"Id":0,"JawName":"proba","JawType":0}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (5, CAST(N'2021-06-14T14:51:49.9913842' AS DateTime2), N'Create jaw using EF', N'{"Id":0,"JawName":"proba","JawType":0}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (6, CAST(N'2021-06-14T15:49:11.4221094' AS DateTime2), N'Create serviceType using EF', N'{"Id":0,"ServiceName":"Whitening - one jaw","ServiceDescription":"Teeth whitenining for one jaw","ServicePrice":700.0}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (7, CAST(N'2021-06-14T15:59:30.3515954' AS DateTime2), N'Create serviceType using EF', N'{"Id":0,"ServiceName":"Teeth removal","ServiceDescription":"Teeth removal - simple procedure","ServicePrice":700.0}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (8, CAST(N'2021-06-14T16:01:07.0812214' AS DateTime2), N'Create serviceType using EF', N'{"Id":0,"ServiceName":"Teeth removal - Surgical","ServiceDescription":"Teeth removal - surgical procedure","ServicePrice":100.0}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (9, CAST(N'2021-06-14T16:02:02.8049127' AS DateTime2), N'Update serviceType using EF', N'{"Id":5,"ServiceName":"Teeth removal - Surgical","ServiceDescription":"Teeth removal - surgical procedure","ServicePrice":1000.0}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (10, CAST(N'2021-06-14T16:04:21.9348436' AS DateTime2), N'Create serviceType using EF', N'{"Id":0,"ServiceName":"Descaling","ServiceDescription":"Cleaning scale from teeth","ServicePrice":1200.0}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (11, CAST(N'2021-06-14T16:17:29.5485723' AS DateTime2), N'Search ServiceTypes using EF', N'{"ServiceName":"teeth","ServiceDescription":null,"PerPage":10,"Page":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (12, CAST(N'2021-06-14T16:17:46.8838782' AS DateTime2), N'Search ServiceTypes using EF', N'{"ServiceName":"te","ServiceDescription":null,"PerPage":10,"Page":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (13, CAST(N'2021-06-14T16:24:11.3696933' AS DateTime2), N'Get one serviceType using EF', N'3', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (14, CAST(N'2021-06-14T16:24:19.8213987' AS DateTime2), N'Get one serviceType using EF', N'5', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (15, CAST(N'2021-06-14T16:24:50.1490140' AS DateTime2), N'Search ServiceTypes using EF', N'{"ServiceName":null,"ServiceDescription":"te","PerPage":10,"Page":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (16, CAST(N'2021-06-14T16:26:29.1605285' AS DateTime2), N'Search ServiceTypes using EF', N'{"ServiceName":"te","ServiceDescription":null,"PerPage":10,"Page":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (17, CAST(N'2021-06-14T16:26:34.8248518' AS DateTime2), N'Search ServiceTypes using EF', N'{"ServiceName":null,"ServiceDescription":null,"PerPage":10,"Page":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (18, CAST(N'2021-06-14T16:26:44.5614773' AS DateTime2), N'Search ServiceTypes using EF', N'{"ServiceName":null,"ServiceDescription":"one","PerPage":10,"Page":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (19, CAST(N'2021-06-14T16:27:11.1416909' AS DateTime2), N'Search ServiceTypes using EF', N'{"ServiceName":null,"ServiceDescription":"one","PerPage":10,"Page":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (20, CAST(N'2021-06-14T16:27:56.8050882' AS DateTime2), N'Search ServiceTypes using EF', N'{"ServiceName":null,"ServiceDescription":"one","PerPage":10,"Page":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (21, CAST(N'2021-06-14T16:28:23.8337553' AS DateTime2), N'Search ServiceTypes using EF', N'{"ServiceName":"t","ServiceDescription":"o","PerPage":10,"Page":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (22, CAST(N'2021-06-14T16:45:44.9191739' AS DateTime2), N'Search Dentist using EF', N'{"FirstName":"p","LastName":null,"PerPage":10,"Page":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (23, CAST(N'2021-06-14T16:46:05.3466753' AS DateTime2), N'Search Dentist using EF', N'{"FirstName":null,"LastName":"peric","PerPage":10,"Page":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (24, CAST(N'2021-06-14T16:52:23.3517319' AS DateTime2), N'Get one dentist using EF', N'1', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (25, CAST(N'2021-06-14T16:52:29.4361814' AS DateTime2), N'Get one dentist using EF', N'2', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (26, CAST(N'2021-06-14T17:43:42.9471956' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":1,"ToothId":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (27, CAST(N'2021-06-14T17:44:19.4205296' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":20,"JawSideId":1,"ToothId":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (28, CAST(N'2021-06-14T18:39:15.3845894' AS DateTime2), N'Create Appointment using EF', N'{"Id":0,"FirstNameLastName":"Milutin Velisic","Email":"mvelisic@gmail.com","Date":"2021-06-14T18:38:05.653Z","Time":"2021-06-14T18:38:05.653Z","Phone":"0613006462","ServiceTypeId":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (29, CAST(N'2021-06-14T18:42:08.3890607' AS DateTime2), N'Create Appointment using EF', N'{"Id":0,"FirstNameLastName":"pera peric","Email":"pera@gmail.com","Date":"2021-06-14T18:41:52.986Z","Time":"2021-06-14T18:41:52.986Z","Phone":"0613003132","ServiceTypeId":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (30, CAST(N'2021-06-14T18:43:15.4085792' AS DateTime2), N'Create Appointment using EF', N'{"Id":0,"FirstNameLastName":"pera peric","Email":"pera@gmail.com","Date":"2021-06-14T18:43:00.21Z","Time":"2021-06-14T18:43:00.21Z","Phone":"061300642","ServiceTypeId":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (31, CAST(N'2021-06-14T18:43:37.3874896' AS DateTime2), N'Create Appointment using EF', N'{"Id":0,"FirstNameLastName":"pera peric","Email":"pera@gmail.com","Date":"2021-06-14T18:43:00.21Z","Time":"2021-06-14T18:43:00.21Z","Phone":"061300642","ServiceTypeId":100}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (32, CAST(N'2021-06-14T18:44:14.2682286' AS DateTime2), N'Create Appointment using EF', N'{"Id":0,"FirstNameLastName":"pera peric","Email":"pera@gmail.com","Date":"2021-06-14T18:43:00.21Z","Time":"2021-06-14T18:43:00.21Z","Phone":"061300642","ServiceTypeId":2}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (33, CAST(N'2021-06-14T18:44:37.9392196' AS DateTime2), N'Create Appointment using EF', N'{"Id":0,"FirstNameLastName":"pera peric","Email":"pera@gmail.com","Date":"2021-06-14T18:43:00.21Z","Time":"2021-06-14T18:43:00.21Z","Phone":"061300642","ServiceTypeId":3}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (34, CAST(N'2021-06-14T18:49:02.9261200' AS DateTime2), N'Create Appointment using EF', N'{"Id":0,"FirstNameLastName":"pera","Email":"pera","Date":"2021-06-14T18:48:48.974Z","Time":"2021-06-14T18:48:48.974Z","Phone":"0642","ServiceTypeId":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (35, CAST(N'2021-06-14T18:49:48.4109175' AS DateTime2), N'Create Appointment using EF', N'{"Id":0,"FirstNameLastName":"pera","Email":"pera@gmail.com","Date":"2021-06-14T18:48:48.974","Time":"2021-06-14T18:48:48.974Z","Phone":"0642","ServiceTypeId":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (36, CAST(N'2021-06-14T19:15:29.6679379' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":1,"ToothId":2}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (37, CAST(N'2021-06-14T19:15:40.7754424' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":1,"ToothId":3}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (38, CAST(N'2021-06-14T19:15:43.7829296' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":1,"ToothId":4}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (39, CAST(N'2021-06-14T19:15:46.8054109' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":1,"ToothId":5}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (40, CAST(N'2021-06-14T19:15:50.3851262' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":1,"ToothId":6}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (41, CAST(N'2021-06-14T19:15:54.9800047' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":1,"ToothId":7}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (42, CAST(N'2021-06-14T19:15:57.5746474' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":1,"ToothId":8}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (43, CAST(N'2021-06-14T19:16:37.9408531' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":2,"ToothId":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (44, CAST(N'2021-06-14T19:16:41.0200431' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":2,"ToothId":2}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (45, CAST(N'2021-06-14T19:16:43.7084325' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":2,"ToothId":3}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (46, CAST(N'2021-06-14T19:16:46.4159292' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":2,"ToothId":4}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (47, CAST(N'2021-06-14T19:16:49.3250233' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":2,"ToothId":5}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (48, CAST(N'2021-06-14T19:16:51.5755731' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":2,"ToothId":6}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (49, CAST(N'2021-06-14T19:16:53.9811952' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":2,"ToothId":7}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (50, CAST(N'2021-06-14T19:16:56.1968942' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":2,"ToothId":8}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (51, CAST(N'2021-06-14T19:17:39.4696263' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":18,"JawSideId":1,"ToothId":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (52, CAST(N'2021-06-14T19:17:43.4827131' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":18,"JawSideId":1,"ToothId":2}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (53, CAST(N'2021-06-14T19:17:45.8653557' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":18,"JawSideId":1,"ToothId":3}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (54, CAST(N'2021-06-14T19:17:48.1377184' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":18,"JawSideId":1,"ToothId":4}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (55, CAST(N'2021-06-14T19:17:50.3282353' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":18,"JawSideId":1,"ToothId":5}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (56, CAST(N'2021-06-14T19:17:52.8540731' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":18,"JawSideId":1,"ToothId":6}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (57, CAST(N'2021-06-14T19:17:54.9276139' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":18,"JawSideId":1,"ToothId":7}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (58, CAST(N'2021-06-14T19:17:56.8831242' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":18,"JawSideId":1,"ToothId":8}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (59, CAST(N'2021-06-14T19:18:01.2217579' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":18,"JawSideId":2,"ToothId":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (60, CAST(N'2021-06-14T19:18:03.9257893' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":18,"JawSideId":2,"ToothId":2}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (61, CAST(N'2021-06-14T19:18:05.9834647' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":18,"JawSideId":2,"ToothId":3}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (62, CAST(N'2021-06-14T19:18:08.3741159' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":18,"JawSideId":2,"ToothId":4}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (63, CAST(N'2021-06-14T19:18:10.5619613' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":18,"JawSideId":2,"ToothId":5}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (64, CAST(N'2021-06-14T19:18:14.1222967' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":18,"JawSideId":2,"ToothId":6}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (65, CAST(N'2021-06-14T19:18:16.1398258' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":18,"JawSideId":2,"ToothId":7}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (66, CAST(N'2021-06-14T19:18:19.2825056' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":18,"JawSideId":2,"ToothId":8}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (67, CAST(N'2021-06-14T19:32:30.9333330' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":1,"ToothId":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (68, CAST(N'2021-06-14T19:50:35.2594754' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":1,"ToothId":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (69, CAST(N'2021-06-14T19:51:49.5271817' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":1,"ToothId":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (70, CAST(N'2021-06-14T19:54:05.5353336' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":17,"JawSideId":1,"ToothId":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (71, CAST(N'2021-06-14T20:18:34.6738887' AS DateTime2), N'Update JawJawSideTeeth using EF', N'{"Id":32,"JawId":18,"JawSideId":2,"ToothId":7}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (72, CAST(N'2021-06-15T14:19:11.9388425' AS DateTime2), N'Update JawJawSideTeeth using EF', N'{"Id":32,"JawId":18,"JawSideId":2,"ToothId":7}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (73, CAST(N'2021-06-15T14:20:25.3997831' AS DateTime2), N'Create jawJawSideTeeth using EF', N'{"Id":0,"JawId":18,"JawSideId":2,"ToothId":2}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (74, CAST(N'2021-06-15T14:21:40.7892577' AS DateTime2), N'Update JawJawSideTeeth using EF', N'{"Id":32,"JawId":18,"JawSideId":2,"ToothId":8}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (75, CAST(N'2021-06-15T14:26:27.5043054' AS DateTime2), N'Update JawJawSideTeeth using EF', N'{"Id":32,"JawId":18,"JawSideId":2,"ToothId":7}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (76, CAST(N'2021-06-15T14:28:29.1117791' AS DateTime2), N'Update JawJawSideTeeth using EF', N'{"Id":32,"JawId":18,"JawSideId":2,"ToothId":8}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (77, CAST(N'2021-06-15T14:38:22.7455410' AS DateTime2), N'Update JawJawSideTeeth using EF', N'{"Id":32,"JawId":18,"JawSideId":2,"ToothId":8}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (78, CAST(N'2021-06-15T15:01:34.1558856' AS DateTime2), N'Update JawJawSideTeeth using EF', N'{"Id":32,"JawId":18,"JawSideId":2,"ToothId":8}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (79, CAST(N'2021-06-15T15:02:27.3613094' AS DateTime2), N'Update JawJawSideTeeth using EF', N'{"Id":32,"JawId":18,"JawSideId":2,"ToothId":8}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (80, CAST(N'2021-06-15T18:21:24.6046317' AS DateTime2), N'Search roles using EF', N'{"RoleName":null,"PerPage":10,"Page":1}', N'Fake Admin')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (81, CAST(N'2021-06-15T19:06:44.5854054' AS DateTime2), N'Search roles using EF', N'{"RoleName":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (82, CAST(N'2021-06-15T20:12:59.2791061' AS DateTime2), N'Search Dentist using EF', N'{"FirstName":null,"LastName":null,"PerPage":10,"Page":1}', N'Anonymus')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (83, CAST(N'2021-06-16T19:20:18.0068211' AS DateTime2), N'Search Dentist using EF', N'{"FirstName":null,"LastName":null,"PerPage":10,"Page":1}', N'Anonymus')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (84, CAST(N'2021-06-16T19:26:00.7551013' AS DateTime2), N'Search Dentist using EF', N'{"FirstName":null,"LastName":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (85, CAST(N'2021-06-16T19:26:50.7863604' AS DateTime2), N'Search roles using EF', N'{"RoleName":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (86, CAST(N'2021-06-16T19:34:42.6005675' AS DateTime2), N'Create Appointment using EF', N'{"Id":0,"FirstNameLastName":"Milutin Velisic","Email":"mvelisic@gmail.com","Date":"2021-06-16T19:34:13.234Z","Time":"2021-06-16T19:34:13.234Z","Phone":"0613006462","ServiceTypeId":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (87, CAST(N'2021-06-16T20:32:31.9648293' AS DateTime2), N'Delete dentist using EF', N'2', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (88, CAST(N'2021-06-16T20:32:46.0182805' AS DateTime2), N'Delete dentist using EF', N'3', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (89, CAST(N'2021-06-16T20:33:03.7375661' AS DateTime2), N'Delete dentist using EF', N'1', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (90, CAST(N'2021-06-16T20:33:07.5260034' AS DateTime2), N'Delete dentist using EF', N'4', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (91, CAST(N'2021-06-16T20:33:24.2513659' AS DateTime2), N'Create dentist using EF!', N'{"Id":0,"FirstName":"Milutin","LastName":"Velisic"}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (92, CAST(N'2021-06-16T20:33:33.5353662' AS DateTime2), N'Create dentist using EF!', N'{"Id":0,"FirstName":"Veljko","LastName":"Rajkovic"}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (93, CAST(N'2021-06-16T20:33:41.7697562' AS DateTime2), N'Create dentist using EF!', N'{"Id":0,"FirstName":"Luka","LastName":"Lukic"}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (94, CAST(N'2021-06-16T20:33:49.5267625' AS DateTime2), N'Create dentist using EF!', N'{"Id":0,"FirstName":"Megan","LastName":"Fox"}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (95, CAST(N'2021-06-16T20:33:59.7475511' AS DateTime2), N'Create dentist using EF!', N'{"Id":0,"FirstName":"Milena","LastName":"Vesic"}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (96, CAST(N'2021-06-16T20:34:07.3111165' AS DateTime2), N'Create dentist using EF!', N'{"Id":0,"FirstName":"Danijela","LastName":"Nikitin"}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (97, CAST(N'2021-06-16T20:52:15.5064404' AS DateTime2), N'Create user using EF', N'{"Id":0,"FirstName":"Veljko","LastName":"Rajkovic","Email":"veljko@gmail.com","Password":"proba","Phone":"0111234567","RoleId":0}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (98, CAST(N'2021-06-16T21:01:56.3238229' AS DateTime2), N'Update user using EF', N'{"Id":3,"FirstName":"Luka","LastName":"Lukic","Email":"luka@gmail.com","Password":"luka123","Phone":"1231231","RoleId":2}', N'Anonymus')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (99, CAST(N'2021-06-16T21:02:29.3254871' AS DateTime2), N'Update user using EF', N'{"Id":3,"FirstName":"Luka","LastName":"Lukic","Email":"luka@gmail.com","Password":"luka123","Phone":"1231231","RoleId":2}', N'Anonymus')
GO
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (100, CAST(N'2021-06-16T21:03:40.0031288' AS DateTime2), N'Update user using EF', N'{"Id":3,"FirstName":"Luka","LastName":"Lukic","Email":"luka@gmail.com","Password":"luka123","Phone":"123123123","RoleId":2}', N'Anonymus')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (101, CAST(N'2021-06-16T21:04:54.9642728' AS DateTime2), N'Update user using EF', N'{"Id":3,"FirstName":"Luka","LastName":"Lukic","Email":"luka@gmail.com","Password":"luka123","Phone":"123123123","RoleId":2}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (102, CAST(N'2021-06-16T21:10:28.7739809' AS DateTime2), N'Delete user using EF', N'3', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (103, CAST(N'2021-06-16T21:10:46.8572017' AS DateTime2), N'Delete user using EF', N'3', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (104, CAST(N'2021-06-16T21:10:52.4282078' AS DateTime2), N'Delete user using EF', N'3', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (105, CAST(N'2021-06-16T21:11:41.9956478' AS DateTime2), N'Delete user using EF', N'3', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (106, CAST(N'2021-06-16T21:11:46.8291605' AS DateTime2), N'Delete user using EF', N'3', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (107, CAST(N'2021-06-16T21:14:04.9050968' AS DateTime2), N'Create user using EF', N'{"Id":0,"FirstName":"Milena","LastName":"Vesic","Email":"milena@gmail.com","Password":"milena123","Phone":"123123","RoleId":0}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (108, CAST(N'2021-06-16T21:14:19.0154740' AS DateTime2), N'Create user using EF', N'{"Id":0,"FirstName":"Danijela","LastName":"Nikitin","Email":"danijela@gmail.com","Password":"danijela123","Phone":"123123","RoleId":0}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (109, CAST(N'2021-06-16T21:31:44.2088850' AS DateTime2), N'Search all users using EF', N'{"FirstName":null,"Email":null,"LastName":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (110, CAST(N'2021-06-16T21:32:54.0074220' AS DateTime2), N'Search all users using EF', N'{"FirstName":null,"Email":null,"LastName":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (111, CAST(N'2021-06-16T21:33:01.8137666' AS DateTime2), N'Search all users using EF', N'{"FirstName":null,"Email":"mil","LastName":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (112, CAST(N'2021-06-16T21:33:09.4264626' AS DateTime2), N'Search all users using EF', N'{"FirstName":null,"Email":"m","LastName":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (113, CAST(N'2021-06-16T21:33:22.8442309' AS DateTime2), N'Search all users using EF', N'{"FirstName":null,"Email":"d","LastName":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (114, CAST(N'2021-06-16T21:33:28.9622757' AS DateTime2), N'Search all users using EF', N'{"FirstName":null,"Email":null,"LastName":"n","PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (115, CAST(N'2021-06-16T21:43:22.6777380' AS DateTime2), N'Get one dentist using EF', N'4', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (116, CAST(N'2021-06-16T21:44:31.9566910' AS DateTime2), N'Search all users using EF', N'{"FirstName":null,"Email":null,"LastName":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (117, CAST(N'2021-06-16T21:44:42.0396548' AS DateTime2), N'Get one dentist using EF', N'3', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (118, CAST(N'2021-06-16T22:16:40.3620511' AS DateTime2), N'Create Ekarton using EF', N'{"Id":0,"Date":"2021-06-16T22:16:15.967Z","Price":100.0,"ServiceTypeId":1,"JawJawSideToothId":1,"UserId":2,"DentistId":7}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (119, CAST(N'2021-06-16T22:18:28.8608688' AS DateTime2), N'Create Ekarton using EF', N'{"Id":0,"Date":"2021-06-16T22:18:11.921Z","Price":100.0,"ServiceTypeId":1,"JawJawSideToothId":1,"UserId":2,"DentistId":7}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (120, CAST(N'2021-06-16T22:18:42.5634236' AS DateTime2), N'Create Ekarton using EF', N'{"Id":0,"Date":"2021-06-18T22:18:11.921Z","Price":100.0,"ServiceTypeId":1,"JawJawSideToothId":1,"UserId":2,"DentistId":7}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (121, CAST(N'2021-06-16T22:25:53.2113242' AS DateTime2), N'Create Ekarton using EF', N'{"Id":0,"Date":"2021-06-19T22:25:29.158Z","Price":200.0,"ServiceTypeId":1,"JawJawSideToothId":2,"UserId":2,"DentistId":7}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (122, CAST(N'2021-06-16T22:28:56.9651486' AS DateTime2), N'Create Ekarton using EF', N'{"Id":0,"Date":"2021-06-19T22:25:29.158Z","Price":200.0,"ServiceTypeId":51,"JawJawSideToothId":2,"UserId":2,"DentistId":7}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (123, CAST(N'2021-06-16T22:52:47.2251225' AS DateTime2), N'Update ekarton using EF', N'{"Id":2,"Date":"2021-06-20T22:52:03.809Z","Price":3000.0,"ServiceTypeId":3,"JawJawSideToothId":5,"UserId":2,"DentistId":8}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (124, CAST(N'2021-06-16T22:54:27.1665989' AS DateTime2), N'Update ekarton using EF', N'{"Id":2,"Date":"2021-06-20T22:52:03.809Z","Price":3000.0,"ServiceTypeId":3,"JawJawSideToothId":5,"UserId":2,"DentistId":8}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (125, CAST(N'2021-06-16T22:54:54.6365195' AS DateTime2), N'Update ekarton using EF', N'{"Id":2,"Date":"2021-06-20T22:52:03.809Z","Price":3000.0,"ServiceTypeId":111,"JawJawSideToothId":5,"UserId":2,"DentistId":8}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (126, CAST(N'2021-06-17T15:23:36.4934169' AS DateTime2), N'Create Ekarton using EF', N'{"Id":0,"Date":"2021-06-18T15:23:20.308Z","Price":10.0,"ServiceTypeId":1,"JawJawSideToothId":1,"UserId":2,"DentistId":7}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (127, CAST(N'2021-06-17T15:23:54.3267429' AS DateTime2), N'Delete EKarton using EF', N'3', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (128, CAST(N'2021-06-17T15:25:00.9369027' AS DateTime2), N'Delete EKarton using EF', N'3', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (129, CAST(N'2021-06-17T15:59:41.5161824' AS DateTime2), N'Search EKarton using EF', N'{"LastName":null,"FirstName":null,"Service":null,"DentistFirstName":null,"DentistLastName":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (130, CAST(N'2021-06-17T16:00:03.5525845' AS DateTime2), N'Search EKarton using EF', N'{"LastName":null,"FirstName":null,"Service":null,"DentistFirstName":"luka","DentistLastName":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (131, CAST(N'2021-06-17T16:00:10.2037624' AS DateTime2), N'Search EKarton using EF', N'{"LastName":null,"FirstName":null,"Service":null,"DentistFirstName":"megan","DentistLastName":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (132, CAST(N'2021-06-17T16:00:20.6137744' AS DateTime2), N'Search EKarton using EF', N'{"LastName":null,"FirstName":"milutin","Service":null,"DentistFirstName":null,"DentistLastName":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (133, CAST(N'2021-06-17T16:00:39.2940121' AS DateTime2), N'Search EKarton using EF', N'{"LastName":null,"FirstName":null,"Service":null,"DentistFirstName":null,"DentistLastName":"f","PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (134, CAST(N'2021-06-17T16:09:46.8275272' AS DateTime2), N'Search one ekarton using EF', N'1', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (135, CAST(N'2021-06-17T16:09:55.5470205' AS DateTime2), N'Search one ekarton using EF', N'2', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (136, CAST(N'2021-06-17T16:09:58.0727311' AS DateTime2), N'Search one ekarton using EF', N'3', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (137, CAST(N'2021-06-17T16:45:05.4170875' AS DateTime2), N'Search UseCaseLog using EF', N'{"UseCaseName":null,"Actor":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (138, CAST(N'2021-06-17T16:45:24.9638850' AS DateTime2), N'Search UseCaseLog using EF', N'{"UseCaseName":null,"Actor":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (139, CAST(N'2021-06-17T16:45:42.0833114' AS DateTime2), N'Search UseCaseLog using EF', N'{"UseCaseName":null,"Actor":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (140, CAST(N'2021-06-17T16:46:01.1330032' AS DateTime2), N'Search UseCaseLog using EF', N'{"UseCaseName":null,"Actor":"mvelisic","PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (141, CAST(N'2021-06-17T16:46:13.3568957' AS DateTime2), N'Search UseCaseLog using EF', N'{"UseCaseName":"create","Actor":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (142, CAST(N'2021-06-17T16:46:49.4392445' AS DateTime2), N'Search UseCaseLog using EF', N'{"UseCaseName":"create","Actor":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (143, CAST(N'2021-06-17T16:47:15.1192230' AS DateTime2), N'Search UseCaseLog using EF', N'{"UseCaseName":"create","Actor":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (144, CAST(N'2021-06-17T16:47:45.1097531' AS DateTime2), N'Search UseCaseLog using EF', N'{"UseCaseName":"create","Actor":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (145, CAST(N'2021-06-17T17:08:44.4867423' AS DateTime2), N'Search Appointments using EF', N'{"FirstNameLastName":null,"Service":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (146, CAST(N'2021-06-17T17:08:51.1313163' AS DateTime2), N'Search Appointments using EF', N'{"FirstNameLastName":"Milutin","Service":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
INSERT [dbo].[UseCaseLog] ([Id], [Date], [UseCaseName], [Data], [Actor]) VALUES (147, CAST(N'2021-06-17T17:08:59.8959083' AS DateTime2), N'Search Appointments using EF', N'{"FirstNameLastName":null,"Service":null,"PerPage":10,"Page":1}', N'mvelisic@gmail.com')
SET IDENTITY_INSERT [dbo].[UseCaseLog] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [Password], [Phone], [RoleId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (2, N'Milutin', N'Velisic', N'mvelisic@gmail.com', N'milke281', N'0613006462', 1, CAST(N'2021-06-13T17:08:42.9461747' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [Password], [Phone], [RoleId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (3, N'Luka', N'Lukic', N'luka@gmail.com', N'luka123', N'123123123', 2, CAST(N'2021-06-16T22:52:15.7809484' AS DateTime2), CAST(N'2021-06-16T23:11:42.2114532' AS DateTime2), CAST(N'2021-06-16T23:11:42.1996113' AS DateTime2), 1, 0)
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [Password], [Phone], [RoleId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (4, N'Milena', N'Vesic', N'milena@gmail.com', N'milena123', N'123123', 2, CAST(N'2021-06-16T23:14:05.1372195' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [Password], [Phone], [RoleId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (5, N'Danijela', N'Nikitin', N'danijela@gmail.com', N'danijela123', N'123123', 2, CAST(N'2021-06-16T23:14:19.0228859' AS DateTime2), NULL, NULL, 0, 1)
INSERT [dbo].[Users] ([Id], [FirstName], [LastName], [Email], [Password], [Phone], [RoleId], [CreatedAt], [ModifiedAt], [DeletedAt], [IsDeleted], [IsActive]) VALUES (6, N'pera', N'peric', N'pera@gmail.com', N'pera123', N'123456789', 1, CAST(N'2021-06-17T19:24:00.2818712' AS DateTime2), NULL, NULL, 0, 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[UserUseCases] ON 

INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (2, 2, 1)
INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (3, 2, 2)
INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (4, 2, 3)
INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (5, 2, 4)
INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (6, 2, 5)
INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (7, 2, 19)
INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (8, 2, 25)
INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (9, 2, 31)
INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (10, 2, 32)
INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (11, 2, 33)
INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (12, 2, 34)
INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (13, 2, 35)
INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (14, 2, 36)
INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (15, 2, 40)
INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (16, 2, 41)
INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (17, 2, 42)
INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (18, 2, 43)
INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (19, 2, 44)
INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (20, 2, 45)
INSERT [dbo].[UserUseCases] ([Id], [UserId], [UseCaseId]) VALUES (21, 2, 46)
SET IDENTITY_INSERT [dbo].[UserUseCases] OFF
GO
ALTER TABLE [dbo].[Dentists] ADD  DEFAULT (N'') FOR [FirstName]
GO
ALTER TABLE [dbo].[Dentists] ADD  DEFAULT (N'') FOR [LastName]
GO
ALTER TABLE [dbo].[Dentists] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedAt]
GO
ALTER TABLE [dbo].[Dentists] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsActive]
GO
ALTER TABLE [dbo].[Dentists] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[EKartons] ADD  DEFAULT ((0)) FOR [DentistId]
GO
ALTER TABLE [dbo].[Roles] ADD  DEFAULT (N'') FOR [RoleName]
GO
ALTER TABLE [dbo].[Appointments]  WITH CHECK ADD  CONSTRAINT [FK_Appointments_ServiceTypes_ServiceTypeId] FOREIGN KEY([ServiceTypeId])
REFERENCES [dbo].[ServiceTypes] ([Id])
GO
ALTER TABLE [dbo].[Appointments] CHECK CONSTRAINT [FK_Appointments_ServiceTypes_ServiceTypeId]
GO
ALTER TABLE [dbo].[EKartons]  WITH CHECK ADD  CONSTRAINT [FK_EKartons_Dentists_DentistId] FOREIGN KEY([DentistId])
REFERENCES [dbo].[Dentists] ([Id])
GO
ALTER TABLE [dbo].[EKartons] CHECK CONSTRAINT [FK_EKartons_Dentists_DentistId]
GO
ALTER TABLE [dbo].[EKartons]  WITH CHECK ADD  CONSTRAINT [FK_EKartons_JawJawSideTeeth_JawJawSideToothId] FOREIGN KEY([JawJawSideToothId])
REFERENCES [dbo].[JawJawSideTeeth] ([Id])
GO
ALTER TABLE [dbo].[EKartons] CHECK CONSTRAINT [FK_EKartons_JawJawSideTeeth_JawJawSideToothId]
GO
ALTER TABLE [dbo].[EKartons]  WITH CHECK ADD  CONSTRAINT [FK_EKartons_ServiceTypes_ServiceTypeId] FOREIGN KEY([ServiceTypeId])
REFERENCES [dbo].[ServiceTypes] ([Id])
GO
ALTER TABLE [dbo].[EKartons] CHECK CONSTRAINT [FK_EKartons_ServiceTypes_ServiceTypeId]
GO
ALTER TABLE [dbo].[EKartons]  WITH CHECK ADD  CONSTRAINT [FK_EKartons_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EKartons] CHECK CONSTRAINT [FK_EKartons_Users_UserId]
GO
ALTER TABLE [dbo].[JawJawSideTeeth]  WITH CHECK ADD  CONSTRAINT [FK_JawJawSideTeeth_Jaws_JawId] FOREIGN KEY([JawId])
REFERENCES [dbo].[Jaws] ([Id])
GO
ALTER TABLE [dbo].[JawJawSideTeeth] CHECK CONSTRAINT [FK_JawJawSideTeeth_Jaws_JawId]
GO
ALTER TABLE [dbo].[JawJawSideTeeth]  WITH CHECK ADD  CONSTRAINT [FK_JawJawSideTeeth_JawSides_JawSideId] FOREIGN KEY([JawSideId])
REFERENCES [dbo].[JawSides] ([Id])
GO
ALTER TABLE [dbo].[JawJawSideTeeth] CHECK CONSTRAINT [FK_JawJawSideTeeth_JawSides_JawSideId]
GO
ALTER TABLE [dbo].[JawJawSideTeeth]  WITH CHECK ADD  CONSTRAINT [FK_JawJawSideTeeth_Teeths_ToothId] FOREIGN KEY([ToothId])
REFERENCES [dbo].[Teeths] ([Id])
GO
ALTER TABLE [dbo].[JawJawSideTeeth] CHECK CONSTRAINT [FK_JawJawSideTeeth_Teeths_ToothId]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles_RoleId]
GO
ALTER TABLE [dbo].[UserUseCases]  WITH CHECK ADD  CONSTRAINT [FK_UserUseCases_Users_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserUseCases] CHECK CONSTRAINT [FK_UserUseCases_Users_UserId]
GO
