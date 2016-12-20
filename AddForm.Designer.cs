namespace Embassy
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.addButton = new System.Windows.Forms.Button();
            this.typeLabel = new System.Windows.Forms.Label();
            this.expirationLabel = new System.Windows.Forms.Label();
            this.providerLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.providerBox = new System.Windows.Forms.ComboBox();
            this.receiverLabel = new System.Windows.Forms.Label();
            this.receiverBox = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.addButton.Location = new System.Drawing.Point(169, 210);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(63, 25);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(42, 18);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.Text = "Type:";
            // 
            // expirationLabel
            // 
            this.expirationLabel.AutoSize = true;
            this.expirationLabel.BackColor = System.Drawing.Color.Transparent;
            this.expirationLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.expirationLabel.Location = new System.Drawing.Point(259, 25);
            this.expirationLabel.Name = "expirationLabel";
            this.expirationLabel.Size = new System.Drawing.Size(77, 18);
            this.expirationLabel.TabIndex = 5;
            this.expirationLabel.Text = "Expires on:";
            // 
            // providerLabel
            // 
            this.providerLabel.AutoSize = true;
            this.providerLabel.BackColor = System.Drawing.Color.Transparent;
            this.providerLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.providerLabel.Location = new System.Drawing.Point(63, 86);
            this.providerLabel.Name = "providerLabel";
            this.providerLabel.Size = new System.Drawing.Size(87, 18);
            this.providerLabel.TabIndex = 6;
            this.providerLabel.Text = "Provided by:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.BackColor = System.Drawing.Color.White;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Transit",
            "Visitor",
            "Long-stay",
            "Immigrant",
            "Official"});
            this.typeComboBox.Location = new System.Drawing.Point(66, 46);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 7;
            // 
            // monthCalendar
            // 
            this.monthCalendar.BackColor = System.Drawing.Color.White;
            this.monthCalendar.Location = new System.Drawing.Point(262, 46);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.MinDate = new System.DateTime(2016, 12, 15, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowToday = false;
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 8;
            // 
            // providerBox
            // 
            this.providerBox.BackColor = System.Drawing.Color.White;
            this.providerBox.FormattingEnabled = true;
            this.providerBox.Location = new System.Drawing.Point(66, 107);
            this.providerBox.Name = "providerBox";
            this.providerBox.Size = new System.Drawing.Size(121, 21);
            this.providerBox.TabIndex = 9;
            // 
            // receiverLabel
            // 
            this.receiverLabel.AutoSize = true;
            this.receiverLabel.BackColor = System.Drawing.Color.Transparent;
            this.receiverLabel.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.receiverLabel.Location = new System.Drawing.Point(63, 141);
            this.receiverLabel.Name = "receiverLabel";
            this.receiverLabel.Size = new System.Drawing.Size(87, 18);
            this.receiverLabel.TabIndex = 10;
            this.receiverLabel.Text = "Received by:";
            // 
            // receiverBox
            // 
            this.receiverBox.BackColor = System.Drawing.Color.White;
            this.receiverBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.receiverBox.Location = new System.Drawing.Point(66, 162);
            this.receiverBox.Name = "receiverBox";
            this.receiverBox.Size = new System.Drawing.Size(121, 20);
            this.receiverBox.TabIndex = 11;
            this.receiverBox.Validating += new System.ComponentModel.CancelEventHandler(this.receiverBox_Validating);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.deleteButton.Location = new System.Drawing.Point(169, 239);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Embassy.Properties.Resources.travel_visa_passport;
            this.ClientSize = new System.Drawing.Size(458, 272);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.receiverBox);
            this.Controls.Add(this.receiverLabel);
            this.Controls.Add(this.providerBox);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.providerLabel);
            this.Controls.Add(this.expirationLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visa information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label expirationLabel;
        private System.Windows.Forms.Label providerLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ComboBox providerBox;
        private System.Windows.Forms.Label receiverLabel;
        private System.Windows.Forms.TextBox receiverBox;
        private System.Windows.Forms.Button deleteButton;
    }
}