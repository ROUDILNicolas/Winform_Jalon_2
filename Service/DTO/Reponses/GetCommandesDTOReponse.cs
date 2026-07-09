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

        //public StatutCommande Statut { get; set; }

        public DateTime Date { get; set; }
    }
}
