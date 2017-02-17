CREATE TABLE [dbo].[About] (
    [AboutId]        UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [LangTypeId]     UNIQUEIDENTIFIER NOT NULL,
    [DateTimeOpen]   DATETIME         NOT NULL,
    [DateTimeCreate] DATETIME         NOT NULL,
    [Body]           NVARCHAR (MAX)   NOT NULL,
    PRIMARY KEY CLUSTERED ([AboutId] ASC),
    CONSTRAINT [FK_LangType_About] FOREIGN KEY ([LangTypeId]) REFERENCES [dbo].[LangType] ([LangTypeId]) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE [dbo].[LangType] (
    [LangTypeId]   UNIQUEIDENTIFIER DEFAULT (newsequentialid()) NOT NULL,
    [LangTypeName] NVARCHAR (50)    NOT NULL,
    PRIMARY KEY CLUSTERED ([LangTypeId] ASC)
);

CREATE TABLE [dbo].[News] (
    [NewsId]         UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [LangTypeId]     UNIQUEIDENTIFIER NOT NULL,
    [DateTimeOpen]   DATETIME         NOT NULL,
    [DateTimeCreate] DATETIME         NOT NULL,
    [NewsTitle]      NVARCHAR (100)   NOT NULL,
    [NewsBody]       NVARCHAR (MAX)   NOT NULL,
    PRIMARY KEY CLUSTERED ([NewsId] ASC),
    CONSTRAINT [FK_LangType_News] FOREIGN KEY ([LangTypeId]) REFERENCES [dbo].[LangType] ([LangTypeId]) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE [dbo].[Post] (
    [PostId]         UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [LangTypeId]     UNIQUEIDENTIFIER NOT NULL,
    [DateTimeOpen]   DATETIME         NOT NULL,
    [DateTimeCreate] DATETIME         NOT NULL,
    [PostTitle]      NVARCHAR (100)   NOT NULL,
    [PostBody]       NVARCHAR (MAX)   NOT NULL,
    PRIMARY KEY CLUSTERED ([PostId] ASC),
    CONSTRAINT [FK_LangType_Post] FOREIGN KEY ([LangTypeId]) REFERENCES [dbo].[LangType] ([LangTypeId]) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE [dbo].[Vacancy] (
    [VacId]          UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [LangTypeId]     UNIQUEIDENTIFIER NOT NULL,
    [DateTimeOpen]   DATETIME         NOT NULL,
    [DateTimeCreate] DATETIME         NOT NULL,
    [VacancyName]    NVARCHAR (200)   NOT NULL,
    [Rank]           INT              NULL,
    [Comment]        NVARCHAR (250)   NULL,
    PRIMARY KEY CLUSTERED ([VacId] ASC),
    CONSTRAINT [FK_LangType_Vacancy] FOREIGN KEY ([LangTypeId]) REFERENCES [dbo].[LangType] ([LangTypeId]) ON DELETE CASCADE ON UPDATE CASCADE
);