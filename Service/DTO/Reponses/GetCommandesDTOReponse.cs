using WinForms_Jalon_2.Service.DTO.Enums;

namespace WinForms_Jalon_2.Service.DTO.Reponses
{
    public class GetCommandesDTOReponse
    {
        public IEnumerable<GetCommandesItemDTOReponse> Commandes { get; set; }
    }

    public class GetCommandesItemDTOReponse 
    {
        public int Id { get; set; }

        public int ClientId { get; set; }

        public int AdresseId { get; set; }

        public int NombreArticles { get; set; }

        public int QuantiteTotale { get; set; }

        public StatutCommande Statut { get; set; }

        public DateTime Date { get; set; }

        public int Version { get; set; }
    }
}
