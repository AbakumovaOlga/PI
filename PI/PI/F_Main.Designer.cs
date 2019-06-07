namespace PI
{
    partial class F_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.F_OdersList = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.расходныеМатериалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вНаличииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.распечатьСписокПокупокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закупкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.администрированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьМатериалToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьРазмерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.F_Status = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.добавитьТипToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.F_OdersList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // F_OdersList
            // 
            this.F_OdersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.F_OdersList.Location = new System.Drawing.Point(12, 138);
            this.F_OdersList.Name = "F_OdersList";
            this.F_OdersList.RowTemplate.Height = 28;
            this.F_OdersList.Size = new System.Drawing.Size(776, 300);
            this.F_OdersList.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расходныеМатериалыToolStripMenuItem,
            this.статистикаToolStripMenuItem,
            this.администрированиеToolStripMenuItem,
            this.заказToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // расходныеМатериалыToolStripMenuItem
            // 
            this.расходныеМатериалыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вНаличииToolStripMenuItem,
            this.распечатьСписокПокупокToolStripMenuItem,
            this.закупкаToolStripMenuItem});
            this.расходныеМатериалыToolStripMenuItem.Name = "расходныеМатериалыToolStripMenuItem";
            this.расходныеМатериалыToolStripMenuItem.Size = new System.Drawing.Size(207, 29);
            this.расходныеМатериалыToolStripMenuItem.Text = "Расходные материалы";
            // 
            // вНаличииToolStripMenuItem
            // 
            this.вНаличииToolStripMenuItem.Name = "вНаличииToolStripMenuItem";
            this.вНаличииToolStripMenuItem.Size = new System.Drawing.Size(312, 30);
            this.вНаличииToolStripMenuItem.Text = "В наличии";
            this.вНаличииToolStripMenuItem.Click += new System.EventHandler(this.вНаличииToolStripMenuItem_Click);
            // 
            // распечатьСписокПокупокToolStripMenuItem
            // 
            this.распечатьСписокПокупокToolStripMenuItem.Name = "распечатьСписокПокупокToolStripMenuItem";
            this.распечатьСписокПокупокToolStripMenuItem.Size = new System.Drawing.Size(312, 30);
            this.распечатьСписокПокупокToolStripMenuItem.Text = "Распечать список покупок";
            this.распечатьСписокПокупокToolStripMenuItem.Click += new System.EventHandler(this.распечатьСписокПокупокToolStripMenuItem_Click);
            // 
            // закупкаToolStripMenuItem
            // 
            this.закупкаToolStripMenuItem.Name = "закупкаToolStripMenuItem";
            this.закупкаToolStripMenuItem.Size = new System.Drawing.Size(312, 30);
            this.закупкаToolStripMenuItem.Text = "Закупка";
            this.закупкаToolStripMenuItem.Click += new System.EventHandler(this.закупкаToolStripMenuItem_Click);
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(111, 29);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // администрированиеToolStripMenuItem
            // 
            this.администрированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьМатериалToolStripMenuItem,
            this.добавитьПользователяToolStripMenuItem,
            this.добавитьРазмерToolStripMenuItem,
            this.добавитьТипToolStripMenuItem});
            this.администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            this.администрированиеToolStripMenuItem.Size = new System.Drawing.Size(195, 29);
            this.администрированиеToolStripMenuItem.Text = "Администрирование";
            // 
            // добавитьМатериалToolStripMenuItem
            // 
            this.добавитьМатериалToolStripMenuItem.Name = "добавитьМатериалToolStripMenuItem";
            this.добавитьМатериалToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.добавитьМатериалToolStripMenuItem.Text = "Добавить материал";
            this.добавитьМатериалToolStripMenuItem.Click += new System.EventHandler(this.добавитьМатериалToolStripMenuItem_Click);
            // 
            // добавитьПользователяToolStripMenuItem
            // 
            this.добавитьПользователяToolStripMenuItem.Name = "добавитьПользователяToolStripMenuItem";
            this.добавитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.добавитьПользователяToolStripMenuItem.Text = "Добавить пользователя";
            this.добавитьПользователяToolStripMenuItem.Click += new System.EventHandler(this.добавитьПользователяToolStripMenuItem_Click);
            // 
            // добавитьРазмерToolStripMenuItem
            // 
            this.добавитьРазмерToolStripMenuItem.Name = "добавитьРазмерToolStripMenuItem";
            this.добавитьРазмерToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.добавитьРазмерToolStripMenuItem.Text = "Добавить размер";
            this.добавитьРазмерToolStripMenuItem.Click += new System.EventHandler(this.добавитьРазмерToolStripMenuItem_Click);
            // 
            // заказToolStripMenuItem
            // 
            this.заказToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаказToolStripMenuItem});
            this.заказToolStripMenuItem.Name = "заказToolStripMenuItem";
            this.заказToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.заказToolStripMenuItem.Text = "Заказ";
            // 
            // добавитьЗаказToolStripMenuItem
            // 
            this.добавитьЗаказToolStripMenuItem.Name = "добавитьЗаказToolStripMenuItem";
            this.добавитьЗаказToolStripMenuItem.Size = new System.Drawing.Size(222, 30);
            this.добавитьЗаказToolStripMenuItem.Text = "Добавить заказ";
            this.добавитьЗаказToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаказToolStripMenuItem_Click);
            // 
            // F_Status
            // 
            this.F_Status.FormattingEnabled = true;
            this.F_Status.Location = new System.Drawing.Point(545, 104);
            this.F_Status.Name = "F_Status";
            this.F_Status.Size = new System.Drawing.Size(208, 28);
            this.F_Status.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Статус заказа";
            // 
            // добавитьТипToolStripMenuItem
            // 
            this.добавитьТипToolStripMenuItem.Name = "добавитьТипToolStripMenuItem";
            this.добавитьТипToolStripMenuItem.Size = new System.Drawing.Size(290, 30);
            this.добавитьТипToolStripMenuItem.Text = "Добавить тип";
            this.добавитьТипToolStripMenuItem.Click += new System.EventHandler(this.добавитьТипToolStripMenuItem_Click);
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.F_Status);
            this.Controls.Add(this.F_OdersList);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_Main";
            this.Text = "PI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.F_OdersList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView F_OdersList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem расходныеМатериалыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вНаличииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem распечатьСписокПокупокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem администрированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьМатериалToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьРазмерToolStripMenuItem;
        private System.Windows.Forms.ComboBox F_Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem закупкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТипToolStripMenuItem;
    }
}

