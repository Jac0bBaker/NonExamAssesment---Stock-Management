namespace NonExamAssesment___Stock_Management
{
    partial class FullStockRecord
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
            this.StockRecordSubmitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.StockRecordDateRangeEndText = new System.Windows.Forms.TextBox();
            this.StockRecordDateRangeStartText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StockRecordSubmitButton
            // 
            this.StockRecordSubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StockRecordSubmitButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockRecordSubmitButton.Location = new System.Drawing.Point(325, 20);
            this.StockRecordSubmitButton.Name = "StockRecordSubmitButton";
            this.StockRecordSubmitButton.Size = new System.Drawing.Size(100, 20);
            this.StockRecordSubmitButton.TabIndex = 13;
            this.StockRecordSubmitButton.Text = "Submit";
            this.StockRecordSubmitButton.UseVisualStyleBackColor = true;
            this.StockRecordSubmitButton.Click += new System.EventHandler(this.StockRecordSubmitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "-";
            // 
            // StockRecordDateRangeEndText
            // 
            this.StockRecordDateRangeEndText.Location = new System.Drawing.Point(225, 20);
            this.StockRecordDateRangeEndText.Name = "StockRecordDateRangeEndText";
            this.StockRecordDateRangeEndText.Size = new System.Drawing.Size(75, 20);
            this.StockRecordDateRangeEndText.TabIndex = 11;
            // 
            // StockRecordDateRangeStartText
            // 
            this.StockRecordDateRangeStartText.Location = new System.Drawing.Point(130, 20);
            this.StockRecordDateRangeStartText.Name = "StockRecordDateRangeStartText";
            this.StockRecordDateRangeStartText.Size = new System.Drawing.Size(75, 20);
            this.StockRecordDateRangeStartText.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date Range";
            // 
            // FullStockRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StockRecordSubmitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.StockRecordDateRangeEndText);
            this.Controls.Add(this.StockRecordDateRangeStartText);
            this.Controls.Add(this.label2);
            this.Name = "FullStockRecord";
            this.Text = "FullStockRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StockRecordSubmitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StockRecordDateRangeEndText;
        private System.Windows.Forms.TextBox StockRecordDateRangeStartText;
        private System.Windows.Forms.Label label2;
    }
}