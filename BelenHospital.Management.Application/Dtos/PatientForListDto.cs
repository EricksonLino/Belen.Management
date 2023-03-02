namespace BelenHospital.Management.Application.Dtos
{
    public class PatientForListDto
    {
        public int Id { get; set; }
        public int Dni { get; set; }
        public string StoryNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string InsuranceCompany { get; set; }
    }
}
