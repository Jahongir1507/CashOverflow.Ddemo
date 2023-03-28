// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Models.Jobs;
using Microsoft.EntityFrameworkCore;

namespace CashOverflow.Ddemo.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Job> Job { get; set; }

        public async ValueTask<Job> InsertJobAsync(Job job) =>
            await InsertAsync(job);

        public IQueryable<Job> SelectAllJobs() =>
            SelectAll<Job>();

        public async ValueTask<Job> SelectJobByIdAsync(Guid jobId) =>
            await SelectAsync<Job>(jobId);

        public async ValueTask<Job> UpdateJobAsync(Job job) =>
            await UpdateAsync(job);

        public async ValueTask<Job> DeleteJobAsync(Job job) =>
            await DeleteAsync<Job>(job);
    }
}
