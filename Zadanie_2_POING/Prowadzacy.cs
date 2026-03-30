namespace Zadanie_2_POIG;

public class Prowadzacy
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public Prowadzacy() { }
    public Prowadzacy(string imie, string nazwisko)
    {
        Imie = imie;
        Nazwisko = nazwisko;
    }

    public override string ToString()
    {
        return Imie + " " + Nazwisko;
    }
}