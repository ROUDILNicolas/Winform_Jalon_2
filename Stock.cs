using Microsoft.VisualBasic;
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
using WinForms_Jalon_2.Service.DTO.Enums;
using WinForms_Jalon_2.Service.DTO.Reponses;

namespace WinForms_Jalon_2
{
    public partial class Stock : Form
    {
        //données non charger des dgvs
        private bool datagridviewloadStock;
        private bool datagridviewloadListPrep;
        private bool datagridviewloadCmdStatut;
        private int? _commandeEnCoursId;
        private int _commandeEnCoursVersion;

        private readonly EmployeConnecte _employeConnecte;
        private readonly ProduitApiClient _produitApiClient;
        private readonly CommandeApiClient _commandeApiClient;

        private BindingList<GetProduitsItemDTOReponse> _produits;
        private BindingList<GetCommandesItemDTOReponse> _commandesListePrep;
        private BindingList<GetLignesCommandeDTOReponse> _lignesCommandePrep;
        private BindingList<GetCommandesItemDTOReponse> _commandesCmdStatut;

        private List<GetCommandesItemDTOReponse> _toutesCommandesCmdStatut;

        private int _indexLigne = -1;

        public Stock(ServiceApi serviceApi)
        {
            InitializeComponent();

            _employeConnecte = serviceApi.EmployeConnecte;
            _produitApiClient = new ProduitApiClient(serviceApi);
            _commandeApiClient = new CommandeApiClient(serviceApi);

            InitializeBinding();
            ConfigurerInterface();

        }
        private void InitializeBinding()
        {
            InitializeBindingStock();
            InitializeBindingEnPreparation();
            InitializeBindingPreparation();
            InitializeBindingCmdStatut();
        }
        #region InitializeBindings


        private void InitializeBindingStock()
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

        private void InitializeBindingEnPreparation()
        {
            dgvListePrep.AutoGenerateColumns = false;

            dgvListePrep.DefaultCellStyle.SelectionBackColor = dgvListePrep.DefaultCellStyle.BackColor;

            dgvListePrep.DefaultCellStyle.SelectionForeColor = dgvListePrep.DefaultCellStyle.ForeColor;

            dgvListePrep.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;

            dgvListePrep.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;

            dgvListePrep.BackgroundColor = Color.White;

            _commandesListePrep =
                new BindingList<GetCommandesItemDTOReponse>();

            bsCommandesAPrep.DataSource = _commandesListePrep;
            dgvListePrep.DataSource = bsCommandesAPrep;


        }

        private void InitializeBindingPreparation()
        {
            dgvPrep.AutoGenerateColumns = false;

            dgvPrep.DefaultCellStyle.SelectionBackColor = dgvPrep.DefaultCellStyle.BackColor;

            dgvPrep.DefaultCellStyle.SelectionForeColor = dgvPrep.DefaultCellStyle.ForeColor;

            dgvPrep.BackgroundColor = Color.White;

            _lignesCommandePrep = new BindingList<GetLignesCommandeDTOReponse>();

            bsPreparation.DataSource = _lignesCommandePrep;

            dgvPrep.DataSource = bsPreparation;
        }

        private void InitializeBindingCmdStatut()
        {
            dgvCmdStatut.AutoGenerateColumns = false;

            dgvCmdStatut.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;

            dgvCmdStatut.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;

            dgvCmdStatut.BackgroundColor = Color.White;

            _toutesCommandesCmdStatut = new List<GetCommandesItemDTOReponse>();

            _commandesCmdStatut = new BindingList<GetCommandesItemDTOReponse>();

            bsCmdStatut.DataSource = _commandesCmdStatut;
            dgvCmdStatut.DataSource = bsCmdStatut;

            //Renomme les Statut de la combobox filtre
            InitialiserComboBoxStatut(cbFiltreStatut, true);

            InitialiserComboBoxStatut(cbModifierStatut, false);
        }
        #endregion

        #region Méthode
        private void btnCRUD_Click(object sender, EventArgs e)
        {
            tlpFormulaire.Visible = !tlpFormulaire.Visible;
        }
        private void _produits_ListChanged(object? sender, ListChangedEventArgs e)
        {
            Console.WriteLine(e);
        }

        private void ConfigurerInterface()
        {
            if (_employeConnecte.Role == "Magasinier")
            {
                btnSupprimer.Enabled = false;

                tcStock.TabPages.Remove(tpCmdStatut);
            }
        }

        private void VerifierPreparationComplete()
        {
            foreach (DataGridViewRow row in dgvPrep.Rows)
            {
                bool recupere = (bool)row.Cells["colRecupere"].Value;

                if (!recupere)
                {
                    btnValiderPrep.Enabled = false;
                    return;
                }
            }

            btnValiderPrep.Enabled = true;
        }

