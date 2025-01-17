USE [FlySusData]
GO
/****** Object:  Table [dbo].[AdminlFlightInformations]    Script Date: 12.11.2020 13:45:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminlFlightInformations](
	[flightsId] [int] IDENTITY(1,1) NOT NULL,
	[departureAırport] [nvarchar](max) NULL,
	[landingAırport] [nvarchar](max) NULL,
	[departureTıme] [date] NULL,
	[returnTıme] [date] NULL,
	[Company] [nchar](20) NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_dbo.AdminlFlightInformations] PRIMARY KEY CLUSTERED 
(
	[flightsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[emptyseats]    Script Date: 12.11.2020 13:45:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emptyseats](
	[Emptyseats] [int] NOT NULL,
 CONSTRAINT [PK_emptyseats_1] PRIMARY KEY CLUSTERED 
(
	[Emptyseats] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Flights]    Script Date: 12.11.2020 13:45:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Flights](
	[PnrCode] [nvarchar](15) NOT NULL,
	[Departure] [nvarchar](max) NULL,
	[arrival] [nvarchar](max) NULL,
	[goingTime] [datetime] NOT NULL,
	[returnTime] [datetime] NOT NULL,
	[adultTicket] [nvarchar](3) NULL,
	[studentTicket] [nvarchar](3) NULL,
	[armchair] [nvarchar](3) NULL,
	[ticketPrice] [int] NOT NULL,
	[rezTime] [datetime] NULL,
	[status] [nvarchar](50) NULL,
 CONSTRAINT [PK_Flights_1] PRIMARY KEY CLUSTERED 
(
	[PnrCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OperationsManagers]    Script Date: 12.11.2020 13:45:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperationsManagers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OperationsmanagerEposta] [nvarchar](max) NULL,
	[OperationsManagerSıfre] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.OperationsManagers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[passangerInformations]    Script Date: 12.11.2020 13:45:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[passangerInformations](
	[passengerTc] [nvarchar](12) NOT NULL,
	[PassangerCode] [int] NOT NULL,
	[passengerName] [nvarchar](50) NULL,
	[passengerSurname] [nvarchar](50) NULL,
	[passengerTelNo] [nvarchar](15) NULL,
	[passengerAddress] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.PassengerInformations] PRIMARY KEY CLUSTERED 
(
	[passengerTc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Salespersons]    Script Date: 12.11.2020 13:45:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salespersons](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SalepersonEposta] [nvarchar](max) NULL,
	[SalespersonSıfre] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Salespersons] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
