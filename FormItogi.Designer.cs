namespace Kollok
{
    partial class FormItogi
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
            labelItogi = new Label();
            SuspendLayout();
            // 
            // labelItogi
            // 
            labelItogi.AutoSize = true;
            labelItogi.Font = new Font("Segoe UI", 30F);
            labelItogi.Location = new Point(12, 182);
            labelItogi.Name = "labelItogi";
            labelItogi.Size = new Size(130, 54);
            labelItogi.TabIndex = 0;
            labelItogi.Text = "label1";
            labelItogi.Click += labelItogi_Click;
            // 
            // FormItogi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelItogi);
            Name = "FormItogi";
            Text = "FormItogi";
            Load += FormItogi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelItogi;
    }
}