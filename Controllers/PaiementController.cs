using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AxiaBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PaiementController : ControllerBase
    {
        private readonly IPaiementService _IPaiementService;
        public PaiementController(IPaiementService prIPaiementService)
        {
            _IPaiementService = prIPaiementService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Paiement> lResult = _IPaiementService.GetAll();
            return Ok(lResult);
        }
        [HttpGet]
        public IActionResult Search(string prName)
        {
            List<Paiement> lResult = _IPaiementService.GetByName(prName);
            return Ok(lResult);
        }
        [HttpPut]
        public IActionResult Update(Paiement prPaiement) 
        {
            return Ok(_IPaiementService.Update(prPaiement));
        }
        [HttpPost]
        public IActionResult Save(Paiement prPaiement)
        {
            return Ok(_IPaiementService.Save(prPaiement));
        }
        [HttpDelete]
        public IActionResult Delete(Paiement prPaiement) 
        {
            _IPaiementService.Delete(prPaiement.CbMarq);
            return Ok();
        }
    }
}
