using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadanieSluchu
{
    class Program
    {
        static void Main(string[] args)
        {
            int czestotliwosc = 20;
            while (czestotliwosc <= 20000)
            {
                Console.WriteLine(czestotliwosc);
                Console.Beep(czestotliwosc, 700);

                czestotliwosc += 500;
            }
        }
    }
}
