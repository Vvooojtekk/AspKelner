using System;

namespace Kelner
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Stoliki lastPage = (Stoliki)Context.Handler;

            lblStolik.Text = lastPage.stolik.GetNazwa();
            lblTresc.Text = lastPage.stolik.Podsumowanie();
        }
    }
}