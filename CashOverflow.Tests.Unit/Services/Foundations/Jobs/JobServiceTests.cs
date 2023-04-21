// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Brokers.Storages;
using CashOverflow.Ddemo.Models.Jobs;
using CashOverflow.Ddemo.Services.Foundations.Jobs;
using Moq;
using Tynamix.ObjectFiller;

namespace CashOverflow.Tests.Unit.Services.Foundations.Jobs
{
    public partial class JobServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly IJobService jobService;

        public JobServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();

            this.jobService = new JobService(
                storageBroker: this.storageBrokerMock.Object
            );
        }

        private DateTimeOffset GetRandomDateTime() =>
            new DateTimeRange(earliestDate: DateTime.UnixEpoch).GetValue();

        private Job CreateRandomJob(DateTimeOffset dates) =>
            CreateJobFiller(GetRandomDateTime()).Create();

        private Filler<Job> CreateJobFiller(DateTimeOffset dates)
        {
            var filler = new Filler<Job>();

            filler.Setup().
                OnType<DateTimeOffset>().Use(dates);

            return filler;
        }
    }
}
