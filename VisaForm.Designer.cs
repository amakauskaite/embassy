namespace Embassy
{
    partial class VisaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisaForm));
            this.passportNumberLabel = new System.Windows.Forms.Label();
            this.passportNoBox = new System.Windows.Forms.TextBox();
            this.numberButton = new System.Windows.Forms.Button();
            this.passportBox = new System.Windows.Forms.PictureBox();
            this.uploadButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.passportBox)).BeginInit();
            this.SuspendLayout();
            // 
            // passportNumberLabel
            // 
            this.passportNumberLabel.AutoSize = true;
            this.passportNumberLabel.Location = new System.Drawing.Point(35, 103);
            this.passportNumberLabel.Name = "passportNumberLabel";
            this.passportNumberLabel.Size = new System.Drawing.Size(65, 13);
            this.passportNumberLabel.TabIndex = 0;
            this.passportNumberLabel.Text = "Passport No";
            // 
            // passportNoBox
            // 
            this.passportNoBox.Location = new System.Drawing.Point(38, 119);
            this.passportNoBox.Name = "passportNoBox";
            this.passportNoBox.Size = new System.Drawing.Size(100, 20);
            this.passportNoBox.TabIndex = 1;
            // 
            // numberButton
            // 
            this.numberButton.Location = new System.Drawing.Point(49, 145);
            this.numberButton.Name = "numberButton";
            this.numberButton.Size = new System.Drawing.Size(75, 23);
            this.numberButton.TabIndex = 9;
            this.numberButton.Text = "Get Number";
            this.numberButton.UseVisualStyleBackColor = true;
            this.numberButton.Click += new System.EventHandler(this.comfirmationButton_Click);
            // 
            // passportBox
            // 
            this.passportBox.Location = new System.Drawing.Point(183, 25);
            this.passportBox.Name = "passportBox";
            this.passportBox.Size = new System.Drawing.Size(370, 242);
            this.passportBox.TabIndex = 10;
            this.passportBox.TabStop = false;
            // 
            // uploadButton
            // 
            this.uploadButton.Location = new System.Drawing.Point(307, 286);
            this.uploadButton.Name = "uploadButton";
            this.uploadButton.Size = new System.Drawing.Size(119, 23);
            this.uploadButton.TabIndex = 11;
            this.uploadButton.Text = "Upload Passport";
            this.uploadButton.UseVisualStyleBackColor = true;
            this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // VisaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 321);
            this.Controls.Add(this.uploadButton);
            this.Controls.Add(this.passportBox);
            this.Controls.Add(this.numberButton);
            this.Controls.Add(this.passportNoBox);
            this.Controls.Add(this.passportNumberLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisaForm";
            this.Text = "Register new travel visa";
            this.TransparencyKey = System.Drawing.Color.Pink;
            ((System.ComponentModel.ISupportInitialize)(this.passportBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passportNumberLabel;
        private System.Windows.Forms.TextBox passportNoBox;
        private System.Windows.Forms.Button numberButton;
        private System.Windows.Forms.PictureBox passportBox;
        private System.Windows.Forms.Button uploadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

