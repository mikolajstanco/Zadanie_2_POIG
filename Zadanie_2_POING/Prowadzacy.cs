namespace Zadanie_2_POIG;

public class Prowadzacy
{
    public string imie { get; set; }
    public string nazwisko { get; set; }
    public Prowadzacy() { }
    public Prowadzacy(string imie, string nazwisko)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
    }

    public override string ToString()
    {
        return imie + " " + nazwisko;
    }
}