using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGMENT.Classes
{
    internal class Car_Class
    {
        int id {  get; set; }   
        public string Nom { get; set; }
        public string Marque { get; set; }
        public string Matricule { get; set; }
        public string Color { get; set; }
        public int id_Car { get; set; }
        
        public float Prix { get; set; }

        private static SqlCommand cmd;
        private static Connection_Classe cn=new Connection_Classe();

        public Car_Class() { }
        public Car_Class(string Nom, string Marque, string Matricule, string Color, float Prix )
        {
            this.Nom = Nom;
            this.Marque = Marque;
            this.Matricule = Matricule;
            this.Color = Color;
            this.Prix = Prix;


            cn = new Connection_Classe();


        }
        public Car_Class(int id ,string Nom, string Marque, string Matricule, string Color, float Prix)
        {
            this.id=id;
            this.Nom = Nom;
            this.Marque = Marque;
            this.Matricule = Matricule;
            this.Color = Color;
            this.Prix = Prix;

            cn = new Connection_Classe();


        }
        public void AjouterCar()
        {
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query = "insert into Car (Nom,Marque,Matricule,Color,Prix) values(@Nom,@Marque,@Matricule,@Color,@Prix)";
            cmd = new SqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@Nom", Nom);
            cmd.Parameters.AddWithValue("@Marque", Marque);
            cmd.Parameters.AddWithValue("@Matricule", Matricule);
            cmd.Parameters.AddWithValue("@Color", Color);
            cmd.Parameters.AddWithValue("@Prix", Prix);

            try
            {

                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Car successefuly added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);

            }
            cnx.Close();
        }


        public static void SupprimerCar(int id)
        {
            
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query1 = "delete from Car where id=@id";
            cmd = new SqlCommand(query1, cnx);
            cmd.Parameters.AddWithValue("@id", id);
           
            //le processus de suppression
            try
            {

                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Car Suprimme!");



            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);

            }
            cnx.Close();


        }


        public static ListView Afficher()
        {
            ListView l = new ListView { };
            
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query2 = "select * from Car";
            cmd = new SqlCommand(query2, cnx);
            try
            {

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem items = new ListViewItem(reader["nom"].ToString());
                    items.SubItems.Add(reader["marque"].ToString());
                    items.SubItems.Add(reader["matricule"].ToString());
                    items.SubItems.Add(reader["Color"].ToString());
                    items.SubItems.Add(reader["Prix"].ToString());
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

        public static ListView AfficherCarNonLocation(DateTime debutLocation , DateTime finLocation )
        {
            ListView l = new ListView { };

            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query2 = @" SELECT *  FROM Car c
        WHERE NOT EXISTS (
            SELECT 1
            FROM Car_Location cl
            WHERE cl.id_Car = c.id
              AND cl.Fin_Location >= @Debut_Location
              AND cl.Debut_Location <= @Fin_Location);";
            cmd = new SqlCommand(query2, cnx);
            cmd.Parameters.AddWithValue("@Debut_Location", debutLocation);
            cmd.Parameters.AddWithValue("@Fin_Location", finLocation);
            try
            {

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem items = new ListViewItem(reader["nom"].ToString());
                    items.SubItems.Add(reader["marque"].ToString());
                    items.SubItems.Add(reader["matricule"].ToString());
                    items.SubItems.Add(reader["Color"].ToString());
                    items.SubItems.Add(reader["Prix"].ToString());
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
        public static void Modifier(int id,string Nom, string Marque, string Matricule, string Color ,float Prix)
        {
            cn = new Connection_Classe();
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query3 = "UPDATE Car set Nom=@Nom,Marque=@Marque,Matricule=@Matricule,Color=@Color, Prix=@Prix where id=@id";
            cmd = new SqlCommand(query3, cnx);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@Nom", Nom);
            cmd.Parameters.AddWithValue("@Marque", Marque);
            cmd.Parameters.AddWithValue("@Matricule", Matricule);
            cmd.Parameters.AddWithValue("@Color", Color);
            cmd.Parameters.AddWithValue("@Prix", Prix);

            try
            {


                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Car modifie!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);
            }

            cnx.Close();
        }

    }
}
