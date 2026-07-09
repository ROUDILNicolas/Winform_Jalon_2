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
            lblStock = new Label();
            tpEmballage = new TabControl();
            tbPreparation = new TabPage();
            tlpPreparation = new TableLayoutPanel();
            dataGridView2 = new DataGridView();
            btnEmballage = new Button();
            tpColis = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            gbCarton = new GroupBox();
            dataGridView3 = new DataGridView();
            Produits = new GroupBox();
            dataGridView1 = new DataGridView();
            btnCarton = new Button();
            tpCommande = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnValiderCommande = new Button();
            btnModifierCarton = new Button();
            btnAnnulerCommande = new Button();
            dgvCommande = new DataGridView();
            tlpEmballage = new TableLayoutPanel();
            buttonTEST = new Button();
            tpEmballage.SuspendLayout();
            tbPreparation.SuspendLayout();
            tlpPreparation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tpColis.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            gbCarton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            Produits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tpCommande.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCommande).BeginInit();
            tlpEmballage.SuspendLayout();
            SuspendLayout();
            // 
            // lblStock
            // 
            lblStock.Anchor = AnchorStyles.None;
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblStock.Location = new Point(286, 0);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(533, 46);
            lblStock.TabIndex = 1;
            lblStock.Text = "Liste des commandes a emballer";
            lblStock.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tpEmballage
            // 
            tpEmballage.Controls.Add(tbPreparation);
            tpEmballage.Controls.Add(tpColis);
            tpEmballage.Controls.Add(tpCommande);
            tpEmballage.Dock = DockStyle.Fill;
            tpEmballage.Location = new Point(43, 49);
            tpEmballage.Name = "tpEmballage";
            tpEmballage.SelectedIndex = 0;
            tpEmballage.Size = new Size(1019, 475);
            tpEmballage.TabIndex = 0;
            // 
            // tbPreparation
            // 
            tbPreparation.Controls.Add(tlpPreparation);
            tbPreparation.Location = new Point(4, 29);
            tbPreparation.Name = "tbPreparation";
            tbPreparation.Padding = new Padding(3);
            tbPreparation.Size = new Size(1011, 442);
            tbPreparation.TabIndex = 1;
            tbPreparation.Text = "Emballage";
            tbPreparation.UseVisualStyleBackColor = true;
            // 
            // tlpPreparation
            // 
            tlpPreparation.ColumnCount = 2;
            tlpPreparation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpPreparation.ColumnStyles.Add(new ColumnStyle());
            tlpPreparation.Controls.Add(dataGridView2, 0, 0);
            tlpPreparation.Controls.Add(btnEmballage, 1, 1);
            tlpPreparation.Dock = DockStyle.Fill;
            tlpPreparation.Location = new Point(3, 3);
            tlpPreparation.Name = "tlpPreparation";
            tlpPreparation.RowCount = 2;
            tlpPreparation.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpPreparation.RowStyles.Add(new RowStyle());
            tlpPreparation.Size = new Size(1005, 436);
            tlpPreparation.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tlpPreparation.SetColumnSpan(dataGridView2, 2);
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(999, 333);
            dataGridView2.TabIndex = 0;
            // 
            // btnEmballage
            // 
            btnEmballage.Location = new Point(908, 342);
            btnEmballage.Name = "btnEmballage";
            btnEmballage.Size = new Size(94, 91);
            btnEmballage.TabIndex = 1;
            btnEmballage.Text = "Emballage";
            btnEmballage.UseVisualStyleBackColor = true;
            // 
            // tpColis
            // 
            tpColis.Controls.Add(tableLayoutPanel1);
            tpColis.Location = new Point(4, 29);
            tpColis.Name = "tpColis";
            tpColis.Padding = new Padding(3);
            tpColis.Size = new Size(1011, 442);
            tpColis.TabIndex = 2;
            tpColis.Text = "Colis";
            tpColis.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(gbCarton, 2, 0);
            tableLayoutPanel1.Controls.Add(Produits, 0, 0);
            tableLayoutPanel1.Controls.Add(btnCarton, 3, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1005, 436);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // gbCarton
            // 
            tableLayoutPanel1.SetColumnSpan(gbCarton, 2);
            gbCarton.Controls.Add(dataGridView3);
            gbCarton.Dock = DockStyle.Fill;
            gbCarton.Location = new Point(505, 3);
            gbCarton.Name = "gbCarton";
            gbCarton.Size = new Size(497, 356);
            gbCarton.TabIndex = 1;
            gbCarton.TabStop = false;
            gbCarton.Text = "Sélectionner Carton";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(3, 23);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 51;
            dataGridView3.Size = new Size(491, 330);
            dataGridView3.TabIndex = 0;
            // 
            // Produits
            // 
            tableLayoutPanel1.SetColumnSpan(Produits, 2);
            Produits.Controls.Add(dataGridView1);
            Produits.Dock = DockStyle.Fill;
            Produits.Location = new Point(3, 3);
            Produits.Name = "Produits";
            Produits.Size = new Size(496, 356);
            Produits.TabIndex = 0;
            Produits.TabStop = false;
            Produits.Text = "Sélectionner produits";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(490, 330);
            dataGridView1.TabIndex = 0;
            // 
            // btnCarton
            // 
            btnCarton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCarton.Location = new Point(848, 365);
            btnCarton.Name = "btnCarton";
            btnCarton.Size = new Size(154, 68);
            btnCarton.TabIndex = 2;
            btnCarton.Text = "Générer Carton";
            btnCarton.UseVisualStyleBackColor = true;
            // 
            // tpCommande
            // 
            tpCommande.Controls.Add(tableLayoutPanel2);
            tpCommande.Location = new Point(4, 29);
            tpCommande.Name = "tpCommande";
            tpCommande.Padding = new Padding(3);
            tpCommande.Size = new Size(1011, 442);
            tpCommande.TabIndex = 3;
            tpCommande.Text = "Commande";
            tpCommande.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(btnValiderCommande, 3, 1);
            tableLayoutPanel2.Controls.Add(btnModifierCarton, 2, 1);
            tableLayoutPanel2.Controls.Add(btnAnnulerCommande, 0, 1);
            tableLayoutPanel2.Controls.Add(dgvCommande, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(1005, 436);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnValiderCommande
            // 
            btnValiderCommande.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnValiderCommande.Location = new Point(848, 365);
            btnValiderCommande.Name = "btnValiderCommande";
            btnValiderCommande.Size = new Size(154, 68);
            btnValiderCommande.TabIndex = 3;
            btnValiderCommande.Text = "Valider";
            btnValiderCommande.UseVisualStyleBackColor = true;
            // 
            // btnModifierCarton
            // 
            btnModifierCarton.Location = new Point(505, 365);
            btnModifierCarton.Name = "btnModifierCarton";
            btnModifierCarton.Size = new Size(154, 68);
            btnModifierCarton.TabIndex = 4;
            btnModifierCarton.Text = "Modifier Carton";
            btnModifierCarton.UseVisualStyleBackColor = true;
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
            dgvCommande.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel2.SetColumnSpan(dgvCommande, 4);
            dgvCommande.Dock = DockStyle.Fill;
            dgvCommande.Location = new Point(3, 3);
            dgvCommande.Name = "dgvCommande";
            dgvCommande.RowHeadersWidth = 51;
            dgvCommande.Size = new Size(999, 356);
            dgvCommande.TabIndex = 6;
            // 
            // tlpEmballage
            // 
            tlpEmballage.BackColor = SystemColors.Control;
            tlpEmballage.ColumnCount = 3;
            tlpEmballage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.617811F));
            tlpEmballage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.76438F));
            tlpEmballage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.617809F));
            tlpEmballage.Controls.Add(tpEmballage, 1, 1);
            tlpEmballage.Controls.Add(lblStock, 1, 0);
            tlpEmballage.Controls.Add(buttonTEST, 2, 1);
            tlpEmballage.Dock = DockStyle.Fill;
            tlpEmballage.Location = new Point(0, 0);
            tlpEmballage.Name = "tlpEmballage";
            tlpEmballage.RowCount = 3;
            tlpEmballage.RowStyles.Add(new RowStyle());
            tlpEmballage.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpEmballage.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpEmballage.Size = new Size(1106, 577);
            tlpEmballage.TabIndex = 1;
            // 
            // buttonTEST
            // 
            buttonTEST.Location = new Point(1068, 49);
            buttonTEST.Name = "buttonTEST";
            buttonTEST.Size = new Size(35, 189);
            buttonTEST.TabIndex = 2;
            buttonTEST.Text = "TEST";
            buttonTEST.UseVisualStyleBackColor = true;
            buttonTEST.Click += buttonTEST_Click;
            // 
            // Emballage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 577);
            Controls.Add(tlpEmballage);
            Name = "Emballage";
            Text = "Emballage";
            tpEmballage.ResumeLayout(false);
            tbPreparation.ResumeLayout(false);
            tlpPreparation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tpColis.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            gbCarton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            Produits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tpCommande.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCommande).EndInit();
            tlpEmballage.ResumeLayout(false);
            tlpEmballage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblStock;
        private TabControl tpEmballage;
        private TabPage tbPreparation;
        private TableLayoutPanel tlpPreparation;
        private DataGridView dataGridView2;
        private Button btnEmballage;
        private TabPage tpColis;
        private TableLayoutPanel tlpEmballage;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox gbCarton;
        private GroupBox Produits;
        private Button btnCarton;
        private DataGridView dataGridView3;
        private DataGridView dataGridView1;
        private TabPage tpCommande;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnValiderCommande;
        private Button btnModifierCarton;
        private Button btnAnnulerCommande;
        private DataGridView dgvCommande;
        private Button buttonTEST;
    }
}