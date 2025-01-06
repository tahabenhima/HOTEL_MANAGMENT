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
using static Guna.UI2.Native.WinApi;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HOTEL_MANAGMENT
{
    public partial class Reservation : Form
    {
        DateTime debutLocation;
        DateTime finLocation;
        float prixT;
        Food_Class f;
        Spa_Classe sp;
        Car_Class ca;
        CarLocation_Class carL;
        Reservation_Class reservation;
        Chambre_Class chambre = new Chambre_Class();
        Client_Class Client = new Client_Class();


        public Reservation()
        {
            InitializeComponent();

        }

        private void Reserverbtn_Click(object sender, EventArgs e)
        {
           



            /*
                        DateTime debutR = new DateTime(DateDebutCarLocation.Value.Year, DateDebutCarLocation.Value.Month, DateDebutCarLocation.Value.Day);
                        DateTime finR = new DateTime(DateFinCarLocation.Value.Year, DateFinCarLocation.Value.Month, DateFinCarLocation.Value.Day);

                        //(Client_Class client, Chambre_Class chambre, Food_Class food, Spa_Classe spa, Car_Class car, DateTime dateArrive, DateTime dateSortie, float prixTotal, bool statut)

                        //(2,1002,NULL,NULL,NULL,'2023-10-01','2025-10-01',1200,1)
                        Client_Class cl = new Client_Class();
                        Chambre_Class ch = new Chambre_Class();
                        Food_Class fo = new Food_Class();
                        Spa_Classe sp = new Spa_Classe();
                        Car_Class ca = new Car_Class();
                        // Reservation_Class r = new Reservation_Class(cl, ch, fo, sp, ca, debutR, finR, 1200, true);
                        Reservation_Class r = new Reservation_Class();
                        r.AjouterReserve();
            */

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            reservation = new Reservation_Class(DateDebutCarLocation.Value, DateFinCarLocation.Value);


            try
            {


                ListViewChambre.Items.Clear();

                DateTime debutLocation = new DateTime(DateDebutCarLocation.Value.Year, DateDebutCarLocation.Value.Month, DateDebutCarLocation.Value.Day);
                DateTime finLocation = new DateTime(DateFinCarLocation.Value.Year, DateFinCarLocation.Value.Month, DateFinCarLocation.Value.Day);
                int n = Reservation_Class.AfficherchabrerNonReserve(debutLocation, finLocation, comboBox1.Text).Items.Count;
                for (int i = 0; i < n; i++)
                {
                    ListViewChambre.Items.Add((ListViewItem)Reservation_Class.AfficherchabrerNonReserve(debutLocation, finLocation, comboBox1.Text).Items[i].Clone());
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

                DateTime debutLocation = new DateTime(DateDebutCarLocation.Value.Year, DateDebutCarLocation.Value.Month, DateDebutCarLocation.Value.Day);
                DateTime finLocation = new DateTime(DateFinCarLocation.Value.Year, DateFinCarLocation.Value.Month, DateFinCarLocation.Value.Day);

                ListViewCar.Visible = true;
                labelMsg.Visible = true;


                try
                {
                    ListViewCar.Items.Clear();


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
                //        public CarLocation_Class( DateTime dateDebut, DateTime dateFin, bool isdisponible, Car_Class car)
                int idc = int.Parse(getCarId.Text);
                //public Car_Class(int id, string Nom, string Marque, string Matricule, string Color, float Prix)

                ca = new Car_Class(idc, labelNom.Text, labelMarque.Text, labelMatricule.Text, labelCouleur.Text, float.Parse(labelPrix.Text));
                carL = new CarLocation_Class(debutLocation, finLocation, true, ca);
                
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
                // reservation.NbrJour * chambre.Prix
                selectCapacite.Text = selectedItem.SubItems[3].Text;
                selectNumero.Text = selectedItem.SubItems[1].Text;

                //public Chambre_Class(int id,string TypeChambre, int Numero, int Capacite, float Prix)
                chambre = new Chambre_Class(int.Parse(getchambreId.Text), selecType.Text, int.Parse(selectNumero.Text), int.Parse(selectCapacite.Text), float
                    .Parse(selectPrix.Text));
               
            }

        }

        private void Repascheckbx_CheckedChanged(object sender, EventArgs e)
        {
            if (Repascheckbx.Checked == true)
            {
                f = new Food_Class(1, 200, true);
                
                
            }
           




        }

        private void prixtotal_Click(object sender, EventArgs e)
        {
            /*
            //       (Client_Class client, Chambre_Class chambre, Food_Class food, Spa_Classe spa, Car_Class car, DateTime dateArrive, DateTime dateSortie, float prixTotal, bool statut)
            
            */
        }

        private void Nbr_Seances_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = Nbr_Seances_Box.SelectedIndex+1;
            float p = Spa_Classe.getprix(indice);
            sp = new Spa_Classe(indice, indice, p);
            MessageBox.Show(""+sp.Prix);
           
           
        }





        private void btnVallidation_Click(object sender, EventArgs e)
        {
            prixT = 0;
            reservation = new Reservation_Class(Client, chambre, f, sp, ca, DateDebutCarLocation.Value, DateFinCarLocation.Value, chambre.Prix, true);

            label8.Visible = true;
            prixtotal.Visible = true;

            if (chambre != null)
                prixT += reservation.NbrJour * chambre.Prix;

            //MessageBox.Show("" + reservation.NbrJour);

            if (ca != null)
                prixT += reservation.NbrJour * ca.Prix;

            if (f != null)
                prixT += reservation.NbrJour * f.Prix;

            if (sp != null)
                prixT += sp.Prix;

            prixtotal.Text = prixT.ToString();
            //MessageBox.Show("" + prixT);
        }
    }
}
