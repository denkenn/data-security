
namespace ds_lab1
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шифрованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.праваАдминистратораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйАккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрСпискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.change_pass = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.change_user = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.праваАдминистратораToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(507, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.FileToolStripMenuItem.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem,
            this.шифрованиеToolStripMenuItem});
            this.справкаToolStripMenuItem.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // шифрованиеToolStripMenuItem
            // 
            this.шифрованиеToolStripMenuItem.Name = "шифрованиеToolStripMenuItem";
            this.шифрованиеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.шифрованиеToolStripMenuItem.Text = "Шифрование";
            this.шифрованиеToolStripMenuItem.Click += new System.EventHandler(this.шифрованиеToolStripMenuItem_Click);
            // 
            // праваАдминистратораToolStripMenuItem
            // 
            this.праваАдминистратораToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйАккаунтToolStripMenuItem,
            this.просмотрСпискаToolStripMenuItem});
            this.праваАдминистратораToolStripMenuItem.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.праваАдминистратораToolStripMenuItem.Name = "праваАдминистратораToolStripMenuItem";
            this.праваАдминистратораToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.праваАдминистратораToolStripMenuItem.Text = "Права администратора";
            // 
            // новыйАккаунтToolStripMenuItem
            // 
            this.новыйАккаунтToolStripMenuItem.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.новыйАккаунтToolStripMenuItem.Name = "новыйАккаунтToolStripMenuItem";
            this.новыйАккаунтToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.новыйАккаунтToolStripMenuItem.Text = "Новый аккаунт";
            this.новыйАккаунтToolStripMenuItem.Click += new System.EventHandler(this.новыйАккаунтToolStripMenuItem_Click);
            // 
            // просмотрСпискаToolStripMenuItem
            // 
            this.просмотрСпискаToolStripMenuItem.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.просмотрСпискаToolStripMenuItem.Name = "просмотрСпискаToolStripMenuItem";
            this.просмотрСпискаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.просмотрСпискаToolStripMenuItem.Text = "Просмотр списка";
            this.просмотрСпискаToolStripMenuItem.Click += new System.EventHandler(this.просмотрСпискаToolStripMenuItem_Click);
            // 
            // change_pass
            // 
            this.change_pass.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_pass.Location = new System.Drawing.Point(63, 94);
            this.change_pass.Name = "change_pass";
            this.change_pass.Size = new System.Drawing.Size(149, 30);
            this.change_pass.TabIndex = 1;
            this.change_pass.Text = "Сменить пароль";
            this.change_pass.UseVisualStyleBackColor = true;
            this.change_pass.Click += new System.EventHandler(this.change_pass_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(63, 206);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(149, 30);
            this.exit.TabIndex = 5;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // change_user
            // 
            this.change_user.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_user.Location = new System.Drawing.Point(303, 94);
            this.change_user.Name = "change_user";
            this.change_user.Size = new System.Drawing.Size(145, 30);
            this.change_user.TabIndex = 2;
            this.change_user.Text = "Сменить польз.";
            this.change_user.UseVisualStyleBackColor = true;
            this.change_user.Click += new System.EventHandler(this.change_user_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 295);
            this.Controls.Add(this.change_user);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.change_pass);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "Программа";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.main_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button change_pass;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button change_user;
        private System.Windows.Forms.ToolStripMenuItem праваАдминистратораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйАккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрСпискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шифрованиеToolStripMenuItem;
    }
}

