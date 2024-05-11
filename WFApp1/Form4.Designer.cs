
namespace WFApp1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.txtChiffreAffaire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLitre = new System.Windows.Forms.TextBox();
            this.txtMonetaire = new System.Windows.Forms.TextBox();
            this.btnValiderLitre = new System.Windows.Forms.Button();
            this.btnValiderMonetaire = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rbLitre = new System.Windows.Forms.RadioButton();
            this.rbMonetaire = new System.Windows.Forms.RadioButton();
            this.txtLitreMonetaire = new System.Windows.Forms.TextBox();
            this.btnAchat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Volume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chiffre d\'affaire:";
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(101, 6);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(133, 20);
            this.txtVolume.TabIndex = 2;
            // 
            // txtChiffreAffaire
            // 
            this.txtChiffreAffaire.Location = new System.Drawing.Point(102, 43);
            this.txtChiffreAffaire.Name = "txtChiffreAffaire";
            this.txtChiffreAffaire.Size = new System.Drawing.Size(133, 20);
            this.txtChiffreAffaire.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Achat en ltre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Achat en monétaire:";
            // 
            // txtLitre
            // 
            this.txtLitre.Location = new System.Drawing.Point(134, 112);
            this.txtLitre.Name = "txtLitre";
            this.txtLitre.Size = new System.Drawing.Size(100, 20);
            this.txtLitre.TabIndex = 6;
            // 
            // txtMonetaire
            // 
            this.txtMonetaire.Location = new System.Drawing.Point(134, 145);
            this.txtMonetaire.Name = "txtMonetaire";
            this.txtMonetaire.Size = new System.Drawing.Size(100, 20);
            this.txtMonetaire.TabIndex = 7;
            // 
            // btnValiderLitre
            // 
            this.btnValiderLitre.Location = new System.Drawing.Point(249, 109);
            this.btnValiderLitre.Name = "btnValiderLitre";
            this.btnValiderLitre.Size = new System.Drawing.Size(75, 23);
            this.btnValiderLitre.TabIndex = 8;
            this.btnValiderLitre.Text = "VALIDER";
            this.btnValiderLitre.UseVisualStyleBackColor = true;
            this.btnValiderLitre.Click += new System.EventHandler(this.btnValiderLitre_Click);
            // 
            // btnValiderMonetaire
            // 
            this.btnValiderMonetaire.Location = new System.Drawing.Point(249, 142);
            this.btnValiderMonetaire.Name = "btnValiderMonetaire";
            this.btnValiderMonetaire.Size = new System.Drawing.Size(75, 23);
            this.btnValiderMonetaire.TabIndex = 9;
            this.btnValiderMonetaire.Text = "VALIDER";
            this.btnValiderMonetaire.UseVisualStyleBackColor = true;
            this.btnValiderMonetaire.Click += new System.EventHandler(this.btnValiderMonetaire_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(364, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(381, 277);
            this.listBox1.TabIndex = 10;
            // 
            // rbLitre
            // 
            this.rbLitre.AutoSize = true;
            this.rbLitre.Checked = true;
            this.rbLitre.Location = new System.Drawing.Point(16, 218);
            this.rbLitre.Name = "rbLitre";
            this.rbLitre.Size = new System.Drawing.Size(45, 17);
            this.rbLitre.TabIndex = 11;
            this.rbLitre.TabStop = true;
            this.rbLitre.Text = "Litre";
            this.rbLitre.UseVisualStyleBackColor = true;
            // 
            // rbMonetaire
            // 
            this.rbMonetaire.AutoSize = true;
            this.rbMonetaire.Location = new System.Drawing.Point(134, 218);
            this.rbMonetaire.Name = "rbMonetaire";
            this.rbMonetaire.Size = new System.Drawing.Size(72, 17);
            this.rbMonetaire.TabIndex = 12;
            this.rbMonetaire.Text = "Monétaire";
            this.rbMonetaire.UseVisualStyleBackColor = true;
            // 
            // txtLitreMonetaire
            // 
            this.txtLitreMonetaire.Location = new System.Drawing.Point(19, 252);
            this.txtLitreMonetaire.Name = "txtLitreMonetaire";
            this.txtLitreMonetaire.Size = new System.Drawing.Size(187, 20);
            this.txtLitreMonetaire.TabIndex = 13;
            // 
            // btnAchat
            // 
            this.btnAchat.Location = new System.Drawing.Point(249, 248);
            this.btnAchat.Name = "btnAchat";
            this.btnAchat.Size = new System.Drawing.Size(75, 23);
            this.btnAchat.TabIndex = 14;
            this.btnAchat.Text = "Valider";
            this.btnAchat.UseVisualStyleBackColor = true;
            this.btnAchat.Click += new System.EventHandler(this.btnAchat_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 421);
            this.Controls.Add(this.btnAchat);
            this.Controls.Add(this.txtLitreMonetaire);
            this.Controls.Add(this.rbMonetaire);
            this.Controls.Add(this.rbLitre);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnValiderMonetaire);
            this.Controls.Add(this.btnValiderLitre);
            this.Controls.Add(this.txtMonetaire);
            this.Controls.Add(this.txtLitre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtChiffreAffaire);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.TextBox txtChiffreAffaire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLitre;
        private System.Windows.Forms.TextBox txtMonetaire;
        private System.Windows.Forms.Button btnValiderLitre;
        private System.Windows.Forms.Button btnValiderMonetaire;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rbLitre;
        private System.Windows.Forms.RadioButton rbMonetaire;
        private System.Windows.Forms.TextBox txtLitreMonetaire;
        private System.Windows.Forms.Button btnAchat;
    }
}