using WinForms_Jalon_2.Service.DTO.Enums;

namespace WinForms_Jalon_2.Service.DTO.Reponses
{
    public class GetCommandeParIdDTOReponse
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public IEnumerable<GetLignesCommandeDTOReponse> LignesCommande { get; set; }

        public int Version { get; set; }
    }

    public class GetLignesCommandeDTOReponse
    {
        
        public int ProduitId { get; set; }
        
        public string NomProduit { get; set; }

        public int Quantite { get; set; }

        public StatutLigneCommande Statut {  get; set; }
    }

}
