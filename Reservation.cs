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




        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

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
                SearchCarLocationBtn.Visible = true;
                labelMsg.Visible = true;
                label3.Visible = true;
                DateDebutCarLocation.Visible = true;
                label7.Visible = true;
                DateFinCarLocation.Visible = true;
                label6.Visible = true;
                labelNom.Visible = true;
                label5.Visible = true;
                labelMarque.Visible = true;
                label4.Visible = true;
                labelCouleur.Visible = true;
                ListViewCar.Visible = true;
                label9.Visible = true;

            }
            else
            {
                SearchCarLocationBtn.Visible = false;
                labelMsg.Visible = false;
                label3.Visible = false;
                DateDebutCarLocation.Visible = false;
                label7.Visible = false;
                DateFinCarLocation.Visible = false;
                label6.Visible = false;
                labelNom.Visible = false;
                label5.Visible = false;
                labelMarque.Visible = false;
                label4.Visible = false;
                labelCouleur.Visible = false;
                ListViewCar.Visible = false;
                label9.Visible = false;
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

        private void SearchCarLocationBtn_Click_1(object sender, EventArgs e)
        {
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

        private void ListViewCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewCar.SelectedItems.Count > 0)
            {
                int il;
                ListViewItem selectedItem = ListViewCar.SelectedItems[0];
                il = int.Parse(selectedItem.SubItems[5].Text);
                string queryS = "select * from Car where id=" + il;
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
                getCarId.Text = ListViewCar.SelectedItems[0].SubItems[5].Text;
                labelNom.Text = selectedItem.SubItems[0].Text;
                labelMatricule.Text = selectedItem.SubItems[2].Text;
                labelCouleur.Text = selectedItem.SubItems[3].Text;
                labelPrix.Text = selectedItem.SubItems[4].Text;
                labelMarque.Text = selectedItem.SubItems[1].Text;
            }
        }

       
    }
}
