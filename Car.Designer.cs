namespace HOTEL_MANAGMENT
{
    partial class Car
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            NomCarBox = new TextBox();
            MatriculeCarBox = new TextBox();
            MarqueCarBox = new TextBox();
            ColorCarBox = new TextBox();
            AddCar = new Guna.UI2.WinForms.Guna2Button();
            UpdateCar = new Guna.UI2.WinForms.Guna2Button();
            DeleteCar = new Guna.UI2.WinForms.Guna2Button();
            ReadCar = new Guna.UI2.WinForms.Guna2Button();
            ListViewCar = new ListView();
            Nom = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            getCarId = new Label();
            prixCarBox = new TextBox();
            label5 = new Label();
            telechargerCSVbtn = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 117);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Matricule";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 52);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 3;
            label3.Text = "Nom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(293, 114);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 4;
            label4.Text = "Couleur";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 49);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 5;
            label1.Text = "Marque";
            // 
            // NomCarBox
            // 
            NomCarBox.Location = new Point(104, 52);
            NomCarBox.Name = "NomCarBox";
            NomCarBox.Size = new Size(125, 23);
            NomCarBox.TabIndex = 6;
            NomCarBox.TextChanged += NomCarBox_TextChanged;
            // 
            // MatriculeCarBox
            // 
            MatriculeCarBox.Location = new Point(104, 117);
            MatriculeCarBox.Name = "MatriculeCarBox";
            MatriculeCarBox.Size = new Size(125, 23);
            MatriculeCarBox.TabIndex = 7;
            MatriculeCarBox.TextChanged += MatriculeCarBox_TextChanged;
            // 
            // MarqueCarBox
            // 
            MarqueCarBox.Location = new Point(382, 49);
            MarqueCarBox.Name = "MarqueCarBox";
            MarqueCarBox.Size = new Size(125, 23);
            MarqueCarBox.TabIndex = 8;
            MarqueCarBox.TextChanged += MarqueCarBox_TextChanged;
            // 
            // ColorCarBox
            // 
            ColorCarBox.Location = new Point(382, 114);
            ColorCarBox.Name = "ColorCarBox";
            ColorCarBox.Size = new Size(125, 23);
            ColorCarBox.TabIndex = 9;
            ColorCarBox.TextChanged += ColorCarBox_TextChanged;
            // 
            // AddCar
            // 
            AddCar.CustomizableEdges = customizableEdges1;
            AddCar.DisabledState.BorderColor = Color.DarkGray;
            AddCar.DisabledState.CustomBorderColor = Color.DarkGray;
            AddCar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddCar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddCar.Font = new Font("Segoe UI", 9F);
            AddCar.ForeColor = Color.White;
            AddCar.Location = new Point(12, 401);
            AddCar.Margin = new Padding(2);
            AddCar.Name = "AddCar";
            AddCar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            AddCar.Size = new Size(118, 33);
            AddCar.TabIndex = 19;
            AddCar.Text = "Ajouter Car";
            AddCar.Click += AddCar_Click;
            // 
            // UpdateCar
            // 
            UpdateCar.CustomizableEdges = customizableEdges3;
            UpdateCar.DisabledState.BorderColor = Color.DarkGray;
            UpdateCar.DisabledState.CustomBorderColor = Color.DarkGray;
            UpdateCar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            UpdateCar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            UpdateCar.Font = new Font("Segoe UI", 9F);
            UpdateCar.ForeColor = Color.White;
            UpdateCar.Location = new Point(153, 401);
            UpdateCar.Margin = new Padding(2);
            UpdateCar.Name = "UpdateCar";
            UpdateCar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            UpdateCar.Size = new Size(128, 33);
            UpdateCar.TabIndex = 27;
            UpdateCar.Text = "Modifier Car";
            UpdateCar.Click += UpdateCar_Click;
            // 
            // DeleteCar
            // 
            DeleteCar.CustomizableEdges = customizableEdges5;
            DeleteCar.DisabledState.BorderColor = Color.DarkGray;
            DeleteCar.DisabledState.CustomBorderColor = Color.DarkGray;
            DeleteCar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            DeleteCar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            DeleteCar.Font = new Font("Segoe UI", 9F);
            DeleteCar.ForeColor = Color.White;
            DeleteCar.Location = new Point(304, 400);
            DeleteCar.Margin = new Padding(2);
            DeleteCar.Name = "DeleteCar";
            DeleteCar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            DeleteCar.Size = new Size(140, 34);
            DeleteCar.TabIndex = 28;
            DeleteCar.Text = "Supprimer Car";
            DeleteCar.Click += DeleteCar_Click;
            // 
            // ReadCar
            // 
            ReadCar.CustomizableEdges = customizableEdges7;
            ReadCar.DisabledState.BorderColor = Color.DarkGray;
            ReadCar.DisabledState.CustomBorderColor = Color.DarkGray;
            ReadCar.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ReadCar.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ReadCar.Font = new Font("Segoe UI", 9F);
            ReadCar.ForeColor = Color.White;
            ReadCar.Location = new Point(466, 400);
            ReadCar.Margin = new Padding(2);
            ReadCar.Name = "ReadCar";
            ReadCar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ReadCar.Size = new Size(127, 34);
            ReadCar.TabIndex = 29;
            ReadCar.Text = "Afficher Car";
            ReadCar.Click += ReadCar_Click;
            // 
            // ListViewCar
            // 
            ListViewCar.Columns.AddRange(new ColumnHeader[] { Nom, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            ListViewCar.Location = new Point(13, 251);
            ListViewCar.Name = "ListViewCar";
            ListViewCar.Size = new Size(705, 129);
            ListViewCar.TabIndex = 30;
            ListViewCar.UseCompatibleStateImageBehavior = false;
            ListViewCar.View = View.Details;
            ListViewCar.SelectedIndexChanged += ListViewCar_SelectedIndexChanged;
            // 
            // Nom
            // 
            Nom.Text = "Nom";
            Nom.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Marque";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Matricule";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Couleur";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Prix";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "id";
            columnHeader6.Width = 0;
            // 
            // getCarId
            // 
            getCarId.AutoSize = true;
            getCarId.Location = new Point(217, 76);
            getCarId.Name = "getCarId";
            getCarId.Size = new Size(10, 15);
            getCarId.TabIndex = 31;
            getCarId.Text = " ";
            getCarId.Visible = false;
            // 
            // prixCarBox
            // 
            prixCarBox.Location = new Point(104, 182);
            prixCarBox.Name = "prixCarBox";
            prixCarBox.Size = new Size(125, 23);
            prixCarBox.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 182);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 32;
            label5.Text = "Prix";
            // 
            // telechargerCSVbtn
            // 
            telechargerCSVbtn.BorderColor = Color.Gray;
            telechargerCSVbtn.BorderRadius = 5;
            telechargerCSVbtn.BorderThickness = 1;
            telechargerCSVbtn.CustomizableEdges = customizableEdges9;
            telechargerCSVbtn.DisabledState.BorderColor = Color.DarkGray;
            telechargerCSVbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            telechargerCSVbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            telechargerCSVbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            telechargerCSVbtn.FillColor = SystemColors.Control;
            telechargerCSVbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            telechargerCSVbtn.ForeColor = Color.Black;
            telechargerCSVbtn.Image = Properties.Resources._6133884;
            telechargerCSVbtn.Location = new Point(153, 447);
            telechargerCSVbtn.Name = "telechargerCSVbtn";
            telechargerCSVbtn.ShadowDecoration.CustomizableEdges = customizableEdges10;
            telechargerCSVbtn.Size = new Size(335, 30);
            telechargerCSVbtn.TabIndex = 49;
            telechargerCSVbtn.Text = "Telecharger les données sous form csv";
            // 
            // Car
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 489);
            Controls.Add(telechargerCSVbtn);
            Controls.Add(prixCarBox);
            Controls.Add(label5);
            Controls.Add(getCarId);
            Controls.Add(ListViewCar);
            Controls.Add(ReadCar);
            Controls.Add(DeleteCar);
            Controls.Add(UpdateCar);
            Controls.Add(AddCar);
            Controls.Add(ColorCarBox);
            Controls.Add(MarqueCarBox);
            Controls.Add(MatriculeCarBox);
            Controls.Add(NomCarBox);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Car";
            Text = "CRUDCar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label1;
        private TextBox NomCarBox;
        private TextBox MatriculeCarBox;
        private TextBox MarqueCarBox;
        private TextBox ColorCarBox;
        private Guna.UI2.WinForms.Guna2Button AddCar;
        private Guna.UI2.WinForms.Guna2Button UpdateCar;
        private Guna.UI2.WinForms.Guna2Button DeleteCar;
        private Guna.UI2.WinForms.Guna2Button ReadCar;
        private ListView ListViewCar;
        private ColumnHeader columnHeader1;

        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label getCarId;
        private ColumnHeader Nom;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private TextBox prixCarBox;
        private Label label5;
        private Guna.UI2.WinForms.Guna2Button telechargerCSVbtn;
    }
}