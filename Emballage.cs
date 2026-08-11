using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_Jalon_2.Service.Api;

namespace WinForms_Jalon_2
{
    public partial class Emballage : Form
    {
        private readonly EmployeConnecte _employeConnecte;

        public Emballage(EmployeConnecte employeConnecte)
        {
            InitializeComponent();

            _employeConnecte = employeConnecte;
        }

        private void buttonTEST_Click(object sender, EventArgs e)
        {

        }
    }
}
