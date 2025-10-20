using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edzestervezogyakorlat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string vezetek_nev;
            string kereszt_nev;
            int suly_kg = 0;
            int cel_index = 0;
            double edzes_alap_hossz = 0;
            double kaloria_szorzo = 0;
            string[] cel_lista = { "Állóképesség", "Izomtömeg", "Fogyás" };


            while (true)
            {
                Console.Write("Adja meg a vezetéknevét (első nagybetűvel): ");
                vezetek_nev = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(vezetek_nev) && char.IsUpper(vezetek_nev[0]))
                    break;

                Console.WriteLine("Helytelen név! Nagybetűvel kell kezdődnie.");
            }
            while (true)
            {
                Console.Write("Adja meg a keresztnevét (első nagybetűvel): ");
                kereszt_nev = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(kereszt_nev) && char.IsUpper(kereszt_nev[0]))
                    break;

                Console.WriteLine("Helytelen név! Nagybetűvel kell kezdődnie.");
            }



            while (true)
            {
                Console.Write("Kérem a testsúlyát (50 és 120 kg között): ");
                string be_suly = Console.ReadLine();
                if (int.TryParse(be_suly, out suly_kg) && suly_kg >= 50 && suly_kg <= 120)
                    break;
                // ------------------------------------------------------------------------
                Console.WriteLine("Érvénytelen súly! 50 és 120 közötti számot adjon meg.");
            }

            Console.WriteLine();
            //

            Console.WriteLine("Válasszon célt:");

            Console.WriteLine("1 - Állóképesség fejlesztése");

            Console.WriteLine("2 - Izomtömeg növelése");

            Console.WriteLine("3 - Fogyás");

            while (true)
            {
                Console.Write("Adja meg a célt ( 1-3 ): ");
                string be_cel = Console.ReadLine();
                if (int.TryParse(be_cel, out cel_index) && cel_index >= 1 && cel_index <= 3)
                    break;

                Console.WriteLine("Csak 1, 2, vagy 3 lehet");
            }
        }
    }
}
