namespace TravelAgency
{
    partial class CreateNewTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewTransfer));
            this.errorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toWhereCB = new TravelAgency.Design.CustomComboBox();
            this.fromWhereCB = new TravelAgency.Design.CustomComboBox();
            this.availableTransportsTB = new TravelAgency.Design.CustomComboBox();
            this.createTransportB = new TravelAgency.Design.RoundedButton();
            this.CostTB = new TravelAgency.Design.CustomMaskedTextBoxDate();
            this.label3 = new System.Windows.Forms.Label();
            this.CountOfSeatsTB = new TravelAgency.Design.CustomMaskedTextBoxDate();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Franklin Gothic Book", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(659, 868);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 38);
            this.errorLabel.TabIndex = 27;
            this.errorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 43);
            this.label1.TabIndex = 29;
            this.label1.Text = "Транспорт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(460, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 43);
            this.label2.TabIndex = 30;
            this.label2.Text = "Ціна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(49, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 43);
            this.label4.TabIndex = 50;
            this.label4.Text = "Місце відправки";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(460, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 43);
            this.label5.TabIndex = 51;
            this.label5.Text = "Місце прибуття";
            // 
            // toWhereCB
            // 
            this.toWhereCB.BackColor = System.Drawing.Color.White;
            this.toWhereCB.BorderColor = System.Drawing.Color.White;
            this.toWhereCB.BorderSize = 0;
            this.toWhereCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toWhereCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.toWhereCB.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toWhereCB.ForeColor = System.Drawing.Color.Black;
            this.toWhereCB.IconColor = System.Drawing.Color.Black;
            this.toWhereCB.ListBackColor = System.Drawing.Color.White;
            this.toWhereCB.ListTextColor = System.Drawing.Color.Black;
            this.toWhereCB.Location = new System.Drawing.Point(468, 285);
            this.toWhereCB.MinimumSize = new System.Drawing.Size(200, 30);
            this.toWhereCB.Name = "toWhereCB";
            this.toWhereCB.Size = new System.Drawing.Size(269, 58);
            this.toWhereCB.TabIndex = 53;
            this.toWhereCB.Texts = "";
            this.toWhereCB.OnSelectedIndexChanged += new System.EventHandler(this.toWhereCB_OnSelectedIndexChanged);
            // 
            // fromWhereCB
            // 
            this.fromWhereCB.BackColor = System.Drawing.Color.White;
            this.fromWhereCB.BorderColor = System.Drawing.Color.White;
            this.fromWhereCB.BorderSize = 0;
            this.fromWhereCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fromWhereCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.fromWhereCB.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromWhereCB.ForeColor = System.Drawing.Color.Black;
            this.fromWhereCB.IconColor = System.Drawing.Color.Black;
            this.fromWhereCB.ListBackColor = System.Drawing.Color.White;
            this.fromWhereCB.ListTextColor = System.Drawing.Color.Black;
            this.fromWhereCB.Location = new System.Drawing.Point(57, 285);
            this.fromWhereCB.MinimumSize = new System.Drawing.Size(200, 30);
            this.fromWhereCB.Name = "fromWhereCB";
            this.fromWhereCB.Size = new System.Drawing.Size(281, 58);
            this.fromWhereCB.TabIndex = 52;
            this.fromWhereCB.Texts = "";
            this.fromWhereCB.OnSelectedIndexChanged += new System.EventHandler(this.fromWhereCB_OnSelectedIndexChanged);
            // 
            // availableTransportsTB
            // 
            this.availableTransportsTB.BackColor = System.Drawing.Color.White;
            this.availableTransportsTB.BorderColor = System.Drawing.Color.White;
            this.availableTransportsTB.BorderSize = 0;
            this.availableTransportsTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.availableTransportsTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.availableTransportsTB.Font = new System.Drawing.Font("Franklin Gothic Book", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.availableTransportsTB.ForeColor = System.Drawing.Color.Black;
            this.availableTransportsTB.IconColor = System.Drawing.Color.Black;
            this.availableTransportsTB.ListBackColor = System.Drawing.Color.White;
            this.availableTransportsTB.ListTextColor = System.Drawing.Color.Black;
            this.availableTransportsTB.Location = new System.Drawing.Point(57, 89);
            this.availableTransportsTB.MinimumSize = new System.Drawing.Size(200, 30);
            this.availableTransportsTB.Name = "availableTransportsTB";
            this.availableTransportsTB.Size = new System.Drawing.Size(445, 58);
            this.availableTransportsTB.TabIndex = 49;
            this.availableTransportsTB.Texts = "";
            this.availableTransportsTB.OnSelectedIndexChanged += new System.EventHandler(this.availableTransportsTB_OnSelectedIndexChanged);
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
            this.createTransportB.Location = new System.Drawing.Point(1176, 609);
            this.createTransportB.Name = "createTransportB";
            this.createTransportB.Size = new System.Drawing.Size(269, 106);
            this.createTransportB.TabIndex = 48;
            this.createTransportB.Text = "Створити транспорт";
            this.createTransportB.TextColor = System.Drawing.Color.White;
            this.createTransportB.UseVisualStyleBackColor = false;
            this.createTransportB.Click += new System.EventHandler(this.createTransportB_Click);
            // 
            // CostTB
            // 
            this.CostTB.BackColor = System.Drawing.Color.White;
            this.CostTB.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CostTB.BorderRadius = 0;
            this.CostTB.BorderSize = 1;
            this.CostTB.IsPasswordChar = false;
            this.CostTB.IsPlaceHolder = false;
            this.CostTB.Location = new System.Drawing.Point(468, 483);
            this.CostTB.Mask = "0000.00";
            this.CostTB.Multiline = false;
            this.CostTB.Name = "CostTB";
            this.CostTB.PasswordChar = false;
            this.CostTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.CostTB.PlaceHolderText = "";
            this.CostTB.Size = new System.Drawing.Size(198, 58);
            this.CostTB.TabIndex = 32;
            this.CostTB.Texts = "    ,";
            this.CostTB.UnderlineStyle = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(49, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 87);
            this.label3.TabIndex = 31;
            this.label3.Text = "Кількість доступних місць";
            // 
            // CountOfSeatsTB
            // 
            this.CountOfSeatsTB.BackColor = System.Drawing.Color.White;
            this.CountOfSeatsTB.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CountOfSeatsTB.BorderRadius = 0;
            this.CountOfSeatsTB.BorderSize = 1;
            this.CountOfSeatsTB.Enabled = false;
            this.CountOfSeatsTB.IsPasswordChar = false;
            this.CountOfSeatsTB.IsPlaceHolder = false;
            this.CountOfSeatsTB.Location = new System.Drawing.Point(57, 483);
            this.CountOfSeatsTB.Mask = "00";
            this.CountOfSeatsTB.Multiline = false;
            this.CountOfSeatsTB.Name = "CountOfSeatsTB";
            this.CountOfSeatsTB.PasswordChar = false;
            this.CountOfSeatsTB.PlaceHolderColor = System.Drawing.Color.DarkGray;
            this.CountOfSeatsTB.PlaceHolderText = "";
            this.CountOfSeatsTB.Size = new System.Drawing.Size(241, 58);
            this.CountOfSeatsTB.TabIndex = 33;
            this.CountOfSeatsTB.Texts = "";
            this.CountOfSeatsTB.UnderlineStyle = false;
            // 
            // CreateNewTransfer
            // 
            this.AcceptButton = this.createTransportB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1646, 992);
            this.Controls.Add(this.toWhereCB);
            this.Controls.Add(this.fromWhereCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.availableTransportsTB);
            this.Controls.Add(this.createTransportB);
            this.Controls.Add(this.CountOfSeatsTB);
            this.Controls.Add(this.CostTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateNewTransfer";
            this.Text = "CreateNewStaff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreateNewTransfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Design.CustomMaskedTextBoxDate CostTB;
        private Design.RoundedButton createTransportB;
        private Design.CustomComboBox availableTransportsTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Design.CustomComboBox fromWhereCB;
        private Design.CustomComboBox toWhereCB;
        private System.Windows.Forms.Label label3;
        private Design.CustomMaskedTextBoxDate CountOfSeatsTB;
    }
}