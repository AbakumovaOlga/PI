namespace PI
{
    partial class F_Author
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
            this.F_Enter = new System.Windows.Forms.Button();
            this.F_Login = new System.Windows.Forms.TextBox();
            this.F_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.F_Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // F_Enter
            // 
            this.F_Enter.Location = new System.Drawing.Point(368, 281);
            this.F_Enter.Name = "F_Enter";
            this.F_Enter.Size = new System.Drawing.Size(101, 29);
            this.F_Enter.TabIndex = 0;
            this.F_Enter.Text = "Вход";
            this.F_Enter.UseVisualStyleBackColor = true;
            this.F_Enter.Click += new System.EventHandler(this.F_Enter_Click);
            // 
            // F_Login
            // 
            this.F_Login.Location = new System.Drawing.Point(207, 95);
            this.F_Login.Name = "F_Login";
            this.F_Login.Size = new System.Drawing.Size(173, 26);
            this.F_Login.TabIndex = 1;
            // 
            // F_Password
            // 
            this.F_Password.Location = new System.Drawing.Point(207, 177);
            this.F_Password.Name = "F_Password";
            this.F_Password.PasswordChar = '*';
            this.F_Password.Size = new System.Drawing.Size(173, 26);
            this.F_Password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            // 
            // F_Create
            // 
            this.F_Create.Location = new System.Drawing.Point(546, 136);
            this.F_Create.Name = "F_Create";
            this.F_Create.Size = new System.Drawing.Size(75, 23);
            this.F_Create.TabIndex = 5;
            this.F_Create.Text = "Создать";
            this.F_Create.UseVisualStyleBackColor = true;
            this.F_Create.Click += new System.EventHandler(this.F_Create_Click);
            // 
            // F_Author
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.F_Create);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.F_Password);
            this.Controls.Add(this.F_Login);
            this.Controls.Add(this.F_Enter);
            this.Name = "F_Author";
            this.Text = "Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button F_Enter;
        private System.Windows.Forms.TextBox F_Login;
        private System.Windows.Forms.TextBox F_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button F_Create;
    }
}