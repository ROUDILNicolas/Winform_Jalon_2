namespace WinForms_Jalon_2.Service.DTO.Reponses
{
    public class GetCommandeParIdDTOReponse
    {
        public int Id { get; set; }
        
        //public IEnumerable<GetLignesCommandeDTOReponse> LignesCommande { get; set; }

        public int ClientId { get; set; }

        public int AdresseId { get; set; }
   
        //public StatutCommande Statut { get; set; }

        public DateTime Date {  get; set; }
    }

    //public class GetLignesCommandeDTOReponse
    //{

    //    public Produit Produit { get; set; }

    //    public int Quantite { get; set; }

    //    public StatutLigneCommande Statut { get; set; }
    //}

}
