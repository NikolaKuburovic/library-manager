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
    public partial class PregledajKnjige : Form
    {
        SqlConnection scon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Biblioteka.mdf;Integrated Security=True");
        public PregledajKnjige()
        {
            InitializeComponent();
        }

        private void PregledajKnjige_Load(object sender, EventArgs e)
        {
            prikaziKnjige();
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
                    scmd.CommandText = "SELECT * FROM Knjige WHERE (naslov LIKE ('%" + textBoxTrazi.Text + "%')) OR (pisac_ime LIKE ('%" + textBoxTrazi.Text + "%')) OR (pisac_prezime LIKE ('%" + textBoxTrazi.Text + "%'))";
                    scmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(scmd);
                    da.Fill(dt);
                    dataGridViewKnjige.DataSource = dt;

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

        private void DataGridViewKnjige_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            int red;
            red = Convert.ToInt32(dataGridViewKnjige.SelectedCells[0].Value.ToString());
            try
            {
                if (scon.State == ConnectionState.Closed)
                {

                    scon.Open();
                    SqlCommand scmd = scon.CreateCommand();
                    scmd.CommandType = CommandType.Text;
                    scmd.CommandText = "SELECT * FROM Knjige WHERE Id=" + red + "";
                    scmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(scmd);
                    da.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        textBoxNaslov.Text = dr["naslov"].ToString();
                        textBoxIme.Text = dr["pisac_ime"].ToString();
                        textBoxPrezime.Text = dr["pisac_prezime"].ToString();
                        textBoxIzdavac.Text = dr["izdavac"].ToString();
                        textBoxGodina.Text = dr["godina_izdavanja"].ToString();
                        textBoxStrana.Text = dr["broj_strana"].ToString();
                        textBoxPrimerci.Text = dr["broj_primeraka"].ToString();
                        textBoxDostupno.Text = dr["dostupno_primeraka"].ToString();
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
            red = Convert.ToInt32(dataGridViewKnjige.SelectedCells[0].Value.ToString());

            try
            {
                if (scon.State == ConnectionState.Closed)
                {

                    scon.Open();
                    SqlCommand scmd = scon.CreateCommand();
                    scmd.CommandType = CommandType.Text;
                    scmd.CommandText = "UPDATE Knjige SET naslov='" + textBoxNaslov.Text + "', pisac_ime='" + textBoxIme.Text + "', pisac_prezime='" + textBoxPrezime.Text + "', izdavac='" + textBoxIzdavac.Text + "', godina_izdavanja='" + textBoxGodina.Text + "', broj_strana='" + textBoxStrana.Text + "',broj_primeraka='" + textBoxPrimerci.Text + "',dostupno_primeraka='" + textBoxDostupno.Text + "' WHERE id='" + red + "'";
                    scmd.ExecuteNonQuery();
                    scon.Close();
                    prikaziKnjige();
                    MessageBox.Show("Uspešno su izmenjeni podaci za knjigu");

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

        public void prikaziKnjige()
        {
            try
            {
                if (scon.State == ConnectionState.Closed)
                {

                    scon.Open();
                    SqlCommand scmd = new SqlCommand("PregledajKnjige", scon);
                    scmd.CommandType = CommandType.StoredProcedure;
                    scmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(scmd);
                    da.Fill(dt);
                    dataGridViewKnjige.DataSource = dt;

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
