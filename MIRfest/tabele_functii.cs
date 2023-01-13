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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select a.prenume, a.nume, t.nume as 'trupa'\r\nfrom artisti a join contine c on (a.id_artist = c.id_artist)\r\n\t\t\t   join trupe t on (t.id_trupa = c.id_trupa)\r\nwhere t.nume = 'PreaTarziu' or t.nume = 'PreaDevreme' or a.nume = 'ionescu';", con);
                DataTable the_important_stuff = new DataTable();
                sqlDa.Fill(the_important_stuff);
                dataGridView1.DataSource = the_important_stuff;

            }
        }
    }
}
