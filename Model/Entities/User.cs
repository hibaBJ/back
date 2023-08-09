using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AxiaBackend.Model.Entities
{
    [Keyless]
    
    public class User
    {
       
        public string userEmail { get; set; } = string.Empty;
      //  public string userPassword { get; set; }
        public byte[] PasswordHash { get; set; }=new byte[0];
        public byte[] PasswordSalt { get; set; } = new byte[0];
     

    }
}
