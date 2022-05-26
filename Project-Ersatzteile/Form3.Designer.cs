namespace Project_Ersatzteile
{
    partial class Form3
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdNewteil = new System.Windows.Forms.Button();
            this.cmdTeildelete = new System.Windows.Forms.Button();
            this.txtTeilname3 = new System.Windows.Forms.TextBox();
            this.txtVolume3 = new System.Windows.Forms.TextBox();
            this.txtTeilezeit3 = new System.Windows.Forms.TextBox();
            this.lblCadfile3 = new System.Windows.Forms.Label();
            this.cmdCadupload = new System.Windows.Forms.Button();
            this.cmdTeilpicupload = new System.Windows.Forms.Button();
            this.cmdPositionpicfileupload = new System.Windows.Forms.Button();
            this.pbTeil = new System.Windows.Forms.PictureBox();
            this.pbPosition = new System.Windows.Forms.PictureBox();
            this.cmdTeiledit = new System.Windows.Forms.Button();
            this.cmdConfigdelete = new System.Windows.Forms.Button();
            this.cmdConfigupload = new System.Windows.Forms.Button();
            this.lstPakete = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosition)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(690, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "3D Druckzeit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(690, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Volumen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(690, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "CAD Datei";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ersatzteilname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "3D-Druck Ausrichtung";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bild von Ersatzteil";
            // 
            // cmdNewteil
            // 
            this.cmdNewteil.Location = new System.Drawing.Point(59, 627);
            this.cmdNewteil.Name = "cmdNewteil";
            this.cmdNewteil.Size = new System.Drawing.Size(315, 92);
            this.cmdNewteil.TabIndex = 16;
            this.cmdNewteil.Text = "Neues Teil hinzufuegen";
            this.cmdNewteil.UseVisualStyleBackColor = true;
            this.cmdNewteil.Click += new System.EventHandler(this.cmdNewteil_Click);
            // 
            // cmdTeildelete
            // 
            this.cmdTeildelete.Location = new System.Drawing.Point(982, 627);
            this.cmdTeildelete.Name = "cmdTeildelete";
            this.cmdTeildelete.Size = new System.Drawing.Size(315, 92);
            this.cmdTeildelete.TabIndex = 17;
            this.cmdTeildelete.Text = "Teil loeschen";
            this.cmdTeildelete.UseVisualStyleBackColor = true;
            this.cmdTeildelete.Click += new System.EventHandler(this.cmdTeildelete_Click);
            // 
            // txtTeilname3
            // 
            this.txtTeilname3.Location = new System.Drawing.Point(872, 12);
            this.txtTeilname3.Name = "txtTeilname3";
            this.txtTeilname3.Size = new System.Drawing.Size(222, 39);
            this.txtTeilname3.TabIndex = 18;
            // 
            // txtVolume3
            // 
            this.txtVolume3.Location = new System.Drawing.Point(870, 170);
            this.txtVolume3.Name = "txtVolume3";
            this.txtVolume3.Size = new System.Drawing.Size(224, 39);
            this.txtVolume3.TabIndex = 19;
            // 
            // txtTeilezeit3
            // 
            this.txtTeilezeit3.Location = new System.Drawing.Point(870, 226);
            this.txtTeilezeit3.Name = "txtTeilezeit3";
            this.txtTeilezeit3.Size = new System.Drawing.Size(224, 39);
            this.txtTeilezeit3.TabIndex = 20;
            // 
            // lblCadfile3
            // 
            this.lblCadfile3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCadfile3.Location = new System.Drawing.Point(872, 82);
            this.lblCadfile3.Name = "lblCadfile3";
            this.lblCadfile3.Size = new System.Drawing.Size(222, 48);
            this.lblCadfile3.TabIndex = 21;
            this.lblCadfile3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmdCadupload
            // 
            this.cmdCadupload.Location = new System.Drawing.Point(1116, 82);
            this.cmdCadupload.Name = "cmdCadupload";
            this.cmdCadupload.Size = new System.Drawing.Size(224, 46);
            this.cmdCadupload.TabIndex = 22;
            this.cmdCadupload.Text = "... CAD hochladen";
            this.cmdCadupload.UseVisualStyleBackColor = true;
            this.cmdCadupload.Click += new System.EventHandler(this.cmdCadupload_Click);
            // 
            // cmdTeilpicupload
            // 
            this.cmdTeilpicupload.Location = new System.Drawing.Point(452, 82);
            this.cmdTeilpicupload.Name = "cmdTeilpicupload";
            this.cmdTeilpicupload.Size = new System.Drawing.Size(150, 98);
            this.cmdTeilpicupload.TabIndex = 25;
            this.cmdTeilpicupload.Text = "... Bild hochladen";
            this.cmdTeilpicupload.UseVisualStyleBackColor = true;
            this.cmdTeilpicupload.Click += new System.EventHandler(this.cmdTeilpicupload_Click);
            // 
            // cmdPositionpicfileupload
            // 
            this.cmdPositionpicfileupload.Location = new System.Drawing.Point(452, 380);
            this.cmdPositionpicfileupload.Name = "cmdPositionpicfileupload";
            this.cmdPositionpicfileupload.Size = new System.Drawing.Size(190, 86);
            this.cmdPositionpicfileupload.TabIndex = 26;
            this.cmdPositionpicfileupload.Text = "... Ausrichtung Bild hochladen";
            this.cmdPositionpicfileupload.UseVisualStyleBackColor = true;
            this.cmdPositionpicfileupload.Click += new System.EventHandler(this.cmdPositionpicfileupload_Click);
            // 
            // pbTeil
            // 
            this.pbTeil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbTeil.Location = new System.Drawing.Point(59, 82);
            this.pbTeil.Name = "pbTeil";
            this.pbTeil.Size = new System.Drawing.Size(375, 210);
            this.pbTeil.TabIndex = 27;
            this.pbTeil.TabStop = false;
            // 
            // pbPosition
            // 
            this.pbPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPosition.Location = new System.Drawing.Point(59, 380);
            this.pbPosition.Name = "pbPosition";
            this.pbPosition.Size = new System.Drawing.Size(375, 210);
            this.pbPosition.TabIndex = 28;
            this.pbPosition.TabStop = false;
            // 
            // cmdTeiledit
            // 
            this.cmdTeiledit.Location = new System.Drawing.Point(526, 627);
            this.cmdTeiledit.Name = "cmdTeiledit";
            this.cmdTeiledit.Size = new System.Drawing.Size(315, 92);
            this.cmdTeiledit.TabIndex = 29;
            this.cmdTeiledit.Text = "Teil aendern";
            this.cmdTeiledit.UseVisualStyleBackColor = true;
            this.cmdTeiledit.Click += new System.EventHandler(this.cmdTeiledit_Click);
            // 
            // cmdConfigdelete
            // 
            this.cmdConfigdelete.Location = new System.Drawing.Point(1116, 461);
            this.cmdConfigdelete.Name = "cmdConfigdelete";
            this.cmdConfigdelete.Size = new System.Drawing.Size(231, 66);
            this.cmdConfigdelete.TabIndex = 36;
            this.cmdConfigdelete.Text = "Loeschen";
            this.cmdConfigdelete.UseVisualStyleBackColor = true;
            this.cmdConfigdelete.Click += new System.EventHandler(this.cmdConfigdelete_Click);
            // 
            // cmdConfigupload
            // 
            this.cmdConfigupload.Location = new System.Drawing.Point(1116, 363);
            this.cmdConfigupload.Name = "cmdConfigupload";
            this.cmdConfigupload.Size = new System.Drawing.Size(231, 73);
            this.cmdConfigupload.TabIndex = 34;
            this.cmdConfigupload.Text = "... Zip hochladen";
            this.cmdConfigupload.UseVisualStyleBackColor = true;
            this.cmdConfigupload.Click += new System.EventHandler(this.cmdConfigupload_Click);
            // 
            // lstPakete
            // 
            this.lstPakete.FormattingEnabled = true;
            this.lstPakete.ItemHeight = 32;
            this.lstPakete.Location = new System.Drawing.Point(853, 363);
            this.lstPakete.Name = "lstPakete";
            this.lstPakete.Size = new System.Drawing.Size(241, 164);
            this.lstPakete.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(853, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 32);
            this.label7.TabIndex = 37;
            this.label7.Text = "Konfigurationspakete";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1100, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 32);
            this.label8.TabIndex = 38;
            this.label8.Text = "cm^3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1100, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 32);
            this.label9.TabIndex = 39;
            this.label9.Text = "stunden";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 731);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmdConfigdelete);
            this.Controls.Add(this.cmdConfigupload);
            this.Controls.Add(this.lstPakete);
            this.Controls.Add(this.cmdTeiledit);
            this.Controls.Add(this.cmdTeildelete);
            this.Controls.Add(this.cmdNewteil);
            this.Controls.Add(this.pbPosition);
            this.Controls.Add(this.pbTeil);
            this.Controls.Add(this.cmdPositionpicfileupload);
            this.Controls.Add(this.cmdTeilpicupload);
            this.Controls.Add(this.cmdCadupload);
            this.Controls.Add(this.lblCadfile3);
            this.Controls.Add(this.txtTeilezeit3);
            this.Controls.Add(this.txtVolume3);
            this.Controls.Add(this.txtTeilname3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTeil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPosition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button cmdNewteil;
        private Button cmdTeildelete;
        private TextBox txtTeilname3;
        private TextBox txtVolume3;
        private TextBox txtTeilezeit3;
        private Label lblCadfile3;
        private Button cmdCadupload;
        private Button cmdTeilpicupload;
        private Button cmdPositionpicfileupload;
        private PictureBox pbTeil;
        private PictureBox pbPosition;
        private Button cmdTeiledit;
        private Button cmdConfigdelete;
        private Button cmdConfigupload;
        private ListBox lstPakete;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}