namespace MoninPeli_Projekti
{
    partial class Menu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kirjauduUlos = new System.Windows.Forms.Button();
            this.tasapelit = new System.Windows.Forms.Label();
            this.haviot = new System.Windows.Forms.Label();
            this.wins = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kirjauduUlos);
            this.groupBox1.Controls.Add(this.tasapelit);
            this.groupBox1.Controls.Add(this.haviot);
            this.groupBox1.Controls.Add(this.wins);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Font = new System.Drawing.Font("Calibri Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tietosi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // kirjauduUlos
            // 
            this.kirjauduUlos.BackColor = System.Drawing.SystemColors.Highlight;
            this.kirjauduUlos.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kirjauduUlos.Location = new System.Drawing.Point(6, 275);
            this.kirjauduUlos.Name = "kirjauduUlos";
            this.kirjauduUlos.Size = new System.Drawing.Size(229, 41);
            this.kirjauduUlos.TabIndex = 2;
            this.kirjauduUlos.Text = "Kirjaudu ulos";
            this.kirjauduUlos.UseVisualStyleBackColor = false;
            this.kirjauduUlos.Click += new System.EventHandler(this.button3_Click);
            // 
            // tasapelit
            // 
            this.tasapelit.AutoSize = true;
            this.tasapelit.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasapelit.Location = new System.Drawing.Point(123, 196);
            this.tasapelit.Name = "tasapelit";
            this.tasapelit.Size = new System.Drawing.Size(49, 29);
            this.tasapelit.TabIndex = 1;
            this.tasapelit.Text = "120";
            // 
            // haviot
            // 
            this.haviot.AutoSize = true;
            this.haviot.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haviot.Location = new System.Drawing.Point(123, 167);
            this.haviot.Name = "haviot";
            this.haviot.Size = new System.Drawing.Size(49, 29);
            this.haviot.TabIndex = 1;
            this.haviot.Text = "120";
            // 
            // wins
            // 
            this.wins.AutoSize = true;
            this.wins.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wins.Location = new System.Drawing.Point(123, 138);
            this.wins.Name = "wins";
            this.wins.Size = new System.Drawing.Size(49, 29);
            this.wins.TabIndex = 1;
            this.wins.Text = "120";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tasapelit:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Häviöt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Voitot:";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Calibri Light", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(6, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(229, 94);
            this.name.TabIndex = 0;
            this.name.Text = "Ville";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(259, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(390, 158);
            this.button1.TabIndex = 1;
            this.button1.Text = "Liity huoneeseen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Font = new System.Drawing.Font("Calibri Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(259, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(390, 158);
            this.button2.TabIndex = 1;
            this.button2.Text = "Tee oma huone";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 348);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label wins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label tasapelit;
        private System.Windows.Forms.Label haviot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button kirjauduUlos;
    }
}