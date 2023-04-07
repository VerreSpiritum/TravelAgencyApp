namespace TravelAgency
{
    partial class EditTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTransfer));
            this.label6 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toWhereCB = new TravelAgency.Design.CustomComboBox();
            this.fromWhereCB = new TravelAgency.Design.CustomComboBox();
            this.availableTransportsTB = new TravelAgency.Design.CustomComboBox();
            this.CostTB = new TravelAgency.Design.CustomMaskedTextBoxDate();
            this.searchTransportB = new TravelAgency.Design.RoundedButton();
            this.TransferNumTB = new TravelAgency.Design.CustomTextBox();
            this.createTransportB = new TravelAgency.Design.RoundedButton();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Medium", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(48, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(358, 49);
            this.label6.TabIndex = 49;
            this.label6.Text = "Номер трансфера";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(644, 895);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 38);
            this.errorLabel.TabIndex = 27;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(630, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 43);
            this.label5.TabIndex = 61;
            this.label5.Text = "Місце прибуття";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(630, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 43);
            this.label4.TabIndex = 60;
            this.label4.Text = "Місце відправки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(49, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 43);
            this.label2.TabIndex = 55;
            this.label2.Text = "Ціна";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 43);
            this.label1.TabIndex = 54;
            this.label1.Text = "Транспорт";
            // 
            // toWhereCB
            // 
            this.toWhereCB.BackColor = System.Drawing.Color.White;
            this.toWhereCB.BorderColor = System.Drawing.Color.White;
            this.toWhereCB.BorderSize = 0;
            this.toWhereCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toWhereCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.toWhereCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.toWhereCB.ForeColor = System.Drawing.Color.Black;
            this.toWhereCB.IconColor = System.Drawing.Color.Black;
            this.toWhereCB.ListBackColor = System.Drawing.Color.White;
            this.toWhereCB.ListTextColor = System.Drawing.Color.Black;
            this.toWhereCB.Location = new System.Drawing.Point(638, 524);
            this.toWhereCB.MinimumSize = new System.Drawing.Size(200, 30);
            this.toWhereCB.Name = "toWhereCB";
            this.toWhereCB.Size = new System.Drawing.Size(350, 58);
            this.toWhereCB.TabIndex = 63;
            this.toWhereCB.Texts = "";
            // 
            // fromWhereCB
            // 
            this.fromWhereCB.BackColor = System.Drawing.Color.White;
            this.fromWhereCB.BorderColor = System.Drawing.Color.White;
            this.fromWhereCB.BorderSize = 0;
            this.fromWhereCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromWhereCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.fromWhereCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fromWhereCB.ForeColor = System.Drawing.Color.Black;
            this.fromWhereCB.IconColor = System.Drawing.Color.Black;
            this.fromWhereCB.ListBackColor = System.Drawing.Color.White;
            this.fromWhereCB.ListTextColor = System.Drawing.Color.Black;
            this.fromWhereCB.Location = new System.Drawing.Point(638, 332);
            this.fromWhereCB.MinimumSize = new System.Drawing.Size(200, 30);
            this.fromWhereCB.Name = "fromWhereCB";
            this.fromWhereCB.Size = new System.Drawing.Size(350, 58);
            this.fromWhereCB.TabIndex = 62;
            this.fromWhereCB.Texts = "";
            // 
            // availableTransportsTB
            // 
            this.availableTransportsTB.BackColor = System.Drawing.Color.White;
            this.availableTransportsTB.BorderColor = System.Drawing.Color.White;
            this.availableTransportsTB.BorderSize = 0;
            this.availableTransportsTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.availableTransportsTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.availableTransportsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.availableTransportsTB.ForeColor = System.Drawing.Color.Black;
            this.availableTransportsTB.IconColor = System.Drawing.Color.Black;
            this.availableTransportsTB.ListBackColor = System.Drawing.Color.White;
            this.availableTransportsTB.ListTextColor = System.Drawing.Color.Black;
            this.availableTransportsTB.Location = new System.Drawing.Point(57, 332);
            this.availableTransportsTB.MinimumSize = new System.Drawing.Size(200, 30);
            this.availableTransportsTB.Name = "availableTransportsTB";
            this.availableTransportsTB.Size = new System.Drawing.Size(344, 58);
            this.availableTransportsTB.TabIndex = 59;
            this.availableTransportsTB.Texts = "";
            // 
            // CostTB
            // 
            this.CostTB.BackColor = System.Drawing.Color.White;
            this.CostTB.BorderColor = System.Drawing.Color.Black;
            this.CostTB.BorderRadius = 1;
            this.CostTB.BorderSize = 1;
            this.CostTB.IsPasswordChar = false;
            this.CostTB.IsPlaceHolder = false;
            this.CostTB.Location = new System.Drawing.Point(57, 524);
            this.CostTB.Mask = "0000.00";
            this.CostTB.Multiline = false;
            this.CostTB.Name = "CostTB";
            this.CostTB.PasswordChar = false;
            this.CostTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.CostTB.PlaceHolderText = "";
            this.CostTB.Size = new System.Drawing.Size(198, 58);
            this.CostTB.TabIndex = 57;
            this.CostTB.Texts = "    ,";
            this.CostTB.UnderlineStyle = false;
            // 
            // searchTransportB
            // 
            this.searchTransportB.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.searchTransportB.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.searchTransportB.BorderColor = System.Drawing.Color.Transparent;
            this.searchTransportB.BorderRadius = 12;
            this.searchTransportB.BorderSize = 1;
            this.searchTransportB.FlatAppearance.BorderSize = 0;
            this.searchTransportB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchTransportB.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTransportB.ForeColor = System.Drawing.Color.White;
            this.searchTransportB.Location = new System.Drawing.Point(464, 104);
            this.searchTransportB.Name = "searchTransportB";
            this.searchTransportB.Size = new System.Drawing.Size(132, 72);
            this.searchTransportB.TabIndex = 51;
            this.searchTransportB.Text = "Пошук";
            this.searchTransportB.TextColor = System.Drawing.Color.White;
            this.searchTransportB.UseVisualStyleBackColor = false;
            this.searchTransportB.Click += new System.EventHandler(this.searchTransportB_Click);
            // 
            // TransferNumTB
            // 
            this.TransferNumTB.BackColor = System.Drawing.Color.White;
            this.TransferNumTB.BorderColor = System.Drawing.Color.Black;
            this.TransferNumTB.BorderRadius = 0;
            this.TransferNumTB.BorderSize = 1;
            this.TransferNumTB.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TransferNumTB.IsPasswordChar = false;
            this.TransferNumTB.IsPlaceHolder = false;
            this.TransferNumTB.Location = new System.Drawing.Point(57, 104);
            this.TransferNumTB.Multiline = false;
            this.TransferNumTB.Name = "TransferNumTB";
            this.TransferNumTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TransferNumTB.PasswordChar = false;
            this.TransferNumTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.TransferNumTB.PlaceHolderText = "";
            this.TransferNumTB.Size = new System.Drawing.Size(344, 58);
            this.TransferNumTB.TabIndex = 50;
            this.TransferNumTB.Texts = "";
            this.TransferNumTB.UnderlineStyle = false;
            this.TransferNumTB._TextChanged += new System.EventHandler(this.TransportNumTB__TextChanged);
            // 
            // createTransportB
            // 
            this.createTransportB.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.createTransportB.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.createTransportB.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.createTransportB.BorderRadius = 12;
            this.createTransportB.BorderSize = 0;
            this.createTransportB.FlatAppearance.BorderSize = 0;
            this.createTransportB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTransportB.Font = new System.Drawing.Font("Franklin Gothic Book", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createTransportB.ForeColor = System.Drawing.Color.White;
            this.createTransportB.Location = new System.Drawing.Point(1293, 763);
            this.createTransportB.Name = "createTransportB";
            this.createTransportB.Size = new System.Drawing.Size(269, 106);
            this.createTransportB.TabIndex = 48;
            this.createTransportB.Text = "Змінити трансфер";
            this.createTransportB.TextColor = System.Drawing.Color.White;
            this.createTransportB.UseVisualStyleBackColor = false;
            this.createTransportB.Click += new System.EventHandler(this.createTransportB_Click);
            // 
            // EditTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1646, 992);
            this.Controls.Add(this.toWhereCB);
            this.Controls.Add(this.fromWhereCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.availableTransportsTB);
            this.Controls.Add(this.CostTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTransportB);
            this.Controls.Add(this.TransferNumTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.createTransportB);
            this.Controls.Add(this.errorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditTransfer";
            this.Text = "CreateNewStaff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private Design.RoundedButton createTransportB;
        private System.Windows.Forms.Label errorLabel;
        private Design.CustomTextBox TransferNumTB;
        private Design.RoundedButton searchTransportB;
        private Design.CustomComboBox toWhereCB;
        private Design.CustomComboBox fromWhereCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Design.CustomComboBox availableTransportsTB;
        private Design.CustomMaskedTextBoxDate CostTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}