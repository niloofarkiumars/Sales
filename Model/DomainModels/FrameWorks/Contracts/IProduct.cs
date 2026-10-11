using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainModels.FrameWorks.Contracts
{
    public interface IProduct
    {
        int Id { get; set; }
        string? Code { get; set; }
        string? Title { get; set; }
        decimal UnitPrice { get; set; }
        int Quantity { get; set; }
    }
}
