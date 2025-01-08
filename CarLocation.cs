using HOTEL_MANAGMENT.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HOTEL_MANAGMENT
{
    public partial class CarLocation : Form
    {
        static private SqlCommand cmd;
        private static Connection_Classe cn = new Connection_Classe();
        public CarLocation()
        {
            InitializeComponent();


        }

        private void CarLocation_Load(object sender, EventArgs e)
        {

        }

        private void SearchCarLocationBtn_Click(object sender, EventArgs e)
        {
            //FROM Car c WHERE NOT EXISTS (SELECT 1 FROM Car_Location cl WHERE cl.id_Car = c.id AND cl.Fin_Location >= '2023-10-01'AND cl.Debut_Location <= '2025-10-01')

            try
            {
                ListViewCar.Items.Clear();

                DateTime debutLocation = new DateTime(DateDebutCarLocation.Value.Year, DateDebutCarLocation.Value.Month, DateDebutCarLocation.Value.Day);
                DateTime finLocation = new DateTime(DateFinCarLocation.Value.Year, DateFinCarLocation.Value.Month, DateFinCarLocation.Value.Day);
                int n = Car_Class.AfficherCarNonLocation(debutLocation, finLocation).Items.Count;
                for (int i = 0; i < n; i++)
                {
                    ListViewCar.Items.Add((ListViewItem)Car_Class.AfficherCarNonLocation(debutLocation, finLocation).Items[i].Clone());
                }

                //vider();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Affichage  " + ex);
            }

        }

        private void Carbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Car c = new Car();
            c.Show();
        }
        /*msg*/
        private void ListViewCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*// ListViewCar.Clear();
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
                        labelNom.Visible = true;
                        labelMatricule.Visible = true;
                        labelCouleur.Visible = true;
                        labelMarque.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label7.Visible = true;

                        labelNom.Text = reader["nom"].ToString();

                        labelMatricule.Text = reader["matricule"].ToString();
                        labelCouleur.Text = reader["Color"].ToString();
                        //in fonctionne selement si est la derniere
                        labelMarque.Text = reader["marque"].ToString();
                    }


                }
                cnx.Close();
            }*/
            if (ListViewCar.SelectedItems.Count > 0)
            {


                int il;
                ListViewItem selectedItem = ListViewCar.SelectedItems[0];
                il = int.Parse(selectedItem.SubItems[5].Text);
                string queryS = "select * from Car where id=" + il;
                labelNom.Visible = true;
                labelMatricule.Visible = true;
                labelCouleur.Visible = true;
                labelMarque.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label7.Visible = true;
                labelp.Visible = true;
                labelPrix.Visible = true;
                getCarId.Text = ListViewCar.SelectedItems[0].SubItems[5].Text;
                labelNom.Text = selectedItem.SubItems[0].Text;
                labelMatricule.Text = selectedItem.SubItems[2].Text;
                labelCouleur.Text = selectedItem.SubItems[3].Text;
                labelPrix.Text = selectedItem.SubItems[4].Text;
                labelMarque.Text = selectedItem.SubItems[1].Text;
            }

        }

        private void telechargerCSVbtn_Click(object sender, EventArgs e)
        {
            string queryCh = "SELECT * FROM Car_Location";
            SqlConnection cnx = cn.GetConnection();
            SqlCommand cmd = new SqlCommand(queryCh, cnx);

            cnx.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // Pour nommer et choisir le chemin
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Choisissez l'emplacement pour sauvegarder le fichier CSV",
                FileName = "Car_Location.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Création du fichier CSV
                string filePath = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Écrire les en-têtes des colonnes
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        writer.Write(reader.GetName(i));
                        if (i < reader.FieldCount - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();

                    // Écrire les lignes
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            string value = reader[i].ToString();
                            // Entourez les valeurs contenant des virgules ou des caractères spéciaux avec des guillemets
                            if (value.Contains(",") || value.Contains("\n") || value.Contains("\r") || value.Contains("\""))
                            {
                                value = "\"" + value.Replace("\"", "\"\"") + "\"";
                            }
                            writer.Write(value);
                            if (i < reader.FieldCount - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();
                    }
                }

                MessageBox.Show($"Les données ont été exportées avec succès vers : {filePath}");
                cnx.Close();
            }
            else
            {
                MessageBox.Show("Exportation annulée par l'utilisateur.");
                cnx.Close();
            }
        }

        /*
                public void RemplirComboColor()
                {
                    try
                    {
                        cn = new Connection_Classe();
                        SqlConnection cnx = cn.GetConnection();
                        ModelCarLocationComboBox.Items.Clear();
                        String query = "select Mat from STAGIAIRE";
                        cmd = new SqlCommand(query, cnx);
                        cnx.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ModelCarLocationComboBox.Items.Add(reader[0]);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("ERREUR d'affichage " + ex);
                    }

                }*/
    }
}
