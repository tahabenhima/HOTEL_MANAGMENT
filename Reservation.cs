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
            
        }

        private void ListViewCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       
    }
}
