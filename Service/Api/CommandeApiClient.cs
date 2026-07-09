using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using WinForms_Jalon_2.Service.DTO.Reponses;

namespace WinForms_Jalon_2.Service.Api
{
    public class ComandeApiClient
    {
        private readonly ServiceApi _serviceApi;

        public ComandeApiClient(ServiceApi serviceApi)
        {
            _serviceApi = serviceApi;
        }

        public async Task<GetProduitsDTOReponse?> GetProduitsAsync(
            CancellationToken cancellationToken)
        {
            return await _serviceApi.GetAsync<GetProduitsDTOReponse>("Commande", cancellationToken);
        }

        public async Task<GetProduitParIdDTOReponse?> GetProduitParIdAsync(int id, CancellationToken cancellationToken)
        {
            return await _serviceApi.GetAsync<GetProduitParIdDTOReponse>($"Commande/{id}", cancellationToken);
        }
    }
}
