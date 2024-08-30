namespace FlyingButterfly
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
            buttoncreate = new Button();
            SuspendLayout();
            // 
            // buttoncreate
            // 
            buttoncreate.Location = new Point(12, 416);
            buttoncreate.Name = "buttoncreate";
            buttoncreate.Size = new Size(81, 22);
            buttoncreate.TabIndex = 0;
            buttoncreate.Text = "Создать";
            buttoncreate.UseVisualStyleBackColor = true;
            buttoncreate.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 450);
            Controls.Add(buttoncreate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttoncreate;
    }
}
