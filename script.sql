USE [NewDemo]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 2020/6/2 23:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[LoginId] [nvarchar](50) NOT NULL,
	[LoginPwd] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[LoginId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT INTO [dbo].[Admin] VALUES (N'123456', N'123456')
INSERT INTO [dbo].[Admin] VALUES (N'aaaaa', N'aaaaa')
INSERT INTO [dbo].[Admin] VALUES (N'admin', N'admin')
INSERT INTO [dbo].[Admin] VALUES (N'xs123456', N'xs123456')

/****** Object:  Table [dbo].[BookInfo]    Script Date: 2020/6/2 23:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookInfo](
	[BookId] [nvarchar](50) NOT NULL,
	[BookName] [nvarchar](50) NOT NULL,
	[TimeIn] [datetime] NOT NULL,
	[BookTypeId] [int] NOT NULL,
	[Author] [nvarchar](50) NULL,
	[BookNumber] [nvarchar](50) NULL,
	[Price] [nvarchar](50) NULL,
	[ISBS] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT INTO [dbo].[BookInfo] VALUES (N'book_00001', N'平凡的世界', N'2016-09-02 14:35:59.267', N'4', N'路遥', N'1100', N'74.5', N'ISBS_00001')
INSERT INTO [dbo].[BookInfo] VALUES (N'book_00002', N'傅雷家书', N'2016-09-02 14:35:59.267', N'4', N'傅雷', N'1234', N'22.7', N'ISBS_00002')
INSERT INTO [dbo].[BookInfo] VALUES (N'book_00003', N'百年孤独', N'2016-09-02 14:35:59.267', N'4', N'马尔克斯', N'1345', N'32.5', N'ISBS_00003')
INSERT INTO [dbo].[BookInfo] VALUES (N'book_00004', N'老人与海', N'2016-09-02 14:35:59.267', N'4', N'海明威', N'999', N'40.5', N'ISBS_00004')
INSERT INTO [dbo].[BookInfo] VALUES (N'book_00005', N'悲惨的世界', N'2016-09-02 14:35:59.267', N'4', N'雨果', N'888', N'105.6', N'ISBS_00005')



/****** Object:  Table [dbo].[BookType]    Script Date: 2020/6/2 23:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookType](
	[BookTypeId] [int] IDENTITY(1,1) NOT NULL,
	[BookTypeName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BookTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[BookType] ON
INSERT INTO [dbo].[BookType] ([BookTypeId], [BookTypeName]) VALUES (N'1', N'古典小说')
INSERT INTO [dbo].[BookType] ([BookTypeId], [BookTypeName]) VALUES (N'2', N'数学')
INSERT INTO [dbo].[BookType] ([BookTypeId], [BookTypeName]) VALUES (N'3', N'天文')
INSERT INTO [dbo].[BookType] ([BookTypeId], [BookTypeName]) VALUES (N'4', N'外国小说')
INSERT INTO [dbo].[BookType] ([BookTypeId], [BookTypeName]) VALUES (N'5', N'文学')
INSERT INTO [dbo].[BookType] ([BookTypeId], [BookTypeName]) VALUES (N'6', N'武侠小说类')
INSERT INTO [dbo].[BookType] ([BookTypeId], [BookTypeName]) VALUES (N'7', N'物理')
INSERT INTO [dbo].[BookType] ([BookTypeId], [BookTypeName]) VALUES (N'8', N'医学')
INSERT INTO [dbo].[BookType] ([BookTypeId], [BookTypeName]) VALUES (N'9', N'政治')
INSERT INTO [dbo].[BookType] ([BookTypeId], [BookTypeName]) VALUES (N'10', N'现代小说')
INSERT INTO [dbo].[BookType] ([BookTypeId], [BookTypeName]) VALUES (N'11', N'化学')
INSERT INTO [dbo].[BookType] ([BookTypeId], [BookTypeName]) VALUES (N'12', N'历史')
SET IDENTITY_INSERT [dbo].[BookType] OFF

/****** Object:  Table [dbo].[BorrowReturn]    Script Date: 2020/6/2 23:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BorrowReturn](
	[BorrowId] [int] IDENTITY(1,1) NOT NULL,
	[BookId] [nvarchar](50) NOT NULL,
	[ReaderId] [nvarchar](50) NOT NULL,
	[BorrowTime] [datetime] NOT NULL,
	[ReturnTime] [datetime] NOT NULL,
	[FactReturnTime] [datetime] NULL,
	[Fine] [decimal](18, 0) NOT NULL,
	[RenewCount] [int] NOT NULL,
	[BorrowRemark] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[BorrowId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 2020/6/2 23:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[ClassId] [int] IDENTITY(1,1) NOT NULL,
	[ClassName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ClassId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Class] ON
INSERT INTO [dbo].[Class] ([ClassId], [ClassName]) VALUES (N'1', N'财经三班')
INSERT INTO [dbo].[Class] ([ClassId], [ClassName]) VALUES (N'2', N'航空二班')
INSERT INTO [dbo].[Class] ([ClassId], [ClassName]) VALUES (N'3', N'航空一班')
INSERT INTO [dbo].[Class] ([ClassId], [ClassName]) VALUES (N'4', N'计算机一班')
INSERT INTO [dbo].[Class] ([ClassId], [ClassName]) VALUES (N'5', N'土建一班')
INSERT INTO [dbo].[Class] ([ClassId], [ClassName]) VALUES (N'6', N'造价二班')
SET IDENTITY_INSERT [dbo].[Class] OFF

/****** Object:  Table [dbo].[Department]    Script Date: 2020/6/2 23:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[DepartmentId] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DepartmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Department] ON
INSERT INTO [dbo].[Department] ([DepartmentId], [DepartmentName]) VALUES (N'1', N'财经系')
INSERT INTO [dbo].[Department] ([DepartmentId], [DepartmentName]) VALUES (N'2', N'航空系')
INSERT INTO [dbo].[Department] ([DepartmentId], [DepartmentName]) VALUES (N'3', N'计算机系')
INSERT INTO [dbo].[Department] ([DepartmentId], [DepartmentName]) VALUES (N'4', N'建筑系')
INSERT INTO [dbo].[Department] ([DepartmentId], [DepartmentName]) VALUES (N'5', N'英语系')
SET IDENTITY_INSERT [dbo].[Department] OFF

/****** Object:  Table [dbo].[Reader]    Script Date: 2020/6/2 23:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reader](
	[ReaderId] [nvarchar](50) NOT NULL,
	[ReaderName] [nvarchar](50) NOT NULL,
	[TimeIn] [datetime] NOT NULL,
	[TimeOut] [datetime] NOT NULL,
	[ReaderTypeId] [int] NOT NULL,
	[DepartmentId] [int] NULL,
	[ClassId] [int] NULL,
	[IdentityCard] [nvarchar](50) NULL,
	[Gender] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ReaderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT INTO [dbo].[Reader] VALUES (N'reader-00001', N'李华', N'2020-06-02 14:35:59.287', N'2020-07-02 14:35:59.287', N'1', N'1', N'1', N'511102199108220014', N'男')
INSERT INTO [dbo].[Reader] VALUES (N'reader-00002', N'张强', N'2020-06-02 14:35:59.287', N'2020-07-02 14:35:59.287', N'1', N'1', N'1', N'511102199108220014', N'男')
INSERT INTO [dbo].[Reader] VALUES (N'reader-00003', N'高红', N'2020-06-02 14:35:59.287', N'2020-07-02 14:35:59.287', N'1', N'1', N'1', N'511102199108220014', N'男')
INSERT INTO [dbo].[Reader] VALUES (N'reader-00004', N'张丽', N'2020-06-02 14:35:59.287', N'2020-07-02 14:35:59.287', N'1', N'1', N'1', N'511102199108220014', N'男')
INSERT INTO [dbo].[Reader] VALUES (N'reader-00005', N'李雄', N'2020-06-02 14:35:59.287', N'2020-07-02 14:35:59.287', N'1', N'1', N'1', N'511102199108220014', N'男')

/****** Object:  Table [dbo].[ReaderType]    Script Date: 2020/6/2 23:01:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReaderType](
	[ReaderTypeId] [int] IDENTITY(1,1) NOT NULL,
	[ReaderTypeName] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ReaderTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ReaderType] ON
INSERT INTO [dbo].[ReaderType] ([ReaderTypeId], [ReaderTypeName]) VALUES (N'1', N'老师')
INSERT INTO [dbo].[ReaderType] ([ReaderTypeId], [ReaderTypeName]) VALUES (N'2', N'其他')
INSERT INTO [dbo].[ReaderType] ([ReaderTypeId], [ReaderTypeName]) VALUES (N'3', N'学生')
INSERT INTO [dbo].[ReaderType] ([ReaderTypeId], [ReaderTypeName]) VALUES (N'4', N'员工')
SET IDENTITY_INSERT [dbo].[ReaderType] OFF



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_AddBookTypeInfo]
	@BookTypeId int output,
	@BookTypeName nvarchar(50)
as
	insert into BookType select @BookTypeName
	set @BookTypeId=@@IDENTITY
	return 0
GO
/****** Object:  StoredProcedure [dbo].[proc_addClass]    Script Date: 2020/6/2 23:00:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_addClass]
	@ClassId int output,
	@ClassName nvarchar(50)
as
	insert into Class select @ClassName
	set @ClassId=@@IDENTITY
	
	return 0;
GO
/****** Object:  StoredProcedure [dbo].[proc_addDepartment]    Script Date: 2020/6/2 23:00:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_addDepartment]
	@DepartmentId int output,
	@DepartmentName nvarchar(50)
as
	insert into Department select @DepartmentName
	set @DepartmentId=@@IDENTITY
	
	return 0;
GO
/****** Object:  StoredProcedure [dbo].[proc_AddReader]    Script Date: 2020/6/2 23:00:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_AddReader]
	@ReaderId nvarchar(50),
	@ReaderName nvarchar(50),
	@TimeIn datetime,
	@TimeOut datetime,
	@ReaderTypeId int,
	@DepartmentId int,
	@ClassId int,
	@IdentityCard nvarchar(50),
	@Gender nvarchar(50),
as
	insert into Reader select @ReaderId,@ReaderName,@TimeIn,@TimeOut,@ReaderTypeId,@DepartmentId,
				@ClassId,@IdentityCard,@Gender
	return 0;
GO
/****** Object:  StoredProcedure [dbo].[proc_addReaderType]    Script Date: 2020/6/2 23:00:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_addReaderType]
	@ReaderTypeId int output,
	@ReaderTypeName nvarchar(50)
as
	insert into ReaderType select @ReaderTypeName
	set @ReaderTypeId=@@IDENTITY
	
	return 0;
GO
/****** Object:  StoredProcedure [dbo].[proc_BorrowBook]    Script Date: 2020/6/2 23:00:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_BorrowBook]
	@BorrowId int output,
	@BookId nvarchar(50),
	@ReaderId nvarchar(50),
	@BorrowTime datetime,
	@ReturnTime datetime,
	@Fine decimal,
	@RenewCount int,
	@BorrowRemark nvarchar(50)
as
	set @ReturnTime=DATEADD(MONTH,3,@ReturnTime);
	insert into BorrowReturn(BookId,ReaderId,BorrowTime,ReturnTime,Fine,RenewCount,BorrowRemark) 
	values(@BookId,@ReaderId,@BorrowTime,@ReturnTime,@Fine,@RenewCount,@BorrowRemark)
	set @BorrowId=@@IDENTITY
	update BorrowReturn set FactReturnTime=null where BorrowId=@BorrowId
	return 0
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_AddReader]
	@ReaderId nvarchar(50),
	@ReaderName nvarchar(50),
	@TimeIn datetime,
	@TimeOut datetime,
	@ReaderTypeId int,
	@DepartmentId int,
	@ClassId int,
	@IdentityCard nvarchar(50),
	@Gender nvarchar(50)
as
	insert into Reader select @ReaderId,@ReaderName,@TimeIn,@TimeOut,@ReaderTypeId,@DepartmentId,
				@ClassId,@IdentityCard,@Gender
	return 0;
GO

ALTER TABLE [dbo].[BorrowReturn] ADD  CONSTRAINT [CK_FactReturnTime]  DEFAULT (NULL) FOR [FactReturnTime]
GO
ALTER TABLE [dbo].[BorrowReturn]  WITH CHECK ADD  CONSTRAINT [FK_BookId] FOREIGN KEY([BookId])
REFERENCES [dbo].[BookInfo] ([BookId])
GO
ALTER TABLE [dbo].[BorrowReturn] CHECK CONSTRAINT [FK_BookId]
GO
ALTER TABLE [dbo].[BorrowReturn]  WITH CHECK ADD  CONSTRAINT [FK_ReaderId] FOREIGN KEY([ReaderId])
REFERENCES [dbo].[Reader] ([ReaderId])
GO
ALTER TABLE [dbo].[BorrowReturn] CHECK CONSTRAINT [FK_ReaderId]
GO
ALTER TABLE [dbo].[Reader]  WITH CHECK ADD  CONSTRAINT [FK_ClassId] FOREIGN KEY([ClassId])
REFERENCES [dbo].[Class] ([ClassId])
GO
ALTER TABLE [dbo].[Reader] CHECK CONSTRAINT [FK_ClassId]
GO
ALTER TABLE [dbo].[Reader]  WITH CHECK ADD  CONSTRAINT [FK_DepartmentId] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([DepartmentId])
GO
ALTER TABLE [dbo].[Reader] CHECK CONSTRAINT [FK_DepartmentId]
GO
ALTER TABLE [dbo].[Reader]  WITH CHECK ADD  CONSTRAINT [FK_ReaderTypeId] FOREIGN KEY([ReaderTypeId])
REFERENCES [dbo].[ReaderType] ([ReaderTypeId])
GO
ALTER TABLE [dbo].[Reader] CHECK CONSTRAINT [FK_ReaderTypeId]
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD  CONSTRAINT [CK_LoginId] CHECK  ((len(rtrim(ltrim([LoginId])))>(4)))
GO
ALTER TABLE [dbo].[Admin] CHECK CONSTRAINT [CK_LoginId]
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD  CONSTRAINT [CK_LoginPwd] CHECK  ((len(rtrim(ltrim([LoginPwd])))>(4)))
GO
ALTER TABLE [dbo].[Admin] CHECK CONSTRAINT [CK_LoginPwd]
GO
ALTER TABLE [dbo].[Reader]  WITH CHECK ADD  CONSTRAINT [CK_Gender] CHECK  (([gender]='' OR [gender]='女' OR [gender]='男'))
GO
ALTER TABLE [dbo].[Reader] CHECK CONSTRAINT [CK_Gender]
GO
