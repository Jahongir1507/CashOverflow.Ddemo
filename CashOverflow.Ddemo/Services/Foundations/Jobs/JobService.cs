// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Brokers.Storages;
using CashOverflow.Ddemo.Models.Jobs;

namespace CashOverflow.Ddemo.Services.Foundations.Jobs
{
    public class JobService : IJobService
    {
        private readonly IStorageBroker storageBroker;

        public JobService(
            IStorageBroker storageBroker)
        {
            this.storageBroker = storageBroker;
        }

        public async ValueTask<Job> AddJobAsync(Job job) =>
            await this.storageBroker.InsertJobAsync(job);
       

        public ValueTask<Job> ModifyJobAsync(Job job)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Job> RemoveJobByIdAsync(Guid jobId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Job> RetrieveAllJobs(Job job)
        {
            throw new NotImplementedException();
        }

        public ValueTask<Job> RetrieveJobByIdAsync(Guid jobId)
        {
            throw new NotImplementedException();
        }
    }
}
