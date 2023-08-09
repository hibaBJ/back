using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;
using AxiaBackend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AxiaBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GroupeController : ControllerBase
    {
        private readonly IGroupeService _IGroupeService;
        public GroupeController(IGroupeService prIGroupeService)
        {
            _IGroupeService = prIGroupeService;
        }
        [HttpGet]

        public IActionResult GetAll()
        {
            List<Groupe> lResult = _IGroupeService.GetAll();
            return Ok(lResult);
        }
        [HttpGet]
        public IActionResult Search(string prName) {
            List<Groupe> lResult = _IGroupeService.GetByName(prName);
            return Ok(lResult);
        }
        [HttpPut]
        public IActionResult Update (Groupe prGroupe)
        {
            return Ok(_IGroupeService.Update(prGroupe));
        }
        [HttpPost]
        public IActionResult Save(Groupe prGroupe)
        {
            return Ok (_IGroupeService.Save(prGroupe));
        }
        [HttpDelete]
        public IActionResult Delete(Groupe prGroupe) 
        {
            _IGroupeService.Delete(prGroupe.CbMarq);
            return Ok();
        }
    }
}
