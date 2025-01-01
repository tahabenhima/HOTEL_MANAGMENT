using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOTEL_MANAGMENT.Classes
{
    internal class CarLocation_Class
    {
        DateTime DateDebut { get; set; }
        DateTime DateFin { get; set; }
        Boolean isdisponible { get; set; }
        Car car { get; set;}
        int nbrjour { get;set; }
        private static SqlCommand cmd;
        private static Connection_Classe cn;


        public CarLocation_Class(DateTime dateDebut, DateTime dateFin, bool isdisponible, Car car)
        {
            DateDebut = dateDebut;
            DateFin = dateFin;
            this.isdisponible = isdisponible;
            this.car = car;
            int nbrjour = Math.Abs((DateFin - DateDebut).Days);
            cn = new Connection_Classe();
        }

      
    }
}
