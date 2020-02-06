using System;
using System.Collections.Generic;
using System.Linq;

namespace Kelner
{
    public partial class Stoliki : System.Web.UI.Page
    {
        Danie d1 = new Danie("ryba", 14);
        Danie d2 = new Danie("kurczak", 12);
        Danie d3 = new Danie("zupa", 16);
        Danie d4 = new Danie("naleśniki", 13);
        Danie d5 = new Danie("frytki", 6);
        Danie d6 = new Danie("kompot", 2.50f);

        //lista w której przechowywane będą obiekty klasy Danie
        static public List<Danie> dania_menu = new List<Danie> { };

        public Stolik s1 = new Stolik("Stolik 1");
        public Stolik s2 = new Stolik("Stolik 2");
        public Stolik s3 = new Stolik("Stolik 3");
        public Stolik s4 = new Stolik("Stolik 4");
        public Stolik s5 = new Stolik("Stolik 5");

        public Stolik stolik;


        //lista w której przechowywane będą obiekty klasy Stolik
        static public List<Stolik> stoliki_lista = new List<Stolik> { };

        //lista w której przechowywane będą obiekty klasy PrzedmiotZamowienia
        static public List<PrzedmiotZamowienia> zamowienia_dla_stolika = new List<PrzedmiotZamowienia> { };

        //funkcja wyświetlająca zamówienia przypisane do wybranego stolika
        public void WyswietlZamowione()
        {
            if (ddlStoliki.SelectedIndex > 0)
            {
                if (stoliki_lista[ddlStoliki.SelectedIndex - 1].GetListaZamowien() != null)
                {
                    lstZamowienie.Items.Clear();
                    foreach (PrzedmiotZamowienia item in stoliki_lista[ddlStoliki.SelectedIndex - 1].GetListaZamowien())
                    {
                        lstZamowienie.Items.Add(item.ToString());
                    }
                }
                lblSumaWartosc.Text = stoliki_lista[ddlStoliki.SelectedIndex - 1].Podlicz().ToString() + " zł";
            }
        }
        public void WyswietlOpis()
        {
            if (lstZamowienie.SelectedIndex > -1)
            {
                lblNazwaDaniaWartosc.Text = stoliki_lista[ddlStoliki.SelectedIndex - 1].GetListaZamowien()[lstZamowienie.SelectedIndex].GetNazwa();
                lblCenaJednWartosc.Text = stoliki_lista[ddlStoliki.SelectedIndex - 1].GetListaZamowien()[lstZamowienie.SelectedIndex].GetDanie().GetCena().ToString() + " zł";
                lblCenaZaWszystkieWartosc.Text = stoliki_lista[ddlStoliki.SelectedIndex - 1].GetListaZamowien()[lstZamowienie.SelectedIndex].GetCena().ToString() + " zł";
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (lstZamowienie.SelectedIndex > -1)
            {
                btnUsun.Visible = true;
                btnZmienIlosc.Visible = true;
                ddlIloscZmien.Visible = true;
                lblNazwaDaniaWartosc.Visible = true;
                lblNazwaDania.Visible = true;
                lblCenaJedn.Visible = true;
                lblCenaJednWartosc.Visible = true;
                lblCenaZaWszystkie.Visible = true;
                lblCenaZaWszystkieWartosc.Visible = true;
            }
            else
            {
                btnUsun.Visible = false;
                btnZmienIlosc.Visible = false;
                ddlIloscZmien.Visible = false;
                lblNazwaDania.Visible = false;
                lblNazwaDaniaWartosc.Visible = false;
                lblCenaJedn.Visible = false;
                lblCenaJednWartosc.Visible = false;
                lblCenaZaWszystkie.Visible = false;
                lblCenaZaWszystkieWartosc.Visible = false;

            }
            if (!IsPostBack)
            {
                if (stoliki_lista.Count() == 0)
                {
                    //dodawanie dań do listy
                    dania_menu.Add(d1);
                    dania_menu.Add(d2);
                    dania_menu.Add(d3);
                    dania_menu.Add(d4);
                    dania_menu.Add(d5);
                    dania_menu.Add(d6);

                    //dodawanie stolików do listy
                    stoliki_lista.Add(s1);
                    stoliki_lista.Add(s2);
                    stoliki_lista.Add(s3);
                    stoliki_lista.Add(s4);
                    stoliki_lista.Add(s5);

                }
                //dodawanie do oferty (listbox) dań z listy dań
                foreach (var d in dania_menu)
                {
                    //zmienna pomocnicza, której przypisuję nazwę i cenę po przecinku
                    string pom = d.GetNazwa() + ", " + d.GetCena().ToString() + " zł";
                    lstOferta.Items.Add(pom);
                }
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            btnUsun.Visible = false;
            btnZmienIlosc.Visible = false;
            ddlIloscZmien.Visible = false;
            lblNazwaDaniaWartosc.Visible = false;
            lblNazwaDania.Visible = false;
            lblCenaJedn.Visible = false;
            lblCenaJednWartosc.Visible = false;
            lblCenaZaWszystkie.Visible = false;
            lblCenaZaWszystkieWartosc.Visible = false;
            // Funkcja działająca po wyborze stolika. Umożliwia jego edycję
            if (ddlStoliki.SelectedValue != "wybierz stolik")
            {


                lblCenaWartosc.Visible = true;
                lblOferta.Visible = true;
                lblOferta2.Visible = true;
                lblOferta3.Visible = true;
                lblSuma.Visible = true;
                lblSumaWartosc.Visible = true;
                lstOferta.Visible = true;
                lstZamowienie.Visible = true;
                btnDodaj.Visible = true;
                btnDodaj.Enabled = false;
                btnZaplac.Visible = true;
                lblCenaWartosc.Text = "";

            }
            else
            {
                lblCena.Visible = false;
                lblIlosc.Visible = false;
                lblCenaWartosc.Visible = false;
                lblOferta.Visible = false;
                lblOferta2.Visible = false;
                lblOferta3.Visible = false;
                lblSuma.Visible = false;
                lblSumaWartosc.Visible = false;
                lstOferta.Visible = false;
                lstZamowienie.Visible = false;
                ddlIlosc.Visible = false;
                btnDodaj.Visible = false;
                btnUsun.Visible = false;
                lblNazwaDania.Visible = false;
                lblNazwaDaniaWartosc.Visible = false;
                lblCenaJedn.Visible = false;
                lblCenaJednWartosc.Visible = false;
                lblCenaZaWszystkie.Visible = false;
                lblCenaZaWszystkieWartosc.Visible = false;
                btnZaplac.Visible = false;
            }
            lstOferta.SelectedIndex = -1;
            WyswietlZamowione();

        }

        protected void lstOferta_SelectedIndexChanged(object sender, EventArgs e)
        {

            

            lblCena.Visible = true;

            //Umożliwienie zwiększenia ilości produktu
            lblIlosc.Visible = true;
            ddlIlosc.Visible = true;
            ddlIlosc.Items.Clear();
            for (int ile=1; ile <= 20; ile++)
            {
                ddlIlosc.Items.Add(ile.ToString());
            }
            ddlIlosc.SelectedIndex = 0;
            //Umożliwienie dodania produktu do zamówienia
            btnDodaj.Enabled = true;

            //Wyświetlanie ceny
            float cena = dania_menu[lstOferta.SelectedIndex].GetCena() * int.Parse(ddlIlosc.SelectedValue);
            lblCenaWartosc.Text = cena.ToString() + " zł";
        }

        protected void ddlIlosc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Wyświetlanie ceny
            if (lstOferta.SelectedIndex != -1)
            {
                float cena = dania_menu[lstOferta.SelectedIndex].GetCena() * int.Parse(ddlIlosc.SelectedValue);
                lblCenaWartosc.Text = cena.ToString() + " zł";
            }
        }

        protected void btnDodaj_Click(object sender, EventArgs e)
        {
            //Jeśli pozycja którą chcemy dodać występuje w liście zamówionych do stolika

            if (stoliki_lista[ddlStoliki.SelectedIndex - 1].CzyWystepuje(dania_menu[lstOferta.SelectedIndex]))
            {
                foreach (PrzedmiotZamowienia item in stoliki_lista[ddlStoliki.SelectedIndex - 1].GetListaZamowien())
                {
                    if (item.GetNazwa() == dania_menu[lstOferta.SelectedIndex].GetNazwa())
                    {
                        //zwiększamy ilość zamówionej pozycji
                        item.Dodaj(int.Parse(ddlIlosc.SelectedValue));
                    }
                }
            }
            else
            {
                Danie danie = dania_menu[lstOferta.SelectedIndex];
                int ilosc = int.Parse(ddlIlosc.SelectedValue);
                PrzedmiotZamowienia przedmiot_zam = new PrzedmiotZamowienia(danie, ilosc);
                stoliki_lista[ddlStoliki.SelectedIndex - 1].DodajZamowienie(przedmiot_zam);
            }
            WyswietlZamowione();
            btnUsun.Visible = false;
            btnZmienIlosc.Visible = false;
            ddlIloscZmien.Visible = false;
            lblNazwaDania.Visible = false;
            lblNazwaDaniaWartosc.Visible = false;
            lblCenaJedn.Visible = false;
            lblCenaJednWartosc.Visible = false;
            lblCenaZaWszystkie.Visible = false;
            lblCenaZaWszystkieWartosc.Visible = false;

        }

        protected void lstZamowienie_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlIloscZmien.Items.Clear();
            for (int ile = 1; ile <= 20; ile++)
            {
                ddlIloscZmien.Items.Add(ile.ToString());
            }
            WyswietlOpis();
        }

