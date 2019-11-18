namespace Test_1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.rich1 = new System.Windows.Forms.RichTextBox();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.rich2 = new System.Windows.Forms.RichTextBox();
            this.clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Узнать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rich1
            // 
            this.rich1.Location = new System.Drawing.Point(135, 9);
            this.rich1.Name = "rich1";
            this.rich1.ReadOnly = true;
            this.rich1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rich1.Size = new System.Drawing.Size(65, 179);
            this.rich1.TabIndex = 2;
            this.rich1.Text = "";
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(15, 28);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(105, 20);
            this.txt_number.TabIndex = 3;
            this.txt_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress);
            // 
            // rich2
            // 
            this.rich2.Location = new System.Drawing.Point(15, 112);
            this.rich2.Name = "rich2";
            this.rich2.ReadOnly = true;
            this.rich2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rich2.Size = new System.Drawing.Size(114, 41);
            this.rich2.TabIndex = 6;
            this.rich2.Text = "";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(15, 159);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(114, 29);
            this.clear.TabIndex = 7;
            this.clear.Text = "Очистить";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ответ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Введите число:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 200);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.rich2);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.rich1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание №1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rich1;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.RichTextBox rich2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

