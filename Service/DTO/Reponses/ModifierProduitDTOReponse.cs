namespace WinForms_Jalon_2.Service.DTO.Reponses
{
    public class ModifierProduitDTOReponse
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public int TypeProduitId { get; set; }

        public string NomTypeProduit { get; set; }

        public int Quantite { get; set; }

        public decimal PrixAchat { get; set; }

        public decimal PrixVente { get; set; }

        public string Description { get; set; }

        public int Version { get; set; }
    }
}
