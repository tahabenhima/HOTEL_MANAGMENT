using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            //Reservation_Class reservation
            Carcheckbox.Checked = true;
            if (Carcheckbox.Checked)
            {
               /* Car_Class car = new Car_Class();
                car.Marque = MarqueTxt.Text;
                car.Modele = ModeleTxt.Text;
                car.Prix = float.Parse(PrixTxt.Text);
                car.NbJours = int.Parse(NbJoursTxt.Text);
                car.Ajouter_Car();*/
            }
            else
            {
              
            }

        }
    }
}
