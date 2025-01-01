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
    public partial class Spa : Form

    {
        SqlCommand cmd;
        object ll = new object();
        EventArgs ev = new EventArgs();
        private static Connection_Classe cn = new Connection_Classe();
        public Spa()
        {
            InitializeComponent();
            Afficher_Spa_BTN_Click(ll, ev);

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ajouter_Spa_BTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nbr_Seances_Box.Text))
            {
                MessageBox.Show("Veuillez remplir le champ !");
                return;
            }
            if (!int.TryParse(Nbr_Seances_Box.Text, out int Nbr_Seances))
            {
                MessageBox.Show("Le champ Nombre de seances doit être des entiers !");
                return;
            }
            Spa_Classe Spa = new Spa_Classe(int.Parse(Nbr_Seances_Box.Text),20);
            SqlConnection cnx = cn.GetConnection();

            Spa.Ajouter_Spa();
            vider();
            //ReadEmp_Click(sender, e);

        }
        //////AFFICHER///////

        private void Afficher_Spa_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                listViewSpa.Items.Clear();
                Spa_Classe.Afficher_Spa();

                for (int i = 0; i < Spa_Classe.Afficher_Spa().Items.Count; i++)
                {
                    listViewSpa.Items.Add((ListViewItem)Spa_Classe.Afficher_Spa().Items[i].Clone());
                }

                vider();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Affichage " + ex);
            }
        }

        ///////////Supprimer////////
        private void Supprimer_Spa_BTN_Click(object sender, EventArgs e)
        {
            if (listViewSpa.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une spa dans la liste !");
                return;
            }

            try
            {
                Spa_Classe.Supprimer_Spa(int.Parse(listViewSpa.SelectedItems[0].Text));
                vider();
                Afficher_Spa_BTN_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Suppresion " + ex);
            }


        }

        //////////////////////MODIFIER///////////////////////
        private void Modifier_Spa_BTN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Nbr_Seances_Box.Text))
            {
                MessageBox.Show("Veuillez remplir le champ !");
                return;
            }

            if (
                !int.TryParse(Nbr_Seances_Box.Text, out int Nbr_Seances))
            {
                MessageBox.Show("Le champ Nombre des seances doit etre entier !");
                return;
            }


            Consulter_Spa_BTN.Visible = true;
            Modifier_Spa_BTN.Visible = false;
            try
            {
                Spa_Classe.Modifier_Spa(int.Parse(getid.Text), int.Parse(Nbr_Seances_Box.Text), 20);
                vider();
                Afficher_Spa_BTN_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);
            }

        }
        /////////////////////////////
        private void Consulter_Spa_BTN_Click(object sender, EventArgs e)
        {
            if (listViewSpa.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un employé dans la liste !");
                return;
            }
            Modifier_Spa_BTN.Visible = true;
            Consulter_Spa_BTN.Visible = false;
            string queryS = "select * from Spa where id=" + int.Parse(listViewSpa.SelectedItems[0].Text);
            SqlConnection cnx = cn.GetConnection();
            cmd = new SqlCommand(queryS, cnx);

            cnx.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            getid.Text = listViewSpa.SelectedItems[0].Text;
            while (reader.Read())
            {

                Nbr_Seances_Box.Text = reader["Nbr_Seances"].ToString();
                



            }
            cnx.Close();


        }
        //////Vider///////
        void vider()
        {
            Nbr_Seances_Box.Clear();
        }


    }
}
