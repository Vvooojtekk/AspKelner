namespace Kelner
{
    //Klasa reprezentująca dania
    public class Danie
    {
        private string nazwa;
        private float cena;
        private string opis;

        public Danie(string nazwa, float cena)
        {
            this.nazwa = nazwa;
            this.cena = cena;
        }

        public Danie(string nazwa, float cena, string opis)
        {
            this.nazwa = nazwa;
            this.cena = cena;
            this.opis = opis;
        }
        override public string ToString()
        {
            return this.nazwa;
        }
        public float GetCena()
        {
            return this.cena;
        }
        public string GetNazwa()
        {
            return this.nazwa;
        }
    }
}