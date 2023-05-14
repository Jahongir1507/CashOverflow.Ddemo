// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Brokers.Loggings;
using CashOverflow.Ddemo.Brokers.Storages;
using CashOverflow.Ddemo.Models.Locations;
using CashOverflow.Ddemo.Services.Foundations.Locations;
using Moq;
using Tynamix.ObjectFiller;

namespace CashOverflow.Tests.Unit.Services.Foundations.Locations
{
    public partial class LocationServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly Mock<ILoggingBroker> loggingBrokerMock;
        private readonly ILocationService locationService;

        public LocationServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();
            this.loggingBrokerMock = new Mock<ILoggingBroker>();

            this.locationService = new LocationService(
                storageBroker: this.storageBrokerMock.Object,
                loggingBroker: this.loggingBrokerMock.Object
                );
        }

        private DateTimeOffset GetRandomDateTimeOffset() =>
            new DateTimeRange(earliestDate: DateTime.UnixEpoch).GetValue();

        private Location CreateRandomLocation(DateTimeOffset dateTimeOffset) =>
            CreateLocationFiller(GetRandomDateTimeOffset()).Create();


        private Filler<Location> CreateLocationFiller(DateTimeOffset dates)
        {
            var filler = new Filler<Location>();

            filler.Setup()
                .OnType<DateTimeOffset>().Use(dates);

            return filler;
        }
    }
}
