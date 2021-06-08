using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using BibliothequeDeStructure;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Runtime.Serialization.Formatters.Binary;


namespace GERARDLéoGestionClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // Instation d'un client de type client

        Client unClient = new Client();


        OdbcConnection maConnexion;



        private void Form1_Load(object sender, EventArgs e)
        {
        

            maConnexion = new OdbcConnection();
            maConnexion.ConnectionString = "DSN=gerardLGestionClient";

            // Ouverture de la connexion
            maConnexion.Open();

            OdbcDataAdapter monAdapter = new OdbcDataAdapter();

            DataSet mesDonnees = new DataSet();

            // Récupération des données de la base de données

            OdbcCommand reqClient = new OdbcCommand("SELECT * FROM clients;", maConnexion);
            monAdapter.SelectCommand = reqClient;
            monAdapter.Fill(mesDonnees);


            // Remplissage du tableau

            for (int i = 0; i < mesDonnees.Tables[0].Rows.Count; i++)
            {
                unClient.getID = mesDonnees.Tables[0].Rows[i].ItemArray[0].ToString();
                unClient.getEmail = mesDonnees.Tables[0].Rows[i].ItemArray[1].ToString();
                unClient.getNom = mesDonnees.Tables[0].Rows[i].ItemArray[2].ToString();
                unClient.getPrenom = mesDonnees.Tables[0].Rows[i].ItemArray[3].ToString();
                unClient.getPsw = mesDonnees.Tables[0].Rows[i].ItemArray[4].ToString();
                unClient.getTel = mesDonnees.Tables[0].Rows[i].ItemArray[5].ToString();
                unClient.getNumRue = mesDonnees.Tables[0].Rows[i].ItemArray[6].ToString();
                unClient.getNomRue = mesDonnees.Tables[0].Rows[i].ItemArray[7].ToString();
                unClient.getVille = mesDonnees.Tables[0].Rows[i].ItemArray[8].ToString();
                unClient.getCP = mesDonnees.Tables[0].Rows[i].ItemArray[9].ToString();
                unClient.getCP = mesDonnees.Tables[0].Rows[i].ItemArray[10].ToString();

                // Affichage des clients dans la dataGrid

                dataGridView1.Rows.Add(unClient.getID,
                                       unClient.getEmail,
                                       unClient.getNom,
                                       unClient.getPrenom,
                                       unClient.getPsw,
                                       unClient.getTel,
                                       unClient.getNumRue,
                                       unClient.getNomRue,
                                       unClient.getVille,
                                       unClient.getCP,
                                       unClient.getStatut);
            }

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {         

            Client nouveauClient = new Client();
            
            nouveauClient.getEmail = txtEmail.Text;
            nouveauClient.getNom = txtNom.Text;
            nouveauClient.getPrenom = txtPrenom.Text;
            nouveauClient.getPsw = txtMdp.Text;
            nouveauClient.getTel = txtTel.Text;
            nouveauClient.getNumRue = txtNumRue.Text;
            nouveauClient.getNomRue = txtNomRue.Text;
            nouveauClient.getVille = txtVille.Text;
            nouveauClient.getCP = txtCP.Text;
            nouveauClient.getStatut = "Ajouté";

            // Ajouter le nouveau client dans la datagrid

            dataGridView1.Rows.Add(nouveauClient.getID,
                                   nouveauClient.getEmail,
                                   nouveauClient.getNom,
                                   nouveauClient.getPrenom,
                                   nouveauClient.getPsw,
                                   nouveauClient.getTel,
                                   nouveauClient.getNumRue,
                                   nouveauClient.getNomRue,
                                   nouveauClient.getVille,
                                   nouveauClient.getCP,
                                   nouveauClient.getStatut);


            MessageBox.Show("Client bien ajouté");
            txtEmail.Clear();
            txtNom.Clear();
            txtPrenom.Clear();
            txtMdp.Clear();
            txtTel.Clear();
            txtNumRue.Clear();
            txtNomRue.Clear();
            txtVille.Clear();
            txtCP.Clear();
        }


        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            // Récupère l'index de la ligne à supprimer

            int ligneASupprimer = dataGridView1.CurrentCellAddress.Y;

            dataGridView1.Rows[ligneASupprimer].Cells["Statut"].Value = "Supprimé";

        }



        private void btnModifier_Click(object sender, EventArgs e)
        {
            /*txtId.Text = unClient.getID;
            txtPseudo.Text = unClient.getPseudo;
            txtEmail.Text = unClient.getEmail;
            txtNom.Text = unClient.getNom;
            txtPrenom.Text = unClient.getPrenom;
            txtSexe.Text = unClient.getSexe;
            txtMdp.Text = unClient.getPsw;
            txtTel.Text = unClient.getTel;
            txtNumRue.Text = unClient.getNumRue;
            txtNomRue.Text = unClient.getNomRue;
            txtVille.Text = unClient.getVille;
            txtCP.Text = unClient.getCP;*/
        }



        private void btnQuitter_Click(object sender, EventArgs e)
        {           

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                // Ajout des nouveaux clients dans la base de données

                if (Convert.ToString(dataGridView1.Rows[i].Cells["Statut"].Value) == "Ajouté")
                {

                    OdbcDataAdapter monAdapter = new OdbcDataAdapter();

                    OdbcCommand reqAjouterClient = new OdbcCommand("INSERT INTO clients (email, nom, prenom, mdp, telephone, numRue, nomRue, ville, codePostal) VALUES ('" + Convert.ToString(dataGridView1.Rows[i].Cells["email"].Value) + "','" + Convert.ToString(dataGridView1.Rows[i].Cells["Nom"].Value) + "','" + Convert.ToString(dataGridView1.Rows[i].Cells["prenom"].Value) + "','" + Convert.ToString(dataGridView1.Rows[i].Cells["psw"].Value) + "','" + Convert.ToString(dataGridView1.Rows[i].Cells["telephone"].Value) + "','" + Convert.ToString(dataGridView1.Rows[i].Cells["numRue"].Value) + "','" + Convert.ToString(dataGridView1.Rows[i].Cells["nomRue"].Value) + "','" + Convert.ToString(dataGridView1.Rows[i].Cells["ville"].Value) + "','" + Convert.ToString(dataGridView1.Rows[i].Cells["codePostal"].Value) + "')", maConnexion);
                    monAdapter.SelectCommand = reqAjouterClient;
                    reqAjouterClient.ExecuteNonQuery();

                    MessageBox.Show("Test client ajouté");
                }

                // Suppression d'un client dans la base de données

                else if (Convert.ToString(dataGridView1.Rows[i].Cells["Statut"].Value) == "Supprimé")
                {
                    OdbcDataAdapter monAdapter = new OdbcDataAdapter();

                    OdbcCommand reqSupprClient = new OdbcCommand("DELETE FROM clients WHERE email = '" + Convert.ToString(dataGridView1.Rows[i].Cells["email"].Value) + "'", maConnexion);
                    monAdapter.DeleteCommand = reqSupprClient;
                    reqSupprClient.ExecuteNonQuery();

                    MessageBox.Show("Test client supprimé");
                }

            }

        }


        // Rechercher par nom les clients


        private void txtRechercher_TextChanged(object sender, EventArgs e)
        {
           

            OdbcDataAdapter monAdapter = new OdbcDataAdapter();

            DataSet mesDonnees = new DataSet();
            OdbcCommand reqAfficherDonnees = new OdbcCommand("SELECT * FROM clients WHERE nom LIKE '" + txtRechercher.Text + "%'", maConnexion);
            monAdapter.SelectCommand = reqAfficherDonnees;
            monAdapter.Fill(mesDonnees);
            dataGridView1.Rows.Clear();

            for (int i = 0; i < mesDonnees.Tables[0].Rows.Count; i++)
            {
                dataGridView1.Rows.Add(mesDonnees.Tables[0].Rows[i].ItemArray[0].ToString(),
                                       mesDonnees.Tables[0].Rows[i].ItemArray[1].ToString(),
                                       mesDonnees.Tables[0].Rows[i].ItemArray[2].ToString(),
                                       mesDonnees.Tables[0].Rows[i].ItemArray[3].ToString(),
                                       mesDonnees.Tables[0].Rows[i].ItemArray[4].ToString(),
                                       mesDonnees.Tables[0].Rows[i].ItemArray[5].ToString(),
                                       mesDonnees.Tables[0].Rows[i].ItemArray[6].ToString(),
                                       mesDonnees.Tables[0].Rows[i].ItemArray[7].ToString(),
                                       mesDonnees.Tables[0].Rows[i].ItemArray[8].ToString(),
                                       mesDonnees.Tables[0].Rows[i].ItemArray[9].ToString(),
                                       mesDonnees.Tables[0].Rows[i].ItemArray[10].ToString());
        }
        }

        // Annuler la recherche

        private void btnAnnulerRecherche_Click(object sender, EventArgs e)
        {
            txtRechercher.Clear();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtNom.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPrenom.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtMdp.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtTel.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtNumRue.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtNomRue.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtVille.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtCP.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

            MessageBox.Show(dataGridView1.CurrentCellAddress.Y.ToString());
        }
    }
}
