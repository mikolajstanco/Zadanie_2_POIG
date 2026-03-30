namespace Zadanie_2_POIG;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        combo_box_wydzialRezerwacja = new ComboBox();
        label1 = new Label();
        tab = new TabControl();
        TabDodajInformacje = new TabPage();
        groupBox3 = new GroupBox();
        button_dodajWydzial = new Button();
        textBox_dodajWydzialKod2 = new TextBox();
        label17 = new Label();
        textBox_dodajWydzialKod1 = new TextBox();
        label16 = new Label();
        label15 = new Label();
        label14 = new Label();
        label13 = new Label();
        textBox_dodajWydzialNumer = new TextBox();
        textBox_dodajWydzialUlica = new TextBox();
        textBox_dodajWydzialMiasto = new TextBox();
        textBox_dodajWydzialNazwa = new TextBox();
        label6 = new Label();
        GroupBox_Sala = new GroupBox();
        label7 = new Label();
        textBox_iloscMiejsc = new TextBox();
        ComboBox_TypSali = new ComboBox();
        label5 = new Label();
        button_dodajSale = new Button();
        label4 = new Label();
        ComboBox_Wydzialy_dodajSale = new ComboBox();
        label3 = new Label();
        text_NumerSali = new TextBox();
        GroupBox_Prowadzacy = new GroupBox();
        button_dodajProwadzacego = new Button();
        textBox_nazwiskoProwadzacego = new TextBox();
        textBox_imieProwadzacego = new TextBox();
        label2 = new Label();
        LabelImie = new Label();
        TabZarezerwujSale = new TabPage();
        button_zarezerwuj = new Button();
        listaSalNaWybranymWydziale = new ListBox();
        salaBindingSource = new BindingSource(components);
        dateTimePicker_godzinaZakonczenia = new DateTimePicker();
        dateTimePicker_godzinaRozpoczecia = new DateTimePicker();
        label12 = new Label();
        label11 = new Label();
        dateTimePicker1 = new DateTimePicker();
        label10 = new Label();
        label9 = new Label();
        comboBox_prowadzacyRezerwacja = new ComboBox();
        label8 = new Label();
        TabZarzadzanieRezerwacjami = new TabPage();
        listBox_rezerwacjeAll = new ListBox();
        rezerwacjaBindingSource = new BindingSource(components);
        TabWszystkieInformacje = new TabPage();
        tabControl1 = new TabControl();
        tabPage1 = new TabPage();
        tabPage2 = new TabPage();
        panel_ReservationLive = new Panel();
        tab.SuspendLayout();
        TabDodajInformacje.SuspendLayout();
        groupBox3.SuspendLayout();
        GroupBox_Sala.SuspendLayout();
        GroupBox_Prowadzacy.SuspendLayout();
        TabZarezerwujSale.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)salaBindingSource).BeginInit();
        TabZarzadzanieRezerwacjami.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)rezerwacjaBindingSource).BeginInit();
        TabWszystkieInformacje.SuspendLayout();
        tabControl1.SuspendLayout();
        SuspendLayout();
        // 
        // combo_box_wydzialRezerwacja
        // 
        combo_box_wydzialRezerwacja.FormattingEnabled = true;
        combo_box_wydzialRezerwacja.Location = new Point(139, 81);
        combo_box_wydzialRezerwacja.Name = "combo_box_wydzialRezerwacja";
        combo_box_wydzialRezerwacja.Size = new Size(335, 23);
        combo_box_wydzialRezerwacja.TabIndex = 0;
        combo_box_wydzialRezerwacja.SelectedIndexChanged += combo_box_wydzialRezerwacja_SelectedIndexChanged;
        combo_box_wydzialRezerwacja.KeyPress += ComboBox_wydzialy_on_typing;
        // 
        // label1
        // 
        label1.Location = new Point(51, 82);
        label1.Name = "label1";
        label1.Size = new Size(60, 23);
        label1.TabIndex = 1;
        label1.Text = "Wydział";
        // 
        // tab
        // 
        tab.Controls.Add(TabDodajInformacje);
        tab.Controls.Add(TabZarezerwujSale);
        tab.Controls.Add(TabZarzadzanieRezerwacjami);
        tab.Controls.Add(TabWszystkieInformacje);
        tab.Location = new Point(0, -1);
        tab.Name = "tab";
        tab.SelectedIndex = 0;
        tab.Size = new Size(1025, 551);
        tab.TabIndex = 2;
        // 
        // TabDodajInformacje
        // 
        TabDodajInformacje.Controls.Add(groupBox3);
        TabDodajInformacje.Controls.Add(GroupBox_Sala);
        TabDodajInformacje.Controls.Add(GroupBox_Prowadzacy);
        TabDodajInformacje.Location = new Point(4, 24);
        TabDodajInformacje.Name = "TabDodajInformacje";
        TabDodajInformacje.Size = new Size(1017, 523);
        TabDodajInformacje.TabIndex = 2;
        TabDodajInformacje.Text = "Dodaj informacje";
        TabDodajInformacje.ToolTipText = "sa;a";
        TabDodajInformacje.UseVisualStyleBackColor = true;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(button_dodajWydzial);
        groupBox3.Controls.Add(textBox_dodajWydzialKod2);
        groupBox3.Controls.Add(label17);
        groupBox3.Controls.Add(textBox_dodajWydzialKod1);
        groupBox3.Controls.Add(label16);
        groupBox3.Controls.Add(label15);
        groupBox3.Controls.Add(label14);
        groupBox3.Controls.Add(label13);
        groupBox3.Controls.Add(textBox_dodajWydzialNumer);
        groupBox3.Controls.Add(textBox_dodajWydzialUlica);
        groupBox3.Controls.Add(textBox_dodajWydzialMiasto);
        groupBox3.Controls.Add(textBox_dodajWydzialNazwa);
        groupBox3.Controls.Add(label6);
        groupBox3.Location = new Point(713, 29);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(270, 355);
        groupBox3.TabIndex = 2;
        groupBox3.TabStop = false;
        groupBox3.Text = "Wydział";
        // 
        // button_dodajWydzial
        // 
        button_dodajWydzial.Location = new Point(81, 223);
        button_dodajWydzial.Name = "button_dodajWydzial";
        button_dodajWydzial.Size = new Size(136, 90);
        button_dodajWydzial.TabIndex = 11;
        button_dodajWydzial.Text = "Dodaj Wydział";
        button_dodajWydzial.UseVisualStyleBackColor = true;
        button_dodajWydzial.Click += button_dodajWydzial_Click;
        // 
        // textBox_dodajWydzialKod2
        // 
        textBox_dodajWydzialKod2.Location = new Point(170, 105);
        textBox_dodajWydzialKod2.Name = "textBox_dodajWydzialKod2";
        textBox_dodajWydzialKod2.Size = new Size(47, 23);
        textBox_dodajWydzialKod2.TabIndex = 21;
        // 
        // label17
        // 
        label17.Location = new Point(143, 108);
        label17.Name = "label17";
        label17.Size = new Size(25, 23);
        label17.TabIndex = 21;
        label17.Text = "-";
        // 
        // textBox_dodajWydzialKod1
        // 
        textBox_dodajWydzialKod1.Location = new Point(109, 105);
        textBox_dodajWydzialKod1.Name = "textBox_dodajWydzialKod1";
        textBox_dodajWydzialKod1.Size = new Size(28, 23);
        textBox_dodajWydzialKod1.TabIndex = 20;
        // 
        // label16
        // 
        label16.Location = new Point(7, 108);
        label16.Name = "label16";
        label16.Size = new Size(96, 23);
        label16.TabIndex = 19;
        label16.Text = "Kod Pocztowy";
        // 
        // label15
        // 
        label15.Location = new Point(16, 178);
        label15.Name = "label15";
        label15.Size = new Size(60, 23);
        label15.TabIndex = 17;
        label15.Text = "Numer";
        // 
        // label14
        // 
        label14.Location = new Point(16, 140);
        label14.Name = "label14";
        label14.Size = new Size(60, 23);
        label14.TabIndex = 16;
        label14.Text = "Ulica";
        // 
        // label13
        // 
        label13.Location = new Point(16, 76);
        label13.Name = "label13";
        label13.Size = new Size(60, 23);
        label13.TabIndex = 15;
        label13.Text = "Miasto";
        // 
        // textBox_dodajWydzialNumer
        // 
        textBox_dodajWydzialNumer.Location = new Point(82, 175);
        textBox_dodajWydzialNumer.Name = "textBox_dodajWydzialNumer";
        textBox_dodajWydzialNumer.Size = new Size(182, 23);
        textBox_dodajWydzialNumer.TabIndex = 14;
        // 
        // textBox_dodajWydzialUlica
        // 
        textBox_dodajWydzialUlica.Location = new Point(82, 140);
        textBox_dodajWydzialUlica.Name = "textBox_dodajWydzialUlica";
        textBox_dodajWydzialUlica.Size = new Size(182, 23);
        textBox_dodajWydzialUlica.TabIndex = 13;
        // 
        // textBox_dodajWydzialMiasto
        // 
        textBox_dodajWydzialMiasto.Location = new Point(82, 76);
        textBox_dodajWydzialMiasto.Name = "textBox_dodajWydzialMiasto";
        textBox_dodajWydzialMiasto.Size = new Size(182, 23);
        textBox_dodajWydzialMiasto.TabIndex = 12;
        // 
        // textBox_dodajWydzialNazwa
        // 
        textBox_dodajWydzialNazwa.Location = new Point(82, 44);
        textBox_dodajWydzialNazwa.Name = "textBox_dodajWydzialNazwa";
        textBox_dodajWydzialNazwa.Size = new Size(182, 23);
        textBox_dodajWydzialNazwa.TabIndex = 11;
        // 
        // label6
        // 
        label6.Location = new Point(16, 47);
        label6.Name = "label6";
        label6.Size = new Size(60, 23);
        label6.TabIndex = 11;
        label6.Text = "Nazwa";
        // 
        // GroupBox_Sala
        // 
        GroupBox_Sala.Controls.Add(label7);
        GroupBox_Sala.Controls.Add(textBox_iloscMiejsc);
        GroupBox_Sala.Controls.Add(ComboBox_TypSali);
        GroupBox_Sala.Controls.Add(label5);
        GroupBox_Sala.Controls.Add(button_dodajSale);
        GroupBox_Sala.Controls.Add(label4);
        GroupBox_Sala.Controls.Add(ComboBox_Wydzialy_dodajSale);
        GroupBox_Sala.Controls.Add(label3);
        GroupBox_Sala.Controls.Add(text_NumerSali);
        GroupBox_Sala.Location = new Point(393, 29);
        GroupBox_Sala.Name = "GroupBox_Sala";
        GroupBox_Sala.Size = new Size(266, 355);
        GroupBox_Sala.TabIndex = 1;
        GroupBox_Sala.TabStop = false;
        GroupBox_Sala.Text = "Sala";
        // 
        // label7
        // 
        label7.Location = new Point(22, 134);
        label7.Name = "label7";
        label7.Size = new Size(82, 20);
        label7.TabIndex = 10;
        label7.Text = "Ilość Miejsc";
        // 
        // textBox_iloscMiejsc
        // 
        textBox_iloscMiejsc.Location = new Point(110, 130);
        textBox_iloscMiejsc.Name = "textBox_iloscMiejsc";
        textBox_iloscMiejsc.Size = new Size(143, 23);
        textBox_iloscMiejsc.TabIndex = 9;
        // 
        // ComboBox_TypSali
        // 
        ComboBox_TypSali.FormattingEnabled = true;
        ComboBox_TypSali.Location = new Point(110, 102);
        ComboBox_TypSali.Name = "ComboBox_TypSali";
        ComboBox_TypSali.Size = new Size(143, 23);
        ComboBox_TypSali.TabIndex = 8;
        // 
        // label5
        // 
        label5.Location = new Point(22, 105);
        label5.Name = "label5";
        label5.Size = new Size(96, 23);
        label5.TabIndex = 7;
        label5.Text = "Rodzaj Sali";
        // 
        // button_dodajSale
        // 
        button_dodajSale.Location = new Point(72, 223);
        button_dodajSale.Name = "button_dodajSale";
        button_dodajSale.Size = new Size(136, 90);
        button_dodajSale.TabIndex = 5;
        button_dodajSale.Text = "Dodaj Salę";
        button_dodajSale.UseVisualStyleBackColor = true;
        button_dodajSale.Click += button_dodajSale_Click;
        // 
        // label4
        // 
        label4.Location = new Point(22, 76);
        label4.Name = "label4";
        label4.Size = new Size(60, 20);
        label4.TabIndex = 6;
        label4.Text = "Nr. Sali";
        // 
        // ComboBox_Wydzialy_dodajSale
        // 
        ComboBox_Wydzialy_dodajSale.FormattingEnabled = true;
        ComboBox_Wydzialy_dodajSale.Location = new Point(110, 44);
        ComboBox_Wydzialy_dodajSale.Name = "ComboBox_Wydzialy_dodajSale";
        ComboBox_Wydzialy_dodajSale.Size = new Size(143, 23);
        ComboBox_Wydzialy_dodajSale.TabIndex = 3;
        // 
        // label3
        // 
        label3.Location = new Point(22, 47);
        label3.Name = "label3";
        label3.Size = new Size(60, 23);
        label3.TabIndex = 4;
        label3.Text = "Wydział";
        // 
        // text_NumerSali
        // 
        text_NumerSali.Location = new Point(110, 73);
        text_NumerSali.Name = "text_NumerSali";
        text_NumerSali.Size = new Size(143, 23);
        text_NumerSali.TabIndex = 5;
        // 
        // GroupBox_Prowadzacy
        // 
        GroupBox_Prowadzacy.Controls.Add(button_dodajProwadzacego);
        GroupBox_Prowadzacy.Controls.Add(textBox_nazwiskoProwadzacego);
        GroupBox_Prowadzacy.Controls.Add(textBox_imieProwadzacego);
        GroupBox_Prowadzacy.Controls.Add(label2);
        GroupBox_Prowadzacy.Controls.Add(LabelImie);
        GroupBox_Prowadzacy.Location = new Point(34, 27);
        GroupBox_Prowadzacy.Name = "GroupBox_Prowadzacy";
        GroupBox_Prowadzacy.Size = new Size(310, 357);
        GroupBox_Prowadzacy.TabIndex = 0;
        GroupBox_Prowadzacy.TabStop = false;
        GroupBox_Prowadzacy.Text = "Prowadzący";
        // 
        // button_dodajProwadzacego
        // 
        button_dodajProwadzacego.Location = new Point(81, 225);
        button_dodajProwadzacego.Name = "button_dodajProwadzacego";
        button_dodajProwadzacego.Size = new Size(136, 90);
        button_dodajProwadzacego.TabIndex = 4;
        button_dodajProwadzacego.Text = "Dodaj Prowadzącego";
        button_dodajProwadzacego.UseVisualStyleBackColor = true;
        button_dodajProwadzacego.Click += button_dodajProwadzacego_Click;
        // 
        // textBox_nazwiskoProwadzacego
        // 
        textBox_nazwiskoProwadzacego.Location = new Point(106, 80);
        textBox_nazwiskoProwadzacego.Name = "textBox_nazwiskoProwadzacego";
        textBox_nazwiskoProwadzacego.Size = new Size(143, 23);
        textBox_nazwiskoProwadzacego.TabIndex = 3;
        // 
        // textBox_imieProwadzacego
        // 
        textBox_imieProwadzacego.Location = new Point(106, 46);
        textBox_imieProwadzacego.Name = "textBox_imieProwadzacego";
        textBox_imieProwadzacego.Size = new Size(143, 23);
        textBox_imieProwadzacego.TabIndex = 2;
        // 
        // label2
        // 
        label2.Location = new Point(17, 83);
        label2.Name = "label2";
        label2.Size = new Size(200, 20);
        label2.TabIndex = 1;
        label2.Text = "Nazwisko";
        // 
        // LabelImie
        // 
        LabelImie.Location = new Point(17, 49);
        LabelImie.Name = "LabelImie";
        LabelImie.Size = new Size(200, 20);
        LabelImie.TabIndex = 0;
        LabelImie.Text = "Imie";
        // 
        // TabZarezerwujSale
        // 
        TabZarezerwujSale.AutoScroll = true;
        TabZarezerwujSale.Controls.Add(panel_ReservationLive);
        TabZarezerwujSale.Controls.Add(button_zarezerwuj);
        TabZarezerwujSale.Controls.Add(listaSalNaWybranymWydziale);
        TabZarezerwujSale.Controls.Add(dateTimePicker_godzinaZakonczenia);
        TabZarezerwujSale.Controls.Add(dateTimePicker_godzinaRozpoczecia);
        TabZarezerwujSale.Controls.Add(label12);
        TabZarezerwujSale.Controls.Add(label11);
        TabZarezerwujSale.Controls.Add(dateTimePicker1);
        TabZarezerwujSale.Controls.Add(label10);
        TabZarezerwujSale.Controls.Add(label9);
        TabZarezerwujSale.Controls.Add(comboBox_prowadzacyRezerwacja);
        TabZarezerwujSale.Controls.Add(label8);
        TabZarezerwujSale.Controls.Add(label1);
        TabZarezerwujSale.Controls.Add(combo_box_wydzialRezerwacja);
        TabZarezerwujSale.Location = new Point(4, 24);
        TabZarezerwujSale.Name = "TabZarezerwujSale";
        TabZarezerwujSale.Padding = new Padding(3);
        TabZarezerwujSale.Size = new Size(1017, 523);
        TabZarezerwujSale.TabIndex = 0;
        TabZarezerwujSale.Text = "Zarezerwuj Sale";
        TabZarezerwujSale.UseVisualStyleBackColor = true;
        // 
        // button_zarezerwuj
        // 
        button_zarezerwuj.Location = new Point(51, 220);
        button_zarezerwuj.Name = "button_zarezerwuj";
        button_zarezerwuj.Size = new Size(423, 37);
        button_zarezerwuj.TabIndex = 13;
        button_zarezerwuj.Text = "Zarezerwuj";
        button_zarezerwuj.UseVisualStyleBackColor = true;
        button_zarezerwuj.Click += button_zarezerwuj_Click;
        // 
        // listaSalNaWybranymWydziale
        // 
        listaSalNaWybranymWydziale.DataSource = salaBindingSource;
        listaSalNaWybranymWydziale.FormattingEnabled = true;
        listaSalNaWybranymWydziale.Location = new Point(586, 42);
        listaSalNaWybranymWydziale.Name = "listaSalNaWybranymWydziale";
        listaSalNaWybranymWydziale.Size = new Size(384, 409);
        listaSalNaWybranymWydziale.TabIndex = 12;
        // 
        // salaBindingSource
        // 
        salaBindingSource.DataSource = typeof(Sala);
        // 
        // dateTimePicker_godzinaZakonczenia
        // 
        dateTimePicker_godzinaZakonczenia.CustomFormat = "HH:mm";
        dateTimePicker_godzinaZakonczenia.Format = DateTimePickerFormat.Custom;
        dateTimePicker_godzinaZakonczenia.Location = new Point(403, 161);
        dateTimePicker_godzinaZakonczenia.Name = "dateTimePicker_godzinaZakonczenia";
        dateTimePicker_godzinaZakonczenia.ShowUpDown = true;
        dateTimePicker_godzinaZakonczenia.Size = new Size(71, 23);
        dateTimePicker_godzinaZakonczenia.TabIndex = 11;
        // 
        // dateTimePicker_godzinaRozpoczecia
        // 
        dateTimePicker_godzinaRozpoczecia.CustomFormat = "HH:mm";
        dateTimePicker_godzinaRozpoczecia.Format = DateTimePickerFormat.Custom;
        dateTimePicker_godzinaRozpoczecia.Location = new Point(180, 161);
        dateTimePicker_godzinaRozpoczecia.Name = "dateTimePicker_godzinaRozpoczecia";
        dateTimePicker_godzinaRozpoczecia.ShowUpDown = true;
        dateTimePicker_godzinaRozpoczecia.Size = new Size(71, 23);
        dateTimePicker_godzinaRozpoczecia.TabIndex = 10;
        // 
        // label12
        // 
        label12.Location = new Point(264, 167);
        label12.Name = "label12";
        label12.Size = new Size(133, 23);
        label12.TabIndex = 9;
        label12.Text = "Godzina Zakończenia";
        // 
        // label11
        // 
        label11.Location = new Point(51, 167);
        label11.Name = "label11";
        label11.Size = new Size(133, 23);
        label11.TabIndex = 8;
        label11.Text = "Godzina Rozpoczęcia";
        // 
        // dateTimePicker1
        // 
        dateTimePicker1.Location = new Point(139, 121);
        dateTimePicker1.Name = "dateTimePicker1";
        dateTimePicker1.Size = new Size(335, 23);
        dateTimePicker1.TabIndex = 7;
        // 
        // label10
        // 
        label10.Location = new Point(51, 127);
        label10.Name = "label10";
        label10.Size = new Size(88, 23);
        label10.TabIndex = 6;
        label10.Text = "Data";
        // 
        // label9
        // 
        label9.Location = new Point(586, 16);
        label9.Name = "label9";
        label9.Size = new Size(60, 23);
        label9.TabIndex = 5;
        label9.Text = "Sala";
        label9.Click += label9_Click;
        // 
        // comboBox_prowadzacyRezerwacja
        // 
        comboBox_prowadzacyRezerwacja.FormattingEnabled = true;
        comboBox_prowadzacyRezerwacja.Location = new Point(139, 42);
        comboBox_prowadzacyRezerwacja.Name = "comboBox_prowadzacyRezerwacja";
        comboBox_prowadzacyRezerwacja.Size = new Size(335, 23);
        comboBox_prowadzacyRezerwacja.TabIndex = 3;
        // 
        // label8
        // 
        label8.Location = new Point(51, 45);
        label8.Name = "label8";
        label8.Size = new Size(82, 23);
        label8.TabIndex = 2;
        label8.Text = "Prowadzący";
        // 
        // TabZarzadzanieRezerwacjami
        // 
        TabZarzadzanieRezerwacjami.Controls.Add(listBox_rezerwacjeAll);
        TabZarzadzanieRezerwacjami.Location = new Point(4, 24);
        TabZarzadzanieRezerwacjami.Name = "TabZarzadzanieRezerwacjami";
        TabZarzadzanieRezerwacjami.Padding = new Padding(3);
        TabZarzadzanieRezerwacjami.Size = new Size(1017, 523);
        TabZarzadzanieRezerwacjami.TabIndex = 1;
        TabZarzadzanieRezerwacjami.Text = "Zarzadzanie Rezerwacjami";
        TabZarzadzanieRezerwacjami.UseVisualStyleBackColor = true;
        // 
        // listBox_rezerwacjeAll
        // 
        listBox_rezerwacjeAll.DataSource = rezerwacjaBindingSource;
        listBox_rezerwacjeAll.FormattingEnabled = true;
        listBox_rezerwacjeAll.Location = new Point(0, 0);
        listBox_rezerwacjeAll.Name = "listBox_rezerwacjeAll";
        listBox_rezerwacjeAll.Size = new Size(1014, 409);
        listBox_rezerwacjeAll.TabIndex = 0;
        // 
        // rezerwacjaBindingSource
        // 
        rezerwacjaBindingSource.DataSource = typeof(Rezerwacja);
        // 
        // TabWszystkieInformacje
        // 
        TabWszystkieInformacje.Controls.Add(tabControl1);
        TabWszystkieInformacje.Location = new Point(4, 24);
        TabWszystkieInformacje.Name = "TabWszystkieInformacje";
        TabWszystkieInformacje.Size = new Size(1017, 523);
        TabWszystkieInformacje.TabIndex = 3;
        TabWszystkieInformacje.Text = "Wszystkie informacje";
        TabWszystkieInformacje.UseVisualStyleBackColor = true;
        // 
        // tabControl1
        // 
        tabControl1.Controls.Add(tabPage1);
        tabControl1.Controls.Add(tabPage2);
        tabControl1.Location = new Point(3, 3);
        tabControl1.Name = "tabControl1";
        tabControl1.SelectedIndex = 0;
        tabControl1.Size = new Size(992, 387);
        tabControl1.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Location = new Point(4, 24);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(984, 359);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "tabPage1";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.Location = new Point(4, 24);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(984, 359);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "tabPage2";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // panel_ReservationLive
        // 
        panel_ReservationLive.Location = new Point(51, 289);
        panel_ReservationLive.Name = "panel_ReservationLive";
        panel_ReservationLive.Size = new Size(423, 162);
        panel_ReservationLive.TabIndex = 14;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1024, 505);
        Controls.Add(tab);
        MaximizeBox = false;
        Name = "Form1";
        Text = "Rezerwacja Sal";
        tab.ResumeLayout(false);
        TabDodajInformacje.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        GroupBox_Sala.ResumeLayout(false);
        GroupBox_Sala.PerformLayout();
        GroupBox_Prowadzacy.ResumeLayout(false);
        GroupBox_Prowadzacy.PerformLayout();
        TabZarezerwujSale.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)salaBindingSource).EndInit();
        TabZarzadzanieRezerwacjami.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)rezerwacjaBindingSource).EndInit();
        TabWszystkieInformacje.ResumeLayout(false);
        tabControl1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.DateTimePicker dateTimePicker1;

    private System.Windows.Forms.Label label9;

    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.ComboBox comboBox_prowadzacyRezerwacja;

    private System.Windows.Forms.TabPage TabWszystkieInformacje;

    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox textBox_iloscMiejsc;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox ComboBox_TypSali;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button_dodajSale;

    private System.Windows.Forms.TextBox text_NumerSali;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox ComboBox_Wydzialy_dodajSale;

    private System.Windows.Forms.TextBox textBox_imieProwadzacego;
    private System.Windows.Forms.TextBox textBox_nazwiskoProwadzacego;
    private System.Windows.Forms.Button button_dodajProwadzacego;

    private System.Windows.Forms.Label LabelImie;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.GroupBox GroupBox_Prowadzacy;
    private System.Windows.Forms.GroupBox GroupBox_Sala;
    private System.Windows.Forms.GroupBox groupBox3;

    private System.Windows.Forms.TabPage TabDodajInformacje;

    private System.Windows.Forms.TabControl tab;
    private System.Windows.Forms.TabPage TabZarezerwujSale;
    private System.Windows.Forms.TabPage TabZarzadzanieRezerwacjami;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.ComboBox combo_box_wydzialRezerwacja;

    #endregion

    private DateTimePicker dateTimePicker_godzinaZakonczenia;
    private DateTimePicker dateTimePicker_godzinaRozpoczecia;
    private Label label12;
    private Label label11;
    private ListBox listaSalNaWybranymWydziale;
    private BindingSource salaBindingSource;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private TextBox textBox_dodajWydzialNazwa;
    private Label label6;
    private Button button_dodajWydzial;
    private TextBox textBox_dodajWydzialKod2;
    private Label label17;
    private TextBox textBox_dodajWydzialKod1;
    private Label label16;
    private Label label15;
    private Label label14;
    private Label label13;
    private TextBox textBox_dodajWydzialNumer;
    private TextBox textBox_dodajWydzialUlica;
    private TextBox textBox_dodajWydzialMiasto;
    private Button button_zarezerwuj;
    private ListBox listBox_rezerwacjeAll;
    private BindingSource rezerwacjaBindingSource;
    private Panel panel_ReservationLive;
}