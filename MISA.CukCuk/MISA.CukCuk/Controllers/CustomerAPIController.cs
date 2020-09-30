﻿using MISA.Entities;
using Microsoft.AspNetCore.Mvc;
using MISA.Service.Dictionary;
using System.Collections.Generic;

namespace MISA.CukCuk.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerAPIController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomerAPIController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [Route("")]
        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return _customerService.GetCustomers();
        }

        [Route("{code}")]
        [HttpGet]
        public Customer GetCustomer([FromRoute]string code)
        {
            return _customerService.GetCustomerByCode(code);
        }

        [Route("")]
        [HttpPost]
        public int SaveCustomer([FromBody] Customer customer)
        {
            return _customerService.AddCustomer(customer);
        }

        /// <summary>
        /// Hàm update cusstomer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [Route("")]
        [HttpPut]
        public int UpdateCustomer([FromBody] Customer customer)
        {
            return _customerService.UpdateCustomer(customer);
        }

        [Route("{code}")]
        [HttpDelete]
        public int DeleteCustomer([FromRoute]string code)
        {
            return _customerService.DeleteCustomer(code);
        }
    }
}