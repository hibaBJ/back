using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AxiaBackend.Model.Entities
{
    [Table("Objectifs")]
    public class Objectifs
    {
        [Key]
        public int CbMarq { get;set; }
        public int Id { get; set; }
        public string Taches { get; set; }
        public string Projet { get; set; }
        [Required]
        public string objectifs { get; set; }
        [Required]
        public DateTime Temps_estime {get;set;}
        public DateTime CbModificateur { get; set; }
        public string CbCreateur { get; set; }
        

    }
}
