namespace HOTEL_MANAGMENT
{
    partial class Reservation_liste
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            telechargerCSVbtn = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            listView1.Location = new Point(92, 73);
            listView1.Name = "listView1";
            listView1.Size = new Size(855, 272);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "id_Client";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "id_chambre";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "id_food";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "id_spa";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "id_Car";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Date_debut";
            columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Date_Sortie";
            columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Pris_Total";
            columnHeader8.Width = 100;
            // 
            // telechargerCSVbtn
            // 
            telechargerCSVbtn.BorderColor = Color.Gray;
            telechargerCSVbtn.BorderRadius = 5;
            telechargerCSVbtn.BorderThickness = 1;
            telechargerCSVbtn.CustomizableEdges = customizableEdges1;
            telechargerCSVbtn.DisabledState.BorderColor = Color.DarkGray;
            telechargerCSVbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            telechargerCSVbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            telechargerCSVbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            telechargerCSVbtn.FillColor = SystemColors.Control;
            telechargerCSVbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            telechargerCSVbtn.ForeColor = Color.Black;
            telechargerCSVbtn.Image = Properties.Resources._6133884;
            telechargerCSVbtn.Location = new Point(294, 380);
            telechargerCSVbtn.Margin = new Padding(3, 4, 3, 4);
            telechargerCSVbtn.Name = "telechargerCSVbtn";
            telechargerCSVbtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            telechargerCSVbtn.Size = new Size(383, 40);
            telechargerCSVbtn.TabIndex = 50;
            telechargerCSVbtn.Text = "Telecharger les données sous form csv";
            telechargerCSVbtn.Click += telechargerCSVbtn_Click;
            // 
            // Reservation_liste
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 585);
            Controls.Add(telechargerCSVbtn);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Reservation_liste";
            Text = "Reservation_liste";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Guna.UI2.WinForms.Guna2Button telechargerCSVbtn;
    }
}