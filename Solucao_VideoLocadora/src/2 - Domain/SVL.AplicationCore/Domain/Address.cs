using SVL.AplicationCore.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SVL.AplicationCore.Domain
{
    /// <summary>
    ///     bairro: "Tijuca",
    ///     logradouro: "Rua Garibaldi",
    ///     cep: "20511330",
    ///     uf: "RJ",
    ///     localidade: "Rio de Janeiro"
    /// </summary>
    public class Address : BaseEntity
    {
        private int _CustomerId;
        private Customer _Customer;
        private string _cep;
        private string _streetDescription;
        private string _city;
        private string _district;
        private string _state;

        /// <summary>
        /// CEP
        /// </summary>
        [Required(ErrorMessage = "O Cep é obrigatório", AllowEmptyStrings = false)]
        [StringLength(15, ErrorMessage = "O CEP não pode ser maior que 15 caracteres.")]
        [DataType(DataType.Text)]
        [RegularExpression("^d{5}-d{3}$",
        ErrorMessage = "Cep Inválido, favor verificar.")]
        public string Cep { get => _cep; set => _cep = value; }
        /// <summary>
        /// Descrição Rua
        /// </summary>
        [Required(ErrorMessage = "Descrição do Logradouro é obrigatório", AllowEmptyStrings = false)]
        [StringLength(150, ErrorMessage = "O Logradouro não pode ser maior que 150 caracteres.")]
        public string StreetDescription { get => _streetDescription; set => _streetDescription = value; }
        /// <summary>
        /// bairro
        /// </summary>
        public string District { get => _district; set => _district = value; }
        /// <summary>
        /// Cidade
        /// </summary>
        public string City { get => _city; set => _city = value; }
        /// <summary>
        /// Estado
        /// </summary>
        public string State { get => _state; set => _state = value; }
        /// <summary>
        /// Significa que este Endereço pertence a um Cliente
        /// </summary>
        [ForeignKey("Customer")]
        public int CustomerId { get => _CustomerId; set => _CustomerId = value; }
        public Customer Customer { get => _Customer; set => _Customer = value; }

    }
}
