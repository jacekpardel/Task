using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Task.Models
{
    public class LecturerModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }

    }
}
