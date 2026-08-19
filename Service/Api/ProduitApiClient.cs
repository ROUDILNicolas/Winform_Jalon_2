using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WinForms_Jalon_2.Service.DTO.Reponses;
using WinForms_Jalon_2.Service.DTO.Requetes;

namespace WinForms_Jalon_2.Service.Api
{
    public class ProduitApiClient
    {
        private readonly ServiceApi _serviceApi;

        public ProduitApiClient(ServiceApi serviceApi)
        {
            _serviceApi = serviceApi;
        }

        public async Task<GetProduitsDTOReponse?> GetProduitsAsync(
            CancellationToken cancellationToken)
        {
            return await _serviceApi.GetAsync<GetProduitsDTOReponse>("Produit");
        }

        public async Task<GetProduitParIdDTOReponse?> GetProduitParIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _serviceApi.GetAsync<GetProduitParIdDTOReponse>($"Produit/{id}");
        }

        public async Task<List<GetTypesProduitDTOReponse>?> GetTypesProduitAsync(CancellationToken cancellationToken)
        {
            return await _serviceApi.GetAsync<List<GetTypesProduitDTOReponse>>("Produit/types", cancellationToken);
        }

        public async Task<bool> AjouterProduitAsync(AjouterProduitDTORequete requete, CancellationToken cancellationToken)
        {
            return await _serviceApi.PostAsync("Produit", requete, cancellationToken);
        }

        public async Task<bool> ModifierProduitAsync(int id, ModifierProduitDTORequete requete, CancellationToken cancellationToken)
        {
            return await _serviceApi.PutAsync($"Produit/{id}", requete, cancellationToken);
        }

        public async Task<bool> SupprimerProduitAsync(int id, CancellationToken cancellationToken)
        {
            return await _serviceApi.DeleteAsync($"Produit/{id}", cancellationToken);
        }
    }
}
