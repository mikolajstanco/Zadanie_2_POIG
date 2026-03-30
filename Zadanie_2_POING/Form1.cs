namespace Zadanie_2_POING;

public partial class Form1 : Form
{
    List<Wydzial> listWydzialow = new List<Wydzial>();
    List<Prowadzacy> listaProwadzacych = new List<Prowadzacy>();
    List<Sala> listaSal = new List<Sala>();
    List<Rezerwacja> listaRezerwacji = new List<Rezerwacja>();
    public Form1()
    {
        InitializeComponent();


        // Testowe Obiekty
        Wydzial testowyWydzial = new Wydzial("Testowy Wydział", new Adres("Gliwice", "Majonezowa", 13));
        Prowadzacy testowyProwadzacy = new Prowadzacy("Grzegorz", "Brzęczyszczykiewicz");
        listaSal.Add(new Sala(testowyWydzial, TypSali.Komputerowa, 13, "37a"));
        listaProwadzacych.Add(testowyProwadzacy);
        
        DateOnly data = new DateOnly(2024, 6, 20);
        TimeOnly godzinaRozpoczecia = new TimeOnly(10, 0);
        TimeOnly godzinaZakonczenia = new TimeOnly(12, 0);

        listaRezerwacji.Add(new Rezerwacja(testowyWydzial, listaSal[0], data, godzinaRozpoczecia, godzinaZakonczenia));


        listWydzialow.Add(new Wydzial("Matematyki Stosowanej", new Adres("Gliwice", "Kaszubska", 23)));
        listWydzialow.Add(new Wydzial("Automatyki Elektroniki i Informatyki", new Adres("Gliwice", "Akademicka", 16)));
        listWydzialow.Add(new Wydzial("Budownictwa", new Adres("Gliwice", "Akademicka", 5)));



        //Dodaj informacje
        ComboBox_Wydzialy_dodajSale.DataSource = listWydzialow;
        ComboBox_TypSali.DataSource = Enum.GetValues(typeof(TypSali));
        //Rezerwacja
        combo_box_wydzialRezerwacja.DataSource = listWydzialow;
        comboBox_prowadzacyRezerwacja.DataSource = listaProwadzacych;
        //comboBox_salaRezerwacja.DataSource = listaSal;

    }

    private void ComboBox_wydzialy_on_typing(object sender, KeyPressEventArgs e)
    {
        e.Handled = true;
    }

    private void button_dodajProwadzacego_Click(object sender, EventArgs e)
    {
        string imie = textBox_imieProwadzacego.Text;
        string nazwisko = textBox_nazwiskoProwadzacego.Text;

        listaProwadzacych.Add(new Prowadzacy(imie, nazwisko));
        //string lista = "";
        //foreach (Prowadzacy prowadzacy in listaProwadzacych)
        //{
        //    lista += prowadzacy;
        //    lista += "\n";
        //}

        //MessageBox.Show(lista);
    }

    private void button_dodajSale_Click(object sender, EventArgs e)
    {
        string numerSali = text_NumerSali.Text;
        int iloscMiejsc = int.Parse(textBox_iloscMiejsc.Text);

        listaSal.Add(new Sala((Wydzial)ComboBox_Wydzialy_dodajSale.SelectedItem, (TypSali)ComboBox_TypSali.SelectedItem, iloscMiejsc, numerSali));

        //string lista = "";
        //foreach (Sala sala in listaSal)
        //{
        //    lista += sala;
        //    lista += "\n";
        //}

        //MessageBox.Show(lista);


    }

    private void label9_Click(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    private void combo_box_wydzialRezerwacja_SelectedIndexChanged(object sender, EventArgs e)
    {
        List<Sala> listaSalNaWydziale = new List<Sala>();

        foreach (Sala sala in listaSal)
        {
            if (sala.NazwaWydzialu == combo_box_wydzialRezerwacja.SelectedItem)
            {
                listaSalNaWydziale.Add(sala);
            }
        }

        listaSalNaWybranymWydziale.DataSource = listaSalNaWydziale;
    }
}