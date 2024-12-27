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
        string Nom { get; set; }
        string Marque { get; set; }
        string Matricule { get; set; }
        string Color { get; set; }

        private static SqlCommand cmd;
        private static Connection_Classe cn;


        public Car_Class(string Nom, string Marque, string Matricule, string Color )
        {
            this.Nom = Nom;
            this.Marque = Marque;
            this.Matricule = Matricule;
            this.Color = Color;

            cn = new Connection_Classe();


        }
        public Car_Class(int id ,string Nom, string Marque, string Matricule, string Color)
        {
            this.id=id;
            this.Nom = Nom;
            this.Marque = Marque;
            this.Matricule = Matricule;
            this.Color = Color;

            cn = new Connection_Classe();


        }
        public void AjouterCar()
        {
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query = "insert into Car (Nom,Marque,Matricule,Color) values(@Nom,@Marque,@Matricule,@Color)";
            cmd = new SqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@Nom", Nom);
            cmd.Parameters.AddWithValue("@Marque", Marque);
            cmd.Parameters.AddWithValue("@Matricule", Matricule);
            cmd.Parameters.AddWithValue("@Color", Color);
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
            cn = new Connection_Classe();
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query1 = "delete  from Car where id=@id";
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
            cn = new Connection_Classe();
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query2 = "select * from Car";
            cmd = new SqlCommand(query2, cnx);
            try
            {

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem items = new ListViewItem(reader["Nom"].ToString());
                    items.SubItems.Add(reader["Marque"].ToString());
                    items.SubItems.Add(reader["Matricule"].ToString());
                    items.SubItems.Add(reader["Color"].ToString());
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

        public static void Modifier(int id,string Nom, string Marque, string Matricule, string Color)
        {
            cn = new Connection_Classe();
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query3 = "UPDATE Car set Nom=@Nom,Marque=@Marque,Matricule=@Matricule,Color=@Color  where id=@id";
            cmd = new SqlCommand(query3, cnx);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@Nom", Nom);
            cmd.Parameters.AddWithValue("@Marque", Marque);
            cmd.Parameters.AddWithValue("@Matricule", Matricule);
            cmd.Parameters.AddWithValue("@Color", Color);
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
