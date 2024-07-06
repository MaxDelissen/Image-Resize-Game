using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ImageResizeForm
{
    public partial class Main : Form
    {
        private List<Image> _images = new List<Image>();
        private int _currentImageIndex;
        private float _originalLabelTextSize;

        public Main()
        {
            InitializeComponent();
            SetupForm();
        }

        #region Button Event Handlers

        private void UploadButton_Click(object sender, EventArgs e)
        {
            string imagePath = ShowUploadDialog();
            if (imagePath == null) return;

            _images = ImageLoader.CreateImages(imagePath);
            _images.Reverse(); //Start with the smallest image
            UpdateImageDisplay(0);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (_currentImageIndex < _images.Count - 1)
                UpdateImageDisplay(++_currentImageIndex);
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (_currentImageIndex > 0)
                UpdateImageDisplay(--_currentImageIndex);
        }

        #endregion

        private void SetupForm()
        {
            Size currentSize = this.Size;
            this.MinimumSize = this.MaximumSize = currentSize;
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;

            _originalLabelTextSize = label1.Font.SizeInPoints;
            label1.Text = "Laad een foto om te beginnen.";
            label1.Font = new Font(label1.Font.FontFamily, 14);
        }

        #region Image Processing

        private float CalculateAspectRatio(Image image)
        {
            return (float)image.Width / image.Height;
        }

        private (int width, int height) DetermineTargetSize(float imageAspectRatio, float pictureBoxAspectRatio)
        {
            int targetWidth, targetHeight;
            if (imageAspectRatio > pictureBoxAspectRatio)
            {
                targetWidth = pictureBox1.Width;
                targetHeight = (int)(pictureBox1.Width / imageAspectRatio);
            }
            else
            {
                targetHeight = pictureBox1.Height;
                targetWidth = (int)(pictureBox1.Height * imageAspectRatio);
            }
            return (targetWidth, targetHeight);
        }

        private (int x, int y) CalculateCenteringStartPoint(int targetWidth, int targetHeight)
        {
            int startX = (pictureBox1.Width - targetWidth) / 2;
            int startY = (pictureBox1.Height - targetHeight) / 2;
            return (startX, startY);
        }

        private Image DrawCenteredImage(Image image, int targetWidth, int targetHeight, int startX, int startY)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent); // Fill the background with transparency or a solid color if preferred
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(image, new Rectangle(startX, startY, targetWidth, targetHeight));
            }
            return bmp;
        }

        private Image SetScaledImage(Image image)
        {
            float imageAspectRatio = CalculateAspectRatio(image);
            float pictureBoxAspectRatio = CalculateAspectRatio(new Bitmap(pictureBox1.Width, pictureBox1.Height));
            var (targetWidth, targetHeight) = DetermineTargetSize(imageAspectRatio, pictureBoxAspectRatio);
            var (startX, startY) = CalculateCenteringStartPoint(targetWidth, targetHeight);
            return DrawCenteredImage(image, targetWidth, targetHeight, startX, startY);
        }

        #endregion

        #region Utility Methods

        private void UpdateImageDisplay(int index)
        {
            pictureBox1.Image = SetScaledImage(_images[index]);
            // ReSharper disable once LocalizableElement
            label1.Text = $"{index + 1}/{_images.Count}";
            label1.Font = new Font(label1.Font.FontFamily, _originalLabelTextSize);
        }

        private string ShowUploadDialog()
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                Title = "Select an image file",
                Multiselect = false,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                CheckFileExists = true
            };
            return dialog.ShowDialog() == DialogResult.OK ? dialog.FileName : null;
        }
        
        #endregion
    }
}