using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGMENT
{
     internal class ClientClass
    {
        static string cnChaine = "Data Source=DESKTOP;Initial Catalog=Gestion_Hotel;Integrated Security=True;";
        static SqlConnection cn;
        static SqlCommand cmd;
        public ClientClass() { }


        static public Boolean DeleteClient(int e)
        {
            //ook
            try
            {
                string query3 = "delete  from Employe where id=@id";
                cn = new SqlConnection(cnChaine);
                cmd = new SqlCommand(query3, cn);
                cmd.Parameters.AddWithValue("@id", e);
                cn.Open();
                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Employe suprime");
                cn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Suppresion " + ex);
            }
            return false;
        }


        static public ListView ReadClient()
        {
            ListView list = new ListView();
            String query2 = "select * from Employe ";
            cn = new SqlConnection(cnChaine);
            cmd = new SqlCommand(query2, cn);
            try
            {
                list.Items.Clear();
                cn.Open();
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
                    list.Items.Add(items);

                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Affichage " + ex);
            }
            return list;
        }
    }
}
