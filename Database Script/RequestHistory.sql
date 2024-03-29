USE [GoogleTimeZoneDB]
GO
/****** Object:  Table [dbo].[RequestHistory]    Script Date: 3/03/2021 11:34:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RequestHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RequestLocation] [varchar](250) NULL,
	[RequestTimeStamp] [varchar](250) NULL,
	[ResponseDstOffset] [int] NULL,
	[ResponseRawOffset] [int] NULL,
	[ResponseStatus] [varchar](250) NULL,
	[ResponseTimeZoneId] [varchar](250) NULL,
	[ResponseTimeZoneName] [varchar](250) NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_TimeZoneApiAudit] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
