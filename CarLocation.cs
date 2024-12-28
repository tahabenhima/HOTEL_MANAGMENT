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
        static private Connection_Classe cn;
        public CarLocation()
        {
            InitializeComponent();
            //RemplirComboColor();
        }

        private void CarLocation_Load(object sender, EventArgs e)
        {

        }

        private void SearchCarLocationBtn_Click(object sender, EventArgs e)
        {
            /*string query = "SELECT Brand, Model, Color FROM Cars WHERE 1=1";

            if (DateDebutCarLocation.Value != DateFinCarLocation.Value)
            {
                query += " AND Date BETWEEN @StartDate AND @EndDate";
            }

            if (MarquecarLocationComboBox.SelectedItem != null && !string.IsNullOrEmpty(MarquecarLocationComboBox.SelectedItem.ToString()))
            {
                query += " AND Brand = @Brand";
            }

            if (ModelCarLocationComboBox.SelectedItem != null && !string.IsNullOrEmpty(ModelCarLocationComboBox.SelectedItem.ToString()))
            {
                query += " AND Model = @Model";
            }

            if (!string.IsNullOrEmpty(ColorCararLocationComboBox.Text))
            {
                query += " AND Color = @Color";
            }*/
        }

        private void Carbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Car c = new Car();
            c.Show();
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
