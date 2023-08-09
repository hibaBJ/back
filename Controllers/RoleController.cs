using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;
using AxiaBackend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AxiaBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _IRoleService;
        public RoleController(IRoleService prIRoleService)
        {
            _IRoleService = prIRoleService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Role> lResult = _IRoleService.GetAll();
            return Ok(lResult);
        }
        [HttpGet]
        public IActionResult Search(string prName)
        {
            List<Role> lResult = _IRoleService.GetByName(prName);
            return Ok(lResult);
        }
        [HttpPut]
        public IActionResult Update(Role prRole)
        {
            return Ok (_IRoleService.Update(prRole));
        }
        [HttpPost]
        public IActionResult Save (Role prRole) 
        {
            return Ok(_IRoleService.Save(prRole));  
        }
        [HttpDelete]
        public IActionResult Delete(Role prRole)
        {
            _IRoleService.Delete(prRole.CbMarq);
            return Ok();
        }
    }
}
