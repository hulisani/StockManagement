using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockManagement.Business.Entities.Interface
{
    public interface Company
    {
         string Name { get; set; }

         Address PostalAddress { get; set; }

         Address PhysicalAddress { get; set; }

         string RegistrationCode { get; set; }
    }
}
