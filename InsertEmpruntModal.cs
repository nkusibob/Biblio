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
    public partial class InsertEmpruntModal : Form
    {
        public InsertEmpruntModal()
        {
            InitializeComponent();
            loadBiblio();
        }
        public static string biblio = "";
        private void buttonInsEmp_Click(object sender, EventArgs e)
        {
            {
                biblio = comboBoxBiblio.SelectedValue.ToString();
                ServiceReferenceRetards.RetardsClient re = new ServiceReferenceRetards.RetardsClient();
                int nbreRetard = re.GetCountRetardsUsersAdo(textBoxName.Text);
                ServiceReferenceExemplaires.ServiceExemplairesClient ex = new ServiceReferenceExemplaires.ServiceExemplairesClient();

               // ServiceReferenceLecteur.ServiceLecteurClient scl = new ServiceReferenceLecteur.ServiceLecteurClient();
                ServiceReferenceEmprunts.ServiceEmpruntsClient ser = new ServiceReferenceEmprunts.ServiceEmpruntsClient();
                ServiceReferenceBiblio.ServiceBiblioClient sb = new ServiceReferenceBiblio.ServiceBiblioClient();
                string biblioPrincip = sb.Select_BiblioPrincipaleAdo(textBoxName.Text);
                int nbreBP = ser.NbreEmpruntAnnexePrincipalAdo(textBoxName.Text);
                int nbreBA = ser.NbreEmpruntAnnexeAdo(textBoxName.Text);

                while (true)
                {
                    if (nbreRetard >= 2)
                    {
                        MessageBox.Show("vous ne pouvez pas emprunter avec 2 retards !");
                        break;
                    }



                    int check = ex.VerifiNbreExemDispoAdo(biblio, textBoxTitle.Text);

                    if (biblioPrincip != biblio)
                    {
                        if (nbreBA + nbreBP > 2)
                        {
                            MessageBox.Show("3 livres max pour emprunter en Annexe");
                            break;
                        }

                    }

                    if (check == 0)
                    {
                        MessageBox.Show("ce livre n'est pas disponible");
                        break;
                    }


                    else
                    {
                        ServiceReferenceEmprunts.ServiceEmpruntsClient se = new ServiceReferenceEmprunts.ServiceEmpruntsClient();
                        //se.InsertEmpruntEF(textBoxTitle.Text, textBoxName.Text, null, Convert.ToDecimal(textBoxPrixEmprunt.Text), biblio);
                          se.InsertEmprunt(textBoxTitle.Text, textBoxName.Text, null, Convert.ToDecimal(textBoxPrixEmprunt.Text), biblio);
                        break;
                    }

                }



            }
            //il faut verifier si livre dispo
            //biblio = comboBoxBiblio.SelectedValue.ToString();
            //ServiceReferenceRetards.RetardsClient re = new ServiceReferenceRetards.RetardsClient();
            //int nbreRetard=re.GetCountRetardsUsers(textBoxName.Text).FirstOrDefault().NbreRetards;

            //if (nbreRetard >= 2)
            //{
            //    MessageBox.Show("vous ne pouvez pas emprunter avec 2 retards !");
            //}
            //ServiceReferenceExemplaires.ServiceExemplairesClient ex = new ServiceReferenceExemplaires.ServiceExemplairesClient();
            //int nbr=ex.VerifiNbreExemDispo(biblio, textBoxTitle.Text).FirstOrDefault().NbreExemDispo;

            //if (nbr > 0)
            //{
            //    ServiceReferenceEmprunts.ServiceEmpruntsClient se = new ServiceReferenceEmprunts.ServiceEmpruntsClient();
            //    se.InsertEmprunt(textBoxTitle.Text, textBoxName.Text, Convert.ToDateTime(textBoxDtRetour.Text), Convert.ToDecimal(textBoxPrixEmprunt.Text), biblio);

            //}
            //else
            //{
            //    MessageBox.Show("ce livre n'est pas disponible maintenant");
            //}


        }

     

      

       


       public void loadBiblio()
        {
            ServiceReferenceBiblio.ServiceBiblioClient sb = new ServiceReferenceBiblio.ServiceBiblioClient();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sb.GetAll();
            comboBoxBiblio.DataSource = bindingSource.DataSource;
            comboBoxBiblio.DisplayMember = "libellé";
            comboBoxBiblio.ValueMember = "libellé";
        }

        private void comboBoxBiblio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     
    }
}
