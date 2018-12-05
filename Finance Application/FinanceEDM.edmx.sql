
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/05/2018 13:23:01
-- Generated from EDMX file: C:\Users\yasirulakruwan\source\repos\Finance Application\Finance Application\FinanceEDM.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FinanceAppDatabase];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserDetailsPayerPayee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PayerPayees] DROP CONSTRAINT [FK_UserDetailsPayerPayee];
GO
IF OBJECT_ID(N'[dbo].[FK_TransactionPayerPayee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_TransactionPayerPayee];
GO
IF OBJECT_ID(N'[dbo].[FK_UserDetailsTransaction]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Transactions] DROP CONSTRAINT [FK_UserDetailsTransaction];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[UserDetails]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserDetails];
GO
IF OBJECT_ID(N'[dbo].[PayerPayees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PayerPayees];
GO
IF OBJECT_ID(N'[dbo].[Transactions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Transactions];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'UserDetails'
CREATE TABLE [dbo].[UserDetails] (
    [UserId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [DOB] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PayerPayees'
CREATE TABLE [dbo].[PayerPayees] (
    [PPId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [DOB] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL,
    [UserDetailsUserId] int  NOT NULL
);
GO

-- Creating table 'Transactions'
CREATE TABLE [dbo].[Transactions] (
    [TransactionId] int IDENTITY(1,1) NOT NULL,
    [Category] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Recuring] bit  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [TransactionType] nvarchar(max)  NOT NULL,
    [UserDetailsUserId] int  NOT NULL,
    [PayerPayee_PPId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [UserId] in table 'UserDetails'
ALTER TABLE [dbo].[UserDetails]
ADD CONSTRAINT [PK_UserDetails]
    PRIMARY KEY CLUSTERED ([UserId] ASC);
GO

-- Creating primary key on [PPId] in table 'PayerPayees'
ALTER TABLE [dbo].[PayerPayees]
ADD CONSTRAINT [PK_PayerPayees]
    PRIMARY KEY CLUSTERED ([PPId] ASC);
GO

-- Creating primary key on [TransactionId] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [PK_Transactions]
    PRIMARY KEY CLUSTERED ([TransactionId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UserDetailsUserId] in table 'PayerPayees'
ALTER TABLE [dbo].[PayerPayees]
ADD CONSTRAINT [FK_UserDetailsPayerPayee]
    FOREIGN KEY ([UserDetailsUserId])
    REFERENCES [dbo].[UserDetails]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserDetailsPayerPayee'
CREATE INDEX [IX_FK_UserDetailsPayerPayee]
ON [dbo].[PayerPayees]
    ([UserDetailsUserId]);
GO

-- Creating foreign key on [PayerPayee_PPId] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_TransactionPayerPayee]
    FOREIGN KEY ([PayerPayee_PPId])
    REFERENCES [dbo].[PayerPayees]
        ([PPId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransactionPayerPayee'
CREATE INDEX [IX_FK_TransactionPayerPayee]
ON [dbo].[Transactions]
    ([PayerPayee_PPId]);
GO

-- Creating foreign key on [UserDetailsUserId] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_UserDetailsTransaction]
    FOREIGN KEY ([UserDetailsUserId])
    REFERENCES [dbo].[UserDetails]
        ([UserId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UserDetailsTransaction'
CREATE INDEX [IX_FK_UserDetailsTransaction]
ON [dbo].[Transactions]
    ([UserDetailsUserId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------