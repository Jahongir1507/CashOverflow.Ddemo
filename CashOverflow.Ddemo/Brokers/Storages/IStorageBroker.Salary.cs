// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using System.Security.Principal;
using CashOverflow.Ddemo.Models.Salaries;

namespace CashOverflow.Ddemo.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Salary> InsertSalaryAsync(Salary salary);
        IQueryable<Salary> SelectAllSalaries();
        ValueTask<Salary> SelectSalaryByIdAsync(Guid salaryId);
    }
}
