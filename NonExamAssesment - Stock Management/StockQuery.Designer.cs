﻿namespace NonExamAssesment___Stock_Management
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
            this.label2 = new System.Windows.Forms.Label();
            this.QueryProductCombo = new System.Windows.Forms.ComboBox();
            this.QueryDateRangeStartText = new System.Windows.Forms.TextBox();
            this.QueryDateRangeEndText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QuerySubmitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Range";
            // 
            // QueryProductCombo
            // 
            this.QueryProductCombo.FormattingEnabled = true;
            this.QueryProductCombo.Location = new System.Drawing.Point(125, 20);
            this.QueryProductCombo.Name = "QueryProductCombo";
            this.QueryProductCombo.Size = new System.Drawing.Size(100, 21);
            this.QueryProductCombo.TabIndex = 2;
            // 
            // QueryDateRangeStartText
            // 
            this.QueryDateRangeStartText.Location = new System.Drawing.Point(330, 20);
            this.QueryDateRangeStartText.Name = "QueryDateRangeStartText";
            this.QueryDateRangeStartText.Size = new System.Drawing.Size(75, 20);
            this.QueryDateRangeStartText.TabIndex = 3;
            // 
            // QueryDateRangeEndText
            // 
            this.QueryDateRangeEndText.Location = new System.Drawing.Point(430, 20);
            this.QueryDateRangeEndText.Name = "QueryDateRangeEndText";
            this.QueryDateRangeEndText.Size = new System.Drawing.Size(75, 20);
            this.QueryDateRangeEndText.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "-";
            // 
            // QuerySubmitButton
            // 
            this.QuerySubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuerySubmitButton.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuerySubmitButton.Location = new System.Drawing.Point(550, 20);
            this.QuerySubmitButton.Name = "QuerySubmitButton";
            this.QuerySubmitButton.Size = new System.Drawing.Size(100, 20);
            this.QuerySubmitButton.TabIndex = 6;
            this.QuerySubmitButton.Text = "Submit";
            this.QuerySubmitButton.UseVisualStyleBackColor = true;
            // 
            // StockQueryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuerySubmitButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.QueryDateRangeEndText);
            this.Controls.Add(this.QueryDateRangeStartText);
            this.Controls.Add(this.QueryProductCombo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StockQueryPage";
            this.Text = "StockQuery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox QueryProductCombo;
        private System.Windows.Forms.TextBox QueryDateRangeStartText;
        private System.Windows.Forms.TextBox QueryDateRangeEndText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button QuerySubmitButton;
    }
}