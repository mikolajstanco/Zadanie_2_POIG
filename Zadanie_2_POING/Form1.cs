namespace Zadanie_2_POIG;

using System.Linq;
using System.ComponentModel;
using System.Data;

public partial class Form1 : Form
{
    MagazynDanych magazyn = new MagazynDanych();
    public Form1()
    {
        InitializeComponent();

        if (magazyn.Dane.Wydzialy.Count == 0)
        {
            Wydzial testowyWydzial = new Wydzial("Matematyki Stosowanej", new Adres("Gliwice", "Kaszubska", 23, "44-100"));
            magazyn.Dane.Wydzialy.Add(testowyWydzial);

            Prowadzacy testowyProwadzacy = new Prowadzacy("Grzegorz", "Brzęczyszczykiewicz");
            magazyn.Dane.Prowadzacy.Add(testowyProwadzacy);

            magazyn.Dane.Sale.Add(new Sala(testowyWydzial, TypSali.Komputerowa, 13, "37a"));

            DateOnly data = new DateOnly(2026, 03, 30);
            TimeOnly godzinaRozpoczecia = new TimeOnly(10, 0);
            TimeOnly godzinaZakonczenia = new TimeOnly(12, 0);

            magazyn.Dane.Rezerwacje.Add(new Rezerwacja(testowyProwadzacy, testowyWydzial, magazyn.Dane.Sale[0], data, godzinaRozpoczecia, godzinaZakonczenia));

            magazyn.Dane.Wydzialy.Add(new Wydzial("Automatyki Elektroniki i Informatyki", new Adres("Gliwice", "Akademicka", 16, "44-100")));
            magazyn.Dane.Wydzialy.Add(new Wydzial("Budownictwa", new Adres("Gliwice", "Akademicka", 5, "44-100")));
        }

        ComboBox_Wydzialy_dodajSale.DataSource = magazyn.Dane.Wydzialy;
        ComboBox_TypSali.DataSource = Enum.GetValues(typeof(TypSali));

        combo_box_wydzialRezerwacja.DataSource = magazyn.Dane.Wydzialy;
        comboBox_prowadzacyRezerwacja.DataSource = magazyn.Dane.Prowadzacy;

        listBox_infoWydzialy.DataSource = magazyn.Dane.Wydzialy;
        listBox_infoWydzialy.DisplayMember = "PelneDane";

        listBox_infoProwadzacy.DataSource = magazyn.Dane.Prowadzacy;
        listBox_infoSale.DataSource = magazyn.Dane.Sale;
        listBox_rezerwacjeAll.DataSource = magazyn.Dane.Rezerwacje;

        OdswiezFiltry();
    }

