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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
           
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Dodawanie = new Form2();
            Dodawanie.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 about = new Form3();
            about.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testowaDataSet.gatunki' table. You can move, or remove it, as needed.
            this.gatunkiTableAdapter.Fill(this.testowaDataSet.gatunki);
            // TODO: This line of code loads data into the 'testowaDataSet.wypozyczenia' table. You can move, or remove it, as needed.
            this.wypozyczeniaTableAdapter.Fill(this.testowaDataSet.wypozyczenia);
            // TODO: This line of code loads data into the 'testowaDataSet.ksiazki' table. You can move, or remove it, as needed.
            this.ksiazkiTableAdapter.Fill(this.testowaDataSet.ksiazki);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void tabControl1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dataGridView5_KeyPress(object sender, KeyPressEventArgs e)
        {
                 
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void dataGridView5_KeyDown(object sender, KeyEventArgs e)
        {
          
        }


    }
}
