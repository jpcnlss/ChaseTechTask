CREATE TABLE [dbo].[Student] (
    [ID]      INT          NOT NULL,
    [Name]    VARCHAR (50) NULL,
    [College] VARCHAR (50) NULL,
    [Course]  VARCHAR (50) NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([ID] ASC)
);

