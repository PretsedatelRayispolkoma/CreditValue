namespace CreditValue
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
            this.TB_credit = new System.Windows.Forms.TextBox();
            this.TB_days = new System.Windows.Forms.TextBox();
            this.TB_amount_result = new System.Windows.Forms.TextBox();
            this.create_b = new System.Windows.Forms.Button();
            this.TB_ppd = new System.Windows.Forms.TextBox();
            this.TB_effValue = new System.Windows.Forms.TextBox();
            this.TB_percent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB_credit
            // 
            this.TB_credit.Location = new System.Drawing.Point(74, 52);
            this.TB_credit.Name = "TB_credit";
            this.TB_credit.Size = new System.Drawing.Size(100, 20);
            this.TB_credit.TabIndex = 0;
            // 
            // TB_days
            // 
            this.TB_days.Location = new System.Drawing.Point(180, 52);
            this.TB_days.Name = "TB_days";
            this.TB_days.Size = new System.Drawing.Size(100, 20);
            this.TB_days.TabIndex = 1;
            // 
            // TB_amount_result
            // 
            this.TB_amount_result.Location = new System.Drawing.Point(74, 141);
            this.TB_amount_result.Name = "TB_amount_result";
            this.TB_amount_result.Size = new System.Drawing.Size(256, 20);
            this.TB_amount_result.TabIndex = 2;
            // 
            // create_b
            // 
            this.create_b.Location = new System.Drawing.Point(163, 269);
            this.create_b.Name = "create_b";
            this.create_b.Size = new System.Drawing.Size(75, 23);
            this.create_b.TabIndex = 3;
            this.create_b.Text = "Create";
            this.create_b.UseVisualStyleBackColor = true;
            this.create_b.Click += new System.EventHandler(this.create_b_Click);
            // 
            // TB_ppd
            // 
            this.TB_ppd.Location = new System.Drawing.Point(74, 168);
            this.TB_ppd.Name = "TB_ppd";
            this.TB_ppd.Size = new System.Drawing.Size(256, 20);
            this.TB_ppd.TabIndex = 4;
            // 
            // TB_effValue
            // 
            this.TB_effValue.Location = new System.Drawing.Point(74, 194);
            this.TB_effValue.Name = "TB_effValue";
            this.TB_effValue.Size = new System.Drawing.Size(256, 20);
            this.TB_effValue.TabIndex = 5;
            // 
            // TB_percent
            // 
            this.TB_percent.Location = new System.Drawing.Point(286, 52);
            this.TB_percent.Name = "TB_percent";
            this.TB_percent.Size = new System.Drawing.Size(100, 20);
            this.TB_percent.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB_percent);
            this.Controls.Add(this.TB_effValue);
            this.Controls.Add(this.TB_ppd);
            this.Controls.Add(this.create_b);
            this.Controls.Add(this.TB_amount_result);
            this.Controls.Add(this.TB_days);
            this.Controls.Add(this.TB_credit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_credit;
        private System.Windows.Forms.TextBox TB_days;
        private System.Windows.Forms.TextBox TB_amount_result;
        private System.Windows.Forms.Button create_b;
        private System.Windows.Forms.TextBox TB_ppd;
        private System.Windows.Forms.TextBox TB_effValue;
        private System.Windows.Forms.TextBox TB_percent;
    }
}

