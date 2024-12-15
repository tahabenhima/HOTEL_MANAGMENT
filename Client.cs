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
            listViewClient.Items.Clear();
            foreach (ListViewItem item in Classes.ClientClass.ReadClient().Items)
            {
                listViewClient.Items.Add((ListViewItem)item.Clone());
            }
        }

        private void DeleteClient_Click(object sender, EventArgs e)
        {
            if (listViewClient.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a client to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult confirmResult = MessageBox.Show(
                "Are you sure you want to delete the selected client?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                int id = int.Parse(listViewClient.SelectedItems[0].Text);

                bool success = Classes.ClientClass.DeleteClient(id);

                if (success)
                {
                    MessageBox.Show("Client deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReadClient_Click(sender, e); 
                }
            }
        }



       
    }
}
