// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Models.Languages;
using CashOverflow.Ddemo.Models.Locations;
using Microsoft.EntityFrameworkCore;

namespace CashOverflow.Ddemo.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Language> Language { get; set; }

        public async ValueTask<Language> InsertLanguageAsync(Language language) =>
            await InsertAsync(language);

        public async ValueTask<Language> SelectLanguageByIdAsync(Guid languageId) =>
            await SelectAsync<Language>(languageId);

        public IQueryable<Language> SelectAllLanguages() =>
            SelectAll<Language>();

        public async ValueTask<Language> UpdateLanguageAsync(Language language) =>
            await UpdateAsync<Language>(language);

        public async ValueTask<Language> DeleteLanguageAsync(Language language) =>
            await DeleteAsync<Language>(language);
    }
}
