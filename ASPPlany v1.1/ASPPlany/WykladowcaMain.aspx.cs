using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPPlany
{
    public partial class WykladowcaMain : System.Web.UI.Page
    {
        public string ktoZalogowany = null;
        public string id_przedmiot = null;
        private string connStr;
        private SqlConnection conn;

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Zalogowany jako : " + Session["name"].ToString();
            ktoZalogowany = Session["name"].ToString();

            connStr = ConfigurationManager.ConnectionStrings["PlanyKsztalceniaConnectionString"].ConnectionString;
            conn = new SqlConnection(connStr);
            conn.Open();
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
            
            btnZapisz.Visible = true;
            tbNazwa.Text = null;
            tbIleGodzin.Text = null;
            tbSemestr.Text = null;
            tbTypZajec.Text = null;
            
        }

        protected void btnEdytuj_Click(object sender, EventArgs e)
        {
            
            
        }

        protected void btnUsun_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnZapisz.Visible = false;
            
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

        protected void btnEdytujPrzedmioty_Click(object sender, EventArgs e)
        {
            Panel3.Visible = true;
            //wypelnij();

            id_przedmiot = GridView3.SelectedRow.Cells[2].Text;
            tbNazwa.Text = GridView3.SelectedRow.Cells[3].Text;
            tbIleGodzin.Text = GridView3.SelectedRow.Cells[4].Text;
            tbTypZajec.Text = GridView3.SelectedRow.Cells[5].Text;
            tbSemestr.Text = GridView3.SelectedRow.Cells[6].Text;

            /*
           connStr = ConfigurationManager.ConnectionStrings["PlanyKsztalceniaConnectionString"].ConnectionString;
           conn = new SqlConnection(connStr);
           conn.Open();

           SqlCommand pobierzDane = new SqlCommand();
            pobierzDane.Connection = conn;
            pobierzDane.Parameters["@id_przedmiot"].Value = index;
            pobierzDane.Parameters["@nazwa"].Value = tbNazwa.Text;
            pobierzDane.Parameters["@ile_godzin"].Value = tbIleGodzin.Text;
            pobierzDane.Parameters["@typ_zajec"].Value = tbTypZajec.Text;
            pobierzDane.Parameters["@semestr"].Value = tbSemestr.Text;
            pobierzDane.Parameters["@Specjalnosc_id_specjalnosc"].Value = DropDownList1.SelectedValue.ToString();
            pobierzDane.CommandText = "UPDATE Ptrzedmioty SET nazwa = @nazwa, ile_godzin = @ile_godzin, typ_zajec = @typ_zajec, semestr = @semestr,  Specjalnosc_id_specjalnosc = @Specjalnosc_id_specjalnosc, id_przedmiot = @id_przedmiot WHERE id_przedmiot = @index";


            
           string nazwa = Request["tbNazwa"];
           string ileGodzin = Request["tbIleGodzin"];
           string typZajec = Request["tbTypZajec"];
           string semestr = Request.Form["tbSemestr"];
           string specjalnosc = Request.Form["DropDownList1"];
           SqlCommand edytujStudenta = new SqlCommand();

           edytujStudenta.Connection = conn;

           edytujStudenta.Parameters.Add("@nazwa", SqlDbType.VarChar);
           edytujStudenta.Parameters["@nazwa"].Value = tbNazwa.Text;

           edytujStudenta.Parameters.Add("@ile_godzin", SqlDbType.Decimal);
           edytujStudenta.Parameters["@ile_godzin"].Value = tbIleGodzin.Text;

           edytujStudenta.Parameters.Add("@typ_zajec", SqlDbType.Decimal);
           edytujStudenta.Parameters["@typ_zajec"].Value = tbTypZajec.Text;

           edytujStudenta.Parameters.Add("@semestr", SqlDbType.Decimal);
           edytujStudenta.Parameters["@semestr"].Value = tbSemestr.Text;

           edytujStudenta.Parameters.Add("@Specjalnosc_id_specjalnosc", SqlDbType.VarChar);
           edytujStudenta.Parameters["@Specjalnosc_id_specjalnosc"].Value = DropDownList1.SelectedValue.ToString();
           edytujStudenta.CommandText = "UPDATE STUDENCI SET Gru_ID = @idGru, Dziek_ID = @idDziek, Wyd_ID = @idWyd, Num_Indeksu = @numIndeks, Stud_Haslo = @haslo, Stud_Imie = @imie, Stud_Nazwisko = @nazwisko, Stud_Miejscowosc = @miejsc, Stud_Telefon = @telefon  WHERE Num_Indeksu = @numerIndeksu";
           edytujStudenta.ExecuteNonQuery();
           
            conn.Close();

    */
        }

        protected void GridView3_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow row = GridView3.Rows[e.NewSelectedIndex];
        }

        public void wypelnij()
        {
            SqlCommand pobierzDane = new SqlCommand();
            pobierzDane.Connection = conn;
            pobierzDane.Parameters.Add("@id_przedmiot", SqlDbType.Int);
            pobierzDane.Parameters["@id_przedmiot"].Value = id_przedmiot;

            pobierzDane.CommandText = "SELECT nazwa FROM Przedmioty Where id_przedmiot = @id_przedmiot";
            tbNazwa.Text = pobierzDane.ExecuteScalar().ToString();

            pobierzDane.CommandText = "SELECT ile_godzin FROM Przedmioty Where id_przedmiot = @id_przedmiot";
            tbIleGodzin.Text = pobierzDane.ExecuteScalar().ToString();

            pobierzDane.CommandText = "SELECT typ_zajec FROM Przedmioty Where id_przedmiot = @id_przedmiot";
            tbTypZajec.Text = pobierzDane.ExecuteScalar().ToString();

            pobierzDane.CommandText = "SELECT semestr FROM Przedmioty Where id_przedmiot = @id_przedmiot";
            tbSemestr.Text = pobierzDane.ExecuteScalar().ToString();

            pobierzDane.CommandText = "SELECT Specjalnosc_id_specjalnosc FROM Przedmioty Where id_przedmiot = @id_przedmiot";
            DropDownList1.SelectedValue = pobierzDane.ExecuteScalar().ToString();

        }
        protected void btnAktualizujPrzedmiot_Click(object sender, EventArgs e)
        {
            

            string nazwa = Request.Form["tbNazwa"];
            string ile_godzin = Request.Form["tbIleGodzin"];
            string typ_zajec = Request.Form["tbTypZajec"];
            string semestr = Request.Form["tbSemestr"];
            string specjalnosc = Request["DropDownList1"];
            SqlCommand edytujStudenta = new SqlCommand();

            edytujStudenta.Connection = conn;

            int h;
            int.TryParse(id_przedmiot, out h);
            edytujStudenta.Parameters.Add("@id_przedmiot", SqlDbType.Int);
            edytujStudenta.Parameters["@id_przedmiot"].Value = h;

            edytujStudenta.Parameters.Add("@nazwa", SqlDbType.VarChar);
            edytujStudenta.Parameters["@nazwa"].Value = nazwa;

            edytujStudenta.Parameters.Add("@ile_godzin", SqlDbType.Int);
            edytujStudenta.Parameters["@ile_godzin"].Value = ile_godzin;

            edytujStudenta.Parameters.Add("@typ_zajec", SqlDbType.VarChar);
            edytujStudenta.Parameters["@typ_zajec"].Value = typ_zajec;

            edytujStudenta.Parameters.Add("@semestr", SqlDbType.Int);
            edytujStudenta.Parameters["@semestr"].Value = semestr;

            edytujStudenta.Parameters.Add("@Specjalnosc_id_specjalnosc", SqlDbType.Int);
            edytujStudenta.Parameters["@Specjalnosc_id_specjalnosc"].Value = specjalnosc;

            edytujStudenta.CommandText = "UPDATE Przedmioty SET nazwa = @nazwa ,ile_godzin = @ile_godzin,typ_zajec = @typ_zajec,semestr = @semestr,Specjalnosc_id_specjalnosc = @Specjalnosc_id_specjalnosc WHERE id_przedmiot = @id_przedmiot ";
            edytujStudenta.ExecuteNonQuery();
            edytujStudenta.Dispose();
            conn.Close();

            /*
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter adapt;
            adapt = new SqlDataAdapter("Select id_przedmiot,nazwa,ile_godzin, typ_zajec,semestr, Specjalnosc_id_specjalnosc from Przedmioty", conn);
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                GridView3.DataSource = dt;
            }
            conn.Close();
            */
            /*
            SqlDataSource3.UpdateCommandType = SqlDataSourceCommandType.Text;
            SqlDataSource3.UpdateParameters.Clear();
            SqlDataSource3.UpdateParameters.Add("id_przedmiot", id_przedmiot);
            SqlDataSource3.UpdateParameters.Add("nazwa", tbNazwa.Text);
            SqlDataSource3.UpdateParameters.Add("ile_godzin", tbIleGodzin.Text);
            SqlDataSource3.UpdateParameters.Add("typ_zajec", tbTypZajec.Text);
            SqlDataSource3.UpdateParameters.Add("semestr", tbSemestr.Text);
            SqlDataSource3.UpdateParameters.Add("Specjalnosc_id_specjalnosc", DropDownList1.SelectedValue.ToString());
            SqlDataSource3.UpdateCommand = "UPDATE Przedmioty SET nazwa = @nazwa ,ile_godzin = @ile_godzin,typ_zajec = @typ_zajec,semestr = @semestr,Specjalnosc_id_specjalnosc = @Specjalnosc_id_specjalnosc WHERE id_przedmiot = @id_przedmiot ";
            SqlDataSource3.Update();
            GridView3.DataBind();
            */
            Panel3.Visible = false;
        }

    }
}