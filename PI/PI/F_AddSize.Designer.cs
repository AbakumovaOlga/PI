namespace PI
{
    partial class F_AddSize
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
            this.F_Name = new System.Windows.Forms.TextBox();
            this.F_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // F_Name
            // 
            this.F_Name.Location = new System.Drawing.Point(152, 80);
            this.F_Name.Name = "F_Name";
            this.F_Name.Size = new System.Drawing.Size(243, 26);
            this.F_Name.TabIndex = 1;
            // 
            // F_Save
            // 
            this.F_Save.Location = new System.Drawing.Point(320, 168);
            this.F_Save.Name = "F_Save";
            this.F_Save.Size = new System.Drawing.Size(87, 33);
            this.F_Save.TabIndex = 2;
            this.F_Save.Text = "Save";
            this.F_Save.UseVisualStyleBackColor = true;
            this.F_Save.Click += new System.EventHandler(this.F_Save_Click);
            // 
            // F_AddSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 270);
            this.Controls.Add(this.F_Save);
            this.Controls.Add(this.F_Name);
            this.Controls.Add(this.label1);
            this.Name = "F_AddSize";
            this.Text = "F_AddSize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox F_Name;
        private System.Windows.Forms.Button F_Save;
    }
}