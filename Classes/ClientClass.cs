using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGMENT.Classes
{
    internal class ClientClass
    {
        string Nom { get; set; }
        string Prenom { get; set; }
        string Adresse { get; set; }
        string CIN { get; set; }
        int Tele { get; set; }
        DateTime DateRejoin { get; set; }
        static private SqlCommand cmd;
        static private Connection_Classe cn;
        public ClientClass(string Nom, string Prenom, string Adresse, string CIN, int Tele, DateTime DateRejoin)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Adresse = Adresse;
            this.CIN = CIN;
            this.Tele = Tele;
            this.DateRejoin = DateRejoin;

            cn = new Connection_Classe();
        }

        static public Boolean DeleteClient(int e)
        {
            try
            {
                string query = "delete from Client where id=@id";
                SqlConnection cnx = cn.GetConnection();

                cmd = new SqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@id", e);
                cnx.Open();
                int row = cmd.ExecuteNonQuery();
                cnx.Close();

                return row > 0;


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Suppresion " + ex);
            }
            return false;
        }

//
        static public ListView ReadClient()
        {
           
            ListView list = new ListView();
            try
            {
                cn = new Connection_Classe();
                SqlConnection cnx = cn.GetConnection();
            String query = "select * from Client ";
            cmd = new SqlCommand(query, cnx);

                list.Items.Clear();
                cnx.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {


                    ListViewItem items = new ListViewItem(reader["id"].ToString());
                    items.SubItems.Add(reader["Nom"].ToString());
                    items.SubItems.Add(reader["Prenom"].ToString());
                    items.SubItems.Add(reader["Adresee"].ToString());
                    items.SubItems.Add(reader["CIN"].ToString());
                    items.SubItems.Add(reader["Tele"].ToString());
                    items.SubItems.Add(reader["DateRejoin"].ToString());

                    list.Items.Add(items);

                }
                cnx.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Affichage " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return list;
        }
    }
}



