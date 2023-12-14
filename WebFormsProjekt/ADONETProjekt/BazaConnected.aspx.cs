using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ADONETProjekt
{
    public partial class Baza : System.Web.UI.Page
    {

        private readonly SqlConnection _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AdoNetConnectionString"].ToString());
        private SqlCommand _command;
        private SqlDataReader _dr;

        protected void Page_Load(object sender, EventArgs e)
        {
            Display();
        }



        //Metoda koja dohvaća podatke iz baze i povezuje ih s Gridom
        private void Display()
        {
            //otvaramo konekciju
            _connection.Open();
            //konekciji dodjeljujemo naredbu
            _command = new SqlCommand("SELECT * FROM Student", _connection);
            //izvršavamo naredbu
            _dr = _command.ExecuteReader();
            //povezujemo grid i rezultat
            gvStudents.DataSource = _dr;
            gvStudents.DataBind();
            //zatvaramo konekcije prema bazi
            _dr.Close();
            _connection.Close();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            _connection.Open();
            _command = new SqlCommand("INSERT INTO Student(Ime, Prezime, GodinaUpisa)VALUES(@ime, @prezime, @godina)", _connection);
            _command.Parameters.AddWithValue("@ime", tbIme.Text);
            _command.Parameters.AddWithValue("@prezime", tbPrezime.Text);
            _command.Parameters.AddWithValue("@godina", tbGodina.Text);
            _command.ExecuteNonQuery(); // ništa ne vraća
            _connection.Close();
            Display();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            _connection.Open();

            //ovo nije dobar način za prosljeđivanje upita prema bazi jer nam u textbox netko može unijeti kod kojeg ćemo proslijediti prema bazi
            //a taj kod može potencijalno i cijelu bazu pobrisati npr. 1;DROP DATABASE Organization
            //SQL Injection problem
            //command = new SqlCommand("DELETE FROM Student where Id=@id=" + tbId.Text, _connection);

            _command = new SqlCommand("DELETE FROM Student where Id=@id", _connection);
            _command.Parameters.AddWithValue("@id", tbId.Text);
            _command.ExecuteNonQuery();
            _connection.Close();
            Display();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            _connection.Open();
            _command = new SqlCommand("UPDATE Student SET GodinaUpisa=@godina WHERE Id=@id", _connection);
            _command.Parameters.AddWithValue("@id", tbId.Text);
            _command.Parameters.AddWithValue("@godina", tbGodina.Text);
            _command.ExecuteNonQuery();
            _connection.Close();
            Display();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            _connection.Open();
            _command = new SqlCommand("SELECT * FROM Student WHERE Id=@id", _connection);
            _command.Parameters.AddWithValue("@id", tbId.Text);
            _dr = _command.ExecuteReader();
            gvStudents.DataSource = _dr;
            gvStudents.DataBind();
            _dr.Close();
            _connection.Close();
        }

        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            Display();
        }

        protected void btnTotal_Click(object sender, EventArgs e)
        {
            _connection.Open();
            _command = new SqlCommand("SELECT COUNT(*) FROM Student", _connection);
            int total = (int)_command.ExecuteScalar(); //vraća jednu vrijednost
            lblTotal.Text = "Total Record:--> " + total.ToString();
            _connection.Close();
        }
    }
}