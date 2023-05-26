// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Models.Locations;
using CashOverflow.Ddemo.Models.Locations.Exceptions;

namespace CashOverflow.Ddemo.Services.Foundations.Locations
{
    public partial class LocationService
    {
        private delegate ValueTask<Location> ReturningLocationFunction();

        private async ValueTask<Location> TryCatch(ReturningLocationFunction returningLocationFunction)
        {
            try 
            {
                return await returningLocationFunction();
            }
            catch(NullLocationException innerException)
            {
                throw CreateAndLogValidationException(innerException);
            }
        }

        private LocationValidationException CreateAndLogValidationException(NullLocationException innerException)
        {
            var locationValidationException = new LocationValidationException(innerException);
            this.loggingBroker.LogError(locationValidationException);

            return locationValidationException;
        }
    }
}
