namespace NonExamAssesment___Stock_Management
{
    partial class StockUsageEntryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockUsageEntryPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UsageDateText = new System.Windows.Forms.TextBox();
            this.UsageQuantityText = new System.Windows.Forms.TextBox();
            this.UsageStockItemButton = new System.Windows.Forms.Button();
            this.UsageProductCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Usage Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantity";
            // 
            // UsageDateText
            // 
            this.UsageDateText.Location = new System.Drawing.Point(100, 150);
            this.UsageDateText.Name = "UsageDateText";
            this.UsageDateText.Size = new System.Drawing.Size(100, 22);
            this.UsageDateText.TabIndex = 5;
            // 
            // UsageQuantityText
            // 
            this.UsageQuantityText.Location = new System.Drawing.Point(130, 200);
            this.UsageQuantityText.Name = "UsageQuantityText";
            this.UsageQuantityText.Size = new System.Drawing.Size(100, 22);
            this.UsageQuantityText.TabIndex = 6;
            // 
            // UsageStockItemButton
            // 
            this.UsageStockItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UsageStockItemButton.Location = new System.Drawing.Point(30, 250);
            this.UsageStockItemButton.Name = "UsageStockItemButton";
            this.UsageStockItemButton.Size = new System.Drawing.Size(100, 30);
            this.UsageStockItemButton.TabIndex = 7;
            this.UsageStockItemButton.Text = "Submit";
            this.UsageStockItemButton.UseVisualStyleBackColor = true;
            this.UsageStockItemButton.Click += new System.EventHandler(this.UsageStockItemButton_Click);
            // 
            // UsageProductCombo
            // 
            this.UsageProductCombo.FormattingEnabled = true;
            this.UsageProductCombo.Location = new System.Drawing.Point(140, 100);
            this.UsageProductCombo.Name = "UsageProductCombo";
            this.UsageProductCombo.Size = new System.Drawing.Size(150, 24);
            this.UsageProductCombo.TabIndex = 8;
            // 
            // StockUsageEntryPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(382, 503);
            this.Controls.Add(this.UsageProductCombo);
            this.Controls.Add(this.UsageStockItemButton);
            this.Controls.Add(this.UsageQuantityText);
            this.Controls.Add(this.UsageDateText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StockUsageEntryPage";
            this.Text = "Stock Usage Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UsageDateText;
        private System.Windows.Forms.TextBox UsageQuantityText;
        private System.Windows.Forms.Button UsageStockItemButton;
        private System.Windows.Forms.ComboBox UsageProductCombo;
    }
}