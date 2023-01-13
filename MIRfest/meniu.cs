namespace MIRfest
{
    public partial class meniu : Form
    {
        public meniu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            continut_tabele f2 = new continut_tabele();
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modificat_tabele f3 = new modificat_tabele();
            f3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            group_si_having f5 = new group_si_having();
            f5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();  
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vizualizari f1 = new vizualizari();
            f1.Show();
        }
    }
}