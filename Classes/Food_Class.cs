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
       /* public int Quantite { get; set; }*/
       public Boolean Full { get; set; }
        public Food_Class() { }
        public Food_Class(float prix, Boolean full)
        {
            
            Prix = prix;
            Full = full;
            
            cn = new Connection_Classe();
        }
        public Food_Class(int id_food, float prix, Boolean full)
        {
            this.id_food = id_food;
            Prix = prix;
            Full = full;

            cn = new Connection_Classe();
        }
        
        public void Ajouter_Food()
        {
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query = "insert into Food (Prix,Quantite) values(@Prix,@full)";
            cmd = new SqlCommand(query, cnx);
            
            cmd.Parameters.AddWithValue("@Prix", Prix);
            cmd.Parameters.AddWithValue("@Quantite", Full);
           
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
        public float getPrix(int id)
        {
            float prix = 0; 
            cn = new Connection_Classe();
            SqlConnection cnx = cn.GetConnection();
            cnx.Open();
            string query2 = "select * from Food where id=@id";
            cmd = new SqlCommand(query2, cnx);
            cmd.Parameters.AddWithValue("@id", id);
            try
            {

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    prix= float.Parse(reader["Prix"].ToString());
                   
                    
                }
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR " + ex);
            }
            cnx.Close();

            return prix;
        }


    }
}
