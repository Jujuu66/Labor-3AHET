using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Werkzeugverwaltung
{

    class tool // "Bauplan " in speicher
    {
        // Member-Variablen (eigenschaften)
        private string description;
        private int number;
        private bool inStore;

        // Methoden (Unterprogrammen)

        public void setDescription(string description)
        { 
        
        this.description = description;
        
        
        
        }

        public void setnumber(int number)
        {

            this.number = number;



        }

        public void setinStore(bool inStore)
        {

            this.inStore = inStore;



        }

        public void Print()
        {
            Console.WriteLine($"{description} {number} , Im Lager: {inStore}");
        
        
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {




            tool s1 = new tool();
            tool s2 = new tool();
            tool s3 = new tool();

            s1.setDescription ("Schraubendreher");
            s1.setnumber(67676);
            s1.setinStore(true);

            s2.setDescription("Schraubendreher");
            s2.setnumber(12345);
            s2.setinStore(true);

            s3.setDescription("Wasserwaage");
            s3.setnumber(50005);
            s3.setinStore(true);

            bool stayAlive = true;
            while (stayAlive)
            {


                Console.WriteLine("Werkzeuge auflisten [l]");
                Console.WriteLine("Werkzeug hinzufügen [h]");
                Console.WriteLine("Werkzeug ausleihen [a]");
                Console.WriteLine("Werkzeug retourieren [r]");
                Console.WriteLine(" Beenden [b]");
                char eingabe = Console.ReadKey().KeyChar;




                switch (eingabe)
                {
                    case 'b':
                        stayAlive = false;
                        break;

                    case 'l':

                        break;

                    case 'h':

                        break;

                    case 'a':

                        break;

                    case 'r':

                        break;


                }

                Console.ReadKey();
            }

        }
    }
}
