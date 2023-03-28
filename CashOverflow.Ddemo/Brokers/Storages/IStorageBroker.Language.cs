// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using CashOverflow.Ddemo.Models.Languages;

namespace CashOverflow.Ddemo.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Language> InsertLanguageAsync(Language language);
        IQueryable<Language> SelectAllLanguages();
        ValueTask<Language> SelectLanguageByIdAsync(Guid languageId);
        ValueTask<Language> UpdateLanguageAsync(Language language);
        ValueTask<Language> DeleteLanguageAsync(Language language);
    }
}
