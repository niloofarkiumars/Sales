using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Dtos.Person
{
    public class GetPersonDto
    {
        public int Id { get; set; }
        public string? NationalId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
