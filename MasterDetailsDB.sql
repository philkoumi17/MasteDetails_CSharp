USE [master]
GO
/****** Object:  Database [MasterDetailsDB]    Script Date: 06/05/2018 01:05:30 ******/
CREATE DATABASE [MasterDetailsDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MasterDetailsDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\MasterDetailsDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MasterDetailsDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\MasterDetailsDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MasterDetailsDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MasterDetailsDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MasterDetailsDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MasterDetailsDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MasterDetailsDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MasterDetailsDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MasterDetailsDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MasterDetailsDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MasterDetailsDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MasterDetailsDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MasterDetailsDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MasterDetailsDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MasterDetailsDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MasterDetailsDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MasterDetailsDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MasterDetailsDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MasterDetailsDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MasterDetailsDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MasterDetailsDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MasterDetailsDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MasterDetailsDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MasterDetailsDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MasterDetailsDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MasterDetailsDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MasterDetailsDB] SET RECOVERY FULL 
GO
ALTER DATABASE [MasterDetailsDB] SET  MULTI_USER 
GO
ALTER DATABASE [MasterDetailsDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MasterDetailsDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MasterDetailsDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MasterDetailsDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MasterDetailsDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MasterDetailsDB', N'ON'
GO
ALTER DATABASE [MasterDetailsDB] SET QUERY_STORE = OFF
GO
USE [MasterDetailsDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
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
USE [MasterDetailsDB]
GO
/****** Object:  Table [dbo].[Employe]    Script Date: 06/05/2018 01:05:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employe](
	[EMP_ID] [int] IDENTITY(1,1) NOT NULL,
	[EMP_Code] [varchar](50) NULL,
	[EMP_Nom] [varchar](100) NULL,
	[EMP_POS_ID] [int] NULL,
	[EMP_DOB] [date] NULL,
	[EMP_Genre] [varchar](20) NULL,
	[EMP_EtatEmployé] [varchar](15) NULL,
	[EMP_ImagePath] [varchar](250) NULL,
 CONSTRAINT [PK_Employe] PRIMARY KEY CLUSTERED 
(
	[EMP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployéSociété]    Script Date: 06/05/2018 01:05:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployéSociété](
	[EMPSOC_ID] [int] IDENTITY(1,1) NOT NULL,
	[EMPSOC_EMP_ID] [int] NULL,
	[EMPSOC_Nom] [varchar](100) NULL,
	[EMPSOC_POS_ID] [int] NULL,
	[EMPSOC_AnneeExp] [int] NULL,
 CONSTRAINT [PK_EmployéSociété] PRIMARY KEY CLUSTERED 
(
	[EMPSOC_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Position]    Script Date: 06/05/2018 01:05:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Position](
	[POS_ID] [int] NOT NULL,
	[POS_Position] [varchar](50) NULL,
 CONSTRAINT [PK_Position] PRIMARY KEY CLUSTERED 
(
	[POS_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employe] ON 

INSERT [dbo].[Employe] ([EMP_ID], [EMP_Code], [EMP_Nom], [EMP_POS_ID], [EMP_DOB], [EMP_Genre], [EMP_EtatEmployé], [EMP_ImagePath]) VALUES (2, N'RA', N'Rony Abraham', 4, CAST(N'1991-12-21' AS Date), N'Masculin', N'Regulier', N'rony_abraham18580141.png')
SET IDENTITY_INSERT [dbo].[Employe] OFF
SET IDENTITY_INSERT [dbo].[EmployéSociété] ON 

INSERT [dbo].[EmployéSociété] ([EMPSOC_ID], [EMPSOC_EMP_ID], [EMPSOC_Nom], [EMPSOC_POS_ID], [EMPSOC_AnneeExp]) VALUES (2, 1, N'BCD', 4, 2)
INSERT [dbo].[EmployéSociété] ([EMPSOC_ID], [EMPSOC_EMP_ID], [EMPSOC_Nom], [EMPSOC_POS_ID], [EMPSOC_AnneeExp]) VALUES (1002, 1, N'EFG', 4, 4)
INSERT [dbo].[EmployéSociété] ([EMPSOC_ID], [EMPSOC_EMP_ID], [EMPSOC_Nom], [EMPSOC_POS_ID], [EMPSOC_AnneeExp]) VALUES (1003, 2, N'ABC', 4, 3)
INSERT [dbo].[EmployéSociété] ([EMPSOC_ID], [EMPSOC_EMP_ID], [EMPSOC_Nom], [EMPSOC_POS_ID], [EMPSOC_AnneeExp]) VALUES (1004, 3, N'ABC', 2, 2)
INSERT [dbo].[EmployéSociété] ([EMPSOC_ID], [EMPSOC_EMP_ID], [EMPSOC_Nom], [EMPSOC_POS_ID], [EMPSOC_AnneeExp]) VALUES (1005, 3, N'BCD', 4, 2)
INSERT [dbo].[EmployéSociété] ([EMPSOC_ID], [EMPSOC_EMP_ID], [EMPSOC_Nom], [EMPSOC_POS_ID], [EMPSOC_AnneeExp]) VALUES (1006, 3, N'EFG', 4, 3)
SET IDENTITY_INSERT [dbo].[EmployéSociété] OFF
INSERT [dbo].[Position] ([POS_ID], [POS_Position]) VALUES (1, N'Comptable')
INSERT [dbo].[Position] ([POS_ID], [POS_Position]) VALUES (2, N'Développeur d''applications')
INSERT [dbo].[Position] ([POS_ID], [POS_Position]) VALUES (3, N'Assistant des ventes')
INSERT [dbo].[Position] ([POS_ID], [POS_Position]) VALUES (4, N'Administrateur des systèmes')
INSERT [dbo].[Position] ([POS_ID], [POS_Position]) VALUES (5, N'Chef de projet')
/****** Object:  StoredProcedure [dbo].[AddOrEditEmployé]    Script Date: 06/05/2018 01:05:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddOrEditEmployé]
    @EMP_ID INT,
    @EMP_Code VARCHAR(50),
    @EMP_Nom VARCHAR(100),
    @EMP_POS_ID INT,
    @EMP_DOB DATE,
    @EMP_Genre VARCHAR(20),
    @EMP_EtatEmployé VARCHAR(15),
    @EMP_ImagePath VARCHAR(250)
AS

-- Insertion un employé
IF (@EMP_ID = 0)
BEGIN
    INSERT INTO Employe
    (
        EMP_Code,
        EMP_Nom,
        EMP_POS_ID,
        EMP_DOB,
        EMP_Genre,
        EMP_EtatEmployé,
        EMP_ImagePath
    )
    VALUES
    (@EMP_Code, @EMP_Nom, @EMP_POS_ID, @EMP_DOB, @EMP_Genre, @EMP_EtatEmployé, @EMP_ImagePath);

    SELECT SCOPE_IDENTITY();

END;

-- Mise à jour des données de l'employé
ELSE
BEGIN
    UPDATE Employe
    SET EMP_Code = @EMP_Code,
        EMP_Nom = @EMP_Nom,
        EMP_POS_ID = @EMP_POS_ID,
        EMP_DOB = @EMP_DOB,
        EMP_Genre = @EMP_Genre,
        EMP_EtatEmployé = @EMP_EtatEmployé,
        EMP_ImagePath = @EMP_ImagePath
    WHERE EMP_ID = @EMP_ID;

    SELECT @EMP_ID;

END;
GO
/****** Object:  StoredProcedure [dbo].[AddOrEditEmployéSociété]    Script Date: 06/05/2018 01:05:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddOrEditEmployéSociété]
    @EMPSOC_ID INT,
    @EMPSOC_EMP_ID INT,
    @EMPSOC_Nom VARCHAR(100),
    @EMPSOC_POS_ID INT,
    @EMPSOC_AnneeExp INT
AS

-- Insertion un employé d'une société
IF (@EMPSOC_ID = 0)
BEGIN
    INSERT INTO EmployéSociété
    (
        EMPSOC_EMP_ID,
        EMPSOC_Nom,
        EMPSOC_POS_ID,
        EMPSOC_AnneeExp
    )
    VALUES
    (@EMPSOC_EMP_ID, @EMPSOC_Nom, @EMPSOC_POS_ID, @EMPSOC_AnneeExp);

END;

-- Mise à jour des données de l'employé de la société
ELSE
BEGIN
    UPDATE EmployéSociété
    SET EMPSOC_EMP_ID = @EMPSOC_EMP_ID,
        EMPSOC_Nom = @EMPSOC_Nom,
        EMPSOC_POS_ID = @EMPSOC_POS_ID,
        EMPSOC_AnneeExp = @EMPSOC_AnneeExp
    WHERE EMPSOC_ID = @EMPSOC_ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[EmployéDelete]    Script Date: 06/05/2018 01:05:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EmployéDelete] 
	@EMP_ID INT
AS
BEGIN
    -- Master --
    DELETE FROM Employe
    WHERE EMP_ID = @EMP_ID;

    -- Détails --
    DELETE FROM EmployéSociété
    WHERE EMPSOC_ID = @EMP_ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[EmployéSociétéDelete]    Script Date: 06/05/2018 01:05:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EmployéSociétéDelete] 
	@EMPSOC_ID INT
AS
BEGIN
    DELETE FROM EmployéSociété
    WHERE EMPSOC_ID = @EMPSOC_ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[EmployéViewByID]    Script Date: 06/05/2018 01:05:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EmployéViewByID] @EMP_ID INT
AS
BEGIN
    -- Master --
    SELECT *
    FROM Employe
    WHERE EMP_ID = @EMP_ID;

    -- Détails --
    SELECT *
    FROM EmployéSociété
    WHERE EMPSOC_EMP_ID = @EMP_ID;
END;
GO
/****** Object:  StoredProcedure [dbo].[SelectEmployéViewAll]    Script Date: 06/05/2018 01:05:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectEmployéViewAll]
AS
BEGIN
    SELECT E.EMP_ID,
           E.EMP_Code,
           E.EMP_Nom,
           P.POS_Position,
           E.EMP_DOB,
           E.EMP_EtatEmployé
    FROM Employe E
    INNER JOIN Position P
    ON E.EMP_POS_ID = P.POS_ID;
END;
GO
USE [master]
GO
ALTER DATABASE [MasterDetailsDB] SET  READ_WRITE 
GO
