
namespace SVL.AplicationCore.Domain
{
    public class Credits : BaseEntity
    {
        private Customer _customer;
        private int _creditPoints;

        /// <summary>
        /// Id do Cliente
        /// </summary>
        public int CustomerID { get; set; }

        public virtual Customer Customer { get => _customer; set => _customer = value; }

        /// <summary>
        /// Total de Creditos do Cliente
        /// </summary>
        public int CreditPoints { get => _creditPoints; set => _creditPoints = value; }


    }
}
