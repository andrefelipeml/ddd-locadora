﻿
namespace SVL.AplicationCore.Domain
{
    public class Wallet : BaseEntity
    {
        private Customer _customer;
        private int _creditPoints;

        /// <summary>
        /// Id do Cliente
        /// </summary>
        public int CustomerID { get; set; }

        /// <summary>
        /// Total de Creditos do Cliente
        /// </summary>
        public int CreditPoints { get => _creditPoints; set => _creditPoints = value; }


    }
}