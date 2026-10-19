namespace zadanie
{
    partial class Task4Form
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
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnChange1 = new System.Windows.Forms.Button();
            this.btnChange2 = new System.Windows.Forms.Button();
            this.btnChange3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(214, 138);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(341, 92);
            this.txtSource.TabIndex = 0;
            // 
            // btnChange1
            // 
            this.btnChange1.Location = new System.Drawing.Point(137, 298);
            this.btnChange1.Name = "btnChange1";
            this.btnChange1.Size = new System.Drawing.Size(117, 43);
            this.btnChange1.TabIndex = 1;
            this.btnChange1.Text = "кнопка 1";
            this.btnChange1.UseVisualStyleBackColor = true;
            this.btnChange1.Click += new System.EventHandler(this.btnChange1_Click);
            // 
            // btnChange2
            // 
            this.btnChange2.Location = new System.Drawing.Point(356, 298);
            this.btnChange2.Name = "btnChange2";
            this.btnChange2.Size = new System.Drawing.Size(110, 43);
            this.btnChange2.TabIndex = 2;
            this.btnChange2.Text = "кнопка 2";
            this.btnChange2.UseVisualStyleBackColor = true;
            this.btnChange2.Click += new System.EventHandler(this.btnChange2_Click);
            // 
            // btnChange3
            // 
            this.btnChange3.Location = new System.Drawing.Point(545, 298);
            this.btnChange3.Name = "btnChange3";
            this.btnChange3.Size = new System.Drawing.Size(111, 43);
            this.btnChange3.TabIndex = 3;
            this.btnChange3.Text = "кнопка 3";
            this.btnChange3.UseVisualStyleBackColor = true;
            this.btnChange3.Click += new System.EventHandler(this.btnChange3_Click);
            // 
            // Task4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChange3);
            this.Controls.Add(this.btnChange2);
            this.Controls.Add(this.btnChange1);
            this.Controls.Add(this.txtSource);
            this.Name = "Task4Form";
            this.Text = "Задание 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnChange1;
        private System.Windows.Forms.Button btnChange2;
        private System.Windows.Forms.Button btnChange3;
    }
}