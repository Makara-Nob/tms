USE [tms]
GO
/****** Object:  StoredProcedure [dbo].[AddStaff]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AddStaff]
    @Name NVARCHAR(100),
    @PersonalPhone NVARCHAR(20),
    @ContactPhone NVARCHAR(20),
    @Gender NVARCHAR(10),
    @Address NVARCHAR(255),
    @Position NVARCHAR(50),
    @Photo VARBINARY(MAX) = NULL
AS
BEGIN
    INSERT INTO Staffs (Name, Personal_PhoneNumber, Contact_PhoneNumber, Gender, Address, Position, Photo)
    VALUES (@Name, @PersonalPhone, @ContactPhone, @Gender, @Address, @Position, @Photo)
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteBooking]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteBooking]
    @BookingID INT
AS
BEGIN
    DELETE FROM Bookings WHERE BookingID = @BookingID;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteOrder]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteOrder]
    @OrderID VARCHAR(20)
AS
BEGIN
    DELETE FROM Orders WHERE OrderID = @OrderID;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeletePassenger]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeletePassenger]
    @PassengerID NVARCHAR(50)
AS
BEGIN
    DELETE FROM Passengers
    WHERE PassengerID = @PassengerID;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteRoute]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteRoute]
    @RouteID NVARCHAR(50)
AS
BEGIN
    DELETE FROM Routes
    WHERE RouteID = @RouteID;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteSeat]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteSeat]
    @SeatID INT
AS
BEGIN
    DELETE FROM Seats WHERE SeatId = @SeatID;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteTicket]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteTicket]
    @TicketID NVARCHAR(50)
AS
BEGIN
    DELETE FROM Tickets
    WHERE TicketID = @TicketID;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteTrip]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteTrip]
    @TripID NVARCHAR(50)
AS
BEGIN
    DELETE FROM Trips WHERE TripID = @TripID;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteVehicle]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteVehicle]
    @VehicleID NVARCHAR(50)
AS
BEGIN
    DELETE FROM Vehicles
    WHERE VehicleID = @VehicleID;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetAllBookings]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllBookings]
AS
BEGIN
    SELECT * FROM Bookings;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetAllDeliveries]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllDeliveries]
AS
BEGIN
    SELECT * FROM Deliveries;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetAllOrders]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllOrders]
AS
BEGIN
    SELECT * FROM Orders;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetAllPassengers]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllPassengers]
AS
BEGIN
    SELECT *
    FROM Passengers;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetAllRoutes]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllRoutes]
AS
BEGIN
    SELECT *
    FROM Routes;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetAllSeats]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllSeats]
AS
BEGIN
    SELECT * FROM Seats;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetAllStaff]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Get all staff
CREATE PROCEDURE [dbo].[GetAllStaff]
AS
BEGIN
    SELECT * FROM Staffs
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllTickets]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllTickets]
AS
BEGIN
    SELECT *
    FROM Tickets
    ORDER BY TicketID;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetAllTrips]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllTrips]
AS
BEGIN
    SELECT * FROM Trips ORDER BY TripID;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetAllVehicles]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllVehicles]
AS
BEGIN
    SELECT *
    FROM Vehicles
    ORDER BY VehicleID;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetBookingById]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetBookingById]
    @BookingID INT
AS
BEGIN
    SELECT * FROM Bookings WHERE BookingID = @BookingID;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetOrderById]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetOrderById]
    @OrderID VARCHAR(20)
AS
BEGIN
    SELECT * FROM Orders WHERE OrderID = @OrderID;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetPassengerById]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPassengerById]
    @PassengerID NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Passengers
    WHERE PassengerID = @PassengerID;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetRouteById]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetRouteById]
    @RouteID NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Routes
    WHERE RouteID = @RouteID;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetSeatExclusions]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[GetSeatExclusions]
    @VehicleId NVARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        se.ExclusionId,
        se.VehicleId,
        se.RowNumber,
        se.SeatPosition,
        se.Reason,
        se.IsTemporary
    FROM SeatExclusions se
    WHERE se.VehicleId = @VehicleId;
END
GO
/****** Object:  StoredProcedure [dbo].[GetTicketById]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTicketById]
    @TicketID NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Tickets
    WHERE TicketID = @TicketID;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetTripById]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTripById]
    @TripID NVARCHAR(50)
AS
BEGIN
    SELECT * FROM Trips WHERE TripID = @TripID;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetTripsByDateRange]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTripsByDateRange]
    @StartDate DATETIME2,
    @EndDate DATETIME2
AS
BEGIN
    SELECT * FROM Trips
    WHERE DepatureTime BETWEEN @StartDate AND @EndDate
    ORDER BY status;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetTripsByDriverId]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTripsByDriverId]
    @DriverID NVARCHAR(50)
AS
BEGIN
    SELECT * FROM Trips WHERE DriverID = @DriverID ORDER BY TripID;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetTripsByRouteId]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTripsByRouteId]
    @RouteID NVARCHAR(50)
AS
BEGIN
    SELECT * FROM Trips WHERE RouteID = @RouteID ORDER BY TripID;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetTripsByVehicleId]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTripsByVehicleId]
    @VehicleID NVARCHAR(50)
AS
BEGIN
    SELECT * FROM Trips WHERE VehicleID = @VehicleID ORDER BY TripID;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetTripsDetails]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTripsDetails]
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        T.TripID,
        V.Type,           
        S.Name AS DriverName, 
        R.StartPoint + ' → ' + R.EndPoint AS RouteName,
        T.DepatureTime AS DepartureTime,  
        T.status
    FROM 
        dbo.Trips T
    LEFT JOIN 
        dbo.Vehicles V ON T.VehicleID = V.VehicleID
    LEFT JOIN 
        dbo.Staffs S ON T.DriverID = S.StaffId
    LEFT JOIN 
        dbo.Routes R ON T.RouteID = R.RouteID
    ORDER BY 
        T.DepatureTime DESC;
END;
GO
/****** Object:  StoredProcedure [dbo].[GetVehicleById]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetVehicleById]
    @VehicleID NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM Vehicles
    WHERE VehicleID = @VehicleID;
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertBooking]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertBooking]
    @BookingDate DATETIME,
    @SeatNumber INT,
    @Status NVARCHAR(50),
    @PassengerContact NVARCHAR(20),
    @Gender NVARCHAR(10),
    @StaffID NVARCHAR(50),
    @TripID NVARCHAR(20),
    @NewBookingID INT OUTPUT
AS
BEGIN
    INSERT INTO Bookings (BookingDate, SeatNumber, Status, PassengerContact, Gender, StaffID, TripID)
    VALUES (@BookingDate, @SeatNumber, @Status, @PassengerContact, @Gender, @StaffID, @TripID);

    SET @NewBookingID = SCOPE_IDENTITY();
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertDelivery]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertDelivery]
    @OrderId INT,
    @DeliveryDate DATETIME,
    @DeliveryStatus NVARCHAR(50)
AS
BEGIN
    INSERT INTO Deliveries (OrderId, DeliveryDate, DeliveryStatus)
    VALUES (@OrderId, @DeliveryDate, @DeliveryStatus);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertOrder]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertOrder]
    @OrderID VARCHAR(20),
    @Sender VARCHAR(20),
    @Reciever VARCHAR(20),
    @OrderType VARCHAR(50),
    @OrderDate DATETIME,
    @DeliveryId INT = NULL,
    @DeliveryStatus VARCHAR(20) = NULL,
    @TotalAmount DECIMAL(10,2) = NULL
AS
BEGIN
    INSERT INTO Orders (OrderID, Sender, Reciever, OrderType, OrderDate, DeliveryId, DeliveryStatus, TotalAmount)
    VALUES (@OrderID, @Sender, @Reciever, @OrderType, @OrderDate, @DeliveryId, @DeliveryStatus, @TotalAmount);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertPassenger]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertPassenger]
    @PassengerID NVARCHAR(50),
    @PassengerName NVARCHAR(255),
    @Gender NVARCHAR(50),
    @PersonalNumber NVARCHAR(100),
    @Email NVARCHAR(255),
    @IsActive INT
AS
BEGIN
    INSERT INTO Passengers (
        PassengerID, PassengerName, Gender, PersonalNumber, Email, IsActive
    )
    VALUES (
        @PassengerID, @PassengerName, @Gender, @PersonalNumber, @Email, @IsActive
    );
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertSeat]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertSeat]
    @VehicleID NVARCHAR(50),
    @SeatNumber NVARCHAR(20),
    @SeatType NVARCHAR(50),
    @SeatStatus NVARCHAR(20)
AS
BEGIN
    INSERT INTO Seats (VehicleID, SeatNumber, SeatType, SeatStatus)
    VALUES (@VehicleID, @SeatNumber, @SeatType, @SeatStatus);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertSeatExclusion]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertSeatExclusion]
    @VehicleId NVARCHAR(450),
    @RowNumber INT,
    @SeatPosition INT = NULL,
    @Reason NVARCHAR(255),
    @IsTemporary BIT,
    @ExclusionStart DATETIME = NULL,
    @ExclusionEnd DATETIME = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    INSERT INTO SeatExclusion 
    (VehicleId, RowNumber, SeatPosition, Reason, IsTemporary, ExclusionStart, ExclusionEnd)
    VALUES 
    (@VehicleId, @RowNumber, @SeatPosition, @Reason, @IsTemporary, @ExclusionStart, @ExclusionEnd);
    
    SELECT SCOPE_IDENTITY() AS ExclusionId;
END
GO
/****** Object:  StoredProcedure [dbo].[InsertTicket]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertTicket]
    @TicketID NVARCHAR(50),
    @SupplierID NVARCHAR(50),
    @SupplierName NVARCHAR(200),
    @SupplierDate DATETIME2,
    @CustomerPosition NVARCHAR(200) = NULL,
    @CustomerAddress NVARCHAR(500) = NULL,
    @CreatedDate DATETIME2,
    @ModifiedDate DATETIME2
AS
BEGIN
    INSERT INTO Tickets (
        TicketID, SupplierID, SupplierName, SupplierDate,
        CustomerPosition, CustomerAddress, CreatedDate, ModifiedDate
    )
    VALUES (
        @TicketID, @SupplierID, @SupplierName, @SupplierDate,
        @CustomerPosition, @CustomerAddress, @CreatedDate, @ModifiedDate
    );
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertTrip]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertTrip]
    @TripID NVARCHAR(50),
    @VehicleID NVARCHAR(50),
    @DriverID NVARCHAR(50),
    @RouteID NVARCHAR(50),
    @DepatureTime DATETIME2,
    @Status NVARCHAR(50)
AS
BEGIN
    INSERT INTO Trips (TripID, VehicleID, DriverID, RouteID, DepatureTime, status)
    VALUES (@TripID, @VehicleID, @DriverID, @RouteID, @DepatureTime, @Status);
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertVehicle]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertVehicle]
    @VehicleID NVARCHAR(50),
    @Type NVARCHAR(100),
    @Capacity INT,
    @LicensePlate NVARCHAR(50),
    @RouteID NVARCHAR(50),
    @Status NVARCHAR(50),
    @MaintenanceDate DATETIME,
    @CreatedDate DATETIME,
    @ModifiedDate DATETIME
AS
BEGIN
    INSERT INTO Vehicles (
        VehicleID, Type, Capacity, LicensePlate, RouteID,
        Status, MaintenanceDate, CreatedDate, ModifiedDate
    )
    VALUES (
        @VehicleID, @Type, @Capacity, @LicensePlate, @RouteID,
        @Status, @MaintenanceDate, @CreatedDate, @ModifiedDate
    );
END;
GO
/****** Object:  StoredProcedure [dbo].[SearchPassengers]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchPassengers]
    @SearchTerm NVARCHAR(255)
AS
BEGIN
    SELECT *
    FROM Passengers
    WHERE PassengerID LIKE '%' + @SearchTerm + '%'
       OR PassengerName LIKE '%' + @SearchTerm + '%'
       OR Gender LIKE '%' + @SearchTerm + '%'
       OR PersonalNumber LIKE '%' + @SearchTerm + '%'
       OR Email LIKE '%' + @SearchTerm + '%';
END;
GO
/****** Object:  StoredProcedure [dbo].[SearchRoute]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchRoute]
    @term NVARCHAR(255)
AS
BEGIN
    SELECT *
    FROM Routes
    WHERE StartPoint LIKE '%' + @term + '%'
       OR EndPoint LIKE '%' + @term + '%'
       OR VehicleAssigned LIKE '%' + @term + '%'
       OR Priority LIKE '%' + @term + '%';
END;
GO
/****** Object:  StoredProcedure [dbo].[SearchStaff]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchStaff]
    @Keyword NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM Staffs
    WHERE Name LIKE '%' + @Keyword + '%'
       OR Personal_PhoneNumber LIKE '%' + @Keyword + '%'
       OR Contact_PhoneNumber LIKE '%' + @Keyword + '%'
       OR Gender LIKE '%' + @Keyword + '%'
       OR Address LIKE '%' + @Keyword + '%'
	   OR BirthDate LIKE '%' + @Keyword + '%'
	   OR position LIKE '%' + @Keyword + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[SearchTrips]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchTrips]
    @SearchTerm NVARCHAR(100)
AS
BEGIN
    SELECT * FROM Trips
    WHERE TripID LIKE '%' + @SearchTerm + '%'
       OR VehicleID LIKE '%' + @SearchTerm + '%'
       OR DriverID LIKE '%' + @SearchTerm + '%'
       OR RouteID LIKE '%' + @SearchTerm + '%'
    ORDER BY TripID;
END;
GO
/****** Object:  StoredProcedure [dbo].[SearchVehicles]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchVehicles]
    @term NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM Vehicles
    WHERE VehicleID LIKE '%' + @term + '%'
       OR Type LIKE '%' + @term + '%'
       OR LicensePlate LIKE '%' + @term + '%'
       OR RouteID LIKE '%' + @term + '%'
       OR Status LIKE '%' + @term + '%'
    ORDER BY VehicleID;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_CreateOrUpdateSeatTypeConfig]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CreateOrUpdateSeatTypeConfig]
    @Id INT = 0 OUTPUT,  -- Add OUTPUT keyword here
    @VehicleId NVARCHAR(450),
    @SeatType NVARCHAR(50),
    @FromRow INT,
    @ToRow INT,
    @BasePrice DECIMAL(10,2),
    @IsActive BIT = 1
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        IF @Id = 0
        BEGIN
            -- Insert new configuration
            INSERT INTO [dbo].[SeatTypeConfiguration]
            ([VehicleId], [SeatType], [FromRow], [ToRow], [BasePrice], [IsActive])
            VALUES
            (@VehicleId, @SeatType, @FromRow, @ToRow, @BasePrice, @IsActive);
            
            SET @Id = SCOPE_IDENTITY();
        END
        ELSE
        BEGIN
            -- Update existing configuration
            UPDATE [dbo].[SeatTypeConfiguration]
            SET [SeatType] = @SeatType,
                [FromRow] = @FromRow,
                [ToRow] = @ToRow,
                [BasePrice] = @BasePrice,
                [IsActive] = @IsActive
            WHERE [Id] = @Id;
        END
        
        -- Update seat prices based on configuration
        UPDATE s
        SET s.[Price] = stc.[BasePrice],
            s.[SeatType] = stc.[SeatType]
        FROM [dbo].[Seats] s
        INNER JOIN [dbo].[SeatTypeConfiguration] stc ON s.[VehicleID] = stc.[VehicleId]
        WHERE stc.[Id] = @Id
        AND s.[RowNumber] BETWEEN stc.[FromRow] AND stc.[ToRow];
        
    END TRY
    BEGIN CATCH
        -- Re-throw the error instead of returning a result set
        THROW;
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_CreateOrUpdateVehicle]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_CreateOrUpdateVehicle]
    @VehicleID NVARCHAR(450),
    @Type NVARCHAR(MAX),
    @Capacity INT,
    @LicensePlate NVARCHAR(MAX),
    @RouteID NVARCHAR(450),
    @Status NVARCHAR(MAX),
    @VehicleName NVARCHAR(100),
    @VehicleType NVARCHAR(50),
    @TotalRows INT,
    @SeatsPerRow INT,
    @SeatLayout NVARCHAR(20),
    @CreatedBy NVARCHAR(50),
    @AislePositionsString NVARCHAR(100) = NULL,
    @HasUpperDeck BIT = 0,
    @IsUpdate BIT = 0
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        BEGIN TRANSACTION;
        
        IF @IsUpdate = 1
        BEGIN            
            -- Check if vehicle configuration exists
            IF EXISTS (SELECT 1 FROM [dbo].[VehicleConfigurations] WHERE [VehicleId] = @VehicleID)
            BEGIN
                -- Update existing vehicle configuration
                UPDATE [dbo].[VehicleConfigurations]
                SET [VehicleName] = @VehicleName,
                    [VehicleType] = @VehicleType,
                    [TotalRows] = @TotalRows,
                    [SeatsPerRow] = @SeatsPerRow,
                    [SeatLayout] = @SeatLayout,
                    [AislePositionsString] = @AislePositionsString,
                    [HasUpperDeck] = @HasUpperDeck,
                    [LastModified] = GETDATE()
                WHERE [VehicleId] = @VehicleID;
            END
            ELSE
            BEGIN
                -- Insert new vehicle configuration if it doesn't exist
                INSERT INTO [dbo].[VehicleConfigurations]
                ([VehicleId], [VehicleName], [VehicleType], [TotalRows], [SeatsPerRow], [SeatLayout], 
                 [CreatedDate], [CreatedBy], [AislePositionsString], [HasUpperDeck])
                VALUES
                (@VehicleID, @VehicleName, @VehicleType, @TotalRows, @SeatsPerRow, @SeatLayout,
                 GETDATE(), @CreatedBy, @AislePositionsString, @HasUpperDeck);
            END
            
            -- Also update the main vehicle record if it exists
            IF EXISTS (SELECT 1 FROM [dbo].[Vehicles] WHERE [VehicleID] = @VehicleID)
            BEGIN
                UPDATE [dbo].[Vehicles]
                SET [Type] = @Type,
                    [Capacity] = @Capacity,
                    [LicensePlate] = @LicensePlate,
                    [RouteID] = @RouteID,
                    [Status] = @Status,
                    [ModifiedDate] = GETDATE()
                WHERE [VehicleID] = @VehicleID;
            END
        END
        ELSE
        BEGIN
            -- Insert new vehicle
            INSERT INTO [dbo].[Vehicles] 
            ([VehicleID], [Type], [Capacity], [LicensePlate], [RouteID], [Status], [CreatedDate], [ModifiedDate])
            VALUES 
            (@VehicleID, @Type, @Capacity, @LicensePlate, @RouteID, @Status, GETDATE(), GETDATE());
            
            -- Insert vehicle configuration
            INSERT INTO [dbo].[VehicleConfigurations]
            ([VehicleId], [VehicleName], [VehicleType], [TotalRows], [SeatsPerRow], [SeatLayout], 
             [CreatedDate], [CreatedBy], [AislePositionsString], [HasUpperDeck])
            VALUES
            (@VehicleID, @VehicleName, @VehicleType, @TotalRows, @SeatsPerRow, @SeatLayout,
             GETDATE(), @CreatedBy, @AislePositionsString, @HasUpperDeck);
        END
        
        COMMIT TRANSACTION;
        SELECT 'Success' AS Result, 'Vehicle saved successfully' AS Message;
        
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        SELECT 'Error' AS Result, ERROR_MESSAGE() AS Message;
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteVehicle]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- 10. Delete Vehicle and Related Data
CREATE PROCEDURE [dbo].[sp_DeleteVehicle]
    @VehicleID NVARCHAR(450)
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        BEGIN TRANSACTION;
        
        -- Delete in correct order to avoid foreign key constraints
        DELETE FROM [dbo].[Seats] WHERE [VehicleID] = @VehicleID;
        DELETE FROM [dbo].[SeatExclusions] WHERE [VehicleId] = @VehicleID;
        DELETE FROM [dbo].[SeatTypeConfiguration] WHERE [VehicleId] = @VehicleID;
        DELETE FROM [dbo].[VehicleConfigurations] WHERE [VehicleId] = @VehicleID;
        DELETE FROM [dbo].[Vehicles] WHERE [VehicleID] = @VehicleID;
        
        COMMIT TRANSACTION;
        SELECT 'Success' AS Result, 'Vehicle deleted successfully' AS Message;
        
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        SELECT 'Error' AS Result, ERROR_MESSAGE() AS Message;
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GenerateSeatsForVehicle]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GenerateSeatsForVehicle]
    @VehicleID NVARCHAR(450),
    @UpdatedBy NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        BEGIN TRANSACTION;
        
        DECLARE @TotalRows INT, @SeatsPerRow INT, @SeatLayout NVARCHAR(20);
        DECLARE @AislePositions NVARCHAR(100);
        
        -- Get vehicle configuration
        SELECT @TotalRows = [TotalRows], 
               @SeatsPerRow = [SeatsPerRow], 
               @SeatLayout = [SeatLayout],
               @AislePositions = [AislePositionsString]
        FROM [dbo].[VehicleConfigurations]
        WHERE [VehicleId] = @VehicleID;
        
        IF @TotalRows IS NULL
        BEGIN
            SELECT 'Error' AS Result, 'Vehicle configuration not found' AS Message;
            RETURN;
        END
        
        -- Delete existing seats for this vehicle
        DELETE FROM [dbo].[Seats] WHERE [VehicleID] = @VehicleID;
        
        DECLARE @Row INT = 1;
        DECLARE @Position INT;
        DECLARE @SeatLetter CHAR(1);
        DECLARE @SeatNumber NVARCHAR(10);
        DECLARE @IsAisle BIT, @IsWindow BIT;
        
        -- Generate seats
        WHILE @Row <= @TotalRows
        BEGIN
            SET @Position = 1;
            
            WHILE @Position <= @SeatsPerRow
            BEGIN
                -- Skip if seat is excluded
                IF NOT EXISTS (SELECT 1 FROM [dbo].[SeatExclusions] 
                              WHERE [VehicleId] = @VehicleID 
                              AND [RowNumber] = @Row 
                              AND ([SeatPosition] = @Position OR [SeatPosition] IS NULL))
                BEGIN
                    -- Calculate seat letter (A, B, C, etc.)
                    SET @SeatLetter = CHAR(64 + @Position);
                    SET @SeatNumber = CAST(@Row AS NVARCHAR) + @SeatLetter;
                    
                    -- Determine if it's window or aisle seat
                    SET @IsWindow = CASE WHEN @Position = 1 OR @Position = @SeatsPerRow THEN 1 ELSE 0 END;
                    SET @IsAisle = CASE WHEN @AislePositions IS NOT NULL AND 
                                        CHARINDEX(CAST(@Position AS NVARCHAR), @AislePositions) > 0 THEN 1 ELSE 0 END;
                    
                    INSERT INTO [dbo].[Seats]
                    ([VehicleID], [SeatNumber], [SeatType], [seatStatus], [RowNumber], 
                     [SeatPosition], [SeatLetter], [IsWindowSeat], [IsAisleSeat], 
                     [LastUpdated], [UpdatedBy])
                    VALUES
                    (@VehicleID, @SeatNumber, 'Standard', 'Available', @Row, 
                     @Position, @SeatLetter, @IsWindow, @IsAisle, 
                     GETDATE(), @UpdatedBy);
                END
                
                SET @Position = @Position + 1;
            END
            
            SET @Row = @Row + 1;
        END
        
        COMMIT TRANSACTION;
        SELECT 'Success' AS Result, 'Seats generated successfully' AS Message;
        
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        SELECT 'Error' AS Result, ERROR_MESSAGE() AS Message;
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetSeatTypeConfigurations]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetSeatTypeConfigurations]
    @VehicleId NVARCHAR(450) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        [Id],
        [VehicleId],
        [SeatType],
        [FromRow],
        [ToRow],
        [BasePrice],
        [IsActive]
    FROM [dbo].[SeatTypeConfiguration]
    WHERE (@VehicleId IS NULL OR [VehicleId] = @VehicleId)
    AND [IsActive] = 1
    ORDER BY [VehicleId], [FromRow];
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetVehicleDetails]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetVehicleDetails]
    @VehicleID NVARCHAR(450) = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        v.[VehicleID],
        v.[Type],
        v.[Capacity],
        v.[LicensePlate],
        v.[RouteID],
        v.[Status],
        v.[MaintenanceDate],
        v.[CreatedDate],
        v.[ModifiedDate],
        vc.[VehicleName],
        vc.[VehicleType],
        vc.[TotalRows],
        vc.[SeatsPerRow],
        vc.[SeatLayout],
        vc.[AislePositionsString],
        vc.[HasUpperDeck],
        vc.[CreatedBy],
        vc.[LastModified]
    FROM [dbo].[Vehicles] v
    LEFT JOIN [dbo].[VehicleConfigurations] vc ON v.[VehicleID] = vc.[VehicleId]
    WHERE (@VehicleID IS NULL OR v.[VehicleID] = @VehicleID)
    ORDER BY v.[CreatedDate] DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetVehicleSeatMap]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetVehicleSeatMap]
    @VehicleID NVARCHAR(450)
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Get vehicle configuration
    SELECT 
        [TotalRows],
        [SeatsPerRow],
        [SeatLayout],
        [AislePositionsString],
        [HasUpperDeck]
    FROM [dbo].[VehicleConfigurations]
    WHERE [VehicleId] = @VehicleID;
    
    -- Get seats with exclusions
    SELECT 
        s.[SeatId],
        s.[SeatNumber],
        s.[SeatType],
        s.[seatStatus],
        s.[RowNumber],
        s.[SeatPosition],
        s.[SeatLetter],
        s.[Price],
        s.[IsWindowSeat],
        s.[IsAisleSeat],
        s.[SeatFeatures],
        CASE WHEN se.[ExclusionId] IS NOT NULL THEN 1 ELSE 0 END AS IsExcluded,
        se.[Reason] AS ExclusionReason
    FROM [dbo].[Seats] s
    LEFT JOIN [dbo].[SeatExclusions] se ON s.[VehicleID] = se.[VehicleId] 
                                        AND s.[RowNumber] = se.[RowNumber]
                                        AND (se.[SeatPosition] IS NULL OR s.[SeatPosition] = se.[SeatPosition])
    WHERE s.[VehicleID] = @VehicleID
    ORDER BY s.[RowNumber], s.[SeatPosition];
END
GO
/****** Object:  StoredProcedure [dbo].[sp_GetVehicleSeats]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetVehicleSeats]
    @VehicleID NVARCHAR(450)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        [SeatId],
        [VehicleID],
        [SeatNumber],
        [SeatType],
        [seatStatus],
        [RowNumber],
        [SeatPosition],
        [SeatLetter],
        [Price],
        [IsWindowSeat],
        [IsAisleSeat],
        [SeatFeatures],
        [LastUpdated],
        [UpdatedBy]
    FROM [dbo].[Seats]
    WHERE [VehicleID] = @VehicleID
    ORDER BY [RowNumber], [SeatPosition];
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ManageSeatExclusion]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_ManageSeatExclusion]
    @Action NVARCHAR(10), -- 'ADD' or 'REMOVE'
    @VehicleId NVARCHAR(450),
    @RowNumber INT,
    @SeatPosition INT = NULL,
    @Reason NVARCHAR(100) = NULL,
    @IsTemporary BIT = 0
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        IF @Action = 'ADD'
        BEGIN
            INSERT INTO [dbo].[SeatExclusions]
            ([VehicleId], [RowNumber], [SeatPosition], [Reason], [IsTemporary])
            VALUES
            (@VehicleId, @RowNumber, @SeatPosition, @Reason, @IsTemporary);
            
            -- Update seat status to unavailable
            UPDATE [dbo].[Seats]
            SET [seatStatus] = 'Unavailable'
            WHERE [VehicleID] = @VehicleId
            AND [RowNumber] = @RowNumber
            AND (@SeatPosition IS NULL OR [SeatPosition] = @SeatPosition);
        END
        ELSE IF @Action = 'REMOVE'
        BEGIN
            DELETE FROM [dbo].[SeatExclusions]
            WHERE [VehicleId] = @VehicleId
            AND [RowNumber] = @RowNumber
            AND (@SeatPosition IS NULL OR [SeatPosition] = @SeatPosition);
            
            -- Update seat status back to available
            UPDATE [dbo].[Seats]
            SET [seatStatus] = 'Available'
            WHERE [VehicleID] = @VehicleId
            AND [RowNumber] = @RowNumber
            AND (@SeatPosition IS NULL OR [SeatPosition] = @SeatPosition);
        END
        
        SELECT 'Success' AS Result, 'Exclusion managed successfully' AS Message;
        
    END TRY
    BEGIN CATCH
        SELECT 'Error' AS Result, ERROR_MESSAGE() AS Message;
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateSeat]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_UpdateSeat]
    @SeatId INT,
    @SeatType NVARCHAR(MAX) = NULL,
    @SeatStatus NVARCHAR(MAX) = NULL,
    @Price DECIMAL(10,2) = NULL,
    @SeatFeatures NVARCHAR(200) = NULL,
    @UpdatedBy NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        UPDATE [dbo].[Seats]
        SET [SeatType] = ISNULL(@SeatType, [SeatType]),
            [seatStatus] = ISNULL(@SeatStatus, [seatStatus]),
            [Price] = ISNULL(@Price, [Price]),
            [SeatFeatures] = ISNULL(@SeatFeatures, [SeatFeatures]),
            [LastUpdated] = GETDATE(),
            [UpdatedBy] = @UpdatedBy
        WHERE [SeatId] = @SeatId;
        
        IF @@ROWCOUNT > 0
            SELECT 'Success' AS Result, 'Seat updated successfully' AS Message;
        ELSE
            SELECT 'Error' AS Result, 'Seat not found' AS Message;
            
    END TRY
    BEGIN CATCH
        SELECT 'Error' AS Result, ERROR_MESSAGE() AS Message;
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateBooking]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateBooking]
    @BookingID INT,
    @BookingDate DATETIME,
    @SeatNumber INT,
    @Status NVARCHAR(50),
    @PassengerContact NVARCHAR(20),
    @Gender NVARCHAR(10),
    @StaffID NVARCHAR(50),
    @TripID INT
AS
BEGIN
    UPDATE Bookings
    SET 
        BookingDate = @BookingDate,
        SeatNumber = @SeatNumber,
        Status = @Status,
        PassengerContact = @PassengerContact,
        Gender = @Gender,
        StaffID = @StaffID,
        TripID = @TripID
    WHERE BookingID = @BookingID;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateDelivery]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateDelivery]
    @DeliveryId INT,
    @OrderId INT,
    @DeliveryDate DATETIME,
    @DeliveryStatus NVARCHAR(50)
AS
BEGIN
    UPDATE Deliveries
    SET OrderId = @OrderId,
        DeliveryDate = @DeliveryDate,
        DeliveryStatus = @DeliveryStatus
    WHERE DeliveryId = @DeliveryId;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateOrder]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateOrder]
    @OrderID VARCHAR(20),
    @Sender VARCHAR(20),
    @Reciever VARCHAR(20),
    @OrderType VARCHAR(50),
    @OrderDate DATETIME,
    @DeliveryId INT = NULL,
    @DeliveryStatus VARCHAR(20) = NULL,
    @TotalAmount DECIMAL(10,2) = NULL
AS
BEGIN
    UPDATE Orders
    SET
        Sender = @Sender,
        Reciever = @Reciever,
        OrderType = @OrderType,
        OrderDate = @OrderDate,
        DeliveryId = @DeliveryId,
        DeliveryStatus = @DeliveryStatus,
        TotalAmount = @TotalAmount
    WHERE OrderID = @OrderID;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdatePassenger]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdatePassenger]
    @PassengerID NVARCHAR(50),
    @PassengerName NVARCHAR(255),
    @Gender NVARCHAR(50),
    @PersonalNumber NVARCHAR(100),
    @Email NVARCHAR(255),
    @IsActive INT
AS
BEGIN
    UPDATE Passengers
    SET
        PassengerName = @PassengerName,
        Gender = @Gender,
        PersonalNumber = @PersonalNumber,
        Email = @Email,
        IsActive = @IsActive
    WHERE PassengerID = @PassengerID;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateRoute]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateRoute]
    @RouteID NVARCHAR(50),
    @StartPoint NVARCHAR(255),
    @EndPoint NVARCHAR(255),
    @DistanceKm DECIMAL(18, 2),
    @EstimatedTimeMinutes INT,
    @VehicleAssigned NVARCHAR(255),
    @Priority NVARCHAR(50),
    @AvoidTolls BIT,
    @EnableWeatherAlerts BIT,
    @ModifiedDate DATETIME
AS
BEGIN
    UPDATE Routes
    SET
        StartPoint = @StartPoint,
        EndPoint = @EndPoint,
        DistanceKm = @DistanceKm,
        EstimatedTimeMinutes = @EstimatedTimeMinutes,
        VehicleAssigned = @VehicleAssigned,
        Priority = @Priority,
        AvoidTolls = @AvoidTolls,
        EnableWeatherAlerts = @EnableWeatherAlerts,
        ModifiedDate = @ModifiedDate
    WHERE RouteID = @RouteID;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateSeat]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateSeat]
    @SeatID INT,
    @VehicleID NVARCHAR(50),
    @SeatNumber NVARCHAR(20),
    @SeatType NVARCHAR(50),
    @SeatStatus NVARCHAR(20)
AS
BEGIN
    UPDATE Seats
    SET VehicleID = @VehicleID,
        SeatNumber = @SeatNumber,
        SeatType = @SeatType,
        SeatStatus = @SeatStatus
    WHERE SeatId = @SeatID;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateSeatStatus]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateSeatStatus]
    @SeatId INT,
    @NewStatus NVARCHAR(50),
    @UpdatedBy NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE Seat 
    SET seatStatus = @NewStatus,
        LastUpdated = GETDATE(),
        UpdatedBy = @UpdatedBy
    WHERE SeatId = @SeatId;
    
    SELECT 'Success' AS Result;
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateStaff]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateStaff]
    @StaffId INT,
    @Name NVARCHAR(100),
    @PersonalPhone NVARCHAR(20),
    @ContactPhone NVARCHAR(20),
    @Gender NVARCHAR(10),
    @Address NVARCHAR(255),
    @Position NVARCHAR(50),
    @Photo VARBINARY(MAX)
AS
BEGIN
    UPDATE Staffs
    SET Name = @Name,
        Personal_PhoneNumber = @PersonalPhone,
        Contact_PhoneNumber = @ContactPhone,
        Gender = @Gender,
        Address = @Address,
        Position = @Position,
        Photo = @Photo
    WHERE StaffId = @StaffId
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateTicket]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateTicket]
    @TicketID NVARCHAR(50),
    @SupplierID NVARCHAR(50),
    @SupplierName NVARCHAR(200),
    @SupplierDate DATETIME2,
    @CustomerPosition NVARCHAR(200) = NULL,
    @CustomerAddress NVARCHAR(500) = NULL,
    @ModifiedDate DATETIME2
AS
BEGIN
    UPDATE Tickets
    SET
        SupplierID = @SupplierID,
        SupplierName = @SupplierName,
        SupplierDate = @SupplierDate,
        CustomerPosition = @CustomerPosition,
        CustomerAddress = @CustomerAddress,
        ModifiedDate = @ModifiedDate
    WHERE TicketID = @TicketID;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateTrip]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateTrip]
    @TripID NVARCHAR(50),
    @VehicleID NVARCHAR(50),
    @DriverID NVARCHAR(50),
    @RouteID NVARCHAR(50),
    @DepatureTime DATETIME2,
    @Status NVARCHAR(50)
AS
BEGIN
    UPDATE Trips
    SET VehicleID = @VehicleID,
        DriverID = @DriverID,
        RouteID = @RouteID,
        DepatureTime = @DepatureTime,
        status = @Status
    WHERE TripID = @TripID;
END;
GO
/****** Object:  StoredProcedure [dbo].[UpdateVehicle]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateVehicle]
    @VehicleID NVARCHAR(50),
    @Type NVARCHAR(100),
    @Capacity INT,
    @LicensePlate NVARCHAR(50),
    @RouteID NVARCHAR(50),
    @Status NVARCHAR(50),
    @MaintenanceDate DATETIME,
    @ModifiedDate DATETIME
AS
BEGIN
    UPDATE Vehicles
    SET
        Type = @Type,
        Capacity = @Capacity,
        LicensePlate = @LicensePlate,
        RouteID = @RouteID,
        Status = @Status,
        MaintenanceDate = @MaintenanceDate,
        ModifiedDate = @ModifiedDate
    WHERE VehicleID = @VehicleID;
END;
GO
/****** Object:  StoredProcedure [dbo].[DeleteInvoice]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteInvoice]
    @InvoiceID NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        DELETE FROM Invoices
        WHERE InvoiceID = @InvoiceID;
        
        IF @@ROWCOUNT > 0
            SELECT 'Success' AS Result, 'Invoice deleted successfully' AS Message;
        ELSE
            SELECT 'Error' AS Result, 'Invoice not found' AS Message;
            
    END TRY
    BEGIN CATCH
        SELECT 'Error' AS Result, ERROR_MESSAGE() AS Message;
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[GetAllInvoices]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllInvoices]
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        InvoiceID,
        InvoiceDate,
        StaffID,
        TotalAmount,
        CreatedDate,
        ModifiedDate
    FROM Invoices
    ORDER BY CreatedDate DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[GetInvoiceById]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetInvoiceById]
    @InvoiceID NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        InvoiceID,
        InvoiceDate,
        StaffID,
        TotalAmount,
        CreatedDate,
        ModifiedDate
    FROM Invoices
    WHERE InvoiceID = @InvoiceID;
END
GO
/****** Object:  StoredProcedure [dbo].[GetInvoiceSummary]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetInvoiceSummary]
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        i.InvoiceID,
        i.InvoiceDate,
        i.StaffID,
        s.Name AS StaffName,
        i.TotalAmount,
        i.CreatedDate,
        i.ModifiedDate
    FROM Invoices i
    LEFT JOIN Staffs s ON i.StaffID = s.StaffId;
END
GO
/****** Object:  StoredProcedure [dbo].[GetInvoicesByDateRange]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetInvoicesByDateRange]
    @StartDate DATETIME2,
    @EndDate DATETIME2
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        InvoiceID,
        InvoiceDate,
        StaffID,
        TotalAmount,
        CreatedDate,
        ModifiedDate
    FROM Invoices
    WHERE InvoiceDate >= @StartDate 
      AND InvoiceDate <= @EndDate
    ORDER BY InvoiceDate DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[GetInvoicesByStaff]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetInvoicesByStaff]
    @StaffID NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        InvoiceID,
        InvoiceDate,
        StaffID,
        TotalAmount,
        CreatedDate,
        ModifiedDate
    FROM Invoices
    WHERE StaffID = @StaffID
    ORDER BY InvoiceDate DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[InsertInvoice]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertInvoice]
    @InvoiceID NVARCHAR(50),
    @InvoiceDate DATETIME2,
    @StaffID NVARCHAR(50),
    @TotalAmount DECIMAL(12,2),
    @CreatedDate DATETIME2 = NULL,
    @ModifiedDate DATETIME2 = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        SET @CreatedDate = ISNULL(@CreatedDate, GETDATE());
        SET @ModifiedDate = ISNULL(@ModifiedDate, GETDATE());
        
        INSERT INTO Invoices (
            InvoiceID,
            InvoiceDate,
            StaffID,
            TotalAmount,
            CreatedDate,
            ModifiedDate
        )
        VALUES (
            @InvoiceID,
            @InvoiceDate,
            @StaffID,
            @TotalAmount,
            @CreatedDate,
            @ModifiedDate
        );
        
        SELECT 'Success' AS Result, 'Invoice created successfully' AS Message;
        
    END TRY
    BEGIN CATCH
        SELECT 'Error' AS Result, ERROR_MESSAGE() AS Message;
    END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[SearchInvoices]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchInvoices]
    @term NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        InvoiceID,
        InvoiceDate,
        StaffID,
        TotalAmount,
        CreatedDate,
        ModifiedDate
    FROM Invoices
    WHERE InvoiceID LIKE '%' + @term + '%'
       OR StaffID LIKE '%' + @term + '%'
       OR CAST(TotalAmount AS NVARCHAR) LIKE '%' + @term + '%'
    ORDER BY CreatedDate DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateInvoice]    Script Date: 6/24/2025 10:57:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateInvoice]
    @InvoiceID NVARCHAR(50),
    @InvoiceDate DATETIME2,
    @StaffID NVARCHAR(50),
    @TotalAmount DECIMAL(12,2),
    @ModifiedDate DATETIME2 = NULL
AS
BEGIN
    SET NOCOUNT ON;
    
    BEGIN TRY
        SET @ModifiedDate = ISNULL(@ModifiedDate, GETDATE());
        
        UPDATE Invoices
        SET 
            InvoiceDate = @InvoiceDate,
            StaffID = @StaffID,
            TotalAmount = @TotalAmount,
            ModifiedDate = @ModifiedDate
        WHERE InvoiceID = @InvoiceID;
        
        IF @@ROWCOUNT > 0
            SELECT 'Success' AS Result, 'Invoice updated successfully' AS Message;
        ELSE
            SELECT 'Error' AS Result, 'Invoice not found' AS Message;
            
    END TRY
    BEGIN CATCH
        SELECT 'Error' AS Result, ERROR_MESSAGE() AS Message;
    END CATCH
END
GO

/****** Stored Procedures ******/
CREATE PROCEDURE [dbo].[InsertPayment]
    @PaymentID NVARCHAR(50),
    @InvoiceNo NVARCHAR(50),
    @PaymentMethod NVARCHAR(50),
    @StaffID NVARCHAR(450),
    @AmountPaid DECIMAL(18,2),
    @PaymentDate DATETIME2,
    @Status NVARCHAR(50)