        private void FiltrerCommandesManager()
        {
            IEnumerable<GetCommandesItemDTOReponse> commandes = _toutesCommandesCmdStatut;

            if (cbFiltreStatut.SelectedItem is not StatutComboBoxItem item)
            {
                return;
            }

            if (item.Statut is StatutCommande statut)
            {
                commandes = commandes.Where(c => c.Statut == statut);
            }
            else
            {
                commandes = commandes.Where(
                    c => c.Statut != StatutCommande.Archiver);
            }

            commandes = commandes.OrderBy(c => c.Date);

            _commandesCmdStatut.Clear();

            foreach (GetCommandesItemDTOReponse commande in commandes)
            {
                _commandesCmdStatut.Add(commande);
            }
        }

        private string ObtenirLibelleStatut(StatutCommande statut)
        {
            return statut switch
            {
                StatutCommande.EnPreparation => "En préparation",
                StatutCommande.AEmballer => "À emballer",
                StatutCommande.EnAttenteEnvoi => "En attente d'envoi",
                StatutCommande.EnCoursEnvoi => "En cours d'envoi",
                StatutCommande.Delivre => "Livrée",
                StatutCommande.Bloque => "Bloquée",
                StatutCommande.Archiver => "Archivée",
                _ => statut.ToString()
            };
        }

        private void InitialiserComboBoxStatut(ComboBox comboBox, bool avecTousSaufArchivees)
        {
            comboBox.Items.Clear();

            if (avecTousSaufArchivees)
            {
                comboBox.Items.Add(new StatutComboBoxItem
                {
                    Libelle = "Tous sauf archivées",
                    Statut = null
                });
            }

            foreach (StatutCommande statut in Enum.GetValues<StatutCommande>())
            {
                comboBox.Items.Add(new StatutComboBoxItem
                {
                    Libelle = ObtenirLibelleStatut(statut),
                    Statut = statut
                });
            }

            comboBox.SelectedIndex = avecTousSaufArchivees ? 0 : -1;
        }
        #endregion


        private async void Stock_Load(object sender, EventArgs e)
        {
            await ChargertpStockAsync();
        }

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

        private void dgvStock_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
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

        private async void tpStock_Selected(object sender, TabControlEventArgs e)
        {
            if (tcStock.SelectedTab == tpStock)
            {
                await ChargertpStockAsync();
            }
            else if (tcStock.SelectedTab == tpListePrep)
            {
                await ChargertpListPrepAsync();
            }

            else if (tcStock.SelectedTab == tpCmdStatut)
            {
                await ChargertpCmdStatutAsync();
            }
        }


        #region Chargement Tab Pages
        private async Task ChargertpStockAsync()
        {
            if (datagridviewloadStock)
                return;

            // Appel API pour Stock

            GetProduitsDTOReponse? reponse =
            await _produitApiClient.GetProduitsAsync(CancellationToken.None);

            if (reponse is null)
            {
                return;
            }

            // Remplir BindingList Stock

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


            datagridviewloadStock = true;
        }

        private async Task ChargertpListPrepAsync()
        {
            if (datagridviewloadListPrep)
                return;

            // Appel API pour A;

            GetCommandesDTOReponse? reponse =
                await _commandeApiClient.GetCommandesEnPreparationAsync(CancellationToken.None);

            if (reponse is null)
                return;

            _commandesListePrep.Clear();

            foreach (GetCommandesItemDTOReponse commande in reponse.Commandes)
            {
                _commandesListePrep.Add(commande);
            }

            datagridviewloadListPrep = true;
            // Remplir BindingList A
        }

        private async Task ChargertpPrepAsync(int commandeId)
        {
            GetCommandeParIdDTOReponse? reponse =
                await _commandeApiClient.GetCommandesParIdAsync(
                    commandeId,
                    CancellationToken.None);

            if (reponse is null)
            {
                return;
            }

            // Mémorise la commande en cours
            _commandeEnCoursId = reponse.Id;
            _commandeEnCoursVersion = reponse.Version;

            // Charge les lignes
            _lignesCommandePrep.Clear();

            foreach (GetLignesCommandeDTOReponse ligne in reponse.LignesCommande)
            {
                _lignesCommandePrep.Add(ligne);
            }

            // Ouvre l'onglet préparation
            tcStock.SelectedTab = tpPrep;

            // Initialise les checkbox
            foreach (DataGridViewRow row in dgvPrep.Rows)
            {
                row.Cells["colRecupere"].Value = false;
            }

            btnValiderPrep.Enabled = false;
        }

        private async Task ChargertpCmdStatutAsync()
        {
            if (datagridviewloadCmdStatut)
            {
                return;
            }

            GetCommandesDTOReponse? reponse =
                await _commandeApiClient.GetCommandesGestionManagerAsync(
                    CancellationToken.None);

            if (reponse is null)
            {
                return;
            }

            _toutesCommandesCmdStatut.Clear();
            _toutesCommandesCmdStatut.AddRange(reponse.Commandes);

            FiltrerCommandesManager();

            datagridviewloadCmdStatut = true;
        }
        #endregion

