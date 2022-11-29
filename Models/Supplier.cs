using System.ComponentModel.DataAnnotations;

namespace EverCleanDbSystem.Models
{
    public class Supplier
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Telelphone { get; set; }
    }
}
