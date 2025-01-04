using HOTEL_MANAGMENT.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_MANAGMENT
{
    public partial class Reservation : Form
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void Reserverbtn_Click(object sender, EventArgs e)
        {
            DateTime debutR = new DateTime(DateDebutCarLocation.Value.Year, DateDebutCarLocation.Value.Month, DateDebutCarLocation.Value.Day);
            DateTime finR = new DateTime(DateFinCarLocation.Value.Year, DateFinCarLocation.Value.Month, DateFinCarLocation.Value.Day);

            //(Client_Class client, Chambre_Class chambre, Food_Class food, Spa_Classe spa, Car_Class car, DateTime dateArrive, DateTime dateSortie, float prixTotal, bool statut)

            //(2,1002,NULL,NULL,NULL,'2023-10-01','2025-10-01',1200,1)
            Client_Class  cl = new Client_Class();
             Chambre_Class  ch = new Chambre_Class();
             Food_Class  fo = new Food_Class();
            Spa_Classe  sp = new Spa_Classe();
            Car_Class  ca = new Car_Class();
            // Reservation_Class r = new Reservation_Class(cl, ch, fo, sp, ca, debutR, finR, 1200, true);
            Reservation_Class r = new Reservation_Class();
            r.AjouterReserve();


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewCar.Items.Clear();

                DateTime debutLocation = new DateTime(DateDebutCarLocation.Value.Year, DateDebutCarLocation.Value.Month, DateDebutCarLocation.Value.Day);
                DateTime finLocation = new DateTime(DateFinCarLocation.Value.Year, DateFinCarLocation.Value.Month, DateFinCarLocation.Value.Day);
                int n = Reservation_Class.AfficherchabrerNonReserve(debutLocation, finLocation).Items.Count;
                for (int i = 0; i < n; i++)
                {
                    ListViewChambre.Items.Add((ListViewItem)Reservation_Class.AfficherchabrerNonReserve(debutLocation, finLocation).Items[i].Clone());
                }

                //vider();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Affichage  " + ex);
            }
        }

        private void SearchCarLocationBtn_Click(object sender, EventArgs e)
        {

        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }

        private void Carcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Carcheckbox.Checked)
            {
                ListViewCar.Visible = true;
                labelMsg.Visible = true;


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
            else
            {
                ListViewCar.Visible = false;
                labelMsg.Visible = false;

                label6.Visible = false;
                labelNom.Visible = false;

                label5.Visible = false;

                labelMarque.Visible = false;
                label4.Visible = false;

                labelCouleur.Visible = false;



                label9.Visible = false;
                labelMatricule.Visible = false;
                labelp.Visible = false;

                labelPrix.Visible = false;
            }
        }

        private void Spacheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (Spacheckbox.Checked)
            {
                Nbr_Seances_Label.Visible = true;
                Nbr_Seances_Box.Visible = true;
            }
            else
            {
                Nbr_Seances_Label.Visible = false;
                Nbr_Seances_Box.Visible = false;
            }
        }

        private void ListViewCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewCar.SelectedItems.Count > 0)
            {
                int il;
                ListViewItem selectedItem = ListViewCar.SelectedItems[0];
                il = int.Parse(selectedItem.SubItems[5].Text);
               
                labelNom.Visible = true;
                labelMatricule.Visible = true;
                labelCouleur.Visible = true;
                labelMarque.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label7.Visible = true;
                labelp.Visible = true;
                labelPrix.Visible = true;
                label6.Visible = true;
                label9.Visible = true;
                labelp.Visible = true;
                getCarId.Text = ListViewCar.SelectedItems[0].SubItems[5].Text;
                labelNom.Text = selectedItem.SubItems[0].Text;
                labelMatricule.Text = selectedItem.SubItems[2].Text;
                labelCouleur.Text = selectedItem.SubItems[3].Text;
                labelPrix.Text = selectedItem.SubItems[4].Text;
                labelMarque.Text = selectedItem.SubItems[1].Text;
            }
        }

        private void ListViewChambre_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*validation*/
            if (ListViewChambre.SelectedItems.Count > 0)
            {

                ListViewItem selectedItem = ListViewChambre.SelectedItems[0];
                label11.Visible = true;
                label15.Visible = true;
                label16.Visible = true;
                label17.Visible = true;
                selecType.Visible = true;
                selectNumero.Visible = true;
                selectPrix.Visible = true;
                selectCapacite.Visible = true;
                getchambreId.Text = ListViewChambre.SelectedItems[0].SubItems[4].Text;
                selecType.Text = selectedItem.SubItems[0].Text;
                selectPrix.Text = selectedItem.SubItems[2].Text;
                selectCapacite.Text = selectedItem.SubItems[3].Text;
                selectNumero.Text = selectedItem.SubItems[1].Text;
            }

        }
    }
}
