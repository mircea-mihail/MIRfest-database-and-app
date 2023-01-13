using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIRfest
{
    public partial class vizualizari : Form
    {
        public vizualizari()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //compusa
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select * from esential_trupa_artist", con);
                DataTable trupa_artist = new DataTable();
                sqlDa.Fill(trupa_artist);
                dataGridView1.DataSource = trupa_artist;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //complexa
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select * from trupa_artist_marca", con);
                DataTable trupa_artist_marca = new DataTable();
                sqlDa.Fill(trupa_artist_marca);
                dataGridView1.DataSource = trupa_artist_marca;

            }
        }
    }
}
