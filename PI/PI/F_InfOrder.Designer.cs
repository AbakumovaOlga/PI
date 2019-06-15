namespace PI
{
    partial class F_InfOrder
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
            this.F_ListMaterials = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.F_Customer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.F_Date = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.F_Sum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.F_ListMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // F_ListMaterials
            // 
            this.F_ListMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_ListMaterials.Location = new System.Drawing.Point(24, 142);
            this.F_ListMaterials.Name = "F_ListMaterials";
            this.F_ListMaterials.RowTemplate.Height = 28;
            this.F_ListMaterials.Size = new System.Drawing.Size(753, 286);
            this.F_ListMaterials.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Клиент";
            // 
            // F_Customer
            // 
            this.F_Customer.Location = new System.Drawing.Point(125, 86);
            this.F_Customer.Name = "F_Customer";
            this.F_Customer.Size = new System.Drawing.Size(198, 26);
            this.F_Customer.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дата Заказа";
            // 
            // F_Date
            // 
            this.F_Date.Location = new System.Drawing.Point(154, 37);
            this.F_Date.Name = "F_Date";
            this.F_Date.Size = new System.Drawing.Size(200, 26);
            this.F_Date.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Сумма";
            // 
            // F_Sum
            // 
            this.F_Sum.Location = new System.Drawing.Point(674, 86);
            this.F_Sum.Name = "F_Sum";
            this.F_Sum.ReadOnly = true;
            this.F_Sum.Size = new System.Drawing.Size(100, 26);
            this.F_Sum.TabIndex = 12;
            // 
            // F_InfOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.F_Sum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.F_Customer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_Date);
            this.Controls.Add(this.F_ListMaterials);
            this.Name = "F_InfOrder";
            this.Text = "F_InfOrder";
            this.Load += new System.EventHandler(this.F_InfOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.F_ListMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView F_ListMaterials;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox F_Customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker F_Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox F_Sum;
    }
}