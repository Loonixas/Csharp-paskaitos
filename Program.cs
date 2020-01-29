using System;
using System.Collections.Generic;
using System.Linq;

namespace aaa
{

    class Knyga
    {
        public string Pavadinimas { get; private set; }
        public string Autorius { get; private set; }
        public int Puslapiai { get; private set; }
        public string Zanras { get; private set; }
        public double Kaina { get; private set; }
        public int Kiekis { get; private set; }

        public Knyga(string pavadinimas, string autorius, int puslapiai, string zanras, double kaina, int kiekis)
        {
            Pavadinimas = pavadinimas;
            Autorius = autorius;
            Puslapiai = puslapiai;
            Zanras = zanras;
            Kaina = kaina;
            Kiekis = kiekis;
        }
        public void isvedimas()
        {
            Console.WriteLine("Pavadinimas: " + Pavadinimas);
            Console.WriteLine("Autorius: " + Autorius);
            Console.WriteLine("Puslapiu skaicius: " + Puslapiai);
            Console.WriteLine("Zanras: " + Zanras);
            Console.WriteLine("Kaina: " + Kaina + " eur");
            Console.WriteLine("Yra sios knygos vienetu: " + Kiekis);
            Console.WriteLine("Pardavus visus knygos vnt gautume {0} eur apyvarta", Apyvarta());
            Console.WriteLine();
        }
        public double Apyvarta()
        {
            return Kiekis * Kaina;
        }
    }

    class Knygynas
    {
        public string Pavadinimas { get; private set; }
        public string Adresas { get; private set; }
        public List<Knyga> Knygos { get; private set; }

        public Knygynas(string pavadinimas, string adresas, List<Knyga> knygos)
        {
            Pavadinimas = pavadinimas;
            Adresas = adresas;
            Knygos = knygos;
        }

        public void isvedimas()
        {
            Console.WriteLine("Knygyno pavadinimas: " + Pavadinimas);
            Console.WriteLine("Ji rasite adresu: " + Adresas);
            Console.WriteLine("---------------");
            Console.WriteLine("Jame turimos knygos: ");
            Console.WriteLine("---------------");
            foreach (var knyga in Knygos)
            {
                knyga.isvedimas();
            }
            Console.WriteLine("--------------");

            Console.WriteLine("Didziausia knyga");
            DidziausiaKnyga().isvedimas();
        }

        public Knyga DidziausiaKnyga()
        {
            var didziausia = Knygos.First();

            foreach (var knyga in Knygos)
            {
                if (knyga.Puslapiai>didziausia.Puslapiai)
                {
                    didziausia = knyga;
                }
            }

            return didziausia;
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            var knygynas = new Knygynas("Pegasas", "Akropolis", new List<Knyga>
            {
                new Knyga("Harris Poteris","Rawling",500,"Vaikiska",12.99,30),
                new Knyga("Pavadinimas","Autorius",315,"Siaubo",14.99,50),
                new Knyga("Sutemos","Vampyrowskis",13,"Nesamones",9.99,25)
            });
            knygynas.isvedimas();
        }
    }
}
