namespace Kollok
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxReady = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            listBoxWant = new ListBox();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // listBoxReady
            // 
            listBoxReady.FormattingEnabled = true;
            listBoxReady.ItemHeight = 15;
            listBoxReady.Location = new Point(12, 12);
            listBoxReady.Name = "listBoxReady";
            listBoxReady.Size = new Size(120, 199);
            listBoxReady.TabIndex = 0;
            listBoxReady.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(356, 134);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(356, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(184, 23);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 12);
            label1.Name = "label1";
            label1.Size = new Size(184, 15);
            label1.TabIndex = 3;
            label1.Text = "Требуемая длина в сантиметрах";
            // 
            // listBoxWant
            // 
            listBoxWant.FormattingEnabled = true;
            listBoxWant.ItemHeight = 15;
            listBoxWant.Location = new Point(215, 12);
            listBoxWant.Name = "listBoxWant";
            listBoxWant.Size = new Size(120, 199);
            listBoxWant.TabIndex = 4;
            listBoxWant.SelectedIndexChanged += listBoxWant_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(356, 75);
            label2.Name = "label2";
            label2.Size = new Size(153, 15);
            label2.TabIndex = 5;
            label2.Text = "Требуемая длина в метрах";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(356, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(184, 23);
            textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(listBoxWant);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listBoxReady);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxReady;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private ListBox listBoxWant;
        private Label label2;
        private TextBox textBox2;
    }
}
