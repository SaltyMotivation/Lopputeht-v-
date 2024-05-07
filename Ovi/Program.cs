using System;

namespace EnumDemo
{
    class Ovi
    {
        // Määritellään staattiset boolean-muuttujat oviLukossa, oviKiinni ja loppu
        static bool oviLukossa = false;
        static bool oviKiinni = false;
        static bool loppu = false;

        // Määritellään enum Ovet, joka sisältää eri ovien tilat
        enum Ovet
        {
            Auki = 1,
            Kiinni,
            Lukossa,
            Loppu
        };

        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ovi on " + Ovet.Auki + ", mitä haluat tehdä?");

            // Pääsilmukka, joka jatkuu kunnes käyttäjä syöttää "Loppu"
            while (loppu == false)
            {
                
                string käsky = Console.ReadLine();

                // Tarkistetaan käskyn perusteella, mitä toimintoa suoritetaan
                if (käsky == "Kiinni")
                {
                    // Jos käsky on "Kiinni", muutetaan oviKiinni tilaksi true
                    Console.WriteLine("Ovi on " + Ovet.Kiinni + ", mitä haluat tehdä?");
                    Ovi.oviKiinni = true;
                    Ovi.oviLukossa = false;
                }
                if (käsky == "Lukko")
                {
                    // Jos käsky on "Lukko" ja ovi ei ole kiinni, tulostetaan virheviesti
                    if (!Ovi.oviKiinni)
                    {
                        Console.WriteLine("Sulje ovi ennen kuin lukitset oven!");
                    }
                    else
                    {
                        // Muuten muutetaan oviLukossa tilaksi true
                        Console.WriteLine("Ovi on " + Ovet.Lukossa + ", mitä haluat tehdä?");
                        Ovi.oviLukossa = true;
                        Ovi.oviKiinni = false;
                    }
                }
                if (käsky == "Auki")
                {
                    // Jos käsky on "Auki" ja ovi on lukossa, tulostetaan virheviesti
                    if (oviLukossa == true)
                    {
                        Console.WriteLine("Poista lukko ekaksi!");
                    }
                    else
                    {
                        // Muuten muutetaan oviKiinni tilaksi false
                        Console.WriteLine("Ovi on " + Ovet.Auki + ", mitä haluat tehdä?");
                        Ovi.oviKiinni = false;
                    }
                }
                if (käsky == "Loppu")
                {
                    // Jos käsky on "Loppu", asetetaan loppu muuttujaan true ja poistutaan silmukasta
                    loppu = true;
                }
            }
        }
    }
}
