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
    public partial class IzdavanjeKnjige : Form
    {
        SqlConnection scon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Biblioteka.mdf;Integrated Security=True");
        public IzdavanjeKnjige()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (scon.State == ConnectionState.Closed)
                {

                    scon.Open();
                    int broj = 0;
                    SqlCommand scom = scon.CreateCommand();
                    scom.CommandType = CommandType.Text;
                    scom.CommandText = "SELECT * FROM Korisnici WHERE id='" + textBoxIdBroj.Text + "'";
                    scom.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(scom);
                    da.Fill(dt);
                    broj = Convert.ToInt32(dt.Rows.Count.ToString());

                    if (broj == 0)
                    {
                        MessageBox.Show("Ovaj broj clanske karte ne postoji!");
                    }
                    else
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            textBoxImeKor.Text = dr["ime"].ToString();
                            textBoxPrezimeKor.Text = dr["prezime"].ToString();
                        }
                    }
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

        private void IzdavanjeKnjige_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxNaslovK_KeyUp(object sender, KeyEventArgs e)
        {
            int broj = 0;
            if (scon.State == ConnectionState.Open)
            {
                scon.Close();
            }
            scon.Open();

            if (e.KeyCode != Keys.Enter)
            {
                listBoxKnjige.Items.Clear();

                SqlCommand scom = scon.CreateCommand();
                scom.CommandType = CommandType.Text;
                scom.CommandText = "SELECT * FROM Knjige WHERE naslov LIKE ('%" + textBoxNaslovK.Text + "%')";
                scom.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(scom);
                da.Fill(dt);
                broj = Convert.ToInt32(dt.Rows.Count.ToString());

                if (broj > 0)
                {
                    listBoxKnjige.Visible = true;
                    foreach (DataRow dr in dt.Rows)
                    {
                        listBoxKnjige.Items.Add(dr["naslov"].ToString());
                    }
                }
            }
        }

        private void TextBoxNaslovK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBoxKnjige.Focus();
                listBoxKnjige.SelectedIndex = 0;
            }
        }

        private void ListBoxKnjige_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxNaslovK.Text = listBoxKnjige.SelectedItem.ToString();
                listBoxKnjige.Visible = false;
            }
        }

        private void ListBoxKnjige_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxNaslovK.Text = listBoxKnjige.SelectedItem.ToString();
            listBoxKnjige.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (scon.State == ConnectionState.Open)
            {
                scon.Close();
            }
            scon.Open();

            try
            {
                int dostupno = 0;
                SqlCommand scmd = scon.CreateCommand();
                scmd.CommandType = CommandType.Text;
                scmd.CommandText = "SELECT * FROM Knjige WHERE naslov='" + textBoxNaslovK.Text + "'";
                scmd.ExecuteNonQuery();
                DataTable dt1 = new DataTable();
                SqlDataAdapter da1 = new SqlDataAdapter(scmd);
                da1.Fill(dt1);
                foreach (DataRow dr1 in dt1.Rows)
                {
                    dostupno = Convert.ToInt32(dr1["dostupno_primeraka"].ToString());
                }

                if (dostupno > 0)
                {

                    SqlCommand scmd1 = new SqlCommand("IzdajKnjigu", scon);
                    scmd1.CommandType = CommandType.StoredProcedure;
                    scmd1.Parameters.AddWithValue("@korisnik_ime", textBoxImeKor.Text.Trim());
                    scmd1.Parameters.AddWithValue("@korisnik_prezime", textBoxPrezimeKor.Text.Trim());
                    scmd1.Parameters.AddWithValue("@naslov", textBoxNaslovK.Text.Trim());
                    scmd1.Parameters.AddWithValue("@datum_izdavanja", dateTimePicker1.Value.ToShortDateString());
                    scmd1.Parameters.AddWithValue("@datum_vracanja", "");
                    scmd1.Parameters.AddWithValue("@korisnik_id", textBoxIdBroj.Text.Trim());
                    scmd1.ExecuteNonQuery();

                    SqlCommand scmd2 = scon.CreateCommand();
                    scmd2.CommandType = CommandType.Text;
                    scmd2.CommandText = "UPDATE Knjige SET dostupno_primeraka=dostupno_primeraka-1 WHERE naslov='" + textBoxNaslovK.Text + "'";
                    scmd2.ExecuteNonQuery();

                    MessageBox.Show("Knjiga je uspesno izdata!");

                    textBoxIdBroj.Clear();
                    textBoxImeKor.Clear();
                    textBoxPrezimeKor.Clear();
                    textBoxNaslovK.Clear();
                }
                else
                {
                    MessageBox.Show("Knjiga nije trenutno dostupna!");
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
