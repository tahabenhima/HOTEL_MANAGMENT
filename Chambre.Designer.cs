namespace HOTEL_MANAGMENT
{
    partial class Chambre
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
            prixlabel = new Label();
            ListViewChambre = new ListView();
            type = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            id = new ColumnHeader();
            ReadChambrebtn = new Guna.UI2.WinForms.Guna2Button();
            DeleteChambrebtn = new Guna.UI2.WinForms.Guna2Button();
            UpdateChambrebtn = new Guna.UI2.WinForms.Guna2Button();
            AddChambrebtn = new Guna.UI2.WinForms.Guna2Button();
            CapasiteChambreBox = new TextBox();
            NumeroChambreBox = new TextBox();
            PrixChambreBox = new TextBox();
            TypechambreBox = new TextBox();
            labelnum = new Label();
            labelcapa = new Label();
            labeltype = new Label();
            getid = new Label();
            telechargerCSVbtn = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // prixlabel
            // 
            prixlabel.AutoSize = true;
            prixlabel.Location = new Point(67, 157);
            prixlabel.Name = "prixlabel";
            prixlabel.Size = new Size(33, 20);
            prixlabel.TabIndex = 46;
            prixlabel.Text = "Prix";
            // 
            // ListViewChambre
            // 
            ListViewChambre.BackColor = Color.WhiteSmoke;
            ListViewChambre.Columns.AddRange(new ColumnHeader[] { type, columnHeader2, columnHeader3, columnHeader4, id });
            ListViewChambre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListViewChambre.Location = new Point(67, 213);
            ListViewChambre.Margin = new Padding(3, 4, 3, 4);
            ListViewChambre.Name = "ListViewChambre";
            ListViewChambre.Size = new Size(778, 211);
            ListViewChambre.TabIndex = 45;
            ListViewChambre.UseCompatibleStateImageBehavior = false;
            ListViewChambre.View = View.Details;
            ListViewChambre.SelectedIndexChanged += ListViewChambre_SelectedIndexChanged;
            // 
            // type
            // 
            type.Text = "Type";
            type.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Numero";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Prix";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Capasite";
            columnHeader4.Width = 150;
            // 
            // id
            // 
            id.Width = 0;
            // 
            // ReadChambrebtn
            // 
            ReadChambrebtn.BorderColor = Color.Gray;
            ReadChambrebtn.BorderRadius = 5;
            ReadChambrebtn.BorderThickness = 1;
            ReadChambrebtn.CustomizableEdges = customizableEdges1;
            ReadChambrebtn.DisabledState.BorderColor = Color.DarkGray;
            ReadChambrebtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ReadChambrebtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ReadChambrebtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ReadChambrebtn.FillColor = SystemColors.Control;
            ReadChambrebtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ReadChambrebtn.ForeColor = Color.Black;
            ReadChambrebtn.Location = new Point(688, 471);
            ReadChambrebtn.Margin = new Padding(2, 3, 2, 3);
            ReadChambrebtn.Name = "ReadChambrebtn";
            ReadChambrebtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ReadChambrebtn.Size = new Size(158, 45);
            ReadChambrebtn.TabIndex = 44;
            ReadChambrebtn.Text = "Afficher Chambre";
            ReadChambrebtn.Click += ReadChambrebtn_Click;
            // 
            // DeleteChambrebtn
            // 
            DeleteChambrebtn.BorderColor = Color.Gray;
            DeleteChambrebtn.BorderRadius = 5;
            DeleteChambrebtn.BorderThickness = 1;
            DeleteChambrebtn.CustomizableEdges = customizableEdges3;
            DeleteChambrebtn.DisabledState.BorderColor = Color.DarkGray;
            DeleteChambrebtn.DisabledState.CustomBorderColor = Color.DarkGray;
            DeleteChambrebtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            DeleteChambrebtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            DeleteChambrebtn.FillColor = SystemColors.Control;
            DeleteChambrebtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteChambrebtn.ForeColor = Color.Black;
            DeleteChambrebtn.Location = new Point(470, 471);
            DeleteChambrebtn.Margin = new Padding(2, 3, 2, 3);
            DeleteChambrebtn.Name = "DeleteChambrebtn";
            DeleteChambrebtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            DeleteChambrebtn.Size = new Size(176, 45);
            DeleteChambrebtn.TabIndex = 43;
            DeleteChambrebtn.Text = "Supprimer Chambre";
            DeleteChambrebtn.Click += DeleteChambrebtn_Click_1;
            // 
            // UpdateChambrebtn
            // 
            UpdateChambrebtn.BorderColor = Color.Gray;
            UpdateChambrebtn.BorderRadius = 5;
            UpdateChambrebtn.BorderThickness = 1;
            UpdateChambrebtn.CustomizableEdges = customizableEdges5;
            UpdateChambrebtn.DisabledState.BorderColor = Color.DarkGray;
            UpdateChambrebtn.DisabledState.CustomBorderColor = Color.DarkGray;
            UpdateChambrebtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            UpdateChambrebtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            UpdateChambrebtn.FillColor = SystemColors.Control;
            UpdateChambrebtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateChambrebtn.ForeColor = Color.Black;
            UpdateChambrebtn.Location = new Point(263, 471);
            UpdateChambrebtn.Margin = new Padding(2, 3, 2, 3);
            UpdateChambrebtn.Name = "UpdateChambrebtn";
            UpdateChambrebtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            UpdateChambrebtn.Size = new Size(160, 44);
            UpdateChambrebtn.TabIndex = 42;
            UpdateChambrebtn.Text = "Modifier Chambre";
            UpdateChambrebtn.Click += UpdateChambrebtn_Click_1;
            // 
            // AddChambrebtn
            // 
            AddChambrebtn.BorderColor = Color.Gray;
            AddChambrebtn.BorderRadius = 5;
            AddChambrebtn.BorderThickness = 1;
            AddChambrebtn.CustomizableEdges = customizableEdges7;
            AddChambrebtn.DisabledState.BorderColor = Color.DarkGray;
            AddChambrebtn.DisabledState.CustomBorderColor = Color.DarkGray;
            AddChambrebtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddChambrebtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddChambrebtn.FillColor = SystemColors.Control;
            AddChambrebtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddChambrebtn.ForeColor = Color.Black;
            AddChambrebtn.Location = new Point(67, 471);
            AddChambrebtn.Margin = new Padding(2, 3, 2, 3);
            AddChambrebtn.Name = "AddChambrebtn";
            AddChambrebtn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            AddChambrebtn.Size = new Size(150, 43);
            AddChambrebtn.TabIndex = 40;
            AddChambrebtn.Text = "Ajouter Chambre";
            AddChambrebtn.Click += AddChambrebtn_Click;
            // 
            // CapasiteChambreBox
            // 
            CapasiteChambreBox.Location = new Point(611, 147);
            CapasiteChambreBox.Margin = new Padding(3, 4, 3, 4);
            CapasiteChambreBox.Name = "CapasiteChambreBox";
            CapasiteChambreBox.Size = new Size(234, 27);
            CapasiteChambreBox.TabIndex = 39;
            // 
            // NumeroChambreBox
            // 
            NumeroChambreBox.Location = new Point(611, 75);
            NumeroChambreBox.Margin = new Padding(3, 4, 3, 4);
            NumeroChambreBox.Name = "NumeroChambreBox";
            NumeroChambreBox.Size = new Size(234, 27);
            NumeroChambreBox.TabIndex = 38;
            // 
            // PrixChambreBox
            // 
            PrixChambreBox.Location = new Point(138, 147);
            PrixChambreBox.Margin = new Padding(3, 4, 3, 4);
            PrixChambreBox.Name = "PrixChambreBox";
            PrixChambreBox.Size = new Size(225, 27);
            PrixChambreBox.TabIndex = 37;
            // 
            // TypechambreBox
            // 
            TypechambreBox.Location = new Point(138, 75);
            TypechambreBox.Margin = new Padding(3, 4, 3, 4);
            TypechambreBox.Name = "TypechambreBox";
            TypechambreBox.Size = new Size(225, 27);
            TypechambreBox.TabIndex = 36;
            // 
            // labelnum
            // 
            labelnum.AutoSize = true;
            labelnum.Location = new Point(523, 79);
            labelnum.Name = "labelnum";
            labelnum.Size = new Size(63, 20);
            labelnum.TabIndex = 35;
            labelnum.Text = "Numero";
            // 
            // labelcapa
            // 
            labelcapa.AutoSize = true;
            labelcapa.Location = new Point(523, 151);
            labelcapa.Name = "labelcapa";
            labelcapa.Size = new Size(67, 20);
            labelcapa.TabIndex = 34;
            labelcapa.Text = "Capacite";
            // 
            // labeltype
            // 
            labeltype.AutoSize = true;
            labeltype.Location = new Point(63, 79);
            labeltype.Name = "labeltype";
            labeltype.Size = new Size(40, 20);
            labeltype.TabIndex = 33;
            labeltype.Text = "Type";
            // 
            // getid
            // 
            getid.AutoSize = true;
            getid.Location = new Point(67, 189);
            getid.Name = "getid";
            getid.Size = new Size(31, 20);
            getid.TabIndex = 47;
            getid.Text = "get";
            getid.Visible = false;
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
            telechargerCSVbtn.Location = new Point(263, 555);
            telechargerCSVbtn.Margin = new Padding(3, 4, 3, 4);
            telechargerCSVbtn.Name = "telechargerCSVbtn";
            telechargerCSVbtn.ShadowDecoration.CustomizableEdges = customizableEdges10;
            telechargerCSVbtn.Size = new Size(383, 40);
            telechargerCSVbtn.TabIndex = 48;
            telechargerCSVbtn.Text = "Telecharger les données sous form csv";
            telechargerCSVbtn.Click += telechargerCSVbtn_Click;
            // 
            // Chambre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(914, 623);
            Controls.Add(telechargerCSVbtn);
            Controls.Add(getid);
            Controls.Add(prixlabel);
            Controls.Add(ListViewChambre);
            Controls.Add(ReadChambrebtn);
            Controls.Add(DeleteChambrebtn);
            Controls.Add(UpdateChambrebtn);
            Controls.Add(AddChambrebtn);
            Controls.Add(CapasiteChambreBox);
            Controls.Add(NumeroChambreBox);
            Controls.Add(PrixChambreBox);
            Controls.Add(TypechambreBox);
            Controls.Add(labelnum);
            Controls.Add(labelcapa);
            Controls.Add(labeltype);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Chambre";
            Text = "Chambre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label prixlabel;
        private ListView ListViewChambre;
        private ColumnHeader type;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2Button ReadChambrebtn;
        private Guna.UI2.WinForms.Guna2Button DeleteChambrebtn;
        private Guna.UI2.WinForms.Guna2Button UpdateChambrebtn;
        private Guna.UI2.WinForms.Guna2Button AddChambrebtn;
        private TextBox CapasiteChambreBox;
        private TextBox NumeroChambreBox;
        private TextBox PrixChambreBox;
        private TextBox TypechambreBox;
        private Label labelnum;
        private Label labelcapa;
        private Label labeltype;
        private Label getid;
        private ColumnHeader id;
        private Guna.UI2.WinForms.Guna2Button telechargerCSVbtn;
    }
}