USE [master]
GO
/****** Object:  Database [NamNT_BH00888]    Script Date: 3/27/2024 9:05:46 AM ******/
CREATE DATABASE [NamNT_BH00888]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NamNT_BH00888', FILENAME = N'D:\SQL\MSSQL16.MSSQLSERVER01\MSSQL\DATA\NamNT_BH00888.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NamNT_BH00888_log', FILENAME = N'D:\SQL\MSSQL16.MSSQLSERVER01\MSSQL\DATA\NamNT_BH00888_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [NamNT_BH00888] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NamNT_BH00888].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NamNT_BH00888] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NamNT_BH00888] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NamNT_BH00888] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NamNT_BH00888] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NamNT_BH00888] SET ARITHABORT OFF 
GO
ALTER DATABASE [NamNT_BH00888] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [NamNT_BH00888] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NamNT_BH00888] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NamNT_BH00888] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NamNT_BH00888] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NamNT_BH00888] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NamNT_BH00888] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NamNT_BH00888] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NamNT_BH00888] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NamNT_BH00888] SET  ENABLE_BROKER 
GO
ALTER DATABASE [NamNT_BH00888] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NamNT_BH00888] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NamNT_BH00888] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NamNT_BH00888] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NamNT_BH00888] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NamNT_BH00888] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NamNT_BH00888] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NamNT_BH00888] SET RECOVERY FULL 
GO
ALTER DATABASE [NamNT_BH00888] SET  MULTI_USER 
GO
ALTER DATABASE [NamNT_BH00888] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NamNT_BH00888] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NamNT_BH00888] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NamNT_BH00888] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NamNT_BH00888] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [NamNT_BH00888] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'NamNT_BH00888', N'ON'
GO
ALTER DATABASE [NamNT_BH00888] SET QUERY_STORE = ON
GO
ALTER DATABASE [NamNT_BH00888] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [NamNT_BH00888]
GO
USE [NamNT_BH00888]
GO
/****** Object:  Sequence [dbo].[sinhvienSeq]    Script Date: 3/27/2024 9:05:46 AM ******/
CREATE SEQUENCE [dbo].[sinhvienSeq] 
 AS [bigint]
 START WITH 0
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
USE [NamNT_BH00888]
GO
/****** Object:  Sequence [dbo].[StudentSeq]    Script Date: 3/27/2024 9:05:46 AM ******/
CREATE SEQUENCE [dbo].[StudentSeq] 
 AS [bigint]
 START WITH 886
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
/****** Object:  Table [dbo].[TblAccount]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblAccount](
	[UserName] [varchar](50) NULL,
	[Pass] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblClass]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblClass](
	[Date Create] [datetime] NULL,
	[Creator] [varchar](50) NULL,
	[Update Day] [datetime] NULL,
	[Updater] [varchar](50) NULL,
	[ClassCode] [bigint] IDENTITY(1,1) NOT NULL,
	[SubjectCode] [int] NOT NULL,
	[TeacherCode] [int] NOT NULL,
 CONSTRAINT [PK_TblClass] PRIMARY KEY CLUSTERED 
(
	[ClassCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblScore]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblScore](
	[Date Create] [datetime] NULL,
	[Creator] [varchar](50) NULL,
	[Update Day] [datetime] NULL,
	[Updater] [varchar](50) NULL,
	[StudentCode] [varchar](50) NOT NULL,
	[ClassCode] [bigint] NOT NULL,
	[StudyTimes] [int] NULL,
	[Score] [float] NULL,
	[Status] [varchar](50) NULL,
 CONSTRAINT [PK_TblScore] PRIMARY KEY CLUSTERED 
(
	[StudentCode] ASC,
	[ClassCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblStudent]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblStudent](
	[Date Create] [datetime] NULL,
	[Creator] [varchar](50) NULL,
	[Update Day] [datetime] NULL,
	[Updater] [varchar](50) NULL,
	[StudentCode] [varchar](50) NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[Sex] [tinyint] NULL,
	[Birth] [date] NULL,
	[Email] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[PassWord] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl.Student] PRIMARY KEY CLUSTERED 
(
	[StudentCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblSubject]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSubject](
	[Date Create] [datetime] NULL,
	[Creater] [varchar](50) NULL,
	[Update Day] [datetime] NULL,
	[Updater] [varchar](50) NULL,
	[SubjectCode] [int] IDENTITY(1,1) NOT NULL,
	[SubjectName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TblSubject] PRIMARY KEY CLUSTERED 
(
	[SubjectCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblTeacher]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblTeacher](
	[Date Create] [datetime] NULL,
	[Creator] [varchar](50) NULL,
	[Update Day] [datetime] NULL,
	[Updater] [varchar](50) NULL,
	[TeacherCode] [int] IDENTITY(1,1) NOT NULL,
	[PassWord] [varchar](50) NULL,
	[TeacherName] [nvarchar](50) NOT NULL,
	[Sex] [tinyint] NULL,
	[Birth] [date] NULL,
	[Email] [varchar](50) NOT NULL,
	[Phone] [varchar](50) NULL,
 CONSTRAINT [PK_Tbl.Teacher] PRIMARY KEY CLUSTERED 
(
	[TeacherCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TblClass] ADD  CONSTRAINT [DF_TblClass_Date Create]  DEFAULT (getdate()) FOR [Date Create]
GO
ALTER TABLE [dbo].[TblClass] ADD  CONSTRAINT [DF_TblClass_Creator]  DEFAULT ('NamNT_BH00888') FOR [Creator]
GO
ALTER TABLE [dbo].[TblClass] ADD  CONSTRAINT [DF_TblClass_Update Day]  DEFAULT (getdate()) FOR [Update Day]
GO
ALTER TABLE [dbo].[TblClass] ADD  CONSTRAINT [DF_TblClass_Updater]  DEFAULT ('NamNT_BH00888') FOR [Updater]
GO
ALTER TABLE [dbo].[TblScore] ADD  CONSTRAINT [DF_TblScore_Date Create]  DEFAULT (getdate()) FOR [Date Create]
GO
ALTER TABLE [dbo].[TblScore] ADD  CONSTRAINT [DF_TblScore_Creator]  DEFAULT ('NamNT_BH00888') FOR [Creator]
GO
ALTER TABLE [dbo].[TblScore] ADD  CONSTRAINT [DF_TblScore_Update Day]  DEFAULT (getdate()) FOR [Update Day]
GO
ALTER TABLE [dbo].[TblScore] ADD  CONSTRAINT [DF_TblScore_Updater]  DEFAULT ('NamNT_BH00888') FOR [Updater]
GO
ALTER TABLE [dbo].[TblScore] ADD  CONSTRAINT [DF_TblScore_StudyTimes]  DEFAULT ((1)) FOR [StudyTimes]
GO
ALTER TABLE [dbo].[TblScore] ADD  CONSTRAINT [DF_TblScore_TestScore 1st]  DEFAULT ((5)) FOR [Score]
GO
ALTER TABLE [dbo].[TblScore] ADD  CONSTRAINT [DF_TblScore_TestScore 2nd]  DEFAULT ((7)) FOR [Status]
GO
ALTER TABLE [dbo].[TblStudent] ADD  DEFAULT ('123') FOR [PassWord]
GO
ALTER TABLE [dbo].[TblTeacher] ADD  CONSTRAINT [DF_TblTeacher_PassWord]  DEFAULT ((123)) FOR [PassWord]
GO
ALTER TABLE [dbo].[TblClass]  WITH CHECK ADD  CONSTRAINT [FK_TblClass_TblSubject1] FOREIGN KEY([SubjectCode])
REFERENCES [dbo].[TblSubject] ([SubjectCode])
GO
ALTER TABLE [dbo].[TblClass] CHECK CONSTRAINT [FK_TblClass_TblSubject1]
GO
ALTER TABLE [dbo].[TblClass]  WITH CHECK ADD  CONSTRAINT [FK_TblClass_TblTeacher] FOREIGN KEY([TeacherCode])
REFERENCES [dbo].[TblTeacher] ([TeacherCode])
GO
ALTER TABLE [dbo].[TblClass] CHECK CONSTRAINT [FK_TblClass_TblTeacher]
GO
ALTER TABLE [dbo].[TblScore]  WITH CHECK ADD  CONSTRAINT [FK_TblScore_TblClass1] FOREIGN KEY([ClassCode])
REFERENCES [dbo].[TblClass] ([ClassCode])
GO
ALTER TABLE [dbo].[TblScore] CHECK CONSTRAINT [FK_TblScore_TblClass1]
GO
ALTER TABLE [dbo].[TblScore]  WITH CHECK ADD  CONSTRAINT [FK_TblScore_TblClass2] FOREIGN KEY([ClassCode])
REFERENCES [dbo].[TblClass] ([ClassCode])
GO
ALTER TABLE [dbo].[TblScore] CHECK CONSTRAINT [FK_TblScore_TblClass2]
GO
ALTER TABLE [dbo].[TblScore]  WITH CHECK ADD  CONSTRAINT [FK_TblScore_TblStudent] FOREIGN KEY([StudentCode])
REFERENCES [dbo].[TblStudent] ([StudentCode])
GO
ALTER TABLE [dbo].[TblScore] CHECK CONSTRAINT [FK_TblScore_TblStudent]
GO
/****** Object:  StoredProcedure [dbo].[ADDSV]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ADDSV]
@Name varchar(50),
@Sex tinyint,
@Birth date,
@Email varchar(50),
@Phone varchar(50)
as
begin
insert into TblStudent
(
StudentCode,
StudentName,
Sex,Birth,
Email,Phone

)values(
'BH00'+cast (next value for StudentSeq as varchar(50)),
@Name,
@Sex,
@Birth,
@Email,@Phone

);
if @@ROWCOUNT>0  begin return 1 end
else begin  return 0 end ;
end
GO
/****** Object:  StoredProcedure [dbo].[allClass]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[allClass]
@Search nvarchar(50)
as
begin
select
TblClass.ClassCode,
TblTeacher.TeacherName,
TblSubject.SubjectName
from TblClass 
inner join TblTeacher  on TblClass.TeacherCode = TblTeacher.TeacherCode
inner join TblSubject  on TblClass.SubjectCode = TblSubject.SubjectCode
where LOWER(TblSubject.SubjectName) like '%' +@Search+'%'
or LOWER(TblTeacher.TeacherName) like '%' +@Search+'%'

end
GO
/****** Object:  StoredProcedure [dbo].[insertClass]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertClass]
@Creator varchar(50),
@SubjectCode int,
@TeacherCode int
as
begin
insert into TblClass(Creator,TeacherCode,SubjectCode) 
values (@Creator,@TeacherCode,@SubjectCode);
if @@ROWCOUNT>0 begin return 1 end 
else begin return 0 end;
end
GO
/****** Object:  StoredProcedure [dbo].[InsertGV]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertGV]
@Creator varchar(50),
@TeacherName nvarchar(50),
@Sex tinyint,
@Birth date,
@Email varchar(50),
@Phone varchar(50)
as
begin
insert into TblTeacher
(
Creator,
TeacherName,
Sex,
Birth,
Email,
Phone
)values(
@Creator,
@TeacherName,
@Sex,
@Birth,
@Email,@Phone)
if @@ROWCOUNT >0 begin return 1 end 
else begin return 0 end;
end
GO
/****** Object:  StoredProcedure [dbo].[insertMH]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertMH]
@Creater varchar(50),
@SubjectName varchar(50)
as 
begin
insert into TblSubject
(
Creater,
SubjectName)values
(@Creater,
@SubjectName);
if @@ROWCOUNT > 0 begin return 1 end
else begin return 0 end;
end
GO
/****** Object:  StoredProcedure [dbo].[loginAccount]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[loginAccount]
@AccountType varchar(50),
@UserName varchar(50),
@PassWord varchar(50)
as
begin
if @AccountType = 'admin' 

 select * from TblAccount where UserName = @UserName and Pass = @PassWord;
else if @AccountType = 'Teacher' 
select * from TblTeacher where CONVERT( varchar(50),TeacherCode )=@UserName
and PassWord =@PassWord;
else
select *from TblStudent
where StudentCode = @UserName and PassWord = @PassWord



end
GO
/****** Object:  StoredProcedure [dbo].[score]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[score]
@Search nvarchar(50)

as
begin
select
TblStudent.StudentName,
TblClass.ClassCode,

TblScore.StudyTimes,
TblScore.Score,
TblScore.Status
from TblScore
inner join TblStudent on TblScore.StudentCode=TblStudent.StudentCode
inner join TblClass on TblScore.ClassCode = TblClass.ClassCode

where LOWER (TblStudent.StudentName) like '%' +@Search+'%'


end
GO
/****** Object:  StoredProcedure [dbo].[selectAllGV]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[selectAllGV]
@Search nvarchar(50)
as
begin
select
TeacherCode,
TeacherName,
case when Sex =1 then 'Male'
else N'Famale' end as  sex,
Email,
Phone
from TblTeacher
where 
lower (TeacherName)like'%'+lower (trim(@Search))+'%'
or Phone like '%'+lower (trim(@Search))+'%' or  cast (TeacherCode as varchar(50)) like '%'+lower (trim(@Search))+'%'
order by TeacherName
end
GO
/****** Object:  StoredProcedure [dbo].[SelectAllStudents]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Procedure [dbo].[SelectAllStudents]
@Search nvarchar(50)
As
select
 
StudentCode,
StudentName,
convert(varchar(10),Birth,103) as birth,
case
when Sex=1 then N'Famele'
else N'Mele'
end as sex ,
Email,
Phone
from TblStudent
where
StudentName like '%'+lower(trim(@Search))+'%'
or Phone like '%'+LOWER(trim(@Search))+'%'
order by StudentName
GO
/****** Object:  StoredProcedure [dbo].[selectAllSubject]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectAllSubject]
@Search nvarchar(50)
as
begin
select
SubjectCode,
SubjectName from TblSubject
where SubjectCode like '%'+lower (trim(@Search))+'%'
or lower(SubjectName) like '%'+lower (trim(@Search))+'%'
order by SubjectName;
end
GO
/****** Object:  StoredProcedure [dbo].[selectClass]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectClass]
@ClassCode bigint
as 
begin
select TeacherCode,SubjectCode from TblClass where ClassCode =@ClassCode;
end
GO
/****** Object:  StoredProcedure [dbo].[selectGV]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectGV]
@TeacherCode int 
as
begin
select
TeacherName,
Sex,
convert (varchar(10),Birth,103) as Birth,
Email,
Phone
from TblTeacher
where TeacherCode=@TeacherCode;
end
GO
/****** Object:  StoredProcedure [dbo].[selectMH]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[selectMH]
@SubjectCode int
as
begin
select
SubjectName
from TblSubject
where SubjectCode=@SubjectCode;
end
GO
/****** Object:  StoredProcedure [dbo].[SelectSv]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectSv]
@StudentCode varchar(50)
as
begin
select
StudentName ,CONVERT(varchar(50),Birth,103) as Birth,
Sex,
Email,Phone 
from TblStudent
where StudentCode= @StudentCode;
end
GO
/****** Object:  StoredProcedure [dbo].[updateClass]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateClass]
@Updater varchar(50),

@ClassCode bigint,
@SubjectCode int,
@TeacherCode int
as 
begin 
update TblClass
set Updater=@Updater,
[Update Day]=getdate(),
TeacherCode=@TeacherCode,
SubjectCode=@SubjectCode
where ClassCode = @ClassCode;
if @@ROWCOUNT>0 begin return 1 end
else begin return 0 end ;

end
GO
/****** Object:  StoredProcedure [dbo].[updateGV]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateGV]
@Updater varchar(50),
@TeacherCode int ,
@TeacherName nvarchar(50),
@Sex tinyint,
@Birth date,
@Email varchar(50),
@Phone varchar(50)
as
begin
update TblTeacher
set 
Updater=@Updater,

[Update Day]=GETDATE(),

TeacherName=@TeacherName,
Sex=@Sex,
Birth=@Birth,
Email=@Email,
Phone=@Phone
where TeacherCode=@TeacherCode
end
GO
/****** Object:  StoredProcedure [dbo].[updateMH]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateMH]
@Updater varchar(50),
@SubjectCode int,
@SubjectName varchar(50)
as 
begin
update TblSubject
set
Updater=@Updater,
[Update Day]=GETDATE(),
SubjectName=@SubjectName
where SubjectCode=@SubjectCode;
if @@ROWCOUNT>0begin return 1 end
else begin return 0 end;
end
GO
/****** Object:  StoredProcedure [dbo].[updateSV]    Script Date: 3/27/2024 9:05:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[updateSV]
@StudentCode varchar(50),
@StudentName varchar(50),
@Sex tinyint,
@Birth date,
@Email varchar(50),
@Phone varchar(50)
as
begin
update TblStudent
set
StudentName = @StudentName,
Sex = @Sex,
Birth=@Birth,
Email=@Email,
Phone=@Phone
where
StudentCode=@StudentCode;
if @@ROWCOUNT>0 begin return 1 end
else begin return 0 end;
end

GO
USE [master]
GO
ALTER DATABASE [NamNT_BH00888] SET  READ_WRITE 
GO
