namespace MasterDetailsApp
{
    partial class FormMain
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
            this.tabCtrlDataEmployés = new System.Windows.Forms.TabControl();
            this.tabDetailsEmployé = new System.Windows.Forms.TabPage();
            this.panelFinal = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnEnregister = new System.Windows.Forms.Button();
            this.dgvEmployéSociété = new System.Windows.Forms.DataGridView();
            this.dgvtxtEmpCompID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtNomSociété = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbPosition = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtAnnée = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnImageClear = new System.Windows.Forms.Button();
            this.btnImageParcourir = new System.Windows.Forms.Button();
            this.pbxPhoto = new System.Windows.Forms.PictureBox();
            this.rbtnContractual = new System.Windows.Forms.RadioButton();
            this.rbtnRegular = new System.Windows.Forms.RadioButton();
            this.cmbGenre = new System.Windows.Forms.ComboBox();
            this.dateTimeDDN = new System.Windows.Forms.DateTimePicker();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.txtBoxCode = new System.Windows.Forms.TextBox();
            this.labelEtat = new System.Windows.Forms.Label();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelDDN = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.tabAjouterEmployé = new System.Windows.Forms.TabPage();
            this.dgvEmployés = new System.Windows.Forms.DataGridView();
            this.tabCtrlDataEmployés.SuspendLayout();
            this.tabDetailsEmployé.SuspendLayout();
            this.panelFinal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployéSociété)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).BeginInit();
            this.tabAjouterEmployé.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployés)).BeginInit();
            this.SuspendLayout();
            // 
            // tabCtrlDataEmployés
            // 
            this.tabCtrlDataEmployés.Controls.Add(this.tabDetailsEmployé);
            this.tabCtrlDataEmployés.Controls.Add(this.tabAjouterEmployé);
            this.tabCtrlDataEmployés.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCtrlDataEmployés.Location = new System.Drawing.Point(13, 13);
            this.tabCtrlDataEmployés.Name = "tabCtrlDataEmployés";
            this.tabCtrlDataEmployés.SelectedIndex = 0;
            this.tabCtrlDataEmployés.Size = new System.Drawing.Size(1000, 645);
            this.tabCtrlDataEmployés.TabIndex = 0;
            // 
            // tabDetailsEmployé
            // 
            this.tabDetailsEmployé.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabDetailsEmployé.Controls.Add(this.panelFinal);
            this.tabDetailsEmployé.Controls.Add(this.dgvEmployéSociété);
            this.tabDetailsEmployé.Controls.Add(this.btnImageClear);
            this.tabDetailsEmployé.Controls.Add(this.btnImageParcourir);
            this.tabDetailsEmployé.Controls.Add(this.pbxPhoto);
            this.tabDetailsEmployé.Controls.Add(this.rbtnContractual);
            this.tabDetailsEmployé.Controls.Add(this.rbtnRegular);
            this.tabDetailsEmployé.Controls.Add(this.cmbGenre);
            this.tabDetailsEmployé.Controls.Add(this.dateTimeDDN);
            this.tabDetailsEmployé.Controls.Add(this.cmbPosition);
            this.tabDetailsEmployé.Controls.Add(this.txtBoxNom);
            this.tabDetailsEmployé.Controls.Add(this.txtBoxCode);
            this.tabDetailsEmployé.Controls.Add(this.labelEtat);
            this.tabDetailsEmployé.Controls.Add(this.labelGenre);
            this.tabDetailsEmployé.Controls.Add(this.labelDDN);
            this.tabDetailsEmployé.Controls.Add(this.labelPosition);
            this.tabDetailsEmployé.Controls.Add(this.labelNom);
            this.tabDetailsEmployé.Controls.Add(this.labelCode);
            this.tabDetailsEmployé.Location = new System.Drawing.Point(4, 29);
            this.tabDetailsEmployé.Name = "tabDetailsEmployé";
            this.tabDetailsEmployé.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetailsEmployé.Size = new System.Drawing.Size(992, 612);
            this.tabDetailsEmployé.TabIndex = 0;
            this.tabDetailsEmployé.Text = "Détails";
            // 
            // panelFinal
            // 
            this.panelFinal.Controls.Add(this.btnReset);
            this.panelFinal.Controls.Add(this.btnSupprimer);
            this.panelFinal.Controls.Add(this.btnEnregister);
            this.panelFinal.Location = new System.Drawing.Point(13, 534);
            this.panelFinal.Name = "panelFinal";
            this.panelFinal.Size = new System.Drawing.Size(959, 72);
            this.panelFinal.TabIndex = 17;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(541, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 34);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(421, 19);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(114, 34);
            this.btnSupprimer.TabIndex = 17;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnEnregister
            // 
            this.btnEnregister.Location = new System.Drawing.Point(301, 19);
            this.btnEnregister.Name = "btnEnregister";
            this.btnEnregister.Size = new System.Drawing.Size(114, 34);
            this.btnEnregister.TabIndex = 16;
            this.btnEnregister.Text = "Enregistrer";
            this.btnEnregister.UseVisualStyleBackColor = true;
            this.btnEnregister.Click += new System.EventHandler(this.btnEnregister_Click);
            // 
            // dgvEmployéSociété
            // 
            this.dgvEmployéSociété.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployéSociété.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtEmpCompID,
            this.dgvtxtNomSociété,
            this.dgvcmbPosition,
            this.dgvtxtAnnée});
            this.dgvEmployéSociété.Location = new System.Drawing.Point(13, 358);
            this.dgvEmployéSociété.Name = "dgvEmployéSociété";
            this.dgvEmployéSociété.Size = new System.Drawing.Size(959, 170);
            this.dgvEmployéSociété.TabIndex = 16;
            this.dgvEmployéSociété.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvEmployéSociété_UserDeletingRow);
            // 
            // dgvtxtEmpCompID
            // 
            this.dgvtxtEmpCompID.DataPropertyName = "EMPSOC_ID";
            this.dgvtxtEmpCompID.HeaderText = "EmpSoc_Id";
            this.dgvtxtEmpCompID.Name = "dgvtxtEmpCompID";
            this.dgvtxtEmpCompID.Visible = false;
            // 
            // dgvtxtNomSociété
            // 
            this.dgvtxtNomSociété.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvtxtNomSociété.DataPropertyName = "EMPSOC_Nom";
            this.dgvtxtNomSociété.HeaderText = "Nom_société";
            this.dgvtxtNomSociété.Name = "dgvtxtNomSociété";
            // 
            // dgvcmbPosition
            // 
            this.dgvcmbPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvcmbPosition.DataPropertyName = "EMPSOC_POS_ID";
            this.dgvcmbPosition.HeaderText = "Position";
            this.dgvcmbPosition.Name = "dgvcmbPosition";
            this.dgvcmbPosition.Width = 71;
            // 
            // dgvtxtAnnée
            // 
            this.dgvtxtAnnée.DataPropertyName = "EMPSOC_AnneeExp";
            this.dgvtxtAnnée.HeaderText = "Année";
            this.dgvtxtAnnée.Name = "dgvtxtAnnée";
            // 
            // btnImageClear
            // 
            this.btnImageClear.Location = new System.Drawing.Point(723, 307);
            this.btnImageClear.Name = "btnImageClear";
            this.btnImageClear.Size = new System.Drawing.Size(114, 34);
            this.btnImageClear.TabIndex = 15;
            this.btnImageClear.Text = "Clear";
            this.btnImageClear.UseVisualStyleBackColor = true;
            this.btnImageClear.Click += new System.EventHandler(this.btnImageClear_Click);
            // 
            // btnImageParcourir
            // 
            this.btnImageParcourir.Location = new System.Drawing.Point(603, 307);
            this.btnImageParcourir.Name = "btnImageParcourir";
            this.btnImageParcourir.Size = new System.Drawing.Size(114, 34);
            this.btnImageParcourir.TabIndex = 14;
            this.btnImageParcourir.Text = "Parcourir";
            this.btnImageParcourir.UseVisualStyleBackColor = true;
            this.btnImageParcourir.Click += new System.EventHandler(this.btnImageParcourir_Click);
            // 
            // pbxPhoto
            // 
            this.pbxPhoto.Location = new System.Drawing.Point(603, 23);
            this.pbxPhoto.Name = "pbxPhoto";
            this.pbxPhoto.Size = new System.Drawing.Size(369, 278);
            this.pbxPhoto.TabIndex = 13;
            this.pbxPhoto.TabStop = false;
            // 
            // rbtnContractual
            // 
            this.rbtnContractual.AutoSize = true;
            this.rbtnContractual.Location = new System.Drawing.Point(253, 273);
            this.rbtnContractual.Name = "rbtnContractual";
            this.rbtnContractual.Size = new System.Drawing.Size(109, 24);
            this.rbtnContractual.TabIndex = 12;
            this.rbtnContractual.TabStop = true;
            this.rbtnContractual.Text = "Contractuel";
            this.rbtnContractual.UseVisualStyleBackColor = true;
            // 
            // rbtnRegular
            // 
            this.rbtnRegular.AutoSize = true;
            this.rbtnRegular.Location = new System.Drawing.Point(161, 273);
            this.rbtnRegular.Name = "rbtnRegular";
            this.rbtnRegular.Size = new System.Drawing.Size(86, 24);
            this.rbtnRegular.TabIndex = 11;
            this.rbtnRegular.TabStop = true;
            this.rbtnRegular.Text = "Régulier";
            this.rbtnRegular.UseVisualStyleBackColor = true;
            // 
            // cmbGenre
            // 
            this.cmbGenre.FormattingEnabled = true;
            this.cmbGenre.Items.AddRange(new object[] {
            "Masculin",
            "Féminin",
            "Autre"});
            this.cmbGenre.Location = new System.Drawing.Point(161, 221);
            this.cmbGenre.Name = "cmbGenre";
            this.cmbGenre.Size = new System.Drawing.Size(371, 28);
            this.cmbGenre.TabIndex = 10;
            // 
            // dateTimeDDN
            // 
            this.dateTimeDDN.CustomFormat = "dd-MM-yyyy";
            this.dateTimeDDN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDDN.Location = new System.Drawing.Point(161, 169);
            this.dateTimeDDN.Name = "dateTimeDDN";
            this.dateTimeDDN.Size = new System.Drawing.Size(371, 26);
            this.dateTimeDDN.TabIndex = 9;
            // 
            // cmbPosition
            // 
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(161, 123);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(371, 28);
            this.cmbPosition.TabIndex = 8;
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(161, 72);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(371, 26);
            this.txtBoxNom.TabIndex = 7;
            // 
            // txtBoxCode
            // 
            this.txtBoxCode.Location = new System.Drawing.Point(161, 25);
            this.txtBoxCode.Name = "txtBoxCode";
            this.txtBoxCode.Size = new System.Drawing.Size(371, 26);
            this.txtBoxCode.TabIndex = 6;
            // 
            // labelEtat
            // 
            this.labelEtat.AutoSize = true;
            this.labelEtat.ForeColor = System.Drawing.Color.Red;
            this.labelEtat.Location = new System.Drawing.Point(116, 273);
            this.labelEtat.Name = "labelEtat";
            this.labelEtat.Size = new System.Drawing.Size(39, 20);
            this.labelEtat.TabIndex = 5;
            this.labelEtat.Text = "Etat";
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.ForeColor = System.Drawing.Color.Red;
            this.labelGenre.Location = new System.Drawing.Point(101, 224);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(54, 20);
            this.labelGenre.TabIndex = 4;
            this.labelGenre.Text = "Genre";
            // 
            // labelDDN
            // 
            this.labelDDN.AutoSize = true;
            this.labelDDN.ForeColor = System.Drawing.Color.Red;
            this.labelDDN.Location = new System.Drawing.Point(13, 169);
            this.labelDDN.Name = "labelDDN";
            this.labelDDN.Size = new System.Drawing.Size(142, 20);
            this.labelDDN.TabIndex = 3;
            this.labelDDN.Text = "Date de naissance";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.ForeColor = System.Drawing.Color.Red;
            this.labelPosition.Location = new System.Drawing.Point(90, 126);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(65, 20);
            this.labelPosition.TabIndex = 2;
            this.labelPosition.Text = "Position";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.ForeColor = System.Drawing.Color.Red;
            this.labelNom.Location = new System.Drawing.Point(113, 72);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(42, 20);
            this.labelNom.TabIndex = 1;
            this.labelNom.Text = "Nom";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.ForeColor = System.Drawing.Color.Red;
            this.labelCode.Location = new System.Drawing.Point(108, 28);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(47, 20);
            this.labelCode.TabIndex = 0;
            this.labelCode.Text = "Code";
            // 
            // tabAjouterEmployé
            // 
            this.tabAjouterEmployé.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabAjouterEmployé.Controls.Add(this.dgvEmployés);
            this.tabAjouterEmployé.Location = new System.Drawing.Point(4, 29);
            this.tabAjouterEmployé.Name = "tabAjouterEmployé";
            this.tabAjouterEmployé.Padding = new System.Windows.Forms.Padding(3);
            this.tabAjouterEmployé.Size = new System.Drawing.Size(992, 612);
            this.tabAjouterEmployé.TabIndex = 1;
            this.tabAjouterEmployé.Text = "Enregistement";
            // 
            // dgvEmployés
            // 
            this.dgvEmployés.AllowUserToAddRows = false;
            this.dgvEmployés.AllowUserToDeleteRows = false;
            this.dgvEmployés.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployés.Location = new System.Drawing.Point(6, 13);
            this.dgvEmployés.Name = "dgvEmployés";
            this.dgvEmployés.ReadOnly = true;
            this.dgvEmployés.Size = new System.Drawing.Size(980, 588);
            this.dgvEmployés.TabIndex = 0;
            this.dgvEmployés.DoubleClick += new System.EventHandler(this.dgvEmployés_DoubleClick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 670);
            this.Controls.Add(this.tabCtrlDataEmployés);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Details";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabCtrlDataEmployés.ResumeLayout(false);
            this.tabDetailsEmployé.ResumeLayout(false);
            this.tabDetailsEmployé.PerformLayout();
            this.panelFinal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployéSociété)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPhoto)).EndInit();
            this.tabAjouterEmployé.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployés)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlDataEmployés;
        private System.Windows.Forms.TabPage tabDetailsEmployé;
        private System.Windows.Forms.TabPage tabAjouterEmployé;
        private System.Windows.Forms.Label labelEtat;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelDDN;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.TextBox txtBoxCode;
        private System.Windows.Forms.RadioButton rbtnContractual;
        private System.Windows.Forms.RadioButton rbtnRegular;
        private System.Windows.Forms.ComboBox cmbGenre;
        private System.Windows.Forms.DateTimePicker dateTimeDDN;
        private System.Windows.Forms.PictureBox pbxPhoto;
        private System.Windows.Forms.Button btnImageClear;
        private System.Windows.Forms.Button btnImageParcourir;
        private System.Windows.Forms.Panel panelFinal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnEnregister;
        private System.Windows.Forms.DataGridView dgvEmployéSociété;
        private System.Windows.Forms.DataGridView dgvEmployés;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEmpCompID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtNomSociété;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAnnée;
    }
}

