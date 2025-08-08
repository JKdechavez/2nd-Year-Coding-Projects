using System.IO;
namespace Lab21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("textfile.txt"))
            {
                string allText = "";
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    allText += line;
                }
                int wordCount = 0;
                int digitCount = 0;
                int letterCount = 0;
                int specialCharCount = 0;
                bool inWord = false;

                // Loop for counting 
                foreach (char s in allText)
                {
                    if (char.IsLetter(s))
                    {
                        letterCount++;
                        inWord = true;
                    }
                    else if (char.IsDigit(s))
                    {
                        digitCount++;
                        inWord = true;
                    }
                    else if (char.IsWhiteSpace(s))
                    {
                        if (inWord)
                        {
                            wordCount++;
                            inWord = false;
                        }
                    }
                    else
                    {
                        specialCharCount++;
                        if (inWord)
                        {
                            wordCount++;
                            inWord = false;
                        }
                    }
                }

                if (inWord)
                {
                    wordCount++;
                }
                MessageBox.Show(@$"Word count = {wordCount}
Digit count = {digitCount}
Letter count = {letterCount}
Special characters count = {specialCharCount}", "File Counters", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;
            g.DrawRectangle(Pens.Black, new Rectangle(0, 0, width - 1, height - 1));

            // Upper left box
            g.DrawRectangle(Pens.Black, new Rectangle(10, 10, width / 2 - 1, height / 2 - 11));
            g.FillRectangle(Brushes.CornflowerBlue, new Rectangle(11, 11, width / 2 - 2, height / 2 - 12));
            g.FillEllipse(Brushes.ForestGreen, new Rectangle(11, 11, width / 2 - 2, height / 2 - 12));


            // Upper right box
            g.DrawRectangle(Pens.Black, new Rectangle(width / 2 + 9, 10, width / 2 - 20, height / 2 - 11));
            g.FillRectangle(Brushes.ForestGreen, new Rectangle(width / 2 + 10, 11, width / 2 - 21, height / 2 - 12));
            g.FillEllipse(Brushes.CornflowerBlue, new Rectangle(width / 2 + 10, 11, width / 2 - 21, height / 2 - 12));


            // Lower left box
            g.DrawRectangle(Pens.Black, new Rectangle(10, height / 2, width / 2 - 1, height / 2 - 11));
            g.FillRectangle(Brushes.ForestGreen, new Rectangle(11, height / 2, width / 2 - 2, height / 2 - 11));
            g.FillEllipse(Brushes.CornflowerBlue, new Rectangle(11, height / 2, width / 2 - 2, height / 2 - 11));

            // Lower right box
            g.DrawRectangle(Pens.Black, new Rectangle(width / 2 + 9, height / 2, width / 2 - 20, height / 2 - 11));
            g.FillRectangle(Brushes.CornflowerBlue, new Rectangle(width / 2 + 10, height / 2, width / 2 - 21, height / 2 - 11));
            g.FillEllipse(Brushes.ForestGreen, new Rectangle(width / 2 + 10, height / 2, width / 2 - 21, height / 2 - 11));

            g.FillEllipse(Brushes.Red, new Rectangle(width / 2 - 26, height / 2 - 36, 70, 70));
            Point[] diamondPoints = { new Point(width / 2 + 9, 10), new Point(width - 11, height / 2), new Point(width / 2 + 9, height - 11), new Point(10, height / 2) };
            g.DrawPolygon(Pens.Black, diamondPoints);
        }
    }
}