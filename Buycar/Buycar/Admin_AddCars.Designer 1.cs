namespace Buycar
{
    partial class Admin_AddCars
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
            this.mskId = new System.Windows.Forms.MaskedTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFuelType = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.mskYear = new System.Windows.Forms.MaskedTextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mskId
            // 
            this.mskId.Enabled = false;
            this.mskId.Location = new System.Drawing.Point(265, 96);
            this.mskId.Mask = "0000";
            this.mskId.Name = "mskId";
            this.mskId.Size = new System.Drawing.Size(342, 50);
            this.mskId.TabIndex = 31;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(417, 663);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 70);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFuelType
            // 
            this.txtFuelType.Location = new System.Drawing.Point(265, 588);
            this.txtFuelType.Name = "txtFuelType";
            this.txtFuelType.Size = new System.Drawing.Size(342, 50);
            this.txtFuelType.TabIndex = 29;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(265, 505);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(342, 50);
            this.txtColor.TabIndex = 28;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(265, 423);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(342, 50);
            this.txtPrice.TabIndex = 27;
            // 
            // mskYear
            // 
            this.mskYear.Location = new System.Drawing.Point(265, 341);
            this.mskYear.Mask = "0000";
            this.mskYear.Name = "mskYear";
            this.mskYear.Size = new System.Drawing.Size(342, 50);
            this.mskYear.TabIndex = 26;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(265, 262);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(342, 50);
            this.txtModel.TabIndex = 25;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(265, 181);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(342, 50);
            this.txtBrand.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 593);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 45);
            this.label7.TabIndex = 23;
            this.label7.Text = "Fuel Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 510);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 45);
            this.label6.TabIndex = 22;
            this.label6.Text = "Color:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 428);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 45);
            this.label5.TabIndex = 21;
            this.label5.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(128, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 45);
            this.label4.TabIndex = 20;
            this.label4.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 45);
            this.label3.TabIndex = 19;
            this.label3.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 45);
            this.label2.TabIndex = 18;
            this.label2.Text = "Brand:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Id:";
            // 
            // Admin_AddCars
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 825);
            this.Controls.Add(this.mskId);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFuelType);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.mskYear);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Admin_AddCars";
            this.Text = "Admin_AddCars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFuelType;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.MaskedTextBox mskYear;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}