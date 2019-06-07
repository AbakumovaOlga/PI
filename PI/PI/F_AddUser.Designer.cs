namespace PI
{
    partial class F_AddUser
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
            this.label3 = new System.Windows.Forms.Label();
            this.F_Save = new System.Windows.Forms.Button();
            this.F_Login = new System.Windows.Forms.TextBox();
            this.F_Password = new System.Windows.Forms.TextBox();
            this.F_Name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // F_Save
            // 
            this.F_Save.Location = new System.Drawing.Point(172, 284);
            this.F_Save.Name = "F_Save";
            this.F_Save.Size = new System.Drawing.Size(129, 45);
            this.F_Save.TabIndex = 3;
            this.F_Save.Text = "Save";
            this.F_Save.UseVisualStyleBackColor = true;
            this.F_Save.Click += new System.EventHandler(this.F_Save_Click);
            // 
            // F_Login
            // 
            this.F_Login.Location = new System.Drawing.Point(244, 75);
            this.F_Login.Name = "F_Login";
            this.F_Login.Size = new System.Drawing.Size(179, 26);
            this.F_Login.TabIndex = 4;
            // 
            // F_Password
            // 
            this.F_Password.Location = new System.Drawing.Point(244, 138);
            this.F_Password.Name = "F_Password";
            this.F_Password.Size = new System.Drawing.Size(179, 26);
            this.F_Password.TabIndex = 5;
            // 
            // F_Name
            // 
            this.F_Name.Location = new System.Drawing.Point(244, 211);
            this.F_Name.Name = "F_Name";
            this.F_Name.Size = new System.Drawing.Size(179, 26);
            this.F_Name.TabIndex = 6;
            // 
            // F_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 372);
            this.Controls.Add(this.F_Name);
            this.Controls.Add(this.F_Password);
            this.Controls.Add(this.F_Login);
            this.Controls.Add(this.F_Save);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "F_AddUser";
            this.Text = "F_AddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button F_Save;
        private System.Windows.Forms.TextBox F_Login;
        private System.Windows.Forms.TextBox F_Password;
        private System.Windows.Forms.TextBox F_Name;
    }
}