AS
BEGIN
    INSERT INTO Payments (
        PaymentID, InvoiceNo, PaymentMethod, StaffID, 
        AmountPaid, PaymentDate, Status
    )
    VALUES (
        @PaymentID, @InvoiceNo, @PaymentMethod, @StaffID,
        @AmountPaid, @PaymentDate, @Status
    );
END
GO

CREATE PROCEDURE [dbo].[UpdatePayment]
    @PaymentID NVARCHAR(50),
    @InvoiceNo NVARCHAR(50),
    @PaymentMethod NVARCHAR(50),
    @StaffID NVARCHAR(450),
    @AmountPaid DECIMAL(18,2),
    @PaymentDate DATETIME2,
    @Status NVARCHAR(50)
AS
BEGIN
    UPDATE Payments
    SET
        InvoiceNo = @InvoiceNo,
        PaymentMethod = @PaymentMethod,
        StaffID = @StaffID,
        AmountPaid = @AmountPaid,
        PaymentDate = @PaymentDate,
        Status = @Status,
        ModifiedDate = GETDATE()
    WHERE PaymentID = @PaymentID;
END
GO

CREATE PROCEDURE [dbo].[DeletePayment]
    @PaymentID NVARCHAR(50)
AS
BEGIN
    DELETE FROM Payments WHERE PaymentID = @PaymentID;
