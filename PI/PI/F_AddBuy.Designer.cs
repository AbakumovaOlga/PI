namespace PI
{
    partial class F_AddBuy
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
            this.F_Materials = new System.Windows.Forms.DataGridView();
            this.F_AddMat = new System.Windows.Forms.Button();
            this.F_DelMat = new System.Windows.Forms.Button();
            this.F_Save = new System.Windows.Forms.Button();
            this.F_Date = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.F_Materials)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата";
            // 
            // F_Materials
            // 
            this.F_Materials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_Materials.Location = new System.Drawing.Point(27, 23);
            this.F_Materials.Name = "F_Materials";
            this.F_Materials.RowTemplate.Height = 28;
            this.F_Materials.Size = new System.Drawing.Size(463, 292);
            this.F_Materials.TabIndex = 6;
            // 
            // F_AddMat
            // 
            this.F_AddMat.Location = new System.Drawing.Point(532, 23);
            this.F_AddMat.Name = "F_AddMat";
            this.F_AddMat.Size = new System.Drawing.Size(104, 35);
            this.F_AddMat.TabIndex = 7;
            this.F_AddMat.Text = "Добавить";
            this.F_AddMat.UseVisualStyleBackColor = true;
            this.F_AddMat.Click += new System.EventHandler(this.F_AddMat_Click);
            // 
            // F_DelMat
            // 
            this.F_DelMat.Location = new System.Drawing.Point(532, 87);
            this.F_DelMat.Name = "F_DelMat";
            this.F_DelMat.Size = new System.Drawing.Size(104, 38);
            this.F_DelMat.TabIndex = 8;
            this.F_DelMat.Text = "Удалить";
            this.F_DelMat.UseVisualStyleBackColor = true;
            this.F_DelMat.Click += new System.EventHandler(this.F_DelMat_Click);
            // 
            // F_Save
            // 
            this.F_Save.Location = new System.Drawing.Point(532, 367);
            this.F_Save.Name = "F_Save";
            this.F_Save.Size = new System.Drawing.Size(104, 40);
            this.F_Save.TabIndex = 9;
            this.F_Save.Text = "Сохранить";
            this.F_Save.UseVisualStyleBackColor = true;
            this.F_Save.Click += new System.EventHandler(this.F_Save_Click);
            // 
            // F_Date
            // 
            this.F_Date.Location = new System.Drawing.Point(151, 372);
            this.F_Date.Name = "F_Date";
            this.F_Date.Size = new System.Drawing.Size(200, 26);
            this.F_Date.TabIndex = 10;
            // 
            // F_AddBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 426);
            this.Controls.Add(this.F_Date);
            this.Controls.Add(this.F_Save);
            this.Controls.Add(this.F_DelMat);
            this.Controls.Add(this.F_AddMat);
            this.Controls.Add(this.F_Materials);
            this.Controls.Add(this.label1);
            this.Name = "F_AddBuy";
            this.Text = "F_AddBuy";
            this.Load += new System.EventHandler(this.F_AddBuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.F_Materials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView F_Materials;
        private System.Windows.Forms.Button F_AddMat;
        private System.Windows.Forms.Button F_DelMat;
        private System.Windows.Forms.Button F_Save;
        private System.Windows.Forms.DateTimePicker F_Date;
    }
}