using AxiaBackend.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AxiaBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public static int LoggedIn = -1; // variable statique de la classe

       // [HttpPost]
        //public IActionResult Login(Login model)
        //{
           
        //  //  var admin = _context.Admins.SingleOrDefault(d => d.Email == model.email && d.Password == model.password);

        //    if (admin == null)
        //    {
        //        return Unauthorized(); // erreur d'authentification
        //    }

        //    LoggedIn = admin.cbMarq; // stocker l'ID de l'utilisateur connecté dans LoggedIn
        //    return Ok(new
        //    {
        //        admin.cbMarq,
        //        admin.email,
        //        admin.password,
        //        LoggedIn,
        //    });
        //}



        //[HttpPost]
        //[Route("logout")]
        //public IActionResult Logout()
        //{
        //    LoggedIn = -1;
        //    return Ok();
        //}

    }

}

