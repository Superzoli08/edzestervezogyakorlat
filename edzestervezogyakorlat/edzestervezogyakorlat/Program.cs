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

            // Alap edzésidő és kalóriaszorzó beállítása a cél alapján
            if (cel_index == 1)
            {
                edzes_alap_hossz = 45;
                kaloria_szorzo = 0.12;
            }

            else if (cel_index == 2)

            {
                edzes_alap_hossz = 40;
                kaloria_szorzo = 0.10;
            }

            else
            {
                edzes_alap_hossz = 30;
                kaloria_szorzo = 0.15;
            }

            // Heti edzésnapok bekérése
            int napok_szama = 0;
            while (true)
            {
                Console.Write("Hány napot szeretne edzeni a héten (1–7): ");
                string be_napok = Console.ReadLine();
                if (int.TryParse(be_napok, out napok_szama) && napok_szama >= 1 && napok_szama <= 7)
                    break;

                Console.WriteLine("Érvénytelen nap! 1 és 7 közötti számot adjon meg.");
            }

            // Napok erősségei
            int[] nap_erossegek = new int[napok_szama];
            for (int i = 0; i < napok_szama; i++)
            {
                while (true)
                {
                    Console.Write($"Kérem a(z) {i + 1}. nap erősségi szintjét (1–5): ");
                    string be_szint = Console.ReadLine();
                    if (int.TryParse(be_szint, out int szint) && szint >= 1 && szint <= 5)
                    {
                        nap_erossegek[i] = szint;
                        break;
                    }

                    Console.WriteLine("Érvénytelen erősség! 1 és 5 közötti számot adjon meg.");

                }

            }

            double heti_ossz_ido = 0;
            for (int i = 0; i < napok_szama; i++)
            {
                double napi_ido = edzes_alap_hossz * (1 + 0.1 * nap_erossegek[i]);
                heti_ossz_ido += napi_ido;
            }
            double heti_kaloria = suly_kg * heti_ossz_ido * kaloria_szorzo;
            Console.WriteLine();
            Console.WriteLine("Edzési Adatok:");
            Console.WriteLine($"Név: {vezetek_nev} {kereszt_nev}");
            Console.WriteLine($"Cél: {cel_lista[cel_index - 1]}");
            Console.WriteLine($"Heti edzésidő: {heti_ossz_ido:F2} perc");
            Console.WriteLine($"Heti elégetett kalória: {heti_kaloria:F2} kcal");


            Console.ReadKey();

        }
    }
}

