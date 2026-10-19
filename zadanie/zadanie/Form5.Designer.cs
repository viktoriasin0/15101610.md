namespace zadanie
{
    partial class Task5Form
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
            this.btnShow1 = new System.Windows.Forms.Button();
            this.btnShow2 = new System.Windows.Forms.Button();
            this.btnShow3 = new System.Windows.Forms.Button();
            this.lblMsg1 = new System.Windows.Forms.Label();
            this.lblMsg2 = new System.Windows.Forms.Label();
            this.lblMsg3 = new System.Windows.Forms.Label();
            this.btnShow4 = new System.Windows.Forms.Button();
            this.lblMsg4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShow1
            // 
            this.btnShow1.Location = new System.Drawing.Point(61, 61);
            this.btnShow1.Name = "btnShow1";
            this.btnShow1.Size = new System.Drawing.Size(133, 50);
            this.btnShow1.TabIndex = 0;
            this.btnShow1.Text = "кнопка 1";
            this.btnShow1.UseVisualStyleBackColor = true;
            this.btnShow1.Click += new System.EventHandler(this.btnShow1_Click);
            // 
            // btnShow2
            // 
            this.btnShow2.Location = new System.Drawing.Point(61, 160);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(133, 55);
            this.btnShow2.TabIndex = 1;
            this.btnShow2.Text = "кнопка 2";
            this.btnShow2.UseVisualStyleBackColor = true;
            this.btnShow2.Click += new System.EventHandler(this.btnShow2_Click);
            // 
            // btnShow3
            // 
            this.btnShow3.Location = new System.Drawing.Point(61, 264);
            this.btnShow3.Name = "btnShow3";
            this.btnShow3.Size = new System.Drawing.Size(133, 49);
            this.btnShow3.TabIndex = 2;
            this.btnShow3.Text = "кнопка 3";
            this.btnShow3.UseVisualStyleBackColor = true;
            this.btnShow3.Click += new System.EventHandler(this.btnShow3_Click);
            // 
            // lblMsg1
            // 
            this.lblMsg1.AutoSize = true;
            this.lblMsg1.Location = new System.Drawing.Point(264, 78);
            this.lblMsg1.Name = "lblMsg1";
            this.lblMsg1.Size = new System.Drawing.Size(250, 16);
            this.lblMsg1.TabIndex = 3;
            this.lblMsg1.Text = "текст виден при нажатии на кнопку 1";
            // 
            // lblMsg2
            // 
            this.lblMsg2.AutoSize = true;
            this.lblMsg2.Location = new System.Drawing.Point(264, 179);
            this.lblMsg2.Name = "lblMsg2";
            this.lblMsg2.Size = new System.Drawing.Size(250, 16);
            this.lblMsg2.TabIndex = 4;
            this.lblMsg2.Text = "текст виден при нажатии на кнопку 2";
            // 
            // lblMsg3
            // 
            this.lblMsg3.AutoSize = true;
            this.lblMsg3.Location = new System.Drawing.Point(264, 280);
            this.lblMsg3.Name = "lblMsg3";
            this.lblMsg3.Size = new System.Drawing.Size(250, 16);
            this.lblMsg3.TabIndex = 5;
            this.lblMsg3.Text = "текст виден при нажатии на кнопку 3";
            // 
            // btnShow4
            // 
            this.btnShow4.Location = new System.Drawing.Point(61, 357);
            this.btnShow4.Name = "btnShow4";
            this.btnShow4.Size = new System.Drawing.Size(133, 49);
            this.btnShow4.TabIndex = 6;
            this.btnShow4.Text = "кнопка 4";
            this.btnShow4.UseVisualStyleBackColor = true;
            this.btnShow4.Click += new System.EventHandler(this.btnShow4_Click);
            // 
            // lblMsg4
            // 
            this.lblMsg4.AutoSize = true;
            this.lblMsg4.Location = new System.Drawing.Point(264, 373);
            this.lblMsg4.Name = "lblMsg4";
            this.lblMsg4.Size = new System.Drawing.Size(250, 16);
            this.lblMsg4.TabIndex = 7;
            this.lblMsg4.Text = "текст виден при нажатии на кнопку 4";
            // 
            // Task5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMsg4);
            this.Controls.Add(this.btnShow4);
            this.Controls.Add(this.lblMsg3);
            this.Controls.Add(this.lblMsg2);
            this.Controls.Add(this.lblMsg1);
            this.Controls.Add(this.btnShow3);
            this.Controls.Add(this.btnShow2);
            this.Controls.Add(this.btnShow1);
            this.Name = "Task5Form";
            this.Text = "Задание 5";
            this.Load += new System.EventHandler(this.Task5Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShow1;
        private System.Windows.Forms.Button btnShow2;
        private System.Windows.Forms.Button btnShow3;
        private System.Windows.Forms.Label lblMsg1;
        private System.Windows.Forms.Label lblMsg2;
        private System.Windows.Forms.Label lblMsg3;
        private System.Windows.Forms.Button btnShow4;
        private System.Windows.Forms.Label lblMsg4;
    }
}