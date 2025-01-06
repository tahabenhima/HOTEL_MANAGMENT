using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGMENT.Classes
{
    internal class Reservation_Class
    {
        public Client_Class client_obj { get; set; }
        
        public Chambre_Class chambre_obj { get; set; }
        public Food_Class food_obj { get; set; }
        public Spa_Classe spa_obj { get; set; }
        public Car_Class car_obj { get; set; }
        public DateTime DateArrive { get; set; }
        public DateTime DateSortie { get; set; }
        public int NbrJour { get; set; }    
        public float PrixTotal { get; set; }
        public bool Statut { get; set; }
        private static SqlCommand cmd;
        private static Connection_Classe cn = new Connection_Classe();
        // Constructor
        public Reservation_Class( DateTime dateArrive, DateTime dateSortie, float prixTotal, bool statut)
        {
            TimeSpan difference = dateSortie - dateArrive;

            // Obtenir le nombre de jours
            int NbrJour = (int)difference.TotalDays;
            NbrJour = (int)difference.TotalDays;
            DateArrive = dateArrive;
            DateSortie = dateSortie;
            PrixTotal = prixTotal;
            Statut = statut;
            cn = new Connection_Classe();

        }
        public Reservation_Class(DateTime dateArrive, DateTime dateSortie)
        {
            TimeSpan difference = dateSortie - dateArrive;

            // Obtenir le nombre de jours
            NbrJour = (int)difference.TotalDays;
           
            DateArrive = dateArrive;
            DateSortie = dateSortie;
            MessageBox.Show("" + NbrJour);
            cn = new Connection_Classe();

        }
        public Reservation_Class() { }
        // Constructor2
        public Reservation_Class(Client_Class client, Chambre_Class chambre, Food_Class food, Spa_Classe spa, Car_Class car, DateTime dateArrive, DateTime dateSortie, float prixTotal, bool statut)
        {
            TimeSpan difference = dateSortie - dateArrive;
            NbrJour = (int)difference.TotalDays;
            this.client_obj = client ;
            this.chambre_obj = chambre;
            this.food_obj = food;
            this.spa_obj = spa;
            this.car_obj = car;
            DateArrive = dateArrive;
            DateSortie = dateSortie;
            PrixTotal = prixTotal;
            Statut = statut;
            cn = new Connection_Classe();
           
        }

        public void Ajouter_Reservation()
        {
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query = "insert into Reservation (DateArrive,DateSortie,PrixTotal,Statut) values(@DateArrive,@DateSortie,@PrixTotal,@Statut";
            
            /*if(Carcheckbox)
            {
                query += ",@Client"; 
            }*/
            cmd = new SqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@DateArrive", DateArrive);
            cmd.Parameters.AddWithValue("@DateSortie", DateSortie);
            cmd.Parameters.AddWithValue("@PrixTotal", PrixTotal);
            cmd.Parameters.AddWithValue("@Statut", Statut);
            try
            {
                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation insere!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnx.Close();
            }

        }

        public static ListView AfficherchabrerNonReserve(DateTime debutLocation, DateTime finLocation,string type)
        {
            ListView l = new ListView { };

            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query2 = @"SELECT *FROM Chambre c 
            WHERE NOT EXISTS 
            (SELECT 1 FROM Reservation r
            WHERE r.id_Chambre = c.id AND r.dateSortie >= @Debut_Location AND r.dateArrive <= @Fin_Location )And c.type_Chambre= @type;";


            cmd = new SqlCommand(query2, cnx);
            cmd.Parameters.AddWithValue("@Debut_Location", debutLocation);
            cmd.Parameters.AddWithValue("@Fin_Location", finLocation);
            cmd.Parameters.AddWithValue("@type", type);
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
        public void   AjouterReserve(float prixTotal)
        {
            //int id_Client,int id_Chambre,int id_Food,int id_Spa,int id_Car

            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query = "insert into Reservation (id_Client,id_Chambre,id_Food,id_Spa,id_Car,dateArrive,dateSortie,prixtotal,statut) values (@id_Client,@id_Chambre,@id_Food,@id_Spa,@id_Car,@dateArrive,@dateSortie,@prixtotal,@statut)";
            cmd = new SqlCommand(query, cnx);
            if (food_obj != null)
            {
                int id_Food = food_obj.id_food;
                MessageBox.Show("Food " + id_Food);
                cmd.Parameters.AddWithValue("@id_Food", id_Food);
            }
            else {
                string id_Food = "NULL";
                MessageBox.Show("Food " + id_Food);
                cmd.Parameters.AddWithValue("@id_Food", id_Food);
            }

            if (spa_obj != null)
            {
                int id_Spa = spa_obj.id_Spa;
                MessageBox.Show("Spa " + id_Spa);
                cmd.Parameters.AddWithValue("@id_Spa", id_Spa);
            }
            else
            {
                string id_Spa = "NULL";
                MessageBox.Show("Spa " + id_Spa);
                cmd.Parameters.AddWithValue("@id_Spa", id_Spa);
            }

            if (car_obj != null)
            {
                int id_Car = car_obj.id_Car;
                MessageBox.Show("Car " + id_Car);
                cmd.Parameters.AddWithValue("@id_Car", id_Car);
            }
            else
            {
                string id_Car = "NULL";
                MessageBox.Show("Car " + id_Car);
                cmd.Parameters.AddWithValue("@id_Car", id_Car);
            }
            
            
            //(2,1002,NULL,NULL,NULL,'2023-10-01','2025-10-01',1200,1)
            cmd.Parameters.AddWithValue("@id_Client",this.client_obj.id_Client);
            cmd.Parameters.AddWithValue("@id_Chambre", chambre_obj.id);
            
            

            
            cmd.Parameters.AddWithValue("@dateArrive", "2023-10-01");
            cmd.Parameters.AddWithValue("@dateSortie", "2025-10-01");
            
            cmd.Parameters.AddWithValue("@prixtotal", prixTotal);
            cmd.Parameters.AddWithValue("@statut", 1);

            try
            {

                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Reservation successefuly added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);

            }
            cnx.Close();
            
        }


    }
}
