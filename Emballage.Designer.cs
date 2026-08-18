namespace WinForms_Jalon_2
{
    partial class Emballage
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
            lblStock = new Label();
            tlpEmballage = new TableLayoutPanel();
            tcEmballage = new TabControl();
            tpEmballage = new TabPage();
            tlpPreparation = new TableLayoutPanel();
            dgvEmballage = new DataGridView();
            colIdEmballage = new DataGridViewTextBoxColumn();
            colDateEmballage = new DataGridViewTextBoxColumn();
            colNbArticlesEmballage = new DataGridViewTextBoxColumn();
            colQuantiteTotaleEmballage = new DataGridViewTextBoxColumn();
            btnEmballage = new Button();
            tpCommande = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnValiderCommande = new Button();
            btnAnnulerCommande = new Button();
            dgvCommande = new DataGridView();
            colNomProduitCommande = new DataGridViewTextBoxColumn();
            colProduitIdCommande = new DataGridViewTextBoxColumn();
            colQuantiteCommande = new DataGridViewTextBoxColumn();
            colEmballe = new DataGridViewCheckBoxColumn();
            bsEmballage = new BindingSource(components);
            bsCommande = new BindingSource(components);
            tlpEmballage.SuspendLayout();
            tcEmballage.SuspendLayout();
            tpEmballage.SuspendLayout();
            tlpPreparation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmballage).BeginInit();
            tpCommande.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCommande).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsEmballage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCommande).BeginInit();
            SuspendLayout();
            // 
            // lblStock
            // 
            lblStock.Anchor = AnchorStyles.None;
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblStock.Location = new Point(93, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(533, 46);
            lblStock.TabIndex = 1;
            lblStock.Text = "Liste des commandes a emballer";
            lblStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpEmballage
            // 
            tlpEmballage.BackColor = SystemColors.Control;
            tlpEmballage.ColumnCount = 3;
            tlpEmballage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.617811F));
            tlpEmballage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.76438F));
            tlpEmballage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.617809F));
            tlpEmballage.Controls.Add(tcEmballage, 1, 1);
            tlpEmballage.Controls.Add(lblStock, 1, 0);
            tlpEmballage.Dock = DockStyle.Fill;
            tlpEmballage.Location = new Point(0, 0);
            tlpEmballage.Name = "tlpEmballage";
            tlpEmballage.RowCount = 3;
            tlpEmballage.RowStyles.Add(new RowStyle());
            tlpEmballage.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpEmballage.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpEmballage.Size = new Size(721, 577);
            tlpEmballage.TabIndex = 1;
            // 
            // tcEmballage
            // 
            tcEmballage.Controls.Add(tpEmballage);
            tcEmballage.Controls.Add(tpCommande);
            tcEmballage.Dock = DockStyle.Fill;
            tcEmballage.Location = new Point(29, 49);
            tcEmballage.Name = "tcEmballage";
            tcEmballage.SelectedIndex = 0;
            tcEmballage.Size = new Size(662, 475);
            tcEmballage.TabIndex = 0;
            tcEmballage.Selected += tpEmballage_Selected;
            // 
            // tpEmballage
            // 
            tpEmballage.Controls.Add(tlpPreparation);
            tpEmballage.Location = new Point(4, 29);
            tpEmballage.Name = "tpEmballage";
            tpEmballage.Padding = new Padding(3);
            tpEmballage.Size = new Size(654, 442);
            tpEmballage.TabIndex = 1;
            tpEmballage.Text = "Emballage";
            tpEmballage.UseVisualStyleBackColor = true;
            // 
            // tlpPreparation
            // 
            tlpPreparation.ColumnCount = 2;
            tlpPreparation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPreparation.ColumnStyles.Add(new ColumnStyle());
            tlpPreparation.Controls.Add(dgvEmballage, 0, 0);
            tlpPreparation.Controls.Add(btnEmballage, 1, 1);
            tlpPreparation.Dock = DockStyle.Fill;
            tlpPreparation.Location = new Point(3, 3);
            tlpPreparation.Name = "tlpPreparation";
            tlpPreparation.RowCount = 2;
            tlpPreparation.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPreparation.RowStyles.Add(new RowStyle());
            tlpPreparation.Size = new Size(648, 436);
            tlpPreparation.TabIndex = 1;
            // 
            // dgvEmballage
            // 
            dgvEmballage.AllowUserToAddRows = false;
            dgvEmballage.AllowUserToDeleteRows = false;
            dgvEmballage.AllowUserToResizeColumns = false;
            dgvEmballage.AllowUserToResizeRows = false;
            dgvEmballage.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmballage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmballage.Columns.AddRange(new DataGridViewColumn[] { colIdEmballage, colDateEmballage, colNbArticlesEmballage, colQuantiteTotaleEmballage });
            tlpPreparation.SetColumnSpan(dgvEmballage, 2);
            dgvEmballage.Dock = DockStyle.Fill;
            dgvEmballage.Location = new Point(3, 3);
            dgvEmballage.Name = "dgvEmballage";
            dgvEmballage.RowHeadersVisible = false;
            dgvEmballage.RowHeadersWidth = 51;
            dgvEmballage.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmballage.Size = new Size(642, 333);
            dgvEmballage.TabIndex = 0;
            // 
            // colIdEmballage
            // 
            colIdEmballage.DataPropertyName = "Id";
            colIdEmballage.HeaderText = "Id";
            colIdEmballage.MinimumWidth = 6;
            colIdEmballage.Name = "colIdEmballage";
            // 
            // colDateEmballage
            // 
            colDateEmballage.DataPropertyName = "Date";
            colDateEmballage.HeaderText = "Date";
            colDateEmballage.MinimumWidth = 6;
            colDateEmballage.Name = "colDateEmballage";
            // 
            // colNbArticlesEmballage
            // 
            colNbArticlesEmballage.DataPropertyName = "NombreArticles";
            colNbArticlesEmballage.HeaderText = "Nb articles";
            colNbArticlesEmballage.MinimumWidth = 6;
            colNbArticlesEmballage.Name = "colNbArticlesEmballage";
            // 
            // colQuantiteTotaleEmballage
            // 
            colQuantiteTotaleEmballage.DataPropertyName = "QuantiteTotale";
            colQuantiteTotaleEmballage.HeaderText = "Quantité totale";
            colQuantiteTotaleEmballage.MinimumWidth = 6;
            colQuantiteTotaleEmballage.Name = "colQuantiteTotaleEmballage";
            // 
            // btnEmballage
            // 
            btnEmballage.Location = new Point(551, 342);
            btnEmballage.Name = "btnEmballage";
            btnEmballage.Size = new Size(94, 91);
            btnEmballage.TabIndex = 1;
            btnEmballage.Text = "Emballage";
            btnEmballage.UseVisualStyleBackColor = true;
            btnEmballage.Click += btnEmballage_Click;
            // 
            // tpCommande
            // 
            tpCommande.Controls.Add(tableLayoutPanel2);
            tpCommande.Location = new Point(4, 29);
            tpCommande.Name = "tpCommande";
            tpCommande.Padding = new Padding(3);
            tpCommande.Size = new Size(654, 442);
            tpCommande.TabIndex = 3;
            tpCommande.Text = "Commande";
            tpCommande.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(btnValiderCommande, 1, 1);
            tableLayoutPanel2.Controls.Add(btnAnnulerCommande, 0, 1);
            tableLayoutPanel2.Controls.Add(dgvCommande, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(648, 436);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnValiderCommande
            // 
            btnValiderCommande.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnValiderCommande.Location = new Point(491, 365);
            btnValiderCommande.Name = "btnValiderCommande";
            btnValiderCommande.Size = new Size(154, 68);
            btnValiderCommande.TabIndex = 3;
            btnValiderCommande.Text = "Valider";
            btnValiderCommande.UseVisualStyleBackColor = true;
            btnValiderCommande.Click += btnValiderCommande_Click;
            // 
            // btnAnnulerCommande
            // 
            btnAnnulerCommande.Location = new Point(3, 365);
            btnAnnulerCommande.Name = "btnAnnulerCommande";
            btnAnnulerCommande.Size = new Size(154, 68);
            btnAnnulerCommande.TabIndex = 5;
            btnAnnulerCommande.Text = "Annuler";
            btnAnnulerCommande.UseVisualStyleBackColor = true;
            // 
            // dgvCommande
            // 
            dgvCommande.AllowUserToAddRows = false;
            dgvCommande.AllowUserToDeleteRows = false;
            dgvCommande.AllowUserToResizeColumns = false;
            dgvCommande.AllowUserToResizeRows = false;
            dgvCommande.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCommande.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCommande.Columns.AddRange(new DataGridViewColumn[] { colNomProduitCommande, colProduitIdCommande, colQuantiteCommande, colEmballe });
            tableLayoutPanel2.SetColumnSpan(dgvCommande, 2);
            dgvCommande.Dock = DockStyle.Fill;
            dgvCommande.Location = new Point(3, 3);
            dgvCommande.Name = "dgvCommande";
            dgvCommande.RowHeadersWidth = 51;
            dgvCommande.Size = new Size(642, 356);
            dgvCommande.TabIndex = 6;
            dgvCommande.CellValueChanged += dgvCommande_CellValueChanged;
            dgvCommande.CurrentCellDirtyStateChanged += dgvCommande_CurrentCellDirtyStateChanged;
            // 
            // colNomProduitCommande
            // 
            colNomProduitCommande.DataPropertyName = "NomProduit";
            colNomProduitCommande.HeaderText = "Produit";
            colNomProduitCommande.MinimumWidth = 6;
            colNomProduitCommande.Name = "colNomProduitCommande";
            // 
            // colProduitIdCommande
            // 
            colProduitIdCommande.DataPropertyName = "ProduitId";
            colProduitIdCommande.HeaderText = "ProduitId";
            colProduitIdCommande.MinimumWidth = 6;
            colProduitIdCommande.Name = "colProduitIdCommande";
            colProduitIdCommande.Visible = false;
            // 
            // colQuantiteCommande
            // 
            colQuantiteCommande.DataPropertyName = "Quantite";
            colQuantiteCommande.HeaderText = "Quantité";
            colQuantiteCommande.MinimumWidth = 6;
            colQuantiteCommande.Name = "colQuantiteCommande";
            // 
            // colEmballe
            // 
            colEmballe.HeaderText = "Emballé";
            colEmballe.MinimumWidth = 6;
            colEmballe.Name = "colEmballe";
            colEmballe.Resizable = DataGridViewTriState.True;
            colEmballe.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Emballage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(721, 577);
            Controls.Add(tlpEmballage);
            MinimumSize = new Size(739, 624);
            Name = "Emballage";
            Text = "Emballage";
            Load += Emballage_Load;
            tlpEmballage.ResumeLayout(false);
            tlpEmballage.PerformLayout();
            tcEmballage.ResumeLayout(false);
            tpEmballage.ResumeLayout(false);
            tlpPreparation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmballage).EndInit();
            tpCommande.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCommande).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsEmballage).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCommande).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblStock;
        private TableLayoutPanel tlpEmballage;
        private TabControl tcEmballage;
        private TabPage tpEmballage;
        private TableLayoutPanel tlpPreparation;
        private DataGridView dgvEmballage;
        private Button btnEmballage;
        private TabPage tpCommande;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnValiderCommande;
        private Button btnAnnulerCommande;
        private DataGridView dgvCommande;
        private BindingSource bsEmballage;
        private BindingSource bsCommande;
        private DataGridViewTextBoxColumn colIdEmballage;
        private DataGridViewTextBoxColumn colDateEmballage;
        private DataGridViewTextBoxColumn colNbArticlesEmballage;
        private DataGridViewTextBoxColumn colQuantiteTotaleEmballage;
        private DataGridViewTextBoxColumn colNomProduitCommande;
        private DataGridViewTextBoxColumn colProduitIdCommande;
        private DataGridViewTextBoxColumn colQuantiteCommande;
        private DataGridViewCheckBoxColumn colEmballe;
    }
}