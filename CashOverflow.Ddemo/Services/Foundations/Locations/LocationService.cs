// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Brokers.Loggings;
using CashOverflow.Ddemo.Brokers.Storages;
using CashOverflow.Ddemo.Models.Locations;
using CashOverflow.Ddemo.Models.Locations.Exceptions;

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

        public async ValueTask<Location> AddLocationAsync(Location location)
        {
            try
            {
                if (location == null)
                {
                    throw new NullLocationException();
                }
                return await this.storageBroker.InsertLocationAsync(location);
            }
            catch (NullLocationException nullLocationException)
            {
                var locationValidationException = new LocationValidationException(nullLocationException);
                this.loggingBroker.LogError(locationValidationException);

                throw locationValidationException;
            }
        }
    }
}
