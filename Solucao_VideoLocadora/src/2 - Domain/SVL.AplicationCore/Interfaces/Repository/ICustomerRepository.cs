﻿using SVL.AplicationCore.Domain;
using System.Collections.Generic;

/// <summary>
/// Interface Customer que herda de IRepository genérico
/// Segregando a informação 
/// </summary>
namespace SVL.AplicationCore.Interfaces.Repository
{
    /// <summary>
    /// ICustomerRepository implementa IRepository
    /// </summary>
    public interface ICustomerRepository : IRepository<Customer>
    {
        /// <summary>
        /// Metodo especifico que retorna todos os contatos do Cliente
        /// </summary>
        /// <returns></returns>
        IEnumerable<Customer> GetContacts(int CustomerId);

        /// <summary>
        /// Metodo especifico que retorna todos os Endereços do Cliente
        /// </summary>
        /// <returns></returns>
        IEnumerable<Customer> GetAdress(int CustomerId);


    }
}