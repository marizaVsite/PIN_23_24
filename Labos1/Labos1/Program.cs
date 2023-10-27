using System;

namespace Labos1
{
    public class Program
    {
        static void Main()
        {
            Proizvod p = new Proizvod("test", (decimal)4.5, 5);
            p.IspisiInformacije();

            PametniTelefon telefon = new PametniTelefon("iPhone 13", "Apple", 2022, "iOS");
            telefon.IspisiInformacije();
            telefon.InstalirajAplikaciju("Facebook");


        }

    }

}