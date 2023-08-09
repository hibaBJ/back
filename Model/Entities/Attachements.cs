using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AxiaBackend.Model.Entities
{
    [Table("Attachement")]
    public class Attachements

    {
        [Key]
        public int CbMarq { get; set; }
        public string Employee { get; set; }
        public string Attachement { get; set; }
        public DateTime CbModificateur { get; set; }
        public string CbCreateur { get; set; }


    }
}
