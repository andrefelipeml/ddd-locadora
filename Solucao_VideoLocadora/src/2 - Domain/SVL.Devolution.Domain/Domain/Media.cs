using SVL.Domain.Base;
using System;

namespace SVL.Domain.Devolution
{
    public class Media : BaseEntity
    {
        private DateTime _date;

        private DateTime Date { get => _date; set => _date = value; }
    }
}
