namespace Kelner
{
    //Klasa reprezentująca przedmiot zamówienia, czyli danie i jego ilość

    public class PrzedmiotZamowienia
    {
        private Danie danie;
        private int ilosc;

        public PrzedmiotZamowienia(Danie danie, int ilosc)
        {
            this.danie = danie;
            this.ilosc = ilosc;
        }

        override public string ToString()
        {
            return this.danie.GetNazwa() + " x " + this.ilosc;
        }

        public void Odejmij(int ile)
        {
            this.ilosc -= ile;
        }

        public void Dodaj(int ile)
        {
            this.ilosc += ile;
        }

        public string GetNazwa()
        {
            return this.danie.GetNazwa();
        }
        public void SetIlosc(int ilosc)
        {
            this.ilosc = ilosc;
        }
        public float GetCena()
        {
            return this.danie.GetCena() * this.ilosc;
        }
        public Danie GetDanie()
        {
            return this.danie;
        }
    }
}