using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFApp1
{
    public partial class Form4 : Form
    {
        private float volume = 200;
        private float chiffre_affaire = 0;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtVolume.Text = volume.ToString();
            txtChiffreAffaire.Text = chiffre_affaire.ToString();
        }

        private void btnValiderLitre_Click(object sender, EventArgs e)
        {
            this.volume = this.volume - float.Parse(txtLitre.Text);
            txtVolume.Text = volume.ToString();
            this.chiffre_affaire = this.chiffre_affaire + 310 * float.Parse(txtLitre.Text);
            txtChiffreAffaire.Text = chiffre_affaire.ToString();
            listBox1.Items.Add("Achat de " + txtLitre.Text + " litres d'essence");
        }

        private void btnValiderMonetaire_Click(object sender, EventArgs e)
        {
            this.chiffre_affaire = this.chiffre_affaire + float.Parse(txtMonetaire.Text);
            txtChiffreAffaire.Text = this.chiffre_affaire.ToString();
            this.volume = this.volume - float.Parse(txtMonetaire.Text) / 310;
            txtVolume.Text = this.volume.ToString();
            listBox1.Items.Add("Achat de " + txtMonetaire.Text + " FD d'essence");
        }

        private void btnAchat_Click(object sender, EventArgs e)
        {
            if (rbLitre.Checked == true)
            {
                if (float.Parse(txtVolume.Text) >= float.Parse(txtLitreMonetaire.Text))
                {
                    this.volume = this.volume - float.Parse(txtLitreMonetaire.Text);
                    txtVolume.Text = volume.ToString();
                    this.chiffre_affaire = this.chiffre_affaire + 310 * float.Parse(txtLitreMonetaire.Text);
                    txtChiffreAffaire.Text = chiffre_affaire.ToString();
                    listBox1.Items.Add("Achat de " + txtLitreMonetaire.Text + " litres d'essence");
                }
                else
                {
                    MessageBox.Show("Attention le volume demandé n'est pas disponible !");
                }
            }
            else
            {
                float demande = float.Parse(txtLitreMonetaire.Text) / 310;
                if (float.Parse(txtVolume.Text) >= demande)
                {
                    this.chiffre_affaire = this.chiffre_affaire + float.Parse(txtLitreMonetaire.Text);
                    txtChiffreAffaire.Text = this.chiffre_affaire.ToString();
                    this.volume = this.volume - float.Parse(txtLitreMonetaire.Text) / 310;
                    txtVolume.Text = this.volume.ToString();
                    listBox1.Items.Add("Achat de " + txtLitreMonetaire.Text + " FD d'essence");
                }
                else
                {
                    MessageBox.Show("Attention le volume demandé n'est pas disponible !");
                }
            }
        }
    }
}
