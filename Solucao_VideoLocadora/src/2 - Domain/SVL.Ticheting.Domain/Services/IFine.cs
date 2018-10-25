using SVL.AplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SVL.Ticketing.Domain.Services
{
    public interface IFine
    {
        void Apply(Media media, DateTime date);
    }
}
