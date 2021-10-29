using System;

namespace liczby_pierwsze
{
    class Program
    {
        static bool czypierwsze(int liczba)
        {
            if (liczba == 2)
            {
                return true;
            }
            if (liczba <= 1)
            {
                return false;
            }
            else
            {
                for (int i = 2; i < liczba; i++)
                {
                    if (liczba % i == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("ile liczb pierwszych chcesz wypisać? ");
            int liczbyPierwsze = Convert.ToInt32(Console.ReadLine());

            int j = 1;
            int i = 1;
            while (j <= liczbyPierwsze)
            {
                if (czypierwsze(i))
                {
                    Console.WriteLine(i);
                    j++;
                }
                i++;
            }
        }
    }
}
    

