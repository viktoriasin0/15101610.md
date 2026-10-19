namespace zadanie
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
            this.btnTask1 = new System.Windows.Forms.Button();
            this.btnTask2 = new System.Windows.Forms.Button();
            this.btnTask3 = new System.Windows.Forms.Button();
            this.btnTask4 = new System.Windows.Forms.Button();
            this.btnTask5 = new System.Windows.Forms.Button();
            this.btnTask6 = new System.Windows.Forms.Button();
            this.btnTask7 = new System.Windows.Forms.Button();
            this.btnTask8v1 = new System.Windows.Forms.Button();
            this.btnTask8v2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTask1
            // 
            this.btnTask1.Location = new System.Drawing.Point(43, 27);
            this.btnTask1.Name = "btnTask1";
            this.btnTask1.Size = new System.Drawing.Size(140, 52);
            this.btnTask1.TabIndex = 0;
            this.btnTask1.Text = "задание 1";
            this.btnTask1.UseVisualStyleBackColor = true;
            this.btnTask1.Click += new System.EventHandler(this.btnTask1_Click);
            // 
            // btnTask2
            // 
            this.btnTask2.Location = new System.Drawing.Point(43, 85);
            this.btnTask2.Name = "btnTask2";
            this.btnTask2.Size = new System.Drawing.Size(140, 52);
            this.btnTask2.TabIndex = 1;
            this.btnTask2.Text = "задание 2";
            this.btnTask2.UseVisualStyleBackColor = true;
            this.btnTask2.Click += new System.EventHandler(this.btnTask2_Click);
            // 
            // btnTask3
            // 
            this.btnTask3.Location = new System.Drawing.Point(43, 143);
            this.btnTask3.Name = "btnTask3";
            this.btnTask3.Size = new System.Drawing.Size(140, 52);
            this.btnTask3.TabIndex = 2;
            this.btnTask3.Text = "задание 3";
            this.btnTask3.UseVisualStyleBackColor = true;
            this.btnTask3.Click += new System.EventHandler(this.btnTask3_Click);
            // 
            // btnTask4
            // 
            this.btnTask4.Location = new System.Drawing.Point(43, 201);
            this.btnTask4.Name = "btnTask4";
            this.btnTask4.Size = new System.Drawing.Size(140, 52);
            this.btnTask4.TabIndex = 3;
            this.btnTask4.Text = "задание 4";
            this.btnTask4.UseVisualStyleBackColor = true;
            this.btnTask4.Click += new System.EventHandler(this.btnTask4_Click);
            // 
            // btnTask5
            // 
            this.btnTask5.Location = new System.Drawing.Point(43, 259);
            this.btnTask5.Name = "btnTask5";
            this.btnTask5.Size = new System.Drawing.Size(140, 52);
            this.btnTask5.TabIndex = 4;
            this.btnTask5.Text = "задание 5";
            this.btnTask5.UseVisualStyleBackColor = true;
            this.btnTask5.Click += new System.EventHandler(this.btnTask5_Click);
            // 
            // btnTask6
            // 
            this.btnTask6.Location = new System.Drawing.Point(43, 321);
            this.btnTask6.Name = "btnTask6";
            this.btnTask6.Size = new System.Drawing.Size(140, 52);
            this.btnTask6.TabIndex = 5;
            this.btnTask6.Text = "задание 6";
            this.btnTask6.UseVisualStyleBackColor = true;
            this.btnTask6.Click += new System.EventHandler(this.btnTask6_Click);
            // 
            // btnTask7
            // 
            this.btnTask7.Location = new System.Drawing.Point(255, 27);
            this.btnTask7.Name = "btnTask7";
            this.btnTask7.Size = new System.Drawing.Size(140, 52);
            this.btnTask7.TabIndex = 6;
            this.btnTask7.Text = "задание 7";
            this.btnTask7.UseVisualStyleBackColor = true;
            this.btnTask7.Click += new System.EventHandler(this.btnTask7_Click);
            // 
            // btnTask8v1
            // 
            this.btnTask8v1.Location = new System.Drawing.Point(255, 85);
            this.btnTask8v1.Name = "btnTask8v1";
            this.btnTask8v1.Size = new System.Drawing.Size(140, 52);
            this.btnTask8v1.TabIndex = 7;
            this.btnTask8v1.Text = "задание 8";
            this.btnTask8v1.UseVisualStyleBackColor = true;
            this.btnTask8v1.Click += new System.EventHandler(this.btnTask8v1_Click);
            // 
            // btnTask8v2
            // 
            this.btnTask8v2.Location = new System.Drawing.Point(255, 143);
            this.btnTask8v2.Name = "btnTask8v2";
            this.btnTask8v2.Size = new System.Drawing.Size(140, 52);
            this.btnTask8v2.TabIndex = 8;
            this.btnTask8v2.Text = "задание 8.2";
            this.btnTask8v2.UseVisualStyleBackColor = true;
            this.btnTask8v2.Click += new System.EventHandler(this.btnTask8v2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 407);
            this.Controls.Add(this.btnTask8v2);
            this.Controls.Add(this.btnTask8v1);
            this.Controls.Add(this.btnTask7);
            this.Controls.Add(this.btnTask6);
            this.Controls.Add(this.btnTask5);
            this.Controls.Add(this.btnTask4);
            this.Controls.Add(this.btnTask3);
            this.Controls.Add(this.btnTask2);
            this.Controls.Add(this.btnTask1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор задания";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTask1;
        private System.Windows.Forms.Button btnTask2;
        private System.Windows.Forms.Button btnTask3;
        private System.Windows.Forms.Button btnTask4;
        private System.Windows.Forms.Button btnTask5;
        private System.Windows.Forms.Button btnTask6;
        private System.Windows.Forms.Button btnTask7;
        private System.Windows.Forms.Button btnTask8v1;
        private System.Windows.Forms.Button btnTask8v2;
    }
}

