﻿// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Models.Locations;

namespace CashOverflow.Ddemo.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Location> InsertLocationAsync(Location location);
        IQueryable<Location> SelectAllLocations();
        ValueTask<Location> SelectLocationByIdAsync(Guid locationId);
        ValueTask<Location> UpdateLocationAsync(Location location);
        ValueTask<Location> DeleteLocationAsync(Location location);
    }
}
