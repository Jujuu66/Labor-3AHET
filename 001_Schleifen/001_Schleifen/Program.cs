using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Schleifen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i =0;
            Console.WriteLine("Gib einen text ein");
            string text = Console.ReadLine();
         

            while (text.Length != i)
            { 
                i++;
                Console.Write(text[text.Length - i]);

            }


        }
    }
}
