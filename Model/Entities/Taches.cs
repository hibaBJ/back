using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AxiaBackend.Model.Entities
{
    [Table("Tache")]
    public class Taches
    {
        public int  Id { get; set; }
        public string Nom { get; set; }
        public string Type { get; set; }
        public string Module { get; set; }
        public string Projet { get; set; }
        public int Duree { get; set; }
        public int Temps_estime { get; set; }
        [Key]
        public int CbMarq { get; set; }
        public DateTime CbModificateur{get;set;}
        public string CbCreateur { get; set; }
    }
}
