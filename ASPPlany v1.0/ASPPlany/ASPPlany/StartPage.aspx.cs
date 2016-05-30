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
        }
    }
}