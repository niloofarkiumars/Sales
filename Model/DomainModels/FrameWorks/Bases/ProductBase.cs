using Model.DomainModels.FrameWorks.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DomainModels.FrameWorks.Bases
{
    public class ProductBase : IProduct
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public string? Title { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }   
    }
}
