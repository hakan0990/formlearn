namespace Variable.cs
{
    partial class Form4
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
            button1 = new Button();
            sayı1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(128, 286);
            button1.Name = "button1";
            button1.Size = new Size(380, 89);
            button1.TabIndex = 0;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sayı1
            // 
            sayı1.AutoSize = true;
            sayı1.Location = new Point(128, 95);
            sayı1.Name = "sayı1";
            sayı1.Size = new Size(68, 28);
            sayı1.TabIndex = 1;
            sayı1.Text = "Sayı 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 146);
            label2.Name = "label2";
            label2.Size = new Size(68, 28);
            label2.TabIndex = 2;
            label2.Text = "Sayı 2:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(217, 87);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 36);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(217, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(190, 36);
            textBox2.TabIndex = 4;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(885, 586);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(sayı1);
            Controls.Add(button1);
            Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 6, 4, 6);
            Name = "Form4";
            Text = "4 işlem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label sayı1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}