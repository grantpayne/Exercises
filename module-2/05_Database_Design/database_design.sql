USE [master]
GO
/****** Object:  Database [ProjectOrganizer]    Script Date: 2/16/2019 11:47:09 PM ******/
CREATE DATABASE [ProjectOrganizer]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProjectOrganizer', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\ProjectOrganizer.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProjectOrganizer_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\ProjectOrganizer_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [ProjectOrganizer] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjectOrganizer].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjectOrganizer] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProjectOrganizer] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProjectOrganizer] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProjectOrganizer] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProjectOrganizer] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProjectOrganizer] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProjectOrganizer] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProjectOrganizer] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProjectOrganizer] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProjectOrganizer] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProjectOrganizer] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProjectOrganizer] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProjectOrganizer] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProjectOrganizer] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProjectOrganizer] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProjectOrganizer] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProjectOrganizer] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProjectOrganizer] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProjectOrganizer] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProjectOrganizer] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProjectOrganizer] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProjectOrganizer] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProjectOrganizer] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProjectOrganizer] SET  MULTI_USER 
GO
ALTER DATABASE [ProjectOrganizer] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProjectOrganizer] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProjectOrganizer] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProjectOrganizer] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProjectOrganizer] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProjectOrganizer] SET QUERY_STORE = OFF
GO
USE [ProjectOrganizer]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [ProjectOrganizer]
GO
/****** Object:  Table [dbo].[department]    Script Date: 2/16/2019 11:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[department](
	[department_num] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_department] PRIMARY KEY CLUSTERED 
(
	[department_num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 2/16/2019 11:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[employee_num] [int] NOT NULL,
	[job_title] [nvarchar](50) NOT NULL,
	[last_name] [nvarchar](50) NOT NULL,
	[first_name] [nvarchar](50) NOT NULL,
	[gender] [nvarchar](10) NOT NULL,
	[birthday] [date] NOT NULL,
	[hire_date] [date] NOT NULL,
	[department_num] [int] NOT NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[employee_num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[project]    Script Date: 2/16/2019 11:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[project](
	[project_num] [int] NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[start_date] [date] NULL,
 CONSTRAINT [PK_project] PRIMARY KEY CLUSTERED 
(
	[project_num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[project_employee]    Script Date: 2/16/2019 11:47:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[project_employee](
	[project_num] [int] NOT NULL,
	[employee_num] [int] NOT NULL,
 CONSTRAINT [PK_project_employee] PRIMARY KEY CLUSTERED 
(
	[project_num] ASC,
	[employee_num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[department] ([department_num], [name]) VALUES (1, N'Engineering')
INSERT [dbo].[department] ([department_num], [name]) VALUES (2, N'Human Resources')
INSERT [dbo].[department] ([department_num], [name]) VALUES (3, N'Administration')
INSERT [dbo].[department] ([department_num], [name]) VALUES (4, N'Sales')
INSERT [dbo].[department] ([department_num], [name]) VALUES (5, N'Customer Support')
INSERT [dbo].[department] ([department_num], [name]) VALUES (6, N'Black Ops')
INSERT [dbo].[employee] ([employee_num], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date], [department_num]) VALUES (1, N'Junior Engineer', N'Burgandy', N'Ron', N'male', CAST(N'1972-04-25' AS Date), CAST(N'2019-01-01' AS Date), 1)
INSERT [dbo].[employee] ([employee_num], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date], [department_num]) VALUES (2, N'Senior Engineer', N'Guy', N'Some', N'male', CAST(N'1969-11-02' AS Date), CAST(N'2012-12-21' AS Date), 1)
INSERT [dbo].[employee] ([employee_num], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date], [department_num]) VALUES (3, N'Payroll Supervisor', N'Sung', N'Sam', N'female', CAST(N'1983-07-17' AS Date), CAST(N'2014-07-12' AS Date), 2)
INSERT [dbo].[employee] ([employee_num], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date], [department_num]) VALUES (4, N'Talent Aquisition Specialist', N'Nelson', N'Willie', N'male', CAST(N'1933-04-29' AS Date), CAST(N'1999-04-20' AS Date), 2)
INSERT [dbo].[employee] ([employee_num], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date], [department_num]) VALUES (5, N'Human Resources Manager', N'Obama', N'Michelle', N'female', CAST(N'1964-01-17' AS Date), CAST(N'2009-01-20' AS Date), 2)
INSERT [dbo].[employee] ([employee_num], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date], [department_num]) VALUES (6, N'Chief Executive Officer', N'Bezos', N'Jeff', N'male', CAST(N'1964-01-12' AS Date), CAST(N'1994-07-05' AS Date), 3)
INSERT [dbo].[employee] ([employee_num], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date], [department_num]) VALUES (7, N'Super Secret Agent', N'Bond', N'James', N'male', CAST(N'1920-11-11' AS Date), CAST(N'2006-11-14' AS Date), 6)
INSERT [dbo].[employee] ([employee_num], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date], [department_num]) VALUES (8, N'World Peace Consultant', N'Artest', N'Ron', N'male', CAST(N'1979-11-13' AS Date), CAST(N'2018-01-06' AS Date), 6)
INSERT [dbo].[employee] ([employee_num], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date], [department_num]) VALUES (9, N'Important VP', N'Wig', N'Big', N'female', CAST(N'1968-03-20' AS Date), CAST(N'2002-09-23' AS Date), 3)
INSERT [dbo].[employee] ([employee_num], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date], [department_num]) VALUES (10, N'Customer Support Representative', N'Kathy', N'Chatty', N'female', CAST(N'1992-07-17' AS Date), CAST(N'2019-01-01' AS Date), 5)
INSERT [dbo].[employee] ([employee_num], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date], [department_num]) VALUES (11, N'Customer Support Representative', N'Kringle', N'Kris', N'male', CAST(N'0270-03-15' AS Date), CAST(N'1994-12-25' AS Date), 5)
INSERT [dbo].[employee] ([employee_num], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date], [department_num]) VALUES (12, N'Customer Support Manager', N'Zoolander', N'Derek', N'male', CAST(N'2001-09-28' AS Date), CAST(N'2016-02-12' AS Date), 5)
INSERT [dbo].[employee] ([employee_num], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date], [department_num]) VALUES (13, N'Investor Relations Coordinator', N'Burry', N'Michael', N'male', CAST(N'1971-06-19' AS Date), CAST(N'2015-12-11' AS Date), 4)
INSERT [dbo].[employee] ([employee_num], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date], [department_num]) VALUES (14, N'Sales Representative', N'Belfort', N'Jordan', N'male', CAST(N'1962-07-09' AS Date), CAST(N'2013-12-25' AS Date), 4)
INSERT [dbo].[employee] ([employee_num], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date], [department_num]) VALUES (15, N'Sales Representative', N'Montana', N'Tony', N'male', CAST(N'1989-12-09' AS Date), CAST(N'2008-11-25' AS Date), 4)
INSERT [dbo].[employee] ([employee_num], [job_title], [last_name], [first_name], [gender], [birthday], [hire_date], [department_num]) VALUES (16, N'Test Subject', N'Bourne', N'Jason', N'male', CAST(N'2002-06-14' AS Date), CAST(N'2016-06-29' AS Date), 6)
INSERT [dbo].[project] ([project_num], [name], [start_date]) VALUES (1, N'Company Initiation', CAST(N'1994-07-05' AS Date))
INSERT [dbo].[project] ([project_num], [name], [start_date]) VALUES (2, N'Secure Funding', CAST(N'2008-11-25' AS Date))
INSERT [dbo].[project] ([project_num], [name], [start_date]) VALUES (3, N'Build Website', CAST(N'2012-12-31' AS Date))
INSERT [dbo].[project] ([project_num], [name], [start_date]) VALUES (4, N'Classified', CAST(N'2019-02-14' AS Date))
INSERT [dbo].[project_employee] ([project_num], [employee_num]) VALUES (1, 6)
INSERT [dbo].[project_employee] ([project_num], [employee_num]) VALUES (2, 13)
INSERT [dbo].[project_employee] ([project_num], [employee_num]) VALUES (2, 14)
INSERT [dbo].[project_employee] ([project_num], [employee_num]) VALUES (2, 15)
INSERT [dbo].[project_employee] ([project_num], [employee_num]) VALUES (3, 1)
INSERT [dbo].[project_employee] ([project_num], [employee_num]) VALUES (3, 2)
INSERT [dbo].[project_employee] ([project_num], [employee_num]) VALUES (4, 7)
INSERT [dbo].[project_employee] ([project_num], [employee_num]) VALUES (4, 16)
ALTER TABLE [dbo].[employee]  WITH CHECK ADD  CONSTRAINT [FK_employee_department] FOREIGN KEY([department_num])
REFERENCES [dbo].[department] ([department_num])
GO
ALTER TABLE [dbo].[employee] CHECK CONSTRAINT [FK_employee_department]
GO
ALTER TABLE [dbo].[project_employee]  WITH CHECK ADD  CONSTRAINT [FK_project_employee_employee] FOREIGN KEY([employee_num])
REFERENCES [dbo].[employee] ([employee_num])
GO
ALTER TABLE [dbo].[project_employee] CHECK CONSTRAINT [FK_project_employee_employee]
GO
ALTER TABLE [dbo].[project_employee]  WITH CHECK ADD  CONSTRAINT [FK_project_employee_project] FOREIGN KEY([project_num])
REFERENCES [dbo].[project] ([project_num])
GO
ALTER TABLE [dbo].[project_employee] CHECK CONSTRAINT [FK_project_employee_project]
GO
USE [master]
GO
ALTER DATABASE [ProjectOrganizer] SET  READ_WRITE 
GO
