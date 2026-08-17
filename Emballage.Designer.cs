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
            tlpEmballage = new TableLayoutPanel();
            tbPreparation = new TabPage();
            tlpPreparation = new TableLayoutPanel();
            btnEmballage = new Button();
            dataGridView2 = new DataGridView();
            tpEmballage = new TabControl();
            tableLayoutPanel2 = new TableLayoutPanel();
            dgvCommande = new DataGridView();
            btnAnnulerCommande = new Button();
            btnValiderCommande = new Button();
            tpCommande = new TabPage();
            tlpEmballage.SuspendLayout();
            tbPreparation.SuspendLayout();
            tlpPreparation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tpEmballage.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCommande).BeginInit();
            tpCommande.SuspendLayout();
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
            // tlpEmballage
            // 
            tlpEmballage.BackColor = SystemColors.Control;
            tlpEmballage.ColumnCount = 3;
            tlpEmballage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.617811F));
            tlpEmballage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 92.76438F));
            tlpEmballage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.617809F));
            tlpEmballage.Controls.Add(tpEmballage, 1, 1);
            tlpEmballage.Controls.Add(lblStock, 1, 0);
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
            tlpPreparation.TabIndex = 1;
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
            // tpEmballage
            // 
            tpEmballage.Controls.Add(tbPreparation);
            tpEmballage.Controls.Add(tpCommande);
            tpEmballage.Dock = DockStyle.Fill;
            tpEmballage.Location = new Point(43, 49);
            tpEmballage.Name = "tpEmballage";
            tpEmballage.SelectedIndex = 0;
            tpEmballage.Size = new Size(1019, 475);
            tpEmballage.TabIndex = 0;
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
            tableLayoutPanel2.Size = new Size(1005, 436);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // dgvCommande
            // 
            dgvCommande.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel2.SetColumnSpan(dgvCommande, 2);
            dgvCommande.Dock = DockStyle.Fill;
            dgvCommande.Location = new Point(3, 3);
            dgvCommande.Name = "dgvCommande";
            dgvCommande.RowHeadersWidth = 51;
            dgvCommande.Size = new Size(999, 356);
            dgvCommande.TabIndex = 6;
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
            // Emballage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 577);
            Controls.Add(tlpEmballage);
            Name = "Emballage";
            Text = "Emballage";
            tlpEmballage.ResumeLayout(false);
            tlpEmballage.PerformLayout();
            tbPreparation.ResumeLayout(false);
            tlpPreparation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tpEmballage.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCommande).EndInit();
            tpCommande.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblStock;
        private TableLayoutPanel tlpEmballage;
        private TabControl tpEmballage;
        private TabPage tbPreparation;
        private TableLayoutPanel tlpPreparation;
        private DataGridView dataGridView2;
        private Button btnEmballage;
        private TabPage tpCommande;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnValiderCommande;
        private Button btnAnnulerCommande;
        private DataGridView dgvCommande;
    }
}