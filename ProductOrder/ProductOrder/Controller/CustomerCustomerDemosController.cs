﻿
using Microsoft.AspNetCore.Mvc;

namespace ProductOrder.Controller
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerCustomerDemosController : ControllerBase
    {
        private readonly Interfaces.IUnitOfWork _unitOfWork;

        public CustomerCustomerDemosController(Interfaces.IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var customerCustomerDemo = _unitOfWork.CustomerCustomerDemoRepository.GetAll();
            return new JsonResult(customerCustomerDemo);
        }
        [HttpPost]
        public IActionResult Insert([FromBody] Models.CustomerCustomerDemo customerCustomerDemo)
        {
            _unitOfWork.CustomerCustomerDemoRepository.Insert(customerCustomerDemo);
            _unitOfWork.Complete();
            return new JsonResult(customerCustomerDemo);
        }
        [HttpPut]
        public IActionResult Update([FromBody] Models.CustomerCustomerDemo customerCustomerDemo)
        {
            _unitOfWork.CustomerCustomerDemoRepository.Update(customerCustomerDemo);
            _unitOfWork.Complete();
            return new JsonResult(customerCustomerDemo);

        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _unitOfWork.CustomerCustomerDemoRepository.Delete(id);
            _unitOfWork.Complete();
            return new JsonResult("ok");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var customerCustomerDemo = _unitOfWork.CustomerCustomerDemoRepository.GetById(id);
            return new JsonResult(customerCustomerDemo);
        }
    }
}