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
    public partial class CRUDCar : Form
    {

        SqlCommand cmd;
        object se = new object();

        EventArgs ev = new EventArgs();
        private static Connection_Classe cn = new Connection_Classe();
        public CRUDCar()
        {
            InitializeComponent();
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomCarBox.Text) ||
            string.IsNullOrWhiteSpace(MarqueCarBox.Text) ||
            string.IsNullOrWhiteSpace(MatriculeCarBox.Text) ||
            string.IsNullOrWhiteSpace(ColorCarBox.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            CRUDCarClass Car = new CRUDCarClass(NomCarBox.Text, MarqueCarBox.Text, MatriculeCarBox.Text, ColorCarBox.Text);
            SqlConnection cnx = cn.GetConnection();

            Car.AjouterCar();
            vider();
            ReadCar_Click(sender, e);
        }


        private void ReadCar_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewCar.Items.Clear();
                CRUDCarClass.Afficher();

                for (int i = 0; i < CRUDCarClass.Afficher().Items.Count; i++)
                {
                    ListViewCar.Items.Add((ListViewItem)CRUDCarClass.Afficher().Items[i].Clone());
                }

                vider();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Affichage " + ex);
            }
        }

        private void DeleteCar_Click(object sender, EventArgs e)
        {
            if (ListViewCar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner car dans la liste !");
                return;
            }

            try
            {
                CRUDCarClass.SupprimerCar(int.Parse(ListViewCar.SelectedItems[0].Text));
                vider();
                ReadCar_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Suppression " + ex);
            }
        }

        private void consulterCarButton_Click(object sender, EventArgs e)
        {
            if (ListViewCar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un Car dans la liste !");
                return;
            }
            UpdateCar.Visible = true;
            consulterCarButton.Visible = false;
            string queryS = "select * from Car where id=" + int.Parse(ListViewCar.SelectedItems[0].Text);
            SqlConnection cnx = cn.GetConnection();
            cmd = new SqlCommand(queryS, cnx);

            cnx.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            getCarId.Text = ListViewCar.SelectedItems[0].Text;
            while (reader.Read())
            {
                NomCarBox.Text = reader["Nom"].ToString();
                MarqueCarBox.Text = reader["Marque"].ToString();
                MatriculeCarBox.Text = reader["Matricule"].ToString();
                ColorCarBox.Text = reader["Color"].ToString();
            }
            cnx.Close();
        }

        private void UpdateCar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomCarBox.Text) ||
        string.IsNullOrWhiteSpace(MatriculeCarBox.Text) ||
        string.IsNullOrWhiteSpace(MarqueCarBox.Text) ||
        string.IsNullOrWhiteSpace(ColorCarBox.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }


            consulterCarButton.Visible = true;
            UpdateCar.Visible = false;
            try
            {
                CRUDCarClass.Modifier(int.Parse(getCarId.Text), NomCarBox.Text, MatriculeCarBox.Text, MarqueCarBox.Text, ColorCarBox.Text);
                vider();
                ReadCar_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);
            }
        }

        void vider()
        {
            NomCarBox.Clear();
            MarqueCarBox.Clear();
            MatriculeCarBox.Clear();
            ColorCarBox.Clear();
        }
    }
}
