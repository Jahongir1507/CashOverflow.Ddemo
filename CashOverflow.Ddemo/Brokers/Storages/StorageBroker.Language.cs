// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Models.Languages;
using Microsoft.EntityFrameworkCore;

namespace CashOverflow.Ddemo.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Language> Language { get; set; }
    }
}
