using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockManagement.Business.Entities.Interface
{
    public interface Address
    {
         string Line1 { get; set; }
         string Line2 { get; set; }
         string Line3 { get; set; }
         string Code { get; set; }
    }
}
