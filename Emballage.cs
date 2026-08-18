using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_Jalon_2.Service;
using WinForms_Jalon_2.Service.Api;
using WinForms_Jalon_2.Service.DTO.Reponses;

namespace WinForms_Jalon_2
{
    public partial class Emballage : Form
    {

        //données non charger des dgvs
        private bool datagridviewloadEmballage;
        private bool datagridviewloadCommande;
        private int? _commandeEnCoursId;
        private int _commandeEnCoursVersion;

        private readonly CommandeApiClient _commandeApiClient;
        private readonly EmployeConnecte _employeConnecte;

        private BindingList<GetCommandesItemDTOReponse> _commandeEmballage;
        private BindingList<GetLignesCommandeDTOReponse> _lignesCommandeEmballage;



        public Emballage(ServiceApi serviceApi)
        {
            InitializeComponent();

            _employeConnecte = serviceApi.EmployeConnecte;
            _commandeApiClient = new CommandeApiClient(serviceApi);

            InitializeBinding();
        }

        private void InitializeBinding()
        {
            InitializeBindingEmballage();
            InitializeBindingCommande();
        }

        private void InitializeBindingEmballage()
        {
            dgvEmballage.AutoGenerateColumns = false;

            dgvEmballage.DefaultCellStyle.SelectionBackColor = dgvEmballage.DefaultCellStyle.BackColor;

            dgvEmballage.DefaultCellStyle.SelectionForeColor = dgvEmballage.DefaultCellStyle.ForeColor;

            dgvEmballage.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;

            dgvEmballage.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;

            dgvEmballage.BackgroundColor = Color.White;

            _commandeEmballage = new BindingList<GetCommandesItemDTOReponse>();

            bsEmballage.DataSource = _commandeEmballage;
            dgvEmballage.DataSource = bsEmballage;
        }

        private void InitializeBindingCommande()
        {
            dgvCommande.AutoGenerateColumns = false;

            dgvCommande.DefaultCellStyle.SelectionBackColor = dgvCommande.DefaultCellStyle.BackColor;

            dgvCommande.DefaultCellStyle.SelectionForeColor = dgvCommande.DefaultCellStyle.ForeColor;

            dgvCommande.BackgroundColor = Color.White;

            _lignesCommandeEmballage = new BindingList<GetLignesCommandeDTOReponse>();

            bsCommande.DataSource = _lignesCommandeEmballage;

            dgvCommande.DataSource = bsCommande;
        }
        #region Methode
        private void VerifierEmballageComplet()
        {
            // Parcourt toutes les lignes de la commande.
            foreach (DataGridViewRow row in dgvCommande.Rows)
            {
                // Récupère la valeur true/false de la checkbox.
                bool emballe = (bool)row.Cells["colEmballe"].Value;

                // Si au moins un produit n'est pas encore emballé...
                if (!emballe)
                {
                    // ...on interdit la validation de la commande.
                    btnValiderCommande.Enabled = false;

                    // Inutile de continuer à vérifier les autres lignes.
                    return;
                }
            }

            // Si on arrive ici, aucune checkbox n'était à false :
            // tous les produits sont donc emballés.
            btnValiderCommande.Enabled = true;
        }
        #endregion

        #region Chargement Tab Pages
        private async Task ChargertpEmballageAsync()
        {
            if (datagridviewloadEmballage)
                return;

            // Appel API pour A;

            GetCommandesDTOReponse? reponse =
                await _commandeApiClient.GetCommandesAEmballerAsync(CancellationToken.None);

            if (reponse is null)
                return;

            _commandeEmballage.Clear();

            foreach (GetCommandesItemDTOReponse commande in reponse.Commandes)
            {
                _commandeEmballage.Add(commande);
            }

            datagridviewloadEmballage = true;
            // Remplir BindingList A
        }

        private async Task ChargertpCommandeAsync(int commandeId)
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
            _lignesCommandeEmballage.Clear();

            foreach (GetLignesCommandeDTOReponse ligne in reponse.LignesCommande)
            {
                _lignesCommandeEmballage.Add(ligne);
            }

            // Ouvre l'onglet préparation
            tcEmballage.SelectedTab = tpCommande;

            // Initialise les checkbox
            foreach (DataGridViewRow row in dgvCommande.Rows)
            {
                row.Cells["colEmballe"].Value = false;
            }

            btnValiderCommande.Enabled = false;
        }
        #endregion

        private async void Emballage_Load(object sender, EventArgs e)
        {
            await ChargertpEmballageAsync();
        }

        private async void tpEmballage_Selected(object sender, TabControlEventArgs e)
        {
            if (tcEmballage.SelectedTab == tpEmballage)
            {
                await ChargertpEmballageAsync();
            }
        }

        private async void btnEmballage_Click(object sender, EventArgs e)
        {
            if (dgvEmballage.CurrentRow?.DataBoundItem is not GetCommandesItemDTOReponse commande)
            {
                MessageBox.Show(
                    "Veuillez sélectionner une commande.",
                    "Emballage",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            await ChargertpCommandeAsync(commande.Id);
        }

        private void dgvCommande_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvCommande.IsCurrentCellDirty)
            {
                // Force la validation immédiate de la nouvelle valeur
                // pour que false/true soit pris en compte tout de suite.
                dgvCommande.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvCommande_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvCommande.Columns[e.ColumnIndex].Name == "colEmballe")
            {
                VerifierEmballageComplet();
            }
        }

        private async void btnValiderCommande_Click(object sender, EventArgs e)
        {
            // Vérifie qu'une commande est bien en cours de traitement
            if (_commandeEnCoursId is null)
            {
                return;
            }

            // Demande à l'API de passer la commande à EnAttenteEnvoi
            bool resultat =
                await _commandeApiClient.PasserCommandeEnAttenteEnvoiAsync(
                    _commandeEnCoursId.Value,
                    _commandeEnCoursVersion,
                    CancellationToken.None);

            // Si l'appel API a échoué, on ne fait rien de plus
            if (!resultat)
            {
                return;
            }

            // Vide les lignes de la commande actuellement affichée
            _lignesCommandeEmballage.Clear();

            // Réinitialise la commande en cours
            _commandeEnCoursId = null;
            _commandeEnCoursVersion = 0;

            // Désactive le bouton jusqu'à la prochaine commande
            btnValiderCommande.Enabled = false;

            // Force le rechargement de la liste des commandes à emballer
            datagridviewloadEmballage = false;

            // Retourne sur la liste des commandes à emballer
            tcEmballage.SelectedTab = tpEmballage;
        }
    }
}
