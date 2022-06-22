using System.ComponentModel.DataAnnotations;

namespace RRRRCoreApi.Model
{
    public class UserInfo
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
