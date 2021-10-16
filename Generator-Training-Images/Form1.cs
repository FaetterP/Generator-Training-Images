using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator_Training_Images
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap image;
        Random rnd = new Random();

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
    }
}
