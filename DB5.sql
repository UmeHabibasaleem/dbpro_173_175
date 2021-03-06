USE [DB5]
GO
/****** Object:  Table [dbo].[Attendence]    Script Date: 4/30/2019 9:08:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Attendence](
	[AttendenceID] [int] IDENTITY(1,1) NOT NULL,
	[StaffID] [int] NULL,
	[Date] [datetime] NULL,
	[Status] [nchar](10) NULL,
 CONSTRAINT [PK_Attendence] PRIMARY KEY CLUSTERED 
(
	[AttendenceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 4/30/2019 9:08:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Type] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comapny]    Script Date: 4/30/2019 9:08:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comapny](
	[CompanyID] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](50) NULL,
	[CompanyAddress] [nvarchar](max) NULL,
	[CompanyType] [nvarchar](50) NULL,
 CONSTRAINT [PK_Comapny] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedicalStore]    Script Date: 4/30/2019 9:08:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicalStore](
	[ShopId] [int] IDENTITY(1,1) NOT NULL,
	[ShopName] [nvarchar](50) NULL,
	[ShopAddress] [nvarchar](50) NULL,
 CONSTRAINT [PK_Owner] PRIMARY KEY CLUSTERED 
(
	[ShopId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicine]    Script Date: 4/30/2019 9:08:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicine](
	[MedId] [int] IDENTITY(1,1) NOT NULL,
	[MedicineName] [nvarchar](50) NOT NULL,
	[Company] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[Measurement] [nvarchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[StockID] [int] NULL,
	[CategoryID] [int] NULL,
 CONSTRAINT [PK_Medicine] PRIMARY KEY CLUSTERED 
(
	[MedId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salary]    Script Date: 4/30/2019 9:08:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salary](
	[SalaryId] [int] IDENTITY(1,1) NOT NULL,
	[Scale] [int] NOT NULL,
	[SalaryAmount] [int] NOT NULL,
 CONSTRAINT [PK_Salary] PRIMARY KEY CLUSTERED 
(
	[SalaryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalaryStatus]    Script Date: 4/30/2019 9:08:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalaryStatus](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SalaryID] [int] NULL,
	[StaffID] [int] NULL,
	[Status] [nchar](10) NULL,
 CONSTRAINT [PK_SalaryStatus] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salesman]    Script Date: 4/30/2019 9:08:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salesman](
	[SalesmanID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[CNIC] [nvarchar](50) NULL,
	[Phone] [nvarchar](50) NULL,
	[CompanyID] [int] NOT NULL,
	[StockID] [int] NOT NULL,
 CONSTRAINT [PK_Salesman] PRIMARY KEY CLUSTERED 
(
	[SalesmanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sells]    Script Date: 4/30/2019 9:08:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sells](
	[SellId] [int] IDENTITY(1,1) NOT NULL,
	[MedId] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[StaffId] [int] NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Sells] PRIMARY KEY CLUSTERED 
(
	[SellId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ShopOwner]    Script Date: 4/30/2019 9:08:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShopOwner](
	[OwnerId] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[CNIC] [nchar](10) NULL,
	[Email] [nvarchar](50) NULL,
	[Confirm Password] [nvarchar](50) NULL,
	[ShopId] [int] NOT NULL,
 CONSTRAINT [PK_ShopOwner] PRIMARY KEY CLUSTERED 
(
	[OwnerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 4/30/2019 9:08:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[StaffID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NULL,
	[Join Date] [datetime] NULL,
	[Post] [nvarchar](50) NOT NULL,
	[DateOfBirth] [datetime] NULL,
	[CNIC] [nchar](13) NOT NULL,
	[OwnerId] [int] NOT NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 4/30/2019 9:08:39 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[StockID] [int] IDENTITY(1,1) NOT NULL,
	[StockNumber] [int] NULL,
	[Stockitem] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[StockType] [nvarchar](50) NULL,
	[Quantity] [int] NOT NULL,
	[OwnerId] [int] NOT NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[StockID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Attendence] ON 

INSERT [dbo].[Attendence] ([AttendenceID], [StaffID], [Date], [Status]) VALUES (2, 1, CAST(N'2019-04-13T00:00:00.000' AS DateTime), N'Late      ')
SET IDENTITY_INSERT [dbo].[Attendence] OFF
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryID], [Name], [Type], [Description]) VALUES (1, N'Sugar', N'About Insolin', N'It can be taken inside ')
INSERT [dbo].[Category] ([CategoryID], [Name], [Type], [Description]) VALUES (2, N'Asthma', N'Enhanced Breadth', N'About Breadthing speed')
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[Comapny] ON 

INSERT [dbo].[Comapny] ([CompanyID], [CompanyName], [CompanyAddress], [CompanyType]) VALUES (1, N'Aspire+', N'Lahore', N'Blood Sugar')
INSERT [dbo].[Comapny] ([CompanyID], [CompanyName], [CompanyAddress], [CompanyType]) VALUES (2, N'Examle', N'Kasur', N'Suagr Medicines')
SET IDENTITY_INSERT [dbo].[Comapny] OFF
SET IDENTITY_INSERT [dbo].[MedicalStore] ON 

INSERT [dbo].[MedicalStore] ([ShopId], [ShopName], [ShopAddress]) VALUES (1, N'NewGeneral', N'NearHospital')
INSERT [dbo].[MedicalStore] ([ShopId], [ShopName], [ShopAddress]) VALUES (2, N'Waqar Medical Store', N'Near Lahore')
INSERT [dbo].[MedicalStore] ([ShopId], [ShopName], [ShopAddress]) VALUES (3, N'Waqar Medical Store', N'Near Lahore')
INSERT [dbo].[MedicalStore] ([ShopId], [ShopName], [ShopAddress]) VALUES (4, N'Waqar Medical Store', N'Near Lahore')
INSERT [dbo].[MedicalStore] ([ShopId], [ShopName], [ShopAddress]) VALUES (5, N'GeneralStore', N'Near General Hospital ')
SET IDENTITY_INSERT [dbo].[MedicalStore] OFF
SET IDENTITY_INSERT [dbo].[Medicine] ON 

INSERT [dbo].[Medicine] ([MedId], [MedicineName], [Company], [Description], [Measurement], [Price], [StockID], [CategoryID]) VALUES (2, N'Sugar', N'Sugar.com', N'About Bp''s', N'Gm', 30000, 1, 1)
SET IDENTITY_INSERT [dbo].[Medicine] OFF
SET IDENTITY_INSERT [dbo].[Salary] ON 

INSERT [dbo].[Salary] ([SalaryId], [Scale], [SalaryAmount]) VALUES (1, 10, 30000)
INSERT [dbo].[Salary] ([SalaryId], [Scale], [SalaryAmount]) VALUES (2, 11, 40000)
INSERT [dbo].[Salary] ([SalaryId], [Scale], [SalaryAmount]) VALUES (3, 14, 50000)
INSERT [dbo].[Salary] ([SalaryId], [Scale], [SalaryAmount]) VALUES (4, 17, 700000)
SET IDENTITY_INSERT [dbo].[Salary] OFF
SET IDENTITY_INSERT [dbo].[SalaryStatus] ON 

INSERT [dbo].[SalaryStatus] ([ID], [SalaryID], [StaffID], [Status]) VALUES (1, 1, 1, N'Paid      ')
SET IDENTITY_INSERT [dbo].[SalaryStatus] OFF
SET IDENTITY_INSERT [dbo].[Salesman] ON 

INSERT [dbo].[Salesman] ([SalesmanID], [Name], [CNIC], [Phone], [CompanyID], [StockID]) VALUES (1, N'dsdj', N'028477654', N'1984765', 1, 1)
INSERT [dbo].[Salesman] ([SalesmanID], [Name], [CNIC], [Phone], [CompanyID], [StockID]) VALUES (2, N'Mohsin', N'35209887745', N'041983757265', 1, 1)
SET IDENTITY_INSERT [dbo].[Salesman] OFF
SET IDENTITY_INSERT [dbo].[Sells] ON 

INSERT [dbo].[Sells] ([SellId], [MedId], [Price], [StaffId], [CustomerName], [Date]) VALUES (11, 2, 2000, 1, N'Samina', CAST(N'2019-04-04T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Sells] OFF
INSERT [dbo].[ShopOwner] ([OwnerId], [Name], [CNIC], [Email], [Confirm Password], [ShopId]) VALUES (1, N'Hina', N'3529774361', N'hina54796@gmail.com', N'123456', 1)
INSERT [dbo].[ShopOwner] ([OwnerId], [Name], [CNIC], [Email], [Confirm Password], [ShopId]) VALUES (4, N'Mehwish', N'3521530890', N'Mehwish@gmail.com', N'12345678', 4)
INSERT [dbo].[ShopOwner] ([OwnerId], [Name], [CNIC], [Email], [Confirm Password], [ShopId]) VALUES (5, N'Mohsin', N'3520781754', N'mohsin@gmail.com', N'12345678', 5)
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([StaffID], [FirstName], [LastName], [Join Date], [Post], [DateOfBirth], [CNIC], [OwnerId], [Email], [Password]) VALUES (1, N'Hina', N'Parveen', CAST(N'2019-04-17T00:00:00.000' AS DateTime), N'worker', CAST(N'2000-06-14T00:00:00.000' AS DateTime), N'9187451771   ', 1, N'Samina@gmail.com', N'12345678')
INSERT [dbo].[Staff] ([StaffID], [FirstName], [LastName], [Join Date], [Post], [DateOfBirth], [CNIC], [OwnerId], [Email], [Password]) VALUES (2, N'Ayat', N'Abdullah', CAST(N'2019-04-11T00:00:00.000' AS DateTime), N'Accountant', CAST(N'2019-04-12T00:00:00.000' AS DateTime), N'3520176521   ', 5, N'ayat@gmail.com', N'12345678')
INSERT [dbo].[Staff] ([StaffID], [FirstName], [LastName], [Join Date], [Post], [DateOfBirth], [CNIC], [OwnerId], [Email], [Password]) VALUES (3, N'Ali', N'Ahmed', CAST(N'2019-04-30T00:00:00.000' AS DateTime), N'pharmacist', CAST(N'2019-04-03T00:00:00.000' AS DateTime), N'3520178713   ', 5, N'ali@gmail.com', N'12345678')
INSERT [dbo].[Staff] ([StaffID], [FirstName], [LastName], [Join Date], [Post], [DateOfBirth], [CNIC], [OwnerId], [Email], [Password]) VALUES (4, N'Ahad', N'Ali', CAST(N'2010-07-08T00:00:00.000' AS DateTime), N'Accountant', CAST(N'2019-04-11T00:00:00.000' AS DateTime), N'3520875518   ', 5, N'ahad@gmail.com', N'12345678')
SET IDENTITY_INSERT [dbo].[Staff] OFF
SET IDENTITY_INSERT [dbo].[Stock] ON 

INSERT [dbo].[Stock] ([StockID], [StockNumber], [Stockitem], [Description], [StockType], [Quantity], [OwnerId]) VALUES (1, 3, N'8', N'Fever ', N'For Fever', 3, 1)
SET IDENTITY_INSERT [dbo].[Stock] OFF
ALTER TABLE [dbo].[Attendence]  WITH CHECK ADD  CONSTRAINT [FK_Attendence_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([StaffID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Attendence] CHECK CONSTRAINT [FK_Attendence_Staff]
GO
ALTER TABLE [dbo].[Medicine]  WITH CHECK ADD  CONSTRAINT [FK_Medicine_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Medicine] CHECK CONSTRAINT [FK_Medicine_Category]
GO
ALTER TABLE [dbo].[Medicine]  WITH CHECK ADD  CONSTRAINT [FK_Medicine_Stock] FOREIGN KEY([StockID])
REFERENCES [dbo].[Stock] ([StockID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Medicine] CHECK CONSTRAINT [FK_Medicine_Stock]
GO
ALTER TABLE [dbo].[SalaryStatus]  WITH CHECK ADD  CONSTRAINT [FK_SalaryStatus_Salary] FOREIGN KEY([SalaryID])
REFERENCES [dbo].[Salary] ([SalaryId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SalaryStatus] CHECK CONSTRAINT [FK_SalaryStatus_Salary]
GO
ALTER TABLE [dbo].[SalaryStatus]  WITH CHECK ADD  CONSTRAINT [FK_SalaryStatus_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([StaffID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SalaryStatus] CHECK CONSTRAINT [FK_SalaryStatus_Staff]
GO
ALTER TABLE [dbo].[Salesman]  WITH CHECK ADD  CONSTRAINT [FK_Salesman_Comapny] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Comapny] ([CompanyID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Salesman] CHECK CONSTRAINT [FK_Salesman_Comapny]
GO
ALTER TABLE [dbo].[Salesman]  WITH CHECK ADD  CONSTRAINT [FK_Salesman_Stock] FOREIGN KEY([StockID])
REFERENCES [dbo].[Stock] ([StockID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Salesman] CHECK CONSTRAINT [FK_Salesman_Stock]
GO
ALTER TABLE [dbo].[Sells]  WITH CHECK ADD  CONSTRAINT [FK_Sells_Medicine] FOREIGN KEY([MedId])
REFERENCES [dbo].[Medicine] ([MedId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sells] CHECK CONSTRAINT [FK_Sells_Medicine]
GO
ALTER TABLE [dbo].[Sells]  WITH CHECK ADD  CONSTRAINT [FK_Sells_Staff] FOREIGN KEY([StaffId])
REFERENCES [dbo].[Staff] ([StaffID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Sells] CHECK CONSTRAINT [FK_Sells_Staff]
GO
ALTER TABLE [dbo].[ShopOwner]  WITH CHECK ADD  CONSTRAINT [FK_ShopOwner_MedicalStore] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[MedicalStore] ([ShopId])
GO
ALTER TABLE [dbo].[ShopOwner] CHECK CONSTRAINT [FK_ShopOwner_MedicalStore]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_ShopOwner] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[ShopOwner] ([OwnerId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_ShopOwner]
GO
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD  CONSTRAINT [FK_Stock_ShopOwner] FOREIGN KEY([OwnerId])
REFERENCES [dbo].[ShopOwner] ([OwnerId])
GO
ALTER TABLE [dbo].[Stock] CHECK CONSTRAINT [FK_Stock_ShopOwner]
GO
