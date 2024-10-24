using System;
using System.Security.Cryptography.X509Certificates;

namespace uppgift
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int resultat;
            if (!TryParse(Console.ReadLine(), out resultat))
            {
                Console.WriteLine("Skriv in en siffra");
            }
        }
        public static bool TryParse(string s, out int result)
        {
            
            bool resultat;
            try
            {
                result = Convert.ToInt32(s);
                resultat = true;
                return resultat;
            }
            catch
            {
                result = 0;
                resultat = false;
                return resultat;
            }
        }
    }
}