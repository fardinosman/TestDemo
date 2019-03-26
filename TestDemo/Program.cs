using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vm = new VendingMachine();

           // Console.WriteLine(vm.);
            Console.WriteLine(vm.GetCocaCola());
            Console.WriteLine(vm.GetCocaCola());
            Console.WriteLine(vm.GetCocaCola());
            Console.WriteLine(vm.GetCocaCola());
            Console.WriteLine(vm.GetCocaCola());
            


            Console.ReadKey();
        }
    }
}
