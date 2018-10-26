using SVL.Domain.Base;
using SVL.Domain.Wallet.Domain;
using System.Collections.Generic;

namespace SVL.Domain.Location
{
    public class Wallet : BaseEntity
    {
        private int _creditPoints;

        /// <summary>
        /// Id do Cliente
        /// </summary>
        public int CustomerID { get; protected set; }
        /// <summary>
        /// Total de Creditos do Cliente
        /// </summary>
        public int CreditPoints { get => _creditPoints; protected set => _creditPoints = value; }
        public ICollection<History> histories { get; protected set; }


    }
}
