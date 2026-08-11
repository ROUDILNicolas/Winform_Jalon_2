using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Jalon_2.Service.DTO.Requetes;
using WinForms_Jalon_2.Service.DTO.Reponses;
using System.Net.Http.Json;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using WinForms_Jalon_2.Service.Api;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Net.Http.Headers;

namespace WinForms_Jalon_2.Service
{
    public class ServiceApi
    {

        private readonly HttpClient client = new();
        private readonly GestionnaireErreurApi gestionnaireErreurApi = new();
        private EmployeConnecte employeConnecte = new EmployeConnecte();

        public EmployeConnecte EmployeConnecte => employeConnecte;

        public ServiceApi()
        {
            client.BaseAddress = new Uri("http://localhost:5220/api/");
            client.Timeout = TimeSpan.FromSeconds(10);
        }

        private void LireToken(string accessToken)
        {
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            JwtSecurityToken token = handler.ReadJwtToken(accessToken);

            employeConnecte.Login = token.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.NameIdentifier || claim.Type == JwtRegisteredClaimNames.Sub || claim.Type == "sub")?.Value;

            employeConnecte.Role = token.Claims.FirstOrDefault(claim => claim.Type == ClaimTypes.Role || claim.Type == "role")?.Value;
        }

        private void SetAccessToken(string accessToken)
        {
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            LireToken(accessToken);
        }

        public bool IsLogged()
        {
            return client.DefaultRequestHeaders.Authorization is not null;
        }

        public void LogOut()
        {
            client.DefaultRequestHeaders.Authorization = null;
        }

        public async Task<bool> Login(string username, string password, CancellationToken cancellationToken = default)
        {
            AuthentificationDTORequete authentificationDTORequete = new()
                {
                    Login = username,
                    Password = password
                };

            try
            {
                HttpResponseMessage reponse = await client.PostAsJsonAsync("Employe", authentificationDTORequete, cancellationToken);

                if (!reponse.IsSuccessStatusCode)
                {
                    await gestionnaireErreurApi.GererErreurHttpAsync(reponse);
                    return false;
                }

                AuthentificationDTOReponse? dto = await reponse.Content.ReadFromJsonAsync<AuthentificationDTOReponse>(cancellationToken);

                if (dto is null || string.IsNullOrWhiteSpace(dto.access_token))
                {
                    MessageBox.Show("La réponse d'authentification est invalide.", "Erreur");

                    return false;
                }

                SetAccessToken(dto.access_token);

                return true;
            }
            catch (Exception ex)
            {
                gestionnaireErreurApi.GererException(ex);
                return false;
            }
        }

        public async Task<T?> GetAsync<T>( string route, CancellationToken cancellationToken = default)
        {
            try
            {
                HttpResponseMessage reponse = await client.GetAsync(route, cancellationToken);

                if (!reponse.IsSuccessStatusCode)
                {
                    await gestionnaireErreurApi.GererErreurHttpAsync(reponse);
                    return default;
                }

                return await reponse.Content.ReadFromJsonAsync<T>(cancellationToken);
            }
            catch (Exception ex)
            {
                gestionnaireErreurApi.GererException(ex);
                return default;
            }
        }
    }
}
