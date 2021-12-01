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
    public partial class PregledajKorisnike : Form
    {
        SqlConnection scon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Biblioteka.mdf;Integrated Security=True");
        public PregledajKorisnike()
        {
            InitializeComponent();
        }

        private void PregledajKorisnike_Load(object sender, EventArgs e)
        {
            prikaziKorisnike();
        }
        public void prikaziKorisnike()
        {
            try
            {
                if (scon.State == ConnectionState.Closed)
                {

                    scon.Open();
                    SqlCommand scmd = new SqlCommand("PregledajKorisnike", scon);
                    scmd.CommandType = CommandType.StoredProcedure;
                    scmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(scmd);
                    da.Fill(dt);
                    dataGridViewKorisnici.DataSource = dt;

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

        private void TextBoxTrazi_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (scon.State == ConnectionState.Closed)
                {

                    scon.Open();
                    SqlCommand scmd = scon.CreateCommand();
                    scmd.CommandType = CommandType.Text;
                    scmd.CommandText = "SELECT * FROM Korisnici WHERE (ime LIKE ('%" + textBoxTrazi.Text + "%')) OR (prezime LIKE ('%" + textBoxTrazi.Text + "%'))";
                    scmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(scmd);
                    da.Fill(dt);
                    dataGridViewKorisnici.DataSource = dt;

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

        private void DataGridViewKorisnici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            int red;
            red = Convert.ToInt32(dataGridViewKorisnici.SelectedCells[0].Value.ToString());
            try
            {
                if (scon.State == ConnectionState.Closed)
                {

                    scon.Open();
                    SqlCommand scmd = scon.CreateCommand();
                    scmd.CommandType = CommandType.Text;
                    scmd.CommandText = "SELECT * FROM Korisnici WHERE Id=" + red + "";
                    scmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(scmd);
                    da.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        textBoxImeK.Text = dr["ime"].ToString();
                        textBoxPrezimeK.Text = dr["prezime"].ToString();
                        textBoxEmailK.Text = dr["email"].ToString();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            int red;
            red = Convert.ToInt32(dataGridViewKorisnici.SelectedCells[0].Value.ToString());

            try
            {
                if (scon.State == ConnectionState.Closed)
                {

                    scon.Open();
                    SqlCommand scmd = scon.CreateCommand();
                    scmd.CommandType = CommandType.Text;
                    scmd.CommandText = "UPDATE Korisnici SET ime='" + textBoxImeK.Text + "', prezime='" + textBoxPrezimeK.Text + "', email='" + textBoxEmailK.Text + "' WHERE id='" + red + "'";
                    scmd.ExecuteNonQuery();
                    scon.Close();
                    prikaziKorisnike();
                    MessageBox.Show("Uspešno su izmenjeni podaci za korisnika");

                    panel1.Visible = false;

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
