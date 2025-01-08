using HOTEL_MANAGMENT.Classes;
using System.Data.SqlClient;
namespace HOTEL_MANAGMENT
{
    public partial class Employe : Form
    {

        SqlCommand cmd;
        DateTime dt;
        object se = new object();

        EventArgs ev = new EventArgs();
        private static Connection_Classe cn = new Connection_Classe();
        public Employe()
        {
            InitializeComponent();
            ReadEmp_Click(se, ev);
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

            if (!int.TryParse(IdentifiantBox.Text, out int loginE))
            {
                MessageBox.Show("Le champ Téléphone et Identifiant doivent être des entiers !");
                return;
            }

            dt = DateRejoinBox.Value;
            Employe_Classe EMP = new Employe_Classe(NomBox.Text, PrenomBox.Text, AdresseBox.Text, CINBox.Text, TelephoneBox.Text, dt, MotDePassBox.Text, int.Parse(IdentifiantBox.Text));
            SqlConnection cnx = cn.GetConnection();

            EMP.Ajouter_Emp();
            vider();
            ReadEmp_Click(sender, e);


        }
        ////////////////////AFFICHER//////////////////////////////////////////////////////
        private void ReadEmp_Click(object sender, EventArgs e)
        {


            try
            {
                listViewEmp.Items.Clear();
                Employe_Classe.Afficher();

                for (int i = 0; i < Employe_Classe.Afficher().Items.Count; i++)
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

            if (!int.TryParse(IdentifiantBox.Text, out int loginE))
            {
                MessageBox.Show("Le champ Téléphone et Identifiant doivent être des entiers !");
                return;
            }


            consulterButton.Visible = true;
            UpdateEmp.Visible = false;
            try
            {
                Employe_Classe.Modifier(int.Parse(getid.Text), NomBox.Text, PrenomBox.Text, AdresseBox.Text, CINBox.Text, TelephoneBox.Text, DateRejoinBox.Value, MotDePassBox.Text, int.Parse(IdentifiantBox.Text));
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
            if (reader.Read())
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

        private void NomBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void getid_Click(object sender, EventArgs e)
        {

        }

        private void telechargerCSVbtn_Click(object sender, EventArgs e)
        {
            string queryCh = "SELECT * FROM Employe";
            SqlConnection cnx = cn.GetConnection();
            SqlCommand cmd = new SqlCommand(queryCh, cnx);

            cnx.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            // Pour nommer et choisir le chemin
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                Title = "Choisissez l'emplacement pour sauvegarder le fichier CSV",
                FileName = "table_Employe.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Création du fichier CSV
                string filePath = saveFileDialog.FileName;
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Écrire les en-têtes des colonnes
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        writer.Write(reader.GetName(i));
                        if (i < reader.FieldCount - 1)
                            writer.Write(",");
                    }
                    writer.WriteLine();

                    // Écrire les lignes
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            string value = reader[i].ToString();
                            // Entourez les valeurs contenant des virgules ou des caractères spéciaux avec des guillemets
                            if (value.Contains(",") || value.Contains("\n") || value.Contains("\r") || value.Contains("\""))
                            {
                                value = "\"" + value.Replace("\"", "\"\"") + "\"";
                            }
                            writer.Write(value);
                            if (i < reader.FieldCount - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();
                    }
                }

                MessageBox.Show($"Les données ont été exportées avec succès vers : {filePath}");
                cnx.Close();
            }
            else
            {
                MessageBox.Show("Exportation annulée par l'utilisateur.");
                cnx.Close();
            }
        }
    }
}
