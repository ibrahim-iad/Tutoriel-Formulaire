using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abstraite_Interface.modele;

namespace WFApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            int longueur = int.Parse(txtLongueur.Text);
            int largeur = int.Parse(txtLargeur.Text);
            Abstraite_Interface.modele.Rectangle r = new Abstraite_Interface.modele.Rectangle(longueur, largeur);
            //int perimetre = 2 * (longueur + largeur);
            //int surface = longueur * largeur;
            txtPerimetre.Text = r.Perimetre().ToString();
            txtSurface.Text = r.Surface().ToString();
        }

        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.ShowDialog();
        }
    }
}
