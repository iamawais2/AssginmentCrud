
Create Database [AssignmentCrud]
GO
Use [AssignmentCrud]
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](300) NULL,
	[Description] [varchar](500) NULL,
	[Prize] [decimal](18, 0) NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Product] ON 
GO
INSERT [dbo].[Product] ([Id], [Name], [Description], [Prize], [Quantity]) VALUES (1, N'Battery', N'This is for testing', CAST(105 AS Decimal(18, 0)), 1000)
GO
INSERT [dbo].[Product] ([Id], [Name], [Description], [Prize], [Quantity]) VALUES (2, N'Cover', N'This is for testing', CAST(50 AS Decimal(18, 0)), 2000)
GO
INSERT [dbo].[Product] ([Id], [Name], [Description], [Prize], [Quantity]) VALUES (3, N'Protector', N'This is for testing', CAST(120 AS Decimal(18, 0)), 6000)
GO
INSERT [dbo].[Product] ([Id], [Name], [Description], [Prize], [Quantity]) VALUES (7, N'Charger', N'This is for testing', CAST(79 AS Decimal(18, 0)), 250)
GO
INSERT [dbo].[Product] ([Id], [Name], [Description], [Prize], [Quantity]) VALUES (8, N'Mobile', N'This is for testing', CAST(4400 AS Decimal(18, 0)), 40)
GO
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
