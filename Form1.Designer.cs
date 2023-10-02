
namespace BookShop_HAU_KSV
{
    partial class FormLogin_HAU_KSV
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
            this.ViewProdBut = new System.Windows.Forms.Button();
            this.LogBut = new System.Windows.Forms.Button();
            this.SignBut = new System.Windows.Forms.Button();
            this.TB_Login = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ViewProdBut
            // 
            this.ViewProdBut.Location = new System.Drawing.Point(92, 24);
            this.ViewProdBut.Name = "ViewProdBut";
            this.ViewProdBut.Size = new System.Drawing.Size(183, 23);
            this.ViewProdBut.TabIndex = 0;
            this.ViewProdBut.Text = "Просмотр товаров";
            this.ViewProdBut.UseVisualStyleBackColor = true;
            this.ViewProdBut.Click += new System.EventHandler(this.ViewProdBut_Click);
            // 
            // LogBut
            // 
            this.LogBut.Location = new System.Drawing.Point(148, 302);
            this.LogBut.Name = "LogBut";
            this.LogBut.Size = new System.Drawing.Size(75, 23);
            this.LogBut.TabIndex = 1;
            this.LogBut.Text = "Вход";
            this.LogBut.UseVisualStyleBackColor = true;
            // 
            // SignBut
            // 
            this.SignBut.Location = new System.Drawing.Point(140, 331);
            this.SignBut.Name = "SignBut";
            this.SignBut.Size = new System.Drawing.Size(89, 23);
            this.SignBut.TabIndex = 2;
            this.SignBut.Text = "Регистрация";
            this.SignBut.UseVisualStyleBackColor = true;
            // 
            // TB_Login
            // 
            this.TB_Login.Location = new System.Drawing.Point(92, 130);
            this.TB_Login.Name = "TB_Login";
            this.TB_Login.Size = new System.Drawing.Size(183, 20);
            this.TB_Login.TabIndex = 3;
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(92, 226);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(183, 20);
            this.TB_Password.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пароль";
            // 
            // FormLogin_HAU_KSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 376);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Login);
            this.Controls.Add(this.SignBut);
            this.Controls.Add(this.LogBut);
            this.Controls.Add(this.ViewProdBut);
            this.Name = "FormLogin_HAU_KSV";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ViewProdBut;
        private System.Windows.Forms.Button LogBut;
        private System.Windows.Forms.Button SignBut;
        private System.Windows.Forms.TextBox TB_Login;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

