using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rozgrzewka23042023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int podanaLiczba = int.Parse(txtLiczba.Text);
            int wynik = 0;
            int i = 0;
            while (i < podanaLiczba)
            {
                wynik += i;
                i++;
            }
            MessageBox.Show($"Suma liczb wynosi {wynik}");
        }
    }
}
