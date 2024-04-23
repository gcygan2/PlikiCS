using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CdKeys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int dlugoscKlucza = int.Parse(txtDlugosc.Text);
            int i = 0;
            string klucz = "";
            Random los = new Random();
            
            do {
                int znak = los.Next(0, 10);
                klucz += znak.ToString();
                i++;
            } while (i < dlugoscKlucza) ;

            txtKlucz.Text = klucz;
        }
    }
}
