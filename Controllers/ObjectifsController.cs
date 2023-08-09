using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AxiaBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ObjectifsController : ControllerBase
    {
        public readonly IObjectifsService _IObjectifsService;
        public ObjectifsController(IObjectifsService prIObjectifsService)
        {
            _IObjectifsService = prIObjectifsService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Objectifs> lResult = _IObjectifsService.GetAll();
            return Ok(lResult);
        }
        [HttpGet]
        public IActionResult Search(string prName)
        {
            List<Objectifs> lResult = _IObjectifsService.GetByName(prName);
            return Ok(lResult);
        }
        [HttpPut]
        public IActionResult Update(Objectifs prObjectifs) 
        {
            return Ok(_IObjectifsService.Update(prObjectifs));
        }
        [HttpPost]
        public IActionResult Save(Objectifs prObjectifs)
        {
            return Ok(_IObjectifsService.Save(prObjectifs));
        }
        [HttpDelete]
        public IActionResult Delete(Objectifs prObjectifs) 
        {
            _IObjectifsService.Delete(prObjectifs.CbMarq);

            return Ok();
        }
    }
}
