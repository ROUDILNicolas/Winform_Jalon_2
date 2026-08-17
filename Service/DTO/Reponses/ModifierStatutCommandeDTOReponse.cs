using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Jalon_2.Service.DTO.Enums;

namespace WinForms_Jalon_2.Service.DTO.Reponses
{
    public class ModifierStatutCommandeDTOReponse
    {
        public int Id { get; set; }

        public StatutCommande Statut { get; set; }

        public int Version { get; set; }
    }
}
