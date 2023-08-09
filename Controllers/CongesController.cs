using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;
using AxiaBackend.View;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AxiaBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CongesController : ControllerBase
    {
        private readonly ICongesService _ICongesService;
        public CongesController(ICongesService prICongesService)
        {
          _ICongesService = prICongesService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<ViewConge> lResult = _ICongesService.GetAll();
            return Ok(lResult);
        }
        [HttpGet]
        public IActionResult Search (string prName)
        {
            List<Conges> lResult = _ICongesService.GetByName(prName);
            return Ok(lResult);
        }
        [HttpPut]
        public IActionResult Update(Conges prConge) 
        {
            return Ok(_ICongesService.Update(prConge));
        }
        [HttpPost]
        public IActionResult Save (Conges prConge) 
        {
            return Ok(_ICongesService.Save(prConge));        
        }
        [HttpDelete]
        public IActionResult Delete (Conges prConges) 
        {
            _ICongesService.Delete(prConges.CbMarq);
            return Ok();
        }
    }
}
