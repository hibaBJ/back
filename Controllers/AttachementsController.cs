using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;
using AxiaBackend.Pages;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AxiaBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AttachementsController : ControllerBase
    {
        private readonly IAttachementService _IAttachementService;
        public AttachementsController(IAttachementService prIAttachementService)
        {
            _IAttachementService = prIAttachementService;
        }

        [HttpPost, DisableRequestSizeLimit]
        public async Task<IActionResult> UploadFile()
        {
            try
            {
                var formCollection = await Request.ReadFormAsync();
                var file = formCollection.Files.First();
                string LastPath = _IAttachementService.Upload(file);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.Message);
            }
            
            return Ok(true);

        }


        [HttpGet]
        public IActionResult GetAll()
        {
            List<Attachements> lResult = _IAttachementService.GetAll();
            return Ok(lResult);
        }
        [HttpGet]
        public IActionResult Search(string prName)
        {
            List<Attachements> lResult = _IAttachementService.GetByName(prName);
            return Ok(lResult);
        }
        [HttpPut]
        public IActionResult Update(Attachements prAttachements)
        {
            return Ok(_IAttachementService.Update(prAttachements));
        }
        [HttpPost]
        public IActionResult Save(Attachements prAttachements)

        {
            return Ok(_IAttachementService.Save(prAttachements));
        }
        [HttpDelete]
        public IActionResult Delete(Attachements prAttachements) 
        {
            _IAttachementService.Delete(prAttachements.CbMarq);
            return Ok();
        
        }
    }
}
