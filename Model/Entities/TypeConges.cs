using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AxiaBackend.Model.Entities
{
    [Table("TypeConges")]
    public class TypeConges  
    {
        public string Type { get; set; }

        [Key]
        public int CbMarq { get; set; }
        public DateTime CbModificateur { get; set; }
        public string CbCreateur { get; set; }
    }
}
