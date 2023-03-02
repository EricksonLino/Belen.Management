using System.ComponentModel.DataAnnotations;

namespace BelenHospital.Management.Entity
{
    public class Specilty
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(12)]
        public int NumberOfDoctors { get; set; }
        [Required]
        public bool IsEnabled { get; set; }
    }
}
