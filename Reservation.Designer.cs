namespace HOTEL_MANAGMENT
{
    partial class Reservation
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
            labeltype = new Label();
            Reserverbtn = new Guna.UI2.WinForms.Guna2Button();
            Carcheckbox = new Guna.UI2.WinForms.Guna2CheckBox();
            Repascheckbx = new Guna.UI2.WinForms.Guna2CheckBox();
            Spacheckbox = new Guna.UI2.WinForms.Guna2CheckBox();
            DateFinCarLocation = new Guna.UI2.WinForms.Guna2DateTimePicker();
            DateDebutCarLocation = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            Nbr_Seances_Label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            Nbr_Seances_Box = new Guna.UI2.WinForms.Guna2TextBox();
            label8 = new Label();
            prixtotal = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            comboBox1 = new ComboBox();
            labelMsg = new Label();
            label4 = new Label();
            ListViewCar = new ListView();
            Nom = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            labelMarque = new Label();
            labelCouleur = new Label();
            labelNom = new Label();
            labelPrix = new Label();
            labelp = new Label();
            labelMatricule = new Label();
            label9 = new Label();
            getCarId = new Label();
            ListViewChambre = new ListView();
            type = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            id = new ColumnHeader();
            SuspendLayout();
            // 
            // labeltype
            // 
            labeltype.AutoSize = true;
            labeltype.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            labeltype.Location = new Point(73, 164);
            labeltype.Name = "labeltype";
            labeltype.Size = new Size(46, 23);
            labeltype.TabIndex = 37;
            labeltype.Text = "Type";
            // 
            // Reserverbtn
            // 
            Reserverbtn.BorderColor = Color.Gray;
            Reserverbtn.BorderRadius = 5;
            Reserverbtn.BorderThickness = 1;
            Reserverbtn.CustomizableEdges = customizableEdges1;
            Reserverbtn.DisabledState.BorderColor = Color.DarkGray;
            Reserverbtn.DisabledState.CustomBorderColor = Color.DarkGray;
            Reserverbtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            Reserverbtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            Reserverbtn.FillColor = SystemColors.Control;
            Reserverbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Reserverbtn.ForeColor = Color.Black;
            Reserverbtn.Location = new Point(73, 722);
            Reserverbtn.Margin = new Padding(2, 3, 2, 3);
            Reserverbtn.Name = "Reserverbtn";
            Reserverbtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Reserverbtn.Size = new Size(202, 43);
            Reserverbtn.TabIndex = 41;
            Reserverbtn.Text = "Reserver Chambre";
            Reserverbtn.Click += Reserverbtn_Click;
            // 
            // Carcheckbox
            // 
            Carcheckbox.AutoSize = true;
            Carcheckbox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            Carcheckbox.CheckedState.BorderRadius = 0;
            Carcheckbox.CheckedState.BorderThickness = 0;
            Carcheckbox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            Carcheckbox.Location = new Point(822, 186);
            Carcheckbox.Margin = new Padding(3, 4, 3, 4);
            Carcheckbox.Name = "Carcheckbox";
            Carcheckbox.Size = new Size(78, 24);
            Carcheckbox.TabIndex = 42;
            Carcheckbox.Text = "Voiture";
            Carcheckbox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            Carcheckbox.UncheckedState.BorderRadius = 0;
            Carcheckbox.UncheckedState.BorderThickness = 0;
            Carcheckbox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            Carcheckbox.CheckedChanged += Carcheckbox_CheckedChanged;
            // 
            // Repascheckbx
            // 
            Repascheckbx.AutoSize = true;
            Repascheckbx.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            Repascheckbx.CheckedState.BorderRadius = 0;
            Repascheckbx.CheckedState.BorderThickness = 0;
            Repascheckbx.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            Repascheckbx.Location = new Point(822, 55);
            Repascheckbx.Margin = new Padding(3, 4, 3, 4);
            Repascheckbx.Name = "Repascheckbx";
            Repascheckbx.Size = new Size(71, 24);
            Repascheckbx.TabIndex = 43;
            Repascheckbx.Text = "Repas";
            Repascheckbx.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            Repascheckbx.UncheckedState.BorderRadius = 0;
            Repascheckbx.UncheckedState.BorderThickness = 0;
            Repascheckbx.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // Spacheckbox
            // 
            Spacheckbox.AutoSize = true;
            Spacheckbox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            Spacheckbox.CheckedState.BorderRadius = 0;
            Spacheckbox.CheckedState.BorderThickness = 0;
            Spacheckbox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            Spacheckbox.Location = new Point(822, 120);
            Spacheckbox.Margin = new Padding(3, 4, 3, 4);
            Spacheckbox.Name = "Spacheckbox";
            Spacheckbox.Size = new Size(56, 24);
            Spacheckbox.TabIndex = 44;
            Spacheckbox.Text = "Spa";
            Spacheckbox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            Spacheckbox.UncheckedState.BorderRadius = 0;
            Spacheckbox.UncheckedState.BorderThickness = 0;
            Spacheckbox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            Spacheckbox.CheckedChanged += Spacheckbox_CheckedChanged;
            // 
            // DateFinCarLocation
            // 
            DateFinCarLocation.BorderRadius = 10;
            DateFinCarLocation.BorderThickness = 1;
            DateFinCarLocation.Checked = true;
            DateFinCarLocation.CustomizableEdges = customizableEdges3;
            DateFinCarLocation.FillColor = Color.AliceBlue;
            DateFinCarLocation.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateFinCarLocation.Format = DateTimePickerFormat.Long;
            DateFinCarLocation.Location = new Point(208, 90);
            DateFinCarLocation.Margin = new Padding(3, 4, 3, 4);
            DateFinCarLocation.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DateFinCarLocation.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DateFinCarLocation.Name = "DateFinCarLocation";
            DateFinCarLocation.ShadowDecoration.CustomizableEdges = customizableEdges4;
            DateFinCarLocation.Size = new Size(231, 36);
            DateFinCarLocation.TabIndex = 50;
            DateFinCarLocation.Value = new DateTime(2024, 12, 26, 22, 29, 5, 380);
            // 
            // DateDebutCarLocation
            // 
            DateDebutCarLocation.BorderRadius = 10;
            DateDebutCarLocation.BorderThickness = 1;
            DateDebutCarLocation.Checked = true;
            DateDebutCarLocation.CustomizableEdges = customizableEdges5;
            DateDebutCarLocation.FillColor = Color.AliceBlue;
            DateDebutCarLocation.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DateDebutCarLocation.Format = DateTimePickerFormat.Long;
            DateDebutCarLocation.Location = new Point(208, 29);
            DateDebutCarLocation.Margin = new Padding(3, 4, 3, 4);
            DateDebutCarLocation.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            DateDebutCarLocation.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            DateDebutCarLocation.Name = "DateDebutCarLocation";
            DateDebutCarLocation.ShadowDecoration.CustomizableEdges = customizableEdges6;
            DateDebutCarLocation.Size = new Size(231, 36);
            DateDebutCarLocation.TabIndex = 49;
            DateDebutCarLocation.Value = new DateTime(2024, 12, 26, 22, 29, 5, 380);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(821, 580);
            label5.Name = "label5";
            label5.Size = new Size(70, 23);
            label5.TabIndex = 48;
            label5.Text = "Couleur";
            label5.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(73, 29);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 47;
            label3.Text = "Date debut";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(821, 476);
            label6.Name = "label6";
            label6.Size = new Size(48, 23);
            label6.TabIndex = 46;
            label6.Text = "Nom";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(73, 90);
            label7.Name = "label7";
            label7.Size = new Size(71, 23);
            label7.TabIndex = 45;
            label7.Text = "Date fin";
            // 
            // Nbr_Seances_Label
            // 
            Nbr_Seances_Label.BackColor = Color.Transparent;
            Nbr_Seances_Label.Location = new Point(822, 155);
            Nbr_Seances_Label.Margin = new Padding(2, 3, 2, 3);
            Nbr_Seances_Label.Name = "Nbr_Seances_Label";
            Nbr_Seances_Label.Size = new Size(136, 22);
            Nbr_Seances_Label.TabIndex = 56;
            Nbr_Seances_Label.Text = "Nombre de Seances";
            Nbr_Seances_Label.Visible = false;
            // 
            // Nbr_Seances_Box
            // 
            Nbr_Seances_Box.CustomizableEdges = customizableEdges7;
            Nbr_Seances_Box.DefaultText = "";
            Nbr_Seances_Box.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            Nbr_Seances_Box.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            Nbr_Seances_Box.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            Nbr_Seances_Box.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            Nbr_Seances_Box.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            Nbr_Seances_Box.Font = new Font("Segoe UI", 9F);
            Nbr_Seances_Box.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            Nbr_Seances_Box.Location = new Point(969, 148);
            Nbr_Seances_Box.Margin = new Padding(3, 5, 3, 5);
            Nbr_Seances_Box.Name = "Nbr_Seances_Box";
            Nbr_Seances_Box.PasswordChar = '\0';
            Nbr_Seances_Box.PlaceholderText = "";
            Nbr_Seances_Box.SelectedText = "";
            Nbr_Seances_Box.ShadowDecoration.CustomizableEdges = customizableEdges8;
            Nbr_Seances_Box.Size = new Size(150, 29);
            Nbr_Seances_Box.TabIndex = 55;
            Nbr_Seances_Box.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(81, 667);
            label8.Name = "label8";
            label8.Size = new Size(46, 23);
            label8.TabIndex = 57;
            label8.Text = "Total";
            // 
            // prixtotal
            // 
            prixtotal.AutoSize = true;
            prixtotal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            prixtotal.ForeColor = Color.Maroon;
            prixtotal.Location = new Point(147, 667);
            prixtotal.Name = "prixtotal";
            prixtotal.Size = new Size(17, 25);
            prixtotal.TabIndex = 58;
            prixtotal.Text = " ";
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 10;
            guna2Button1.CustomizableEdges = customizableEdges9;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.SlateGray;
            guna2Button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(135, 214);
            guna2Button1.Margin = new Padding(3, 4, 3, 4);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Button1.Size = new Size(170, 48);
            guna2Button1.TabIndex = 60;
            guna2Button1.Text = "Chercher";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Chambre Simple", "Chambre Double", "Suite" });
            comboBox1.Location = new Point(208, 164);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(231, 28);
            comboBox1.TabIndex = 61;
            // 
            // labelMsg
            // 
            labelMsg.AutoSize = true;
            labelMsg.Font = new Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMsg.ForeColor = Color.Red;
            labelMsg.Location = new Point(1155, 528);
            labelMsg.Name = "labelMsg";
            labelMsg.Size = new Size(0, 32);
            labelMsg.TabIndex = 62;
            labelMsg.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(822, 528);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 65;
            label4.Text = "Marquec";
            label4.Visible = false;
            // 
            // ListViewCar
            // 
            ListViewCar.Columns.AddRange(new ColumnHeader[] { Nom, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            ListViewCar.Location = new Point(821, 239);
            ListViewCar.Margin = new Padding(3, 4, 3, 4);
            ListViewCar.Name = "ListViewCar";
            ListViewCar.Size = new Size(829, 216);
            ListViewCar.TabIndex = 67;
            ListViewCar.UseCompatibleStateImageBehavior = false;
            ListViewCar.View = View.Details;
            ListViewCar.Visible = false;
            ListViewCar.SelectedIndexChanged += ListViewCar_SelectedIndexChanged;
            // 
            // Nom
            // 
            Nom.Text = "Nom";
            Nom.Width = 150;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Marque";
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Matricule";
            columnHeader9.Width = 150;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Couleur";
            columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Prix";
            columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "id";
            columnHeader12.Width = 0;
            // 
            // labelMarque
            // 
            labelMarque.AutoSize = true;
            labelMarque.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMarque.Location = new Point(934, 528);
            labelMarque.Name = "labelMarque";
            labelMarque.Size = new Size(70, 23);
            labelMarque.TabIndex = 70;
            labelMarque.Text = "Marque";
            labelMarque.Visible = false;
            // 
            // labelCouleur
            // 
            labelCouleur.AutoSize = true;
            labelCouleur.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCouleur.Location = new Point(934, 580);
            labelCouleur.Name = "labelCouleur";
            labelCouleur.Size = new Size(70, 23);
            labelCouleur.TabIndex = 69;
            labelCouleur.Text = "Couleur";
            labelCouleur.Visible = false;
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNom.Location = new Point(934, 476);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(48, 23);
            labelNom.TabIndex = 68;
            labelNom.Text = "Nom";
            labelNom.Visible = false;
            // 
            // labelPrix
            // 
            labelPrix.AutoSize = true;
            labelPrix.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrix.Location = new Point(934, 677);
            labelPrix.Name = "labelPrix";
            labelPrix.Size = new Size(39, 23);
            labelPrix.TabIndex = 75;
            labelPrix.Text = "Prix";
            labelPrix.Visible = false;
            // 
            // labelp
            // 
            labelp.AutoSize = true;
            labelp.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelp.Location = new Point(820, 677);
            labelp.Name = "labelp";
            labelp.Size = new Size(39, 23);
            labelp.TabIndex = 74;
            labelp.Text = "Prix";
            labelp.Visible = false;
            // 
            // labelMatricule
            // 
            labelMatricule.AutoSize = true;
            labelMatricule.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelMatricule.Location = new Point(934, 629);
            labelMatricule.Name = "labelMatricule";
            labelMatricule.Size = new Size(82, 23);
            labelMatricule.TabIndex = 73;
            labelMatricule.Text = "Matricule";
            labelMatricule.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(822, 629);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 72;
            label9.Text = "Matricule";
            label9.Visible = false;
            // 
            // getCarId
            // 
            getCarId.AutoSize = true;
            getCarId.Location = new Point(935, 459);
            getCarId.Name = "getCarId";
            getCarId.Size = new Size(13, 20);
            getCarId.TabIndex = 76;
            getCarId.Text = " ";
            getCarId.Visible = false;
            // 
            // ListViewChambre
            // 
            ListViewChambre.BackColor = Color.WhiteSmoke;
            ListViewChambre.Columns.AddRange(new ColumnHeader[] { type, columnHeader2, columnHeader3, columnHeader4, id });
            ListViewChambre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ListViewChambre.Location = new Point(37, 270);
            ListViewChambre.Margin = new Padding(3, 4, 3, 4);
            ListViewChambre.Name = "ListViewChambre";
            ListViewChambre.Size = new Size(603, 211);
            ListViewChambre.TabIndex = 77;
            ListViewChambre.UseCompatibleStateImageBehavior = false;
            ListViewChambre.View = View.Details;
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
            // Reservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1420, 856);
            Controls.Add(ListViewChambre);
            Controls.Add(getCarId);
            Controls.Add(labelPrix);
            Controls.Add(labelp);
            Controls.Add(labelMatricule);
            Controls.Add(label9);
            Controls.Add(labelMarque);
            Controls.Add(labelCouleur);
            Controls.Add(labelNom);
            Controls.Add(ListViewCar);
            Controls.Add(label4);
            Controls.Add(labelMsg);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(guna2Button1);
            Controls.Add(DateDebutCarLocation);
            Controls.Add(DateFinCarLocation);
            Controls.Add(prixtotal);
            Controls.Add(label8);
            Controls.Add(Nbr_Seances_Label);
            Controls.Add(Nbr_Seances_Box);
            Controls.Add(Spacheckbox);
            Controls.Add(Repascheckbx);
            Controls.Add(Carcheckbox);
            Controls.Add(Reserverbtn);
            Controls.Add(labeltype);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Reservation";
            Text = "Reservation";
            Load += Reservation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labeltype;
        private Guna.UI2.WinForms.Guna2Button Reserverbtn;
        private Guna.UI2.WinForms.Guna2CheckBox Carcheckbox;
        private Guna.UI2.WinForms.Guna2CheckBox Repascheckbx;
        private Guna.UI2.WinForms.Guna2CheckBox Spacheckbox;
        private Guna.UI2.WinForms.Guna2ComboBox ColorCararLocationComboBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateFinCarLocation;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateDebutCarLocation;
        private Label label5;
        private Label label3;
        private Label label6;
        private Label label7;
        private Guna.UI2.WinForms.Guna2HtmlLabel Nbr_Seances_Label;
        private Guna.UI2.WinForms.Guna2TextBox Nbr_Seances_Box;
        private Label label8;
        private Label prixtotal;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private ComboBox comboBox1;
        private Label labelMsg;
        private Label label4;
        private ListView ListViewCar;
        private ColumnHeader Nom;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private Label labelMarque;
        private Label labelCouleur;
        private Label labelNom;
        private Label labelPrix;
        private Label labelp;
        private Label labelMatricule;
        private Label label9;
        private Label getCarId;
        private ListView ListViewChambre;
        private ColumnHeader type;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader id;
    }
}