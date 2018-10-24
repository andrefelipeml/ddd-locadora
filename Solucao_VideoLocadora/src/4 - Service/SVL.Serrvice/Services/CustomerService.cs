using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SVL.AplicationCore.Domain;
using SVL.AplicationCore.Interfaces.Repository;
using SVL.AplicationCore.Interfaces.Services;

namespace SVL.Service.Services
{
    public class CustomerService : ICustomerServices
    {
        private readonly ICustomerRepository _CustomerRepository;

        public CustomerService(ICustomerRepository CustomerRepositoty)
        {
            _CustomerRepository = CustomerRepositoty;

        }

        public Customer Add(Customer entity)
        {
            //TODO aqui posso adicionar as regras de negocio antes de salvar
            return _CustomerRepository.Add(entity);

        }

        public void Delete(Customer entity)
        {
            _CustomerRepository.Delete(entity);
        }

        public IEnumerable<Customer> GetAll()
        {
            return _CustomerRepository.GetAll();
        }

        public IEnumerable<Customer> GetBy(Expression<Func<Customer, bool>> predicado)
        {
            return _CustomerRepository.GetBy(predicado);
        }

        public Customer GetId(int id)
        {
            return _CustomerRepository.GetId(id);
        }

        public void Update(Customer entity)
        {
            _CustomerRepository.Update(entity);
        }

        IEnumerable<Customer> ICustomerServices.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
