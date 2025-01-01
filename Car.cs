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
    public partial class Car : Form
    {

        SqlCommand cmd;
        object se = new object();

        EventArgs ev = new EventArgs();
        private static Connection_Classe cn = new Connection_Classe();
        public Car()
        {
            InitializeComponent();
            afficher();
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

            Car_Class Car = new Car_Class(NomCarBox.Text, MarqueCarBox.Text, MatriculeCarBox.Text, ColorCarBox.Text,20);
            SqlConnection cnx = cn.GetConnection();

            Car.AjouterCar();
            vider();
            afficher();
        }


        private void ReadCar_Click(object sender, EventArgs e)
        {
             afficher();
        }
        void afficher()
        {
            try
            {
                ListViewCar.Items.Clear();
                Car_Class.Afficher();

                int n = Car_Class.Afficher().Items.Count;
                for (int i = 0; i < n; i++)
                {
                    ListViewCar.Items.Add((ListViewItem)Car_Class.Afficher().Items[i].Clone());
                }

                vider();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Affichage  " + ex);
            }
        }
        private void DeleteCar_Click(object sender, EventArgs e)
        {
            if (ListViewCar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner car dans la liste !");
                return;
            }
            int a = int.Parse(ListViewCar.SelectedItems[0].SubItems[5].Text);
           
            try
            {
                Car_Class.SupprimerCar(a);
                vider();
                ReadCar_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Suppression " + ex);
            }
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




            try
            {
                Car_Class.Modifier(int.Parse(getCarId.Text), NomCarBox.Text, MarqueCarBox.Text, MatriculeCarBox.Text ,ColorCarBox.Text,20);
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

        private void ListViewCar_SelectedIndexChanged(object sender, EventArgs e)
        {

            // ListViewCar.Clear();
            if (ListViewCar.SelectedItems.Count > 0)
            {
                int il;
                ListViewItem selectedItem = ListViewCar.SelectedItems[0];
                il = int.Parse(selectedItem.SubItems[5].Text);
                string queryS = "select * from Car where id=" + il;
                SqlConnection cnx = cn.GetConnection();
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd = new SqlCommand(queryS, cnx);

                cnx.Open();
                //SqlDataReader reader = cmd.ExecuteReader();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    getCarId.Text = ListViewCar.SelectedItems[0].SubItems[5].Text;
                    if (reader.Read())
                    {

                        NomCarBox.Text = reader["nom"].ToString();

                        MatriculeCarBox.Text = reader["matricule"].ToString();
                        ColorCarBox.Text = reader["Color"].ToString();
                        //in fonctionne selement si est la derniere
                        MarqueCarBox.Text = reader["marque"].ToString();
                    }


                }
                cnx.Close();
            }

        }

        private void ColorCarBox_TextChanged(object sender, EventArgs e)
        {
            /*
            try
            {
                ListViewCar.Items.Clear();

                SqlConnection cnx = cn.GetConnection();
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                string t = ColorCarBox.Text;
                String query = "select * from car where Color LIKE @color";

                cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@color", "%" + t + "%");
                cnx.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem items = new ListViewItem(reader["nom"].ToString());

                    items.SubItems.Add(reader["marque"].ToString());
                    items.SubItems.Add(reader["matricule"].ToString());
                    items.SubItems.Add(reader["Color"].ToString());
                    items.SubItems.Add(reader["Prix"].ToString());
                    items.SubItems.Add(reader["id"].ToString());
                    ListViewCar.Items.Add(items);
                }
                
                cnx.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERREUR d'affichage " + ex);
            }
            */
        }
        //cmd.Parameters.AddWithValue("@Marque", "%" + t + "%");
        private void MarqueCarBox_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                ListViewCar.Items.Clear();

                SqlConnection cnx = cn.GetConnection();
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                string t = MarqueCarBox.Text;
                String query = "select * from car where marque LIKE @marque";

                cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@marque", "%" + t + "%");
                cnx.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem items = new ListViewItem(reader["nom"].ToString());

                    items.SubItems.Add(reader["marque"].ToString());
                    items.SubItems.Add(reader["matricule"].ToString());
                    items.SubItems.Add(reader["Color"].ToString());
                    items.SubItems.Add(reader["Prix"].ToString());
                    items.SubItems.Add(reader["id"].ToString());
                    ListViewCar.Items.Add(items);
                }

                cnx.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERREUR d'affichage " + ex);
            }

        }

        private void NomCarBox_TextChanged(object sender, EventArgs e)
        {
            /* SqlConnection cnx = cn.GetConnection();
             try
             {
                 ListViewCar.Items.Clear();


                 string t = NomCarBox.Text;
                 String query = "select * from car where nom LIKE @Nom";

                 cmd = new SqlCommand(query, cnx);
                 if (cnx.State == ConnectionState.Open)
                 {
                     cnx.Close();
                 }
                 cmd.Parameters.AddWithValue("@Nom", "%" + t + "%");
                 cnx.Open();
                 SqlDataReader reader = cmd.ExecuteReader();

                 while (reader.Read())
                 {
                     ListViewItem items = new ListViewItem(reader["Nom"].ToString());

                     items.SubItems.Add(reader["marque"].ToString());
                     items.SubItems.Add(reader["matricule"].ToString());
                     items.SubItems.Add(reader["Color"].ToString());
                     items.SubItems.Add(reader["Prix"].ToString());
                     items.SubItems.Add(reader["id"].ToString());
                     ListViewCar.Items.Add(items);
                 }
                 reader.Close();


             }
             catch (Exception ex)
             {

                 MessageBox.Show("ERREUR d'affichage " + ex);
             }
             cnx.Close();*/
        }

        private void MatriculeCarBox_TextChanged(object sender, EventArgs e)
        {

            /*SqlConnection cnx = cn.GetConnection();
            if (cnx.State == ConnectionState.Open)
            {
                cnx.Close();
            }
            try
            {
                ListViewCar.Items.Clear();

                
                string t = MatriculeCarBox.Text;
                String query = "select * from car where matricule LIKE @Matricule";

                cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@Matricule", "%" + t + "%");
                cnx.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem items = new ListViewItem(reader["nom"].ToString());

                    items.SubItems.Add(reader["marque"].ToString());
                    items.SubItems.Add(reader["matricule"].ToString());
                    items.SubItems.Add(reader["Color"].ToString());
                    items.SubItems.Add(reader["Prix"].ToString());
                    items.SubItems.Add(reader["id"].ToString());
                    ListViewCar.Items.Add(items);
                }
                reader.Close();
                cnx.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("ERREUR d'affichage " + ex);
            }*/
        }
    }
}
