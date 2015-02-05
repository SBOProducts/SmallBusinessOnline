/****** Object:  Table [dbo].[DemoRegistration]    Script Date: 12/28/2014 11:08:31 AM ******/
SET ANSI_NULLS ON
SET QUOTED_IDENTIFIER ON
CREATE TABLE [dbo].[DemoRegistration](
	[DemoRegistrationId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Name] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Email] [varchar](150) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Phone] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Submitted] [datetime] NOT NULL,
	[Code] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_DemoRegistration] PRIMARY KEY CLUSTERED 
(
	[DemoRegistrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

