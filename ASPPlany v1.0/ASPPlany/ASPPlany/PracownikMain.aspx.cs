using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPPlany
{
    public partial class PracownikMain : System.Web.UI.Page
    {
        public string ktoZalogowany = null;
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

        protected void btnDodajPrzedmiot_Click(object sender, EventArgs e)
        {
            pDodajPrzedmiot.Visible = true;
        }

        protected void btnZapiszPrzedmiot_Click(object sender, EventArgs e)
        {
            SqlDataSource2.InsertCommandType = SqlDataSourceCommandType.Text;
            SqlDataSource2.InsertCommand = "Insert into Przedmioty (nazwa,ile_godzin,typ_zajec,semestr,Specjalnosc_id_specjalnosc) VALUES (@nazwa,@ile_godzin,@typ_zajec,@semestr,@Specjalnosc_id_specjalnosc)";
            SqlDataSource2.InsertParameters.Clear();
            SqlDataSource2.InsertParameters.Add("nazwa", tbNazwaPrzedmiot.Text);
            SqlDataSource2.InsertParameters.Add("ile_godzin", tbIleGodzinPrzedmiot.Text);
            SqlDataSource2.InsertParameters.Add("typ_zajec", tbTypZajecPrzedmiot.Text);
            SqlDataSource2.InsertParameters.Add("semestr", tbSemestrPrzedmiot.Text);
            SqlDataSource2.InsertParameters.Add("Specjalnosc_id_specjalnosc", ddlPrzedmiotSpecjalizacja.SelectedValue.ToString());
            SqlDataSource2.Insert();
            pDodajPrzedmiot.Visible = false;
        }

        protected void btnPrzedmioty_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 6;
        }

        protected void btnStudenci_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 5;
        }

        protected void btnSpecjalnosci_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 4;
        }

        protected void btnKierunki_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 3;
        }

        protected void btnKatedry_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }

        protected void btnStypendia_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnPracownicy_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void btnDodajStudenci_Click(object sender, EventArgs e)
        {
            pDodajStudenci.Visible = true;
        }

        protected void btnZapiszStudenci_Click(object sender, EventArgs e)
        {

            SqlDataSource3.InsertCommandType = SqlDataSourceCommandType.Text;
            SqlDataSource3.InsertCommand = "Insert into Studenci (imie,nazwisko,rok_urodzenia,obecnosc_dzieci,ile_dzieci,login,haslo,plec,grupa,Stypendium_id_stypendium,Katedra_id_katedra,Specjalnosc_id_specjalnosc) VALUES (@imie,@nazwisko,@rok_urodzenia,@obecnosc_dzieci,@ile_dzieci,@login,@haslo,@plec,@grupa,@Stypendium_id_stypendium,@Katedra_id_katedra,@Specjalnosc_id_specjalnosc)";
            SqlDataSource3.InsertParameters.Clear();
            SqlDataSource3.InsertParameters.Add("imie", tbImieStudenci.Text);
            SqlDataSource3.InsertParameters.Add("nazwisko", tbNazwiskoStudenci.Text);
            SqlDataSource3.InsertParameters.Add("rok_urodzenia", tbRokUrodzeniaStudenci.Text);
            SqlDataSource3.InsertParameters.Add("obecnosc_dzieci", chbObecnoscDzieciStudenci.Checked.ToString());
            SqlDataSource3.InsertParameters.Add("ile_dzieci", tbIleDzieciStudenci.Text);
            SqlDataSource3.InsertParameters.Add("login", tbLoginStudenci.Text);
            SqlDataSource3.InsertParameters.Add("haslo", tbHasloStudenci.Text);
            SqlDataSource3.InsertParameters.Add("grupa", tbGrupaStudenci.Text);
            SqlDataSource3.InsertParameters.Add("plec", tbPlecStudenci.Text);
            SqlDataSource3.InsertParameters.Add("Stypendium_id_stypendium", ddlStypendiumStudenci.SelectedValue.ToString());
            SqlDataSource3.InsertParameters.Add("Katedra_id_katedra", ddlKatedraStudenci.SelectedValue.ToString());
            SqlDataSource3.InsertParameters.Add("Specjalnosc_id_specjalnosc", ddlSpecjalnoscStudenci.SelectedValue.ToString());
            SqlDataSource3.Insert();
            pDodajStudenci.Visible = false;
        }

        protected void btnDodajSpecjalnosc_Click(object sender, EventArgs e)
        {
            pDodajSpecjalnosc.Visible = true;
        }

        protected void btnZapiszSpecjalnosc_Click(object sender, EventArgs e)
        {
            SqlDataSource7.InsertCommandType = SqlDataSourceCommandType.Text;
            SqlDataSource7.InsertCommand = "Insert into Specjalnosc (nazwa,stopien,Katedra_id_katedra) VALUES (@nazwa,@stopien,@Katedra_id_katedra)";
            SqlDataSource7.InsertParameters.Clear();
            SqlDataSource7.InsertParameters.Add("nazwa", tbNazwaSpecjalnosc.Text);
            SqlDataSource7.InsertParameters.Add("stopien", tbStopienSpecjalnosc.Text);
            SqlDataSource7.InsertParameters.Add("Katedra_id_katedra", ddlKatedraSpecjalnosc.SelectedValue.ToString());
            SqlDataSource7.Insert();
            pDodajSpecjalnosc.Visible = false;
        }

        protected void btnDodajKierunek_Click(object sender, EventArgs e)
        {
            pDodajKierunek.Visible = true;
        }

        protected void btnZapiszKierunek_Click(object sender, EventArgs e)
        {

            kierunekSqlDataSource.InsertCommandType = SqlDataSourceCommandType.Text;
            kierunekSqlDataSource.InsertCommand = "Insert into Kierunek (nazwa,wydział) VALUES (@nazwa,@wydział)";
            kierunekSqlDataSource.InsertParameters.Clear();
            kierunekSqlDataSource.InsertParameters.Add("nazwa", tbNazwaKierunek.Text);
            kierunekSqlDataSource.InsertParameters.Add("wydział", tbWydzialKierunek.Text);
            kierunekSqlDataSource.Insert();
            pDodajKierunek.Visible = false;
        }

        protected void GridView5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnDodajKatedre_Click(object sender, EventArgs e)
        {
            pDodajKatedre.Visible = true;
        }

        protected void btnZapiszKatedre_Click(object sender, EventArgs e)
        {
            KatedraSqlDataSource.InsertCommandType = SqlDataSourceCommandType.Text;
            KatedraSqlDataSource.InsertCommand = "Insert into Katedra (nazwa,Kierunek_id_kierunek) VALUES (@nazwa,@Kierunek_id_kierunek)";
            KatedraSqlDataSource.InsertParameters.Clear();
            KatedraSqlDataSource.InsertParameters.Add("nazwa", tbNazwaKatedra.Text);
            KatedraSqlDataSource.InsertParameters.Add("Kierunek_id_kierunek", ddlKierunekKatedra.Text);
            KatedraSqlDataSource.Insert();
            pDodajKatedre.Visible = false;
        }

        protected void btnDodajStypendia_Click(object sender, EventArgs e)
        {
            pDodajStypendium.Visible = true;
        }

        protected void btnZapiszStypendia_Click(object sender, EventArgs e)
        {
            StypendiaSqlDataSource.InsertCommandType = SqlDataSourceCommandType.Text;
            StypendiaSqlDataSource.InsertCommand = "Insert into Stypendium (rodizaj,kwota) VALUES (@rodizaj,@kwota)";
            StypendiaSqlDataSource.InsertParameters.Clear();
            StypendiaSqlDataSource.InsertParameters.Add("rodizaj", tbRodzajStypendium.Text);
            StypendiaSqlDataSource.InsertParameters.Add("kwota", tbKwotaStypendium.Text);
            StypendiaSqlDataSource.Insert();
            pDodajStypendium.Visible = false;
        }

        protected void btnZapiszPracownik_Click(object sender, EventArgs e)
        {
            PracownicySqlDataSource.InsertCommandType = SqlDataSourceCommandType.Text;
            PracownicySqlDataSource.InsertCommand = "Insert into Pracownicy (imie,nazwisko,rok_urodzenia,obecnosc_dzieci,ile_dzieci,login,haslo,plec,czy_wykladowca,Katedra_id_katedra,Przedmioty_id_przedmiot) VALUES (@imie,@nazwisko,@rok_urodzenia,@obecnosc_dzieci,@ile_dzieci,@login,@haslo,@plec,@czy_wykladowca,@Katedra_id_katedra,@Przedmioty_id_przedmiot)";
            PracownicySqlDataSource.InsertParameters.Clear();
            PracownicySqlDataSource.InsertParameters.Add("imie", tbImiePracownik.Text);
            PracownicySqlDataSource.InsertParameters.Add("nazwisko", tbNazwiskoPracownik.Text);
            PracownicySqlDataSource.InsertParameters.Add("rok_urodzenia", tbRokUrodzeniaPracownik.Text);
            PracownicySqlDataSource.InsertParameters.Add("obecnosc_dzieci", chbObecnoscDzieciPracownik.Checked.ToString());
            PracownicySqlDataSource.InsertParameters.Add("ile_dzieci", tbIleDzieciPracownik.Text);
            PracownicySqlDataSource.InsertParameters.Add("login", tbLoginPracownik.Text);
            PracownicySqlDataSource.InsertParameters.Add("haslo", tbHasloPracownik.Text);
            PracownicySqlDataSource.InsertParameters.Add("czy_wykladowca", chbCzyWykladowcaPracownik.Checked.ToString());
            PracownicySqlDataSource.InsertParameters.Add("plec", tbPlecPracownik.Text);
            PracownicySqlDataSource.InsertParameters.Add("Katedra_id_katedra", ddlKatedraPracownik.SelectedValue.ToString());
            PracownicySqlDataSource.InsertParameters.Add("Przedmioty_id_przedmiot", ddlPrzedmiotPracownik.SelectedValue.ToString());
            PracownicySqlDataSource.Insert();
            pDodajPracownik.Visible = false;
        }

        protected void btnDodajPracownik_Click(object sender, EventArgs e)
        {
            pDodajPracownik.Visible = true;
        }
    }
}