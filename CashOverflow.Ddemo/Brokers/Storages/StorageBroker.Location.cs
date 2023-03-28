// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Models.Locations;
using Microsoft.EntityFrameworkCore;

namespace CashOverflow.Ddemo.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Location> Location { get; set; }

        public async ValueTask<Location> InsertLocationAsync(Location location) =>
            await InsertAsync(location);

        public async ValueTask<Location> SelectLocationByIdAsync(Guid locationId) =>
            await SelectAsync<Location>(locationId);

        public IQueryable<Location> SelectAllLocations() => SelectAll<Location>();

        public async ValueTask<Location> UpdateLocationAsync(Location location) =>
            await UpdateAsync<Location>(location);

        public async ValueTask<Location> DeleteLocationAsync(Location location) =>
            await DeleteAsync<Location>(location);
    }
}
