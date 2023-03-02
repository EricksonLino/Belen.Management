namespace BelenHospital.Management.Application.Dtos.PatientDto
{
    public class PatientDetailDto
    {
        public int Id { get; set; }
        public int Dni { get; set; }
        public string StoryNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sex { get; set; }
        public DateTime Birthdate { get; set; }
        public string InsuranceCompany { get; set; }
        public string Nationality { get; set; }
    }
}
