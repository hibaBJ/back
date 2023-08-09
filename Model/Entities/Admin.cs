using System.ComponentModel.DataAnnotations;

namespace AxiaBackend.Model.Entities
{
    public class Admin
    {
        public string email { get; set; } = null!;
        public string password { get; set; }=null!;
        [Key]
        public int cbMarq { get; set; }
    }
}
