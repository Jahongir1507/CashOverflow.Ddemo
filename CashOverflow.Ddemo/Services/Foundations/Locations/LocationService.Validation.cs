// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Models.Locations.Exceptions;
using CashOverflow.Ddemo.Models.Locations;

namespace CashOverflow.Ddemo.Services.Foundations.Locations
{
    public partial class LocationService
    {
        private static void ValidateLocationNotNull(Location location)
        {
            if (location == null)
            {
                throw new NullLocationException();
            }
        }
    }
}