END
GO

CREATE PROCEDURE [dbo].[GetPaymentById]
    @PaymentID NVARCHAR(50)
AS
BEGIN
    SELECT * FROM Payments WHERE PaymentID = @PaymentID;
END
GO

CREATE PROCEDURE [dbo].[GetAllPayments]
AS
BEGIN
    SELECT * FROM Payments ORDER BY PaymentDate DESC;
END
GO

CREATE PROCEDURE [dbo].[SearchPayments]
    @term NVARCHAR(100)
AS
BEGIN
    SELECT * 
    FROM Payments
    WHERE PaymentID LIKE '%' + @term + '%'
       OR InvoiceNo LIKE '%' + @term + '%'
       OR StaffID LIKE '%' + @term + '%'
       OR PaymentMethod LIKE '%' + @term + '%'
       OR Status LIKE '%' + @term + '%'
    ORDER BY PaymentDate DESC;
END
GO

-- Stored Procedure for SearchRoute
CREATE PROCEDURE SearchRoute
    @term NVARCHAR(MAX)
AS
BEGIN
    SELECT
        RouteID,
        StartPoint,
        EndPoint,
        DistanceKm,
        EstimatedTimeMinutes,
        VehicleAssigned,
        Priority,
        AvoidTolls,
        EnableWeatherAlerts,
        CreatedDate,
        ModifiedDate
    FROM
        Routes
    WHERE
        RouteID LIKE '%' + @term + '%' OR
        StartPoint LIKE '%' + @term + '%' OR
        EndPoint LIKE '%' + @term + '%' OR
        VehicleAssigned LIKE '%' + @term + '%';
