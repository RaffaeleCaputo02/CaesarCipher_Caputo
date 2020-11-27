using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CeaserCipher_Library.CaesarBase;

namespace CaesarCipher_Caputo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci una parola");
            string plaintext = Console.ReadLine();
            int key;
            CeaserCode m1;
            try
            {
                do
                {
                    Console.WriteLine("Inserisci la chiave");
                    key = int.Parse(Console.ReadLine());

                } while (key < 0 || key > 25);

                m1 = new CeaserCode(plaintext, key);
                Console.WriteLine($"Il testo cifrato è: {m1.CipherText}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

        }
    }
}
