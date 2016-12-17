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
            this.addButton = new System.Windows.Forms.Button();
            this.typeLabel = new System.Windows.Forms.Label();
            this.expirationLabel = new System.Windows.Forms.Label();
            this.providerLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.providerBox = new System.Windows.Forms.ComboBox();
            this.receiverLabel = new System.Windows.Forms.Label();
            this.receiverBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Location = new System.Drawing.Point(168, 219);
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
            this.typeLabel.Location = new System.Drawing.Point(55, 30);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 13);
            this.typeLabel.TabIndex = 4;
            this.typeLabel.Text = "Type:";
            // 
            // expirationLabel
            // 
            this.expirationLabel.AutoSize = true;
            this.expirationLabel.Location = new System.Drawing.Point(259, 31);
            this.expirationLabel.Name = "expirationLabel";
            this.expirationLabel.Size = new System.Drawing.Size(59, 13);
            this.expirationLabel.TabIndex = 5;
            this.expirationLabel.Text = "Expires on:";
            // 
            // providerLabel
            // 
            this.providerLabel.AutoSize = true;
            this.providerLabel.Location = new System.Drawing.Point(55, 91);
            this.providerLabel.Name = "providerLabel";
            this.providerLabel.Size = new System.Drawing.Size(66, 13);
            this.providerLabel.TabIndex = 6;
            this.providerLabel.Text = "Provided by:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Transit",
            "Visitor",
            "Long-stay",
            "Immigrant",
            "Official"});
            this.typeComboBox.Location = new System.Drawing.Point(58, 46);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 7;
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(262, 46);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.MinDate = new System.DateTime(2016, 12, 15, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 8;
            // 
            // providerBox
            // 
            this.providerBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.providerBox.FormattingEnabled = true;
            this.providerBox.Location = new System.Drawing.Point(58, 107);
            this.providerBox.Name = "providerBox";
            this.providerBox.Size = new System.Drawing.Size(121, 21);
            this.providerBox.TabIndex = 9;
            // 
            // receiverLabel
            // 
            this.receiverLabel.AutoSize = true;
            this.receiverLabel.Location = new System.Drawing.Point(55, 146);
            this.receiverLabel.Name = "receiverLabel";
            this.receiverLabel.Size = new System.Drawing.Size(70, 13);
            this.receiverLabel.TabIndex = 10;
            this.receiverLabel.Text = "Received by:";
            // 
            // receiverBox
            // 
            this.receiverBox.Location = new System.Drawing.Point(58, 162);
            this.receiverBox.Name = "receiverBox";
            this.receiverBox.Size = new System.Drawing.Size(121, 20);
            this.receiverBox.TabIndex = 11;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 272);
            this.Controls.Add(this.receiverBox);
            this.Controls.Add(this.receiverLabel);
            this.Controls.Add(this.providerBox);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.providerLabel);
            this.Controls.Add(this.expirationLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.addButton);
            this.Name = "AddForm";
            this.Text = "AddForm";
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
    }
}