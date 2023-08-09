using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AxiaBackend.Model.Entities
{
    [Table("Log")]
    public class Log
    {
        [Key]
        public int CbMarq { get; set; }
        public string CbCreateur{get;set;}
        public DateTime CbModificateur { get;set;}
        public string Table { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public int Id { get; set; }
    }
}
