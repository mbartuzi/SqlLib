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

namespace sql
{
    public partial class Form2 : Form
    {
        Connection baza = new Connection();
                
        public Form2()
        {
            InitializeComponent();              
            string[] id_gat = baza.getSingleColumn("gatunki", "nazwa");

            for (int i = 0; i < id_gat.Length; i++) {
                comboBox1.Items.Add(id_gat[i]);
            }

        }

        private void button1_Click(object sender, EventArgs e, SqlConnection polaczenie)
        {
           // SqlCommand zapytanie = new SqlCommand("SELECT * from ksiazki", polaczenie);
           // MessageBox.Show("");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
           // SqlCommand zapytanie = new SqlCommand("SELECT * from ksiazki", laczenie);
           // comboBox1.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex) { 
                case 0:
                   // wyslij("ksiazki");
                    break;
            
            }
        }

        
    }
}
