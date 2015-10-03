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
            //   Console.WriteLine("as pakeiciau v2");
            //  Funkas fnk = new Funkas();
            // Console.WriteLine("week number"+ fnk.MetuSavaite(DateTime.Now));
            Arbuz buzas = new Arbuz("skanus");
            Arbuz buzas1 = new Arbuz { Skonis = "liuks", nr = 1 };
            buzas1.nr = 32;
            System.Console.WriteLine("a "+buzas.ToString());
            System.Console.WriteLine("b " + buzas1.Skonis);

            //System.Console.WriteLine("b" + buzas.Skonis());
            Console.ReadKey();

        }

    }

    public class Arbuz
    { 
        public string Skonis { get; set; }
        public int nr { get; set; }

        public Arbuz() { }

        public Arbuz(string sk)
        {
            Skonis = sk;
        } 

        public override string ToString()
        {
            return "Skonis: " + Skonis  + ",nr: " + nr;
        }
    }
}
