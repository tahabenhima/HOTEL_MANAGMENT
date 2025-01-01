using HOTEL_MANAGMENT.Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HOTEL_MANAGMENT
{
    public partial class CarLocation : Form
    {
        static private SqlCommand cmd;
        private static Connection_Classe cn = new Connection_Classe();
        public CarLocation()
        {
            InitializeComponent();


        }

        private void CarLocation_Load(object sender, EventArgs e)
        {

        }

        private void SearchCarLocationBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void Carbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Car c = new Car();
            c.Show();
        }

        private void ListViewCar_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        /*
                public void RemplirComboColor()
                {
                    try
                    {
                        cn = new Connection_Classe();
                        SqlConnection cnx = cn.GetConnection();
                        ModelCarLocationComboBox.Items.Clear();
                        String query = "select Mat from STAGIAIRE";
                        cmd = new SqlCommand(query, cnx);
                        cnx.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            ModelCarLocationComboBox.Items.Add(reader[0]);
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("ERREUR d'affichage " + ex);
                    }

                }*/
    }
}
