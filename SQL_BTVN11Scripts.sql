USE [BTVNSQLBUOI1]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 4/29/2024 11:58:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[DepartmentID] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [nvarchar](250) NULL,
PRIMARY KEY CLUSTERED 
(
	[DepartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 4/29/2024 11:58:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](250) NULL,
	[LastName] [nvarchar](250) NULL,
	[Position] [nvarchar](250) NULL,
	[DepartmentID] [int] NULL,
	[Salary] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([DepartmentID], [DepartmentName]) VALUES (1, N'CẤP THẤP')
INSERT [dbo].[Departments] ([DepartmentID], [DepartmentName]) VALUES (2, N'CẤP TRUNG')
INSERT [dbo].[Departments] ([DepartmentID], [DepartmentName]) VALUES (3, N'CẤP CAO')
INSERT [dbo].[Departments] ([DepartmentID], [DepartmentName]) VALUES (4, N'CẤP THẤP')
INSERT [dbo].[Departments] ([DepartmentID], [DepartmentName]) VALUES (5, N'CẤP TRUNG')
SET IDENTITY_INSERT [dbo].[Departments] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Position], [DepartmentID], [Salary]) VALUES (1, N'PHẠM', N'BẢO KIÊN', N'Công Nhân', 1, 1000)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Position], [DepartmentID], [Salary]) VALUES (2, N'PHẠM', N'BẢO KHIÊM', N'Công Nhân', 2, 1000)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Position], [DepartmentID], [Salary]) VALUES (3, N'ĐỖ', N'ĐỨC UY', N'PHÓ GIÁM ĐỐC', 3, 2000)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Position], [DepartmentID], [Salary]) VALUES (4, N'ĐỖ', N'NHÂN', N'GIÁM ĐỐC', 4, 3000)
INSERT [dbo].[Employees] ([EmployeeID], [FirstName], [LastName], [Position], [DepartmentID], [Salary]) VALUES (5, N'SƠN', N'TÙNG', N'CHỦ TỊCH', 5, 10000)
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