        protected void btnUsun_Click(object sender, EventArgs e)
        {
            stoliki_lista[ddlStoliki.SelectedIndex - 1].UsunZamowienie(lstZamowienie.SelectedIndex);
            WyswietlZamowione();
            btnUsun.Visible = false;
            btnZmienIlosc.Visible = false;
            ddlIloscZmien.Visible = false;
            lblNazwaDania.Visible = false;
            lblNazwaDaniaWartosc.Visible = false;
            lblCenaJedn.Visible = false;
            lblCenaJednWartosc.Visible = false;
            lblCenaZaWszystkie.Visible = false;
            lblCenaZaWszystkieWartosc.Visible = false;
        }

        protected void btnZmienIlosc_Click(object sender, EventArgs e)
        {
            stoliki_lista[ddlStoliki.SelectedIndex - 1].ZmienIlosc(int.Parse(ddlIloscZmien.SelectedValue), lstZamowienie.SelectedIndex);
            WyswietlZamowione();
            btnUsun.Visible = false;
            btnZmienIlosc.Visible = false;
            ddlIloscZmien.Visible = false;
            lblNazwaDania.Visible = false;
            lblNazwaDaniaWartosc.Visible = false;
            lblCenaJedn.Visible = false;
            lblCenaJednWartosc.Visible = false;
            lblCenaZaWszystkie.Visible = false;
            lblCenaZaWszystkieWartosc.Visible = false;
        }

        protected void btnZaplac_Click(object sender, EventArgs e)
        {
            stolik = stoliki_lista[ddlStoliki.SelectedIndex - 1];
            Server.Transfer("Podsumowanie.aspx");
        }

        protected void ddlIloscZmien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}