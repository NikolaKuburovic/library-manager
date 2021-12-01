using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Biblioteka
{
    public partial class DodajKorisnika : Form
    {
        SqlConnection scon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Biblioteka.mdf;Integrated Security=True");
        public DodajKorisnika()
        {
            InitializeComponent();
        }

        private void ButtonDodajKorisnika_Click(object sender, EventArgs e)
        {
            try
            {
                if (scon.State == ConnectionState.Closed)
                {

                    scon.Open();
                    SqlCommand scmd = new SqlCommand("DodajKorisnika", scon);
                    scmd.CommandType = CommandType.StoredProcedure;
                    scmd.Parameters.AddWithValue("@ime", textBoxIme.Text.Trim());
                    scmd.Parameters.AddWithValue("@prezime", textBoxPrezime.Text.Trim());
                    scmd.Parameters.AddWithValue("@email", textBoxEmail.Text.Trim());
                    //scmd.ExecuteNonQuery();
                    int idBroj = (int)scmd.ExecuteScalar();

                    MessageBox.Show("Korisnik " + textBoxIme.Text.Trim() + " je uspesno dodat u bazu. Njegov korisnicki broj je: " + idBroj + "");

                    textBoxIme.Clear();
                    textBoxPrezime.Clear();
                    textBoxEmail.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Dogodila se greska!");
            }
            finally
            {
                scon.Close();
            }
        }
    }

}
