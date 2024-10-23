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
            this.SupplierReportSubmitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SupplierReportDateRangeEndText = new System.Windows.Forms.TextBox();
            this.SupplierReportDateRangeStartText = new System.Windows.Forms.TextBox();
            this.SupplierReportSupplierCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SupplierReportSubmitButton
            // 
            this.SupplierReportSubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SupplierReportSubmitButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierReportSubmitButton.Location = new System.Drawing.Point(550, 20);
            this.SupplierReportSubmitButton.Name = "SupplierReportSubmitButton";
            this.SupplierReportSubmitButton.Size = new System.Drawing.Size(100, 20);
            this.SupplierReportSubmitButton.TabIndex = 13;
            this.SupplierReportSubmitButton.Text = "Submit";
            this.SupplierReportSubmitButton.UseVisualStyleBackColor = true;
            this.SupplierReportSubmitButton.Click += new System.EventHandler(this.SupplierReportSubmitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(410, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "-";
            // 
            // SupplierReportDateRangeEndText
            // 
            this.SupplierReportDateRangeEndText.Location = new System.Drawing.Point(425, 20);
            this.SupplierReportDateRangeEndText.Name = "SupplierReportDateRangeEndText";
            this.SupplierReportDateRangeEndText.Size = new System.Drawing.Size(75, 20);
            this.SupplierReportDateRangeEndText.TabIndex = 11;
            // 
            // SupplierReportDateRangeStartText
            // 
            this.SupplierReportDateRangeStartText.Location = new System.Drawing.Point(330, 20);
            this.SupplierReportDateRangeStartText.Name = "SupplierReportDateRangeStartText";
            this.SupplierReportDateRangeStartText.Size = new System.Drawing.Size(75, 20);
            this.SupplierReportDateRangeStartText.TabIndex = 10;
            // 
            // SupplierReportSupplierCombo
            // 
            this.SupplierReportSupplierCombo.FormattingEnabled = true;
            this.SupplierReportSupplierCombo.Location = new System.Drawing.Point(125, 20);
            this.SupplierReportSupplierCombo.Name = "SupplierReportSupplierCombo";
            this.SupplierReportSupplierCombo.Size = new System.Drawing.Size(100, 21);
            this.SupplierReportSupplierCombo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date Range";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Supplier";
            // 
            // SupplierReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SupplierReportSubmitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SupplierReportDateRangeEndText);
            this.Controls.Add(this.SupplierReportDateRangeStartText);
            this.Controls.Add(this.SupplierReportSupplierCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SupplierReport";
            this.Text = "SupplierReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SupplierReportSubmitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SupplierReportDateRangeEndText;
        private System.Windows.Forms.TextBox SupplierReportDateRangeStartText;
        private System.Windows.Forms.ComboBox SupplierReportSupplierCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}