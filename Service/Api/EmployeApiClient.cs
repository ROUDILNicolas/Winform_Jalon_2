using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForms_Jalon_2.Service.DTO.Reponses;
using WinForms_Jalon_2.Service.DTO.Requetes;

namespace WinForms_Jalon_2.Service.Api
{
    public class EmployeApiClient
    {
        private readonly ServiceApi _serviceApi;
        public EmployeApiClient(ServiceApi serviceApi)
        {
            _serviceApi = serviceApi;
        }
    }

    public class EmployeConnecte
    {
        public string? Login { get; set; }

        public string? Role { get; set; }

        public int? Id { get; set; }
    }
}
