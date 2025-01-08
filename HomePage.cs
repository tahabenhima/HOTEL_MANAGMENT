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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        public void AddControls(Form f)
        {
            ControlsPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ControlsPanel.Controls.Add(f);
            f.Show();
        }

        private void EmployesHomeBtn_Click(object sender, EventArgs e)
        {
            AddControls(new Employe());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddControls(new Client());
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            AddControls(new Reservation());
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {

        }

        private void ExitHomeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SpaHomeBtn_Click(object sender, EventArgs e)
        {
            AddControls(new Spa());
        }

        private void ChambresHomeBtn_Click(object sender, EventArgs e)
        {
            AddControls(new Chambre());
        }

        private void CarRentalHomeBtn_Click(object sender, EventArgs e)
        {
            AddControls(new CarLocation());
        }

        private void guna2Button1_Click_3(object sender, EventArgs e)
        {
            AddControls(new Car());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            AddControls(new Reservation_liste());
        }
    }
}