        private async void btnPreparer_Click(object sender, EventArgs e)
        {
            if (dgvListePrep.CurrentRow?.DataBoundItem
                is not GetCommandesItemDTOReponse commande)
            {
                MessageBox.Show(
                    "Veuillez sélectionner une commande.",
                    "Préparation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            await ChargertpPrepAsync(commande.Id);
        }

        private void tcStock_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (-_commandeEnCoursId is not null && e.TabPage == tpListePrep)
            {
                e.Cancel = true;

                MessageBox.Show("Une commande est actuellement en préparation.\n" + "Vous devez la valider ou annuler avant de revenir à la liste.", "Préparation en cours", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvPrep_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvPrep.IsCurrentCellDirty)
            {
                dgvPrep.CommitEdit(
                    DataGridViewDataErrorContexts.Commit
                );
            }
        }

        private void dgvPrep_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvPrep.Columns[e.ColumnIndex].Name == "colRecupere")
            {
                VerifierPreparationComplete();
            }
        }

        private async void btnValiderPrep_Click(object sender, EventArgs e)
        {
            if (_commandeEnCoursId is null)
            {
                return;
            }

            bool resultat = await _commandeApiClient.PasserCommandeAEmballerAsync(_commandeEnCoursId.Value, _commandeEnCoursVersion, CancellationToken.None);

            if (!resultat)
            {
                return;
            }

            GetCommandesItemDTOReponse? commande =
                _commandesListePrep.FirstOrDefault(
                    c => c.Id == _commandeEnCoursId.Value);

            if (commande is not null)
            {
                _commandesListePrep.Remove(commande);
            }

            _lignesCommandePrep.Clear();

            _commandeEnCoursId = null;
            _commandeEnCoursVersion = 0;

            btnValiderPrep.Enabled = false;

            tcStock.SelectedTab = tpListePrep;
        }

        private void btnAnnulerPrep_Click(object sender, EventArgs e)
        {
            if (_commandeEnCoursId is null)
            {
                return;
            }

            DialogResult resultat = MessageBox.Show(
                "Voulez-vous annuler la préparation de cette commande ?",
                "Annuler la préparation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultat != DialogResult.Yes)
            {
                return;
            }

            _lignesCommandePrep.Clear();

            _commandeEnCoursId = null;
            _commandeEnCoursVersion = 0;

            btnValiderPrep.Enabled = false;

            datagridviewloadListPrep = false;

            tcStock.SelectedTab = tpListePrep;
        }

        private void cbFiltreStatut_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_toutesCommandesCmdStatut is null)
            {
                return;
            }

            FiltrerCommandesManager();
        }

        private async void btnModifierStatut_Click(object sender, EventArgs e)
        {
            if (dgvCmdStatut.CurrentRow?.DataBoundItem is not GetCommandesItemDTOReponse commande)
            {
                MessageBox.Show(
                    "Veuillez sélectionner une commande.",
                    "Modification du statut",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            if (cbModifierStatut.SelectedItem
                is not StatutComboBoxItem item
                || item.Statut is null)
            {
                MessageBox.Show(
                    "Veuillez sélectionner un nouveau statut.",
                    "Modification du statut",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            StatutCommande nouveauStatut = item.Statut.Value;

            // Évite de modifier vers le même statut
            if (commande.Statut == nouveauStatut)
            {
                MessageBox.Show(
                    "La commande possède déjà ce statut.",
                    "Modification du statut",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            // Demande confirmation
            DialogResult confirmation = MessageBox.Show(
                $"Commande n°{commande.Id}\n\n" +
                $"{ObtenirLibelleStatut(commande.Statut)} → {ObtenirLibelleStatut(nouveauStatut)}\n\n" +
                "Confirmer la modification ?",
                "Modification du statut",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            // Appel API
            ModifierStatutCommandeDTOReponse? reponse = await _commandeApiClient.ModifierStatutCommandeAsync(commande.Id, nouveauStatut, commande.Version, CancellationToken.None);

            if (reponse is null)
            {
                return;
            }

            // Mise à jour locale avec ce que l'API a réellement enregistré
            commande.Statut = reponse.Statut;
            commande.Version = reponse.Version;

            // Réapplique le filtre actuel
            FiltrerCommandesManager();

            // Vide la ComboBox de modification
            cbModifierStatut.SelectedIndex = -1;

            MessageBox.Show(
                $"La commande n°{reponse.Id} est maintenant " +
                $"« {ObtenirLibelleStatut(reponse.Statut)} ».",
                "Statut modifié",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void dgvCmdStatut_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCmdStatut.Columns[e.ColumnIndex].DataPropertyName == "Statut" && e.Value is StatutCommande statut)
            {
                e.Value = ObtenirLibelleStatut(statut);
                e.FormattingApplied = true;
            }
        }

        private void tlpSelectStatut_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
