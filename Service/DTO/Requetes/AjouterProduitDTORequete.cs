namespace WinForms_Jalon_2.Service.DTO.Requetes
{
    public class AjouterProduitDTORequete
    {

        public string Nom { get; set; }

        public int CategorieId { get; set; }

        public int Quantite { get; set; }

        public decimal PrixAchat { get; set; }

        public decimal PrixVente { get; set; }

        public string Description { get; set; }

    }
}