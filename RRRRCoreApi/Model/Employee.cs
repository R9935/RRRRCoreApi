using System.ComponentModel.DataAnnotations;

namespace RRRRCoreApi.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Mobile { get; set; }
        [Required]
        public string Dept { get; set; }
    }
}
