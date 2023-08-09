using System.ComponentModel.DataAnnotations;

namespace AxiaBackend.Model.Entities
{
    public class Login
    {
        [Key]
        public int cbMarq { get; set; }
        public string email { get; set; }

        public string password { get; set; }
    }
}
