using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // string a;
            Console.WriteLine("as pakeiciau v2");
            funkas fnk = new funkas();
            fnk.KasTu();
            Console.ReadKey();
            fnk.kurk("alalal");
            fnk.KasTu();
            Console.ReadKey();

        }

    }
    class funkas{
        bool sukurtas;
        string vardas = "neturiu vardo";

        public void kurk(string vrd) {
            sukurtas = true;
            vardas = vrd;

        }
        public void KasTu() {
            System.Console.WriteLine("Mano vardas: "+vardas);
            System.Console.WriteLine("Sukurtas: "+sukurtas);

        }
    }
    
}
