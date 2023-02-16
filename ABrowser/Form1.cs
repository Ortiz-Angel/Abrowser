using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABrowser
{
    public partial class Form1 : Form
    {

        List<string> Favoritos = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.msn.com/es-xl");
            txtURL.Text = "www.msn.com/es-xl";
        } 

        private void btnIr_Click(object sender, EventArgs e)
        {
            
        }

        private void btnWard_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnIr_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtURL.Text);
        }

        private void btnFav_Click(object sender, EventArgs e)
        {
            Favoritos.Add(webBrowser1.Url.ToString());
            actualizarFav();
        }

        private void actualizarFav()
        {
            cmbFav.Items.Clear();
            foreach (string direccion in Favoritos)
            {
                cmbFav.Items.Add(direccion);
            }        
        }

        private void cmbFav_SelectedIndexChanged(object sender, EventArgs e)
        {
            webBrowser1.Navigate(cmbFav.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
            txtURL.Clear();
        }
    }
}
