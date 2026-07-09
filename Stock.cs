using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Jalon_2
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void btnCRUD_Click(object sender, EventArgs e)
        {
            tlpFormulaire.Visible = !tlpFormulaire.Visible;
        }
    }
}
