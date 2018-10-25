using SVL.AplicationCore.Domain;
using System;

namespace SVL.Devolution.Domain
{
    public class Media : BaseEntity
    {
        private DateTime _date;

        private DateTime Date { get => _date; set => _date = value; }
    }
}
