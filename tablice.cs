using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_13_2p
{

    public class tablice
    {
        public int liczba = 20;
        public void powitanie()
        {
            Console.WriteLine("WItaj w pliku tablice!");
        }
        public int [] Stworz_tablice()
        {
            Console.WriteLine("Ile elementów ma mieć tablica? ");
            int dl = int.Parse(Console.ReadLine());

            int[] ints = new int[dl];

            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write("Podaj kolejny element tablicy: ");
                    ints[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            return ints;
        }
        public void Wyswietl_Tablice(int[] tab)
        {
            Console.WriteLine("Elementy tablice: ");
            foreach (int i in tab)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
        public void StortujBabelkowo(int[] tab)
        {
            for (int i = 0;i < tab.Length;i++)
            {
                for (int j = 1; j < tab.Length;j++)
                {
                    if (tab[j-1] > tab[j])
                    {
                        int temp = tab[j - 1];
                        tab[j - 1] = tab[j];
                        tab[j] = temp;
                    }
                }
            }
        }
    }
}
