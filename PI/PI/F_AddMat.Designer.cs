namespace PI
{
    partial class F_AddMat
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
            this.F_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.F_ChooseSize = new System.Windows.Forms.ComboBox();
            this.F_NewSize = new System.Windows.Forms.TextBox();
            this.F_AddSize = new System.Windows.Forms.Button();
            this.F_Save = new System.Windows.Forms.Button();
            this.F_NewType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.F_ChooseType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.F_AddType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // F_Price
            // 
            this.F_Price.Location = new System.Drawing.Point(137, 190);
            this.F_Price.Name = "F_Price";
            this.F_Price.Size = new System.Drawing.Size(100, 26);
            this.F_Price.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Цена*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Размер*";
            // 
            // F_ChooseSize
            // 
            this.F_ChooseSize.FormattingEnabled = true;
            this.F_ChooseSize.Location = new System.Drawing.Point(137, 95);
            this.F_ChooseSize.Name = "F_ChooseSize";
            this.F_ChooseSize.Size = new System.Drawing.Size(223, 28);
            this.F_ChooseSize.TabIndex = 6;
            // 
            // F_NewSize
            // 
            this.F_NewSize.Location = new System.Drawing.Point(410, 95);
            this.F_NewSize.Name = "F_NewSize";
            this.F_NewSize.Size = new System.Drawing.Size(143, 26);
            this.F_NewSize.TabIndex = 7;
            // 
            // F_AddSize
            // 
            this.F_AddSize.Location = new System.Drawing.Point(569, 95);
            this.F_AddSize.Name = "F_AddSize";
            this.F_AddSize.Size = new System.Drawing.Size(99, 28);
            this.F_AddSize.TabIndex = 8;
            this.F_AddSize.Text = "Добавить";
            this.F_AddSize.UseVisualStyleBackColor = true;
            this.F_AddSize.Click += new System.EventHandler(this.F_AddSize_Click);
            // 
            // F_Save
            // 
            this.F_Save.Location = new System.Drawing.Point(549, 226);
            this.F_Save.Name = "F_Save";
            this.F_Save.Size = new System.Drawing.Size(119, 41);
            this.F_Save.TabIndex = 12;
            this.F_Save.Text = "Сохранить";
            this.F_Save.UseVisualStyleBackColor = true;
            this.F_Save.Click += new System.EventHandler(this.F_Save_Click);
            // 
            // F_NewType
            // 
            this.F_NewType.Location = new System.Drawing.Point(410, 35);
            this.F_NewType.Name = "F_NewType";
            this.F_NewType.Size = new System.Drawing.Size(143, 26);
            this.F_NewType.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Создать новый размер";
            // 
            // F_ChooseType
            // 
            this.F_ChooseType.FormattingEnabled = true;
            this.F_ChooseType.Location = new System.Drawing.Point(137, 41);
            this.F_ChooseType.Name = "F_ChooseType";
            this.F_ChooseType.Size = new System.Drawing.Size(223, 28);
            this.F_ChooseType.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Создать новый тип";
            // 
            // F_AddType
            // 
            this.F_AddType.Location = new System.Drawing.Point(569, 33);
            this.F_AddType.Name = "F_AddType";
            this.F_AddType.Size = new System.Drawing.Size(99, 28);
            this.F_AddType.TabIndex = 17;
            this.F_AddType.Text = "Добавить";
            this.F_AddType.UseVisualStyleBackColor = true;
            this.F_AddType.Click += new System.EventHandler(this.F_AddType_Click);
            // 
            // F_AddMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 317);
            this.Controls.Add(this.F_AddType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.F_ChooseType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.F_NewType);
            this.Controls.Add(this.F_Save);
            this.Controls.Add(this.F_AddSize);
            this.Controls.Add(this.F_NewSize);
            this.Controls.Add(this.F_ChooseSize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_Price);
            this.Name = "F_AddMat";
            this.Text = "AddMat";
            this.Load += new System.EventHandler(this.F_AddMat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox F_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox F_ChooseSize;
        private System.Windows.Forms.TextBox F_NewSize;
        private System.Windows.Forms.Button F_AddSize;
        private System.Windows.Forms.Button F_Save;
        private System.Windows.Forms.TextBox F_NewType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox F_ChooseType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button F_AddType;
    }
}