namespace WinForms_Jalon_2
{
    partial class Authentification
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblAuthentification = new TableLayoutPanel();
            tblConnexion = new TableLayoutPanel();
            lblUtilisateur = new Label();
            lblMoDePasse = new Label();
            tbLogin = new TextBox();
            tbPassword = new TextBox();
            btnConnexion = new Button();
            tblAuthentification.SuspendLayout();
            tblConnexion.SuspendLayout();
            SuspendLayout();
            // 
            // tblAuthentification
            // 
            tblAuthentification.ColumnCount = 3;
            tblAuthentification.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblAuthentification.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblAuthentification.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblAuthentification.Controls.Add(tblConnexion, 1, 2);
            tblAuthentification.Dock = DockStyle.Fill;
            tblAuthentification.Location = new Point(0, 0);
            tblAuthentification.Name = "tblAuthentification";
            tblAuthentification.RowCount = 4;
            tblAuthentification.RowStyles.Add(new RowStyle(SizeType.Percent, 10.416667F));
            tblAuthentification.RowStyles.Add(new RowStyle(SizeType.Percent, 20.833334F));
            tblAuthentification.RowStyles.Add(new RowStyle(SizeType.Percent, 34.375F));
            tblAuthentification.RowStyles.Add(new RowStyle(SizeType.Percent, 34.375F));
            tblAuthentification.Size = new Size(1034, 541);
            tblAuthentification.TabIndex = 0;
            // 
            // tblConnexion
            // 
            tblConnexion.ColumnCount = 1;
            tblConnexion.ColumnStyles.Add(new ColumnStyle());
            tblConnexion.Controls.Add(lblUtilisateur, 0, 0);
            tblConnexion.Controls.Add(lblMoDePasse, 0, 2);
            tblConnexion.Controls.Add(tbLogin, 0, 1);
            tblConnexion.Controls.Add(tbPassword, 0, 3);
            tblConnexion.Controls.Add(btnConnexion, 0, 4);
            tblConnexion.Dock = DockStyle.Fill;
            tblConnexion.Location = new Point(347, 171);
            tblConnexion.Name = "tblConnexion";
            tblConnexion.RowCount = 5;
            tblConnexion.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblConnexion.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblConnexion.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblConnexion.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblConnexion.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblConnexion.Size = new Size(338, 179);
            tblConnexion.TabIndex = 0;
            // 
            // lblUtilisateur
            // 
            lblUtilisateur.Anchor = AnchorStyles.Left;
            lblUtilisateur.AutoSize = true;
            lblUtilisateur.Location = new Point(3, 7);
            lblUtilisateur.Name = "lblUtilisateur";
            lblUtilisateur.Size = new Size(76, 20);
            lblUtilisateur.TabIndex = 0;
            lblUtilisateur.Text = "Utilisateur";
            // 
            // lblMoDePasse
            // 
            lblMoDePasse.Anchor = AnchorStyles.Left;
            lblMoDePasse.AutoSize = true;
            lblMoDePasse.Location = new Point(3, 77);
            lblMoDePasse.Name = "lblMoDePasse";
            lblMoDePasse.Size = new Size(98, 20);
            lblMoDePasse.TabIndex = 1;
            lblMoDePasse.Text = "Mot de passe";
            // 
            // tbLogin
            // 
            tbLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbLogin.Location = new Point(3, 39);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(332, 27);
            tbLogin.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbPassword.Location = new Point(3, 109);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(332, 27);
            tbPassword.TabIndex = 3;
            // 
            // btnConnexion
            // 
            btnConnexion.Location = new Point(3, 143);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(94, 29);
            btnConnexion.TabIndex = 4;
            btnConnexion.Text = "Connexion";
            btnConnexion.UseVisualStyleBackColor = true;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // Authentification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 541);
            Controls.Add(tblAuthentification);
            Name = "Authentification";
            Text = "Authentification";
            tblAuthentification.ResumeLayout(false);
            tblConnexion.ResumeLayout(false);
            tblConnexion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblAuthentification;
        private TableLayoutPanel tblConnexion;
        private Label lblUtilisateur;
        private Label lblMoDePasse;
        private TextBox tbLogin;
        private TextBox tbPassword;
        private Button btnConnexion;
    }
}
