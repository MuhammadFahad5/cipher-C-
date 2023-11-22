using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cipher2
{
    class Program
    {
        static void Main(string[] args)
        {
            Algorithm a = new Algorithm(3);

            Console.Write("Please Enter the Plain text for Encryption: ");


            string i = Console.ReadLine();

            string s = a.Encrypt(i);
            Console.WriteLine("\nCipher Text of above plain text --> {0}", s);

            string d = a.Decrypt(s);


            Console.WriteLine("\n\nDecrypted text recovering from the above ciphertext ---> {0}", d);

            Console.ReadKey();
        }
    }
}
