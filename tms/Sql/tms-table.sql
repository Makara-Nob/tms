USE [tms]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/24/2025 11:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bookings]    Script Date: 6/24/2025 11:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bookings](
	[BookingID] [int] IDENTITY(1,1) NOT NULL,
	[BookingDate] [datetime2](7) NOT NULL,
	[SeatNumber] [int] NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
	[StaffID] [nvarchar](450) NOT NULL,
	[TripID] [nvarchar](20) NOT NULL,
	[PassengerContact] [nvarchar](20) NULL,
	[Gender] [nvarchar](10) NULL,
 CONSTRAINT [PK_Bookings] PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deliveries]    Script Date: 6/24/2025 11:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deliveries](
	[DeliveryId] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NOT NULL,
	[DeliveryDate] [datetime2](7) NOT NULL,
	[DeliveryStatus] [nvarchar](max) NULL,
 CONSTRAINT [PK_Deliveries] PRIMARY KEY CLUSTERED 
(
	[DeliveryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 6/24/2025 11:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [varchar](20) NOT NULL,
	[Sender] [varchar](20) NOT NULL,
	[Reciever] [varchar](20) NOT NULL,
	[OrderType] [varchar](50) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
	[DeliveryId] [int] NULL,
	[DeliveryStatus] [varchar](20) NULL,
	[TotalAmount] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Passengers]    Script Date: 6/24/2025 11:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Passengers](
	[PassengerID] [nvarchar](450) NOT NULL,
	[PassengerName] [nvarchar](max) NOT NULL,
	[Gender] [nvarchar](max) NOT NULL,
	[PersonalNumber] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[IsActive] [int] NOT NULL,
 CONSTRAINT [PK_Passengers] PRIMARY KEY CLUSTERED 
(
	[PassengerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Routes]    Script Date: 6/24/2025 11:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Routes](
	[RouteID] [nvarchar](450) NOT NULL,
	[StartPoint] [nvarchar](max) NOT NULL,
	[EndPoint] [nvarchar](max) NOT NULL,
	[DistanceKm] [decimal](10, 2) NULL,
	[EstimatedTimeMinutes] [int] NULL,
	[VehicleAssigned] [nvarchar](max) NOT NULL,
	[Priority] [nvarchar](max) NOT NULL,
	[AvoidTolls] [bit] NOT NULL,
	[EnableWeatherAlerts] [bit] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Routes] PRIMARY KEY CLUSTERED 
(
	[RouteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SeatExclusions]    Script Date: 6/24/2025 11:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SeatExclusions](
	[ExclusionId] [int] IDENTITY(1,1) NOT NULL,
	[VehicleId] [nvarchar](450) NOT NULL,
	[RowNumber] [int] NOT NULL,
	[SeatPosition] [int] NULL,
	[Reason] [nvarchar](100) NULL,
	[IsTemporary] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ExclusionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seats]    Script Date: 6/24/2025 11:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seats](
	[SeatId] [int] IDENTITY(1,1) NOT NULL,
	[VehicleID] [nvarchar](450) NULL,
	[SeatNumber] [nvarchar](max) NULL,
	[SeatType] [nvarchar](max) NULL,
	[seatStatus] [nvarchar](max) NULL,
	[RowNumber] [int] NOT NULL,
	[SeatPosition] [int] NOT NULL,
	[SeatLetter] [char](1) NOT NULL,
	[Price] [decimal](10, 2) NULL,
	[IsWindowSeat] [bit] NULL,
	[IsAisleSeat] [bit] NULL,
	[SeatFeatures] [nvarchar](200) NULL,
	[LastUpdated] [datetime2](7) NULL,
	[UpdatedBy] [nvarchar](100) NULL,
 CONSTRAINT [PK_Seats] PRIMARY KEY CLUSTERED 
(
	[SeatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SeatTypeConfiguration]    Script Date: 6/24/2025 11:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SeatTypeConfiguration](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VehicleId] [nvarchar](450) NOT NULL,
	[SeatType] [nvarchar](50) NOT NULL,
	[FromRow] [int] NOT NULL,
	[ToRow] [int] NOT NULL,
	[BasePrice] [decimal](10, 2) NOT NULL,
	[IsActive] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staffs]    Script Date: 6/24/2025 11:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staffs](
	[StaffId] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Gender] [nvarchar](max) NOT NULL,
	[BirthDate] [datetime2](7) NOT NULL,
	[Photo] [varbinary](max) NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Personal_PhoneNumber] [nvarchar](max) NOT NULL,
	[Contact_PhoneNumber] [nvarchar](max) NOT NULL,
	[position] [nvarchar](max) NOT NULL,
	[Hired_Date] [datetime2](7) NOT NULL,
	[Salary] [decimal](12, 2) NOT NULL,
	[IsStopWorking] [bit] NOT NULL,
 CONSTRAINT [PK_Staffs] PRIMARY KEY CLUSTERED 
