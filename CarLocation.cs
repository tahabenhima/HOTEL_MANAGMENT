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
            //FROM Car c WHERE NOT EXISTS (SELECT 1 FROM Car_Location cl WHERE cl.id_Car = c.id AND cl.Fin_Location >= '2023-10-01'AND cl.Debut_Location <= '2025-10-01')

            try
            {
                ListViewCar.Items.Clear();

                DateTime debutLocation = new DateTime(DateDebutCarLocation.Value.Year, DateDebutCarLocation.Value.Month, DateDebutCarLocation.Value.Day);
                DateTime finLocation = new DateTime(DateFinCarLocation.Value.Year, DateFinCarLocation.Value.Month, DateFinCarLocation.Value.Day);
                int n = Car_Class.AfficherCarNonLocation(debutLocation, finLocation).Items.Count;
                for (int i = 0; i < n; i++)
                {
                    ListViewCar.Items.Add((ListViewItem)Car_Class.AfficherCarNonLocation(debutLocation, finLocation).Items[i].Clone());
                }

                //vider();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Affichage  " + ex);
            }
        }

        private void Carbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Car c = new Car();
            c.Show();
        }

        private void ListViewCar_SelectedIndexChanged(object sender, EventArgs e)
        {

            // ListViewCar.Clear();
            if (ListViewCar.SelectedItems.Count > 0)
            {
                int il;
                ListViewItem selectedItem = ListViewCar.SelectedItems[0];
                il = int.Parse(selectedItem.SubItems[5].Text);
                string queryS = "select * from Car where id=" + il;
                SqlConnection cnx = cn.GetConnection();
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }
                cmd = new SqlCommand(queryS, cnx);

                cnx.Open();
                //SqlDataReader reader = cmd.ExecuteReader();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    getCarId.Text = ListViewCar.SelectedItems[0].SubItems[5].Text;
                    if (reader.Read())
                    {
                        labelNom.Visible = true;
                        labelMatricule.Visible = true;
                        labelCouleur.Visible = true;
                        labelMarque.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label7.Visible = true;

                        labelNom.Text = reader["nom"].ToString();

                        labelMatricule.Text = reader["matricule"].ToString();
                        labelCouleur.Text = reader["Color"].ToString();
                        //in fonctionne selement si est la derniere
                        labelMarque.Text = reader["marque"].ToString();
                    }


                }
                cnx.Close();

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

}
