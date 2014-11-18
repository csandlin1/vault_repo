USE [master]
GO
IF DB_ID (N'MobileTech') IS NOT NULL ALTER DATABASE [MobileTech] SET  SINGLE_USER WITH ROLLBACK IMMEDIATE
GO
IF DB_ID (N'MobileTech') IS NOT NULL DROP DATABASE MobileTech 
GO
CREATE DATABASE MobileTech ON ( NAME = MobileTech_dat,FILENAME = '{0}') LOG ON ( NAME = MobileTech_log, FILENAME = '{1}' )
GO