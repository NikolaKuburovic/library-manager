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
    public partial class Prijava : Form
    {
        SqlConnection scon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Biblioteka.mdf;Integrated Security=True");
        int broj;
        public Prijava()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (scon.State == ConnectionState.Open)
            {
                scon.Close();
            }
            scon.Open();

            SqlCommand scmd = scon.CreateCommand();
            scmd.CommandType = CommandType.Text;
            scmd.CommandText = "SELECT * FROM Administratori WHERE korisnicko_ime='" + textBoxImeP.Text + "' AND lozinka='" + textBoxLozinka.Text + "'";
            scmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(scmd);
            da.Fill(dt);

            broj = Convert.ToInt32(dt.Rows.Count.ToString());

            if (broj == 0)
            {
                MessageBox.Show("Korisnicko ime i lozinka nisu odgovarajuci!");
            }
            else
            {
                this.Hide();
                BibliotekaMain bm = new BibliotekaMain();
                bm.Show();
            }

        }
    }
}
