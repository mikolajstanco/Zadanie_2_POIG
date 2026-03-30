namespace Zadanie_2_POIG;

using System.ComponentModel;

public partial class Form1 : Form
{
    BindingList<Wydzial> listaWydzialow = new BindingList<Wydzial>();
    BindingList<Prowadzacy> listaProwadzacych = new BindingList<Prowadzacy>();
    BindingList<Sala> listaSal = new BindingList<Sala>();
    BindingList<Rezerwacja> listaRezerwacji = new BindingList<Rezerwacja>();
    public Form1()
    {
        InitializeComponent();


        // Testowe Obiekty
        Wydzial testowyWydzial = new Wydzial("Testowy Wydział", new Adres("Gliwice", "Majonezowa", 13, "44-100"));
        Prowadzacy testowyProwadzacy = new Prowadzacy("Grzegorz", "Brzęczyszczykiewicz");
        listaSal.Add(new Sala(testowyWydzial, TypSali.Komputerowa, 13, "37a"));
        listaProwadzacych.Add(testowyProwadzacy);

        DateOnly data = new DateOnly(2024, 6, 20);
        TimeOnly godzinaRozpoczecia = new TimeOnly(10, 0);
        TimeOnly godzinaZakonczenia = new TimeOnly(12, 0);

        listaRezerwacji.Add(new Rezerwacja(testowyProwadzacy, testowyWydzial, listaSal[0], data, godzinaRozpoczecia, godzinaZakonczenia));


        listaWydzialow.Add(new Wydzial("Matematyki Stosowanej", new Adres("Gliwice", "Kaszubska", 23, "44-100")));
        listaWydzialow.Add(new Wydzial("Automatyki Elektroniki i Informatyki", new Adres("Gliwice", "Akademicka", 16, "44-100")));
        listaWydzialow.Add(new Wydzial("Budownictwa", new Adres("Gliwice", "Akademicka", 5, "44-100")));



        //Dodaj informacje
        ComboBox_Wydzialy_dodajSale.DataSource = listaWydzialow;
        ComboBox_TypSali.DataSource = Enum.GetValues(typeof(TypSali));
        //Rezerwacja
        combo_box_wydzialRezerwacja.DataSource = listaWydzialow;
        comboBox_prowadzacyRezerwacja.DataSource = listaProwadzacych;
        //comboBox_salaRezerwacja.DataSource = listaSal;

        listBox_rezerwacjeAll.DataSource = listaRezerwacji;

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

        textBox_imieProwadzacego.Clear();
        textBox_nazwiskoProwadzacego.Clear();
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


        text_NumerSali.Clear();
        textBox_iloscMiejsc.Clear();

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

    private void button_dodajWydzial_Click(object sender, EventArgs e)
    {
        string nazwaWydzialu = textBox_dodajWydzialNazwa.Text;
        string miasto = textBox_dodajWydzialMiasto.Text;
        string kod1 = textBox_dodajWydzialKod1.Text;
        string kod2 = textBox_dodajWydzialKod2.Text;
        string kod = kod1 + "-" + kod2;
        string ulica = textBox_dodajWydzialUlica.Text;
        string numer = textBox_dodajWydzialNumer.Text;

        listaWydzialow.Add(new Wydzial(nazwaWydzialu, new Adres(miasto, ulica, int.Parse(numer), kod)));

        textBox_dodajWydzialNazwa.Clear();
        textBox_dodajWydzialMiasto.Clear();
        textBox_dodajWydzialKod1.Clear();
        textBox_dodajWydzialKod2.Clear();
        textBox_dodajWydzialUlica.Clear();
        textBox_dodajWydzialNumer.Clear();
    }

    private void button_zarezerwuj_Click(object sender, EventArgs e)
    {
        Prowadzacy prowadzacy = (Prowadzacy)comboBox_prowadzacyRezerwacja.SelectedItem;
        Wydzial wydzial = (Wydzial)combo_box_wydzialRezerwacja.SelectedItem;
        DateOnly data = DateOnly.FromDateTime(dateTimePicker1.Value);
        TimeOnly godzinaRozpoczecia = TimeOnly.Parse(dateTimePicker_godzinaRozpoczecia.Text);
        TimeOnly godzinaZakonczenia = TimeOnly.Parse(dateTimePicker_godzinaZakonczenia.Text);

        listaRezerwacji.Add(new Rezerwacja(prowadzacy, wydzial, (Sala)listaSalNaWybranymWydziale.SelectedItem, data, godzinaRozpoczecia, godzinaZakonczenia));

    }
}