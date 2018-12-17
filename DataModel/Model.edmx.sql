
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/16/2018 14:50:05
-- Generated from EDMX file: D:\University\3 course\epam\4\Task4\DataModel\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [saledb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ClientSet'
CREATE TABLE [dbo].[ClientSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ManagerSet'
CREATE TABLE [dbo].[ManagerSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProductSet'
CREATE TABLE [dbo].[ProductSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'SaleSet'
CREATE TABLE [dbo].[SaleSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ClientId] int  NOT NULL,
    [ManagerId] int  NOT NULL,
    [ProductId] int  NOT NULL,
    [Date] nvarchar(max)  NOT NULL,
    [Quantity] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ClientSet'
ALTER TABLE [dbo].[ClientSet]
ADD CONSTRAINT [PK_ClientSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ManagerSet'
ALTER TABLE [dbo].[ManagerSet]
ADD CONSTRAINT [PK_ManagerSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProductSet'
ALTER TABLE [dbo].[ProductSet]
ADD CONSTRAINT [PK_ProductSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SaleSet'
ALTER TABLE [dbo].[SaleSet]
ADD CONSTRAINT [PK_SaleSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClientId] in table 'SaleSet'
ALTER TABLE [dbo].[SaleSet]
ADD CONSTRAINT [FK_ClientSale]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[ClientSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientSale'
CREATE INDEX [IX_FK_ClientSale]
ON [dbo].[SaleSet]
    ([ClientId]);
GO

-- Creating foreign key on [ManagerId] in table 'SaleSet'
ALTER TABLE [dbo].[SaleSet]
ADD CONSTRAINT [FK_ManagerSale]
    FOREIGN KEY ([ManagerId])
    REFERENCES [dbo].[ManagerSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ManagerSale'
CREATE INDEX [IX_FK_ManagerSale]
ON [dbo].[SaleSet]
    ([ManagerId]);
GO

-- Creating foreign key on [ProductId] in table 'SaleSet'
ALTER TABLE [dbo].[SaleSet]
ADD CONSTRAINT [FK_ProductSale]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[ProductSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductSale'
CREATE INDEX [IX_FK_ProductSale]
ON [dbo].[SaleSet]
    ([ProductId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------