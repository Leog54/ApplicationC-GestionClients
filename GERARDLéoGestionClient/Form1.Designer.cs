namespace GERARDLéoGestionClient
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.psw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numRue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomRue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblNumRue = new System.Windows.Forms.Label();
            this.lblNomRue = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtNumRue = new System.Windows.Forms.TextBox();
            this.txtNomRue = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCP = new System.Windows.Forms.TextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRechercher = new System.Windows.Forms.Label();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.btnAnnulerRecherche = new System.Windows.Forms.Button();
            this.cbRechercher = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.email,
            this.nom,
            this.prenom,
            this.psw,
            this.telephone,
            this.numRue,
            this.nomRue,
            this.ville,
            this.codePostal,
            this.statut});
            this.dataGridView1.Location = new System.Drawing.Point(28, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 287);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // email
            // 
            this.email.HeaderText = "email";
            this.email.Name = "email";
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            // 
            // psw
            // 
            this.psw.HeaderText = "Mot de passe";
            this.psw.Name = "psw";
            // 
            // telephone
            // 
            this.telephone.HeaderText = "Téléphone";
            this.telephone.Name = "telephone";
            // 
            // numRue
            // 
            this.numRue.HeaderText = "Numéro de rue";
            this.numRue.Name = "numRue";
            // 
            // nomRue
            // 
            this.nomRue.HeaderText = "Nom de rue";
            this.nomRue.Name = "nomRue";
            // 
            // ville
            // 
            this.ville.HeaderText = "Ville";
            this.ville.Name = "ville";
            // 
            // codePostal
            // 
            this.codePostal.HeaderText = "Code postal";
            this.codePostal.Name = "codePostal";
            // 
            // statut
            // 
            this.statut.HeaderText = "Statut";
            this.statut.Name = "statut";
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(154, 437);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(116, 49);
            this.btnAjouter.TabIndex = 9;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.SteelBlue;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnModifier.ForeColor = System.Drawing.Color.White;
            this.btnModifier.Location = new System.Drawing.Point(523, 515);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(125, 49);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.DarkRed;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.White;
            this.btnSupprimer.Location = new System.Drawing.Point(785, 515);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(116, 49);
            this.btnSupprimer.TabIndex = 0;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F);
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(48, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "email :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNom.ForeColor = System.Drawing.Color.Black;
            this.lblNom.Location = new System.Drawing.Point(48, 132);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(54, 20);
            this.lblNom.TabIndex = 4;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblPrenom.ForeColor = System.Drawing.Color.Black;
            this.lblPrenom.Location = new System.Drawing.Point(48, 168);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(77, 20);
            this.lblPrenom.TabIndex = 4;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblMdp.ForeColor = System.Drawing.Color.Black;
            this.lblMdp.Location = new System.Drawing.Point(46, 205);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(120, 20);
            this.lblMdp.TabIndex = 4;
            this.lblMdp.Text = "Mot de passe :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblTel.ForeColor = System.Drawing.Color.Black;
            this.lblTel.Location = new System.Drawing.Point(46, 241);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(96, 20);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "Téléphone :";
            // 
            // lblNumRue
            // 
            this.lblNumRue.AutoSize = true;
            this.lblNumRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNumRue.ForeColor = System.Drawing.Color.Black;
            this.lblNumRue.Location = new System.Drawing.Point(46, 277);
            this.lblNumRue.Name = "lblNumRue";
            this.lblNumRue.Size = new System.Drawing.Size(130, 20);
            this.lblNumRue.TabIndex = 4;
            this.lblNumRue.Text = "Numéro de rue :";
            // 
            // lblNomRue
            // 
            this.lblNomRue.AutoSize = true;
            this.lblNomRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNomRue.ForeColor = System.Drawing.Color.Black;
            this.lblNomRue.Location = new System.Drawing.Point(46, 311);
            this.lblNomRue.Name = "lblNomRue";
            this.lblNomRue.Size = new System.Drawing.Size(111, 20);
            this.lblNomRue.TabIndex = 4;
            this.lblNomRue.Text = "Nom de rue : ";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblVille.ForeColor = System.Drawing.Color.Black;
            this.lblVille.Location = new System.Drawing.Point(46, 346);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(51, 20);
            this.lblVille.TabIndex = 4;
            this.lblVille.Text = "Ville :";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCP.ForeColor = System.Drawing.Color.Black;
            this.lblCP.Location = new System.Drawing.Point(46, 382);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(108, 20);
            this.lblCP.TabIndex = 4;
            this.lblCP.Text = "Code postal :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(185, 94);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 20);
            this.txtEmail.TabIndex = 0;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(185, 130);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(178, 20);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(185, 164);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(178, 20);
            this.txtPrenom.TabIndex = 2;
            // 
            // txtMdp
            // 
            this.txtMdp.Location = new System.Drawing.Point(185, 205);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.Size = new System.Drawing.Size(178, 20);
            this.txtMdp.TabIndex = 3;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(185, 238);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(178, 20);
            this.txtTel.TabIndex = 4;
            // 
            // txtNumRue
            // 
            this.txtNumRue.Location = new System.Drawing.Point(185, 273);
            this.txtNumRue.Name = "txtNumRue";
            this.txtNumRue.Size = new System.Drawing.Size(178, 20);
            this.txtNumRue.TabIndex = 5;
            // 
            // txtNomRue
            // 
            this.txtNomRue.Location = new System.Drawing.Point(185, 308);
            this.txtNomRue.Name = "txtNomRue";
            this.txtNomRue.Size = new System.Drawing.Size(178, 20);
            this.txtNomRue.TabIndex = 6;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(185, 343);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(178, 20);
            this.txtVille.TabIndex = 7;
            // 
            // txtCP
            // 
            this.txtCP.Location = new System.Drawing.Point(185, 379);
            this.txtCP.Name = "txtCP";
            this.txtCP.Size = new System.Drawing.Size(178, 20);
            this.txtCP.TabIndex = 8;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.SteelBlue;
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnQuitter.ForeColor = System.Drawing.Color.White;
            this.btnQuitter.Location = new System.Drawing.Point(1496, 587);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(121, 67);
            this.btnQuitter.TabIndex = 1;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(75, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 57);
            this.label1.TabIndex = 7;
            this.label1.Text = "Données client";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.lblMdp);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblNom);
            this.panel1.Controls.Add(this.btnAjouter);
            this.panel1.Controls.Add(this.txtCP);
            this.panel1.Controls.Add(this.lblPrenom);
            this.panel1.Controls.Add(this.txtVille);
            this.panel1.Controls.Add(this.lblTel);
            this.panel1.Controls.Add(this.txtNomRue);
            this.panel1.Controls.Add(this.lblNumRue);
            this.panel1.Controls.Add(this.txtNumRue);
            this.panel1.Controls.Add(this.lblNomRue);
            this.panel1.Controls.Add(this.txtTel);
            this.panel1.Controls.Add(this.lblVille);
            this.panel1.Controls.Add(this.txtMdp);
            this.panel1.Controls.Add(this.lblCP);
            this.panel1.Controls.Add(this.txtPrenom);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Location = new System.Drawing.Point(1223, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 525);
            this.panel1.TabIndex = 0;
            // 
            // lblRechercher
            // 
            this.lblRechercher.AutoSize = true;
            this.lblRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercher.Location = new System.Drawing.Point(37, 9);
            this.lblRechercher.Name = "lblRechercher";
            this.lblRechercher.Size = new System.Drawing.Size(224, 24);
            this.lblRechercher.TabIndex = 10;
            this.lblRechercher.Text = "Rechercher un client  :";
            // 
            // txtRechercher
            // 
            this.txtRechercher.Location = new System.Drawing.Point(229, 95);
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(162, 20);
            this.txtRechercher.TabIndex = 0;
            this.txtRechercher.TextChanged += new System.EventHandler(this.txtRechercher_TextChanged);
            // 
            // btnAnnulerRecherche
            // 
            this.btnAnnulerRecherche.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAnnulerRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnulerRecherche.ForeColor = System.Drawing.Color.White;
            this.btnAnnulerRecherche.Location = new System.Drawing.Point(435, 66);
            this.btnAnnulerRecherche.Name = "btnAnnulerRecherche";
            this.btnAnnulerRecherche.Size = new System.Drawing.Size(84, 37);
            this.btnAnnulerRecherche.TabIndex = 1;
            this.btnAnnulerRecherche.Text = "Annuler";
            this.btnAnnulerRecherche.UseVisualStyleBackColor = false;
            this.btnAnnulerRecherche.Click += new System.EventHandler(this.btnAnnulerRecherche_Click);
            // 
            // cbRechercher
            // 
            this.cbRechercher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRechercher.FormattingEnabled = true;
            this.cbRechercher.Items.AddRange(new object[] {
            "",
            "id",
            "email",
            "Nom",
            "prenom",
            "psw",
            "telephone",
            "numRue",
            "nomRue",
            "ville",
            "codePostal"});
            this.cbRechercher.Location = new System.Drawing.Point(229, 55);
            this.cbRechercher.Name = "cbRechercher";
            this.cbRechercher.Size = new System.Drawing.Size(162, 21);
            this.cbRechercher.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblRechercher);
            this.panel2.Controls.Add(this.btnAnnulerRecherche);
            this.panel2.Controls.Add(this.cbRechercher);
            this.panel2.Controls.Add(this.txtRechercher);
            this.panel2.Location = new System.Drawing.Point(129, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 139);
            this.panel2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sélectionner un critère de recherche :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1644, 702);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Gestion Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblNumRue;
        private System.Windows.Forms.Label lblNomRue;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtNumRue;
        private System.Windows.Forms.TextBox txtNomRue;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn psw;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn numRue;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomRue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn statut;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblRechercher;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Button btnAnnulerRecherche;
        private System.Windows.Forms.ComboBox cbRechercher;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}

