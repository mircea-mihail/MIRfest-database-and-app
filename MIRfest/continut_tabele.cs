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
using static System.Formats.Asn1.AsnWriter;

namespace MIRfest
{
    public partial class continut_tabele : Form
    {
        public continut_tabele()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //trupe
        private void button7_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Trupe", con);
                DataTable Trupe = new DataTable();
                sqlDa.Fill(Trupe);
                dataGridView1.DataSource = Trupe;

            }
        }
        //piese
        private void button1_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Piese", con);
                DataTable Piese = new DataTable();
                sqlDa.Fill(Piese);
                dataGridView1.DataSource = Piese;

            }
        }
        //artisti
        private void button3_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Artisti", con);
                DataTable Artisti = new DataTable();
                sqlDa.Fill(Artisti);
                dataGridView1.DataSource = Artisti;

            }
        }
        //instrumente
        private void button5_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Instrumente", con);
                DataTable Instrumente = new DataTable();
                sqlDa.Fill(Instrumente);
                dataGridView1.DataSource = Instrumente;

            }
        }
        //scene
        private void button4_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Scene", con);
                DataTable Scene = new DataTable();
                sqlDa.Fill(Scene);
                dataGridView1.DataSource = Scene;

            }
        }
        //ingineri_de_sunet
        private void button8_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Ingineri_de_sunet", con);
                DataTable Ingineri_de_sunet = new DataTable();
                sqlDa.Fill(Ingineri_de_sunet);
                dataGridView1.DataSource = Ingineri_de_sunet;

            }
        }
        //echipament
        private void button9_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Echipament", con);
                DataTable Echipament = new DataTable();
                sqlDa.Fill(Echipament);
                dataGridView1.DataSource = Echipament;

            }
        }
        //manageri
        private void button6_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Manageri", con);
                DataTable Manageri = new DataTable();
                sqlDa.Fill(Manageri);
                dataGridView1.DataSource = Manageri;

            }
        }
        //canta_la
        private void button2_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Canta_la", con);
                DataTable Canta_la = new DataTable();
                sqlDa.Fill(Canta_la);
                dataGridView1.DataSource = Canta_la;

            }
        }
        //contine
        private void button10_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Contine", con);
                DataTable Contine = new DataTable();
                sqlDa.Fill(Contine);
                dataGridView1.DataSource = Contine;

            }
        }
        //sortare trupe dupa nume
        private void button15_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Trupe order by nume", con);
                DataTable Trupe = new DataTable();
                sqlDa.Fill(Trupe);
                dataGridView1.DataSource = Trupe;

            }
        }
        //sortare piese dupa titlu
        private void button11_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Piese order by titlu", con);
                DataTable Piese = new DataTable();
                sqlDa.Fill(Piese);
                dataGridView1.DataSource = Piese;

            }
        }
        //sortare artisti dupa nume
        private void button12_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Artisti order by nume", con);
                DataTable Artisti = new DataTable();
                sqlDa.Fill(Artisti);
                dataGridView1.DataSource = Artisti;

            }
        }
        //sortare instrumente dupa marca
        private void button14_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Instrumente order by marca", con);
                DataTable Instrumente = new DataTable();
                sqlDa.Fill(Instrumente);
                dataGridView1.DataSource = Instrumente;

            }
        }
        //sortare scene dupa nume
        private void button13_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Scene order by nume", con);
                DataTable Scene = new DataTable();
                sqlDa.Fill(Scene);
                dataGridView1.DataSource = Scene;

            }
        }
        //sortare ingineri dupa nume
        private void button20_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Ingineri_de_sunet order by nume", con);
                DataTable Ingineri = new DataTable();
                sqlDa.Fill(Ingineri);
                dataGridView1.DataSource = Ingineri;

            }
        }
        //sortare echipament dupa marca
        private void button19_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Echipament order by marca", con);
                DataTable Echipament = new DataTable();
                sqlDa.Fill(Echipament);
                dataGridView1.DataSource = Echipament;

            }
        }
        //sortare manageri dupa nume
        private void button18_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Manageri order by nume", con);
                DataTable Manageri = new DataTable();
                sqlDa.Fill(Manageri);
                dataGridView1.DataSource = Manageri;

            }
        }
        //sortare canta_la dupa id_artist
        private void button16_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from canta_la order by id_artist", con);
                DataTable canta_la = new DataTable();
                sqlDa.Fill(canta_la);
                dataGridView1.DataSource = canta_la;

            }
        }
        //sortare contine dupa id_artist
        private void button17_Click(object sender, EventArgs e)
        {
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            using (con)
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from contine order by id_artist", con);
                DataTable contine = new DataTable();
                sqlDa.Fill(contine);
                dataGridView1.DataSource = contine;

            }
        }
    }
}
