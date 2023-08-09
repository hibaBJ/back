using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AxiaBackend.Model.Entities
{
    [Table("Groupe")]
    public class Groupe
    {
      
        public int Id { get; set; }
        public string Name{ get; set; }
        [Required]
        public string Specialite { get; set; }
        public string Membres { get; set; }
     
        
        [Key]
        public int CbMarq { get; set; }
        public string CbCreateur { get; set; }  
        public DateTime CbModificateur {  get; set; }
        
    }
}
