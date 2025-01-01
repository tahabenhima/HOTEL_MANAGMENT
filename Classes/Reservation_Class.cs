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
        public float PrixTotal { get; set; }
        public bool Statut { get; set; }
        private static SqlCommand cmd;
        private static Connection_Classe cn;
        // Constructor
        public Reservation_Class( DateTime dateArrive, DateTime dateSortie, float prixTotal, bool statut)
        {
            
            DateArrive = dateArrive;
            DateSortie = dateSortie;
            PrixTotal = prixTotal;
            Statut = statut;
            cn = new Connection_Classe();

        }

        // Constructor2
        public Reservation_Class(Client_Class client, Chambre_Class chambre, Food_Class food, Spa_Classe spa, Car_Class car, DateTime dateArrive, DateTime dateSortie, float prixTotal, bool statut)
        {
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



    }
}
