using System;

namespace ProgramPesel
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesel pesel;
            Console.WriteLine("Wpisz numer PESEL");
            string numerPesel = Console.ReadLine();
            try
            {
                pesel = new Pesel(numerPesel);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            Console.WriteLine("Plec osoby: " + pesel.Plec);
            Console.WriteLine("Plec osoby: " + pesel.PlecOpis);
            Console.ReadLine();
        }
    }
}
