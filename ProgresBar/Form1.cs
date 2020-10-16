using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgresBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            prgBar.Value = 100;
            if (prgBar.Value>=100)
            {
                MessageBox.Show("Download Complete");
                Application.Exit();
                
                
            }
           else if(prgBar.Value <= 0)
            {
                MessageBox.Show("Check your İnternet Connection");
                Application.Exit();
            }
        }   
    }
}
