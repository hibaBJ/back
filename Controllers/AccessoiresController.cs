using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;
using AxiaBackend.Pages;
using AxiaBackend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AxiaBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AccessoiresController : ControllerBase
    {
        private readonly IAccessoireService _IAccessoiresService;
        public AccessoiresController( IAccessoireService prIAccessoiresService)
        {
            _IAccessoiresService=prIAccessoiresService;
        }
        [HttpGet]
       
        public IActionResult GetAll()
        {
            List<Accessoires> lResult = _IAccessoiresService.GetAll();
            return Ok(lResult);
        }
        [HttpGet]
        public IActionResult Search(string  prName)
        {
            List<Accessoires> lResult = _IAccessoiresService.GetByName(prName);
            return Ok(lResult);
        }
        [HttpPut]
        public IActionResult Update(Accessoires prAccessoires)
        {
            return Ok(_IAccessoiresService.Update(prAccessoires));
        }
        [HttpPost]
        public IActionResult Save(Accessoires prAccessoires)
        {
            return Ok(_IAccessoiresService.Save(prAccessoires));
        }
        [HttpDelete]
        public IActionResult Delete(Accessoires prAccessoires)
        {
            _IAccessoiresService.Delete(prAccessoires.CbMarq);
            return Ok();

        }
    }
}
