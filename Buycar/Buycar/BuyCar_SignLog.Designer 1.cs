namespace Buycar
{
    partial class BuyCar_SignLog
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.btnSign = new System.Windows.Forms.Button();
            this.mskSPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtSNick = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.mskPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtNick = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblNick = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAdminEnter = new System.Windows.Forms.Button();
            this.mskAdminPassword = new System.Windows.Forms.MaskedTextBox();
            this.mskMersisNo = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.cmbCity);
            this.groupBox2.Controls.Add(this.mskPhone);
            this.groupBox2.Controls.Add(this.btnSign);
            this.groupBox2.Controls.Add(this.mskSPassword);
            this.groupBox2.Controls.Add(this.txtSNick);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.mskTC);
            this.groupBox2.Controls.Add(this.txtSurname);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(715, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(763, 855);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sign Up";
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(301, 484);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(326, 53);
            this.cmbCity.TabIndex = 17;
            this.cmbCity.TextUpdate += new System.EventHandler(this.cmbCity_TextUpdate);
            // 
            // mskPhone
            // 
            this.mskPhone.Location = new System.Drawing.Point(301, 410);
            this.mskPhone.Mask = "(999) 000-0000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(326, 50);
            this.mskPhone.TabIndex = 15;
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.Black;
            this.btnSign.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSign.Location = new System.Drawing.Point(384, 732);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(243, 72);
            this.btnSign.TabIndex = 20;
            this.btnSign.Text = "Sign Up";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // mskSPassword
            // 
            this.mskSPassword.Location = new System.Drawing.Point(301, 626);
            this.mskSPassword.Mask = "00000000";
            this.mskSPassword.Name = "mskSPassword";
            this.mskSPassword.PasswordChar = '*';
            this.mskSPassword.Size = new System.Drawing.Size(326, 50);
            this.mskSPassword.TabIndex = 19;
            // 
            // txtSNick
            // 
            this.txtSNick.Location = new System.Drawing.Point(301, 555);
            this.txtSNick.Name = "txtSNick";
            this.txtSNick.Size = new System.Drawing.Size(326, 50);
            this.txtSNick.TabIndex = 18;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(301, 335);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(326, 50);
            this.txtEmail.TabIndex = 14;
            // 
            // mskTC
            // 
            this.mskTC.Location = new System.Drawing.Point(301, 268);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(326, 50);
            this.mskTC.TabIndex = 13;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(301, 205);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(326, 50);
            this.txtSurname.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(301, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(326, 50);
            this.txtName.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 633);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 45);
            this.label9.TabIndex = 10;
            this.label9.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(156, 562);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 45);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nick:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(164, 492);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 45);
            this.label7.TabIndex = 8;
            this.label7.Text = "City:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(136, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 45);
            this.label5.TabIndex = 6;
            this.label5.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 45);
            this.label4.TabIndex = 5;
            this.label4.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 45);
            this.label3.TabIndex = 4;
            this.label3.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Controls.Add(this.btnEnter);
            this.groupBox1.Controls.Add(this.mskPassword);
            this.groupBox1.Controls.Add(this.txtNick);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblNick);
            this.groupBox1.Location = new System.Drawing.Point(33, 470);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 450);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log In";
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.Black;
            this.btnEnter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnter.Location = new System.Drawing.Point(320, 321);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(243, 72);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // mskPassword
            // 
            this.mskPassword.Location = new System.Drawing.Point(233, 215);
            this.mskPassword.Mask = "00000000";
            this.mskPassword.Name = "mskPassword";
            this.mskPassword.PasswordChar = '*';
            this.mskPassword.Size = new System.Drawing.Size(330, 50);
            this.mskPassword.TabIndex = 3;
            // 
            // txtNick
            // 
            this.txtNick.Location = new System.Drawing.Point(233, 109);
            this.txtNick.Name = "txtNick";
            this.txtNick.Size = new System.Drawing.Size(330, 50);
            this.txtNick.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(38, 222);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(172, 45);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password:";
            // 
            // lblNick
            // 
            this.lblNick.AutoSize = true;
            this.lblNick.Location = new System.Drawing.Point(94, 116);
            this.lblNick.Name = "lblNick";
            this.lblNick.Size = new System.Drawing.Size(97, 45);
            this.lblNick.TabIndex = 0;
            this.lblNick.Text = "Nick:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox3.Controls.Add(this.btnAdminEnter);
            this.groupBox3.Controls.Add(this.mskAdminPassword);
            this.groupBox3.Controls.Add(this.mskMersisNo);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(33, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(627, 387);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Admin Log In";
            // 
            // btnAdminEnter
            // 
            this.btnAdminEnter.Location = new System.Drawing.Point(297, 285);
            this.btnAdminEnter.Name = "btnAdminEnter";
            this.btnAdminEnter.Size = new System.Drawing.Size(243, 72);
            this.btnAdminEnter.TabIndex = 4;
            this.btnAdminEnter.Text = "Enter";
            this.btnAdminEnter.UseVisualStyleBackColor = true;
            this.btnAdminEnter.Click += new System.EventHandler(this.btnAdminEnter_Click);
            // 
            // mskAdminPassword
            // 
            this.mskAdminPassword.Location = new System.Drawing.Point(233, 205);
            this.mskAdminPassword.Mask = "00000000";
            this.mskAdminPassword.Name = "mskAdminPassword";
            this.mskAdminPassword.PasswordChar = '*';
            this.mskAdminPassword.Size = new System.Drawing.Size(307, 50);
            this.mskAdminPassword.TabIndex = 3;
            // 
            // mskMersisNo
            // 
            this.mskMersisNo.Location = new System.Drawing.Point(233, 106);
            this.mskMersisNo.Mask = "00000000";
            this.mskMersisNo.Name = "mskMersisNo";
            this.mskMersisNo.Size = new System.Drawing.Size(307, 50);
            this.mskMersisNo.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 45);
            this.label10.TabIndex = 1;
            this.label10.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 45);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mersis No:";
            // 
            // BuyCar_SignLog
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1535, 966);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "BuyCar_SignLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignLog";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.MaskedTextBox mskSPassword;
        private System.Windows.Forms.TextBox txtSNick;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.MaskedTextBox mskPassword;
        private System.Windows.Forms.TextBox txtNick;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblNick;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdminEnter;
        private System.Windows.Forms.MaskedTextBox mskAdminPassword;
        private System.Windows.Forms.MaskedTextBox mskMersisNo;
    }
}