(
	[StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tickets]    Script Date: 6/24/2025 11:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tickets](
	[TicketID] [nvarchar](50) NOT NULL,
	[SupplierID] [nvarchar](50) NOT NULL,
	[SupplierName] [nvarchar](200) NOT NULL,
	[SupplierDate] [datetime2](7) NOT NULL,
	[CustomerPosition] [nvarchar](200) NOT NULL,
	[CustomerAddress] [nvarchar](500) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Tickets] PRIMARY KEY CLUSTERED 
(
	[TicketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Trips]    Script Date: 6/24/2025 11:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trips](
	[TripID] [nvarchar](20) NOT NULL,
	[VehicleID] [nvarchar](450) NULL,
	[DriverID] [nvarchar](450) NULL,
	[RouteID] [nvarchar](450) NULL,
	[DepatureTime] [datetime2](7) NOT NULL,
	[status] [nvarchar](max) NULL,
 CONSTRAINT [PK_Trips] PRIMARY KEY CLUSTERED 
(
	[TripID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VehicleConfigurations]    Script Date: 6/24/2025 11:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VehicleConfigurations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[VehicleId] [nvarchar](450) NOT NULL,
	[VehicleName] [nvarchar](100) NOT NULL,
	[VehicleType] [nvarchar](50) NOT NULL,
	[TotalRows] [int] NOT NULL,
	[SeatsPerRow] [int] NOT NULL,
	[SeatLayout] [nvarchar](20) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[AislePositionsString] [nvarchar](100) NULL,
	[HasUpperDeck] [bit] NOT NULL,
	[LastModified] [datetime2](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicles]    Script Date: 6/24/2025 11:00:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicles](
	[VehicleID] [nvarchar](450) NOT NULL,
	[Type] [nvarchar](max) NOT NULL,
	[Capacity] [int] NULL,
	[LicensePlate] [nvarchar](max) NOT NULL,
	[RouteID] [nvarchar](450) NOT NULL,
	[Status] [nvarchar](max) NOT NULL,
	[MaintenanceDate] [datetime2](7) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Vehicles] PRIMARY KEY CLUSTERED 
(
	[VehicleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[SeatExclusions] ADD  DEFAULT ((0)) FOR [IsTemporary]
GO
ALTER TABLE [dbo].[Seats] ADD  DEFAULT ((0)) FOR [RowNumber]
GO
ALTER TABLE [dbo].[Seats] ADD  DEFAULT ((0)) FOR [SeatPosition]
GO
ALTER TABLE [dbo].[Seats] ADD  DEFAULT ('A') FOR [SeatLetter]
GO
ALTER TABLE [dbo].[Seats] ADD  DEFAULT ((0)) FOR [IsWindowSeat]
GO
ALTER TABLE [dbo].[Seats] ADD  DEFAULT ((0)) FOR [IsAisleSeat]
GO
ALTER TABLE [dbo].[SeatTypeConfiguration] ADD  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Tickets] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Tickets] ADD  DEFAULT (getdate()) FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[VehicleConfigurations] ADD  DEFAULT ((0)) FOR [HasUpperDeck]
GO
ALTER TABLE [dbo].[Bookings]  WITH CHECK ADD  CONSTRAINT [FK_Bookings_Trips_TripID] FOREIGN KEY([TripID])
REFERENCES [dbo].[Trips] ([TripID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [FK_Bookings_Trips_TripID]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Delivery] FOREIGN KEY([DeliveryId])
REFERENCES [dbo].[Deliveries] ([DeliveryId])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Delivery]
GO
ALTER TABLE [dbo].[SeatExclusions]  WITH CHECK ADD  CONSTRAINT [FK_SeatExclusion_Vehicle] FOREIGN KEY([VehicleId])
REFERENCES [dbo].[Vehicles] ([VehicleID])
GO
ALTER TABLE [dbo].[SeatExclusions] CHECK CONSTRAINT [FK_SeatExclusion_Vehicle]
GO
ALTER TABLE [dbo].[Trips]  WITH CHECK ADD  CONSTRAINT [FK_Trips_Routes_RouteID] FOREIGN KEY([RouteID])
REFERENCES [dbo].[Routes] ([RouteID])
GO
ALTER TABLE [dbo].[Trips] CHECK CONSTRAINT [FK_Trips_Routes_RouteID]
GO
ALTER TABLE [dbo].[Trips]  WITH CHECK ADD  CONSTRAINT [FK_Trips_Vehicles_VehicleID] FOREIGN KEY([VehicleID])
REFERENCES [dbo].[Vehicles] ([VehicleID])
GO
ALTER TABLE [dbo].[Trips] CHECK CONSTRAINT [FK_Trips_Vehicles_VehicleID]
GO
ALTER TABLE [dbo].[Vehicles]  WITH CHECK ADD  CONSTRAINT [FK_Vehicles_Routes_RouteID] FOREIGN KEY([RouteID])
REFERENCES [dbo].[Routes] ([RouteID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Vehicles] CHECK CONSTRAINT [FK_Vehicles_Routes_RouteID]
GO
/****** Object:  Table [dbo].[Invoices]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoices](
	[InvoiceID] [nvarchar](50) NOT NULL,
	[InvoiceDate] [datetime2](7) NOT NULL,
	[StaffID] [nvarchar](450) NOT NULL,
	[TotalAmount] [decimal](12, 2) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Invoices] PRIMARY KEY CLUSTERED 
(
	[InvoiceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Invoices] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Invoices] ADD  DEFAULT (getdate()) FOR [ModifiedDate]
GO
ALTER TABLE [dbo].[Invoices]  WITH CHECK ADD  CONSTRAINT [FK_Invoices_Staff] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staffs] ([StaffId])
GO
ALTER TABLE [dbo].[Invoices] CHECK CONSTRAINT [FK_Invoices_Staff]
GO
/****** Object:  Index [IX_Invoices_InvoiceDate]    Script Date: 6/24/2025 10:57:51 PM ******/
CREATE NONCLUSTERED INDEX [IX_Invoices_InvoiceDate] ON [dbo].[Invoices]
(
	[InvoiceDate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Invoices_StaffID]    Script Date: 6/24/2025 10:57:51 PM ******/
CREATE NONCLUSTERED INDEX [IX_Invoices_StaffID] ON [dbo].[Invoices]
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Create Payments Table with Correct Column Sizes ******/
CREATE TABLE [dbo].[Payments](
    [PaymentID] [nvarchar](50) NOT NULL,
    [InvoiceNo] [nvarchar](50) NOT NULL,
    [PaymentMethod] [nvarchar](50) NOT NULL,
    [StaffID] [nvarchar](450) NOT NULL,  -- Match Staffs.StaffId size
    [AmountPaid] [decimal](18, 2) NOT NULL,
    [PaymentDate] [datetime2](7) NOT NULL,
    [Status] [nvarchar](50) NOT NULL,
    [CreatedDate] [datetime2](7) NOT NULL DEFAULT GETDATE(),
    [ModifiedDate] [datetime2](7) NOT NULL DEFAULT GETDATE(),
CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED ([PaymentID] ASC)
) ON [PRIMARY]
GO

-- Add foreign keys
ALTER TABLE [dbo].[Payments] WITH CHECK 
ADD CONSTRAINT [FK_Payments_Invoices] FOREIGN KEY([InvoiceNo])
REFERENCES [dbo].[Invoices] ([InvoiceID])
ON UPDATE CASCADE;
GO

ALTER TABLE [dbo].[Payments] WITH CHECK 
ADD CONSTRAINT [FK_Payments_Staffs] FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staffs] ([StaffId])
ON UPDATE CASCADE;
GO
-- Add InvoiceNo column to Tickets table
ALTER TABLE Tickets
ADD InvoiceNo NVARCHAR(50) NULL;

-- Add foreign key constraint
ALTER TABLE Tickets
ADD CONSTRAINT FK_Tickets_Invoices 
FOREIGN KEY (InvoiceNo) REFERENCES Invoices(InvoiceID);

-- Create default users with different roles
DECLARE @adminPassword NVARCHAR(100) = 'Admin@123';
DECLARE @managerPassword NVARCHAR(100) = 'Manager@123';
DECLARE @staffPassword NVARCHAR(100) = 'Staff@123';
DECLARE @driverPassword NVARCHAR(100) = 'Driver@123';

-- Function to hash passwords (SHA-256)
DECLARE @hashedAdminPassword NVARCHAR(MAX);
DECLARE @hashedManagerPassword NVARCHAR(MAX);
DECLARE @hashedStaffPassword NVARCHAR(MAX);
DECLARE @hashedDriverPassword NVARCHAR(MAX);

SET @hashedAdminPassword = LOWER(CONVERT(NVARCHAR(MAX), HASHBYTES('SHA2_256', @adminPassword), 2));
SET @hashedManagerPassword = LOWER(CONVERT(NVARCHAR(MAX), HASHBYTES('SHA2_256', @managerPassword), 2));
SET @hashedStaffPassword = LOWER(CONVERT(NVARCHAR(MAX), HASHBYTES('SHA2_256', @staffPassword), 2));
SET @hashedDriverPassword = LOWER(CONVERT(NVARCHAR(MAX), HASHBYTES('SHA2_256', @driverPassword), 2));

BEGIN TRY
    BEGIN TRANSACTION;
    
    -- Create Admin user
    IF NOT EXISTS (SELECT 1 FROM Staffs WHERE Username = 'admin')
    BEGIN
        INSERT INTO Staffs (
            StaffId, Name, Username, PasswordHash, Role, Gender, BirthDate, 
            Address, Personal_PhoneNumber, Contact_PhoneNumber, position, 
            Hired_Date, Salary, IsStopWorking
        )
        VALUES (
            'ADM001', 
            'System Administrator', 
            'admin', 
            @hashedAdminPassword, 
            'Admin', 
            'Male', 
            '1990-01-01', 
            '123 Admin Street', 
            '111-222-3333', 
            '444-555-6666', 
            'System Administrator', 
            GETDATE(), 
            15000.00, 
            0
        );
        PRINT 'Admin user created successfully';
    END
    ELSE
    BEGIN
        PRINT 'Admin user already exists';
    END

    -- Create Manager user
    IF NOT EXISTS (SELECT 1 FROM Staffs WHERE Username = 'manager')
    BEGIN
        INSERT INTO Staffs (
            StaffId, Name, Username, PasswordHash, Role, Gender, BirthDate, 
            Address, Personal_PhoneNumber, Contact_PhoneNumber, position, 
            Hired_Date, Salary, IsStopWorking
        )
        VALUES (
            'MGR001', 
            'Operations Manager', 
            'manager', 
            @hashedManagerPassword, 
            'Manager', 
            'Female', 
            '1985-05-15', 
            '456 Manager Avenue', 
            '777-888-9999', 
            '000-111-2222', 
            'Operations Manager', 
            GETDATE(), 
            12000.00, 
            0
        );
        PRINT 'Manager user created successfully';
    END
    ELSE
    BEGIN
        PRINT 'Manager user already exists';
    END

    -- Create Staff user
    IF NOT EXISTS (SELECT 1 FROM Staffs WHERE Username = 'staff')
    BEGIN
        INSERT INTO Staffs (
            StaffId, Name, Username, PasswordHash, Role, Gender, BirthDate, 
            Address, Personal_PhoneNumber, Contact_PhoneNumber, position, 
            Hired_Date, Salary, IsStopWorking
        )
        VALUES (
            'STF001', 
            'Front Desk Staff', 
            'staff', 
            @hashedStaffPassword, 
            'Staff', 
            'Other', 
            '1995-08-20', 
            '789 Staff Lane', 
            '333-444-5555', 
            '666-777-8888', 
            'Customer Service', 
            GETDATE(), 
            8000.00, 
            0
        );
        PRINT 'Staff user created successfully';
    END
    ELSE
    BEGIN
        PRINT 'Staff user already exists';
    END

    -- Create Driver user
    IF NOT EXISTS (SELECT 1 FROM Staffs WHERE Username = 'driver')
    BEGIN
        INSERT INTO Staffs (
            StaffId, Name, Username, PasswordHash, Role, Gender, BirthDate, 
            Address, Personal_PhoneNumber, Contact_PhoneNumber, position, 
            Hired_Date, Salary, IsStopWorking
        )
        VALUES (
            'DRV001', 
            'Main Driver', 
            'driver', 
            @hashedDriverPassword, 
            'Driver', 
            'Male', 
            '1988-11-30', 
            '321 Driver Road', 
            '999-000-1111', 
            '222-333-4444', 
            'Senior Driver', 
            GETDATE(), 
            9000.00, 
            0
        );
        PRINT 'Driver user created successfully';
    END
    ELSE
    BEGIN
        PRINT 'Driver user already exists';
    END

    COMMIT TRANSACTION;
    PRINT 'Default users created successfully';
END TRY
BEGIN CATCH
    ROLLBACK TRANSACTION;
    PRINT 'Error creating users: ' + ERROR_MESSAGE();
END CATCH
GO