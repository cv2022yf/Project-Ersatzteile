namespace Project_Ersatzteile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbTeil = new System.Windows.Forms.PictureBox();
            this.pbPosition = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtErsatzteilename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCadfile = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTeilevolume = new System.Windows.Forms.Label();
            this.lblTeileproduktionszeit = new System.Windows.Forms.Label();
            this.cmdBackwards = new System.Windows.Forms.Button();
            this.cmdForwards = new System.Windows.Forms.Button();
            this.cmdStart = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmdConfigload = new System.Windows.Forms.Button();
            this.cmdTeiledit = new System.Windows.Forms.Button();
            this.cmbConfig = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.cmdCaddateidownload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTeil
            // 
            this.pbTeil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTeil.Location = new System.Drawing.Point(64, 65);
            this.pbTeil.Name = "pbTeil";
            this.pbTeil.Size = new System.Drawing.Size(347, 361);
            this.pbTeil.TabIndex = 0;
            this.pbTeil.TabStop = false;
            // 
            // pbPosition
            // 
            this.pbPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPosition.Location = new System.Drawing.Point(475, 65);
            this.pbPosition.Name = "pbPosition";
            this.pbPosition.Size = new System.Drawing.Size(379, 361);
            this.pbPosition.TabIndex = 1;
            this.pbPosition.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bild von Ersatzteil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "3D-Druck Ausrichtung";
            // 
            // txtErsatzteilename
            // 
            this.txtErsatzteilename.Location = new System.Drawing.Point(1106, 65);
            this.txtErsatzteilename.Name = "txtErsatzteilename";
            this.txtErsatzteilename.Size = new System.Drawing.Size(200, 39);
            this.txtErsatzteilename.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(922, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ersatzteilname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(927, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "CAD Datei";
            // 
            // lblCadfile
            // 
            this.lblCadfile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCadfile.Location = new System.Drawing.Point(1107, 134);
            this.lblCadfile.Name = "lblCadfile";
            this.lblCadfile.Size = new System.Drawing.Size(199, 48);
            this.lblCadfile.TabIndex = 7;
            this.lblCadfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(927, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Volumen";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(927, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 32);
            this.label6.TabIndex = 9;
            this.label6.Text = "3D Druckzeit";
            // 
            // lblTeilevolume
            // 
            this.lblTeilevolume.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTeilevolume.Location = new System.Drawing.Point(1106, 304);
            this.lblTeilevolume.Name = "lblTeilevolume";
            this.lblTeilevolume.Size = new System.Drawing.Size(200, 64);
            this.lblTeilevolume.TabIndex = 10;
            this.lblTeilevolume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTeileproduktionszeit
            // 
            this.lblTeileproduktionszeit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTeileproduktionszeit.Location = new System.Drawing.Point(1106, 386);
            this.lblTeileproduktionszeit.Name = "lblTeileproduktionszeit";
            this.lblTeileproduktionszeit.Size = new System.Drawing.Size(200, 64);
            this.lblTeileproduktionszeit.TabIndex = 11;
            this.lblTeileproduktionszeit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdBackwards
            // 
            this.cmdBackwards.Location = new System.Drawing.Point(1053, 563);
            this.cmdBackwards.Name = "cmdBackwards";
            this.cmdBackwards.Size = new System.Drawing.Size(124, 44);
            this.cmdBackwards.TabIndex = 12;
            this.cmdBackwards.Text = "<<<";
            this.cmdBackwards.UseVisualStyleBackColor = true;
            this.cmdBackwards.Click += new System.EventHandler(this.cmdBackwards_Click);
            // 
            // cmdForwards
            // 
            this.cmdForwards.Location = new System.Drawing.Point(1182, 563);
            this.cmdForwards.Name = "cmdForwards";
            this.cmdForwards.Size = new System.Drawing.Size(124, 44);
            this.cmdForwards.TabIndex = 13;
            this.cmdForwards.Text = ">>>";
            this.cmdForwards.UseVisualStyleBackColor = true;
            this.cmdForwards.Click += new System.EventHandler(this.cmdForwards_Click);
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(923, 563);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(124, 44);
            this.cmdStart.TabIndex = 14;
            this.cmdStart.Text = "Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(228, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(229, 32);
            this.label7.TabIndex = 17;
            this.label7.Text = "Konfigurationsname";
            // 
            // cmdConfigload
            // 
            this.cmdConfigload.Location = new System.Drawing.Point(922, 469);
            this.cmdConfigload.Name = "cmdConfigload";
            this.cmdConfigload.Size = new System.Drawing.Size(384, 46);
            this.cmdConfigload.TabIndex = 18;
            this.cmdConfigload.Text = "Konfigurationspaket Laden";
            this.cmdConfigload.UseVisualStyleBackColor = true;
            this.cmdConfigload.Click += new System.EventHandler(this.cmdConfigload_Click);
            // 
            // cmdTeiledit
            // 
            this.cmdTeiledit.Location = new System.Drawing.Point(922, 613);
            this.cmdTeiledit.Name = "cmdTeiledit";
            this.cmdTeiledit.Size = new System.Drawing.Size(384, 46);
            this.cmdTeiledit.TabIndex = 19;
            this.cmdTeiledit.Text = "Ersatzteil bearbeiten";
            this.cmdTeiledit.UseVisualStyleBackColor = true;
            this.cmdTeiledit.Click += new System.EventHandler(this.cmdTeiledit_Click);
            // 
            // cmbConfig
            // 
            this.cmbConfig.FormattingEnabled = true;
            this.cmbConfig.Location = new System.Drawing.Point(476, 466);
            this.cmbConfig.Name = "cmbConfig";
            this.cmbConfig.Size = new System.Drawing.Size(423, 40);
            this.cmbConfig.TabIndex = 21;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(23, 702);
            this.dgv1.MultiSelect = false;
            this.dgv1.Name = "dgv1";
            this.dgv1.RowHeadersWidth = 82;
            this.dgv1.RowTemplate.Height = 41;
            this.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv1.Size = new System.Drawing.Size(855, 243);
            this.dgv1.TabIndex = 24;
            // 
            // cmdCaddateidownload
            // 
            this.cmdCaddateidownload.Location = new System.Drawing.Point(1107, 194);
            this.cmdCaddateidownload.Name = "cmdCaddateidownload";
            this.cmdCaddateidownload.Size = new System.Drawing.Size(199, 81);
            this.cmdCaddateidownload.TabIndex = 25;
            this.cmdCaddateidownload.Text = "CAD datei herunterladen";
            this.cmdCaddateidownload.UseVisualStyleBackColor = true;
            this.cmdCaddateidownload.Click += new System.EventHandler(this.cmdCaddateidownload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 674);
            this.Controls.Add(this.cmdCaddateidownload);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.cmbConfig);
            this.Controls.Add(this.cmdTeiledit);
            this.Controls.Add(this.cmdConfigload);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.cmdForwards);
            this.Controls.Add(this.cmdBackwards);
            this.Controls.Add(this.lblTeileproduktionszeit);
            this.Controls.Add(this.lblTeilevolume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCadfile);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtErsatzteilename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPosition);
            this.Controls.Add(this.pbTeil);
            this.Name = "Form1";
            this.Text = "3D-Druck Ersatzteile";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTeil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbTeil;
        private PictureBox pbPosition;
        private Label label1;
        private Label label2;
        private TextBox txtErsatzteilename;
        private Label label3;
        private Label label4;
        private Label lblCadfile;
        private Label label5;
        private Label label6;
        private Label lblTeilevolume;
        private Label lblTeileproduktionszeit;
        private Button cmdBackwards;
        private Button cmdForwards;
        private Button cmdStart;
        private Label label7;
        private Button cmdConfigload;
        private Button cmdTeiledit;
        private ComboBox cmbConfig;
        private SaveFileDialog saveFileDialog1;
        private DataGridView dgv1;
        private Button cmdCaddateidownload;
    }
}