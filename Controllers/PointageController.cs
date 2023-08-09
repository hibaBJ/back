using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AxiaBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PointageController : ControllerBase
    {
        private readonly IPointageService _IPointageService;
        public PointageController(IPointageService prIPointageService)
        {
            _IPointageService = prIPointageService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Pointage> lResult = _IPointageService.GetAll();
            return Ok(lResult);
        }
        [HttpGet]
        public IActionResult Search(string prName)
        {
            List<Pointage> lResult = _IPointageService.GetByName(prName);
            return Ok(lResult);
        }
        [HttpPut]
        public IActionResult Update(Pointage prPointage)
        {
            return Ok(_IPointageService.Update(prPointage));
        }
        [HttpPost]
        public IActionResult Save(Pointage prPointage)
        {
            return Ok(_IPointageService.Save(prPointage));
        }
        [HttpDelete]
        public IActionResult Delete(Pointage prPointage)
        {
            _IPointageService.Delete(prPointage.CbMarq);
            return Ok();
        }
    }
}
