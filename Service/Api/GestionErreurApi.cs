using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Jalon_2.Service.Api
{
    public class GestionnaireErreurApi
    {
        public async Task GererErreurHttpAsync(HttpResponseMessage reponse)
        {
            string contenuErreur =
                await reponse.Content.ReadAsStringAsync();

            switch (reponse.StatusCode)
            {
                case HttpStatusCode.BadRequest:
                    MessageBox.Show(
                        "Certaines données sont invalides.",
                        "Erreur de validation"
                    );
                    break;

                case HttpStatusCode.Unauthorized:
                    MessageBox.Show(
                        "Identifiant ou mot de passe incorrect.",
                        "Authentification"
                    );
                    break;

                case HttpStatusCode.Forbidden:
                    MessageBox.Show(
                        "Vous n'avez pas les droits nécessaires.",
                        "Accès refusé"
                    );
                    break;

                case HttpStatusCode.NotFound:
                    MessageBox.Show(
                        "L'élément demandé n'existe pas ou plus.",
                        "Introuvable"
                    );
                    break;

                case HttpStatusCode.Conflict:
                    MessageBox.Show(
                        "Les données ont été modifiées ailleurs. Rechargez puis réessayez.",
                        "Conflit de modification"
                    );
                    break;

                case HttpStatusCode.InternalServerError:
                    MessageBox.Show(
                        "Une erreur serveur est survenue.",
                        "Erreur serveur"
                    );
                    break;

                default:
                    MessageBox.Show(
                        $"Erreur inattendue : {(int)reponse.StatusCode}\n{contenuErreur}",
                        "Erreur"
                    );
                    break;
            }
        }

        public void GererException(Exception exception)
        {
            if (exception is TaskCanceledException)
            {
                MessageBox.Show(
                    "Le serveur met trop de temps à répondre.",
                    "Timeout"
                );
            }
            else if (exception is HttpRequestException)
            {
                MessageBox.Show(
                    "Impossible de contacter l'API.",
                    "Erreur réseau"
                );
            }
            else
            {
                MessageBox.Show(
                    $"Erreur inattendue : {exception.Message}",
                    "Erreur"
                );
            }
        }
    }
}
