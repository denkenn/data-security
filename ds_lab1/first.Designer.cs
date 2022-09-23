
namespace ds_lab1
{
    partial class first
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(first));
            this.gif = new System.Windows.Forms.PictureBox();
            this.pass2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.error = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gif)).BeginInit();
            this.SuspendLayout();
            // 
            // gif
            // 
            this.gif.Image = ((System.Drawing.Image)(resources.GetObject("gif.Image")));
            this.gif.Location = new System.Drawing.Point(354, 39);
            this.gif.Name = "gif";
            this.gif.Size = new System.Drawing.Size(28, 32);
            this.gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gif.TabIndex = 21;
            this.gif.TabStop = false;
            // 
            // pass2
            // 
            this.pass2.Location = new System.Drawing.Point(194, 141);
            this.pass2.Name = "pass2";
            this.pass2.Size = new System.Drawing.Size(126, 22);
            this.pass2.TabIndex = 20;
            this.pass2.TextChanged += new System.EventHandler(this.pass2_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Повтор пароля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(101, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(111, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Логин";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(194, 96);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(126, 22);
            this.password.TabIndex = 16;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.Window;
            this.login.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.ForeColor = System.Drawing.SystemColors.MenuText;
            this.login.Location = new System.Drawing.Point(194, 46);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(126, 25);
            this.login.TabIndex = 15;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error.Location = new System.Drawing.Point(39, 193);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(368, 18);
            this.error.TabIndex = 22;
            this.error.Text = "Пользователь с таким именем отсуствует в базе";
            // 
            // cancel
            // 
            this.cancel.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel.Location = new System.Drawing.Point(294, 246);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 24;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // accept
            // 
            this.accept.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accept.Location = new System.Drawing.Point(90, 246);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(75, 23);
            this.accept.TabIndex = 23;
            this.accept.Text = "Принять";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // first
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 302);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.error);
            this.Controls.Add(this.gif);
            this.Controls.Add(this.pass2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "first";
            this.Text = "Ввод нового пароля";
            ((System.ComponentModel.ISupportInitialize)(this.gif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gif;
        private System.Windows.Forms.TextBox pass2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button accept;
    }
}