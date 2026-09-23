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
        private bool inStore = true;

        // Methoden (Unterprogrammen)

        public void setDescription(string description)
        { 
        
        this.description = description;
        
        
        
        }

        public void setnumber(int number)
        {

            this.number = number;



        }

        public int getnumber()
        {

           return number;



        }

        public void Print()
        {
            Console.WriteLine($"{description} {number} , Im Lager: {inStore}");
        
        
        }

        public void SetFalse()
        {


            inStore = false;


        }

        public void SetTrue()
        {


            inStore = true;


        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            List<tool> tools = new List<tool> ();
            tools.Add (new tool ());
            tools.Add(new tool());
            tools.Add(new tool());



            tools[0].setDescription ("Schraubendreher");
            tools[0].setnumber(67676);
         

            tools[1].setDescription("Schraubendreher");
            tools[1].setnumber(12345);
          

            tools[2].setDescription("Wasserwaage");
            tools[2].setnumber(50005);
           

            


            int i = 3;
            bool stayAlive = true;
            while (stayAlive)
            {


                Console.WriteLine("Werkzeuge auflisten [l]");
                Console.WriteLine("Werkzeug hinzufügen [h]");
                Console.WriteLine("Werkzeug ausleihen [a]");
                Console.WriteLine("Werkzeug retourieren [r]");
                Console.WriteLine(" Beenden [b]");
                char eingabe = Console.ReadKey().KeyChar;


               Console.Clear();

                switch (eingabe)
                {
                    case 'b':
                        stayAlive = false;
                        break;

                    case 'l':
                        foreach (tool tool in tools)
                        {

                            tool.Print();
                        }
                        break;

                    case 'h':

                        Console.WriteLine("Welches Werkzeug wird hinzugefügt");
                       string stringHinzu = Console.ReadLine();
                        Console.WriteLine("Gib die Seriennummer ein");
                        int numberHinzu = int.Parse(Console.ReadLine());

                        tools.Add(new tool());
                        tools[i].setDescription(stringHinzu);
                        tools[i].setnumber(numberHinzu);
                        i++;


                        break;

                    case 'a':

                        Console.WriteLine("Seriennummer von den Werkstück das sie ausleihen wollen");
                        int aus = int.Parse(Console.ReadLine());


                        foreach (tool tool in tools)
                        {
                            if (aus == tool.getnumber())
                            {
                                tool.SetFalse();
                            
                            }
                        }
                        break;



                       

                    case 'r':

                        Console.WriteLine("Seriennummer von den Werkstück das sie zurückgeben wollen");
                        int Rück = int.Parse(Console.ReadLine());


                        foreach (tool tool in tools)
                        {
                            if (Rück == tool.getnumber())
                            {
                                tool.SetTrue();

                            }
                        }



                        break;


                }

                Console.ReadKey();
            }

        }
    }
}
