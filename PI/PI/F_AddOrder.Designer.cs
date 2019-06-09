namespace PI
{
    partial class F_AddOrder
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
            this.F_Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.F_Customer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.F_Size = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.F_List = new System.Windows.Forms.DataGridView();
            this.F_Add = new System.Windows.Forms.Button();
            this.F_Del = new System.Windows.Forms.Button();
            this.F_Save = new System.Windows.Forms.Button();
            this.F_Sum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.F_List)).BeginInit();
            this.SuspendLayout();
            // 
            // F_Date
            // 
            this.F_Date.Location = new System.Drawing.Point(109, 52);
            this.F_Date.Name = "F_Date";
            this.F_Date.Size = new System.Drawing.Size(200, 26);
            this.F_Date.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Дата";
            // 
            // F_Customer
            // 
            this.F_Customer.Location = new System.Drawing.Point(109, 101);
            this.F_Customer.Name = "F_Customer";
            this.F_Customer.Size = new System.Drawing.Size(198, 26);
            this.F_Customer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Клиент";
            // 
            // F_Size
            // 
            this.F_Size.FormattingEnabled = true;
            this.F_Size.Location = new System.Drawing.Point(109, 153);
            this.F_Size.Name = "F_Size";
            this.F_Size.Size = new System.Drawing.Size(198, 28);
            this.F_Size.TabIndex = 4;
            this.F_Size.SelectedIndexChanged += new System.EventHandler(this.F_Size_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Размер";
            // 
            // F_List
            // 
            this.F_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_List.Location = new System.Drawing.Point(30, 222);
            this.F_List.Name = "F_List";
            this.F_List.RowTemplate.Height = 28;
            this.F_List.Size = new System.Drawing.Size(415, 251);
            this.F_List.TabIndex = 6;
            // 
            // F_Add
            // 
            this.F_Add.Enabled = false;
            this.F_Add.Location = new System.Drawing.Point(482, 222);
            this.F_Add.Name = "F_Add";
            this.F_Add.Size = new System.Drawing.Size(112, 33);
            this.F_Add.TabIndex = 7;
            this.F_Add.Text = "Добавить";
            this.F_Add.UseVisualStyleBackColor = true;
            this.F_Add.Click += new System.EventHandler(this.F_Add_Click);
            // 
            // F_Del
            // 
            this.F_Del.Location = new System.Drawing.Point(482, 301);
            this.F_Del.Name = "F_Del";
            this.F_Del.Size = new System.Drawing.Size(112, 33);
            this.F_Del.TabIndex = 8;
            this.F_Del.Text = "Удалить";
            this.F_Del.UseVisualStyleBackColor = true;
            this.F_Del.Click += new System.EventHandler(this.F_Del_Click);
            // 
            // F_Save
            // 
            this.F_Save.Location = new System.Drawing.Point(153, 494);
            this.F_Save.Name = "F_Save";
            this.F_Save.Size = new System.Drawing.Size(116, 33);
            this.F_Save.TabIndex = 9;
            this.F_Save.Text = "Сохранить";
            this.F_Save.UseVisualStyleBackColor = true;
            this.F_Save.Click += new System.EventHandler(this.F_Save_Click);
            // 
            // F_Sum
            // 
            this.F_Sum.Location = new System.Drawing.Point(482, 447);
            this.F_Sum.Name = "F_Sum";
            this.F_Sum.ReadOnly = true;
            this.F_Sum.Size = new System.Drawing.Size(100, 26);
            this.F_Sum.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(487, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Сумма";
            // 
            // F_AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 546);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.F_Sum);
            this.Controls.Add(this.F_Save);
            this.Controls.Add(this.F_Del);
            this.Controls.Add(this.F_Add);
            this.Controls.Add(this.F_List);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.F_Size);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.F_Customer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_Date);
            this.Name = "F_AddOrder";
            this.Text = "F_AddOrder";
            this.Load += new System.EventHandler(this.F_AddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.F_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker F_Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox F_Customer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox F_Size;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView F_List;
        private System.Windows.Forms.Button F_Add;
        private System.Windows.Forms.Button F_Del;
        private System.Windows.Forms.Button F_Save;
        private System.Windows.Forms.TextBox F_Sum;
        private System.Windows.Forms.Label label4;
    }
}