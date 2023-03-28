// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Models.Jobs;

namespace CashOverflow.Ddemo.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Job> InsertJobAsync(Job job);
        IQueryable<Job> SelectAllJobs();
        ValueTask<Job> SelectJobByIdAsync(Guid jobId);
        ValueTask<Job> UpdateJobAsync(Job job);
        ValueTask<Job> DeleteJobAsync(Job job);
    }
}
