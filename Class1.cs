using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppZaNaručivanjeHrane
{
    class Class1
    {
        private static int alkohol = 900;
        private static int kafa = 220;
        private static int milksejk = 360;
        private static int palacinke = 360;
        private static int piletina = 720;
        private static int pizza = 900;
        private static int riba = 850;
        private static int salata = 620;
        private static int sendvici = 620;
        private static int sladoled = 430;
        private static int sokovi = 220;
        private static int spageti = 850;
        private static int torta = 520;
        private static int vafle = 430;
        private static int vocniKup = 450;

        private static double ukupno = 0;

        public static int Alkohol { get => alkohol; set => alkohol = value; }
        public static int Kafa { get => kafa; set => kafa = value; }
        public static int Milksejk { get => milksejk; set => milksejk = value; }
        public static int Palacinke { get => palacinke; set => palacinke = value; }
        public static int Piletina { get => piletina; set => piletina = value; }
        public static int Pizza { get => pizza; set => pizza = value; }
        public static int Riba { get => riba; set => riba = value; }
        public static int Salata { get => salata; set => salata = value; }
        public static int Sendvici { get => sendvici; set => sendvici = value; }
        public static int Sokovi { get => sokovi; set => sokovi = value; }
        public static int Spageti { get => spageti; set => spageti = value; }
        public static int Torta { get => torta; set => torta = value; }
        public static int Vafle { get => vafle; set => vafle = value; }
        public static int VocniKup { get => vocniKup; set => vocniKup = value; }
        public static int Sladoled { get => sladoled; set => sladoled = value; }
        public static double Ukupno { get => ukupno; set => ukupno = value; }
    }
}
