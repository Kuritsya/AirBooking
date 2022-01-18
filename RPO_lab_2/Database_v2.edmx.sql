
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/18/2022 15:42:24
-- Generated from EDMX file: C:\Ne kasaisya\Ne trogai\Введение в РПО\RPO_lab_2\RPO_lab_2\Database_v2.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [air_booking];
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

-- Creating table 'planesSet'
CREATE TABLE [dbo].[planesSet] (
    [idPlane] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL,
    [numberOfSeats] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'airportsSet'
CREATE TABLE [dbo].[airportsSet] (
    [idAirports] int IDENTITY(1,1) NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'usersSet'
CREATE TABLE [dbo].[usersSet] (
    [idUser] int IDENTITY(1,1) NOT NULL,
    [FIO] nvarchar(max)  NOT NULL,
    [birthday] nvarchar(max)  NOT NULL,
    [seriaPasport] nvarchar(max)  NOT NULL,
    [numberPasport] nvarchar(max)  NOT NULL,
    [login] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'flightSet'
CREATE TABLE [dbo].[flightSet] (
    [idFlight] int IDENTITY(1,1) NOT NULL,
    [numebr] nvarchar(max)  NOT NULL,
    [departureTime] nvarchar(max)  NOT NULL,
    [arrivalTime] nvarchar(max)  NOT NULL,
    [idAirport_idAirports] int  NOT NULL,
    [idPlane_idPlane] int  NOT NULL
);
GO

-- Creating table 'ticketsSet'
CREATE TABLE [dbo].[ticketsSet] (
    [idTicket] int IDENTITY(1,1) NOT NULL,
    [number] nvarchar(max)  NOT NULL,
    [seat] nvarchar(max)  NOT NULL,
    [price] nvarchar(max)  NOT NULL,
    [idFlight_idFlight] int  NOT NULL,
    [idUser_idUser] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [idPlane] in table 'planesSet'
ALTER TABLE [dbo].[planesSet]
ADD CONSTRAINT [PK_planesSet]
    PRIMARY KEY CLUSTERED ([idPlane] ASC);
GO

-- Creating primary key on [idAirports] in table 'airportsSet'
ALTER TABLE [dbo].[airportsSet]
ADD CONSTRAINT [PK_airportsSet]
    PRIMARY KEY CLUSTERED ([idAirports] ASC);
GO

-- Creating primary key on [idUser] in table 'usersSet'
ALTER TABLE [dbo].[usersSet]
ADD CONSTRAINT [PK_usersSet]
    PRIMARY KEY CLUSTERED ([idUser] ASC);
GO

-- Creating primary key on [idFlight] in table 'flightSet'
ALTER TABLE [dbo].[flightSet]
ADD CONSTRAINT [PK_flightSet]
    PRIMARY KEY CLUSTERED ([idFlight] ASC);
GO

-- Creating primary key on [idTicket] in table 'ticketsSet'
ALTER TABLE [dbo].[ticketsSet]
ADD CONSTRAINT [PK_ticketsSet]
    PRIMARY KEY CLUSTERED ([idTicket] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [idFlight_idFlight] in table 'ticketsSet'
ALTER TABLE [dbo].[ticketsSet]
ADD CONSTRAINT [FK_ticketsflight]
    FOREIGN KEY ([idFlight_idFlight])
    REFERENCES [dbo].[flightSet]
        ([idFlight])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ticketsflight'
CREATE INDEX [IX_FK_ticketsflight]
ON [dbo].[ticketsSet]
    ([idFlight_idFlight]);
GO

-- Creating foreign key on [idAirport_idAirports] in table 'flightSet'
ALTER TABLE [dbo].[flightSet]
ADD CONSTRAINT [FK_flightairports]
    FOREIGN KEY ([idAirport_idAirports])
    REFERENCES [dbo].[airportsSet]
        ([idAirports])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_flightairports'
CREATE INDEX [IX_FK_flightairports]
ON [dbo].[flightSet]
    ([idAirport_idAirports]);
GO

-- Creating foreign key on [idPlane_idPlane] in table 'flightSet'
ALTER TABLE [dbo].[flightSet]
ADD CONSTRAINT [FK_flightplanes]
    FOREIGN KEY ([idPlane_idPlane])
    REFERENCES [dbo].[planesSet]
        ([idPlane])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_flightplanes'
CREATE INDEX [IX_FK_flightplanes]
ON [dbo].[flightSet]
    ([idPlane_idPlane]);
GO

-- Creating foreign key on [idUser_idUser] in table 'ticketsSet'
ALTER TABLE [dbo].[ticketsSet]
ADD CONSTRAINT [FK_ticketsusers]
    FOREIGN KEY ([idUser_idUser])
    REFERENCES [dbo].[usersSet]
        ([idUser])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ticketsusers'
CREATE INDEX [IX_FK_ticketsusers]
ON [dbo].[ticketsSet]
    ([idUser_idUser]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------