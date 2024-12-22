using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections;
namespace HOTEL_MANAGMENT.Classes
{
    internal class Employe_Classe
    {
        string Nom { get; set; }
        string Prenom { get; set; }
        string Adresee { get; set; }
        string CIN { get; set; }
        string Tele { get; set; }
        DateTime DateRejoin { get; set; }
        string MotDePass { get; set; }
        int LoginE { get; set; }
        private static SqlCommand cmd;
        private static Connection_Classe cn;

        public Employe_Classe(string Nom, string Prenom, string Adresee, string CIN, string Tele, DateTime DateRejoin, string MotDePass, int loginE)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
            this.Adresee = Adresee;
            this.CIN = CIN;
            this.Tele= Tele;
            this.DateRejoin = DateRejoin;
            this.MotDePass = MotDePass;
            this.LoginE=loginE;

            cn = new Connection_Classe();


        }

        public void Ajouter_Emp()
        {
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query = "insert into Employe (Nom,Prenom,Adresee,CIN,Tele,DateRejoin,MotDePass,loginE) values(@Nom,@Prenom,@Adresee,@CIN,@Tele,@DateRejoin,@MotDePass,@loginE)";
            cmd = new SqlCommand(query, cnx);
            cmd.Parameters.AddWithValue("@Nom", Nom);
            cmd.Parameters.AddWithValue("@Prenom", Prenom);
            cmd.Parameters.AddWithValue("@Adresee", Adresee);
            cmd.Parameters.AddWithValue("@CIN", CIN);
            cmd.Parameters.AddWithValue("@Tele", Tele);
            cmd.Parameters.AddWithValue("@DateRejoin", DateRejoin);
            cmd.Parameters.AddWithValue("@MotDePass", MotDePass);
            cmd.Parameters.AddWithValue("@loginE", (LoginE));
            try
            {
                
                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Employe insere!");
                
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);

            }
            cnx.Close();
        }


///////SUPPRIMER EMPLOYE////////
       public static void Supprimer_Emp(int id)
        {
            cn = new Connection_Classe();
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query1 = "delete  from Employe where id=@id";
            cmd = new SqlCommand(query1, cnx);
            cmd.Parameters.AddWithValue("@id", id);

            //le processus de suppression
            try
            {

                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Employe Suprimme!");



            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);

            }
            cnx.Close();


        }

///////////AFFICHER/////////////

        public static ListView Afficher()
        {
            ListView l=new ListView { };
            cn = new Connection_Classe();
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query2 = "select * from Employe";
            cmd = new SqlCommand(query2, cnx);
            try
            {
                
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
                    items.SubItems.Add(reader["MotDePass"].ToString());
                    items.SubItems.Add(reader["loginE"].ToString());
                    l.Items.Add(items);
                    

                }
                
                

            }
            catch(Exception ex)
            {
                MessageBox.Show("ERREUR " + ex);
            }
            cnx.Close();
            return l;

        }
///////////MODIFIER/////////////////////////////

        public static void Modifier(int id, string nom, string prenom, string adresse, string cin, string tele, DateTime dt, string motDePass, int loginE)
        {

            //DateTime dt = DateRejoinBox.Value;
            cn = new Connection_Classe();
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query3 = "UPDATE Employe set Nom=@Nom,Prenom=@Prenom,Adresee=@Adresee,CIN=@CIN,Tele=@Tele,DateRejoin=@DateRejoin,MotDePass=@MotDePass,loginE=@loginE  where id=@id";
            cmd = new SqlCommand(query3, cnx);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@Nom", nom);
            cmd.Parameters.AddWithValue("@Prenom", prenom);
            cmd.Parameters.AddWithValue("@Adresee", adresse);
            cmd.Parameters.AddWithValue("@CIN", cin);
            cmd.Parameters.AddWithValue("@Tele", tele);
            cmd.Parameters.AddWithValue("@DateRejoin", dt);
            cmd.Parameters.AddWithValue("@MotDePass", motDePass);
            cmd.Parameters.AddWithValue("@loginE", loginE);
            try
            {

                
                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Employe modifie!");

                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);
            }

            cnx.Close();
        }

    }
}
