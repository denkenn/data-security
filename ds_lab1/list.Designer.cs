
namespace ds_lab1
{
    partial class list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list));
            this.label1 = new System.Windows.Forms.Label();
            this.name_text = new System.Windows.Forms.TextBox();
            this.blocked = new System.Windows.Forms.CheckBox();
            this.bounded = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.ahead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя пользователя";
            // 
            // name_text
            // 
            this.name_text.Enabled = false;
            this.name_text.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_text.Location = new System.Drawing.Point(201, 78);
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(110, 25);
            this.name_text.TabIndex = 1;
            // 
            // blocked
            // 
            this.blocked.AutoSize = true;
            this.blocked.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blocked.Location = new System.Drawing.Point(201, 128);
            this.blocked.Name = "blocked";
            this.blocked.Size = new System.Drawing.Size(110, 22);
            this.blocked.TabIndex = 2;
            this.blocked.Text = "Блокировка";
            this.blocked.UseVisualStyleBackColor = true;
            this.blocked.CheckedChanged += new System.EventHandler(this.blocked_CheckedChanged_1);
            // 
            // bounded
            // 
            this.bounded.AutoSize = true;
            this.bounded.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bounded.Location = new System.Drawing.Point(201, 167);
            this.bounded.Name = "bounded";
            this.bounded.Size = new System.Drawing.Size(198, 22);
            this.bounded.TabIndex = 3;
            this.bounded.Text = "Ограничение на пароль";
            this.bounded.UseVisualStyleBackColor = true;
            this.bounded.CheckedChanged += new System.EventHandler(this.bounded_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("JetBrains Mono", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(59, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("JetBrains Mono Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(331, 79);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(22, 23);
            this.back.TabIndex = 6;
            this.back.Text = "<";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // ahead
            // 
            this.ahead.Font = new System.Drawing.Font("JetBrains Mono Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ahead.Location = new System.Drawing.Point(359, 79);
            this.ahead.Name = "ahead";
            this.ahead.Size = new System.Drawing.Size(22, 23);
            this.ahead.TabIndex = 7;
            this.ahead.Text = ">";
            this.ahead.UseVisualStyleBackColor = true;
            this.ahead.Click += new System.EventHandler(this.ahead_Click);
            // 
            // list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 308);
            this.Controls.Add(this.ahead);
            this.Controls.Add(this.back);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bounded);
            this.Controls.Add(this.blocked);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "list";
            this.Text = "Список пользователей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.CheckBox blocked;
        private System.Windows.Forms.CheckBox bounded;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button ahead;
    }
}