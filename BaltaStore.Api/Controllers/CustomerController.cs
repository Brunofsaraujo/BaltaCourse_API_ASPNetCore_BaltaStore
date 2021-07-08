using BaltaStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;
using BaltaStore.Domain.StoreContext.Commands.CustomerCommands.Outputs;
using BaltaStore.Domain.StoreContext.Entities;
using BaltaStore.Domain.StoreContext.Handlers;
using BaltaStore.Domain.StoreContext.Queries;
using BaltaStore.Domain.StoreContext.Repositories;
using BaltaStore.Shared.Commands;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace BaltaStore.Api.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly CustomerHandler _handler;

        public CustomerController(
            ICustomerRepository customerRepository,
            CustomerHandler handler)
        {
            _customerRepository = customerRepository;
            _handler = handler;
        }

        [HttpGet]
        [Route("v1/customers")]
        // Examplo uso cache: [ResponseCache(Location = ResponseCacheLocation.Client, Duration = 60)]
        public IEnumerable<ListCustomerQueryResult> Get()
        {
            return _customerRepository.Get();
        }

        [HttpGet]
        [Route("v1/customers/{id}")]
        public GetCustomerQueryResult GetById(Guid id)
        {
            return _customerRepository.Get(id);
        }

        [HttpGet]
        [Route("v1/customers/{id}/orders")]
        public IEnumerable<ListCustomerOrdersQueryResult> GetOrders(Guid id)
        {
            return _customerRepository.GetOrders(id);
        }

        [HttpPost]
        [Route("v1/customers")]
        public ICommandResult Post([FromBody] CreateCustomerCommand command)
        {
            return (CreateCustomerCommandResult)_handler.Handle(command);
        }

        [HttpPut]
        [Route("v1/customers/{id}")]
        public Customer Put([FromBody] Customer customer)
        {
            return null;
        }

        [HttpDelete]
        [Route("v1/customers/{id}")]
        public string Delete()
        {
            return null;
        }
    }
}