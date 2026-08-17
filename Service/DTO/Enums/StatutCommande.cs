using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Jalon_2.Service.DTO.Enums
{
    public enum StatutCommande
    {
        EnPreparation = 1,
        AEmballer = 2,
        EnAttenteEnvoi = 3,
        EnCoursEnvoi = 4,
        Delivre = 5,
        Bloque = 6,
        Archiver = 7
    }

    public class StatutComboBoxItem
    {
        public string Libelle { get; set; }

        public StatutCommande? Statut { get; set; }

        public override string ToString()
        {
            return Libelle;
        }
    }
}
