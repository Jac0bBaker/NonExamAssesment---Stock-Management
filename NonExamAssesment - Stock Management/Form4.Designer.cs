namespace NonExamAssesment___Stock_Management
{
    partial class DeliveryDataEntryPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryDataEntryPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deliveryDateText = new System.Windows.Forms.TextBox();
            this.deliveryQuantityText = new System.Windows.Forms.TextBox();
            this.deliverySubmitButton = new System.Windows.Forms.Button();
            this.DeliverySupplierCombo = new System.Windows.Forms.ComboBox();
            this.DeliveryProductCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delivery Data Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Supplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stock Items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Delivery Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Delivery Quantity";
            // 
            // deliveryDateText
            // 
            this.deliveryDateText.Location = new System.Drawing.Point(160, 200);
            this.deliveryDateText.Name = "deliveryDateText";
            this.deliveryDateText.Size = new System.Drawing.Size(100, 22);
            this.deliveryDateText.TabIndex = 9;
            // 
            // deliveryQuantityText
            // 
            this.deliveryQuantityText.Location = new System.Drawing.Point(190, 250);
            this.deliveryQuantityText.Name = "deliveryQuantityText";
            this.deliveryQuantityText.Size = new System.Drawing.Size(75, 22);
            this.deliveryQuantityText.TabIndex = 10;
            // 
            // deliverySubmitButton
            // 
            this.deliverySubmitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deliverySubmitButton.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliverySubmitButton.Location = new System.Drawing.Point(30, 300);
            this.deliverySubmitButton.Name = "deliverySubmitButton";
            this.deliverySubmitButton.Size = new System.Drawing.Size(100, 30);
            this.deliverySubmitButton.TabIndex = 11;
            this.deliverySubmitButton.Text = "Submit";
            this.deliverySubmitButton.UseVisualStyleBackColor = true;
            this.deliverySubmitButton.Click += new System.EventHandler(this.deliverySubmitButton_Click);
            // 
            // DeliverySupplierCombo
            // 
            this.DeliverySupplierCombo.FormattingEnabled = true;
            this.DeliverySupplierCombo.Location = new System.Drawing.Point(125, 100);
            this.DeliverySupplierCombo.Name = "DeliverySupplierCombo";
            this.DeliverySupplierCombo.Size = new System.Drawing.Size(160, 24);
            this.DeliverySupplierCombo.TabIndex = 12;
            // 
            // DeliveryProductCombo
            // 
            this.DeliveryProductCombo.FormattingEnabled = true;
            this.DeliveryProductCombo.Location = new System.Drawing.Point(150, 150);
            this.DeliveryProductCombo.Name = "DeliveryProductCombo";
            this.DeliveryProductCombo.Size = new System.Drawing.Size(150, 24);
            this.DeliveryProductCombo.TabIndex = 13;
            // 
            // DeliveryDataEntryPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 503);
            this.Controls.Add(this.DeliveryProductCombo);
            this.Controls.Add(this.DeliverySupplierCombo);
            this.Controls.Add(this.deliverySubmitButton);
            this.Controls.Add(this.deliveryQuantityText);
            this.Controls.Add(this.deliveryDateText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeliveryDataEntryPage";
            this.Text = "Delivery Data Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox deliveryDateText;
        private System.Windows.Forms.TextBox deliveryQuantityText;
        private System.Windows.Forms.Button deliverySubmitButton;
        private System.Windows.Forms.ComboBox DeliverySupplierCombo;
        private System.Windows.Forms.ComboBox DeliveryProductCombo;
    }
}