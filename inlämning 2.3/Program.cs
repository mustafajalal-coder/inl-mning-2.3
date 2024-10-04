using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlämning_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar ska du hyra ut bilen?");
            int dagar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hur många km ska du köra bilen?");
            int km = Convert.ToInt32(Console.ReadLine());


            int totalkostnad = 300 + km + (dagar > 1? (dagar - 1) *500 : 0);

            Console.WriteLine($"den totala kostnaden för att hyra ut bilen är: {totalkostnad} kr");

        }
    }
}
