using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockManagement.Business.Entities.Interface
{
    public interface Department
    {
        string Name { get; set; }

        Company Company { get; set; }
    }
}
