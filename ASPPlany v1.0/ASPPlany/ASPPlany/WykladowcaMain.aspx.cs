using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPPlany
{
    public partial class WykladowcaMain : System.Web.UI.Page
    {
        public string ktoZalogowany = null;
        public int index = 0;

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

        protected void btnPrzedmioty_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void btnStudenci_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnSpecjalnosci_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }

        protected void btnDodaj_Click(object sender, EventArgs e)
        {
            Panel3.Visible = true;
            
        }

        protected void btnEdytuj_Click(object sender, EventArgs e)
        {
            Panel3.Visible = true;
            tbNazwa.Text = GridView3.SelectedRow.Cells[0].Text;
        }

        protected void btnUsun_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = GridView3.SelectedIndex;
        }

        protected void btnZapisz_Click(object sender, EventArgs e)
        {
            
            SqlDataSource3.InsertCommandType = SqlDataSourceCommandType.Text;
            SqlDataSource3.InsertCommand = "Insert into Przedmioty (nazwa,ile_godzin,typ_zajec,semestr,Specjalnosc_id_specjalnosc) VALUES (@nazwa,@ile_godzin,@typ_zajec,@semestr,@Specjalnosc_id_specjalnosc)";
            SqlDataSource3.InsertParameters.Clear();
            SqlDataSource3.InsertParameters.Add("nazwa", tbNazwa.Text);
            SqlDataSource3.InsertParameters.Add("ile_godzin", tbIleGodzin.Text);
            SqlDataSource3.InsertParameters.Add("typ_zajec", tbTypZajec.Text);
            SqlDataSource3.InsertParameters.Add("semestr", tbSemestr.Text);
            SqlDataSource3.InsertParameters.Add("Specjalnosc_id_specjalnosc", DropDownList1.SelectedValue.ToString());
            SqlDataSource3.Insert();
            Panel3.Visible = false;
        }
    }
}