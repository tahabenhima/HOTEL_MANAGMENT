using System.Data.SqlClient;
namespace HOTEL_MANAGMENT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cnChaine = "Data Source=DESKTOP;Initial Catalog=Gestion_Hotel;Integrated Security=True;Trust Server Certificate=True";
            SqlConnection cn = new SqlConnection(cnChaine);
        }
    }
}
