using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.Service.Validators;
using SVL.Domain.Location;
using SVL.AplicationCore.Interfaces.Repository;
using SVL.AplicationCore.Interfaces.Services;
using SVL.Service.Services;

/// <summary>
/// Controller classe resposnável em conversar com BackEnd e retornar as informações solicitadas
/// </summary>
namespace Modelo.Application.Controllers
{
    [Produces("application/json")]
    [Route("api/Cliente")]
    public class CustomerController : Controller
    {
        private ICustomerServices _customerServices;

        public IActionResult Post([FromBody] Customer customer)
        {
            this._customerServices = new CustomerService();

            try
            {
                _customerServices.Add(customer);

                return new ObjectResult(customer.ID);
            }
            catch(ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        public IActionResult Put([FromBody] Customer customer)
        {
            try
            {
                _customerServices.Add(customer);

                return new ObjectResult(customer);
            }
            catch(ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        public IActionResult Delete([FromBody] Customer customer)
        {
            try
            {
                _customerServices.Delete(customer);

                return new NoContentResult();
            }
            catch(ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(_customerServices.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(_customerServices.GetId(id));
            }
            catch(ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}