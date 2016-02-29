using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ColorDetector
{
    public partial class ColorDetectForm : Form
    {
        Color actualColor;
        public ColorDetectForm()
        {
            InitializeComponent();
            actualColor = panelSelectedColor.BackColor;
        }

        private void ChooseImageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //Clearing previously selected image from picture box
                ImagePathLbl.Text = "";
                pictureBox1.Image = null;

                //Showing the File Chooser Dialog Box for Image File selection
                DialogResult IsFileChosen = openFileDialog1.ShowDialog();

                if (IsFileChosen == System.Windows.Forms.DialogResult.OK)
                {
                    //Get the File name
                    ImagePathLbl.Text = openFileDialog1.FileName;

                    //Load the image into a picture box
                    if (openFileDialog1.ValidateNames == true)
                    {
                        pictureBox1.Image = Image.FromFile(ImagePathLbl.Text);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void PickColorBtn_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show("" + pictureBox1.Height + " " + pictureBox1.Width);
                // Clean previously selected color
                SelectedColorNameLbl.Text = "";
                panelSelectedColor.BackColor = actualColor;

                //Showing color choice
                DialogResult IsColorChosen = colorDialog1.ShowDialog();

                if (IsColorChosen == System.Windows.Forms.DialogResult.OK)
                {
                    panelSelectedColor.BackColor = colorDialog1.Color;

                    //If it is know color, display the color name  
                    if (colorDialog1.Color.IsKnownColor == true)
                    {
                        SelectedColorNameLbl.Text = colorDialog1.Color.ToKnownColor().ToString();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void DetectColorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean IsColorFound = false;

                if (pictureBox1.Image != null)
                {
                    //Converting loaded image into bitmap
                    Bitmap bmp = new Bitmap(pictureBox1.Image);
                    Bitmap newbmp = new Bitmap(pictureBox1.Image.Width, pictureBox1.Image.Height);
                    int count = 0;
                    //Iterate whole bitmap to findout the picked color
                    for (int i = 0; i < pictureBox1.Image.Height; i++)
                    {
                        for (int j = 0; j < pictureBox1.Image.Width; j++)
                        {
                            //Get the color at each pixel
                            Color now_color = bmp.GetPixel(j, i);

                            //Compare Pixel's Color ARGB property with the picked color's ARGB property 
                            if (now_color.ToArgb() == Color.White.ToArgb())
                            {
                                IsColorFound = true;
                                newbmp.SetPixel(j, i, Color.Black);
                                count++;
                            }

                            else
                                newbmp.SetPixel(j, i, now_color);
                        }
                       
                    }

                    if (IsColorFound == false)
                    {
                        MessageBox.Show("Selected Color Not Found.");
                    }
                    else {
                        pictureBox1.Image = newbmp;

                        SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                        saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
                        saveFileDialog1.Title = "Save an Image File";
                        saveFileDialog1.ShowDialog();
                       

                        if (saveFileDialog1.FileName != "")
                        {
                            // Saves the Image via a FileStream created by the OpenFile method.
                            System.IO.FileStream fs =
                               (System.IO.FileStream)saveFileDialog1.OpenFile();
                            // Saves the Image in the appropriate ImageFormat based upon the
                            // File type selected in the dialog box.
                            // NOTE that the FilterIndex property is one-based.
                            switch (saveFileDialog1.FilterIndex)
                            {
                                case 1:
                                    this.pictureBox1.Image.Save(fs,
                                       System.Drawing.Imaging.ImageFormat.Jpeg);
                                    break;

                                case 2:
                                    this.pictureBox1.Image.Save(fs,
                                       System.Drawing.Imaging.ImageFormat.Bmp);
                                    break;

                                case 3:
                                    this.pictureBox1.Image.Save(fs,
                                       System.Drawing.Imaging.ImageFormat.Gif);
                                    break;
                            }

                            fs.Close();
                        }
                    

                    MessageBox.Show("Saved Output to " + saveFileDialog1.FileName);
                    }
                }
                else
                {
                    MessageBox.Show("Image is not loaded");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                e.Link.LinkData = "http://hemant-srivastava.blogspot.com/";
                System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
