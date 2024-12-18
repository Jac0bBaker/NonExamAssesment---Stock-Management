﻿namespace NonExamAssesment___Stock_Management
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StockQueryButton = new System.Windows.Forms.Button();
            this.StockRecordButton = new System.Windows.Forms.Button();
            this.SupplierReportButton = new System.Windows.Forms.Button();
            this.AddSupplierButton = new System.Windows.Forms.Button();
            this.AddStockItemButton = new System.Windows.Forms.Button();
            this.AddStockUsageButton = new System.Windows.Forms.Button();
            this.AddSalesDataButton = new System.Windows.Forms.Button();
            this.AddDeliveryDataButton = new System.Windows.Forms.Button();
            this.AlertsList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AlertsRefreshButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PredictionNextDaySaleText = new System.Windows.Forms.TextBox();
            this.PredictionSubmitButton = new System.Windows.Forms.Button();
            this.PredictionStockItemCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Management +";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "View Reports";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(340, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Add Records";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(675, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(364, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stock Management Tools";
            // 
            // StockQueryButton
            // 
            this.StockQueryButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.StockQueryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StockQueryButton.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockQueryButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StockQueryButton.Location = new System.Drawing.Point(40, 190);
            this.StockQueryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StockQueryButton.Name = "StockQueryButton";
            this.StockQueryButton.Size = new System.Drawing.Size(200, 75);
            this.StockQueryButton.TabIndex = 4;
            this.StockQueryButton.Text = "View Stock Query";
            this.StockQueryButton.UseVisualStyleBackColor = false;
            this.StockQueryButton.Click += new System.EventHandler(this.StockQueryButton_Click);
            // 
            // StockRecordButton
            // 
            this.StockRecordButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.StockRecordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StockRecordButton.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockRecordButton.Location = new System.Drawing.Point(40, 294);
            this.StockRecordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StockRecordButton.Name = "StockRecordButton";
            this.StockRecordButton.Size = new System.Drawing.Size(200, 75);
            this.StockRecordButton.TabIndex = 5;
            this.StockRecordButton.Text = "View Full Stock Record";
            this.StockRecordButton.UseVisualStyleBackColor = false;
            this.StockRecordButton.Click += new System.EventHandler(this.StockRecordButton_Click);
            // 
            // SupplierReportButton
            // 
            this.SupplierReportButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SupplierReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SupplierReportButton.Location = new System.Drawing.Point(40, 402);
            this.SupplierReportButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SupplierReportButton.Name = "SupplierReportButton";
            this.SupplierReportButton.Size = new System.Drawing.Size(200, 75);
            this.SupplierReportButton.TabIndex = 6;
            this.SupplierReportButton.Text = "View Supplier Report";
            this.SupplierReportButton.UseVisualStyleBackColor = false;
            this.SupplierReportButton.Click += new System.EventHandler(this.SupplierReportButton_Click);
            // 
            // AddSupplierButton
            // 
            this.AddSupplierButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AddSupplierButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddSupplierButton.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSupplierButton.Location = new System.Drawing.Point(328, 190);
            this.AddSupplierButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddSupplierButton.Name = "AddSupplierButton";
            this.AddSupplierButton.Size = new System.Drawing.Size(200, 60);
            this.AddSupplierButton.TabIndex = 7;
            this.AddSupplierButton.Text = "Add Supplier";
            this.AddSupplierButton.UseVisualStyleBackColor = false;
            this.AddSupplierButton.Click += new System.EventHandler(this.AddSupplierButton_Click);
            // 
            // AddStockItemButton
            // 
            this.AddStockItemButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AddStockItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStockItemButton.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStockItemButton.Location = new System.Drawing.Point(328, 270);
            this.AddStockItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddStockItemButton.Name = "AddStockItemButton";
            this.AddStockItemButton.Size = new System.Drawing.Size(200, 60);
            this.AddStockItemButton.TabIndex = 8;
            this.AddStockItemButton.Text = "Add Stock Item";
            this.AddStockItemButton.UseVisualStyleBackColor = false;
            this.AddStockItemButton.Click += new System.EventHandler(this.AddStockItemButton_Click);
            // 
            // AddStockUsageButton
            // 
            this.AddStockUsageButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AddStockUsageButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddStockUsageButton.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStockUsageButton.Location = new System.Drawing.Point(328, 351);
            this.AddStockUsageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddStockUsageButton.Name = "AddStockUsageButton";
            this.AddStockUsageButton.Size = new System.Drawing.Size(200, 60);
            this.AddStockUsageButton.TabIndex = 9;
            this.AddStockUsageButton.Text = "Add Stock Usage";
            this.AddStockUsageButton.UseVisualStyleBackColor = false;
            this.AddStockUsageButton.Click += new System.EventHandler(this.AddStockUsageButton_Click);
            // 
            // AddSalesDataButton
            // 
            this.AddSalesDataButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AddSalesDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddSalesDataButton.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSalesDataButton.Location = new System.Drawing.Point(328, 432);
            this.AddSalesDataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddSalesDataButton.Name = "AddSalesDataButton";
            this.AddSalesDataButton.Size = new System.Drawing.Size(200, 60);
            this.AddSalesDataButton.TabIndex = 10;
            this.AddSalesDataButton.Text = "Add Sales Data";
            this.AddSalesDataButton.UseVisualStyleBackColor = false;
            this.AddSalesDataButton.Click += new System.EventHandler(this.AddSalesDataButton_Click);
            // 
            // AddDeliveryDataButton
            // 
            this.AddDeliveryDataButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AddDeliveryDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddDeliveryDataButton.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDeliveryDataButton.Location = new System.Drawing.Point(328, 513);
            this.AddDeliveryDataButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddDeliveryDataButton.Name = "AddDeliveryDataButton";
            this.AddDeliveryDataButton.Size = new System.Drawing.Size(200, 60);
            this.AddDeliveryDataButton.TabIndex = 11;
            this.AddDeliveryDataButton.Text = "Add Delivery Data";
            this.AddDeliveryDataButton.UseVisualStyleBackColor = false;
            this.AddDeliveryDataButton.Click += new System.EventHandler(this.AddDeliveryDataButton_Click);
            // 
            // AlertsList
            // 
            this.AlertsList.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlertsList.FormattingEnabled = true;
            this.AlertsList.ItemHeight = 17;
            this.AlertsList.Location = new System.Drawing.Point(775, 215);
            this.AlertsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AlertsList.Name = "AlertsList";
            this.AlertsList.Size = new System.Drawing.Size(199, 123);
            this.AlertsList.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(775, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ordering Alerts";
            // 
            // AlertsRefreshButton
            // 
            this.AlertsRefreshButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.AlertsRefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlertsRefreshButton.Location = new System.Drawing.Point(775, 350);
            this.AlertsRefreshButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AlertsRefreshButton.Name = "AlertsRefreshButton";
            this.AlertsRefreshButton.Size = new System.Drawing.Size(200, 31);
            this.AlertsRefreshButton.TabIndex = 14;
            this.AlertsRefreshButton.Text = "refesh";
            this.AlertsRefreshButton.UseVisualStyleBackColor = false;
            this.AlertsRefreshButton.Click += new System.EventHandler(this.AlertsRefreshButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(775, 443);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(247, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Daily Sales Predictions";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(720, 480);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Enter stock item";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(975, 480);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Next day sales/uses";
            // 
            // PredictionNextDaySaleText
            // 
            this.PredictionNextDaySaleText.Location = new System.Drawing.Point(973, 505);
            this.PredictionNextDaySaleText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PredictionNextDaySaleText.Name = "PredictionNextDaySaleText";
            this.PredictionNextDaySaleText.Size = new System.Drawing.Size(132, 22);
            this.PredictionNextDaySaleText.TabIndex = 25;
            // 
            // PredictionSubmitButton
            // 
            this.PredictionSubmitButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PredictionSubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PredictionSubmitButton.Location = new System.Drawing.Point(856, 505);
            this.PredictionSubmitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PredictionSubmitButton.Name = "PredictionSubmitButton";
            this.PredictionSubmitButton.Size = new System.Drawing.Size(100, 25);
            this.PredictionSubmitButton.TabIndex = 26;
            this.PredictionSubmitButton.Text = "Submit";
            this.PredictionSubmitButton.UseVisualStyleBackColor = false;
            this.PredictionSubmitButton.Click += new System.EventHandler(this.PredictionSubmitButton_Click);
            // 
            // PredictionStockItemCombo
            // 
            this.PredictionStockItemCombo.FormattingEnabled = true;
            this.PredictionStockItemCombo.Location = new System.Drawing.Point(709, 505);
            this.PredictionStockItemCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PredictionStockItemCombo.Name = "PredictionStockItemCombo";
            this.PredictionStockItemCombo.Size = new System.Drawing.Size(129, 24);
            this.PredictionStockItemCombo.TabIndex = 28;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1181, 628);
            this.Controls.Add(this.PredictionStockItemCombo);
            this.Controls.Add(this.PredictionSubmitButton);
            this.Controls.Add(this.PredictionNextDaySaleText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.AlertsRefreshButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AlertsList);
            this.Controls.Add(this.AddDeliveryDataButton);
            this.Controls.Add(this.AddSalesDataButton);
            this.Controls.Add(this.AddStockUsageButton);
            this.Controls.Add(this.AddStockItemButton);
            this.Controls.Add(this.AddSupplierButton);
            this.Controls.Add(this.SupplierReportButton);
            this.Controls.Add(this.StockRecordButton);
            this.Controls.Add(this.StockQueryButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HomePage";
            this.Text = "Stock Management + ";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button StockQueryButton;
        private System.Windows.Forms.Button StockRecordButton;
        private System.Windows.Forms.Button SupplierReportButton;
        private System.Windows.Forms.Button AddSupplierButton;
        private System.Windows.Forms.Button AddStockItemButton;
        private System.Windows.Forms.Button AddStockUsageButton;
        private System.Windows.Forms.Button AddSalesDataButton;
        private System.Windows.Forms.Button AddDeliveryDataButton;
        private System.Windows.Forms.ListBox AlertsList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AlertsRefreshButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox PredictionNextDaySaleText;
        private System.Windows.Forms.Button PredictionSubmitButton;
        private System.Windows.Forms.ComboBox PredictionStockItemCombo;
    }
}

