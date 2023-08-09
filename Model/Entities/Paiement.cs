using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AxiaBackend.Model.Entities
{
    [Table("Paiement")]
    public class Paiement
    {
        [Key]
        public int CbMarq { get; set; }
        public int Id { get; set; }
        public string Employee { get; set; }
        [Required]
        public decimal Salaire  { get; set; }
        [Required]
        public decimal Prime { get; set; }
        public int Coefficient { get; set; }  
       
        public DateTime CbModificateur { get; set; }
        public string CbCreateur { get; set; }
    }
}
