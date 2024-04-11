using IronOcr;

namespace IronOCRTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                ImagePath.Text = open.FileName;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IronTesseract IronOcr = new IronTesseract();
            var Result = IronOcr.Read(ImagePath.Text);
            richTextBox1.Text = Result.Text;

        }
    }
}
