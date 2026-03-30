namespace Zadanie_2_POIG;

public class Wydzial
{
    public string Nazwa { get; set; }
    public Adres Adres { get; set; }

    public Wydzial() { }
    public Wydzial (string nazwa, Adres adres)
    {
        this.Nazwa = nazwa;
        this.Adres = adres;
    }

    public override string ToString()
    {
        return Nazwa;
    }

    public string PelneDane
    {
        get
        {
            return $"Nazwa: {Nazwa} | Adres: {Adres.Miasto}, {Adres.KodPocztowy}, {Adres.Ulica} {Adres.NumerBudynku}";
        }
    }
}