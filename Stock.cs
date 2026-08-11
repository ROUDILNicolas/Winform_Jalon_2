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
    public partial class Stock : Form
    {
        private readonly EmployeConnecte _employeConnecte;
        private readonly ProduitApiClient _produitApiClient;

        BindingList<GetProduitsItemDTOReponse> _produits;

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
        }

        #endregion
    }
}
