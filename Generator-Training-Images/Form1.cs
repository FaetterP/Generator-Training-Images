using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Generator_Training_Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Bitmap image;
        private Random rnd = new Random();
        private string path;
        private int count = 0;

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            PrintNextPicture();
        }

        private void SkipButton_Click(object sender, EventArgs e)
        {
            PrintNextPicture();
        }

        private void PrintNextPicture()
        {
            SmallPictureBox.Image = new Bitmap(8, 8);
            BigPictureBox.Image = new Bitmap(120, 120);

            int start_x = rnd.Next(image.Size.Width - 8);
            int start_y = rnd.Next(image.Size.Height - 8);
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    ((Bitmap)SmallPictureBox.Image).SetPixel(i, j, image.GetPixel(start_x + i, start_y + j));
                }
            }

            for (int i = 0; i < 96; i++)
            {
                for (int j = 0; j < 96; j++)
                {
                    ((Bitmap)BigPictureBox.Image).SetPixel(i, j, image.GetPixel(start_x + (i / 12), start_y + (j / 12)));
                }
            }
        }

        private void ChooseFolderButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.SelectedPath + "\\";
                PathLabel.Text = path;
            }
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            Inflate(new int[] { 1, 7, 6, 2 }, false, RotateFlipType.Rotate90FlipX);
            PrintNextPicture();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            Inflate(new int[] { 6, 2, 1, 7 }, false, RotateFlipType.Rotate90FlipX);
            PrintNextPicture();
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            Inflate(new int[] { 2, 1, 7, 6 }, true, RotateFlipType.Rotate90FlipX);
            PrintNextPicture();
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            Inflate(new int[] { 7, 6, 2, 1 }, true, RotateFlipType.Rotate90FlipX);
            PrintNextPicture();
        }

        private void UpLeftButton_Click(object sender, EventArgs e)
        {
            Inflate(new int[] { 4, 3, 9, 8 }, false, RotateFlipType.Rotate180FlipX);
            PrintNextPicture();
        }

        private void UpRightButton_Click(object sender, EventArgs e)
        {
            Inflate(new int[] { 3, 9, 8, 4 }, true, RotateFlipType.Rotate180FlipX);
            PrintNextPicture();
        }

        private void DownLeftButton_Click(object sender, EventArgs e)
        {
            Inflate(new int[] { 8, 4, 3, 9 }, true, RotateFlipType.Rotate180FlipX);
            PrintNextPicture();
        }

        private void DownRightButton_Click(object sender, EventArgs e)
        {
            Inflate(new int[] { 9, 8, 4, 3 }, false, RotateFlipType.Rotate180FlipX);
            PrintNextPicture();
        }

        private void BlackButton_Click(object sender, EventArgs e)
        {
            Inflate(new int[] { 5, 5, 5, 5 }, false, RotateFlipType.Rotate90FlipX);
            PrintNextPicture();
        }

        private void WhiteButton_Click(object sender, EventArgs e)
        {
            Inflate(new int[] { 10, 10, 10, 10 }, false, RotateFlipType.Rotate90FlipX);
            PrintNextPicture();
        }

        /*
         * 1 - up
         * 2 - left
         * 3 - up right
         * 4 - up left
         * 5 - black
         * 6 - down
         * 7 - right
         * 8 - down left
         * 9 - down right
         * 10 - white
         */

        private void Inflate(int[] numbers, bool isNeedNegative, RotateFlipType rotateFlipType)
        {
            Image toSaveImage = SmallPictureBox.Image;

            string name = count + GetName(numbers[0]) + ".jpg";
            toSaveImage.Save(path + name, ImageFormat.Jpeg);
            count++;

            toSaveImage = GetNegative(toSaveImage);
            name = count + GetName(numbers[0] > 5 ? numbers[0] - 5 : numbers[0] + 5) + ".jpg";
            toSaveImage.Save(path + name, ImageFormat.Jpeg);
            count++;
            toSaveImage = GetNegative(toSaveImage);

            //------------------------------------------------

            toSaveImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            name = count + GetName(numbers[1]) + ".jpg";
            toSaveImage.Save(path + name, ImageFormat.Jpeg);
            count++;

            toSaveImage = GetNegative(toSaveImage);
            name = count + GetName(numbers[1] > 5 ? numbers[1] - 5 : numbers[1] + 5) + ".jpg";
            toSaveImage.Save(path + name, ImageFormat.Jpeg);
            count++;
            toSaveImage = GetNegative(toSaveImage);

            //------------------------------------------------

            toSaveImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            name = count + GetName(numbers[2]) + ".jpg";
            toSaveImage.Save(path + name, ImageFormat.Jpeg);
            count++;

            toSaveImage = GetNegative(toSaveImage);
            name = count + GetName(numbers[2] > 5 ? numbers[2] - 5 : numbers[2] + 5) + ".jpg";
            toSaveImage.Save(path + name, ImageFormat.Jpeg);
            count++;
            toSaveImage = GetNegative(toSaveImage);

            //------------------------------------------------

            toSaveImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            name = count + GetName(numbers[3]) + ".jpg";
            toSaveImage.Save(path + name, ImageFormat.Jpeg);
            count++;

            toSaveImage = GetNegative(toSaveImage);
            name = count + GetName(numbers[3] > 5 ? numbers[3] - 5 : numbers[3] + 5) + ".jpg";
            toSaveImage.Save(path + name, ImageFormat.Jpeg);
            count++;
            toSaveImage = GetNegative(toSaveImage);

            //------------------------------------------------

            toSaveImage.RotateFlip(rotateFlipType);
            if (isNeedNegative)
                toSaveImage = GetNegative(toSaveImage);

            //------------------------------------------------

            name = count + GetName(numbers[0]) + ".jpg";
            toSaveImage.Save(path + name, ImageFormat.Jpeg);
            count++;

            toSaveImage = GetNegative(toSaveImage);
            name = count + GetName(numbers[0] > 5 ? numbers[0] - 5 : numbers[0] + 5) + ".jpg";
            toSaveImage.Save(path + name, ImageFormat.Jpeg);
            count++;
            toSaveImage = GetNegative(toSaveImage);

            //------------------------------------------------

            toSaveImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            name = count + GetName(numbers[1]) + ".jpg";
            toSaveImage.Save(path + name, ImageFormat.Jpeg);
            count++;

            toSaveImage = GetNegative(toSaveImage);
            name = count + GetName(numbers[1] > 5 ? numbers[1] - 5 : numbers[1] + 5) + ".jpg";
            toSaveImage.Save(path + name, ImageFormat.Jpeg);
            count++;
            toSaveImage = GetNegative(toSaveImage);

            //------------------------------------------------

            toSaveImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            name = count + GetName(numbers[2]) + ".jpg";
            toSaveImage.Save(path + name, ImageFormat.Jpeg);
            count++;

            toSaveImage = GetNegative(toSaveImage);
            name = count + GetName(numbers[2] > 5 ? numbers[2] - 5 : numbers[2] + 5) + ".jpg";
            toSaveImage.Save(path + name, ImageFormat.Jpeg);
            count++;
            toSaveImage = GetNegative(toSaveImage);

            //------------------------------------------------

            toSaveImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            name = count + GetName(numbers[3]) + ".jpg";
            toSaveImage.Save(path + name, ImageFormat.Jpeg);
            count++;

            toSaveImage = GetNegative(toSaveImage);
            name = count + GetName(numbers[3] > 5 ? numbers[3] - 5 : numbers[3] + 5) + ".jpg";
            toSaveImage.Save(path + name, ImageFormat.Jpeg);
            count++;
            toSaveImage = GetNegative(toSaveImage);
        }

        private Bitmap GetNegative(Image img)
        {
            Bitmap b = (Bitmap)img;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Color pixel = b.GetPixel(i, j);
                    Color newcol = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    b.SetPixel(i, j, newcol);
                }
            }
            return b;
        }

        private string GetName(int number)
        {
            string ret = "";
            for (int i = 1; i <= 10; i++)
            {
                ret += (i == number) ? " 1" : " 0";
            }
            return ret;
        }
    }
}
