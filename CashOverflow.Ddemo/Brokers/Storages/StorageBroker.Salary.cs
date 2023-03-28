// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Models.Salaries;
using Microsoft.EntityFrameworkCore;

namespace CashOverflow.Ddemo.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Salary> Salary { get; set; }

        public async ValueTask<Salary> InsertSalaryAsync(Salary salary) =>
            await InsertAsync(salary);

        public IQueryable<Salary> SelectAllSalaries() =>
            SelectAll<Salary>();

        public async ValueTask<Salary> SelectSalaryByIdAsync(Guid salaryId) =>
            await SelectAsync<Salary>(salaryId);
    }
}
