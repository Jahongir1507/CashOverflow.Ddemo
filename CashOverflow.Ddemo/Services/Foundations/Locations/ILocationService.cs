// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Models.Locations;

namespace CashOverflow.Ddemo.Services.Foundations.Locations
{
    public interface ILocationService
    {
        ValueTask<Location> AddLocationAsync(Location location);
    }
}
