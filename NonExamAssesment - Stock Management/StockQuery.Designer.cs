namespace NonExamAssesment___Stock_Management
{
    partial class StockQueryPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.QueryProductCombo = new System.Windows.Forms.ComboBox();
            this.QuerySubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Item";
            // 
            // QueryProductCombo
            // 
            this.QueryProductCombo.FormattingEnabled = true;
            this.QueryProductCombo.Location = new System.Drawing.Point(167, 25);
            this.QueryProductCombo.Margin = new System.Windows.Forms.Padding(4);
            this.QueryProductCombo.Name = "QueryProductCombo";
            this.QueryProductCombo.Size = new System.Drawing.Size(132, 24);
            this.QueryProductCombo.TabIndex = 2;
            // 
            // QuerySubmitButton
            // 
            this.QuerySubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuerySubmitButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuerySubmitButton.Location = new System.Drawing.Point(330, 25);
            this.QuerySubmitButton.Margin = new System.Windows.Forms.Padding(4);
            this.QuerySubmitButton.Name = "QuerySubmitButton";
            this.QuerySubmitButton.Size = new System.Drawing.Size(133, 25);
            this.QuerySubmitButton.TabIndex = 6;
            this.QuerySubmitButton.Text = "Submit";
            this.QuerySubmitButton.UseVisualStyleBackColor = true;
            this.QuerySubmitButton.Click += new System.EventHandler(this.QuerySubmitButton_Click);
            // 
            // StockQueryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.QuerySubmitButton);
            this.Controls.Add(this.QueryProductCombo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockQueryPage";
            this.Text = "StockQuery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox QueryProductCombo;
        private System.Windows.Forms.Button QuerySubmitButton;
    }
}