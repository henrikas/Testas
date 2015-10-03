using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Funkas
    {
        bool sukurtas;
        string vardas = "neturiu vardo";

        public int MetuSavaite(DateTime dtPassed) {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        public void kurk(string vrd)
        {
            sukurtas = true;
            vardas = vrd;

        }
        public void KasTu()
        {
            System.Console.WriteLine("Mano vardas: " + vardas);
            System.Console.WriteLine("Sukurtas: " + sukurtas);

        }
    }
}
