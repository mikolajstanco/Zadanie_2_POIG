namespace Zadanie_2_POIG;

using System.ComponentModel;
using System.Data; // Dodane dla list LINQ

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
        Wydzial testowyWydzial = new Wydzial("Matematyki Stosowanej", new Adres("Gliwice", "Kaszubska", 23, "44-100"));
        listaWydzialow.Add(testowyWydzial);
        Prowadzacy testowyProwadzacy = new Prowadzacy("Grzegorz", "Brzęczyszczykiewicz");

        listaSal.Add(new Sala(testowyWydzial, TypSali.Komputerowa, 13, "37a"));
        listaProwadzacych.Add(testowyProwadzacy);

        DateOnly data = new DateOnly(2026, 03, 30);
        TimeOnly godzinaRozpoczecia = new TimeOnly(10, 0);
        TimeOnly godzinaZakonczenia = new TimeOnly(12, 0);

        listaRezerwacji.Add(new Rezerwacja(testowyProwadzacy, testowyWydzial, listaSal[0], data, godzinaRozpoczecia, godzinaZakonczenia));

        listaWydzialow.Add(new Wydzial("Automatyki Elektroniki i Informatyki", new Adres("Gliwice", "Akademicka", 16, "44-100")));
        listaWydzialow.Add(new Wydzial("Budownictwa", new Adres("Gliwice", "Akademicka", 5, "44-100")));

        // Dodaj informacje
        ComboBox_Wydzialy_dodajSale.DataSource = listaWydzialow;
        ComboBox_TypSali.DataSource = Enum.GetValues(typeof(TypSali));

        // Rezerwacja
        combo_box_wydzialRezerwacja.DataSource = listaWydzialow;
        comboBox_prowadzacyRezerwacja.DataSource = listaProwadzacych;

        // Info (Wszystkie informacje)
        listBox_infoWydzialy.DataSource = listaWydzialow;
        // listBox_infoWydzialy.DisplayMember = "PelneDane"; // Zakomentowane, dopóki nie dodasz właściwości PelneDane do klasy Wydzial
        listBox_infoProwadzacy.DataSource = listaProwadzacych;
        listBox_infoSale.DataSource = listaSal;

        // Ustawienie domyślnego widoku wszystkich rezerwacji
        listBox_rezerwacjeAll.DataSource = listaRezerwacji;

        OdswiezFiltry();
    }


    private void OdswiezFiltry()
    {
        // 1. Filtr Prowadzący
        List<Prowadzacy> filtrProwadzacy = new List<Prowadzacy>();
        filtrProwadzacy.Add(new Prowadzacy("--- Wszyscy ---", ""));
        filtrProwadzacy.AddRange(listaProwadzacych);
        comboBox_FiltrProwadzacy.DataSource = filtrProwadzacy;

        // 2. Filtr Wydziały
        List<Wydzial> filtrWydzialy = new List<Wydzial>();
        filtrWydzialy.Add(new Wydzial("--- Wszystkie ---", new Adres("", "", 0, "")));
        filtrWydzialy.AddRange(listaWydzialow);
        comboBox_FiltrWydzial.DataSource = filtrWydzialy;

        // 3. Filtr Typ Sali
        List<string> filtrTypSali = new List<string>();
        filtrTypSali.Add("--- Wszystkie ---");
        foreach (TypSali typ in Enum.GetValues(typeof(TypSali)))
        {
            filtrTypSali.Add(typ.ToString());
        }
        comboBox_FiltrTypSali.DataSource = filtrTypSali;
    }


    private void button_Szukaj_Click(object sender, EventArgs e)
    {
        List<Rezerwacja> przefiltrowaneRezerwacje = new List<Rezerwacja>();

        foreach (Rezerwacja rez in listaRezerwacji)
        {
            bool pasujeProwadzacy = true;
            bool pasujeWydzial = true;
            bool pasujeTypSali = true;

            if (comboBox_FiltrProwadzacy.SelectedIndex > 0)
            {
                if (rez.Prowadzacy != (Prowadzacy)comboBox_FiltrProwadzacy.SelectedItem)
                    pasujeProwadzacy = false;
            }

            if (comboBox_FiltrWydzial.SelectedIndex > 0)
            {
                if (rez.Wydzial != (Wydzial)comboBox_FiltrWydzial.SelectedItem)
                    pasujeWydzial = false;
            }

            if (comboBox_FiltrTypSali.SelectedIndex > 0)
            {
                if (rez.Sala.TypSali.ToString() != comboBox_FiltrTypSali.SelectedItem.ToString())
                    pasujeTypSali = false;
            }

            if (pasujeProwadzacy && pasujeWydzial && pasujeTypSali)
            {
                przefiltrowaneRezerwacje.Add(rez);
            }
        }


        listBox_rezerwacjeAll.DataSource = przefiltrowaneRezerwacje;
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

        OdswiezFiltry();
    }

    private void button_dodajSale_Click(object sender, EventArgs e)
    {
        string numerSali = text_NumerSali.Text;
        int iloscMiejsc = int.Parse(textBox_iloscMiejsc.Text);
        listaSal.Add(new Sala((Wydzial)ComboBox_Wydzialy_dodajSale.SelectedItem, (TypSali)ComboBox_TypSali.SelectedItem, iloscMiejsc, numerSali));
        text_NumerSali.Clear();
        textBox_iloscMiejsc.Clear();
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

        // Aktualizujemy filtry po dodaniu nowego!
        OdswiezFiltry();
    }

    private void button_zarezerwuj_Click(object sender, EventArgs e)
    {
        Prowadzacy prowadzacy = (Prowadzacy)comboBox_prowadzacyRezerwacja.SelectedItem;
        Wydzial wydzial = (Wydzial)combo_box_wydzialRezerwacja.SelectedItem;
        DateOnly data = DateOnly.FromDateTime(dateTimePicker1.Value);
        TimeOnly godzinaRozpoczecia = TimeOnly.Parse(dateTimePicker_godzinaRozpoczecia.Text);
        TimeOnly godzinaZakonczenia = TimeOnly.Parse(dateTimePicker_godzinaZakonczenia.Text);

        foreach (Rezerwacja rezka in listaRezerwacji)
        {
            if (rezka.Sala == (Sala)listaSalNaWybranymWydziale.SelectedItem && rezka.Data == data)
            {
                if ((godzinaRozpoczecia >= rezka.GodzinaRozpoczecia && godzinaRozpoczecia < rezka.GodzinaZakonczenia) ||
                    (godzinaZakonczenia > rezka.GodzinaRozpoczecia && godzinaZakonczenia <= rezka.GodzinaZakonczenia) ||
                    (godzinaRozpoczecia <= rezka.GodzinaRozpoczecia && godzinaZakonczenia >= rezka.GodzinaZakonczenia))
                {
                    MessageBox.Show("Wybrana sala jest już zarezerwowana w tym terminie. Proszę wybrać inną salę lub zmienić datę/godzinę rezerwacji.");
                    return;
                }
            }
        }

        listaRezerwacji.Add(new Rezerwacja(prowadzacy, wydzial, (Sala)listaSalNaWybranymWydziale.SelectedItem, data, godzinaRozpoczecia, godzinaZakonczenia));
        MessageBox.Show("Pomyślnie zarezerwowano salę");
    }

    private void listaSalNaWybranymWydziale_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Twoja stara logika
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Rezerwacja wybranaRezerwacja = (Rezerwacja)listBox_rezerwacjeAll.SelectedItem;
        if (wybranaRezerwacja != null)
        {
            listaRezerwacji.Remove(wybranaRezerwacja);
            button_Szukaj_Click(null, null);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void comboBox_FiltrTypSali_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}