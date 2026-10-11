using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainModels.FrameWorks.Contracts
{
    public interface IPerson
    {
        int Id { get; set; }
        string? NationalId { get; set; }
        string? FirstName { get; set; }
        string? LastName { get; set; }
    }
}
