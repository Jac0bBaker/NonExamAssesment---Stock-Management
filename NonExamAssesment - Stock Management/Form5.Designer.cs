namespace NonExamAssesment___Stock_Management
{
    partial class SalesDataEntryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesDataEntryPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.salesProductText = new System.Windows.Forms.TextBox();
            this.salesDateText = new System.Windows.Forms.TextBox();
            this.salesQuantityText = new System.Windows.Forms.TextBox();
            this.salesSubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Data Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date";
            // 
            // salesProductText
            // 
            this.salesProductText.Location = new System.Drawing.Point(150, 100);
            this.salesProductText.Name = "salesProductText";
            this.salesProductText.Size = new System.Drawing.Size(150, 22);
            this.salesProductText.TabIndex = 4;
            // 
            // salesDateText
            // 
            this.salesDateText.Location = new System.Drawing.Point(100, 150);
            this.salesDateText.Name = "salesDateText";
            this.salesDateText.Size = new System.Drawing.Size(100, 22);
            this.salesDateText.TabIndex = 5;
            // 
            // salesQuantityText
            // 
            this.salesQuantityText.Location = new System.Drawing.Point(130, 200);
            this.salesQuantityText.Name = "salesQuantityText";
            this.salesQuantityText.Size = new System.Drawing.Size(100, 22);
            this.salesQuantityText.TabIndex = 6;
            // 
            // salesSubmitButton
            // 
            this.salesSubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salesSubmitButton.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesSubmitButton.Location = new System.Drawing.Point(30, 250);
            this.salesSubmitButton.Name = "salesSubmitButton";
            this.salesSubmitButton.Size = new System.Drawing.Size(100, 30);
            this.salesSubmitButton.TabIndex = 7;
            this.salesSubmitButton.Text = "Submit";
            this.salesSubmitButton.UseVisualStyleBackColor = true;
            this.salesSubmitButton.Click += new System.EventHandler(this.salesSubmitButton_Click);
            // 
            // SalesDataEntryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 503);
            this.Controls.Add(this.salesSubmitButton);
            this.Controls.Add(this.salesQuantityText);
            this.Controls.Add(this.salesDateText);
            this.Controls.Add(this.salesProductText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SalesDataEntryPage";
            this.Text = "Sales Data Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox salesProductText;
        private System.Windows.Forms.TextBox salesDateText;
        private System.Windows.Forms.TextBox salesQuantityText;
        private System.Windows.Forms.Button salesSubmitButton;
    }
}