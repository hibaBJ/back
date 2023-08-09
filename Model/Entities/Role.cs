using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AxiaBackend.Model.Entities
{
    [Table("Role")]
    public class Role
    {
        public int Id { get; set; }
       
        public string role { get; set; }
        public string Employee { get; set; }
        public string CbCreateur { get; set; }
        [Key]
        public int CbMarq { get; set; }
        public DateTime CbModificateur{get;set;}
    }
}
