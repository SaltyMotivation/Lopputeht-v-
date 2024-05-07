using System;


string karkitilaus = "a"; 
string peratilaus = "b";
int pituustilaus = 0; 
string haluttupituus; 


Console.WriteLine("Minkälainen kärki (puu, teräs, timantti) :");

// Jatketaan kysymistä, kunnes kelvollinen karkitilaus on syötetty
while (karkitilaus != "puu" || karkitilaus != "teräs" || karkitilaus != "timantti")
{
    karkitilaus = Console.ReadLine();

    // Jos kelvollinen karkitilaus on syötetty, poistutaan silmukasta
    if (karkitilaus == "puu" || karkitilaus == "timantti" || karkitilaus == "teräs")
    {
        break;
    }
}


Console.WriteLine("Minkälainen perä (lehti, kanansulka, kotkansulka) :");


while (peratilaus != "lehti" || peratilaus != "kanansulka" || peratilaus != "kotkansulka")
{
    peratilaus = Console.ReadLine();

  
    if (peratilaus == "lehti" || peratilaus == "kanansulka" || peratilaus == "kotkansulka")
    {
        break;
    }
}

// Kysytään käyttäjältä nuolen pituutta ja varmistetaan, että se on kelvollinen
Console.WriteLine("Mikä on nuolen pituus (60-100cm) :");

// Jatketaan kysymistä, kunnes kelvollinen pituustilaus on syötetty
while (pituustilaus < 60 || pituustilaus > 100)
{
    haluttupituus = Console.ReadLine();

    // Tarkistetaan, voiko käyttäjän syöte muuntaa kokonaisluvuksi ja että se on kelvollisen alueen sisällä
    if (int.TryParse(haluttupituus, out pituustilaus) && pituustilaus >= 60 && pituustilaus <= 100)
    {
        break;
    }
}

// Luodaan uusi NuoliHommeli-luokan instanssi annetuilla parametreilla
NuoliHommeli TilattuNuoli = new NuoliHommeli(karkitilaus, peratilaus, pituustilaus);

// Näytetään nuolen hinta
Console.WriteLine("Nuoli maksaaa " + TilattuNuoli.PalautaHinta() + " kultaa.");

// Määritellään NuoliHommeli-luokka
public class NuoliHommeli
{
    // Yksityiset kentät nuolen ominaisuuksien tallentamiseksi
    private string _karki;
    private string _pera;
    private double _pituus;
    private double nuolenhinta;

    // Konstruktori nuolen ominaisuuksien alustamiseksi ja hinnan laskemiseksi
    public NuoliHommeli(string karki, string pera, int pituus)
    {
        _karki = karki;
        _pera = pera;
        _pituus = pituus;

        // Lasketaan hinta nuolen kärjen (karki) ja perän (pera) tyypin perusteella
        if (_karki == "puu")
        {
            nuolenhinta += 3;
        }
        if (_karki == "teräs")
        {
            nuolenhinta += 5;
        }
        if (_karki == "timantti")
        {
            nuolenhinta += 50;
        }
        if (_pera == "kanansulka")
        {
            nuolenhinta += 1;
        }
        if (_pera == "kotkansulka")
        {
            nuolenhinta += 5;
        }

        // Lisätään hintaan nuolen pituuden perusteella
        nuolenhinta = nuolenhinta + _pituus * 0.05;
        return;
    }

    // Metodi nuolen hinnan palauttamiseksi
    public double PalautaHinta()
    {
        return nuolenhinta;
    }

    // Metodit nuolen ominaisuuksien palauttamiseksi
    public string Karki()
    {
        return _karki;
    }

    public string Pera()
    {
        return _pera;
    }

    public double Pituus()
    {
        return _pituus;
    }
}

