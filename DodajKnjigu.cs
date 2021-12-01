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
    public partial class dodajKnjigu : Form
    {
        SqlConnection scon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Biblioteka.mdf;Integrated Security=True");
        public dodajKnjigu()
        {
            InitializeComponent();
        }

        private void ButtonDodajKnjigu_Click(object sender, EventArgs e)
        {
            try
            {
                if (scon.State == ConnectionState.Closed)
                {

                    scon.Open();
                    SqlCommand scmd = new SqlCommand("DodajKnjigu", scon);
                    scmd.CommandType = CommandType.StoredProcedure;
                    scmd.Parameters.AddWithValue("@naslov", textBoxNaslov.Text.Trim());
                    scmd.Parameters.AddWithValue("@pisac_ime", textBoxPisacIme.Text.Trim());
                    scmd.Parameters.AddWithValue("@pisac_prezime", textBoxPisacPrezime.Text.Trim());
                    scmd.Parameters.AddWithValue("@izdavac", textBoxIzdavac.Text.Trim());
                    scmd.Parameters.AddWithValue("@godina_izdavanja", int.Parse(textBoxGodina.Text.Trim()));
                    scmd.Parameters.AddWithValue("@broj_strana", int.Parse(textBoxStrane.Text.Trim()));
                    scmd.Parameters.AddWithValue("@broj_primeraka", int.Parse(textBoxBrojPrimeraka.Text.Trim()));
                    scmd.Parameters.AddWithValue("@dostupno_primeraka", int.Parse(textBoxBrojPrimeraka.Text.Trim()));
                    scmd.ExecuteNonQuery();

                    MessageBox.Show("Knjiga je uspesno dodata u bazu...");

                    textBoxNaslov.Clear();
                    textBoxPisacIme.Clear();
                    textBoxPisacPrezime.Clear();
                    textBoxIzdavac.Clear();
                    textBoxGodina.Clear();
                    textBoxStrane.Clear();
                    textBoxBrojPrimeraka.Clear();
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
