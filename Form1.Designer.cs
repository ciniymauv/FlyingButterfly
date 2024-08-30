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
            pictureBox = new PictureBox();
            buttoncreate = new Button();
            buttonright = new Button();
            buttondown = new Button();
            buttonleft = new Button();
            buttonup = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox.Location = new Point(-2, -1);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(733, 449);
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            // 
            // buttoncreate
            // 
            buttoncreate.Location = new Point(12, 415);
            buttoncreate.Name = "buttoncreate";
            buttoncreate.Size = new Size(75, 23);
            buttoncreate.TabIndex = 5;
            buttoncreate.Text = "Создать";
            buttoncreate.UseVisualStyleBackColor = true;
            // 
            // buttonright
            // 
            buttonright.BackgroundImage = Properties.Resources.rightbutton;
            buttonright.BackgroundImageLayout = ImageLayout.Stretch;
            buttonright.Location = new Point(667, 388);
            buttonright.Name = "buttonright";
            buttonright.Size = new Size(50, 50);
            buttonright.TabIndex = 6;
            buttonright.UseVisualStyleBackColor = true;
            // 
            // buttondown
            // 
            buttondown.BackgroundImage = Properties.Resources.downbutton;
            buttondown.BackgroundImageLayout = ImageLayout.Stretch;
            buttondown.Location = new Point(611, 388);
            buttondown.Name = "buttondown";
            buttondown.Size = new Size(50, 50);
            buttondown.TabIndex = 7;
            buttondown.UseVisualStyleBackColor = true;
            // 
            // buttonleft
            // 
            buttonleft.BackgroundImage = Properties.Resources.leftbutton;
            buttonleft.BackgroundImageLayout = ImageLayout.Stretch;
            buttonleft.Location = new Point(555, 388);
            buttonleft.Name = "buttonleft";
            buttonleft.Size = new Size(50, 50);
            buttonleft.TabIndex = 8;
            buttonleft.UseVisualStyleBackColor = true;
            // 
            // buttonup
            // 
            buttonup.BackgroundImage = Properties.Resources.upbutton;
            buttonup.BackgroundImageLayout = ImageLayout.Stretch;
            buttonup.Location = new Point(611, 332);
            buttonup.Name = "buttonup";
            buttonup.Size = new Size(50, 50);
            buttonup.TabIndex = 9;
            buttonup.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 450);
            Controls.Add(buttonup);
            Controls.Add(buttonleft);
            Controls.Add(buttondown);
            Controls.Add(buttonright);
            Controls.Add(buttoncreate);
            Controls.Add(pictureBox);
            Name = "Form1";
            Text = "Бабочка";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox;
        private Button buttoncreate;
        private Button buttonright;
        private Button buttondown;
        private Button buttonleft;
        private Button buttonup;
    }
}
