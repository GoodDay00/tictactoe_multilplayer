namespace MoninPeli_Projekti
{
    partial class TeeUusiHuone
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
            this.huone_nimi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tarvitsee_salasanan = new System.Windows.Forms.CheckBox();
            this.huoneMuoto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.huone_salasana_label = new System.Windows.Forms.Label();
            this.huone_salasana = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // huone_nimi
            // 
            this.huone_nimi.Location = new System.Drawing.Point(157, 37);
            this.huone_nimi.Name = "huone_nimi";
            this.huone_nimi.Size = new System.Drawing.Size(206, 23);
            this.huone_nimi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Huoneen nimi:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tarvitsee_salasanan);
            this.groupBox1.Controls.Add(this.huoneMuoto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.huone_salasana_label);
            this.groupBox1.Controls.Add(this.huone_salasana);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.huone_nimi);
            this.groupBox1.Font = new System.Drawing.Font("Calibri Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 188);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Huoneen asetukset";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tarvitsee_salasanan
            // 
            this.tarvitsee_salasanan.AutoSize = true;
            this.tarvitsee_salasanan.Location = new System.Drawing.Point(157, 108);
            this.tarvitsee_salasanan.Name = "tarvitsee_salasanan";
            this.tarvitsee_salasanan.Size = new System.Drawing.Size(132, 21);
            this.tarvitsee_salasanan.TabIndex = 3;
            this.tarvitsee_salasanan.Text = "Tarvitsee salasana";
            this.tarvitsee_salasanan.UseVisualStyleBackColor = true;
            this.tarvitsee_salasanan.Click += new System.EventHandler(this.tarvitsee_salasanan_Click);
            // 
            // huoneMuoto
            // 
            this.huoneMuoto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.huoneMuoto.Items.AddRange(new object[] {
            "Tic tac toe",
            "Connect 4"});
            this.huoneMuoto.Location = new System.Drawing.Point(157, 79);
            this.huoneMuoto.Name = "huoneMuoto";
            this.huoneMuoto.Size = new System.Drawing.Size(206, 23);
            this.huoneMuoto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pelimuoto:";
            // 
            // huone_salasana_label
            // 
            this.huone_salasana_label.AutoSize = true;
            this.huone_salasana_label.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.huone_salasana_label.Location = new System.Drawing.Point(77, 137);
            this.huone_salasana_label.Name = "huone_salasana_label";
            this.huone_salasana_label.Size = new System.Drawing.Size(74, 21);
            this.huone_salasana_label.TabIndex = 1;
            this.huone_salasana_label.Text = "Salasana:";
            // 
            // huone_salasana
            // 
            this.huone_salasana.Location = new System.Drawing.Point(157, 135);
            this.huone_salasana.Name = "huone_salasana";
            this.huone_salasana.Size = new System.Drawing.Size(206, 23);
            this.huone_salasana.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 88);
            this.button1.TabIndex = 4;
            this.button1.Text = "Takaisin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(261, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 88);
            this.button2.TabIndex = 4;
            this.button2.Text = "Tee huone";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TeeUusiHuone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 306);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "TeeUusiHuone";
            this.Text = "TeeUusiHuone";
            this.Load += new System.EventHandler(this.TeeUusiHuone_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox huone_nimi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox tarvitsee_salasanan;
        private System.Windows.Forms.Label huone_salasana_label;
        private System.Windows.Forms.TextBox huone_salasana;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox huoneMuoto;
    }
}