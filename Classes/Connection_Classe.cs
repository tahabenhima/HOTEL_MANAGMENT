using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGMENT.Classes
{
    internal class Connection_Classe
    {
        string cnChaine;
        SqlConnection cn;
        SqlCommand cmd;
        public SqlConnection GetConnection()
        {
            return cn;
        }
        public Connection_Classe() { 
        this.cnChaine= "Data Source=DESKTOP;Initial Catalog=Gestion_Hotel;Integrated Security=True;";
        this.cn = new SqlConnection(cnChaine); 
        

            

        }
        

    }
}
