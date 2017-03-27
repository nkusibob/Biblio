using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Google.Apis.Books.v1.Data;

using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace BiblioAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTimePicker oDateTimePicker = new DateTimePicker();
        private void searchExemplaire_Click(object sender, EventArgs e)
        {
            try
            {
                


                DataSet
                    oData = new DataSet();

                ServiceReferenceExemplaires.ServiceExemplairesClient se = new ServiceReferenceExemplaires.ServiceExemplairesClient();

                
                
                oData = se.GetAll();
               

                string search = "code like '%" + textBoxCode.Text + "%'";
               
                var dt = oData.Tables[0].DefaultView;
                
                dt.RowFilter = search;




                gridData.DataSource = dt;
                gridData.Columns["id1"].Visible = false;
                gridData.Columns["Code1"].Visible = false;
                gridData.Columns["id_biblio"].Visible = false;
                gridData.Columns["idLivre"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      
       

        private void buttonDataset_Click(object sender, EventArgs e)
        {
            ServiceReferenceExemplaires.ServiceExemplairesClient se = new ServiceReferenceExemplaires.ServiceExemplairesClient();
            DataSet oData = new DataSet();
            oData=se.GetAll();
            gridData.DataSource = oData.Tables[0].DefaultView;
            gridData.Columns["id1"].Visible = false;
            gridData.Columns["code1"].Visible = false;
            gridData.Columns["id_biblio"].Visible = false;
            gridData.Columns["idLivre"].Visible = false;
            if (gridData != null)
            {
                gridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                gridData.Columns[gridData.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }


        }
      
       

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReferenceExemplaires.ServiceExemplairesClient se = new ServiceReferenceExemplaires.ServiceExemplairesClient();
            DataSet oData = new DataSet();
            oData = se.LoadAllCopyCA();
            gridData.DataSource = oData.Tables[0].DefaultView;
            
        }

        private void buttonEmprunt_Click(object sender, EventArgs e)
        {
            ServiceReferenceEmprunts.ServiceEmpruntsClient se = new ServiceReferenceEmprunts.ServiceEmpruntsClient();
           
            DataSet oData = new DataSet();
            oData = se.LoadAllEmprunt();
            gridData.DataSource = oData.Tables[0].DefaultView;


          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string responsestring = string.Empty;
            
            string url = @"https://www.googleapis.com/books/v1/volumes?q=isbn:"+ textBoxIsbn.Text;
            //
            //0521356520
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;
            
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                responsestring = reader.ReadToEnd();
               
                
                Volumes oBooks = Newtonsoft.Json.JsonConvert.DeserializeObject<Volumes>(responsestring);
                //checking if isbn exists
                    if(oBooks.Items!=null)
                { 
                    Volume oBook = oBooks.Items[0];

                    var title = oBook.VolumeInfo.Title;
                    var imageUrl = oBook.VolumeInfo.ImageLinks.SmallThumbnail;
                    var listAuteur = oBook.VolumeInfo.Authors;
                    var description = oBook.VolumeInfo.Description;
                    
                    StringBuilder auteurFinal = new StringBuilder();
                    string auteur = "";
                    int i = 0;
                    if (listAuteur!=null)
                    {
                        foreach (var item in listAuteur)
                        {
                            if (listAuteur.Count > 1 & i < listAuteur.Count - 1)
                            {
                                Convert.ToString(auteurFinal.Append(item.ToString() + " and "));

                            }

                            else
                            {
                                Convert.ToString(auteurFinal.Append(item.ToString()));

                            }
                            i++;


                        } 
                    }
                    richTextBoxLivreInfo.AppendText("auteur");
                    richTextBoxLivreInfo.AppendText(Environment.NewLine);
                    richTextBoxLivreInfo.AppendText("------");
                    auteur = Convert.ToString(auteurFinal);
                    richTextBoxLivreInfo.AppendText(Environment.NewLine);
                    richTextBoxLivreInfo.AppendText(auteur);
                    richTextBoxLivreInfo.AppendText(Environment.NewLine);
                    richTextBoxLivreInfo.AppendText(Environment.NewLine);
                    richTextBoxLivreInfo.AppendText("title");
                    richTextBoxLivreInfo.AppendText(Environment.NewLine);
                    richTextBoxLivreInfo.AppendText("-----");
                    richTextBoxLivreInfo.AppendText(Environment.NewLine);
                    richTextBoxLivreInfo.AppendText(title);
                    richTextBoxLivreInfo.AppendText(Environment.NewLine);
                    richTextBoxLivreInfo.AppendText(Environment.NewLine);
                    richTextBoxLivreInfo.AppendText("description");
                    richTextBoxLivreInfo.AppendText(Environment.NewLine);
                    richTextBoxLivreInfo.AppendText("------------");
                    richTextBoxLivreInfo.AppendText(Environment.NewLine);
                    richTextBoxLivreInfo.AppendText(description);
                    ServiceReferenceLivres.ServiceLivresClient scli = new ServiceReferenceLivres.ServiceLivresClient();
                    pictureBoxImageLivre.ImageLocation = imageUrl;
                    pictureBoxImageLivre.SizeMode = PictureBoxSizeMode.AutoSize;


                    scli.insertLivre(textBoxIsbn.Text, title,imageUrl, auteur);
                }else
                {
                    MessageBox.Show("ce numero d'isbn n'a pas été trouvé");
                }
              
               

            }

            

        }

    

       

        private void buttonSoldeRetard_Click(object sender, EventArgs e)
        {
            try
            {

                

                ServiceReferenceExemplaires.ServiceExemplairesClient se = new ServiceReferenceExemplaires.ServiceExemplairesClient();
            
                DataSet oData = new DataSet();
                oData = se.Exemplaire_SoldeRetard();
                gridData.DataSource = oData.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            InsertExemplaireModal oForm = new InsertExemplaireModal();
            oForm.ShowDialog();
        }

        private void buttonInsertEmprunt_Click(object sender, EventArgs e)

        {
            InsertEmpruntModal oForm = new InsertEmpruntModal();
            oForm.ShowDialog();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateEmpruntModal oForm = new UpdateEmpruntModal();
            oForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReferenceExemplaires.ServiceExemplairesClient se = new ServiceReferenceExemplaires.ServiceExemplairesClient();
            DataSet oData = new DataSet();
            oData = se.Exemplaire_Solde();
            var dt = oData.Tables[0].DefaultView;

            int i = 0;

            if (Int32.TryParse(textBoxSearchRetour.Text, out i))
            {
                dt.RowFilter = "exemplaireID = " + i;

                this.gridData.DataSource = dt;
            }
           

        }

        private void buttonLoadSolde_Click(object sender, EventArgs e)
        {
            ServiceReferenceExemplaires.ServiceExemplairesClient se = new ServiceReferenceExemplaires.ServiceExemplairesClient();
            
            DataSet oData = new DataSet();
            oData = se.Exemplaire_Solde();
            gridData.DataSource = oData.Tables[0].DefaultView;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {


           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            ServiceReferenceExemplaires.ServiceExemplairesClient se = new ServiceReferenceExemplaires.ServiceExemplairesClient();
            DataSet oData = new DataSet();
            oData = se.Exemplaire_Solde();
            var dt = oData.Tables[0].DefaultView;



            dt.RowFilter = "solde < " + 0;
            gridData.DataSource = dt;
        }

        private void buttonCountDispoParBiblio_Click(object sender, EventArgs e)
        {
            ServiceReferenceExemplaires.ServiceExemplairesClient se = new ServiceReferenceExemplaires.ServiceExemplairesClient();
            DataSet oData = new DataSet();
            oData = se.GetCountAll();
            gridData.DataSource = oData.Tables[0].DefaultView;

          
            if (gridData != null)
            {
                gridData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                gridData.Columns[gridData.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

        }

      
        private void gridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string titre = gridData.SelectedCells[0].Value.ToString();
            ServiceReferenceBooks.ServiceLivresClient se = new ServiceReferenceBooks.ServiceLivresClient();
           string imageUrl = se.getImage(titre);

            pictureBoxImageLivre.ImageLocation = imageUrl;
            pictureBoxImageLivre.SizeMode = PictureBoxSizeMode.AutoSize;
        }

        private void gridData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string titre = gridData.SelectedCells[0].Value.ToString();
                ServiceReferenceBooks.ServiceLivresClient se = new ServiceReferenceBooks.ServiceLivresClient();
                string imageUrl = se.getImage(titre);

                pictureBoxImageLivre.ImageLocation = imageUrl;
                pictureBoxImageLivre.SizeMode = PictureBoxSizeMode.AutoSize;
            }
           
           
        }

      
      
    }
 }

