// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Models.Jobs;

namespace CashOverflow.Ddemo.Services.Foundations.Jobs
{
    public interface IJobService
    {
        ValueTask<Job> AddJobAsync(Job job);
        IQueryable<Job> RetrieveAllJobs(Job job);
        ValueTask<Job> RetrieveJobByIdAsync(Guid jobId);
        ValueTask<Job> ModifyJobAsync(Job job);
        ValueTask<Job> RemoveJobByIdAsync(Guid jobId);
    }
}
