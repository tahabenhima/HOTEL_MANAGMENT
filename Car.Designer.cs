﻿namespace HOTEL_MANAGMENT
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
            label2.Location = new Point(35, 156);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Matricule";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 69);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 3;
            label3.Text = "Nom";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 152);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 4;
            label4.Text = "Couleur";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 65);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 5;
            label1.Text = "Marque";
            // 
            // NomCarBox
            // 
            NomCarBox.Location = new Point(119, 69);
            NomCarBox.Margin = new Padding(3, 4, 3, 4);
            NomCarBox.Name = "NomCarBox";
            NomCarBox.Size = new Size(142, 27);
            NomCarBox.TabIndex = 6;
            NomCarBox.TextChanged += NomCarBox_TextChanged;
            // 
            // MatriculeCarBox
            // 
            MatriculeCarBox.Location = new Point(119, 156);
            MatriculeCarBox.Margin = new Padding(3, 4, 3, 4);
            MatriculeCarBox.Name = "MatriculeCarBox";
            MatriculeCarBox.Size = new Size(142, 27);
            MatriculeCarBox.TabIndex = 7;
            MatriculeCarBox.TextChanged += MatriculeCarBox_TextChanged;
            // 
            // MarqueCarBox
            // 
            MarqueCarBox.Location = new Point(437, 65);
            MarqueCarBox.Margin = new Padding(3, 4, 3, 4);
            MarqueCarBox.Name = "MarqueCarBox";
            MarqueCarBox.Size = new Size(142, 27);
            MarqueCarBox.TabIndex = 8;
            MarqueCarBox.TextChanged += MarqueCarBox_TextChanged;
            // 
            // ColorCarBox
            // 
            ColorCarBox.Location = new Point(437, 152);
            ColorCarBox.Margin = new Padding(3, 4, 3, 4);
            ColorCarBox.Name = "ColorCarBox";
            ColorCarBox.Size = new Size(142, 27);
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
            AddCar.Location = new Point(14, 535);
            AddCar.Margin = new Padding(2, 3, 2, 3);
            AddCar.Name = "AddCar";
            AddCar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            AddCar.Size = new Size(135, 44);
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
            UpdateCar.Location = new Point(175, 535);
            UpdateCar.Margin = new Padding(2, 3, 2, 3);
            UpdateCar.Name = "UpdateCar";
            UpdateCar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            UpdateCar.Size = new Size(146, 44);
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
            DeleteCar.Location = new Point(347, 533);
            DeleteCar.Margin = new Padding(2, 3, 2, 3);
            DeleteCar.Name = "DeleteCar";
            DeleteCar.ShadowDecoration.CustomizableEdges = customizableEdges6;
            DeleteCar.Size = new Size(160, 45);
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
            ReadCar.Location = new Point(533, 533);
            ReadCar.Margin = new Padding(2, 3, 2, 3);
            ReadCar.Name = "ReadCar";
            ReadCar.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ReadCar.Size = new Size(145, 45);
            ReadCar.TabIndex = 29;
            ReadCar.Text = "Afficher Car";
            ReadCar.Click += ReadCar_Click;
            // 
            // ListViewCar
            // 
            ListViewCar.Columns.AddRange(new ColumnHeader[] { Nom, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            ListViewCar.Location = new Point(15, 335);
            ListViewCar.Margin = new Padding(3, 4, 3, 4);
            ListViewCar.Name = "ListViewCar";
            ListViewCar.Size = new Size(805, 171);
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
            getCarId.Location = new Point(248, 101);
            getCarId.Name = "getCarId";
            getCarId.Size = new Size(13, 20);
            getCarId.TabIndex = 31;
            getCarId.Text = " ";
            getCarId.Visible = false;
            // 
            // prixCarBox
            // 
            prixCarBox.Location = new Point(119, 243);
            prixCarBox.Margin = new Padding(3, 4, 3, 4);
            prixCarBox.Name = "prixCarBox";
            prixCarBox.Size = new Size(142, 27);
            prixCarBox.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 243);
            label5.Name = "label5";
            label5.Size = new Size(33, 20);
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
            telechargerCSVbtn.Location = new Point(175, 596);
            telechargerCSVbtn.Margin = new Padding(3, 4, 3, 4);
            telechargerCSVbtn.Name = "telechargerCSVbtn";
            telechargerCSVbtn.ShadowDecoration.CustomizableEdges = customizableEdges10;
            telechargerCSVbtn.Size = new Size(383, 40);
            telechargerCSVbtn.TabIndex = 49;
            telechargerCSVbtn.Text = "Telecharger les données sous form csv";
            telechargerCSVbtn.Click += telechargerCSVbtn_Click;
            // 
            // Car
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 652);
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
            Margin = new Padding(3, 4, 3, 4);
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