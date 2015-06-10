using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Click(object sender, EventArgs e)
        {
            
        }
        
        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {           
            this.Close();
        }

        private void wszystkie_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void link_MouseClick(object sender, MouseEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mbartuzi/");
            this.Close();
        }
    }
}
