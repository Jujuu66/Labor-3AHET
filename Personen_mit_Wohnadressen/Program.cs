using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personen_mit_Wohnadressen
{







    class Person 
    {


        private string Vorname;
        private string Name;
        private DateTime Geburtstag;
        private string Hauptwohnsitz;
        private string hausnummer;
        private string Strasse;
        private string Postleitzahl;
        private string ort;
        private string Land;

        public Person(string Vorname, string Name, DateTime Geburtstag, string Hauptwohnsitz, string hausnummer, string Strasse,string Postleitzahl, string ort, string Land)  //Konstruktor gleicher name wie klasse
        {
            this.Vorname = Vorname;
            this.Name = Name;
            this.Geburtstag = Geburtstag;
            this.Hauptwohnsitz = Hauptwohnsitz;
            this.hausnummer = hausnummer;
            this.Strasse = Strasse;
            this.Postleitzahl = Postleitzahl;
            this.ort = ort;
            this.Land = Land;

        }



    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> tools = new List<Person>();
            Person.Add(new Person("Anna", "Gruber" ,(1985 - 03 - 12), Hauptplatz 5, 3830 Waidhofen an der Thaya, Österreich));


        }
    }
}
