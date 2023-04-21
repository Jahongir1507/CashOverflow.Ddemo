// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Models.Jobs;
using FluentAssertions;
using Force.DeepCloner;
using Moq;
using Xunit;

namespace CashOverflow.Tests.Unit.Services.Foundations.Jobs
{
    public partial class JobServiceTests
    {
        [Fact]
        public async Task ShouldAddJabAsync()
        {
            // given
            DateTimeOffset dateTimeOffset = GetRandomDateTime();
            Job randomJob = CreateRandomJob(dateTimeOffset);
            Job inputJob = randomJob;
            Job persistedJob = inputJob;
            Job expectedJob = persistedJob.DeepClone();

            this.storageBrokerMock.Setup(broker =>
                broker.InsertJobAsync(inputJob)).ReturnsAsync(persistedJob);

            // when
            Job actualJob = await this.jobService
                .AddJobAsync(inputJob);

            // then
            actualJob.Should().BeEquivalentTo(expectedJob);

            this.storageBrokerMock.Verify(broker =>
                broker.InsertJobAsync(inputJob), Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
