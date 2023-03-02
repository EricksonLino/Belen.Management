using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelenHospital.Management.Application.Dtos
{
    public class SpecialtyForListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfDoctors { get; set; }
        public bool IsEnabled { get; set; }
    }
}
