namespace WinForms_Jalon_2.Service.DTO.Reponses
{
    public class ModifierQuantiteProduitDTOReponse
    {
        public int Id { get; set; }

        public string Nom { get; set; }

        public int CategorieId { get; set; }

        public int Quantite { get; set; }

        public decimal PrixAchat { get; set; }

        public decimal PrixVente { get; set; }

        public string Description { get; set; }
    }
}
