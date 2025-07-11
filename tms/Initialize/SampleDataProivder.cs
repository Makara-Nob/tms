﻿using tms.Model;

namespace tms.DataSeed
{
    public static class SampleDataProvider
    {
        public static List<Route> GetSampleRoutes()
        {
            return new List<Route>
            {
                new Route
                {
                    RouteID = "RT001",
                    StartPoint = "Phnom Penh Central",
                    EndPoint = "Siem Reap",
                    DistanceKm = 314.5m,
                    EstimatedTimeMinutes = 360,
                    VehicleAssigned = "V001",
                    Priority = "High",
                    AvoidTolls = false,
                    EnableWeatherAlerts = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new Route
                {
                    RouteID = "RT002",
                    StartPoint = "Phnom Penh",
                    EndPoint = "Battambang",
                    DistanceKm = 291.8m,
                    EstimatedTimeMinutes = 300,
                    VehicleAssigned = "V002",
                    Priority = "Medium",
                    AvoidTolls = true,
                    EnableWeatherAlerts = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new Route
                {
                    RouteID = "RT003",
                    StartPoint = "Sihanoukville",
                    EndPoint = "Phnom Penh",
                    DistanceKm = 230.2m,
                    EstimatedTimeMinutes = 240,
                    VehicleAssigned = "V003",
                    Priority = "High",
                    AvoidTolls = false,
                    EnableWeatherAlerts = false,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new Route
                {
                    RouteID = "RT004",
                    StartPoint = "Kampong Cham",
                    EndPoint = "Kratie",
                    DistanceKm = 123.7m,
                    EstimatedTimeMinutes = 150,
                    VehicleAssigned = "V004",
                    Priority = "Low",
                    AvoidTolls = true,
                    EnableWeatherAlerts = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new Route
                {
                    RouteID = "RT005",
                    StartPoint = "Phnom Penh Airport",
                    EndPoint = "Central Market",
                    DistanceKm = 12.5m,
                    EstimatedTimeMinutes = 30,
                    VehicleAssigned = "V005",
                    Priority = "High",
                    AvoidTolls = false,
                    EnableWeatherAlerts = false,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                }
            };
        }

        public static List<Vehicle> GetSampleVehicles()
        {
            return new List<Vehicle>
            {
                new Vehicle
                {
                    VehicleID = "V001",
                    Type = "Bus",
                    Capacity = 45,
                    LicensePlate = "PP-1234",
                    RouteID = "RT001",
                    Status = "Active",
                    MaintenanceDate = DateTime.Now.AddDays(-30),
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new Vehicle
                {
                    VehicleID = "V002",
                    Type = "Mini Bus",
                    Capacity = 20,
                    LicensePlate = "BB-5678",
                    RouteID = "RT002",
                    Status = "Active",
                    MaintenanceDate = DateTime.Now.AddDays(-15),
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new Vehicle
                {
                    VehicleID = "V003",
                    Type = "Bus",
                    Capacity = 50,
                    LicensePlate = "SV-9012",
                    RouteID = "RT003",
                    Status = "Maintenance",
                    MaintenanceDate = DateTime.Now.AddDays(-5),
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new Vehicle
                {
                    VehicleID = "V004",
                    Type = "Van",
                    Capacity = 12,
                    LicensePlate = "KC-3456",
                    RouteID = "RT004",
                    Status = "Active",
                    MaintenanceDate = DateTime.Now.AddDays(-45),
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new Vehicle
                {
                    VehicleID = "V005",
                    Type = "Sedan",
                    Capacity = 4,
                    LicensePlate = "PA-7890",
                    RouteID = "RT005",
                    Status = "Active",
                    MaintenanceDate = DateTime.Now.AddDays(-10),
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new Vehicle
                {
                    VehicleID = "V006",
                    Type = "Truck",
                    Capacity = 2,
                    LicensePlate = "TR-1111",
                    RouteID = "RT001",
                    Status = "Inactive",
                    MaintenanceDate = DateTime.Now.AddDays(-60),
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                }
            };
        }

        public static List<Staff> GetSampleStaff()
        {
            return new List<Staff>
    {
        new Staff
        {
            StaffId = "ST-012",
            Name = "John Doe",
            Gender = "Male",
            BirthDate = new DateTime(1995, 1, 1),
            Address = "Phnom Penh",
            Personal_PhoneNumber = "012345678",
            Contact_PhoneNumber = "087654321",
            Hired_Date = new DateTime(2024, 6, 13),
            Salary = 1200.50m,
            IsStopWorking = false,
            position = "Driver"
        },
        new Staff
        {
            StaffId = "ST-018",
            Name = "Jake Sak",
            Gender = "Male",
            BirthDate = new DateTime(1995, 1, 1),
            Address = "Siem Reap",
            Personal_PhoneNumber = "012345678",
            Contact_PhoneNumber = "087654321",
            Hired_Date = new DateTime(2024, 6, 13),
            Salary = 1200.50m,
            IsStopWorking = false,
            position = "Driver"
        },
        new Staff
        {
                        StaffId = "ST-013",
            Name = "Sophea Chan",
            Gender = "Female",
            BirthDate = new DateTime(1992, 5, 15),
            Address = "Siem Reap",
            Personal_PhoneNumber = "012987654",
            Contact_PhoneNumber = "087123456",
            Hired_Date = new DateTime(2023, 3, 20),
            Salary = 1500.75m,
            IsStopWorking = false,
            position = "Office Assistant"
        },
        new Staff
        {StaffId = "ST-014",
            Name = "Dara Kim",
            Gender = "Male",
            BirthDate = new DateTime(1988, 11, 30),
            Address = "Battambang",
            Personal_PhoneNumber = "016555777",
            Contact_PhoneNumber = "085999111",
            Hired_Date = new DateTime(2022, 1, 10),
            Salary = 1800.00m,
            IsStopWorking = false,
            position = "Mechanic"
        },
        new Staff
        {
                        StaffId = "ST-015",

            Name = "Maly Ouch",
            Gender = "Female",
            BirthDate = new DateTime(1990, 8, 22),
            Address = "Sihanoukville",
            Personal_PhoneNumber = "017444888",
            Contact_PhoneNumber = "086222333",
            Hired_Date = new DateTime(2023, 9, 15),
            Salary = 1350.25m,
            IsStopWorking = false,
            position = "Receptionist"
        },
        new Staff
        {
                        StaffId = "ST-016",
            Name = "Pisach Lim",
            Gender = "Male",
            BirthDate = new DateTime(1985, 12, 10),
            Address = "Kampong Cham",
            Personal_PhoneNumber = "015777999",
            Contact_PhoneNumber = "084555666",
            Hired_Date = new DateTime(2021, 5, 1),
            Salary = 2000.00m,
            IsStopWorking = false,
            position = "Manager"
        }
    };
        }

        public static List<Ticket> GetSampleTickets()
        {
            return new List<Ticket>
            {
                new Ticket
                {
                    TicketID = "TKT20240615120001",
                    SupplierID = "SUP001",
                    SupplierName = "Cambodia Express Transport",
                    SupplierDate = DateTime.Parse("2024-07-01"),
                    CustomerPosition = "Phnom Penh Central Station",
                    CustomerAddress = "St. 108, Phnom Penh, Cambodia",
                    CreatedDate = DateTime.Now.AddDays(-10),
                    ModifiedDate = DateTime.Now.AddDays(-10)
                },
                new Ticket
                {
                    TicketID = "TKT20240615120002",
                    SupplierID = "SUP002",
                    SupplierName = "Mekong Delta Lines",
                    SupplierDate = DateTime.Parse("2024-07-02"),
                    CustomerPosition = "Siem Reap Bus Terminal",
                    CustomerAddress = "National Road 6, Siem Reap, Cambodia",
                    CreatedDate = DateTime.Now.AddDays(-9),
                    ModifiedDate = DateTime.Now.AddDays(-9)
                },
                new Ticket
                {
                    TicketID = "TKT20240615120003",
                    SupplierID = "SUP003",
                    SupplierName = "Angkor Transportation Co.",
                    SupplierDate = DateTime.Parse("2024-07-05"),
                    CustomerPosition = "Battambang Market",
                    CustomerAddress = "Street 1, Battambang, Cambodia",
                    CreatedDate = DateTime.Now.AddDays(-8),
                    ModifiedDate = DateTime.Now.AddDays(-8)
                },
                new Ticket
                {
                    TicketID = "TKT20240615120004",
                    SupplierID = "SUP004",
                    SupplierName = "Royal Bus Services",
                    SupplierDate = DateTime.Parse("2024-07-10"),
                    CustomerPosition = "Sihanoukville Port",
                    CustomerAddress = "Preah Sihanouk, Cambodia",
                    CreatedDate = DateTime.Now.AddDays(-7),
                    ModifiedDate = DateTime.Now.AddDays(-7)
                },
                new Ticket
                {
                    TicketID = "TKT20240615120005",
                    SupplierID = "SUP005",
                    SupplierName = "Khmer National Transport",
                    SupplierDate = DateTime.Parse("2024-07-15"),
                    CustomerPosition = "Kampong Cham Bus Station",
                    CustomerAddress = "Kampong Cham Province, Cambodia",
                    CreatedDate = DateTime.Now.AddDays(-6),
                    ModifiedDate = DateTime.Now.AddDays(-6)
                },
                new Ticket
                {
                    TicketID = "TKT20240615120006",
                    SupplierID = "SUP006",
                    SupplierName = "Tonle Sap Express",
                    SupplierDate = DateTime.Parse("2024-07-20"),
                    CustomerPosition = "Pursat Town Center",
                    CustomerAddress = "Pursat Province, Cambodia",
                    CreatedDate = DateTime.Now.AddDays(-5),
                    ModifiedDate = DateTime.Now.AddDays(-5)
                },
                new Ticket
                {
                    TicketID = "TKT20240615120007",
                    SupplierID = "SUP007",
                    SupplierName = "Golden Triangle Transit",
                    SupplierDate = DateTime.Parse("2024-07-25"),
                    CustomerPosition = "Kratie River Port",
                    CustomerAddress = "Kratie Province, Cambodia",
                    CreatedDate = DateTime.Now.AddDays(-4),
                    ModifiedDate = DateTime.Now.AddDays(-4)
                },
                new Ticket
                {
                    TicketID = "TKT20240615120008",
                    SupplierID = "SUP008",
                    SupplierName = "Bayon Transport Solutions",
                    SupplierDate = DateTime.Parse("2024-08-01"),
                    CustomerPosition = "Kandal Market",
                    CustomerAddress = "Kandal Province, Cambodia",
                    CreatedDate = DateTime.Now.AddDays(-3),
                    ModifiedDate = DateTime.Now.AddDays(-3)
                },
                new Ticket
                {
                    TicketID = "TKT20240615120009",
                    SupplierID = "SUP009",
                    SupplierName = "Preah Vihear Lines",
                    SupplierDate = DateTime.Parse("2024-08-05"),
                    CustomerPosition = "Takeo Provincial Hall",
                    CustomerAddress = "Takeo Province, Cambodia",
                    CreatedDate = DateTime.Now.AddDays(-2),
                    ModifiedDate = DateTime.Now.AddDays(-2)
                },
                new Ticket
                {
                    TicketID = "TKT20240615120010",
                    SupplierID = "SUP010",
                    SupplierName = "Cardamom Mountain Transport",
                    SupplierDate = DateTime.Parse("2024-08-10"),
                    CustomerPosition = "Koh Kong Border",
                    CustomerAddress = "Koh Kong Province, Cambodia",
                    CreatedDate = DateTime.Now.AddDays(-1),
                    ModifiedDate = DateTime.Now.AddDays(-1)
                }
            };
        }


        public static List<Route> GetAdditionalRoutes()
        {
            return new List<Route>
            {
                new Route
                {
                    RouteID = "RT006",
                    StartPoint = "Kandal",
                    EndPoint = "Takeo",
                    DistanceKm = 89.3m,
                    EstimatedTimeMinutes = 120,
                    VehicleAssigned = "V007",
                    Priority = "Medium",
                    AvoidTolls = false,
                    EnableWeatherAlerts = true,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new Route
                {
                    RouteID = "RT007",
                    StartPoint = "Prey Veng",
                    EndPoint = "Svay Rieng",
                    DistanceKm = 156.7m,
                    EstimatedTimeMinutes = 180,
                    VehicleAssigned = "V008",
                    Priority = "Low",
                    AvoidTolls = true,
                    EnableWeatherAlerts = false,
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                }
            };
        }
    }
}