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
    public partial class UpdateEmpruntModal : Form
    {
        public UpdateEmpruntModal()
        {
            InitializeComponent();
        }

        private void buttonUpdateEmprunt_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReferenceEmprunts.ServiceEmpruntsClient se = new ServiceReferenceEmprunts.ServiceEmpruntsClient();
                //se.UpdateEmprunt(Convert.ToInt32(  textBoxId.Text), textBoxNom.Text, textBoxTitre.Text, Convert.ToDateTime(textBoxDtRetour.Text), Convert.ToDecimal(textBoxPrixEmprunt.Text));
                se.UpdateEmprunt(Convert.ToInt32(textBoxId.Text), Convert.ToDateTime(textBoxDtRetour.Text));
            }
            catch ( Exception ex)
            {

                MessageBox.Show("veuillez vérifier les données entrées  ");
            }

        }

        private void textBoxDtRetour_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
