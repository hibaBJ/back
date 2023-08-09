using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AxiaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TypeCongesController : ControllerBase
    {
        private readonly ITypeCongesService _ITypeCongesService;
        public TypeCongesController(ITypeCongesService prITypeCongesService)
        {
            _ITypeCongesService = prITypeCongesService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<TypeConges> lResult = _ITypeCongesService.GetAll();
            return Ok(lResult);
        }
        [HttpPost]
        public IActionResult Save(TypeConges prTypeConges)
        {
            return Ok(_ITypeCongesService.Save(prTypeConges));
        }
        [HttpDelete]
        public IActionResult Delete(TypeConges prTypeConges)
        {
            _ITypeCongesService.Delete(prTypeConges);
            return Ok();

        }
    }
}
