using System.ComponentModel.DataAnnotations;
//Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;
namespace megamind.Models
{
    public class form
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone_No { get; set; } = string.Empty;

        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }

    }
}
