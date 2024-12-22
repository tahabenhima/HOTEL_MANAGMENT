using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;

namespace HOTEL_MANAGMENT.Classes
{
    internal class Spa_Classe
    {  
        public   int   Nbr_Seances { get; set; }
        private static SqlCommand cmd;
        private static Connection_Classe cn;


        public Spa_Classe(int Nbr_Seances) {
            this.Nbr_Seances = Nbr_Seances;
            cn = new Connection_Classe();


        } 

    /////////////////ajouter/////////
        public   void Ajouter_Spa()
        {
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string req = "insert into  Spa  (Nbr_Seances) values (@Nbr_Seances)";
            cmd = new SqlCommand(req, cnx);
            cmd.Parameters.AddWithValue("@Nbr_Seances",  Nbr_Seances);
            try
            {

                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Spa insere!");



            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);

            }
            cnx.Close();

        }



////////////////SUPPRIMER////////////
       public static void Supprimer_Spa(int id)
        {
            cn = new Connection_Classe();
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string req1 = "delete  from Spa where id=@id";
            cmd = new SqlCommand(req1, cnx);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {

                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Spa Suprimme!");



            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);

            }
            cnx.Close();

        }

//////////////////AFFICHER/////////////////////
         public static ListView Afficher_Spa()
        {
            ListView l = new ListView { };
            cn = new Connection_Classe();
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string req2 = "select * from Spa";
            cmd = new SqlCommand(req2, cnx);
            try
            {

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {


                    ListViewItem items = new ListViewItem(reader["id"].ToString());
                    items.SubItems.Add(reader["Nbr_Seances"].ToString());
                    l.Items.Add(items);


                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR " + ex);
            }
            cnx.Close();
            return l;

        }

///////////MODIFIER////////////////////////////////////
         public static void Modifier_Spa(int id, int Nbr_Seances)
        {
            cn = new Connection_Classe();
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string req3 = "UPDATE Spa SET  Nbr_Seances=@Nbr_Seances  where id=@id";
            cmd = new SqlCommand(req3, cnx);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@Nbr_Seances", Nbr_Seances);
            try
            {

                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Spa modifie!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);
            }

            cnx.Close();


        }

    }
}
