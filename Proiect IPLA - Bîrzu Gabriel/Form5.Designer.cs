namespace Proiect_IPLA___Bîrzu_Gabriel
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dtpSfarsit = new System.Windows.Forms.DateTimePicker();
            this.dtpInceput = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btCameraSelectata = new System.Windows.Forms.Button();
            this.cmbDisponibile = new System.Windows.Forms.ComboBox();
            this.btnCautare = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvRevervari = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbFitness = new System.Windows.Forms.CheckBox();
            this.cbClub = new System.Windows.Forms.CheckBox();
            this.cbMasaj = new System.Windows.Forms.CheckBox();
            this.cbSauna = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFinalizare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevervari)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(436, -609);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1059, 1271);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dtpSfarsit
            // 
            this.dtpSfarsit.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSfarsit.Location = new System.Drawing.Point(12, 142);
            this.dtpSfarsit.Name = "dtpSfarsit";
            this.dtpSfarsit.Size = new System.Drawing.Size(169, 20);
            this.dtpSfarsit.TabIndex = 18;
            this.dtpSfarsit.TabStop = false;
            this.dtpSfarsit.Leave += new System.EventHandler(this.dtpSfarsit_Leave);
            // 
            // dtpInceput
            // 
            this.dtpInceput.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInceput.Location = new System.Drawing.Point(12, 82);
            this.dtpInceput.Name = "dtpInceput";
            this.dtpInceput.Size = new System.Drawing.Size(169, 20);
            this.dtpInceput.TabIndex = 12;
            this.dtpInceput.TabStop = false;
            this.dtpInceput.Leave += new System.EventHandler(this.dtpInceput_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "CAMERE DISPONIBILE:";
            // 
            // btCameraSelectata
            // 
            this.btCameraSelectata.Location = new System.Drawing.Point(238, 108);
            this.btCameraSelectata.Name = "btCameraSelectata";
            this.btCameraSelectata.Size = new System.Drawing.Size(183, 44);
            this.btCameraSelectata.TabIndex = 16;
            this.btCameraSelectata.Text = "PREZENTARE CAMERĂ SELECTATĂ";
            this.btCameraSelectata.UseVisualStyleBackColor = true;
            this.btCameraSelectata.Click += new System.EventHandler(this.btCameraSelectata_Click);
            // 
            // cmbDisponibile
            // 
            this.cmbDisponibile.FormattingEnabled = true;
            this.cmbDisponibile.Location = new System.Drawing.Point(238, 81);
            this.cmbDisponibile.Name = "cmbDisponibile";
            this.cmbDisponibile.Size = new System.Drawing.Size(183, 21);
            this.cmbDisponibile.TabIndex = 15;
            // 
            // btnCautare
            // 
            this.btnCautare.BackColor = System.Drawing.Color.Crimson;
            this.btnCautare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCautare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCautare.Location = new System.Drawing.Point(12, 168);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(169, 33);
            this.btnCautare.TabIndex = 14;
            this.btnCautare.Text = "CĂUTARE";
            this.btnCautare.UseVisualStyleBackColor = false;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "DATĂ SFÂRȘIT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "DATĂ ÎNCEPUT:";
            // 
            // dgvRevervari
            // 
            this.dgvRevervari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRevervari.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRevervari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevervari.Location = new System.Drawing.Point(12, 218);
            this.dgvRevervari.MultiSelect = false;
            this.dgvRevervari.Name = "dgvRevervari";
            this.dgvRevervari.ReadOnly = true;
            this.dgvRevervari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRevervari.Size = new System.Drawing.Size(409, 130);
            this.dgvRevervari.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "INTRODUCEȚI DATELE NECESARE REZERVĂRII:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 44);
            this.button1.TabIndex = 21;
            this.button1.Text = "ADĂUGARE CAMERA PENTRU REZERVARE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbFitness);
            this.groupBox2.Controls.Add(this.cbClub);
            this.groupBox2.Controls.Add(this.cbMasaj);
            this.groupBox2.Controls.Add(this.cbSauna);
            this.groupBox2.Location = new System.Drawing.Point(12, 367);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 99);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EXTRAOPȚIUNI";
            // 
            // cbFitness
            // 
            this.cbFitness.AutoSize = true;
            this.cbFitness.Location = new System.Drawing.Point(332, 47);
            this.cbFitness.Name = "cbFitness";
            this.cbFitness.Size = new System.Drawing.Size(71, 17);
            this.cbFitness.TabIndex = 4;
            this.cbFitness.Text = "FITNESS";
            this.cbFitness.UseVisualStyleBackColor = true;
            // 
            // cbClub
            // 
            this.cbClub.AutoSize = true;
            this.cbClub.Location = new System.Drawing.Point(6, 47);
            this.cbClub.Name = "cbClub";
            this.cbClub.Size = new System.Drawing.Size(54, 17);
            this.cbClub.TabIndex = 1;
            this.cbClub.Text = "CLUB";
            this.cbClub.UseVisualStyleBackColor = true;
            // 
            // cbMasaj
            // 
            this.cbMasaj.AutoSize = true;
            this.cbMasaj.Location = new System.Drawing.Point(227, 47);
            this.cbMasaj.Name = "cbMasaj";
            this.cbMasaj.Size = new System.Drawing.Size(61, 17);
            this.cbMasaj.TabIndex = 3;
            this.cbMasaj.Text = "MASAJ";
            this.cbMasaj.UseVisualStyleBackColor = true;
            // 
            // cbSauna
            // 
            this.cbSauna.AutoSize = true;
            this.cbSauna.Location = new System.Drawing.Point(115, 47);
            this.cbSauna.Name = "cbSauna";
            this.cbSauna.Size = new System.Drawing.Size(63, 17);
            this.cbSauna.TabIndex = 2;
            this.cbSauna.Text = "SAUNĂ";
            this.cbSauna.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(315, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 33);
            this.button2.TabIndex = 23;
            this.button2.Text = "REVENIRE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFinalizare
            // 
            this.btnFinalizare.BackColor = System.Drawing.Color.Crimson;
            this.btnFinalizare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizare.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFinalizare.Location = new System.Drawing.Point(127, 481);
            this.btnFinalizare.Name = "btnFinalizare";
            this.btnFinalizare.Size = new System.Drawing.Size(173, 33);
            this.btnFinalizare.TabIndex = 24;
            this.btnFinalizare.Text = "FINALIZARE";
            this.btnFinalizare.UseVisualStyleBackColor = false;
            this.btnFinalizare.Click += new System.EventHandler(this.btnFinalizare_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(758, 526);
            this.Controls.Add(this.btnFinalizare);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvRevervari);
            this.Controls.Add(this.dtpSfarsit);
            this.Controls.Add(this.dtpInceput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btCameraSelectata);
            this.Controls.Add(this.cmbDisponibile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCautare);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevervari)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dtpSfarsit;
        private System.Windows.Forms.DateTimePicker dtpInceput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btCameraSelectata;
        private System.Windows.Forms.ComboBox cmbDisponibile;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvRevervari;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbFitness;
        private System.Windows.Forms.CheckBox cbClub;
        private System.Windows.Forms.CheckBox cbMasaj;
        private System.Windows.Forms.CheckBox cbSauna;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnFinalizare;
    }
}