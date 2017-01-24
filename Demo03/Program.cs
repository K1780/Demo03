using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//yas
namespace Demo2
{
    class Ikkuna
    {
        // Properties = ominaisuudet
        public float Leveys { get; set; }
        public float Korkeus { get; set; }
        public float Piiri
        {
            get { return 2 * (Leveys + Korkeus); }

        }
        /// <summary>
        ///  constructors = konstruktor
        ///  
        public Ikkuna()
        {
            // tämä on ns. oletuskonstruktori
        }
        public Ikkuna(float leveys, float korkeus)
        {
            Korkeus = korkeus;
            Leveys = leveys;
        }
        // methods = metodeja
        public float Pintaala
        {
            get { return Leveys * Korkeus; }

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            OOikkunaDemo();
        }

        static void OOikkunaDemo()
        {
            // ohjelma laskee ikkunan pinta-alan ja piirin
            float Leveys = 0;
            float Korkeus = 0;
            float Ala, Piiri = 0;
            // kysytään käyttäjältä mitat 
            Console.WriteLine("Lasken ikkunan pinta-alan ja piirin, syötä leveys millimetreinä. ");
            Leveys = float.Parse(Console.ReadLine());
            Console.WriteLine("Anna korkeus millimetreinä .");
            Korkeus = float.Parse(Console.ReadLine());



            Ala = (Leveys * Korkeus);
            Piiri = (2 * (Korkeus + Leveys));

            Console.WriteLine("Ikkunan pinta ala on " + Ala + " mm^2");
            Console.WriteLine("Ikkunan piiri on " + Piiri + " millimetriä");
            // sama homma olion avulla
            Ikkuna ikkuna = new Demo2.Ikkuna();

            ikkuna.Leveys = Leveys;
            ikkuna.Korkeus = Korkeus;
            // Ala = ikkuna.LaskePintaala();

            Console.WriteLine("Olion avulla lasketun ikkunan pinta-ala on : {0} ja piiri {1}", ikkuna.Pintaala, ikkuna.Piiri);
            // kokeillaam puolta pienemmällä ikkunalla toista konstruktoria
            Ikkuna ikkuna2 = new Demo2.Ikkuna(Leveys / 2, Korkeus / 2);
            Console.WriteLine("Olioikkua2 avulla lasketun ikkunan pinta-ala on : {0} ja piiri {1}", ikkuna2.Pintaala, ikkuna2.Piiri);


        }
    }
}
