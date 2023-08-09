using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AxiaBackend.Model.Entities
{
    [Table("Accessoires")]
    public class Accessoires
    {
        public int Id { get; set; }
        public string Employee { get; set; }
        public string Intitule { get; set; }
        public int Code { get; set; }
        [Key]
        public int CbMarq { get; set; }
        public DateTime CbModificateur { get; set; }
        public string CbCreateur { get; set; }

   
    }
}
