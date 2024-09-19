namespace NonExamAssesment___Stock_Management
{
    partial class SupplierEntryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierEntryPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SupplierNameText = new System.Windows.Forms.TextBox();
            this.EmailAddressText = new System.Windows.Forms.TextBox();
            this.TelephoneNumberText = new System.Windows.Forms.TextBox();
            this.submitSupplierEntryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Supplier Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telephone Number";
            // 
            // SupplierNameText
            // 
            this.SupplierNameText.Location = new System.Drawing.Point(175, 100);
            this.SupplierNameText.Name = "SupplierNameText";
            this.SupplierNameText.Size = new System.Drawing.Size(150, 22);
            this.SupplierNameText.TabIndex = 6;
            // 
            // EmailAddressText
            // 
            this.EmailAddressText.Location = new System.Drawing.Point(175, 150);
            this.EmailAddressText.Name = "EmailAddressText";
            this.EmailAddressText.Size = new System.Drawing.Size(150, 22);
            this.EmailAddressText.TabIndex = 7;
            // 
            // TelephoneNumberText
            // 
            this.TelephoneNumberText.Location = new System.Drawing.Point(200, 200);
            this.TelephoneNumberText.Name = "TelephoneNumberText";
            this.TelephoneNumberText.Size = new System.Drawing.Size(150, 22);
            this.TelephoneNumberText.TabIndex = 8;
            // 
            // submitSupplierEntryButton
            // 
            this.submitSupplierEntryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitSupplierEntryButton.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitSupplierEntryButton.Location = new System.Drawing.Point(30, 250);
            this.submitSupplierEntryButton.Name = "submitSupplierEntryButton";
            this.submitSupplierEntryButton.Size = new System.Drawing.Size(100, 30);
            this.submitSupplierEntryButton.TabIndex = 11;
            this.submitSupplierEntryButton.Text = "Submit";
            this.submitSupplierEntryButton.UseVisualStyleBackColor = true;
            this.submitSupplierEntryButton.Click += new System.EventHandler(this.submitSupplierEntryButton_Click);
            // 
            // SupplierEntryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 503);
            this.Controls.Add(this.submitSupplierEntryButton);
            this.Controls.Add(this.TelephoneNumberText);
            this.Controls.Add(this.EmailAddressText);
            this.Controls.Add(this.SupplierNameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SupplierEntryPage";
            this.Text = "Supplier Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SupplierNameText;
        private System.Windows.Forms.TextBox EmailAddressText;
        private System.Windows.Forms.TextBox TelephoneNumberText;
        private System.Windows.Forms.Button submitSupplierEntryButton;
    }
}