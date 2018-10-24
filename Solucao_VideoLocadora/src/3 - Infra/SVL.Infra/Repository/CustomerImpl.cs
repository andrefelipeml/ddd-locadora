﻿using SVL.AplicationCore.Interfaces.Repository;
using SVL.AplicationCore.Repository;
using SVL.AplicationCore.Domain;
using SVL.Infra.Data;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// Repositorio especializado, herda de EFRepository
/// Implementa Interface ICustomerRepository
/// Caso queira criar um metodo especializado esta seria a classe
/// </summary>
namespace SVL.Infra.Repository
{
    public class EFCustomerRepository : EFRepository<Customer>, ICustomerRepository 
    {
        public EFCustomerRepository(BaseContexto baseContexto) : base(baseContexto)
        {

        }

        /// <summary>
        /// Implementando Classe especializada de Cliente
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns></returns>
        public IEnumerable<Customer> GetAdress(int CustomerId)
        {
            return _baseContexto.customers.Where(p => p.ID == CustomerId);

        }

        public IEnumerable<Customer> GetContacts(int CustomerId)
        {
            //TODO rever pois a lista de contatos deve estar no Repository de Contatos
            //return _baseContexto.contatos.Where(c => c.CustomerId == CustomerId);
            return null;
        }

        public IEnumerable<Customer> GetDepentents(int CustomerId)
        {
            return null;
        }
    }
}