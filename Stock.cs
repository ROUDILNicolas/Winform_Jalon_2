using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_Jalon_2.Service;
using WinForms_Jalon_2.Service.Api;
using WinForms_Jalon_2.Service.DTO.Reponses;

namespace WinForms_Jalon_2
{
    public partial class Stock : Form
    {
        private readonly EmployeConnecte _employeConnecte;
        private readonly ProduitApiClient _produitApiClient;

        private BindingList<GetProduitsItemDTOReponse> _produits;

        private int _indexLigne = -1;

        public Stock(ServiceApi serviceApi)
        {
            InitializeComponent();

            _employeConnecte = serviceApi.EmployeConnecte;
            _produitApiClient = new ProduitApiClient(serviceApi);

            InitializeBinding();
            ConfigurerInterface();

        }



        private void btnCRUD_Click(object sender, EventArgs e)
        {
            tlpFormulaire.Visible = !tlpFormulaire.Visible;
        }

        #region Méthode
        private void _produits_ListChanged(object? sender, ListChangedEventArgs e)
        {
            Console.WriteLine(e);
        }

        private void InitializeBinding()
        {
            dgvStock.AutoGenerateColumns = false;
            
            dgvStock.DefaultCellStyle.SelectionBackColor = dgvStock.DefaultCellStyle.BackColor;

            dgvStock.DefaultCellStyle.SelectionForeColor = dgvStock.DefaultCellStyle.ForeColor;

            dgvStock.BackgroundColor = Color.White;

            _produits = new BindingList<GetProduitsItemDTOReponse>();

            _produits.ListChanged += _produits_ListChanged;
            bsProduit.DataSource = _produits;
            dgvStock.DataSource = bsProduit;


        }

        private void ConfigurerInterface()
        {
            if (_employeConnecte.Role == "Magasinier")
            {
                btnSupprimer.Enabled = false;

                tpStock.TabPages.Remove(tpCmdStatut);
            }
        }
        private async void Stock_Load(object sender, EventArgs e)
        {
            GetProduitsDTOReponse? reponse =
            await _produitApiClient.GetProduitsAsync(CancellationToken.None);

            if (reponse is null)
            {
                return;
            }

            _produits.Clear();

            foreach (GetProduitsItemDTOReponse produit in reponse.Produits)
            {
                _produits.Add(produit);
            }

            _produits.Clear();

            foreach (GetProduitsItemDTOReponse produit in reponse.Produits)
            {
                _produits.Add(produit);
            }

            foreach (DataGridViewRow row in dgvStock.Rows)
            {
                row.Height = 30;
                row.Cells["colDetails"].Value = "▼";
            }
        }

        #endregion

        private void dgvStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                if (e.RowIndex < 0 || e.ColumnIndex < 0)
                {
                    return;
                }

                if (dgvStock.Columns[e.ColumnIndex].Name != "colDetails")
                {
                    return;
                }

                // Si je clique sur la ligne déjà ouverte
                if (_indexLigne == e.RowIndex)
                {
                    dgvStock.Rows[e.RowIndex].Height = 30;

                    dgvStock.Rows[e.RowIndex].DefaultCellStyle.Padding =
                        new Padding(0);

                    dgvStock.Rows[e.RowIndex].Cells["colDetails"].Value = "▼";

                    _indexLigne = -1;

                    dgvStock.Invalidate();

                    return;
                }

                // Si une autre ligne était déjà ouverte
                if (_indexLigne >= 0)
                {
                    dgvStock.Rows[_indexLigne].Height = 30;

                    dgvStock.Rows[_indexLigne].DefaultCellStyle.Padding = new Padding(0);

                    dgvStock.Rows[_indexLigne].Cells["colDetails"].Value = "▼";
                }

                // J'enregistre la nouvelle ligne ouverte
                _indexLigne = e.RowIndex;

                dgvStock.Rows[e.RowIndex].Height = 100;

                dgvStock.Rows[e.RowIndex].DefaultCellStyle.Padding =
                    new Padding(0, 0, 0, 65);

                dgvStock.Rows[e.RowIndex].Cells["colDetails"].Value = "▲";

                dgvStock.Invalidate();
            }
        }

        private void dgvStock_RowPostPaint( object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (e.RowIndex != _indexLigne)
            {
                return;
            }

            GetProduitsItemDTOReponse? produit =
                dgvStock.Rows[e.RowIndex].DataBoundItem
                as GetProduitsItemDTOReponse;

            if (produit is null)
            {
                return;
            }

            Rectangle celluleNom = dgvStock.GetCellDisplayRectangle(
                dgvStock.Columns["colNom"].Index,
                e.RowIndex,
                true
            );

            int debutNom = celluleNom.Left + 5;

            Rectangle zoneDetails = new Rectangle(
                e.RowBounds.Left,
                e.RowBounds.Top + 30,
                e.RowBounds.Width,
                e.RowBounds.Height - 30
            );

            // Fond blanc pour masquer les séparations des colonnes
            e.Graphics.FillRectangle(
                SystemBrushes.Window,
                zoneDetails
            );

            // Ligne de séparation entre les infos principales et les détails
            e.Graphics.DrawLine(
                SystemPens.ControlDark,
                zoneDetails.Left,
                zoneDetails.Top,
                zoneDetails.Right,
                zoneDetails.Top
            );

            int margeGauche = 25;

            Rectangle zonePrixAchat = new Rectangle(
                debutNom,
                zoneDetails.Top + 10,
                250,
                25
            );

            Rectangle zonePrixVente = new Rectangle(
                debutNom + 300,
                zoneDetails.Top + 10,
                250,
                25
            );

            Rectangle zoneDescription = new Rectangle(
                debutNom,
                zoneDetails.Top + 45,
                zoneDetails.Right - debutNom - 20,
                zoneDetails.Height - 50
            );

            TextRenderer.DrawText(
                e.Graphics,
                $"Prix achat : {produit.PrixAchat:0.00} €",
                dgvStock.Font,
                zonePrixAchat,
                dgvStock.ForeColor,
                TextFormatFlags.Left |
                TextFormatFlags.Top
            );

            TextRenderer.DrawText(
                e.Graphics,
                $"Prix vente : {produit.PrixVente:0.00} €",
                dgvStock.Font,
                zonePrixVente,
                dgvStock.ForeColor,
                TextFormatFlags.Left |
                TextFormatFlags.Top
            );

            TextRenderer.DrawText(
                e.Graphics,
                $"Description : {produit.Description}",
                dgvStock.Font,
                zoneDescription,
                dgvStock.ForeColor,
                TextFormatFlags.Left |
                TextFormatFlags.Top |
                TextFormatFlags.WordBreak
            );
        }
    }
}
