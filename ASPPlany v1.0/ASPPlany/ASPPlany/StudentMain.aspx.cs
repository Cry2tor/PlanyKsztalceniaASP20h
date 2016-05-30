using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPPlany
{
    public partial class StudentMain : System.Web.UI.Page
    {
        string ktoZalogowany = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Zalogowany jako : " + Session["name"].ToString();
            ktoZalogowany = Session["name"].ToString();
            
        }

        protected void btnWyloguj_Click(object sender, EventArgs e)
        {
            Server.Transfer("StartPage.aspx", true);
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Server.Transfer("StartPage.aspx", true);
        }

        protected void btnWykladowcy_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 4;
        }

        protected void btnPrzedmioty_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 3;
        }

        protected void btnGrupa_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }

        protected void btnSpecjalizacja_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnStypendium_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }
    }
}