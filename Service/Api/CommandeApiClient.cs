using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WinForms_Jalon_2.Service.DTO.Enums;
using WinForms_Jalon_2.Service.DTO.Reponses;
using WinForms_Jalon_2.Service.DTO.Requetes;

namespace WinForms_Jalon_2.Service.Api
{
    public class CommandeApiClient
    {
        private readonly ServiceApi _serviceApi;

        public CommandeApiClient(ServiceApi serviceApi)
        {
            _serviceApi = serviceApi;
        }

        public async Task<GetCommandesDTOReponse?> GetCommandesAsync(
            CancellationToken cancellationToken)
        {
            return await _serviceApi.GetAsync<GetCommandesDTOReponse>("Commande", cancellationToken);
        }

        public async Task<GetCommandeParIdDTOReponse?> GetCommandesParIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _serviceApi.GetAsync<GetCommandeParIdDTOReponse>($"Commande/{id}", cancellationToken);
        }

        public async Task<GetCommandesDTOReponse?> GetCommandesEnPreparationAsync(
        CancellationToken cancellationToken)
        {
            return await _serviceApi.GetAsync<GetCommandesDTOReponse>("Commande/en-preparation",cancellationToken);
        }

        public async Task<bool> PasserCommandeAEmballerAsync(int id, int version, CancellationToken cancellationToken)
        {
            ModifierStatutCommandeDTORequete requete = new()
            {
                Version = version
            };

            return await _serviceApi.PatchAsync($"Commande/{id}/a-emballer", requete, cancellationToken);
        }

        public async Task<GetCommandesDTOReponse?> GetCommandesGestionManagerAsync(CancellationToken cancellationToken)
        {
            return await _serviceApi.GetAsync<GetCommandesDTOReponse>("Commande/gestion-manager", cancellationToken);
        }

        public async Task<ModifierStatutCommandeDTOReponse?> ModifierStatutCommandeAsync(int id, StatutCommande statut, int version, CancellationToken cancellationToken)
        {
            ModifierStatutCommandeDTORequete requete = new()
            {
                Statut = statut,
                Version = version
            };

            return await _serviceApi.PatchAsync<ModifierStatutCommandeDTORequete, ModifierStatutCommandeDTOReponse>($"Commande/{id}/statut", requete, cancellationToken);
        }
    }
}
