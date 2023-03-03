using System.ComponentModel.DataAnnotations;

namespace BelenHospital.Management.Entity
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(8)]
        public int Dni { get; set; }
        [Required]
        [StringLength(15)]
        public string StoryNumber { get; set; }
        [Required]
        [StringLength(25)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        public bool Sex { get; set; }
        public DateTime Birthdate { get; set; }
        [Required]
        public string InsuranceCompany { get; set; }
        [Required]
        public string Nationality { get; set; }
    }
}
