using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGMENT.Classes
{
    internal class Chambre_Class
    {
        public int id { get; }
        public string TypeChambre { get; set; }
        public int Numero { get; set; }
        public int Capacite { get; set; }
        public float Prix { get; set; }
        private static SqlCommand cmd;
        private static Connection_Classe cn;


        public Chambre_Class( string TypeChambre, int Numero,  int Capacite, float Prix)
        {
            
            this.TypeChambre = TypeChambre;
            this.Numero = Numero;
            this.Capacite = Capacite;
            this.Prix = Prix;
        

        }
        public Chambre_Class(int id,string TypeChambre, int Numero, int Capacite, float Prix)
        {
            this.id = id;
            this.TypeChambre = TypeChambre;
            this.Numero = Numero;
            this.Capacite = Capacite;
            this.Prix = Prix;


        }

        public void Ajouter_Chambre()
        {
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query = "insert into Chambre (type_Chambre,numero,Capacite,Prix) values(@type_Chambre,@numero,@Capacite,@Prix)";
            cmd = new SqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@type_Chambre", TypeChambre);
            cmd.Parameters.AddWithValue("@numero", Numero);
            cmd.Parameters.AddWithValue("@Capacite", Capacite);
            cmd.Parameters.AddWithValue("@Prix", Prix);
    
            try
            {

                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Chambre insere!");



            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);

            }
            cnx.Close();
        }


        ///////SUPPRIMER ////////
        public static void Supprimer_Chambre(int id)
        {
            cn = new Connection_Classe();
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query1 = "delete  from Chambre where id=@id";
            cmd = new SqlCommand(query1, cnx);
            cmd.Parameters.AddWithValue("@id", id);

            //le processus de suppression
            try
            {

                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Chambre Suprimme!");



            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);

            }
            cnx.Close();


        }

        ///////////AFFICHER/////////////

        public static ListView Afficher_chambre()
        {
            ListView l = new ListView { };
            cn = new Connection_Classe();
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query2 = "select * from Chambre";
            cmd = new SqlCommand(query2, cnx);
            try
            {

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {


                    ListViewItem items = new ListViewItem(reader["type_Chambre"].ToString());
                    items.SubItems.Add(reader["numero"].ToString());
              
                    items.SubItems.Add(reader["Prix"].ToString());
                    items.SubItems.Add(reader["Capacite"].ToString());
                    items.SubItems.Add(reader["id"].ToString());

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
        ///////////MODIFIER/////////////////////////////

        public  void Modifier_Chambre()
        {

            //DateTime dt = DateRejoinBox.Value;
            cn = new Connection_Classe();
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query3 = "UPDATE Chambre set type_Chambre=@type_Chambre,numero=@numero,Capacite=@Capacite,Prix=@Prix where id=@id";
            cmd = new SqlCommand(query3, cnx);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@type_Chambre", TypeChambre);
            cmd.Parameters.AddWithValue("@numero", Numero);
            cmd.Parameters.AddWithValue("@Capacite", Capacite);
            cmd.Parameters.AddWithValue("@Prix", Prix);
          
            try
            {


                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Chambre modifie!");




            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);
            }

            cnx.Close();
        }




    }
}
