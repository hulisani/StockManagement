using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StockManagement.Base;

namespace StockManagementTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyBase b = new CompanyBase();
            b.CreateNew();
            Console.ReadLine();
        }
    }
}