    private void OdswiezFiltry()
    {
        List<Prowadzacy> filtrProwadzacy = new List<Prowadzacy>();
        filtrProwadzacy.Add(new Prowadzacy("--- Wszyscy ---", ""));
        filtrProwadzacy.AddRange(magazyn.Dane.Prowadzacy);
        comboBox_FiltrProwadzacy.DataSource = filtrProwadzacy;

        List<Wydzial> filtrWydzialy = new List<Wydzial>();
        filtrWydzialy.Add(new Wydzial("--- Wszystkie ---", new Adres("", "", 0, "")));
        filtrWydzialy.AddRange(magazyn.Dane.Wydzialy);
        comboBox_FiltrWydzial.DataSource = filtrWydzialy;

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

        foreach (Rezerwacja rez in magazyn.Dane.Rezerwacje)
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
        string bledy = "";

        if (!Walidator.CzyTylkoLitery(imie))
            bledy += "Imię jest wymagane i może zawierać tylko litery.\n";

        if (!Walidator.CzyTylkoLitery(nazwisko))
            bledy += "Nazwisko jest wymagane i może zawierać tylko litery.\n";

        if (bledy.Length > 0)
        {
            MessageBox.Show(bledy, "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        magazyn.Dane.Prowadzacy.Add(new Prowadzacy(imie, nazwisko));

        textBox_imieProwadzacego.Clear();
        textBox_nazwiskoProwadzacego.Clear();
        OdswiezFiltry();
        MessageBox.Show("Dodano Prowadzącego!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void button_dodajSale_Click(object sender, EventArgs e)
    {
        string numerSali = text_NumerSali.Text;
        string miejscaTekst = textBox_iloscMiejsc.Text;
        int iloscMiejsc;

        string bledy = "";

        if (!Walidator.CzyPoprawnyTekst(numerSali))
            bledy += "Numer sali nie może być pusty.\n";

        if (!Walidator.CzyPoprawnaLiczba(miejscaTekst, out iloscMiejsc))
            bledy += "Ilość miejsc musi być liczbą całkowitą większą od zera.\n";

        if (bledy.Length > 0)
        {
            MessageBox.Show(bledy, "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        magazyn.Dane.Sale.Add(new Sala((Wydzial)ComboBox_Wydzialy_dodajSale.SelectedItem, (TypSali)ComboBox_TypSali.SelectedItem, iloscMiejsc, numerSali));

        text_NumerSali.Clear();
        textBox_iloscMiejsc.Clear();
    }

    private void combo_box_wydzialRezerwacja_SelectedIndexChanged(object sender, EventArgs e)
    {
        List<Sala> listaSalNaWydziale = new List<Sala>();
        foreach (Sala sala in magazyn.Dane.Sale)
        {
            if (sala.Wydzial == combo_box_wydzialRezerwacja.SelectedItem)
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
        string ulica = textBox_dodajWydzialUlica.Text;

        int numerBudynku;
        string bledy = "";

        // Sprawdzamy wszystkie pola po kolei
        if (!Walidator.CzyPoprawnyTekst(nazwaWydzialu))
            bledy += "Nazwa wydziału jest wymagana.\n";

        if (!Walidator.CzyTylkoLitery(miasto))
            bledy += "Miasto jest wymagane i może zawierać tylko litery.\n";

        if (!Walidator.CzyPoprawnyTekst(ulica))
            bledy += "Ulica jest wymagana.\n";

        if (!Walidator.CzyPoprawnaLiczba(textBox_dodajWydzialNumer.Text, out numerBudynku))
            bledy += "Numer budynku musi być liczbą całkowitą większą od zera.\n";

        if (!Walidator.CzyPoprawnyKodPocztowy(kod1, kod2))
            bledy += "Kod pocztowy musi składać się z 2 cyfr, myślnika i 3 cyfr.\n";

        // Jeśli były jakieś błędy, przerywamy
        if (bledy.Length > 0)
        {
            MessageBox.Show(bledy, "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        string kod = kod1 + "-" + kod2;
        magazyn.Dane.Wydzialy.Add(new Wydzial(nazwaWydzialu, new Adres(miasto, ulica, numerBudynku, kod)));

        textBox_dodajWydzialNazwa.Clear();
        textBox_dodajWydzialMiasto.Clear();
        textBox_dodajWydzialKod1.Clear();
        textBox_dodajWydzialKod2.Clear();
        textBox_dodajWydzialUlica.Clear();
        textBox_dodajWydzialNumer.Clear();
        OdswiezFiltry();
        MessageBox.Show("Dodano Wydział!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void button_zarezerwuj_Click(object sender, EventArgs e)
    {
        string bledy = "";

        if (comboBox_prowadzacyRezerwacja.SelectedItem == null) bledy += "Wybierz prowadzącego.\n";
        if (combo_box_wydzialRezerwacja.SelectedItem == null) bledy += "Wybierz wydział.\n";
        if (listaSalNaWybranymWydziale.SelectedItem == null) bledy += "Wybierz salę.\n";

        DateOnly data = DateOnly.FromDateTime(dateTimePicker1.Value);
        if (data < DateOnly.FromDateTime(DateTime.Now))
            bledy += "Data rezerwacji nie może być datą z przeszłości.\n";

        TimeOnly godzinaRozpoczecia;
        TimeOnly godzinaZakonczenia;

        bool czasRozpOk = TimeOnly.TryParse(dateTimePicker_godzinaRozpoczecia.Text, out godzinaRozpoczecia);
        bool czasZakOk = TimeOnly.TryParse(dateTimePicker_godzinaZakonczenia.Text, out godzinaZakonczenia);

        if (!czasRozpOk || !czasZakOk)
        {
            bledy += "Nieprawidłowy format czasu.\n";
        }
        else if (godzinaRozpoczecia >= godzinaZakonczenia)
        {
            bledy += "Godzina zakończenia musi być późniejsza niż godzina rozpoczęcia.\n";
        }

        if (bledy.Length > 0)
        {
            MessageBox.Show(bledy, "Błąd walidacji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        Prowadzacy prowadzacy = (Prowadzacy)comboBox_prowadzacyRezerwacja.SelectedItem;
        Wydzial wydzial = (Wydzial)combo_box_wydzialRezerwacja.SelectedItem;
        Sala wybranaSala = (Sala)listaSalNaWybranymWydziale.SelectedItem;

        foreach (Rezerwacja rezka in magazyn.Dane.Rezerwacje)
        {
            if (rezka.Sala == wybranaSala && rezka.Data == data)
            {
                if ((godzinaRozpoczecia >= rezka.GodzinaRozpoczecia && godzinaRozpoczecia < rezka.GodzinaZakonczenia) ||
                    (godzinaZakonczenia > rezka.GodzinaRozpoczecia && godzinaZakonczenia <= rezka.GodzinaZakonczenia) ||
                    (godzinaRozpoczecia <= rezka.GodzinaRozpoczecia && godzinaZakonczenia >= rezka.GodzinaZakonczenia))
                {
                    MessageBox.Show("Wybrana sala jest już zarezerwowana w tym terminie. Proszę wybrać inną salę lub zmienić datę/godzinę rezerwacji.", "Konflikt terminów", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        // 5. Wszystko się zgadza, rezerwujemy!
        magazyn.Dane.Rezerwacje.Add(new Rezerwacja(prowadzacy, wydzial, wybranaSala, data, godzinaRozpoczecia, godzinaZakonczenia));
        MessageBox.Show("Pomyślnie zarezerwowano salę", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void button_usunRezerwacje(object sender, EventArgs e)
    {
        Rezerwacja wybranaRezerwacja = (Rezerwacja)listBox_rezerwacjeAll.SelectedItem;
        if (wybranaRezerwacja != null)
        {
            DialogResult decyzja = MessageBox.Show("Czy na pewno chcesz usunąć tę rezerwację?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (decyzja == DialogResult.Yes)
            {
                magazyn.Dane.Rezerwacje.Remove(wybranaRezerwacja);
                button_Szukaj_Click(null, null);
                MessageBox.Show("Usunięto pomyślnie.");
            }
            else
            {
                return;
            }
         
        }
        else
        {
            MessageBox.Show("Nie wybrano żadnej rezerwacji do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
    }

    private void button_usunWydzial_Click(object sender, EventArgs e)
    {
        Wydzial wybranyWydzial = (Wydzial)listBox_infoWydzialy.SelectedItem;

        // Zabezpieczenie, jeśli użytkownik nic nie zaznaczył
        if (wybranyWydzial == null) return;

        foreach (Rezerwacja rez in magazyn.Dane.Rezerwacje)
        {
            if (rez.Wydzial == wybranyWydzial)
            {
                MessageBox.Show("Nie można usunąć wydziału, który ma aktywne rezerwacje. Proszę najpierw usunąć jego rezerwacje.");
                return;
            }
        }

        DialogResult decyzja = MessageBox.Show("Usunięcie wydziału spowoduje usunięcie podpiętych sal. Czy kontynuować?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (decyzja == DialogResult.Yes)
        {
            var saleDoUsuniecia = magazyn.Dane.Sale.Where(s => s.Wydzial == wybranyWydzial).ToList();

            foreach (Sala sala in saleDoUsuniecia)
            {
                magazyn.Dane.Sale.Remove(sala);
            }

            magazyn.Dane.Wydzialy.Remove(wybranyWydzial);

            MessageBox.Show("Pomyślnie usunięto wydział i sale");
        }
        OdswiezFiltry();

    }

    private void button_usunProwadzacego_Click(object sender, EventArgs e)
    {
        Prowadzacy wybranyProwadzacy = (Prowadzacy)listBox_infoProwadzacy.SelectedItem;

        if (wybranyProwadzacy == null) return;

        foreach (Rezerwacja rez in magazyn.Dane.Rezerwacje)
        {
            if (rez.Prowadzacy == wybranyProwadzacy)
            {
                MessageBox.Show("Nie można usunąć prowadzącego, który ma aktywne rezerwacje. Proszę najpierw usunąć jego rezerwacje.");
                return;
            }
        }
        magazyn.Dane.Prowadzacy.Remove(wybranyProwadzacy);
        MessageBox.Show("Pomyślnie usunięto prowadzącego");
        OdswiezFiltry();
    }

    private void button_usunSale_Click(object sender, EventArgs e)
    {
        Sala wybranaSala = (Sala)listBox_infoSale.SelectedItem;

        if (wybranaSala == null) return;

        foreach (Rezerwacja rez in magazyn.Dane.Rezerwacje)
        {
            if (rez.Sala == wybranaSala)
            {
                MessageBox.Show("Nie można usunąć sali, która ma aktywne rezerwacje. Proszę najpierw usunąć jej rezerwacje.");
                return;
            }
        }
        magazyn.Dane.Sale.Remove(wybranaSala);
        MessageBox.Show("Pomyślnie usunięto salę");
        OdswiezFiltry();
    }
}