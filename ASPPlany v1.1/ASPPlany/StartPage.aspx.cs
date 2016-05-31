using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPPlany
{
    public partial class StartPage : System.Web.UI.Page
    {
        PlanyKsztalceniaEntities db = new PlanyKsztalceniaEntities();

        public bool studentLogin = false;
        bool login = false;
        bool haslo = false;
        bool zalogowany = false;
        string ktoZalogowany = null;


        public string getKtoZalogowany(string value)
        {
            value = ktoZalogowany;
            return value;
        }
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnStudent_Click(object sender, EventArgs e)
        {
            ktoZalogowany = "Student";
            panelLogowanie.Visible = true;
        }

        protected void btnWykladowca_Click(object sender, EventArgs e)
        {
            ktoZalogowany = "Wykladowca";
            panelLogowanie.Visible = true;
        }

        protected void btnPracownik_Click(object sender, EventArgs e)
        {
            ktoZalogowany = "Pracownik";
            panelLogowanie.Visible = true;
        }


        public bool logowanie(string ktoZalogowany)
        {
            string script = "alert(\"Hello!\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);
            if (studentLogin != false)
            {
                 script = "alert(\"Hello22!\");";
                ScriptManager.RegisterStartupScript(this, GetType(),
                                      "ServerControlScript", script, true);
                foreach (var student in db.Studenci)
                {
                    if (student.login == tbLogin.Text)
                    {
                        login = true;
                        if (student.haslo == tbHaslo.Text)
                        {
                            haslo = true;
                            break;
                        }
                        else
                        {
                            haslo = false;
                            break;
                        }
                    }
                    else
                    {
                        login = false;
                    }
                }

                if (login == true)
                {
                    if (haslo == true)
                    {
                        zalogowany = true;
                    }
                    else
                    {
                        labelZleHaslo.Visible = true;
                        /*
                        string script = "alert(\"Hello!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                                              */
                    }
                }
                else
                {
                    labelZlyLogin.Visible = true;
                   // MessageBox.Show("Użytkownik o takim loginie nie istnieje.", "Wstecz");
                }
            }

            else if(ktoZalogowany == "Wykladowca")
            {
                foreach (var wykladowca in db.Pracownicy)
                {
                    if (wykladowca.login == tbLogin.Text)
                    {
                        login = true;
                        if (wykladowca.haslo == tbHaslo.Text)
                        {
                            haslo = true;
                            break;
                        }
                        else
                        {
                            haslo = false;
                            break;
                        }
                    }
                    else
                    {
                        login = false;
                    }
                }

                if (login == true)
                {
                    if (haslo == true)
                    {
                        zalogowany = true;
                    }
                    else
                    {
                        labelZleHaslo.Visible = true;
                        /*
                        string script = "alert(\"Hello!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                                              */
                    }
                }
                else
                {
                    labelZlyLogin.Visible = true;
                    // MessageBox.Show("Użytkownik o takim loginie nie istnieje.", "Wstecz");
                }
            }
            else if (ktoZalogowany == "Pracownik")
            {
                foreach (var pracownik in db.Pracownicy)
                {
                    if (pracownik.login == tbLogin.Text)
                    {
                        login = true;
                        if (pracownik.haslo == tbHaslo.Text)
                        {
                            haslo = true;
                            break;
                        }
                        else
                        {
                            haslo = false;
                            break;
                        }
                    }
                    else
                    {
                        login = false;
                    }
                }

                if (login == true)
                {
                    if (haslo == true)
                    {
                        zalogowany = true;
                    }
                    else
                    {
                        labelZleHaslo.Visible = true;
                        /*
                        string script = "alert(\"Hello!\");";
                        ScriptManager.RegisterStartupScript(this, GetType(),
                                              "ServerControlScript", script, true);
                                              */
                    }
                }
                else
                {
                    labelZlyLogin.Visible = true;
                    // MessageBox.Show("Użytkownik o takim loginie nie istnieje.", "Wstecz");
                }
            }
            return zalogowany;
        }

        protected void btnZaloguj_Click(object sender, EventArgs e)
        {

            //logowanie(ktoZalogowany);

           // if (zalogowany == true)
          //  {
                /*
                ktoZalogowany = "admin";
                Session["name"] = tbLogin.Text;
                Server.Transfer("PracownikMain.aspx", true);
                */
                if (tbLogin.Text == "Student")
                {
                    string script = "alert(\"Student\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                    Session["name"] = tbLogin.Text;
                    Server.Transfer("StudentMain.aspx", true);
                }
                else if (tbLogin.Text == "Wykladowca")
                {
                    string script = "alert(\"Wykladowca\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                    Session["name"] = tbLogin.Text;
                    Server.Transfer("WykladowcaMain.aspx", true);
                }
                else if (tbLogin.Text == "Pracownik")
                {
                    string script = "alert(\"Pracownik\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                    Session["name"] = tbLogin.Text;
                    Server.Transfer("PracownikMain.aspx", true);
                }
                if (ktoZalogowany == "Student")
                {
                    string script = "alert(\"Student\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                    Session["name"] = tbLogin.Text;
                    Server.Transfer("StudentMain.aspx", true);
                }
                else if(ktoZalogowany == "Wykladowca")
                {
                    string script = "alert(\"Wykladowca\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                    Session["name"] = tbLogin.Text;
                    Server.Transfer("WykladowcaMain.aspx", true);
                }
                else if(ktoZalogowany == "Pracownik")
                {
                    string script = "alert(\"Pracownik\");";
                    ScriptManager.RegisterStartupScript(this, GetType(),
                                          "ServerControlScript", script, true);
                    Session["name"] = tbLogin.Text;
                    Server.Transfer("PracownikMain.aspx", true);
                }
            /*
            // opening new tab
            Page.ClientScript.RegisterStartupScript(
            this.GetType(), "OpenWindow", "window.open('StudentMain.aspx','_newtab');", true);
            */
            //}
            /*
            -----------------------------------------------------------------------------------------------------------------------
            using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Dziennik.Admin.Formularze
{
    public partial class EdytujStudent : System.Web.UI.Page
    {
        private string connStr;
        private SqlConnection conn;
        private string numerIndeksu;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.numerIndeksu = Request.Cookies["cnumerIndeksuEdStudent"].Value;
            connStr = ConfigurationManager.ConnectionStrings["DzienikOcenConnectionString"].ConnectionString;
            conn = new SqlConnection(connStr);
            conn.Open();
            wypelnij();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            edit();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            conn.Close();
            Response.Redirect("../Studenci.aspx");
        }

        public void wypelnij()
        {
            SqlCommand pobierzDane = new SqlCommand();
            pobierzDane.Connection = conn;
            pobierzDane.Parameters.Add("@numerIndeksu", SqlDbType.VarChar);
            pobierzDane.Parameters["@numerIndeksu"].Value = numerIndeksu;

            pobierzDane.CommandText = "SELECT Gru_ID FROM STUDENCI Where Num_Indeksu = @numerIndeksu";
            int idGru = Convert.ToInt32(pobierzDane.ExecuteScalar());
            gruProjDrop.SelectedValue = idGru.ToString();

            pobierzDane.CommandText = "SELECT Dziek_ID FROM STUDENCI Where Num_Indeksu = @numerIndeksu";
            int idDziek = Convert.ToInt32(pobierzDane.ExecuteScalar());
            gruDziekDrop.SelectedValue = idDziek.ToString();

            pobierzDane.CommandText = "SELECT Wyd_ID FROM STUDENCI Where Num_Indeksu = @numerIndeksu";
            int idWyd = Convert.ToInt32(pobierzDane.ExecuteScalar());
            wydDrop.SelectedValue = idWyd.ToString();

            pobierzDane.CommandText = "SELECT Num_Indeksu FROM STUDENCI Where Num_Indeksu = @numerIndeksu";
            indText.Text = (string)pobierzDane.ExecuteScalar();

            pobierzDane.CommandText = "SELECT Stud_Haslo FROM STUDENCI Where Num_Indeksu = @numerIndeksu";
            passText.Text = (string)pobierzDane.ExecuteScalar();

            pobierzDane.CommandText = "SELECT Stud_Imie FROM STUDENCI Where Num_Indeksu = @numerIndeksu";
            imieText.Text = (string)pobierzDane.ExecuteScalar();

            pobierzDane.CommandText = "SELECT Stud_Nazwisko FROM STUDENCI Where Num_Indeksu = @numerIndeksu";
            nazwiskoText.Text = (string)pobierzDane.ExecuteScalar();

            pobierzDane.CommandText = "SELECT Stud_Miejscowosc FROM STUDENCI Where Num_Indeksu = @numerIndeksu";
            miejscText.Text = (string)pobierzDane.ExecuteScalar();

            pobierzDane.CommandText = "SELECT Stud_Telefon FROM STUDENCI Where Num_Indeksu = @numerIndeksu";
            telText.Text = (string)pobierzDane.ExecuteScalar();
        }

        public void edit()
        {
            string idGru = Request["gruProjDrop"];
            string idDziek = Request["gruDziekDrop"];
            string idWyd = Request["wydDrop"];
            string indeks = Request.Form["indText"];
            string pass = Request.Form["passText"];
            string imie = Request.Form["imieText"];
            string nazwisko = Request.Form["nazwiskoText"];
            string miejscowosc = Request.Form["miejscText"];
            string telefon = Request.Form["telText"];
            SqlCommand edytujStudenta = new SqlCommand();

            edytujStudenta.Connection = conn;

            edytujStudenta.Parameters.Add("@numerIndeksu", SqlDbType.VarChar);
            edytujStudenta.Parameters["@numerIndeksu"].Value = numerIndeksu;

            edytujStudenta.Parameters.Add("@idGru", SqlDbType.Decimal);
            edytujStudenta.Parameters["@idGru"].Value = idGru;

            edytujStudenta.Parameters.Add("@idDziek", SqlDbType.Decimal);
            edytujStudenta.Parameters["@idDziek"].Value = idDziek;

            edytujStudenta.Parameters.Add("@idWyd", SqlDbType.Decimal);
            edytujStudenta.Parameters["@idWyd"].Value = idWyd;

            edytujStudenta.Parameters.Add("@numIndeks", SqlDbType.VarChar);
            edytujStudenta.Parameters["@numIndeks"].Value = indeks;

            edytujStudenta.Parameters.Add("@haslo", SqlDbType.VarChar);
            edytujStudenta.Parameters["@haslo"].Value = pass;

            edytujStudenta.Parameters.Add("@imie", SqlDbType.VarChar);
            edytujStudenta.Parameters["@imie"].Value = imie;

            edytujStudenta.Parameters.Add("@nazwisko", SqlDbType.VarChar);
            edytujStudenta.Parameters["@nazwisko"].Value = nazwisko;

            edytujStudenta.Parameters.Add("@miejsc", SqlDbType.VarChar);
            edytujStudenta.Parameters["@miejsc"].Value = miejscowosc;

            edytujStudenta.Parameters.Add("@telefon", SqlDbType.VarChar);
            edytujStudenta.Parameters["@telefon"].Value = telefon;

            edytujStudenta.CommandText = "UPDATE STUDENCI SET Gru_ID = @idGru, Dziek_ID = @idDziek, Wyd_ID = @idWyd, Num_Indeksu = @numIndeks, Stud_Haslo = @haslo, Stud_Imie = @imie, Stud_Nazwisko = @nazwisko, Stud_Miejscowosc = @miejsc, Stud_Telefon = @telefon  WHERE Num_Indeksu = @numerIndeksu";
            edytujStudenta.ExecuteNonQuery();
            conn.Close();
            Response.Redirect("../Studenci.aspx");
        }

        protected void btnEdit_Click1(object sender, EventArgs e)
        {

        }
    }
}
            ------------------------------------------------------------------------------------------------------------------------------
            */
        }
    }
}