﻿// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using System.Reflection.Metadata.Ecma335;
using CashOverflow.Ddemo.Brokers.Loggings;
using CashOverflow.Ddemo.Brokers.Storages;
using CashOverflow.Ddemo.Models.Locations;

namespace CashOverflow.Ddemo.Services.Foundations.Locations
{
    public class LocationService : ILocationService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public LocationService(
                IStorageBroker storageBroker,
                ILoggingBroker loggingBroker)
        {
            this.storageBroker = storageBroker;
            this.loggingBroker = loggingBroker;
        }

        public async ValueTask<Location> AddLocationAsync(Location location) =>
            await this.storageBroker.InsertLocationAsync(location);
    }
}