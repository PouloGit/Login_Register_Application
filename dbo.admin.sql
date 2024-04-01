CREATE TABLE [dbo].[admin] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [username]      VARCHAR (MAX) NULL,
    [password_hash] VARCHAR (MAX) NULL,
    [date_created]  DATE          NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

