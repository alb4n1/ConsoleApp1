using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public string Emri { get; set; }

        public string Mbiemri { get; set; }

        public int Mosha { get; set; }

        public string Adresa { get; set; }

        void Pershendete()
        {
            Console.WriteLine($"tungjatjeta {Emri} {Mbiemri}");
        }
    }
}
