namespace PI
{
    partial class F_MaterialBuy
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
            this.F_ChooseMat = new System.Windows.Forms.ComboBox();
            this.F_Count = new System.Windows.Forms.TextBox();
            this.F_Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Материал";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество";
            // 
            // F_ChooseMat
            // 
            this.F_ChooseMat.FormattingEnabled = true;
            this.F_ChooseMat.Location = new System.Drawing.Point(184, 76);
            this.F_ChooseMat.Name = "F_ChooseMat";
            this.F_ChooseMat.Size = new System.Drawing.Size(238, 28);
            this.F_ChooseMat.TabIndex = 2;
            // 
            // F_Count
            // 
            this.F_Count.Location = new System.Drawing.Point(185, 136);
            this.F_Count.Name = "F_Count";
            this.F_Count.Size = new System.Drawing.Size(237, 26);
            this.F_Count.TabIndex = 3;
            // 
            // F_Save
            // 
            this.F_Save.Location = new System.Drawing.Point(184, 202);
            this.F_Save.Name = "F_Save";
            this.F_Save.Size = new System.Drawing.Size(101, 33);
            this.F_Save.TabIndex = 4;
            this.F_Save.Text = "Сохранить";
            this.F_Save.UseVisualStyleBackColor = true;
            this.F_Save.Click += new System.EventHandler(this.F_Save_Click);
            // 
            // F_MaterialBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 259);
            this.Controls.Add(this.F_Save);
            this.Controls.Add(this.F_Count);
            this.Controls.Add(this.F_ChooseMat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_MaterialBuy";
            this.Text = "F_MaterialBuy";
            this.Load += new System.EventHandler(this.F_MaterialBuy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox F_ChooseMat;
        private System.Windows.Forms.TextBox F_Count;
        private System.Windows.Forms.Button F_Save;
    }
}