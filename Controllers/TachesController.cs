using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AxiaBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TachesController : ControllerBase
    {
        private readonly ITacheService _ITacheService;
        public TachesController(ITacheService prITacheService)
        {
            _ITacheService = prITacheService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Taches> lResult = _ITacheService.GetAll();
            return Ok(lResult);
        }
        [HttpGet]
        public IActionResult Search(string prName)
        {
            List<Taches> lResult = _ITacheService.GetByName(prName);
            return Ok(lResult);
        }
        [HttpPut]
        public IActionResult Update(Taches prTache)
        {
            return Ok(_ITacheService.Update(prTache));
        }
        [HttpPost]
        public IActionResult Save (Taches prTache)
        {
            return Ok(_ITacheService.Save(prTache));
        }
        [HttpDelete]
        public IActionResult Delete(Taches prTaches)
        {
            _ITacheService.Delete(prTaches.CbMarq);
            return Ok();
        }
    }
}
