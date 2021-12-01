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
    public partial class VracanjeKnjige : Form
    {
        SqlConnection scon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Biblioteka.mdf;Integrated Security=True");
        public VracanjeKnjige()
        {
            InitializeComponent();
        }

        private void ButtonTrazi_Click(object sender, EventArgs e)
        {
            if (scon.State == ConnectionState.Open)
            {
                scon.Close();
            }
            scon.Open();
            SqlCommand scom = scon.CreateCommand();
            scom.CommandType = CommandType.Text;
            scom.CommandText = "SELECT * FROM Izdavanje WHERE korisnik_id='" + textBoxIdBrojV.Text + "' AND datum_vracanja=''";
            scom.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(scom);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            panel2.Visible = true;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            int red;
            red = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                if (scon.State == ConnectionState.Closed)
                {

                    scon.Open();
                    SqlCommand scmd = scon.CreateCommand();
                    scmd.CommandType = CommandType.Text;
                    scmd.CommandText = "SELECT * FROM Izdavanje WHERE Id=" + red + "";
                    scmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(scmd);
                    da.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        textBoxNaslovV.Text = dr["naslov"].ToString();
                        textBoxIzdavanje.Text = dr["datum_izdavanja"].ToString();
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

        private void ButtonVrati_Click(object sender, EventArgs e)
        {
            if (scon.State == ConnectionState.Open)
            {
                scon.Close();
            }
            scon.Open();

            int red;
            red = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            SqlCommand scmd = scon.CreateCommand();
            scmd.CommandType = CommandType.Text;
            scmd.CommandText = "UPDATE Izdavanje SET datum_vracanja='" + dateTimePicker1.Value.ToShortDateString() + "' WHERE Id=" + red + "";
            scmd.ExecuteNonQuery();

            SqlCommand scmd1 = scon.CreateCommand();
            scmd1.CommandType = CommandType.Text;
            scmd1.CommandText = "UPDATE Knjige SET dostupno_primeraka=dostupno_primeraka+1 WHERE naslov='" + textBoxNaslovV.Text + "'";
            scmd1.ExecuteNonQuery();

            MessageBox.Show("Knjiga je uspesno vracena!");

            SqlCommand scom2 = scon.CreateCommand();
            scom2.CommandType = CommandType.Text;
            scom2.CommandText = "SELECT * FROM Izdavanje WHERE korisnik_id='" + textBoxIdBrojV.Text + "' AND datum_vracanja=''";
            scom2.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(scom2);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            textBoxNaslovV.Clear();
            textBoxIzdavanje.Clear();
        }
    }
}
