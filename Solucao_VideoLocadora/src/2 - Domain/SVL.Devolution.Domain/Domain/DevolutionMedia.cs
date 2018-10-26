using SVL.Domain.Base;
using System;

namespace SVL.Domain.Devolution
{
    public class DevolutionMedia : BaseEntity
    {
        private int Id;
        public DateTime DevolutionDate { get; private set; }
        public Boolean Rewound { get; private set; }
        public Boolean isRelease { get; private set; }
    }
}
