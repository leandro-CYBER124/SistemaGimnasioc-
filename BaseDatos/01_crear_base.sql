-- =====================================================================
-- Gym Control (SQL Server) - 01: crear la base de datos
-- Ejecutar en SQL Server Management Studio (SSMS) con F5.
-- =====================================================================
USE master;
GO

IF DB_ID(N'bd_gimnasio') IS NULL
    CREATE DATABASE bd_gimnasio;
GO
