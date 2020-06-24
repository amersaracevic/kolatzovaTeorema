using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolatzovaTeorema
{
    class Program
    {
        //Proverio da li je paran broj
        //Ako je paran, delimo sa 2 i nastavljamo
        //Ako je neparan mnozimo sa 3, dodajemo 1 i nastavljamo
        //Moramo da stignemo do 1
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj ");
            int broj = int.Parse(Console.ReadLine());
            

            while(broj != 1)
            {
                if (broj % 2 == 0)
                {
                    broj = broj / 2;
                    Console.WriteLine(broj);

                }
                else if(broj % 2 == 1)
                {
                    broj = broj * 3 + 1;
                    Console.WriteLine(broj);

                }
            }
            
            Console.ReadKey();
        }
    }
}
