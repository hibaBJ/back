using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AxiaBackend.Model.DTO
{
    [Table("Users")]
    public class UserDto
    {
        public string userEmail { get; set; } = string.Empty;
        public string userPassword { get; set; }=string.Empty;
        [Key]
        public int IdUser { get; set; }
    }
}
