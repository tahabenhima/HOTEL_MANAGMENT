﻿using System;
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
        public CarLocation_Class car_obj { get; set; }
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
            MessageBox.Show("le nombre Du Jour selectionné est : " + NbrJour);
            cn = new Connection_Classe();

        }
        public Reservation_Class() { }
        // Constructor2
        public Reservation_Class(Client_Class client, Chambre_Class chambre, Food_Class food, Spa_Classe spa, CarLocation_Class car, DateTime dateArrive, DateTime dateSortie, float prixTotal, bool statut)
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
                if (!reader.HasRows) // Vérifie si le lecteur contient des lignes
                {
                    MessageBox.Show("Aucune Chambre disponible.");
                }
                else
                {
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
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR " + ex);
            }
            cnx.Close();
            return l;

        }
        public void   AjouterReserve()
        {
            //int id_Client,int id_Chambre,int id_Food,int id_Spa,int id_Car

            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query = "insert into Reservation (id_Client,id_Chambre,id_Food,id_Spa,id_Car,dateArrive,dateSortie,prixtotal,statut) values (@id_Client,@id_Chambre,@id_Food,@id_Spa,@id_Car,@dateArrive,@dateSortie,@prixtotal,@statut)";
            cmd = new SqlCommand(query, cnx);
            if (food_obj != null)
            {
                int id_Food = food_obj.id_food;
                cmd.Parameters.AddWithValue("@id_Food", id_Food);
            }
            else {
                string id_Food = "NULL";
                cmd.Parameters.AddWithValue("@id_Food", DBNull.Value);
            }

            if (spa_obj != null)
            {
                int id_Spa = spa_obj.id_Spa;
                cmd.Parameters.AddWithValue("@id_Spa", id_Spa);
            }
            else
            {
                string id_Spa = "NULL";
                cmd.Parameters.AddWithValue("@id_Spa", DBNull.Value);
            }

            if (car_obj != null)
            {
                int id_Car = car_obj.id_carR;
                cmd.Parameters.AddWithValue("@id_Car", id_Car);
            }
            else
            {
                string id_Car = "NULL";
                cmd.Parameters.AddWithValue("@id_Car", DBNull.Value);
            }
            
            
            //(2,1002,NULL,NULL,NULL,'2023-10-01','2025-10-01',1200,1)
            cmd.Parameters.AddWithValue("@id_Client",this.client_obj.id_Client);
            cmd.Parameters.AddWithValue("@id_Chambre", chambre_obj.id);
            
            
            //DateDebutCarLocation.Value.Year, DateDebutCarLocation.Value.Month, DateDebutCarLocation.Value.Day
            
            cmd.Parameters.AddWithValue("@dateArrive", this.DateArrive);
            cmd.Parameters.AddWithValue("@dateSortie", this.DateSortie);
            
            cmd.Parameters.AddWithValue("@prixtotal", this.PrixTotal);
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

        public static ListView afficherListereservation()
        {
            ListView l = new ListView { };
            cn = new Connection_Classe();
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query2 = "select * from Reservation";
            cmd = new SqlCommand(query2, cnx);
            try
            {

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {


                    ListViewItem items = new ListViewItem(reader["id_Client"].ToString());
                    items.SubItems.Add(reader["id_Chambre"].ToString());
                    items.SubItems.Add(reader["id_Food"].ToString());
                    items.SubItems.Add(reader["id_Spa"].ToString());
                    items.SubItems.Add(reader["id_Car"].ToString());
                    items.SubItems.Add(reader["DateArrive"].ToString());
                    items.SubItems.Add(reader["DateSortie"].ToString());
                    items.SubItems.Add(reader["prixtotal"].ToString());
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

    }
}
