using WinForms_Jalon_2.Service;
using WinForms_Jalon_2.Service.Api;
using WinForms_Jalon_2.Service.DTO.Reponses;
using WinForms_Jalon_2.Service.DTO.Requetes;

namespace WinForms_Jalon_2
{
    public partial class Authentification : Form
    {
        private readonly ServiceApi _serviceApi;

        public Authentification()
        {
            InitializeComponent();
            _serviceApi = new ServiceApi();
        }

        private async void btnConnexion_Click(object sender, EventArgs e)
        {
            AuthentificationDTORequete requete = new AuthentificationDTORequete();
            {
            requete.Login = tbLogin.Text;
            requete.Password = tbPassword.Text;
            };

           bool reponse = await _serviceApi.Login(requete.Login, requete.Password);

            if (!reponse)
                return;

            OuvrirFenetre();
        }

        #region Méthode

        private void OuvrirFenetre()
        {
            EmployeConnecte employeConnecte = _serviceApi.EmployeConnecte;

            switch (employeConnecte.Role)
            {
                case "PreparateurColis":
                    Emballage emballage = new Emballage(_serviceApi);

                    Hide();
                    emballage.ShowDialog();
                    Close();
                    break;

                case "Magasinier":
                case "Manager":
                    Stock stock = new Stock(_serviceApi);

                    Hide();
                    stock.ShowDialog();
                    Close();
                    break;

                default:
                    MessageBox.Show($"Rôle inconnu : {employeConnecte.Role}");
                    break;
            }
        }

        #endregion
    }
}
