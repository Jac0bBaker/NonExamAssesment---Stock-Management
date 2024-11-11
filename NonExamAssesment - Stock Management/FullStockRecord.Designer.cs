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
            this.SuspendLayout();
            // 
            // StockRecordSubmitButton
            // 
            this.StockRecordSubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StockRecordSubmitButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockRecordSubmitButton.Location = new System.Drawing.Point(70, 25);
            this.StockRecordSubmitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StockRecordSubmitButton.Name = "StockRecordSubmitButton";
            this.StockRecordSubmitButton.Size = new System.Drawing.Size(133, 25);
            this.StockRecordSubmitButton.TabIndex = 13;
            this.StockRecordSubmitButton.Text = "Submit";
            this.StockRecordSubmitButton.UseVisualStyleBackColor = true;
            this.StockRecordSubmitButton.Click += new System.EventHandler(this.StockRecordSubmitButton_Click);
            // 
            // FullStockRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.StockRecordSubmitButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FullStockRecord";
            this.Text = "FullStockRecord";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StockRecordSubmitButton;
    }
}