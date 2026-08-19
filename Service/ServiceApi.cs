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
            //client.Timeout = TimeSpan.FromSeconds(10);
            
            //En cas de test
            client.Timeout = TimeSpan.FromMinutes(5);
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

        /// <summary>
        /// Envoie une requête POST avec un contenu JSON.
        /// Retourne true si la requête HTTP a réussi, sinon false.
        /// À utiliser lorsque l'API ne renvoie pas d'objet dans la réponse.
        /// </summary>
        /// <typeparam name="T">Type de l'objet envoyé dans la requête.</typeparam>
        /// <param name="route">Route de l'endpoint API.</param>
        /// <param name="contenu">Objet à envoyer dans le body de la requête.</param>
        /// <param name="cancellationToken">Permet d'annuler la requête HTTP.</param>
        /// <returns>True si la requête a réussi, sinon false.</returns>
        public async Task<bool> PostAsync<T>(string route, T contenu, CancellationToken cancellationToken = default)
        {
            // Envoie la requête POST avec le contenu converti en JSON
            HttpResponseMessage reponse = await client.PostAsJsonAsync(route, contenu, cancellationToken);

            // Si l'API retourne une erreur HTTP
            if (!reponse.IsSuccessStatusCode)
            {
                // Gestion centralisée de l'erreur
                await gestionnaireErreurApi.GererErreurHttpAsync(reponse);
                return false;
            }

            // La requête s'est correctement exécutée
            return true;
        }

        /// <summary>
        /// Envoie une requête PUT avec un contenu JSON.
        /// Retourne true si la requête HTTP a réussi, sinon false.
        /// À utiliser lorsque l'API ne renvoie pas d'objet dans la réponse.
        /// </summary>
        /// <typeparam name="T">Type de l'objet envoyé dans la requête.</typeparam>
        /// <param name="route">Route de l'endpoint API.</param>
        /// <param name="contenu">Objet à envoyer dans le body de la requête.</param>
        /// <param name="cancellationToken">Permet d'annuler la requête HTTP.</param>
        /// <returns>True si la requête a réussi, sinon false.</returns>
        public async Task<bool> PutAsync<T>(string route, T contenu, CancellationToken cancellationToken = default)
        {
            // Envoie la requête PUT avec le contenu converti en JSON
            HttpResponseMessage reponse = await client.PutAsJsonAsync(route, contenu, cancellationToken);

            // Si l'API retourne une erreur HTTP
            if (!reponse.IsSuccessStatusCode)
            {
                // Gestion centralisée de l'erreur
                await gestionnaireErreurApi.GererErreurHttpAsync(reponse);
                return false;
            }

            // La requête s'est correctement exécutée
            return true;
        }

        /// <summary>
        /// Envoie une requête PATCH avec un contenu JSON.
        /// Retourne true si la requête HTTP a réussi, sinon false.
        /// À utiliser lorsque l'API ne renvoie pas d'objet dans la réponse.
        /// </summary>
        /// <typeparam name="T">Type de l'objet envoyé dans la requête.</typeparam>
        /// <param name="route">Route de l'endpoint API.</param>
        /// <param name="contenu">Objet à envoyer dans le body de la requête.</param>
        /// <param name="cancellationToken">Permet d'annuler la requête HTTP.</param>
        /// <returns>True si la requête a réussi, sinon false.</returns>
        public async Task<bool> PatchAsync<T>(string route,T contenu, CancellationToken cancellationToken = default)
        {
            // Envoie la requête PATCH avec le contenu converti en JSON
            HttpResponseMessage reponse = await client.PatchAsJsonAsync(route, contenu, cancellationToken);

            // Si l'API retourne une erreur HTTP
            if (!reponse.IsSuccessStatusCode)
            {
                // Gestion centralisée de l'erreur
                await gestionnaireErreurApi.GererErreurHttpAsync(reponse);
                return false;
            }
            // La requête s'est correctement exécutée
            return true;
        }

        /// <summary>
        /// Envoie une requête PATCH avec un contenu JSON
        /// et désérialise la réponse JSON retournée par l'API.
        /// </summary>
        /// <typeparam name="TRequete">Type de l'objet envoyé dans la requête.</typeparam>
        /// <typeparam name="TReponse">Type de l'objet attendu dans la réponse.</typeparam>
        /// <param name="route">Route de l'endpoint API.</param>
        /// <param name="contenu">Objet à envoyer dans le body de la requête.</param>
        /// <param name="cancellationToken">Permet d'annuler la requête HTTP.</param>
        /// <returns>
        /// L'objet désérialisé retourné par l'API,
        /// ou null/default si la requête échoue.
        /// </returns>
        public async Task<TReponse?> PatchAsync<TRequete, TReponse>(string route, TRequete contenu, CancellationToken cancellationToken = default)
        {
            // Envoie la requête PATCH avec le contenu converti en JSON
            HttpResponseMessage reponse = await client.PatchAsJsonAsync( route, contenu, cancellationToken);

            // Si l'API retourne une erreur HTTP
            if (!reponse.IsSuccessStatusCode)
            {
                // Gestion de l'erreur
                await gestionnaireErreurApi.GererErreurHttpAsync(reponse);
                return default;
            }

            // Désérialise le JSON de la réponse vers le type TReponse
            return await reponse.Content.ReadFromJsonAsync<TReponse>(cancellationToken);
        }

        /// <summary>
        /// Envoie une requête DELETE.
        /// Retourne true si la requête HTTP a réussi, sinon false.
        /// </summary>
        /// <param name="route">Route de l'endpoint API.</param>
        /// <param name="cancellationToken">Permet d'annuler la requête HTTP.</param>
        /// <returns>True si la requête a réussi, sinon false.</returns>
        public async Task<bool> DeleteAsync(string route, CancellationToken cancellationToken = default)
        {
            // Envoie la requête DELETE
            HttpResponseMessage reponse = await client.DeleteAsync(route, cancellationToken);

            // Si l'API retourne une erreur HTTP
            if (!reponse.IsSuccessStatusCode)
            {
                // Gestion centralisée de l'erreur
                await gestionnaireErreurApi.GererErreurHttpAsync(reponse);
                return false;
            }

            // La requête s'est correctement exécutée
            return true;
        }
    }
}
