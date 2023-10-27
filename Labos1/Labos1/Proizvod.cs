using System;

namespace Labos1
{
    public class Proizvod
    {
        // Svojstva (properties)
        public string Naziv { get; set; }
        public decimal Cijena { get; set; }
        public int DostupnaKolicina { get; set; }

        // Konstruktor za inicijalizaciju objekta
        public Proizvod(string naziv, decimal cijena, int dostupnaKolicina)
        {
            Naziv = naziv;
            Cijena = cijena;
            DostupnaKolicina = dostupnaKolicina;
        }

        // Metoda za ispis informacija o proizvodu
        public void IspisiInformacije()
        {
            Console.WriteLine($"Proizvod: {Naziv}");
            Console.WriteLine($"Cijena: {Cijena:C}"); // Formatiranje cijene kao valute
            Console.WriteLine($"Dostupna količina: {DostupnaKolicina}");
        }
    }
}
