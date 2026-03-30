namespace Zadanie_2_POIG;

public class Sala
{
    public Wydzial NazwaWydzialu { get; set; }
    public TypSali TypSali { get; set; }
    public int IloscMiejsc { get; set; }
    public string NumerSali { get; set; }

    public Sala() { }
    public Sala(Wydzial nazwaWydzialu, TypSali typSali, int iloscMiejsc, string numerSali)
    {
        NazwaWydzialu = nazwaWydzialu;
        TypSali = typSali;
        IloscMiejsc = iloscMiejsc;
        NumerSali = numerSali;
    }

    public override string ToString()
    {
        return $"{NazwaWydzialu} -  {TypSali} - {IloscMiejsc} -  {NumerSali}";
    }
}