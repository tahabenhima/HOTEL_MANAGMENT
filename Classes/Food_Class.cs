using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGMENT.Classes
{
    internal class Food_Class
    {
        SqlCommand cmd;
        Connection_Classe cn;
        public int id_food { get; set; }
        public float Prix { get; set; }
        public int Quantite { get; set; }
        public Food_Class() { }
        public Food_Class(float prix, int quantite)
        {
            
            Prix = prix;
            Quantite = quantite;
            
            cn = new Connection_Classe();
        }
        public void Ajouter_Food()
        {
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query = "insert into Food (Prix,Quantite) values(@Prix,@Quantite)";
            cmd = new SqlCommand(query, cnx);
            
            cmd.Parameters.AddWithValue("@Prix", Prix);
            cmd.Parameters.AddWithValue("@Quantite", Quantite);
           
            try
            {
                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Food insere!");
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
