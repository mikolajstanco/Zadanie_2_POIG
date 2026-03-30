namespace Zadanie_2_POING;

public class Adres
{
    public string miasto { get; set; }
    public string ulica { get; set; }
    public int numerBudynku { get; set; }

    public Adres(string miasto, string ulica, int numerBudynku)
    {
        this.miasto = miasto;
        this.ulica = ulica;
        this.numerBudynku = numerBudynku;
    }
}