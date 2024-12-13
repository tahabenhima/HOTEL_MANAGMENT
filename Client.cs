using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL_MANAGMENT
{
    public partial class Client : Form
    {
        string cnChaine = "Data Source=DESKTOP;Initial Catalog=Gestion_Hotel;Integrated Security=True;";
        SqlConnection cn;
        SqlCommand cmd;
        DateTime dt;
        public Client()
        {
            InitializeComponent();
        }


        private void ReadClient_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ClientClass.ReadClient().Items)
            {
                listViewClient.Items.Add((ListViewItem)item.Clone());
            }
        }





        private void DeleteClient_Click(object sender, EventArgs e)
        {
            int id=int.Parse(listViewClient.SelectedItems[0].Text);
            ClientClass.DeleteClient(id);
        }



       
    }
}
