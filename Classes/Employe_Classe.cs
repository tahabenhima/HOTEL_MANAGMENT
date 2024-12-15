using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace HOTEL_MANAGMENT.Classes
{
    internal class Employe_Classe
    {
        string Nom { get; set; }
        string Prenom { get; set; }
        string Adresee { get; set; }
        string CIN { get; set; }
        int Tele { get; set; }
        DateTime DateRejoin { get; set; }
        string MotDePass { get; set; }
        int LoginE { get; set; }
        private SqlCommand cmd;
        private Connection_Classe cn;

        public Employe_Classe(string Nom, string Prenom, string Adresee, string CIN, int Tele, DateTime DateRejoin, string MotDePass, int loginE)
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
            cmd.Parameters.AddWithValue("@Tele", (Tele));
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

       /* public void Supprimer_Emp()
        {
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query1 = "delete  from Employe where id=@id";
       
        }*/

    }
}
