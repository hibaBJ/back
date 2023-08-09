using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AxiaBackend.Model.Entities
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int CbMarq { get; set; }
      
        public string Name  { get; set; }
       
        public string Email { get; set; }
      
        public string  Telephone { get; set; }

        public string Role { get; set; }
        public string CbCreateur { get; set; }  
        public DateTime CbModificateur { get; set; }
        public int Id { get; set; }



    }
}
