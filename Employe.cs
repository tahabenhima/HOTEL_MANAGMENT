using System.Data.SqlClient;
namespace HOTEL_MANAGMENT
{
    public partial class Employe : Form
    {
        string cnChaine = "Data Source=DESKTOP;Initial Catalog=Gestion_Hotel;Integrated Security=True;";
        SqlConnection cn;
        SqlCommand cmd;
        DateTime dt;
        public Employe()
        {
            InitializeComponent();
        }



        private void AddEmp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NomBox.Text) ||
        string.IsNullOrWhiteSpace(PrenomBox.Text) ||
        string.IsNullOrWhiteSpace(AdresseBox.Text) ||
        string.IsNullOrWhiteSpace(CINBox.Text) ||
        string.IsNullOrWhiteSpace(TelephoneBox.Text) ||
        string.IsNullOrWhiteSpace(MotDePassBox.Text) ||
        string.IsNullOrWhiteSpace(IdentifiantBox.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            if (!int.TryParse(TelephoneBox.Text, out int tele) ||
       !int.TryParse(IdentifiantBox.Text, out int loginE))
            {
                MessageBox.Show("Le champ Téléphone et Identifiant doivent être des entiers !");
                return;
            }

            dt = DateRejoinBox.Value;

            cn = new SqlConnection(cnChaine);
            string query = "insert into Employe (Nom,Prenom,Adresee,CIN,Tele,DateRejoin,MotDePass,loginE) values(@Nom,@Prenom,@Adresee,@CIN,@Tele,@DateRejoin,@MotDePass,@loginE)";
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@Nom", NomBox.Text);
            cmd.Parameters.AddWithValue("@Prenom", PrenomBox.Text);
            cmd.Parameters.AddWithValue("@Adresee", AdresseBox.Text);
            cmd.Parameters.AddWithValue("@CIN", CINBox.Text);
            cmd.Parameters.AddWithValue("@Tele", int.Parse(TelephoneBox.Text));
            cmd.Parameters.AddWithValue("@DateRejoin", dt);
            cmd.Parameters.AddWithValue("@MotDePass", MotDePassBox.Text);
            cmd.Parameters.AddWithValue("@loginE", int.Parse(IdentifiantBox.Text));
            try
            {
                cn.Open();
                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Employe insere!");
                cn.Close();
                vider();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);
            }

        }

        private void ReadEmp_Click(object sender, EventArgs e)
        {
            String query2 = "select * from Employe ";
            cn = new SqlConnection(cnChaine);
            cmd = new SqlCommand(query2, cn);
            try
            {
                listViewEmp.Items.Clear();
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {


                    ListViewItem items = new ListViewItem(reader["id"].ToString());
                    items.SubItems.Add(reader["Nom"].ToString());
                    items.SubItems.Add(reader["Prenom"].ToString());
                    items.SubItems.Add(reader["Adresee"].ToString());
                    items.SubItems.Add(reader["CIN"].ToString());
                    items.SubItems.Add(reader["Tele"].ToString());
                    items.SubItems.Add(reader["DateRejoin"].ToString());
                    items.SubItems.Add(reader["MotDePass"].ToString());
                    items.SubItems.Add(reader["loginE"].ToString());
                    listViewEmp.Items.Add(items);

                }
                cn.Close();
                vider();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Affichage " + ex);
            }
        }

        private void DeleteEmp_Click(object sender, EventArgs e)
        {
            if (listViewEmp.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un employé dans la liste !");
                return;
            }

            try
            {
                string query3 = "delete  from Employe where id=@id";
                cn = new SqlConnection(cnChaine);
                cmd = new SqlCommand(query3, cn);
                cmd.Parameters.AddWithValue("@id", int.Parse(listViewEmp.SelectedItems[0].Text));
                cn.Open();
                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Employe suprime");
                cn.Close();
                vider();
                ReadEmp_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Suppresion " + ex);
            }


        }

        private void UpdateEmp_Click(object sender, EventArgs e)

        {

            if(string.IsNullOrWhiteSpace(NomBox.Text) ||
        string.IsNullOrWhiteSpace(PrenomBox.Text) ||
        string.IsNullOrWhiteSpace(AdresseBox.Text) ||
        string.IsNullOrWhiteSpace(CINBox.Text) ||
        string.IsNullOrWhiteSpace(TelephoneBox.Text) ||
        string.IsNullOrWhiteSpace(MotDePassBox.Text) ||
        string.IsNullOrWhiteSpace(IdentifiantBox.Text))
    {
                MessageBox.Show("Veuillez remplir tous les champs !");
                return;
            }

            if (!int.TryParse(TelephoneBox.Text, out int tele) ||
                !int.TryParse(IdentifiantBox.Text, out int loginE))
            {
                MessageBox.Show("Le champ Téléphone et Identifiant doivent être des entiers !");
                return;
            }
            consulterButton.Visible = true;
            UpdateEmp.Visible = false;
            dt = DateRejoinBox.Value;
            string query4 = "UPDATE Employe set Nom=@Nom,Prenom=@Prenom,Adresee=@Adresee,CIN=@CIN,Tele=@Tele,DateRejoin=@DateRejoin,MotDePass=@MotDePass,loginE=@loginE  where id=@id";


            cmd = new SqlCommand(query4, cn);
            cmd.Parameters.AddWithValue("@id", int.Parse(getid.Text));
            cmd.Parameters.AddWithValue("@Nom", NomBox.Text);
            cmd.Parameters.AddWithValue("@Prenom", PrenomBox.Text);
            cmd.Parameters.AddWithValue("@Adresee", AdresseBox.Text);
            cmd.Parameters.AddWithValue("@CIN", CINBox.Text);
            cmd.Parameters.AddWithValue("@Tele", int.Parse(TelephoneBox.Text));
            cmd.Parameters.AddWithValue("@DateRejoin", dt);
            cmd.Parameters.AddWithValue("@MotDePass", MotDePassBox.Text);
            cmd.Parameters.AddWithValue("@loginE", int.Parse(IdentifiantBox.Text));
            try
            {

                cn.Open();
                int row = cmd.ExecuteNonQuery();
                MessageBox.Show("Employe modifie!");

                cn.Close();
                vider();
                ReadEmp_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);
            }

        }

        private void consulterButton_Click(object sender, EventArgs e)
        {
            if (listViewEmp.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un employé dans la liste !");
                return;
            }
            UpdateEmp.Visible = true;
            consulterButton.Visible = false;
            string queryS = "select * from Employe where id=" + int.Parse(listViewEmp.SelectedItems[0].Text);
            cn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            getid.Text = listViewEmp.SelectedItems[0].Text;
            while (reader.Read())
            {
                dt = DateTime.Parse(reader["DateRejoin"].ToString());
                NomBox.Text = reader["Nom"].ToString();
                PrenomBox.Text = reader["Prenom"].ToString();
                AdresseBox.Text = reader["Adresee"].ToString();
                CINBox.Text = reader["CIN"].ToString();
                TelephoneBox.Text = reader["Tele"].ToString();
                DateRejoinBox.Value = dt;
                MotDePassBox.Text = reader["MotDePass"].ToString();
                IdentifiantBox.Text = reader["loginE"].ToString();



            }
            cn.Close();

        }


        void vider()
        {
            NomBox.Clear();
            PrenomBox.Clear();
            AdresseBox.Clear();
            CINBox.Clear();
            TelephoneBox.Clear();
            DateRejoinBox.Value = DateTime.Now;
            MotDePassBox.Clear();
            IdentifiantBox.Clear();
        }

        private void Employe_Load(object sender, EventArgs e)
        {

        }

        private void Nom_Click(object sender, EventArgs e)
        {

        }
    }
}
