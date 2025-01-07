namespace HOTEL_MANAGMENT
{
    partial class Client
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            listViewClient = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            DeleteClient = new Guna.UI2.WinForms.Guna2Button();
            ReadClient = new Guna.UI2.WinForms.Guna2Button();
            telechargerCSVbtn = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // listViewClient
            // 
            listViewClient.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewClient.Location = new Point(38, 90);
            listViewClient.Margin = new Padding(2);
            listViewClient.Name = "listViewClient";
            listViewClient.Size = new Size(1174, 215);
            listViewClient.TabIndex = 33;
            listViewClient.UseCompatibleStateImageBehavior = false;
            listViewClient.View = View.Details;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "id";
            columnHeader9.Width = 70;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nom";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Prenom";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Adresse";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "CIN";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Telephone";
            columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Date de Rejoin";
            columnHeader6.Width = 250;
            // 
            // DeleteClient
            // 
            DeleteClient.CustomizableEdges = customizableEdges1;
            DeleteClient.DisabledState.BorderColor = Color.DarkGray;
            DeleteClient.DisabledState.CustomBorderColor = Color.DarkGray;
            DeleteClient.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            DeleteClient.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            DeleteClient.Font = new Font("Segoe UI", 9F);
            DeleteClient.ForeColor = Color.White;
            DeleteClient.Location = new Point(353, 341);
            DeleteClient.Margin = new Padding(2);
            DeleteClient.Name = "DeleteClient";
            DeleteClient.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DeleteClient.Size = new Size(172, 34);
            DeleteClient.TabIndex = 36;
            DeleteClient.Text = "Supprimer ";
            DeleteClient.Click += DeleteClient_Click;
            // 
            // ReadClient
            // 
            ReadClient.CustomizableEdges = customizableEdges3;
            ReadClient.DisabledState.BorderColor = Color.DarkGray;
            ReadClient.DisabledState.CustomBorderColor = Color.DarkGray;
            ReadClient.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ReadClient.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ReadClient.Font = new Font("Segoe UI", 9F);
            ReadClient.ForeColor = Color.White;
            ReadClient.Location = new Point(759, 341);
            ReadClient.Margin = new Padding(2);
            ReadClient.Name = "ReadClient";
            ReadClient.ShadowDecoration.CustomizableEdges = customizableEdges4;
            ReadClient.Size = new Size(172, 34);
            ReadClient.TabIndex = 39;
            ReadClient.Text = "Afficher";
            ReadClient.Click += ReadClient_Click;
            // 
            // telechargerCSVbtn
            // 
            telechargerCSVbtn.BorderColor = Color.Gray;
            telechargerCSVbtn.BorderRadius = 5;
            telechargerCSVbtn.BorderThickness = 1;
            telechargerCSVbtn.CustomizableEdges = customizableEdges5;
            telechargerCSVbtn.DisabledState.BorderColor = Color.DarkGray;
            telechargerCSVbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            telechargerCSVbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            telechargerCSVbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            telechargerCSVbtn.FillColor = SystemColors.Control;
            telechargerCSVbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            telechargerCSVbtn.ForeColor = Color.Black;
            telechargerCSVbtn.Image = Properties.Resources._6133884;
            telechargerCSVbtn.Location = new Point(478, 416);
            telechargerCSVbtn.Name = "telechargerCSVbtn";
            telechargerCSVbtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            telechargerCSVbtn.Size = new Size(335, 30);
            telechargerCSVbtn.TabIndex = 49;
            telechargerCSVbtn.Text = "Telecharger les données sous form csv";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 473);
            Controls.Add(telechargerCSVbtn);
            Controls.Add(ReadClient);
            Controls.Add(DeleteClient);
            Controls.Add(listViewClient);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Client";
            Text = "Client";
            ResumeLayout(false);
        }

        #endregion
        private ListView listViewClient;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Guna.UI2.WinForms.Guna2Button DeleteClient;
        private Guna.UI2.WinForms.Guna2Button ReadClient;
        private Guna.UI2.WinForms.Guna2Button telechargerCSVbtn;
    }
}