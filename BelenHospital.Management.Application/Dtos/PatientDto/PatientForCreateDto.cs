using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelenHospital.Management.Application.Dtos.PatientDto
{
    public class PatientForCreateDto
    {
        public int Dni { get; set; }
        public string StoryNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Sex { get; set; }
        public DateTime Birthdate { get; set; }
        public string InsuranceCompany { get; set; }
        public string Nationality { get; set; }
    }
}
