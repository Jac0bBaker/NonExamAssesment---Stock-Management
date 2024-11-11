namespace NonExamAssesment___Stock_Management
{
    partial class SupplierReport
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
            this.fullSupplierReportSubmitButton = new System.Windows.Forms.Button();
            this.SupplierReportSupplierCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.individualSupplierReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fullSupplierReportSubmitButton
            // 
            this.fullSupplierReportSubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fullSupplierReportSubmitButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullSupplierReportSubmitButton.Location = new System.Drawing.Point(225, 25);
            this.fullSupplierReportSubmitButton.Margin = new System.Windows.Forms.Padding(4);
            this.fullSupplierReportSubmitButton.Name = "fullSupplierReportSubmitButton";
            this.fullSupplierReportSubmitButton.Size = new System.Drawing.Size(133, 25);
            this.fullSupplierReportSubmitButton.TabIndex = 13;
            this.fullSupplierReportSubmitButton.Text = "Submit";
            this.fullSupplierReportSubmitButton.UseVisualStyleBackColor = true;
            this.fullSupplierReportSubmitButton.Click += new System.EventHandler(this.SupplierReportSubmitButton_Click);
            // 
            // SupplierReportSupplierCombo
            // 
            this.SupplierReportSupplierCombo.FormattingEnabled = true;
            this.SupplierReportSupplierCombo.Location = new System.Drawing.Point(710, 25);
            this.SupplierReportSupplierCombo.Margin = new System.Windows.Forms.Padding(4);
            this.SupplierReportSupplierCombo.Name = "SupplierReportSupplierCombo";
            this.SupplierReportSupplierCombo.Size = new System.Drawing.Size(132, 24);
            this.SupplierReportSupplierCombo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(625, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "View Full Report:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "View Individual Supplier:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // individualSupplierReportButton
            // 
            this.individualSupplierReportButton.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.individualSupplierReportButton.Location = new System.Drawing.Point(875, 25);
            this.individualSupplierReportButton.Name = "individualSupplierReportButton";
            this.individualSupplierReportButton.Size = new System.Drawing.Size(130, 25);
            this.individualSupplierReportButton.TabIndex = 16;
            this.individualSupplierReportButton.Text = "Submit";
            this.individualSupplierReportButton.UseVisualStyleBackColor = true;
            this.individualSupplierReportButton.Click += new System.EventHandler(this.individualSupplierReportButton_Click);
            // 
            // SupplierReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.individualSupplierReportButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullSupplierReportSubmitButton);
            this.Controls.Add(this.SupplierReportSupplierCombo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SupplierReport";
            this.Text = "SupplierReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fullSupplierReportSubmitButton;
        private System.Windows.Forms.ComboBox SupplierReportSupplierCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button individualSupplierReportButton;
    }
}