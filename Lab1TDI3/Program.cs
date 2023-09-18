using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1TDI3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*aria patratului*/

            int lungime = 10;
            lungime = lungime * 3;

            int latime = 11;

            int aria = lungime * latime;

            Console.WriteLine("Aria dreptunghiului este "+aria);





            /*l-am adaugat deoarece fara el, mi se inchide automat debugul fara sa vad ce modificari am facut*/
            Console.ReadKey();
        }
    }
}
