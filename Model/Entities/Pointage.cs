
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AxiaBackend.Model.Entities
{
    [Table("Pointage")]
    public class Pointage
    {
        public int  Id { get; set; }
        public string Employee { get; set; }
        
        public DateTime Entree {  get; set; }
        public DateTime Sortie { get; set; }
        //Entrée aprés_midi 
        public DateTime EntreeM { get; set; }
        //Sortie aprés-midi
        public DateTime SortieM { get; set; }
        public int Total { get; set; }
        [Key]
        public int CbMarq { get; set; }
        public string CbCreateur { get;set; }
        public DateTime CbModificateur { get;set; }
    }
}
