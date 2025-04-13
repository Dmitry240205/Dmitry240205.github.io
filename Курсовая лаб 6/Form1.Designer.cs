namespace WindowsFormsApp6
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.увеличитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.уменьшитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.прогрессToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.увеличитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уменьшитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.курсорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hourGlassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handPointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.формыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.модальнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MIClose = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.ContextMenuStrip = this.contextMenuStrip1;
            this.progressBar1.Location = new System.Drawing.Point(32, 205);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(85, 20);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 50;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.увеличитьToolStripMenuItem1,
            this.уменьшитьToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 48);
            this.contextMenuStrip1.Click += new System.EventHandler(this.уменьшитьToolStripMenuItem_Click);
            // 
            // увеличитьToolStripMenuItem1
            // 
            this.увеличитьToolStripMenuItem1.Name = "увеличитьToolStripMenuItem1";
            this.увеличитьToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.увеличитьToolStripMenuItem1.Text = "У&величить";
            this.увеличитьToolStripMenuItem1.Click += new System.EventHandler(this.увеличитьToolStripMenuItem_Click);
            // 
            // уменьшитьToolStripMenuItem1
            // 
            this.уменьшитьToolStripMenuItem1.Name = "уменьшитьToolStripMenuItem1";
            this.уменьшитьToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.уменьшитьToolStripMenuItem1.Text = "У&меньшить";
            this.уменьшитьToolStripMenuItem1.Click += new System.EventHandler(this.уменьшитьToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прогрессToolStripMenuItem,
            this.формыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // прогрессToolStripMenuItem
            // 
            this.прогрессToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.увеличитьToolStripMenuItem,
            this.уменьшитьToolStripMenuItem,
            this.toolStripMenuItem1,
            this.курсорToolStripMenuItem});
            this.прогрессToolStripMenuItem.Name = "прогрессToolStripMenuItem";
            this.прогрессToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.прогрессToolStripMenuItem.Text = "&Прогресс";
            // 
            // увеличитьToolStripMenuItem
            // 
            this.увеличитьToolStripMenuItem.Name = "увеличитьToolStripMenuItem";
            this.увеличитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.увеличитьToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.увеличитьToolStripMenuItem.Text = "У&величить";
            this.увеличитьToolStripMenuItem.Click += new System.EventHandler(this.увеличитьToolStripMenuItem_Click);
            // 
            // уменьшитьToolStripMenuItem
            // 
            this.уменьшитьToolStripMenuItem.Name = "уменьшитьToolStripMenuItem";
            this.уменьшитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.уменьшитьToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.уменьшитьToolStripMenuItem.Text = "У&меньшить";
            this.уменьшитьToolStripMenuItem.Click += new System.EventHandler(this.уменьшитьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(185, 6);
            // 
            // курсорToolStripMenuItem
            // 
            this.курсорToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultToolStripMenuItem,
            this.hourGlassToolStripMenuItem,
            this.handPointToolStripMenuItem});
            this.курсорToolStripMenuItem.Name = "курсорToolStripMenuItem";
            this.курсорToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.курсорToolStripMenuItem.Text = "&Курсор";
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.defaultToolStripMenuItem.Text = "&Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // hourGlassToolStripMenuItem
            // 
            this.hourGlassToolStripMenuItem.Name = "hourGlassToolStripMenuItem";
            this.hourGlassToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.hourGlassToolStripMenuItem.Text = "&HourGlass";
            this.hourGlassToolStripMenuItem.Click += new System.EventHandler(this.hourGlassToolStripMenuItem_Click);
            // 
            // handPointToolStripMenuItem
            // 
            this.handPointToolStripMenuItem.Name = "handPointToolStripMenuItem";
            this.handPointToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.handPointToolStripMenuItem.Text = "Hand&Point";
            this.handPointToolStripMenuItem.Click += new System.EventHandler(this.handPointToolStripMenuItem_Click);
            // 
            // формыToolStripMenuItem
            // 
            this.формыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.модальнаяToolStripMenuItem,
            this.toolStripMenuItem2,
            this.MIClose});
            this.формыToolStripMenuItem.Name = "формыToolStripMenuItem";
            this.формыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.формыToolStripMenuItem.Text = "&Формы";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem3.Text = "&Параллельная";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // модальнаяToolStripMenuItem
            // 
            this.модальнаяToolStripMenuItem.Name = "модальнаяToolStripMenuItem";
            this.модальнаяToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.модальнаяToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.модальнаяToolStripMenuItem.Text = "&Модальная";
            this.модальнаяToolStripMenuItem.Click += new System.EventHandler(this.модальнаяToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(200, 6);
            // 
            // MIClose
            // 
            this.MIClose.Checked = true;
            this.MIClose.CheckOnClick = true;
            this.MIClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MIClose.Name = "MIClose";
            this.MIClose.Size = new System.Drawing.Size(203, 22);
            this.MIClose.Text = "&Запрос при закрытии";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Пример использования меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem прогрессToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem увеличитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уменьшитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem увеличитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem уменьшитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem курсорToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hourGlassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handPointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem формыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem модальнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MIClose;
    }
}

