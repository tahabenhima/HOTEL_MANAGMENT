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
            prixlabel = new Label();
            ListViewChambre = new ListView();
            type = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
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
            id = new ColumnHeader();
            SuspendLayout();
            // 
            // prixlabel
            // 
            prixlabel.AutoSize = true;
            prixlabel.Location = new Point(117, 118);
            prixlabel.Name = "prixlabel";
            prixlabel.Size = new Size(27, 15);
            prixlabel.TabIndex = 46;
            prixlabel.Text = "Prix";
            // 
            // ListViewChambre
            // 
            ListViewChambre.Columns.AddRange(new ColumnHeader[] { type, columnHeader2, columnHeader3, columnHeader4, id });
            ListViewChambre.Location = new Point(59, 228);
            ListViewChambre.Name = "ListViewChambre";
            ListViewChambre.Size = new Size(701, 129);
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
            // ReadChambrebtn
            // 
            ReadChambrebtn.CustomizableEdges = customizableEdges1;
            ReadChambrebtn.DisabledState.BorderColor = Color.DarkGray;
            ReadChambrebtn.DisabledState.CustomBorderColor = Color.DarkGray;
            ReadChambrebtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            ReadChambrebtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            ReadChambrebtn.Font = new Font("Segoe UI", 9F);
            ReadChambrebtn.ForeColor = Color.White;
            ReadChambrebtn.Location = new Point(602, 377);
            ReadChambrebtn.Margin = new Padding(2);
            ReadChambrebtn.Name = "ReadChambrebtn";
            ReadChambrebtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ReadChambrebtn.Size = new Size(127, 34);
            ReadChambrebtn.TabIndex = 44;
            ReadChambrebtn.Text = "Afficher Chambre";
            ReadChambrebtn.Click += ReadChambrebtn_Click;
            // 
            // DeleteChambrebtn
            // 
            DeleteChambrebtn.CustomizableEdges = customizableEdges3;
            DeleteChambrebtn.DisabledState.BorderColor = Color.DarkGray;
            DeleteChambrebtn.DisabledState.CustomBorderColor = Color.DarkGray;
            DeleteChambrebtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            DeleteChambrebtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            DeleteChambrebtn.Font = new Font("Segoe UI", 9F);
            DeleteChambrebtn.ForeColor = Color.White;
            DeleteChambrebtn.Location = new Point(411, 377);
            DeleteChambrebtn.Margin = new Padding(2);
            DeleteChambrebtn.Name = "DeleteChambrebtn";
            DeleteChambrebtn.ShadowDecoration.CustomizableEdges = customizableEdges4;
            DeleteChambrebtn.Size = new Size(140, 34);
            DeleteChambrebtn.TabIndex = 43;
            DeleteChambrebtn.Text = "Supprimer Chambre";
            DeleteChambrebtn.Click += DeleteChambrebtn_Click_1;
            // 
            // UpdateChambrebtn
            // 
            UpdateChambrebtn.CustomizableEdges = customizableEdges5;
            UpdateChambrebtn.DisabledState.BorderColor = Color.DarkGray;
            UpdateChambrebtn.DisabledState.CustomBorderColor = Color.DarkGray;
            UpdateChambrebtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            UpdateChambrebtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            UpdateChambrebtn.Font = new Font("Segoe UI", 9F);
            UpdateChambrebtn.ForeColor = Color.White;
            UpdateChambrebtn.Location = new Point(228, 378);
            UpdateChambrebtn.Margin = new Padding(2);
            UpdateChambrebtn.Name = "UpdateChambrebtn";
            UpdateChambrebtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            UpdateChambrebtn.Size = new Size(128, 33);
            UpdateChambrebtn.TabIndex = 42;
            UpdateChambrebtn.Text = "Modifier Chambre";
            UpdateChambrebtn.Click += UpdateChambrebtn_Click_1;
            // 
            // AddChambrebtn
            // 
            AddChambrebtn.CustomizableEdges = customizableEdges7;
            AddChambrebtn.DisabledState.BorderColor = Color.DarkGray;
            AddChambrebtn.DisabledState.CustomBorderColor = Color.DarkGray;
            AddChambrebtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            AddChambrebtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            AddChambrebtn.Font = new Font("Segoe UI", 9F);
            AddChambrebtn.ForeColor = Color.White;
            AddChambrebtn.Location = new Point(59, 377);
            AddChambrebtn.Margin = new Padding(2);
            AddChambrebtn.Name = "AddChambrebtn";
            AddChambrebtn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            AddChambrebtn.Size = new Size(118, 33);
            AddChambrebtn.TabIndex = 40;
            AddChambrebtn.Text = "Ajouter Chambre";
            AddChambrebtn.Click += AddChambrebtn_Click;
            // 
            // CapasiteChambreBox
            // 
            CapasiteChambreBox.Location = new Point(535, 110);
            CapasiteChambreBox.Name = "CapasiteChambreBox";
            CapasiteChambreBox.Size = new Size(125, 23);
            CapasiteChambreBox.TabIndex = 39;
            // 
            // NumeroChambreBox
            // 
            NumeroChambreBox.Location = new Point(535, 56);
            NumeroChambreBox.Name = "NumeroChambreBox";
            NumeroChambreBox.Size = new Size(125, 23);
            NumeroChambreBox.TabIndex = 38;
            // 
            // PrixChambreBox
            // 
            PrixChambreBox.Location = new Point(179, 110);
            PrixChambreBox.Name = "PrixChambreBox";
            PrixChambreBox.Size = new Size(125, 23);
            PrixChambreBox.TabIndex = 37;
            // 
            // TypechambreBox
            // 
            TypechambreBox.Location = new Point(179, 56);
            TypechambreBox.Name = "TypechambreBox";
            TypechambreBox.Size = new Size(125, 23);
            TypechambreBox.TabIndex = 36;
            // 
            // labelnum
            // 
            labelnum.AutoSize = true;
            labelnum.Location = new Point(458, 59);
            labelnum.Name = "labelnum";
            labelnum.Size = new Size(51, 15);
            labelnum.TabIndex = 35;
            labelnum.Text = "Numero";
            // 
            // labelcapa
            // 
            labelcapa.AutoSize = true;
            labelcapa.Location = new Point(458, 113);
            labelcapa.Name = "labelcapa";
            labelcapa.Size = new Size(52, 15);
            labelcapa.TabIndex = 34;
            labelcapa.Text = "Capasite";
            // 
            // labeltype
            // 
            labeltype.AutoSize = true;
            labeltype.Location = new Point(59, 59);
            labeltype.Name = "labeltype";
            labeltype.Size = new Size(97, 15);
            labeltype.TabIndex = 33;
            labeltype.Text = "Type de chambre";
            // 
            // getid
            // 
            getid.AutoSize = true;
            getid.Location = new Point(59, 209);
            getid.Name = "getid";
            getid.Size = new Size(24, 15);
            getid.TabIndex = 47;
            getid.Text = "get";
            getid.Visible = false;
            // 
            // id
            // 
            id.Width = 0;
            // 
            // Chambre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}