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
    public partial class StanjeKnjiga : Form
    {
        SqlConnection scon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Biblioteka.mdf;Integrated Security=True");
        public StanjeKnjiga()
        {
            InitializeComponent();
        }

        private void TextBoxPretraga_KeyUp(object sender, KeyEventArgs e)
        {
            if (scon.State == ConnectionState.Open)
            {
                scon.Close();
            }
            scon.Open();

            SqlCommand scom = scon.CreateCommand();
            scom.CommandType = CommandType.Text;
            scom.CommandText = "SELECT naslov, pisac_ime, pisac_prezime, broj_primeraka, dostupno_primeraka FROM Knjige WHERE naslov LIKE('%" + textBoxPretraga.Text + "%')";
            scom.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(scom);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void StanjeKnjiga_Load(object sender, EventArgs e)
        {
            if (scon.State == ConnectionState.Open)
            {
                scon.Close();
            }
            scon.Open();

            SqlCommand scom = scon.CreateCommand();
            scom.CommandType = CommandType.Text;
            scom.CommandText = "SELECT naslov, pisac_ime, pisac_prezime, broj_primeraka, dostupno_primeraka FROM Knjige";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(scom);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (scon.State == ConnectionState.Open)
            {
                scon.Close();
            }
            scon.Open();

            string naslov;
            naslov = dataGridView1.SelectedCells[0].Value.ToString();

            SqlCommand scom = scon.CreateCommand();
            scom.CommandType = CommandType.Text;
            scom.CommandText = "SELECT * FROM Izdavanje WHERE naslov='" + naslov + "' AND datum_vracanja=''";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(scom);
            da.Fill(dt);
            dataGridView2.DataSource = dt;


        }
    }
}
