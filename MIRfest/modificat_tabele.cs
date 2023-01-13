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
    public partial class modificat_tabele : Form
    {
        public modificat_tabele()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        //sterge trupa
        private void button7_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if (input.Length < 1)
            {
                input = "-1";
            }
            string query = "delete from Trupe where id_trupa = " + input + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void modificat_tabele_Load(object sender, EventArgs e)
        {

        }
        //sterge piesa
        private void button3_Click_1(object sender, EventArgs e)
        {
            string input = textBox4.Text;
            if (input.Length < 1)
            {
                input = "-1";
            }
            string query = "delete from Piese where id_piesa = " + input + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //sterge artist
        private void button5_Click_1(object sender, EventArgs e)
        {
            string input = textBox6.Text;
            if (input.Length < 1)
            {
                input = "-1";
            }
            string query = "delete from Artisti where id_artist = " + input + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //sterge instrument
        private void button15_Click(object sender, EventArgs e)
        {
            string input = textBox8.Text;
            if (input.Length < 1)
            {
                input = "-1";
            }
            string query = "delete from Instrumente where cod_produs = " + input + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //sterge scena
        private void button13_Click(object sender, EventArgs e)
        {
            string input = textBox10.Text;
            if (input.Length < 1)
            {
                input = "-1";
            }
            string query = "delete from Scene where index_scena = " + input + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //sterge inginer
        private void button20_Click(object sender, EventArgs e)
        {
            string input = textBox20.Text;
            if (input.Length < 1)
            {
                input = "-1";
            }
            string query = "delete from Ingineri_de_sunet where id_inginer = " + input + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //sterge echipament
        private void button18_Click(object sender, EventArgs e)
        {
            string input = textBox18.Text;
            if (input.Length < 1)
            {
                input = "-1";
            }
            string query = "delete from echipament where cod_produs = " + input + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //sterge manager
        private void button16_Click(object sender, EventArgs e)
        {
            string input = textBox16.Text;
            if (input.Length < 1)
            {
                input = "-1";
            }
            string query = "delete from Manageri where id_manager = " + input + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //contine
        private void button9_Click(object sender, EventArgs e)
        {
            string input1 = textBox14.Text;
            string input2 = textBox24.Text;
            if (input1.Length < 1 || input2.Length < 1)
            {
                input1 = "-1";
                input2 = "-1";
            }
            string query = "delete from contine where id_trupa = " + input1 + " and id_artist = " + input2 + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();

        }
        //canta la
        private void button6_Click(object sender, EventArgs e)
        {
            string input1 = textBox12.Text;
            string input2 = textBox22.Text;
            if (input1.Length < 1 || input2.Length < 1)
            {
                input1 = "-1";
                input2 = "-1";
            }
            string query = "delete from canta_la where id_artist = " + input1 + " and cod_produs = " + input2 + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }



        //modifica numele trupei
        private void button11_Click(object sender, EventArgs e)
        {
            string id = textBox2.Text;
            string nume = textBox25.Text;
            if (id.Length < 1 || nume.Length < 1)
            {
                id = "-1";
                nume = "-1";
            }
            string query = "update trupe set nume = '" + nume + "' where id_trupa = " + id + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //modifica numele piesei
        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox3.Text;
            string nume = textBox29.Text;
            if (id.Length < 1 || nume.Length < 1)
            {
                id = "-1";
                nume = "-1";
            }
            string query = "update piese set titlu = '" + nume + "' where id_piesa = " + id + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //modifica numele artistului 5 28
        private void button4_Click(object sender, EventArgs e)
        {
            string id = textBox5.Text;
            string nume = textBox28.Text;
            if (id.Length < 1 || nume.Length < 1)
            {
                id = "-1";
                nume = "-1";
            }
            string query = "update artisti set nume = '" + nume + "' where id_artist = " + id + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //modifica marca instrumentului 7  27
        private void button14_Click(object sender, EventArgs e)
        {
            string id = textBox7.Text;
            string nume = textBox27.Text;
            if (id.Length < 1 || nume.Length < 1)
            {
                id = "-1";
                nume = "-1";
            }
            string query = "update instrumente set marca = '" + nume + "' where cod_produs = " + id + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //modifica numele scenei 9 26
        private void button12_Click(object sender, EventArgs e)
        {
            string id = textBox9.Text;
            string nume = textBox26.Text;
            if (id.Length < 1 || nume.Length < 1)
            {
                id = "-1";
                nume = "-1";
            }
            string query = "update Scene set nume = '" + nume + "' where index_scena = " + id + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //modifica numele inginerului 19 34
        private void button19_Click(object sender, EventArgs e)
        {
            string id = textBox19.Text;
            string nume = textBox34.Text;
            if (id.Length < 1 || nume.Length < 1)
            {
                id = "-1";
                nume = "-1";
            }
            string query = "update ingineri_de_sunet set nume = '" + nume + "' where id_inginer = " + id + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //modifica marca echipamentului 17 30
        private void button17_Click(object sender, EventArgs e)
        {
            string id = textBox17.Text;
            string nume = textBox30.Text;
            if (id.Length < 1 || nume.Length < 1)
            {
                id = "-1";
                nume = "-1";
            }
            string query = "update echipament set marca = '" + nume + "' where cod_produs = " + id + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //modifica numele managerului 15 31
        private void button10_Click(object sender, EventArgs e)
        {
            string id = textBox15.Text;
            string nume = textBox31.Text;
            if (id.Length < 1 || nume.Length < 1)
            {
                id = "-1";
                nume = "-1";
            }
            string query = "update manageri set nume = '" + nume + "' where id_manager = " + id + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //modifica id_artist din contine asociat cu id_trupa
        private void button8_Click(object sender, EventArgs e)
        {
            string id_trupa = textBox13.Text;
            string id_artist = textBox23.Text;
            string new_id_artist = textBox32.Text;
            if (id_artist.Length < 1 || id_trupa.Length < 1 || new_id_artist.Length < 1)
            {
                id_artist = "-1";
                id_trupa = "-1";
                new_id_artist = "-1";
            }
            string query = "update contine set id_artist = " + new_id_artist +" where id_trupa = " + id_trupa + " and id_artist  = " + id_artist + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        //modifica cod_produs din canta_la asociat cu id_artist
        private void button2_Click(object sender, EventArgs e)
        {
            string cod_produs = textBox21.Text;
            string id_artist = textBox11.Text;
            string new_cod_produs = textBox33.Text;
            if (id_artist.Length < 1 || cod_produs.Length < 1 || new_cod_produs.Length < 1)
            {
                id_artist = "-1";
                cod_produs = "-1";
                new_cod_produs = "-1";
            }
            string query = "update canta_la set cod_produs = " + new_cod_produs + " where id_artist = " + id_artist + " and cod_produs  = " + cod_produs + ";";
            string connstring = "Data Source = WIN10; Initial Catalog = master; Integrated Security = true";
            SqlConnection con = new SqlConnection(connstring);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
