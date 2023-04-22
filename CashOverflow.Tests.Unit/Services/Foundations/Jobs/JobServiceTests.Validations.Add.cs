// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Models.Jobs;
using CashOverflow.Ddemo.Models.Jobs.Exceptions;
using FluentAssertions;
using Moq;
using Xunit;

namespace CashOverflow.Tests.Unit.Services.Foundations.Jobs
{
    public partial class JobServiceTests
    {
        [Fact]
        public async Task ShouldThrowValidationExceptionOnAddIfInputIsNullAndLogItAsync()
        {
            // given
            Job nullJob = null;
            var nullJobException = new NullJobexception();

            var expectedJobValidationException =
                new JobValidationException(nullJobException);

            // when
            ValueTask<Job> addJobTask =
                this.jobService.AddJobAsync(nullJob);

            JobValidationException actualJobValidationException =
                await Assert.ThrowsAsync<JobValidationException>(addJobTask.AsTask);

            // then
            actualJobValidationException.Should().BeEquivalentTo(expectedJobValidationException);

            this.storageBrokerMock.Verify(broker =>
                broker.InsertJobAsync(It.IsAny<Job>()), Times.Never);

            this.storageBrokerMock.VerifyNoOtherCalls();
        }
    }
}
