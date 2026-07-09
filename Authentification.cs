using WinForms_Jalon_2.Service;

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
            string login = tbLogin.Text;
            string password = tbPassword.Text;

           bool connecter = await _serviceApi.Login(login, password);
        }
    }
}
