using System.ComponentModel.DataAnnotations;

namespace AxiaBackend.Model.Entities
{
    public class TRefreshToken
    {
        [Key]
        public string UserId { get; set; }
        public string TokenId { get; set; }
        public string RefreshToken { get; set; }
        public bool? IsActive { get; set; }
    }
}
