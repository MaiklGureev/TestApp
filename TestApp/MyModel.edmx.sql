
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/13/2019 15:37:03
-- Generated from EDMX file: C:\Users\Admiral\source\repos\TestApp\TestApp\MyModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TestDB];
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

-- Creating table 'SpecialtySet'
CREATE TABLE [dbo].[SpecialtySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Faculty_Id] int  NOT NULL
);
GO

-- Creating table 'StudentSet'
CREATE TABLE [dbo].[StudentSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Fio] nvarchar(max)  NOT NULL,
    [Adr] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NOT NULL,
    [Year] nvarchar(max)  NOT NULL,
    [Specialty_Id] int  NOT NULL
);
GO

-- Creating table 'FacultySet'
CREATE TABLE [dbo].[FacultySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'SpecialtySet'
ALTER TABLE [dbo].[SpecialtySet]
ADD CONSTRAINT [PK_SpecialtySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'StudentSet'
ALTER TABLE [dbo].[StudentSet]
ADD CONSTRAINT [PK_StudentSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'FacultySet'
ALTER TABLE [dbo].[FacultySet]
ADD CONSTRAINT [PK_FacultySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Specialty_Id] in table 'StudentSet'
ALTER TABLE [dbo].[StudentSet]
ADD CONSTRAINT [FK_SpecialtyStudent]
    FOREIGN KEY ([Specialty_Id])
    REFERENCES [dbo].[SpecialtySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SpecialtyStudent'
CREATE INDEX [IX_FK_SpecialtyStudent]
ON [dbo].[StudentSet]
    ([Specialty_Id]);
GO

-- Creating foreign key on [Faculty_Id] in table 'SpecialtySet'
ALTER TABLE [dbo].[SpecialtySet]
ADD CONSTRAINT [FK_FacultySpecialty]
    FOREIGN KEY ([Faculty_Id])
    REFERENCES [dbo].[FacultySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacultySpecialty'
CREATE INDEX [IX_FK_FacultySpecialty]
ON [dbo].[SpecialtySet]
    ([Faculty_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------