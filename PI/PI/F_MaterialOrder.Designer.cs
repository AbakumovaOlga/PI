namespace PI
{
    partial class F_MaterialOrder
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
            this.F_Save = new System.Windows.Forms.Button();
            this.F_ChooseMat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // F_Save
            // 
            this.F_Save.Location = new System.Drawing.Point(130, 98);
            this.F_Save.Name = "F_Save";
            this.F_Save.Size = new System.Drawing.Size(101, 33);
            this.F_Save.TabIndex = 9;
            this.F_Save.Text = "Сохранить";
            this.F_Save.UseVisualStyleBackColor = true;
            this.F_Save.Click += new System.EventHandler(this.F_Save_Click);
            // 
            // F_ChooseMat
            // 
            this.F_ChooseMat.FormattingEnabled = true;
            this.F_ChooseMat.Location = new System.Drawing.Point(130, 9);
            this.F_ChooseMat.Name = "F_ChooseMat";
            this.F_ChooseMat.Size = new System.Drawing.Size(238, 28);
            this.F_ChooseMat.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Материал";
            // 
            // F_MaterialOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 143);
            this.Controls.Add(this.F_Save);
            this.Controls.Add(this.F_ChooseMat);
            this.Controls.Add(this.label1);
            this.Name = "F_MaterialOrder";
            this.Text = "F_MaterialOrder";
            this.Load += new System.EventHandler(this.F_MaterialOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button F_Save;
        private System.Windows.Forms.ComboBox F_ChooseMat;
        private System.Windows.Forms.Label label1;
    }
}