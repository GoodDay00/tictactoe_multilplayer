namespace MoninPeli_Projekti
{
    partial class Uusi_käyttäjä
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.password_conf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna käyttäjä tietosi";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(146, 78);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(129, 22);
            this.name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Käyttäjänimi:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(146, 106);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(129, 22);
            this.email.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sähköpostisi:";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(146, 134);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(129, 22);
            this.password.TabIndex = 3;
            // 
            // password_conf
            // 
            this.password_conf.Location = new System.Drawing.Point(146, 162);
            this.password_conf.Name = "password_conf";
            this.password_conf.PasswordChar = '*';
            this.password_conf.Size = new System.Drawing.Size(129, 22);
            this.password_conf.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Salasana:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Vahvista salasana:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 75);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tallenna käyttäjä";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 75);
            this.button2.TabIndex = 6;
            this.button2.Text = "Takaisin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Uusi_käyttäjä
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 296);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password_conf);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Uusi_käyttäjä";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uusi_käyttäjä";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox password_conf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}