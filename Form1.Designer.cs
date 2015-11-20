namespace DesignPatternObserver_Animorphe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chkBox_SonActivation = new System.Windows.Forms.CheckBox();
            this.chkBox_Son = new System.Windows.Forms.CheckBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_Detach = new System.Windows.Forms.Button();
            this.btn_Attach = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_PattesNom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_AnimorpheNom = new System.Windows.Forms.Label();
            this.picTete = new System.Windows.Forms.PictureBox();
            this.picCorps = new System.Windows.Forms.PictureBox();
            this.picPattes = new System.Windows.Forms.PictureBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_TeteNom = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_CorpsNom = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstViewAnimaux = new System.Windows.Forms.ListView();
            this._Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._Tete = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._Coprs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._Pattes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPattes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkBox_SonActivation);
            this.splitContainer1.Panel1.Controls.Add(this.chkBox_Son);
            this.splitContainer1.Panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Detach);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Attach);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_AnimorpheNom);
            this.splitContainer1.Panel1.Controls.Add(this.picTete);
            this.splitContainer1.Panel1.Controls.Add(this.picCorps);
            this.splitContainer1.Panel1.Controls.Add(this.picPattes);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Start);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lstViewAnimaux);
            this.splitContainer1.Size = new System.Drawing.Size(736, 878);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 0;
            // 
            // chkBox_SonActivation
            // 
            this.chkBox_SonActivation.AutoSize = true;
            this.chkBox_SonActivation.Location = new System.Drawing.Point(435, 258);
            this.chkBox_SonActivation.Name = "chkBox_SonActivation";
            this.chkBox_SonActivation.Size = new System.Drawing.Size(81, 17);
            this.chkBox_SonActivation.TabIndex = 27;
            this.chkBox_SonActivation.Text = "Activer Son";
            this.chkBox_SonActivation.UseVisualStyleBackColor = true;
            this.chkBox_SonActivation.CheckedChanged += new System.EventHandler(this.chkBox_SonActivation_CheckedChanged);
            // 
            // chkBox_Son
            // 
            this.chkBox_Son.AutoSize = true;
            this.chkBox_Son.Checked = true;
            this.chkBox_Son.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_Son.Enabled = false;
            this.chkBox_Son.Location = new System.Drawing.Point(435, 276);
            this.chkBox_Son.Name = "chkBox_Son";
            this.chkBox_Son.Size = new System.Drawing.Size(150, 17);
            this.chkBox_Son.TabIndex = 26;
            this.chkBox_Son.Text = "Mode Sonore : Synchrone";
            this.chkBox_Son.UseVisualStyleBackColor = true;
            this.chkBox_Son.CheckedChanged += new System.EventHandler(this.chkBx_Son_CheckedChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(697, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(36, 36);
            this.axWindowsMediaPlayer1.TabIndex = 25;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // btn_Detach
            // 
            this.btn_Detach.Location = new System.Drawing.Point(305, 12);
            this.btn_Detach.Name = "btn_Detach";
            this.btn_Detach.Size = new System.Drawing.Size(62, 23);
            this.btn_Detach.TabIndex = 24;
            this.btn_Detach.Text = "Détacher";
            this.btn_Detach.UseVisualStyleBackColor = true;
            this.btn_Detach.Click += new System.EventHandler(this.btn_Detach_Click);
            // 
            // btn_Attach
            // 
            this.btn_Attach.Enabled = false;
            this.btn_Attach.Location = new System.Drawing.Point(240, 12);
            this.btn_Attach.Name = "btn_Attach";
            this.btn_Attach.Size = new System.Drawing.Size(59, 23);
            this.btn_Attach.TabIndex = 23;
            this.btn_Attach.Text = "Attacher";
            this.btn_Attach.UseVisualStyleBackColor = true;
            this.btn_Attach.Click += new System.EventHandler(this.btn_Attach_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_PattesNom);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(423, 187);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(219, 65);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pattes";
            // 
            // lbl_PattesNom
            // 
            this.lbl_PattesNom.AutoSize = true;
            this.lbl_PattesNom.Location = new System.Drawing.Point(127, 30);
            this.lbl_PattesNom.Name = "lbl_PattesNom";
            this.lbl_PattesNom.Size = new System.Drawing.Size(52, 13);
            this.lbl_PattesNom.TabIndex = 18;
            this.lbl_PattesNom.Text = "---------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Animal Choisi :";
            // 
            // lbl_AnimorpheNom
            // 
            this.lbl_AnimorpheNom.AutoSize = true;
            this.lbl_AnimorpheNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AnimorpheNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_AnimorpheNom.Location = new System.Drawing.Point(428, 6);
            this.lbl_AnimorpheNom.Name = "lbl_AnimorpheNom";
            this.lbl_AnimorpheNom.Size = new System.Drawing.Size(174, 38);
            this.lbl_AnimorpheNom.TabIndex = 21;
            this.lbl_AnimorpheNom.Text = "Animorphe";
            // 
            // picTete
            // 
            this.picTete.BackColor = System.Drawing.Color.White;
            this.picTete.Location = new System.Drawing.Point(12, 45);
            this.picTete.Name = "picTete";
            this.picTete.Size = new System.Drawing.Size(61, 246);
            this.picTete.TabIndex = 20;
            this.picTete.TabStop = false;
            // 
            // picCorps
            // 
            this.picCorps.BackColor = System.Drawing.Color.White;
            this.picCorps.Location = new System.Drawing.Point(79, 45);
            this.picCorps.Name = "picCorps";
            this.picCorps.Size = new System.Drawing.Size(140, 246);
            this.picCorps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCorps.TabIndex = 19;
            this.picCorps.TabStop = false;
            // 
            // picPattes
            // 
            this.picPattes.BackColor = System.Drawing.Color.White;
            this.picPattes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picPattes.Location = new System.Drawing.Point(225, 45);
            this.picPattes.Name = "picPattes";
            this.picPattes.Size = new System.Drawing.Size(142, 246);
            this.picPattes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPattes.TabIndex = 18;
            this.picPattes.TabStop = false;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(12, 12);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(61, 23);
            this.btn_Start.TabIndex = 16;
            this.btn_Start.Text = "Générer";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_TeteNom);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(423, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 65);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tête";
            // 
            // lbl_TeteNom
            // 
            this.lbl_TeteNom.AutoSize = true;
            this.lbl_TeteNom.Location = new System.Drawing.Point(127, 30);
            this.lbl_TeteNom.Name = "lbl_TeteNom";
            this.lbl_TeteNom.Size = new System.Drawing.Size(52, 13);
            this.lbl_TeteNom.TabIndex = 16;
            this.lbl_TeteNom.Text = "---------------";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Animal Choisi :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_CorpsNom);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(423, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 65);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Corps";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 13;
            // 
            // lbl_CorpsNom
            // 
            this.lbl_CorpsNom.AutoSize = true;
            this.lbl_CorpsNom.Location = new System.Drawing.Point(127, 29);
            this.lbl_CorpsNom.Name = "lbl_CorpsNom";
            this.lbl_CorpsNom.Size = new System.Drawing.Size(52, 13);
            this.lbl_CorpsNom.TabIndex = 12;
            this.lbl_CorpsNom.Text = "---------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Animal Choisi :";
            // 
            // lstViewAnimaux
            // 
            this.lstViewAnimaux.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._Nom,
            this._Tete,
            this._Coprs,
            this._Pattes});
            this.lstViewAnimaux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstViewAnimaux.FullRowSelect = true;
            this.lstViewAnimaux.GridLines = true;
            this.lstViewAnimaux.Location = new System.Drawing.Point(0, 0);
            this.lstViewAnimaux.Name = "lstViewAnimaux";
            this.lstViewAnimaux.Size = new System.Drawing.Size(736, 577);
            this.lstViewAnimaux.TabIndex = 16;
            this.lstViewAnimaux.UseCompatibleStateImageBehavior = false;
            this.lstViewAnimaux.View = System.Windows.Forms.View.Details;
            this.lstViewAnimaux.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstViewAnimaux_MouseDoubleClick);
            // 
            // _Nom
            // 
            this._Nom.Text = "Nom Animal Choisi";
            this._Nom.Width = 190;
            // 
            // _Tete
            // 
            this._Tete.Text = "Tête de ...";
            this._Tete.Width = 180;
            // 
            // _Coprs
            // 
            this._Coprs.Text = "Corps de ...";
            this._Coprs.Width = 180;
            // 
            // _Pattes
            // 
            this._Pattes.Text = "Pattes de ...";
            this._Pattes.Width = 180;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 878);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anti-Darwin - Le Générateur d\'Hybrides";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCorps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPattes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_PattesNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_AnimorpheNom;
        private System.Windows.Forms.PictureBox picTete;
        private System.Windows.Forms.PictureBox picCorps;
        private System.Windows.Forms.PictureBox picPattes;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_TeteNom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_CorpsNom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lstViewAnimaux;
        private System.Windows.Forms.ColumnHeader _Nom;
        private System.Windows.Forms.ColumnHeader _Tete;
        private System.Windows.Forms.ColumnHeader _Coprs;
        private System.Windows.Forms.ColumnHeader _Pattes;
        private System.Windows.Forms.Button btn_Detach;
        private System.Windows.Forms.Button btn_Attach;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.CheckBox chkBox_Son;
        private System.Windows.Forms.CheckBox chkBox_SonActivation;

    }
}

