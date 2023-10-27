namespace Labos1
{
    using System;

    // Bazna klasa za elektroničke uređaje
    public class ElektroničkiUređaj
    {
        public string Naziv { get; set; }
        public string Proizvođač { get; set; }
        public int GodinaProizvodnje { get; set; }

        public ElektroničkiUređaj(string naziv, string proizvođač, int godinaProizvodnje)
        {
            Naziv = naziv;
            Proizvođač = proizvođač;
            GodinaProizvodnje = godinaProizvodnje;
        }

        public void IspisiInformacije()
        {
            Console.WriteLine($"Uređaj: {Naziv}");
            Console.WriteLine($"Proizvođač: {Proizvođač}");
            Console.WriteLine($"Godina proizvodnje: {GodinaProizvodnje}");
        }
    }

    // Podklasa za pametne telefone
    public class PametniTelefon : ElektroničkiUređaj
    {
        public string OperativniSustav { get; set; }

        public PametniTelefon(string naziv, string proizvođač, int godinaProizvodnje, string os)
            : base(naziv, proizvođač, godinaProizvodnje)
        {
            OperativniSustav = os;
        }

        // Dodatna metoda specifična za pametne telefone
        public void InstalirajAplikaciju(string aplikacija)
        {
            Console.WriteLine($"Instalira se aplikacija: {aplikacija}");
        }
    }

}
