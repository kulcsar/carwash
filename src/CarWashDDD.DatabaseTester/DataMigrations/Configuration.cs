namespace CarWashDDD.DatabaseTester.DataMigrations
{
    using Repository.EF;
    using Repository.EF.DataModel;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CarWashDDDContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"DataMigrations";
        }

        protected override void Seed(CarWashDDDContext context)
        {
            List<ServiceProvider> serviceProviders = new List<ServiceProvider>();
            ServiceProvider normalServiceProvider = new ServiceProvider
            {
                Id = Guid.NewGuid(),
                Name = "Normal"
            };
            ServiceProvider steamServiceProvider = new ServiceProvider
            {
                Id = Guid.NewGuid(),
                Name = "Steam"
            };
            serviceProviders.Add(normalServiceProvider);
            serviceProviders.Add(steamServiceProvider);
            context.ServiceProviders.AddRange(serviceProviders);

            List<Service> normalServices = new List<Service>();
            Service normalExterior = new Service
            {
                Id = Guid.NewGuid(),
                Name = "Exterior",
                SlotCount = 1,
                ServiceProviderId = normalServiceProvider.Id
            };
            Service normalInterior = new Service
            {
                Id = Guid.NewGuid(),
                Name = "Interior",
                SlotCount = 1,
                ServiceProviderId = normalServiceProvider.Id
            };
            Service normalExteriorInterior = new Service
            {
                Id = Guid.NewGuid(),
                Name = "Exterior + Interior",
                SlotCount = 1,
                ServiceProviderId = normalServiceProvider.Id
            };
            Service normalExteriorInteriorCarpet = new Service
            {
                Id = Guid.NewGuid(),
                Name = "Exterior + Interior + Carpet",
                SlotCount = 2,
                ServiceProviderId = normalServiceProvider.Id
            };
            normalServices.Add(normalExterior);
            normalServices.Add(normalInterior);
            normalServices.Add(normalExteriorInterior);
            normalServices.Add(normalExteriorInteriorCarpet);
            context.Services.AddRange(normalServices);

            List<Service> steamServices = new List<Service>();
            Service steamExterior = new Service
            {
                Id = Guid.NewGuid(),
                Name = "Exterior",
                SlotCount = 1,
                ServiceProviderId = steamServiceProvider.Id
            };
            Service steamInterior = new Service
            {
                Id = Guid.NewGuid(),
                Name = "Interior",
                SlotCount = 1,
                ServiceProviderId = steamServiceProvider.Id
            };
            Service steamExteriorInterior = new Service
            {
                Id = Guid.NewGuid(),
                Name = "Exterior + Interior",
                SlotCount = 1,
                ServiceProviderId = steamServiceProvider.Id
            };
            steamServices.Add(steamExterior);
            steamServices.Add(steamInterior);
            steamServices.Add(steamExteriorInterior);
            context.Services.AddRange(steamServices);

            List<OpeningHour> normalOpeningHours = new List<OpeningHour>();
            OpeningHour normalMonday = new OpeningHour
            {
                Id = Guid.NewGuid(),
                ServiceProviderId = normalServiceProvider.Id,
                SlotCount = 11,
                Weekday = Weekday.Monday
            };
            OpeningHour normalTuesday = new OpeningHour
            {
                Id = Guid.NewGuid(),
                ServiceProviderId = normalServiceProvider.Id,
                SlotCount = 11,
                Weekday = Weekday.Tuesday
            };
            OpeningHour normalWednesday = new OpeningHour
            {
                Id = Guid.NewGuid(),
                ServiceProviderId = normalServiceProvider.Id,
                SlotCount = 11,
                Weekday = Weekday.Wednesday
            };
            OpeningHour normalThursday = new OpeningHour
            {
                Id = Guid.NewGuid(),
                ServiceProviderId = normalServiceProvider.Id,
                SlotCount = 11,
                Weekday = Weekday.Thursday
            };
            OpeningHour normalFriday = new OpeningHour
            {
                Id = Guid.NewGuid(),
                ServiceProviderId = normalServiceProvider.Id,
                SlotCount = 11,
                Weekday = Weekday.Friday
            };
            normalOpeningHours.Add(normalMonday);
            normalOpeningHours.Add(normalTuesday);
            normalOpeningHours.Add(normalWednesday);
            normalOpeningHours.Add(normalThursday);
            normalOpeningHours.Add(normalFriday);
            context.OpeningHours.AddRange(normalOpeningHours);

            List<OpeningHour> steamOpeningHours = new List<OpeningHour>();          
            OpeningHour steamTuesday = new OpeningHour
            {
                Id = Guid.NewGuid(),
                ServiceProviderId = steamServiceProvider.Id,
                SlotCount = 8,
                Weekday = Weekday.Tuesday
            };
            steamOpeningHours.Add(steamTuesday);
            context.OpeningHours.AddRange(steamOpeningHours);

            context.SaveChanges();
        }
    }
}
