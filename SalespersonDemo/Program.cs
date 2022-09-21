using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalespersonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RealEstateSalesperson rp1 = new RealEstateSalesperson("John", "Smith", 0.2);
            Console.WriteLine(rp1.getName());
            rp1.SalesSpeech();
            rp1.MakeSale(80000);
            rp1.MakeSale(50000);

            Console.WriteLine("-----------------------------------------------------------");

            GirlScout gs1 = new GirlScout("Lavi", "Doe");
            Console.WriteLine(gs1.getName());
            gs1.SalesSpeech();
            gs1.MakeSale(5);
            gs1.MakeSale(11);
            
        }
    }
}
