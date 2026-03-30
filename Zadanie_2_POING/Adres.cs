namespace Zadanie_2_POIG;

public class Adres
{
    public string Miasto { get; set; }
    public string Ulica { get; set; }
    public int NumerBudynku { get; set; }
    public string KodPocztowy { get; set; }

    public Adres() { }
    public Adres(string miasto, string ulica, int numerBudynku, string kodpocztowy)
    {
        Miasto = miasto;
        Ulica = ulica;
        NumerBudynku = numerBudynku;
        KodPocztowy = kodpocztowy;
    }
}