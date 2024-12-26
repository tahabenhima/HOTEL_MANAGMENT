using HOTEL_MANAGMENT.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_MANAGMENT
{
    public partial class Chambre : Form
    {
        SqlCommand cmd;

        object se = new object();

        EventArgs ev = new EventArgs();
        private static Connection_Classe cn = new Connection_Classe();

        public Chambre()
        {
            InitializeComponent();
            ReadChambrebtn_Click(se, ev);
        }

        private void AddChambrebtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TypechambreBox.Text) ||
        string.IsNullOrWhiteSpace(CapasiteChambreBox.Text) ||
        string.IsNullOrWhiteSpace(PrixChambreBox.Text) ||
        string.IsNullOrWhiteSpace(NumeroChambreBox.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            if (!int.TryParse(NumeroChambreBox.Text, out int numeroChambre))
            {
                MessageBox.Show("Le champ  NUM doivent être des entiers !");
                return;
            }

            if (!int.TryParse(CapasiteChambreBox.Text, out int capasiteChambre))
            {
                MessageBox.Show("Le champ Capacité doit être un entier !");
                return;
            }

            if (!float.TryParse(PrixChambreBox.Text, out float prixChambre))
            {
                MessageBox.Show("Le champ Prix doit être un nombre décimal !");
                return;
            }



            Chambre_Class chb = new Chambre_Class(TypechambreBox.Text, int.Parse(NumeroChambreBox.Text), int.Parse(CapasiteChambreBox.Text), float.Parse(PrixChambreBox.Text));
            SqlConnection cnx = cn.GetConnection();

            chb.Ajouter_Chambre();
            vider();
            ReadChambrebtn_Click(sender, e);
        }
        void vider()
        {
            TypechambreBox.Clear();
            NumeroChambreBox.Clear();
            CapasiteChambreBox.Clear();
            PrixChambreBox.Clear();

        }

        private void ReadChambrebtn_Click(object sender, EventArgs e)
        {

            try
            {
                ListViewChambre.Items.Clear();
                // Chambre_Class.Afficher_chambre();

                for (int i = 0; i < Chambre_Class.Afficher_chambre().Items.Count; i++)
                {
                    ListViewChambre.Items.Add((ListViewItem)Chambre_Class.Afficher_chambre().Items[i].Clone());
                }

                vider();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Affichage " + ex);
            }
        }





        private void DeleteChambrebtn_Click_1(object sender, EventArgs e)
        {
            if (ListViewChambre.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une chambre dans la liste !");
                return;
            }

            try
            {
                Chambre_Class.Supprimer_Chambre(int.Parse(ListViewChambre.SelectedItems[0].SubItems[4].Text));
                vider();
                ReadChambrebtn_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Suppression " + ex);
            }

        }

        private void UpdateChambrebtn_Click_1(object sender, EventArgs e)
        {
            if (ListViewChambre.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une chambre dans la liste !");
                return;
            }


            if (string.IsNullOrWhiteSpace(TypechambreBox.Text) ||
                string.IsNullOrWhiteSpace(CapasiteChambreBox.Text) ||
                string.IsNullOrWhiteSpace(PrixChambreBox.Text) ||
                string.IsNullOrWhiteSpace(NumeroChambreBox.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            if (!int.TryParse(NumeroChambreBox.Text, out int numeroChambre))
            {
                MessageBox.Show("Le champ numero dois être un entier !");
                return;
            }

            if (!int.TryParse(CapasiteChambreBox.Text, out int capasiteChambre))
            {
                MessageBox.Show("Le champ Capacité doit être un entier !");
                return;
            }

            if (!float.TryParse(PrixChambreBox.Text, out float prixChambre))
            {
                MessageBox.Show("Le champ Prix doit être un nombre décimal !");
                return;
            }

            Chambre_Class chb = new Chambre_Class(int.Parse(getid.Text),TypechambreBox.Text, int.Parse(NumeroChambreBox.Text), int.Parse(CapasiteChambreBox.Text), float.Parse(PrixChambreBox.Text));
            SqlConnection cnx = cn.GetConnection();

            try
            {
                chb.Modifier_Chambre();
                vider();
                ReadChambrebtn_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Modification " + ex);
            }

        }

        private void ListViewChambre_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (ListViewChambre.SelectedItems.Count > 0)
            {
                
                ListViewItem selectedItem = ListViewChambre.SelectedItems[0] ;
                int il = int.Parse( selectedItem.SubItems[4].Text);

                


                string queryS = "select * from Chambre where id=" + il;
            SqlConnection cnx = cn.GetConnection();
            cmd = new SqlCommand(queryS, cnx);

            cnx.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            getid.Text = selectedItem.SubItems[4].Text;
            while (reader.Read())
            {
                    TypechambreBox.Text = reader["type_Chambre"].ToString();
                    CapasiteChambreBox.Text = reader["Capacite"].ToString();
                    PrixChambreBox.Text = reader["Prix"].ToString();
                    NumeroChambreBox.Text = reader["numero"].ToString();
             



            }
            cnx.Close();
 }


        }
    }
}
