namespace PI
{
    partial class F_Sizes
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
            this.F_Add = new System.Windows.Forms.Button();
            this.F_List = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.F_List)).BeginInit();
            this.SuspendLayout();
            // 
            // F_Add
            // 
            this.F_Add.Location = new System.Drawing.Point(12, 389);
            this.F_Add.Name = "F_Add";
            this.F_Add.Size = new System.Drawing.Size(89, 38);
            this.F_Add.TabIndex = 4;
            this.F_Add.Text = "Создать";
            this.F_Add.UseVisualStyleBackColor = true;
            this.F_Add.Click += new System.EventHandler(this.F_Add_Click);
            // 
            // F_List
            // 
            this.F_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_List.Location = new System.Drawing.Point(12, 24);
            this.F_List.Name = "F_List";
            this.F_List.RowTemplate.Height = 28;
            this.F_List.Size = new System.Drawing.Size(776, 359);
            this.F_List.TabIndex = 3;
            // 
            // F_Sizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.F_Add);
            this.Controls.Add(this.F_List);
            this.Name = "F_Sizes";
            this.Text = "F_Sizes";
            this.Load += new System.EventHandler(this.F_Sizes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.F_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button F_Add;
        private System.Windows.Forms.DataGridView F_List;
    }
}