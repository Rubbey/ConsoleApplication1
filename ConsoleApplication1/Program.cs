using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
                struct Kontakt
        {
            public string name;
            public string surname;
            public int phoneNumber;
            public string eMail;
        }

        static void Main(string[] args)
        {

            Struktura();

        }

        static void Struktura()
        {
            Kontakt id1;
            Console.Write("Podaj imię:");
            id1.name = Console.ReadLine();
            Console.Write("Podaj nazwisko:");
            id1.surname = Console.ReadLine();
            id1.phoneNumber = PodajLiczbe("Podaj nr telefonu:");
            Console.Write("e-mail:");
            id1.eMail = Console.ReadLine();

            Console.WriteLine("\n\n{0}\n{1}\n{2}\n{3}", id1.name, id1.surname, id1.phoneNumber, id1.eMail);
            Console.WriteLine("\n\n{0}\n", id1);


        }

        static void Tablice()
        {
            Console.Title = "Tablice!";
            Console.ForegroundColor = ConsoleColor.Green;

            int tabSize;
            do
            {
                try
                {
                    //Console.Write("Podaj wielkość tablicy: ");
                    //tabSize = int.Parse(Console.ReadLine());

                    tabSize = PodajLiczbe("Podaj wielkość tablicy: ");

                    if (tabSize <= 0) throw new Exception();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Podano niepaidłową wielkość tablicy!");
                    Console.WriteLine(e.Message);
                }
            } while (true);

            int[] tab1 = new int[tabSize];
            for (int i = 0; i < tab1.Length;)
            {
                tab1[i] = PodajLiczbe("Podaj wartość " + ++i + " elementu tablicy: ");
            }

            int[] tab2 = new int[tabSize];
            for (int i = 0; i < tab2.Length; i++)
            {
                tab2[i] = PodajLiczbe();
            }

            PiszTablice(tab1);
            PiszTabliceOdKonca(tab1);
            PiszTablice(tab2);
            PiszTabliceOdKonca(tab2);

        }

        static void Choinka()
        {

            int treehigh;

            while (true)
            {
                try
                {
                    Console.Write("podaj wysokość choinki: ");
                    treehigh = int.Parse(Console.ReadLine());
                    if (treehigh <= 0) throw new Exception();
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("niepoprawna liczba, spróbj jeszcze raz!");
                }

            }

            PiszGwiazdki(treehigh);
        }

        static int PodajLiczbe(string a = "Podaj liczbę całkowitą: ")
        {
            int liczba;
            do
            {
                try
                {
                    Console.Write(a);
                    liczba = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Podano niepaidłową liczbę!");
                }
            }
            while (true);

            return liczba;
        }

        static void PiszTablice(int[] a)
        {
            Console.WriteLine("\n*** TABLICA ***");
            foreach (int element in a)
            {
                Console.Write(element + "\t");
            }
            Console.WriteLine("\n*** KONIEC TABLICY ***\n");
        }

        static void PiszTabliceOdKonca(int[] a)
        {
            Console.WriteLine("\n*** TABLICA OD KOŃCA***");
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write("{0}\t", a[i]);
            }
            Console.WriteLine("\n*** KONIEC TABLICY OD KOŃCA***\n");
        }

        static void PiszGwiazdki(int a)
        {
            int q = 0, b = a;

            Console.WriteLine("\n\n");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(" ");
                }
                b--;
                Console.Write("*");
                for (int k = 0; k < q; k++)
                {
                    Console.Write("**");
                }
                q++;
                Console.WriteLine();
            }
            for (int i = 0; i < a; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("|\n\n");



        }
    }


}

