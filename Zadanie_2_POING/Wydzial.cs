namespace Zadanie_2_POING;

public class Wydzial
{
    public string nazwa { get; set; }
    public Adres adres { get; set; }

    public Wydzial (string nazwa, Adres adres)
    {
        this.nazwa = nazwa;
        this.adres = adres;
    }

    public override string ToString()
    {
        return nazwa;
    }
}