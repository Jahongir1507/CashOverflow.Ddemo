// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using Xeptions;

namespace CashOverflow.Ddemo.Models.Locations.Exceptions
{
    public class LocationValidationException : Xeption
    {
        public LocationValidationException(Xeption innerException)
            : base(message: "Location validation exception error occurred, fix error and try again.", innerException)
        {}
    }
}