END;
GO

-- Stored Procedure for InsertRoute
CREATE PROCEDURE InsertRoute
    @RouteID NVARCHAR(450),
    @StartPoint NVARCHAR(MAX),
    @EndPoint NVARCHAR(MAX),
    @DistanceKm DECIMAL(10, 2),
    @EstimatedTimeMinutes INT,
    @VehicleAssigned NVARCHAR(MAX),
    @Priority NVARCHAR(MAX),
    @AvoidTolls BIT,
    @EnableWeatherAlerts BIT,
    @CreatedDate DATETIME2(7),
    @ModifiedDate DATETIME2(7)
AS
BEGIN
    INSERT INTO Routes
    (
        RouteID,
        StartPoint,
        EndPoint,
        DistanceKm,
        EstimatedTimeMinutes,
        VehicleAssigned,
        Priority,
        AvoidTolls,
        EnableWeatherAlerts,
        CreatedDate,
        ModifiedDate
    )
    VALUES
    (
        @RouteID,
        @StartPoint,
        @EndPoint,
        @DistanceKm,
        @EstimatedTimeMinutes,
        @VehicleAssigned,
        @Priority,
        @AvoidTolls,
        @EnableWeatherAlerts,
        @CreatedDate,
        @ModifiedDate
    );
    SELECT @@ROWCOUNT; -- Return the number of rows affected
