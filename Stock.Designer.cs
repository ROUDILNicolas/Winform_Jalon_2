namespace WinForms_Jalon_2
{
    partial class Stock
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
            tlpStock = new TableLayoutPanel();
            tpStock = new TabControl();
            tbStock = new TabPage();
            tlpTcStock = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnCRUD = new Button();
            btnQte = new Button();
            txtbQte = new TextBox();
            lblQte = new Label();
            tlpFormulaire = new TableLayoutPanel();
            tlpFomulaire2 = new TableLayoutPanel();
            txtbDescription = new TextBox();
            flpFormulaire2 = new FlowLayoutPanel();
            lblcategorie = new Label();
            comboBox1 = new ComboBox();
            lblDescription = new Label();
            tlpFormulaireG = new TableLayoutPanel();
            flpFormulaireHG = new FlowLayoutPanel();
            lblNom = new Label();
            txtbNom = new TextBox();
            lblQuantite = new Label();
            txtbQuantite = new TextBox();
            lblPA = new Label();
            txtbPA = new TextBox();
            lblPV = new Label();
            txtbPV = new TextBox();
            flpFormulaireBG = new FlowLayoutPanel();
            btnAjouterProduit = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            dgvStock = new DataGridView();
            tbListePrep = new TabPage();
            tlpListePrep = new TableLayoutPanel();
            dgvListePrep = new DataGridView();
            btnPreparer = new Button();
            tpStatut = new TabPage();
            tlpPrep = new TableLayoutPanel();
            dgvPrep = new DataGridView();
            btnAnnulerPrep = new Button();
            btnValiderPrep = new Button();
            tpCmdStatut = new TabPage();
            dgvCmdStatut = new DataGridView();
            lblStock = new Label();
            tlpStock.SuspendLayout();
            tpStock.SuspendLayout();
            tbStock.SuspendLayout();
            tlpTcStock.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tlpFormulaire.SuspendLayout();
            tlpFomulaire2.SuspendLayout();
            flpFormulaire2.SuspendLayout();
            tlpFormulaireG.SuspendLayout();
            flpFormulaireHG.SuspendLayout();
            flpFormulaireBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            tbListePrep.SuspendLayout();
            tlpListePrep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListePrep).BeginInit();
            tpStatut.SuspendLayout();
            tlpPrep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrep).BeginInit();
            tpCmdStatut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCmdStatut).BeginInit();
            SuspendLayout();
            // 
            // tlpStock
            // 
            tlpStock.BackColor = SystemColors.Control;
            tlpStock.ColumnCount = 3;
            tlpStock.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.617811F));
            tlpStock.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.76438F));
            tlpStock.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.617809F));
            tlpStock.Controls.Add(tpStock, 1, 1);
            tlpStock.Controls.Add(lblStock, 1, 0);
            tlpStock.Dock = DockStyle.Fill;
            tlpStock.Location = new Point(0, 0);
            tlpStock.Name = "tlpStock";
            tlpStock.RowCount = 3;
            tlpStock.RowStyles.Add(new RowStyle());
            tlpStock.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpStock.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpStock.Size = new Size(1455, 744);
            tlpStock.TabIndex = 0;
            // 
            // tpStock
            // 
            tpStock.Controls.Add(tbStock);
            tpStock.Controls.Add(tbListePrep);
            tpStock.Controls.Add(tpStatut);
            tpStock.Controls.Add(tpCmdStatut);
            tpStock.Dock = DockStyle.Fill;
            tpStock.Location = new Point(55, 49);
            tpStock.Name = "tpStock";
            tpStock.SelectedIndex = 0;
            tpStock.Size = new Size(1343, 642);
            tpStock.TabIndex = 0;
            // 
            // tbStock
            // 
            tbStock.Controls.Add(tlpTcStock);
            tbStock.Location = new Point(4, 29);
            tbStock.Name = "tbStock";
            tbStock.Padding = new Padding(3);
            tbStock.Size = new Size(1335, 609);
            tbStock.TabIndex = 0;
            tbStock.Text = "Stock";
            tbStock.UseVisualStyleBackColor = true;
            // 
            // tlpTcStock
            // 
            tlpTcStock.ColumnCount = 1;
            tlpTcStock.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTcStock.Controls.Add(tableLayoutPanel2, 0, 0);
            tlpTcStock.Controls.Add(tlpFormulaire, 0, 2);
            tlpTcStock.Controls.Add(dgvStock, 0, 1);
            tlpTcStock.Dock = DockStyle.Fill;
            tlpTcStock.Location = new Point(3, 3);
            tlpTcStock.Name = "tlpTcStock";
            tlpTcStock.RowCount = 3;
            tlpTcStock.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tlpTcStock.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpTcStock.RowStyles.Add(new RowStyle());
            tlpTcStock.Size = new Size(1329, 603);
            tlpTcStock.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel2.Controls.Add(btnCRUD, 0, 1);
            tableLayoutPanel2.Controls.Add(btnQte, 3, 1);
            tableLayoutPanel2.Controls.Add(txtbQte, 2, 1);
            tableLayoutPanel2.Controls.Add(lblQte, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1323, 54);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // btnCRUD
            // 
            btnCRUD.Location = new Point(3, 23);
            btnCRUD.Name = "btnCRUD";
            btnCRUD.Size = new Size(94, 29);
            btnCRUD.TabIndex = 3;
            btnCRUD.Text = "Formulaire";
            btnCRUD.UseVisualStyleBackColor = true;
            btnCRUD.Click += btnCRUD_Click;
            // 
            // btnQte
            // 
            btnQte.Location = new Point(1260, 23);
            btnQte.Name = "btnQte";
            btnQte.Size = new Size(60, 32);
            btnQte.TabIndex = 0;
            btnQte.Text = "Entrer";
            btnQte.UseVisualStyleBackColor = true;
            // 
            // txtbQte
            // 
            txtbQte.Location = new Point(1166, 23);
            txtbQte.Name = "txtbQte";
            txtbQte.Size = new Size(88, 27);
            txtbQte.TabIndex = 1;
            // 
            // lblQte
            // 
            lblQte.AutoSize = true;
            lblQte.Location = new Point(1166, 0);
            lblQte.Name = "lblQte";
            lblQte.Size = new Size(33, 20);
            lblQte.TabIndex = 2;
            lblQte.Text = "Qte";
            // 
            // tlpFormulaire
            // 
            tlpFormulaire.ColumnCount = 2;
            tlpFormulaire.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFormulaire.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFormulaire.Controls.Add(tlpFomulaire2, 1, 0);
            tlpFormulaire.Controls.Add(tlpFormulaireG, 0, 0);
            tlpFormulaire.Dock = DockStyle.Fill;
            tlpFormulaire.Location = new Point(3, 276);
            tlpFormulaire.Name = "tlpFormulaire";
            tlpFormulaire.RowCount = 1;
            tlpFormulaire.RowStyles.Add(new RowStyle());
            tlpFormulaire.Size = new Size(1323, 324);
            tlpFormulaire.TabIndex = 3;
            // 
            // tlpFomulaire2
            // 
            tlpFomulaire2.ColumnCount = 1;
            tlpFomulaire2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFomulaire2.Controls.Add(txtbDescription, 0, 1);
            tlpFomulaire2.Controls.Add(flpFormulaire2, 0, 0);
            tlpFomulaire2.Dock = DockStyle.Fill;
            tlpFomulaire2.Location = new Point(664, 3);
            tlpFomulaire2.Name = "tlpFomulaire2";
            tlpFomulaire2.RowCount = 2;
            tlpFomulaire2.RowStyles.Add(new RowStyle());
            tlpFomulaire2.RowStyles.Add(new RowStyle());
            tlpFomulaire2.Size = new Size(656, 318);
            tlpFomulaire2.TabIndex = 1;
            // 
            // txtbDescription
            // 
            txtbDescription.Dock = DockStyle.Fill;
            txtbDescription.Location = new Point(3, 83);
            txtbDescription.Multiline = true;
            txtbDescription.Name = "txtbDescription";
            txtbDescription.ScrollBars = ScrollBars.Vertical;
            txtbDescription.Size = new Size(650, 232);
            txtbDescription.TabIndex = 5;
            // 
            // flpFormulaire2
            // 
            flpFormulaire2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpFormulaire2.AutoSize = true;
            flpFormulaire2.Controls.Add(lblcategorie);
            flpFormulaire2.Controls.Add(comboBox1);
            flpFormulaire2.Controls.Add(lblDescription);
            flpFormulaire2.FlowDirection = FlowDirection.TopDown;
            flpFormulaire2.Location = new Point(3, 3);
            flpFormulaire2.Name = "flpFormulaire2";
            flpFormulaire2.Size = new Size(650, 74);
            flpFormulaire2.TabIndex = 2;
            // 
            // lblcategorie
            // 
            lblcategorie.AutoSize = true;
            lblcategorie.Location = new Point(3, 0);
            lblcategorie.Name = "lblcategorie";
            lblcategorie.Size = new Size(74, 20);
            lblcategorie.TabIndex = 1;
            lblcategorie.Text = "Catégorie";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 23);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 28);
            comboBox1.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(3, 54);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "Description";
            // 
            // tlpFormulaireG
            // 
            tlpFormulaireG.ColumnCount = 1;
            tlpFormulaireG.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFormulaireG.Controls.Add(flpFormulaireHG, 0, 0);
            tlpFormulaireG.Controls.Add(flpFormulaireBG, 0, 1);
            tlpFormulaireG.Dock = DockStyle.Fill;
            tlpFormulaireG.Location = new Point(3, 3);
            tlpFormulaireG.Name = "tlpFormulaireG";
            tlpFormulaireG.RowCount = 2;
            tlpFormulaireG.RowStyles.Add(new RowStyle());
            tlpFormulaireG.RowStyles.Add(new RowStyle());
            tlpFormulaireG.Size = new Size(655, 318);
            tlpFormulaireG.TabIndex = 2;
            // 
            // flpFormulaireHG
            // 
            flpFormulaireHG.AutoSize = true;
            flpFormulaireHG.Controls.Add(lblNom);
            flpFormulaireHG.Controls.Add(txtbNom);
            flpFormulaireHG.Controls.Add(lblQuantite);
            flpFormulaireHG.Controls.Add(txtbQuantite);
            flpFormulaireHG.Controls.Add(lblPA);
            flpFormulaireHG.Controls.Add(txtbPA);
            flpFormulaireHG.Controls.Add(lblPV);
            flpFormulaireHG.Controls.Add(txtbPV);
            flpFormulaireHG.Dock = DockStyle.Fill;
            flpFormulaireHG.FlowDirection = FlowDirection.TopDown;
            flpFormulaireHG.Location = new Point(3, 3);
            flpFormulaireHG.Name = "flpFormulaireHG";
            flpFormulaireHG.Size = new Size(649, 212);
            flpFormulaireHG.TabIndex = 1;
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(3, 0);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(42, 20);
            lblNom.TabIndex = 0;
            lblNom.Text = "Nom";
            // 
            // txtbNom
            // 
            txtbNom.Anchor = AnchorStyles.None;
            txtbNom.Location = new Point(3, 23);
            txtbNom.Name = "txtbNom";
            txtbNom.Size = new Size(301, 27);
            txtbNom.TabIndex = 1;
            // 
            // lblQuantite
            // 
            lblQuantite.AutoSize = true;
            lblQuantite.Location = new Point(3, 53);
            lblQuantite.Name = "lblQuantite";
            lblQuantite.Size = new Size(66, 20);
            lblQuantite.TabIndex = 2;
            lblQuantite.Text = "Quantité";
            // 
            // txtbQuantite
            // 
            txtbQuantite.Location = new Point(3, 76);
            txtbQuantite.Name = "txtbQuantite";
            txtbQuantite.Size = new Size(301, 27);
            txtbQuantite.TabIndex = 3;
            // 
            // lblPA
            // 
            lblPA.AutoSize = true;
            lblPA.Location = new Point(3, 106);
            lblPA.Name = "lblPA";
            lblPA.Size = new Size(85, 20);
            lblPA.TabIndex = 4;
            lblPA.Text = "Prix d'achat";
            // 
            // txtbPA
            // 
            txtbPA.Location = new Point(3, 129);
            txtbPA.Name = "txtbPA";
            txtbPA.Size = new Size(301, 27);
            txtbPA.TabIndex = 5;
            // 
            // lblPV
            // 
            lblPV.AutoSize = true;
            lblPV.Location = new Point(3, 159);
            lblPV.Name = "lblPV";
            lblPV.Size = new Size(94, 20);
            lblPV.TabIndex = 6;
            lblPV.Text = "Prix de vente";
            // 
            // txtbPV
            // 
            txtbPV.Location = new Point(3, 182);
            txtbPV.Name = "txtbPV";
            txtbPV.Size = new Size(301, 27);
            txtbPV.TabIndex = 7;
            // 
            // flpFormulaireBG
            // 
            flpFormulaireBG.AutoSize = true;
            flpFormulaireBG.Controls.Add(btnAjouterProduit);
            flpFormulaireBG.Controls.Add(btnModifier);
            flpFormulaireBG.Controls.Add(btnSupprimer);
            flpFormulaireBG.Dock = DockStyle.Fill;
            flpFormulaireBG.Location = new Point(3, 221);
            flpFormulaireBG.Name = "flpFormulaireBG";
            flpFormulaireBG.Size = new Size(649, 97);
            flpFormulaireBG.TabIndex = 2;
            // 
            // btnAjouterProduit
            // 
            btnAjouterProduit.Location = new Point(3, 3);
            btnAjouterProduit.Name = "btnAjouterProduit";
            btnAjouterProduit.Size = new Size(94, 91);
            btnAjouterProduit.TabIndex = 0;
            btnAjouterProduit.Text = "Ajouter";
            btnAjouterProduit.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            btnModifier.Location = new Point(103, 3);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(94, 91);
            btnModifier.TabIndex = 1;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            btnSupprimer.Location = new Point(203, 3);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(101, 91);
            btnSupprimer.TabIndex = 2;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // dgvStock
            // 
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Dock = DockStyle.Fill;
            dgvStock.Location = new Point(3, 63);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 51;
            dgvStock.Size = new Size(1323, 207);
            dgvStock.TabIndex = 1;
            // 
            // tbListePrep
            // 
            tbListePrep.Controls.Add(tlpListePrep);
            tbListePrep.Location = new Point(4, 29);
            tbListePrep.Name = "tbListePrep";
            tbListePrep.Padding = new Padding(3);
            tbListePrep.Size = new Size(1335, 609);
            tbListePrep.TabIndex = 1;
            tbListePrep.Text = "Liste Préparation";
            tbListePrep.UseVisualStyleBackColor = true;
            // 
            // tlpListePrep
            // 
            tlpListePrep.ColumnCount = 2;
            tlpListePrep.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpListePrep.ColumnStyles.Add(new ColumnStyle());
            tlpListePrep.Controls.Add(dgvListePrep, 0, 0);
            tlpListePrep.Controls.Add(btnPreparer, 1, 1);
            tlpListePrep.Dock = DockStyle.Fill;
            tlpListePrep.Location = new Point(3, 3);
            tlpListePrep.Name = "tlpListePrep";
            tlpListePrep.RowCount = 2;
            tlpListePrep.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpListePrep.RowStyles.Add(new RowStyle());
            tlpListePrep.Size = new Size(1329, 603);
            tlpListePrep.TabIndex = 0;
            // 
            // dgvListePrep
            // 
            dgvListePrep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlpListePrep.SetColumnSpan(dgvListePrep, 2);
            dgvListePrep.Dock = DockStyle.Fill;
            dgvListePrep.Location = new Point(3, 3);
            dgvListePrep.Name = "dgvListePrep";
            dgvListePrep.RowHeadersWidth = 51;
            dgvListePrep.Size = new Size(1323, 500);
            dgvListePrep.TabIndex = 0;
            // 
            // btnPreparer
            // 
            btnPreparer.Location = new Point(1232, 509);
            btnPreparer.Name = "btnPreparer";
            btnPreparer.Size = new Size(94, 91);
            btnPreparer.TabIndex = 1;
            btnPreparer.Text = "Préparer";
            btnPreparer.UseVisualStyleBackColor = true;
            // 
            // tpStatut
            // 
            tpStatut.Controls.Add(tlpPrep);
            tpStatut.Location = new Point(4, 29);
            tpStatut.Name = "tpStatut";
            tpStatut.Padding = new Padding(3);
            tpStatut.Size = new Size(1335, 609);
            tpStatut.TabIndex = 2;
            tpStatut.Text = "Préparation";
            tpStatut.UseVisualStyleBackColor = true;
            // 
            // tlpPrep
            // 
            tlpPrep.ColumnCount = 3;
            tlpPrep.ColumnStyles.Add(new ColumnStyle());
            tlpPrep.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPrep.ColumnStyles.Add(new ColumnStyle());
            tlpPrep.Controls.Add(dgvPrep, 0, 0);
            tlpPrep.Controls.Add(btnAnnulerPrep, 0, 1);
            tlpPrep.Controls.Add(btnValiderPrep, 2, 1);
            tlpPrep.Dock = DockStyle.Fill;
            tlpPrep.Location = new Point(3, 3);
            tlpPrep.Name = "tlpPrep";
            tlpPrep.RowCount = 2;
            tlpPrep.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPrep.RowStyles.Add(new RowStyle());
            tlpPrep.Size = new Size(1329, 603);
            tlpPrep.TabIndex = 0;
            // 
            // dgvPrep
            // 
            dgvPrep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlpPrep.SetColumnSpan(dgvPrep, 3);
            dgvPrep.Dock = DockStyle.Fill;
            dgvPrep.Location = new Point(3, 3);
            dgvPrep.Name = "dgvPrep";
            dgvPrep.RowHeadersWidth = 51;
            dgvPrep.Size = new Size(1323, 500);
            dgvPrep.TabIndex = 0;
            // 
            // btnAnnulerPrep
            // 
            btnAnnulerPrep.Location = new Point(3, 509);
            btnAnnulerPrep.Name = "btnAnnulerPrep";
            btnAnnulerPrep.Size = new Size(94, 91);
            btnAnnulerPrep.TabIndex = 1;
            btnAnnulerPrep.Text = "Annuler";
            btnAnnulerPrep.UseVisualStyleBackColor = true;
            // 
            // btnValiderPrep
            // 
            btnValiderPrep.Location = new Point(1232, 509);
            btnValiderPrep.Name = "btnValiderPrep";
            btnValiderPrep.Size = new Size(94, 91);
            btnValiderPrep.TabIndex = 2;
            btnValiderPrep.Text = "Valider";
            btnValiderPrep.UseVisualStyleBackColor = true;
            // 
            // tpCmdStatut
            // 
            tpCmdStatut.Controls.Add(dgvCmdStatut);
            tpCmdStatut.Location = new Point(4, 29);
            tpCmdStatut.Name = "tpCmdStatut";
            tpCmdStatut.Padding = new Padding(3);
            tpCmdStatut.Size = new Size(1335, 609);
            tpCmdStatut.TabIndex = 3;
            tpCmdStatut.Text = "CmdStatut";
            tpCmdStatut.UseVisualStyleBackColor = true;
            // 
            // dgvCmdStatut
            // 
            dgvCmdStatut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCmdStatut.Dock = DockStyle.Fill;
            dgvCmdStatut.Location = new Point(3, 3);
            dgvCmdStatut.Name = "dgvCmdStatut";
            dgvCmdStatut.RowHeadersWidth = 51;
            dgvCmdStatut.Size = new Size(1329, 603);
            dgvCmdStatut.TabIndex = 0;
            // 
            // lblStock
            // 
            lblStock.Anchor = AnchorStyles.None;
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblStock.Location = new Point(599, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(255, 46);
            lblStock.TabIndex = 1;
            lblStock.Text = "Stock Entrepôt";
            lblStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1455, 744);
            Controls.Add(tlpStock);
            MinimumSize = new Size(736, 575);
            Name = "Stock";
            Text = "Stock";
            tlpStock.ResumeLayout(false);
            tlpStock.PerformLayout();
            tpStock.ResumeLayout(false);
            tbStock.ResumeLayout(false);
            tlpTcStock.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tlpFormulaire.ResumeLayout(false);
            tlpFomulaire2.ResumeLayout(false);
            tlpFomulaire2.PerformLayout();
            flpFormulaire2.ResumeLayout(false);
            flpFormulaire2.PerformLayout();
            tlpFormulaireG.ResumeLayout(false);
            tlpFormulaireG.PerformLayout();
            flpFormulaireHG.ResumeLayout(false);
            flpFormulaireHG.PerformLayout();
            flpFormulaireBG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            tbListePrep.ResumeLayout(false);
            tlpListePrep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListePrep).EndInit();
            tpStatut.ResumeLayout(false);
            tlpPrep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrep).EndInit();
            tpCmdStatut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCmdStatut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpStock;
        private TabControl tpStock;
        private TabPage tbStock;
        private TabPage tbListePrep;
        private Label lblStock;
        private TableLayoutPanel tlpTcStock;
        private DataGridView dgvStock;
        private TableLayoutPanel tlpFormulaire;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnQte;
        private TextBox txtbQte;
        private Button btnCRUD;
        private Label lblQte;
        private TableLayoutPanel tlpFomulaire2;
        private FlowLayoutPanel flpFormulaire2;
        private Label lblcategorie;
        private ComboBox comboBox1;
        private Label lblDescription;
        private TextBox txtbDescription;
        private TableLayoutPanel tlpFormulaireG;
        private FlowLayoutPanel flpFormulaireHG;
        private Label lblNom;
        private TextBox txtbNom;
        private Label lblQuantite;
        private TextBox txtbQuantite;
        private Label lblPA;
        private TextBox txtbPA;
        private Label lblPV;
        private TextBox txtbPV;
        private FlowLayoutPanel flpFormulaireBG;
        private Button btnAjouterProduit;
        private Button btnModifier;
        private Button btnSupprimer;
        private TableLayoutPanel tlpListePrep;
        private Button btnPreparer;
        private DataGridView dgvListePrep;
        private TabPage tpStatut;
        private TableLayoutPanel tlpPrep;
        private DataGridView dgvPrep;
        private Button btnAnnulerPrep;
        private Button btnValiderPrep;
        private TabPage tpCmdStatut;
        private DataGridView dgvCmdStatut;
    }
}