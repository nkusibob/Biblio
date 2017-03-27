using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiblioAdmin
{
    public partial class InsertExemplaireModal : Form
    {
        public InsertExemplaireModal()
        {
            InitializeComponent();
        }

        private void buttonExInsSumit_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReferenceExemplaires.ServiceExemplairesClient se = new ServiceReferenceExemplaires.ServiceExemplairesClient();
                se.CreateExemplaire(textBoxCode.Text, Convert.ToDateTime(textBoxAchatDt.Text), Convert.ToDateTime(textBoxEmpruntDt.Text), Convert.ToInt32(textBoxIdBiblio.Text), Convert.ToInt32(textBoxIdLivre.Text));
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