END;
GO
-- Stored procedure to check payment status
CREATE PROCEDURE [dbo].[CheckInvoicePaymentStatus]
    @InvoiceNo NVARCHAR(50)
AS
BEGIN
    SELECT 
        CASE WHEN EXISTS (
            SELECT 1 
            FROM Payments 
            WHERE InvoiceNo = @InvoiceNo AND Status = 'Completed'
        ) THEN 1 ELSE 0 END AS IsPaid
END
GO

-- Update InsertTicket stored procedure
ALTER PROCEDURE [dbo].[InsertTicket]
    @TicketID NVARCHAR(50),
    @SupplierID NVARCHAR(50),
    @SupplierName NVARCHAR(200),
    @SupplierDate DATETIME2,
    @CustomerPosition NVARCHAR(200) = NULL,
    @CustomerAddress NVARCHAR(500) = NULL,
    @CreatedDate DATETIME2,
    @ModifiedDate DATETIME2,
    @InvoiceNo NVARCHAR(50) = NULL  -- New parameter
AS
BEGIN
    INSERT INTO Tickets (
        TicketID, SupplierID, SupplierName, SupplierDate,
        CustomerPosition, CustomerAddress, CreatedDate, ModifiedDate, InvoiceNo
    )
    VALUES (
        @TicketID, @SupplierID, @SupplierName, @SupplierDate,
        @CustomerPosition, @CustomerAddress, @CreatedDate, @ModifiedDate, @InvoiceNo
    );
END
GO

-- Update UpdateTicket stored procedure
ALTER PROCEDURE [dbo].[UpdateTicket]
    @TicketID NVARCHAR(50),
    @SupplierID NVARCHAR(50),
    @SupplierName NVARCHAR(200),
    @SupplierDate DATETIME2,
    @CustomerPosition NVARCHAR(200) = NULL,
    @CustomerAddress NVARCHAR(500) = NULL,
    @ModifiedDate DATETIME2,
    @InvoiceNo NVARCHAR(50) = NULL  -- New parameter
AS
BEGIN
    UPDATE Tickets
    SET
        SupplierID = @SupplierID,
        SupplierName = @SupplierName,
        SupplierDate = @SupplierDate,
        CustomerPosition = @CustomerPosition,
        CustomerAddress = @CustomerAddress,
        ModifiedDate = @ModifiedDate,
        InvoiceNo = @InvoiceNo
    WHERE TicketID = @TicketID;
END
GO