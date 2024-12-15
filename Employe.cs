using HOTEL_MANAGMENT.Classes;
using System.Data.SqlClient;
namespace HOTEL_MANAGMENT
{
    public partial class Employe : Form
    {
        
        SqlCommand cmd;
        DateTime dt;
        private static Connection_Classe cn=new Connection_Classe();
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
            Employe_Classe EMP = new Employe_Classe(NomBox.Text, PrenomBox.Text, AdresseBox.Text, CINBox.Text, int.Parse(TelephoneBox.Text), dt, MotDePassBox.Text, int.Parse(IdentifiantBox.Text));
            SqlConnection cnx = cn.GetConnection();

            EMP.Ajouter_Emp();
            
      

        }
////////////////////AFFICHER//////////////////////////////////////////////////////
        private void ReadEmp_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                listViewEmp.Items.Clear();
                Employe_Classe.Afficher();

                for(int i= 0;i< Employe_Classe.Afficher().Items.Count; i++)
                {
                    listViewEmp.Items.Add((ListViewItem)Employe_Classe.Afficher().Items[i].Clone()); 
                }
 
                vider();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Affichage " + ex);
            }
        }
//////////////////////////////////////////////////////////////////////////


//////////SUPPRIMER////////////////////////////////////////////////////////
        private void DeleteEmp_Click(object sender, EventArgs e)
        {
            if (listViewEmp.SelectedItems.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un employé dans la liste !");
                return;
            }

            try
            {
                Employe_Classe.Supprimer_Emp(int.Parse(listViewEmp.SelectedItems[0].Text));
                vider();
                ReadEmp_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR Suppresion " + ex);
            }


        }
//////////////////////////////////////////////////////////////////////////////////

/////////////////////MODIFIER-----UPDATE/////////////////////////////////////////////

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
            try
            {
                Employe_Classe.Modifier(int.Parse(getid.Text),NomBox.Text,PrenomBox.Text,AdresseBox.Text,CINBox.Text,int.Parse(TelephoneBox.Text),DateRejoinBox.Value,MotDePassBox.Text,int.Parse(IdentifiantBox.Text));
                vider();
                ReadEmp_Click(sender, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR" + ex);
            }

        }



        /////////////////////////////////////////////////////////////////////////////////
        
            

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
            SqlConnection cnx = cn.GetConnection();
            cmd = new SqlCommand(queryS, cnx);
            
            cnx.Open();
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
            cnx.Close();

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
