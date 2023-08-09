using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AxiaBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _IEmployeeService;
        public EmployeeController(IEmployeeService prIEmployeeService)
        {
            _IEmployeeService = prIEmployeeService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Employee> lResult = _IEmployeeService.GetAll();
            return Ok(lResult);
        }
        [HttpGet]
        public IActionResult Search(string prName)
        {
            List<Employee> lResult = _IEmployeeService.GetByName(prName);
            return Ok(lResult);
        }
        [HttpPut]
        public IActionResult Update(Employee prEmployee)
        {
            return Ok(_IEmployeeService.Update(prEmployee));
        }
        [HttpPost]
        public IActionResult Save(Employee prEmployee)
        {
            return Ok(_IEmployeeService.Save(prEmployee));
        }
        [HttpDelete]
        public IActionResult Delete(Employee prEmployee) 
        {
            _IEmployeeService.Delete(prEmployee.CbMarq);
            return Ok();
        }
    }
}
