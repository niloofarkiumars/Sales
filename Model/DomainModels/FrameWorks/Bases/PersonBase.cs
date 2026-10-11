using Model.DomainModels.FrameWorks.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainModels.FrameWorks.Bases
{
    public class PersonBase :IPerson
    {
        public int Id { get; set; }
        public string? NationalId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }   
    }
}
