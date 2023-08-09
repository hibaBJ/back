using AxiaBackend.Interfaces;
using AxiaBackend.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AxiaBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LogController : ControllerBase
    {
        private readonly ILogService _ILogService;
        public LogController(ILogService prILogService)
        {
            _ILogService = prILogService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Log> lResult = _ILogService.GetAll();
            return Ok(lResult);
        }
        [HttpGet]
        public IActionResult Search(string prCbCreateur)
        {
            List<Log> lResult = _ILogService.GetByName(prCbCreateur);
            return Ok(lResult);
        }
        [HttpPut]
        public IActionResult Update(Log prLog)
        {
            return Ok(_ILogService.Update(prLog));

        }
        [HttpPost]
        public IActionResult Save(Log prLog) 
        {
            return Ok (_ILogService.Save(prLog));
        }
        [HttpDelete]
        public IActionResult Delete(Log prLog)
        {
            _ILogService.Delete(prLog);
            return Ok();
        }

    }
}
