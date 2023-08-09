using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AxiaBackend.Model.Entities
{
    [Table("Conges")]
    public class Conges
    {
        [Key]
        public int CbMarq { get; set; }
        public int Id { get;set; }
        public string Employee { get; set; }
        public DateTime Date_Debut {  get; set; }   
        public DateTime Date_Fin { get; set; }
        public int Nombre { get; set; }
        public string CbCreateur { get; set; }
        public DateTime CbModificateur { get; set; }
        //public int Type { get; set; }

    }
}
