using System.Collections.Generic;

namespace Kelner
{
    //Klasa reprezentująca stolik, zawierająca listę zamówionych dań
    public class Stolik
    {
        private string nazwa;
        //lista zamówionych pozycji
        private List<PrzedmiotZamowienia> lista_zamowien = new List<PrzedmiotZamowienia> { };

        public Stolik(string nazwa)
        {
            this.nazwa = nazwa;
        }
        public List<PrzedmiotZamowienia> GetListaZamowien()
        {
            return this.lista_zamowien;
        }
        public bool CzyWystepuje(Danie danie)
        {
            bool znaleziono = false;

            foreach (PrzedmiotZamowienia item in lista_zamowien)
            {
                if (item.GetNazwa() == danie.GetNazwa())
                    znaleziono = true;
            }
            return znaleziono;
        }
        public void DodajZamowienie(PrzedmiotZamowienia pozycja)
        {
            this.lista_zamowien.Add(pozycja);
        }
        public string GetNazwa()
        {
            return this.nazwa;
        }

        public void UsunZamowienie(int index)
        {
            this.lista_zamowien.RemoveAt(index);
        }
        public void ZmienIlosc(int ilosc, int index)
        {
            this.lista_zamowien[index].SetIlosc(ilosc);
        }
        public float Podlicz()
        {
            float suma = 0;
            foreach (PrzedmiotZamowienia zamowienie in this.lista_zamowien)
            {
                suma += zamowienie.GetCena();
            }
            return suma;
        }
        public string Podsumowanie()
        {
            string podsumowanie = "";
            foreach (PrzedmiotZamowienia zamowienie in this.lista_zamowien)
            {
                podsumowanie += zamowienie.ToString() + " x " + zamowienie.GetDanie().GetCena() + "zł = " + zamowienie.GetCena() + "zł<br />";
            }
            podsumowanie += "Do zapłaty: " + this.Podlicz() + "zł";
            return podsumowanie;
        }
    }
}