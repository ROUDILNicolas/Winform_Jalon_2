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
            components = new System.ComponentModel.Container();
            tlpStock = new TableLayoutPanel();
            tcStock = new TabControl();
            tpStock = new TabPage();
            tlpTcStock = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnCRUD = new Button();
            btnQte = new Button();
            lblQte = new Label();
            txtbQte = new TextBox();
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
            colId = new DataGridViewTextBoxColumn();
            colNom = new DataGridViewTextBoxColumn();
            colQuantite = new DataGridViewTextBoxColumn();
            colCategorie = new DataGridViewTextBoxColumn();
            colDetails = new DataGridViewTextBoxColumn();
            tpListePrep = new TabPage();
            tlpListePrep = new TableLayoutPanel();
            dgvListePrep = new DataGridView();
            colIdCommande = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colNombreArticles = new DataGridViewTextBoxColumn();
            colQuantiteTotale = new DataGridViewTextBoxColumn();
            btnPreparer = new Button();
            tpPrep = new TabPage();
            tlpPrep = new TableLayoutPanel();
            dgvPrep = new DataGridView();
            ProduitId = new DataGridViewTextBoxColumn();
            Produit = new DataGridViewTextBoxColumn();
            colQuantitePrep = new DataGridViewTextBoxColumn();
            colRecupere = new DataGridViewCheckBoxColumn();
            btnAnnulerPrep = new Button();
            btnValiderPrep = new Button();
            tpCmdStatut = new TabPage();
            tlpdgvCmdStatut = new TableLayoutPanel();
            dgvCmdStatut = new DataGridView();
            colIdCmdStatut = new DataGridViewTextBoxColumn();
            colDateCmdStatut = new DataGridViewTextBoxColumn();
            colStatutCmd = new DataGridViewTextBoxColumn();
            colNbArticlesCmdStatut = new DataGridViewTextBoxColumn();
            colQuantiteCmdStatut = new DataGridViewTextBoxColumn();
            tlpSelectStatut = new TableLayoutPanel();
            btnModifierStatut = new Button();
            lblModifierStatut = new Label();
            cbFiltreStatut = new ComboBox();
            cbModifierStatut = new ComboBox();
            lblFiltres = new Label();
            lblStock = new Label();
            bsProduit = new BindingSource(components);
            bsCommandesAPrep = new BindingSource(components);
            bsPreparation = new BindingSource(components);
            bsCmdStatut = new BindingSource(components);
            tlpStock.SuspendLayout();
            tcStock.SuspendLayout();
            tpStock.SuspendLayout();
            tlpTcStock.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tlpFormulaire.SuspendLayout();
            tlpFomulaire2.SuspendLayout();
            flpFormulaire2.SuspendLayout();
            tlpFormulaireG.SuspendLayout();
            flpFormulaireHG.SuspendLayout();
            flpFormulaireBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            tpListePrep.SuspendLayout();
            tlpListePrep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListePrep).BeginInit();
            tpPrep.SuspendLayout();
            tlpPrep.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrep).BeginInit();
            tpCmdStatut.SuspendLayout();
            tlpdgvCmdStatut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCmdStatut).BeginInit();
            tlpSelectStatut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsProduit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandesAPrep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsPreparation).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCmdStatut).BeginInit();
            SuspendLayout();
            // 
            // tlpStock
            // 
            tlpStock.BackColor = SystemColors.Control;
            tlpStock.ColumnCount = 3;
            tlpStock.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.617811F));
            tlpStock.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.76438F));
            tlpStock.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.617809F));
            tlpStock.Controls.Add(tcStock, 1, 1);
            tlpStock.Controls.Add(lblStock, 1, 0);
            tlpStock.Dock = DockStyle.Fill;
            tlpStock.Location = new Point(0, 0);
            tlpStock.Name = "tlpStock";
            tlpStock.RightToLeft = RightToLeft.Yes;
            tlpStock.RowCount = 3;
            tlpStock.RowStyles.Add(new RowStyle());
            tlpStock.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpStock.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpStock.Size = new Size(941, 594);
            tlpStock.TabIndex = 0;
            // 
            // tcStock
            // 
            tcStock.Controls.Add(tpStock);
            tcStock.Controls.Add(tpListePrep);
            tcStock.Controls.Add(tpPrep);
            tcStock.Controls.Add(tpCmdStatut);
            tcStock.Dock = DockStyle.Fill;
            tcStock.Location = new Point(38, 49);
            tcStock.Name = "tcStock";
            tcStock.RightToLeft = RightToLeft.No;
            tcStock.SelectedIndex = 0;
            tcStock.Size = new Size(866, 492);
            tcStock.TabIndex = 0;
            tcStock.Selecting += tcStock_Selecting;
            tcStock.Selected += tpStock_Selected;
            // 
            // tpStock
            // 
            tpStock.Controls.Add(tlpTcStock);
            tpStock.Location = new Point(4, 29);
            tpStock.Name = "tpStock";
            tpStock.Padding = new Padding(3);
            tpStock.Size = new Size(858, 459);
            tpStock.TabIndex = 0;
            tpStock.Text = "Stock";
            tpStock.UseVisualStyleBackColor = true;
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
            tlpTcStock.Size = new Size(852, 453);
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
            tableLayoutPanel2.Controls.Add(lblQte, 2, 0);
            tableLayoutPanel2.Controls.Add(txtbQte, 2, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(846, 54);
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
            btnQte.Location = new Point(783, 23);
            btnQte.Name = "btnQte";
            btnQte.Size = new Size(60, 32);
            btnQte.TabIndex = 0;
            btnQte.Text = "Entrer";
            btnQte.UseVisualStyleBackColor = true;
            // 
            // lblQte
            // 
            lblQte.AutoSize = true;
            lblQte.Location = new Point(689, 0);
            lblQte.Name = "lblQte";
            lblQte.Size = new Size(33, 20);
            lblQte.TabIndex = 2;
            lblQte.Text = "Qte";
            // 
            // txtbQte
            // 
            txtbQte.Location = new Point(689, 23);
            txtbQte.Name = "txtbQte";
            txtbQte.Size = new Size(88, 27);
            txtbQte.TabIndex = 1;
            // 
            // tlpFormulaire
            // 
            tlpFormulaire.ColumnCount = 2;
            tlpFormulaire.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFormulaire.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpFormulaire.Controls.Add(tlpFomulaire2, 1, 0);
            tlpFormulaire.Controls.Add(tlpFormulaireG, 0, 0);
            tlpFormulaire.Dock = DockStyle.Fill;
            tlpFormulaire.Location = new Point(3, 126);
            tlpFormulaire.Name = "tlpFormulaire";
            tlpFormulaire.RowCount = 1;
            tlpFormulaire.RowStyles.Add(new RowStyle());
            tlpFormulaire.Size = new Size(846, 324);
            tlpFormulaire.TabIndex = 3;
            // 
            // tlpFomulaire2
            // 
            tlpFomulaire2.ColumnCount = 1;
            tlpFomulaire2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpFomulaire2.Controls.Add(txtbDescription, 0, 1);
            tlpFomulaire2.Controls.Add(flpFormulaire2, 0, 0);
            tlpFomulaire2.Dock = DockStyle.Fill;
            tlpFomulaire2.Location = new Point(426, 3);
            tlpFomulaire2.Name = "tlpFomulaire2";
            tlpFomulaire2.RightToLeft = RightToLeft.No;
            tlpFomulaire2.RowCount = 2;
            tlpFomulaire2.RowStyles.Add(new RowStyle());
            tlpFomulaire2.RowStyles.Add(new RowStyle());
            tlpFomulaire2.Size = new Size(417, 318);
            tlpFomulaire2.TabIndex = 1;
            // 
            // txtbDescription
            // 
            txtbDescription.Dock = DockStyle.Fill;
            txtbDescription.Location = new Point(3, 83);
            txtbDescription.Multiline = true;
            txtbDescription.Name = "txtbDescription";
            txtbDescription.ScrollBars = ScrollBars.Vertical;
            txtbDescription.Size = new Size(411, 232);
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
            flpFormulaire2.Size = new Size(411, 74);
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
            tlpFormulaireG.RightToLeft = RightToLeft.No;
            tlpFormulaireG.RowCount = 2;
            tlpFormulaireG.RowStyles.Add(new RowStyle());
            tlpFormulaireG.RowStyles.Add(new RowStyle());
            tlpFormulaireG.Size = new Size(417, 318);
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
            flpFormulaireHG.RightToLeft = RightToLeft.No;
            flpFormulaireHG.Size = new Size(411, 212);
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
            flpFormulaireBG.Size = new Size(411, 97);
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
            dgvStock.AllowUserToAddRows = false;
            dgvStock.AllowUserToDeleteRows = false;
            dgvStock.AllowUserToResizeColumns = false;
            dgvStock.AllowUserToResizeRows = false;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Columns.AddRange(new DataGridViewColumn[] { colId, colNom, colQuantite, colCategorie, colDetails });
            dgvStock.Dock = DockStyle.Fill;
            dgvStock.Location = new Point(3, 63);
            dgvStock.Name = "dgvStock";
            dgvStock.RightToLeft = RightToLeft.No;
            dgvStock.RowHeadersVisible = false;
            dgvStock.RowHeadersWidth = 51;
            dgvStock.Size = new Size(846, 57);
            dgvStock.TabIndex = 1;
            dgvStock.CellClick += dgvStock_CellClick;
            dgvStock.RowPostPaint += dgvStock_RowPostPaint;
            // 
            // colId
            // 
            colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Resizable = DataGridViewTriState.False;
            colId.Width = 60;
            // 
            // colNom
            // 
            colNom.DataPropertyName = "Nom";
            colNom.HeaderText = "Nom";
            colNom.MinimumWidth = 6;
            colNom.Name = "colNom";
            colNom.ReadOnly = true;
            // 
            // colQuantite
            // 
            colQuantite.DataPropertyName = "Quantite";
            colQuantite.HeaderText = "Quantité";
            colQuantite.MinimumWidth = 6;
            colQuantite.Name = "colQuantite";
            colQuantite.ReadOnly = true;
            // 
            // colCategorie
            // 
            colCategorie.DataPropertyName = "NomTypeProduit";
            colCategorie.HeaderText = "Catégorie";
            colCategorie.MinimumWidth = 6;
            colCategorie.Name = "colCategorie";
            colCategorie.ReadOnly = true;
            // 
            // colDetails
            // 
            colDetails.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDetails.HeaderText = "▼";
            colDetails.MinimumWidth = 6;
            colDetails.Name = "colDetails";
            colDetails.ReadOnly = true;
            colDetails.Resizable = DataGridViewTriState.False;
            colDetails.Width = 35;
            // 
            // tpListePrep
            // 
            tpListePrep.Controls.Add(tlpListePrep);
            tpListePrep.Location = new Point(4, 29);
            tpListePrep.Name = "tpListePrep";
            tpListePrep.Padding = new Padding(3);
            tpListePrep.Size = new Size(858, 459);
            tpListePrep.TabIndex = 1;
            tpListePrep.Text = "Liste Préparation";
            tpListePrep.UseVisualStyleBackColor = true;
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
            tlpListePrep.Size = new Size(852, 453);
            tlpListePrep.TabIndex = 0;
            // 
            // dgvListePrep
            // 
            dgvListePrep.AllowUserToAddRows = false;
            dgvListePrep.AllowUserToDeleteRows = false;
            dgvListePrep.AllowUserToResizeColumns = false;
            dgvListePrep.AllowUserToResizeRows = false;
            dgvListePrep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvListePrep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListePrep.Columns.AddRange(new DataGridViewColumn[] { colIdCommande, colDate, colNombreArticles, colQuantiteTotale });
            tlpListePrep.SetColumnSpan(dgvListePrep, 2);
            dgvListePrep.Dock = DockStyle.Fill;
            dgvListePrep.Location = new Point(3, 3);
            dgvListePrep.MultiSelect = false;
            dgvListePrep.Name = "dgvListePrep";
            dgvListePrep.ReadOnly = true;
            dgvListePrep.RowHeadersVisible = false;
            dgvListePrep.RowHeadersWidth = 51;
            dgvListePrep.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListePrep.Size = new Size(846, 350);
            dgvListePrep.TabIndex = 0;
            // 
            // colIdCommande
            // 
            colIdCommande.DataPropertyName = "Id";
            colIdCommande.HeaderText = "Id";
            colIdCommande.MinimumWidth = 6;
            colIdCommande.Name = "colIdCommande";
            colIdCommande.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.DataPropertyName = "Date";
            colDate.HeaderText = "Date";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colNombreArticles
            // 
            colNombreArticles.DataPropertyName = "NombreArticles";
            colNombreArticles.HeaderText = "Nb articles";
            colNombreArticles.MinimumWidth = 6;
            colNombreArticles.Name = "colNombreArticles";
            colNombreArticles.ReadOnly = true;
            // 
            // colQuantiteTotale
            // 
            colQuantiteTotale.DataPropertyName = "QuantiteTotale";
            colQuantiteTotale.HeaderText = "Quantité totale";
            colQuantiteTotale.MinimumWidth = 6;
            colQuantiteTotale.Name = "colQuantiteTotale";
            colQuantiteTotale.ReadOnly = true;
            // 
            // btnPreparer
            // 
            btnPreparer.Location = new Point(755, 359);
            btnPreparer.Name = "btnPreparer";
            btnPreparer.Size = new Size(94, 91);
            btnPreparer.TabIndex = 1;
            btnPreparer.Text = "Préparer";
            btnPreparer.UseVisualStyleBackColor = true;
            btnPreparer.Click += btnPreparer_Click;
            // 
            // tpPrep
            // 
            tpPrep.Controls.Add(tlpPrep);
            tpPrep.Location = new Point(4, 29);
            tpPrep.Name = "tpPrep";
            tpPrep.Padding = new Padding(3);
            tpPrep.Size = new Size(858, 459);
            tpPrep.TabIndex = 2;
            tpPrep.Text = "Préparation";
            tpPrep.UseVisualStyleBackColor = true;
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
            tlpPrep.Size = new Size(852, 453);
            tlpPrep.TabIndex = 0;
            // 
            // dgvPrep
            // 
            dgvPrep.AllowUserToAddRows = false;
            dgvPrep.AllowUserToDeleteRows = false;
            dgvPrep.AllowUserToResizeColumns = false;
            dgvPrep.AllowUserToResizeRows = false;
            dgvPrep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrep.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrep.Columns.AddRange(new DataGridViewColumn[] { ProduitId, Produit, colQuantitePrep, colRecupere });
            tlpPrep.SetColumnSpan(dgvPrep, 3);
            dgvPrep.Dock = DockStyle.Fill;
            dgvPrep.Location = new Point(3, 3);
            dgvPrep.Name = "dgvPrep";
            dgvPrep.RowHeadersVisible = false;
            dgvPrep.RowHeadersWidth = 51;
            dgvPrep.Size = new Size(846, 350);
            dgvPrep.TabIndex = 0;
            dgvPrep.CellValueChanged += dgvPrep_CellValueChanged;
            dgvPrep.CurrentCellDirtyStateChanged += dgvPrep_CurrentCellDirtyStateChanged;
            // 
            // ProduitId
            // 
            ProduitId.DataPropertyName = "ProduitId";
            ProduitId.HeaderText = "ProduitId";
            ProduitId.MinimumWidth = 6;
            ProduitId.Name = "ProduitId";
            ProduitId.ReadOnly = true;
            // 
            // Produit
            // 
            Produit.DataPropertyName = "NomProduit";
            Produit.HeaderText = "Produit";
            Produit.MinimumWidth = 6;
            Produit.Name = "Produit";
            Produit.ReadOnly = true;
            // 
            // colQuantitePrep
            // 
            colQuantitePrep.DataPropertyName = "Quantite";
            colQuantitePrep.HeaderText = "Quantité";
            colQuantitePrep.MinimumWidth = 6;
            colQuantitePrep.Name = "colQuantitePrep";
            colQuantitePrep.ReadOnly = true;
            // 
            // colRecupere
            // 
            colRecupere.HeaderText = "Récupéré";
            colRecupere.MinimumWidth = 6;
            colRecupere.Name = "colRecupere";
            colRecupere.Resizable = DataGridViewTriState.True;
            colRecupere.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // btnAnnulerPrep
            // 
            btnAnnulerPrep.Location = new Point(3, 359);
            btnAnnulerPrep.Name = "btnAnnulerPrep";
            btnAnnulerPrep.Size = new Size(94, 91);
            btnAnnulerPrep.TabIndex = 1;
            btnAnnulerPrep.Text = "Annuler";
            btnAnnulerPrep.UseVisualStyleBackColor = true;
            btnAnnulerPrep.Click += btnAnnulerPrep_Click;
            // 
            // btnValiderPrep
            // 
            btnValiderPrep.Location = new Point(755, 359);
            btnValiderPrep.Name = "btnValiderPrep";
            btnValiderPrep.Size = new Size(94, 91);
            btnValiderPrep.TabIndex = 2;
            btnValiderPrep.Text = "Valider";
            btnValiderPrep.UseVisualStyleBackColor = true;
            btnValiderPrep.Click += btnValiderPrep_Click;
            // 
            // tpCmdStatut
            // 
            tpCmdStatut.Controls.Add(tlpdgvCmdStatut);
            tpCmdStatut.Location = new Point(4, 29);
            tpCmdStatut.Name = "tpCmdStatut";
            tpCmdStatut.Padding = new Padding(3);
            tpCmdStatut.Size = new Size(858, 459);
            tpCmdStatut.TabIndex = 3;
            tpCmdStatut.Text = "CmdStatut";
            tpCmdStatut.UseVisualStyleBackColor = true;
            // 
            // tlpdgvCmdStatut
            // 
            tlpdgvCmdStatut.AutoSize = true;
            tlpdgvCmdStatut.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpdgvCmdStatut.ColumnCount = 1;
            tlpdgvCmdStatut.ColumnStyles.Add(new ColumnStyle());
            tlpdgvCmdStatut.Controls.Add(dgvCmdStatut, 0, 1);
            tlpdgvCmdStatut.Controls.Add(tlpSelectStatut, 0, 0);
            tlpdgvCmdStatut.Dock = DockStyle.Fill;
            tlpdgvCmdStatut.Location = new Point(3, 3);
            tlpdgvCmdStatut.Name = "tlpdgvCmdStatut";
            tlpdgvCmdStatut.RightToLeft = RightToLeft.No;
            tlpdgvCmdStatut.RowCount = 2;
            tlpdgvCmdStatut.RowStyles.Add(new RowStyle());
            tlpdgvCmdStatut.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpdgvCmdStatut.Size = new Size(852, 453);
            tlpdgvCmdStatut.TabIndex = 0;
            // 
            // dgvCmdStatut
            // 
            dgvCmdStatut.AllowUserToAddRows = false;
            dgvCmdStatut.AllowUserToDeleteRows = false;
            dgvCmdStatut.AllowUserToResizeRows = false;
            dgvCmdStatut.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCmdStatut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCmdStatut.Columns.AddRange(new DataGridViewColumn[] { colIdCmdStatut, colDateCmdStatut, colStatutCmd, colNbArticlesCmdStatut, colQuantiteCmdStatut });
            dgvCmdStatut.Dock = DockStyle.Fill;
            dgvCmdStatut.Location = new Point(3, 44);
            dgvCmdStatut.MultiSelect = false;
            dgvCmdStatut.Name = "dgvCmdStatut";
            dgvCmdStatut.ReadOnly = true;
            dgvCmdStatut.RightToLeft = RightToLeft.No;
            dgvCmdStatut.RowHeadersVisible = false;
            dgvCmdStatut.RowHeadersWidth = 51;
            dgvCmdStatut.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCmdStatut.Size = new Size(846, 406);
            dgvCmdStatut.TabIndex = 4;
            // 
            // colIdCmdStatut
            // 
            colIdCmdStatut.DataPropertyName = "Id";
            colIdCmdStatut.FillWeight = 20.76547F;
            colIdCmdStatut.HeaderText = "Id";
            colIdCmdStatut.MinimumWidth = 31;
            colIdCmdStatut.Name = "colIdCmdStatut";
            colIdCmdStatut.ReadOnly = true;
            // 
            // colDateCmdStatut
            // 
            colDateCmdStatut.DataPropertyName = "Date";
            colDateCmdStatut.FillWeight = 50.4959259F;
            colDateCmdStatut.HeaderText = "Date";
            colDateCmdStatut.MinimumWidth = 6;
            colDateCmdStatut.Name = "colDateCmdStatut";
            colDateCmdStatut.ReadOnly = true;
            // 
            // colStatutCmd
            // 
            colStatutCmd.DataPropertyName = "Statut";
            colStatutCmd.FillWeight = 77.82992F;
            colStatutCmd.HeaderText = "Statut";
            colStatutCmd.MinimumWidth = 6;
            colStatutCmd.Name = "colStatutCmd";
            colStatutCmd.ReadOnly = true;
            // 
            // colNbArticlesCmdStatut
            // 
            colNbArticlesCmdStatut.DataPropertyName = "NombreArticles";
            colNbArticlesCmdStatut.FillWeight = 141.943878F;
            colNbArticlesCmdStatut.HeaderText = "Nb Articles";
            colNbArticlesCmdStatut.MinimumWidth = 6;
            colNbArticlesCmdStatut.Name = "colNbArticlesCmdStatut";
            colNbArticlesCmdStatut.ReadOnly = true;
            // 
            // colQuantiteCmdStatut
            // 
            colQuantiteCmdStatut.DataPropertyName = "QuantiteTotale";
            colQuantiteCmdStatut.FillWeight = 208.9648F;
            colQuantiteCmdStatut.HeaderText = "Quantite Totale";
            colQuantiteCmdStatut.MinimumWidth = 6;
            colQuantiteCmdStatut.Name = "colQuantiteCmdStatut";
            colQuantiteCmdStatut.ReadOnly = true;
            // 
            // tlpSelectStatut
            // 
            tlpSelectStatut.AutoSize = true;
            tlpSelectStatut.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpSelectStatut.ColumnCount = 6;
            tlpSelectStatut.ColumnStyles.Add(new ColumnStyle());
            tlpSelectStatut.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tlpSelectStatut.ColumnStyles.Add(new ColumnStyle());
            tlpSelectStatut.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpSelectStatut.ColumnStyles.Add(new ColumnStyle());
            tlpSelectStatut.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 140F));
            tlpSelectStatut.Controls.Add(btnModifierStatut, 2, 0);
            tlpSelectStatut.Controls.Add(lblModifierStatut, 0, 0);
            tlpSelectStatut.Controls.Add(cbFiltreStatut, 5, 0);
            tlpSelectStatut.Controls.Add(cbModifierStatut, 1, 0);
            tlpSelectStatut.Controls.Add(lblFiltres, 4, 0);
            tlpSelectStatut.Dock = DockStyle.Fill;
            tlpSelectStatut.Location = new Point(3, 3);
            tlpSelectStatut.Name = "tlpSelectStatut";
            tlpSelectStatut.RowCount = 1;
            tlpSelectStatut.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpSelectStatut.Size = new Size(846, 35);
            tlpSelectStatut.TabIndex = 3;
            // 
            // btnModifierStatut
            // 
            btnModifierStatut.Anchor = AnchorStyles.None;
            btnModifierStatut.Location = new Point(265, 3);
            btnModifierStatut.Name = "btnModifierStatut";
            btnModifierStatut.Size = new Size(94, 29);
            btnModifierStatut.TabIndex = 5;
            btnModifierStatut.Text = "Modifier";
            btnModifierStatut.UseVisualStyleBackColor = true;
            btnModifierStatut.Click += btnModifierStatut_Click;
            // 
            // lblModifierStatut
            // 
            lblModifierStatut.Anchor = AnchorStyles.None;
            lblModifierStatut.Location = new Point(3, 7);
            lblModifierStatut.Name = "lblModifierStatut";
            lblModifierStatut.Size = new Size(116, 20);
            lblModifierStatut.TabIndex = 4;
            lblModifierStatut.Text = "Nouveau statut :";
            // 
            // cbFiltreStatut
            // 
            cbFiltreStatut.Dock = DockStyle.Fill;
            cbFiltreStatut.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFiltreStatut.FormattingEnabled = true;
            cbFiltreStatut.Location = new Point(709, 3);
            cbFiltreStatut.Name = "cbFiltreStatut";
            cbFiltreStatut.Size = new Size(134, 28);
            cbFiltreStatut.TabIndex = 1;
            cbFiltreStatut.SelectedIndexChanged += cbFiltreStatut_SelectedIndexChanged;
            // 
            // cbModifierStatut
            // 
            cbModifierStatut.Dock = DockStyle.Fill;
            cbModifierStatut.FormattingEnabled = true;
            cbModifierStatut.Location = new Point(125, 3);
            cbModifierStatut.Name = "cbModifierStatut";
            cbModifierStatut.RightToLeft = RightToLeft.No;
            cbModifierStatut.Size = new Size(134, 28);
            cbModifierStatut.TabIndex = 3;
            // 
            // lblFiltres
            // 
            lblFiltres.Anchor = AnchorStyles.None;
            lblFiltres.Location = new Point(648, 7);
            lblFiltres.Name = "lblFiltres";
            lblFiltres.Size = new Size(55, 20);
            lblFiltres.TabIndex = 2;
            lblFiltres.Text = "Statut :";
            // 
            // lblStock
            // 
            lblStock.Anchor = AnchorStyles.None;
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblStock.Location = new Point(344, 0);
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
            ClientSize = new Size(941, 594);
            Controls.Add(tlpStock);
            MinimumSize = new Size(959, 641);
            Name = "Stock";
            Text = "Stock";
            Load += Stock_Load;
            tlpStock.ResumeLayout(false);
            tlpStock.PerformLayout();
            tcStock.ResumeLayout(false);
            tpStock.ResumeLayout(false);
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
            tpListePrep.ResumeLayout(false);
            tlpListePrep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListePrep).EndInit();
            tpPrep.ResumeLayout(false);
            tlpPrep.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrep).EndInit();
            tpCmdStatut.ResumeLayout(false);
            tpCmdStatut.PerformLayout();
            tlpdgvCmdStatut.ResumeLayout(false);
            tlpdgvCmdStatut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCmdStatut).EndInit();
            tlpSelectStatut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsProduit).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCommandesAPrep).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsPreparation).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCmdStatut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpStock;
        private TabControl tcStock;
        private TabPage tpStock;
        private TabPage tpListePrep;
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
        private TabPage tpPrep;
        private TableLayoutPanel tlpPrep;
        private DataGridView dgvPrep;
        private Button btnAnnulerPrep;
        private Button btnValiderPrep;
        private TabPage tpCmdStatut;
        private BindingSource bsProduit;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNom;
        private DataGridViewTextBoxColumn colQuantite;
        private DataGridViewTextBoxColumn colCategorie;
        private DataGridViewTextBoxColumn colDetails;
        private BindingSource bsCommandesAPrep;
        private DataGridViewTextBoxColumn colIdCommande;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colNombreArticles;
        private DataGridViewTextBoxColumn colQuantiteTotale;
        private BindingSource bsPreparation;
        private DataGridViewTextBoxColumn ProduitId;
        private DataGridViewTextBoxColumn Produit;
        private DataGridViewTextBoxColumn colQuantitePrep;
        private DataGridViewCheckBoxColumn colRecupere;
        private BindingSource bsCmdStatut;
        private TableLayoutPanel tlpdgvCmdStatut;
        private TableLayoutPanel tlpSelectStatut;
        private Button btnModifierStatut;
        private Label lblModifierStatut;
        private ComboBox cbFiltreStatut;
        private ComboBox cbModifierStatut;
        private Label lblFiltres;
        private DataGridView dgvCmdStatut;
        private DataGridViewTextBoxColumn colIdCmdStatut;
        private DataGridViewTextBoxColumn colDateCmdStatut;
        private DataGridViewTextBoxColumn colStatutCmd;
        private DataGridViewTextBoxColumn colNbArticlesCmdStatut;
        private DataGridViewTextBoxColumn colQuantiteCmdStatut;
    }
}