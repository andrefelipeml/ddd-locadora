using SVL.Domain.Base.Domain.Enum;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SVL.Domain.Base
{

    public class Customer : Person
    {
        public Customer()
        {

        }

        private string _cpf;
        private ICollection<Contato> _contatos;
        private ICollection<Address> _addresses;

        /// <summary>
        /// CPF
        /// </summary>
        public string Cpf { get => _cpf; set => _cpf = value; }

        /// <summary>
        ///  Significa que o Cliente pode ter uma lista de Contatos
        /// </summary>
        public ICollection<Contato> Contatos { get => _contatos; set => _contatos = value; }

        /// <summary>
        /// Cliente pode ter N Endereços
        /// </summary>
        public ICollection<Address> Addresses { get => _addresses; set => _addresses = value; }

    }
}
