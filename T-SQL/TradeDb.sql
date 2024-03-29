USE [master]
GO
/****** Object:  Database [TradeDb]    Script Date: 2/27/2024 14:06:02 AM ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'TradeDb')
BEGIN
CREATE DATABASE [TradeDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TradeDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\TradeDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TradeDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\TradeDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
END
GO
ALTER DATABASE [TradeDb] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TradeDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TradeDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TradeDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TradeDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TradeDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TradeDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [TradeDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TradeDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TradeDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TradeDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TradeDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TradeDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TradeDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TradeDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TradeDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TradeDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TradeDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TradeDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TradeDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TradeDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TradeDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TradeDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TradeDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TradeDb] SET RECOVERY FULL 
GO
ALTER DATABASE [TradeDb] SET  MULTI_USER 
GO
ALTER DATABASE [TradeDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TradeDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TradeDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TradeDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TradeDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TradeDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TradeDb', N'ON'
GO
ALTER DATABASE [TradeDb] SET QUERY_STORE = ON
GO
ALTER DATABASE [TradeDb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TradeDb]
GO
/****** Object:  Table [dbo].[TableClientSectorRules]    Script Date: 2/27/2024 14:06:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TableClientSectorRules]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TableClientSectorRules](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[sector] [varchar](20) NOT NULL,
	[category] [varchar](20) NOT NULL,
	[min_value] [float] NOT NULL,
	[max_value] [float] NOT NULL,
 CONSTRAINT [PK_TableClientSectorRules] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[TableTrade]    Script Date: 2/27/2024 14:06:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TableTrade]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[TableTrade](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[value] [float] NOT NULL,
	[client_sector] [varchar](10) NOT NULL,
 CONSTRAINT [PK_TableTrade] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[TableClientSectorRules] ON 

INSERT [dbo].[TableClientSectorRules] ([id], [sector], [category], [min_value], [max_value]) VALUES (1, N'Private', N'UNKNOWN', 0, 1000000)
INSERT [dbo].[TableClientSectorRules] ([id], [sector], [category], [min_value], [max_value]) VALUES (2, N'Public', N'LOWRISK', 0, 1000000)
INSERT [dbo].[TableClientSectorRules] ([id], [sector], [category], [min_value], [max_value]) VALUES (3, N'Public', N'MEDIUMRISK', 1000000, 99000000)
INSERT [dbo].[TableClientSectorRules] ([id], [sector], [category], [min_value], [max_value]) VALUES (4, N'Private', N'HIGHRISK', 1000000, 99000000)
SET IDENTITY_INSERT [dbo].[TableClientSectorRules] OFF
GO
SET IDENTITY_INSERT [dbo].[TableTrade] ON 

INSERT [dbo].[TableTrade] ([id], [value], [client_sector]) VALUES (1, 1316874, N'Private')
INSERT [dbo].[TableTrade] ([id], [value], [client_sector]) VALUES (2, 1863327, N'Private')
INSERT [dbo].[TableTrade] ([id], [value], [client_sector]) VALUES (3, 564153, N'Public')
INSERT [dbo].[TableTrade] ([id], [value], [client_sector]) VALUES (4, 1558368, N'Private')
INSERT [dbo].[TableTrade] ([id], [value], [client_sector]) VALUES (5, 999962, N'Public')
INSERT [dbo].[TableTrade] ([id], [value], [client_sector]) VALUES (6, 1267363, N'Public')
INSERT [dbo].[TableTrade] ([id], [value], [client_sector]) VALUES (7, 1498078, N'Public')
INSERT [dbo].[TableTrade] ([id], [value], [client_sector]) VALUES (8, 275010, N'Public')
INSERT [dbo].[TableTrade] ([id], [value], [client_sector]) VALUES (9, 1489429, N'Public')
INSERT [dbo].[TableTrade] ([id], [value], [client_sector]) VALUES (10, 1649005, N'Public')
INSERT [dbo].[TableTrade] ([id], [value], [client_sector]) VALUES (11, 634076, N'Public')
INSERT [dbo].[TableTrade] ([id], [value], [client_sector]) VALUES (12, 1666992, N'Public')
INSERT [dbo].[TableTrade] ([id], [value], [client_sector]) VALUES (13, 1663931, N'Public')
INSERT [dbo].[TableTrade] ([id], [value], [client_sector]) VALUES (14, 669976, N'Private')
INSERT [dbo].[TableTrade] ([id], [value], [client_sector]) VALUES (15, 1189832, N'Public')
SET IDENTITY_INSERT [dbo].[TableTrade] OFF
GO
/****** Object:  StoredProcedure [dbo].[sp_add_sector_rule]    Script Date: 2/27/2024 14:06:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_add_sector_rule]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_add_sector_rule] AS' 
END
GO



-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_add_sector_rule]
	-- Add the parameters for the stored procedure here
	@sector VARCHAR(20),
	@category VARCHAR(20),
	@minValue FLOAT,
	@maxValue FLOAT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF NOT EXISTS (
		SELECT [id] 
		FROM [TradeDb].[dbo].[TableClientSectorRules] 
		WHERE [sector] = @sector AND [category] = @category AND [min_value] = @minValue AND [max_value] = @maxValue
	)
	BEGIN
		INSERT INTO [TradeDb].[dbo].[TableClientSectorRules] 
		([sector], [category], [min_value], [max_value]) 
		VALUES 
		(@sector, @category, @minValue, @maxValue);
	END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_delete_sector_rule]    Script Date: 2/27/2024 14:06:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_delete_sector_rule]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_delete_sector_rule] AS' 
END
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_delete_sector_rule]
	-- Add the parameters for the stored procedure here
	@id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS (SELECT [id] FROM [TradeDb].[dbo].[TableClientSectorRules] WHERE [id] = @id)
	BEGIN
		DELETE [TradeDb].[dbo].[TableClientSectorRules] WHERE [id] = @id;
	END
END
GO
/****** Object:  StoredProcedure [dbo].[sp_import_json_trade]    Script Date: 2/27/2024 14:06:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_import_json_trade]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_import_json_trade] AS' 
END
GO






-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_import_json_trade]
	-- Add the parameters for the stored procedure here
	@Json nvarchar(max)
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here-
	DECLARE @StrJson nvarchar(max);
	SET @StrJson = N'''' + @Json + '''';

	DECLARE @str NVARCHAR(MAX);
	SET @str = N'
		INSERT [TableTrade] (value, client_sector)
		SELECT value, client_sector
		FROM OPENJSON(' + @StrJson + ')
		WITH (
			value FLOAT ''$.Value'',
			client_sector VARCHAR(10) ''$.ClientSector''
		)';
	EXEC (@str)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sector_rule_process]    Script Date: 2/27/2024 14:06:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sector_rule_process]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_sector_rule_process] AS' 
END
GO





-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_sector_rule_process]
	-- Add the parameters for the stored procedure here
	@ReturnAsJson BIT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF (@ReturnAsJson = 0)
	BEGIN
		SELECT [tt].[id], [tcsr].[category]
		FROM [TradeDb].[dbo].[TableClientSectorRules] as tcsr 
		LEFT OUTER JOIN [TradeDb].[dbo].[TableTrade] as tt ON [tt].[client_sector] = [tcsr].[sector] 
		WHERE [tt].[value] BETWEEN [tcsr].[min_value] AND [tcsr].[max_value]
		ORDER BY [tt].[id]
	END
	ELSE
	BEGIN
		SELECT [tcsr].[category]
		FROM [TradeDb].[dbo].[TableClientSectorRules] as tcsr 
		LEFT OUTER JOIN [TradeDb].[dbo].[TableTrade] as tt ON [tt].[client_sector] = [tcsr].[sector] 
		WHERE [tt].[value] BETWEEN [tcsr].[min_value] AND [tcsr].[max_value]
		ORDER BY [tt].[id]
		FOR JSON AUTO
	END
	
END
GO
/****** Object:  StoredProcedure [dbo].[sp_update_sector_rule]    Script Date: 2/27/2024 14:06:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_update_sector_rule]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[sp_update_sector_rule] AS' 
END
GO





-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_update_sector_rule]
	-- Add the parameters for the stored procedure here
	@id INT,
	@sector VARCHAR(20),
	@category VARCHAR(20),
	@minvalue FLOAT,
	@maxvalue FLOAT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS (SELECT [id] FROM [TradeDb].[dbo].[TableClientSectorRules] WHERE [id] = @id)
	BEGIN
		UPDATE [TradeDb].[dbo].[TableClientSectorRules] 
		SET [sector] = @sector, 
			[category] = @category,  
			[min_value] = @minvalue, 
			[max_value] = @maxvalue
		WHERE [id] = @id;
	END
END
GO
USE [master]
GO
ALTER DATABASE [TradeDb] SET  READ_WRITE 
GO
