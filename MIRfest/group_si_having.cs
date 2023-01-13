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
    public partial class group_si_having : Form
    {
        public group_si_having()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void group_si_having_Load(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("select s.nume as 'numele scenei', s.index_scena as 'indexul scenei', s.metri_patrati , max(e.pret) as 'cel mai scump echipament'\r\nfrom scene s join echipament e on (s.index_scena = e.index_scena)\r\ngroup by s.nume, s.index_scena, s.metri_patrati\r\nhaving s.metri_patrati > 40\r\norder by 'cel mai scump echipament' desc;", con);
                DataTable group_having = new DataTable();
                sqlDa.Fill(group_having);
                dataGridView1.DataSource = group_having;

            }
        }
    }
}
