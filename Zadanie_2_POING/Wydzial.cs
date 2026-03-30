namespace Zadanie_2_POIG;

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

    public string PelneDane
    {
        get
        {
            return $"Nazwa: {nazwa} | Adres: {adres.Miasto}, {adres.KodPocztowy}, {adres.Ulica} {adres.NumerBudynku}";
        }
    }
}