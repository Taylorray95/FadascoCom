USE [Defaultdb]
GO

/****** Object: Table [dbo].[Users] Script Date: 10/21/2022 10:56:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Users];


GO
CREATE TABLE [dbo].[Users] (
    [userId]                             INT           IDENTITY (1, 1) NOT NULL,
    [email]                              VARCHAR (200) NULL,
    [firstName]                          VARCHAR (50)  NULL,
    [middleInitial]                      VARCHAR (25)  NULL,
    [lastName]                           VARCHAR (50)  NULL,
    [recoveryEmail]                      VARCHAR (100) NULL,
    [twoFactorAuthenticationEnabledFlag] INT           NULL,
    [subscriptionId]                     INT           NULL,
    [recoveryQuestionId]                 INT           NULL,
    [recoveryAnswer]                     VARCHAR (100) NULL,
    [recoveryEmailSetFlag]               INT           NULL,
    [passwordHash]                       VARCHAR (50)  NULL,
    [passwordSaltId]                     INT           NULL,
    [phoneNumber]                        VARCHAR (25)  NULL,
    [sysDate]                            DATETIME      NULL,
	[lastLogin]                            DATETIME      NULL,
    [bannedId]                           INT           NULL,
    [accountActiveFlag]                  VARCHAR (50)  NULL,
    [userPath]                           VARCHAR (50)  NULL,
    [userImage]                          VARCHAR (MAX) NULL,
    [storeLogoImage]                     VARCHAR (MAX) NULL,
    [storeBannerImage]                   VARCHAR (MAX) NULL
);


