using System.Drawing;
namespace _2SIO_FSI_Adminstration.WinForm
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lLogin = new System.Windows.Forms.Label();
            this.lMDP = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbMdp = new System.Windows.Forms.TextBox();
            this.bConnexion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 2);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(154, 142);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(156)))), ((int)(((byte)(84)))));
            this.lLogin.Location = new System.Drawing.Point(176, 24);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(72, 26);
            this.lLogin.TabIndex = 1;
            this.lLogin.Text = "Login";
            // 
            // lMDP
            // 
            this.lMDP.AutoSize = true;
            this.lMDP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(156)))), ((int)(((byte)(84)))));
            this.lMDP.Location = new System.Drawing.Point(175, 61);
            this.lMDP.Name = "lMDP";
            this.lMDP.Size = new System.Drawing.Size(145, 26);
            this.lMDP.TabIndex = 2;
            this.lMDP.Text = "Mot de passe";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(326, 16);
            this.tbLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(184, 34);
            this.tbLogin.TabIndex = 3;
            // 
            // tbMdp
            // 
            this.tbMdp.Location = new System.Drawing.Point(326, 53);
            this.tbMdp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMdp.Name = "tbMdp";
            this.tbMdp.PasswordChar = '*';
            this.tbMdp.Size = new System.Drawing.Size(184, 34);
            this.tbMdp.TabIndex = 4;
            // 
            // bConnexion
            // 
            this.bConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(156)))), ((int)(((byte)(84)))));
            this.bConnexion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.bConnexion.Location = new System.Drawing.Point(276, 102);
            this.bConnexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bConnexion.Name = "bConnexion";
            this.bConnexion.Size = new System.Drawing.Size(147, 30);
            this.bConnexion.TabIndex = 5;
            this.bConnexion.Text = "Connexion";
            this.bConnexion.UseVisualStyleBackColor = false;
            this.bConnexion.Click += new System.EventHandler(this.bConnexion_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 142);
            this.Controls.Add(this.bConnexion);
            this.Controls.Add(this.tbMdp);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lMDP);
            this.Controls.Add(this.lLogin);
            this.Controls.Add(this.pbLogo);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Connexion";
            this.Text = "CONNEXION";
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lMDP;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbMdp;
        private System.Windows.Forms.Button bConnexion;
 
    }
}