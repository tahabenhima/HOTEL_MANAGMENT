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
    public partial class Reservation_liste : Form
    {
        public Reservation_liste()
        {
            InitializeComponent();
            afficherliste();
        }

        void afficherliste()
        {
            try
            {
                listView1.Items.Clear();


                for (int i = 0; i < Reservation_Class.afficherListereservation().Items.Count; i++)
                {
                    listView1.Items.Add((ListViewItem)Reservation_Class.afficherListereservation().Items[i].Clone());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Affichage " + ex);
            }
        }

        private void telechargerCSVbtn_Click(object sender, EventArgs e)
        {
            string queryCh = "SELECT * FROM reservation";
            Connection_Classe cn = new Connection_Classe();
            
            SqlConnection cnx = cn.GetConnection();
          
            SqlCommand cmd = new SqlCommand(queryCh, cnx);

            cnx.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // Pour nommer et choisir le chemin
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Choisissez l'emplacement pour sauvegarder le fichier CSV",
                FileName = "table_reservation.csv"
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
    }
}
