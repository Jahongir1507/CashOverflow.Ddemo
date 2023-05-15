// --------------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineer
// Developed by CashOverflow Jahongir
// --------------------------------------------------------

using Xeptions;

namespace CashOverflow.Ddemo.Models.Locations.Exceptions
{
    public class NullLocationException : Xeption
    {
        public NullLocationException()
            : base(message: "Location is null.")
        {}
    }
}
