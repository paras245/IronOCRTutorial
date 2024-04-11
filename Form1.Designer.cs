namespace IronOCRTutorial
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            ImagePath = new TextBox();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(218, 47);
            label1.Name = "label1";
            label1.Size = new Size(291, 19);
            label1.TabIndex = 0;
            label1.Text = "Extracting Text From The Image Using IronOcr";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(98, 97);
            button1.Name = "button1";
            button1.Size = new Size(141, 23);
            button1.TabIndex = 1;
            button1.Text = "Select Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(474, 100);
            button2.Name = "button2";
            button2.Size = new Size(135, 23);
            button2.TabIndex = 2;
            button2.Text = "Convert To Text";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ImagePath
            // 
            ImagePath.Location = new Point(60, 133);
            ImagePath.Name = "ImagePath";
            ImagePath.Size = new Size(206, 23);
            ImagePath.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(60, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 180);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(353, 175);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(378, 180);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(ImagePath);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Extracting Text From The Image Using IronOcr";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private TextBox ImagePath;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
    }
}
