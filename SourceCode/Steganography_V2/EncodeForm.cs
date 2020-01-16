using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography_V2
{
    public partial class EncodeForm : Form
    {
        public EncodeForm()
        {
            InitializeComponent();
        }

        private void BrowseBTN_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PictureToEncodePB.Image = Image.FromFile(openFileDialog.FileName);
                    TextToEncodeRTB.Enabled = true;
                }
            }
        }

        private void TextToEncodeRTB_TextChanged(object sender, EventArgs e)
        {
            if (TextToEncodeRTB.Text.Trim().Length > 0)
            {
                SaveToFileBTN.Enabled = true;
            }
            else
            {
                SaveToFileBTN.Enabled = false;
            }
        }

        private void SaveToFileBTN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to hide this text in the selected image?", "Confirmation : Hide text into image ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.SaveToFileBTN.Enabled = true;
                this.PictureToEncodePB.Image = BusinessLogicLayer.SteaganographyEncoding
                    .SteganoImage(PictureToEncodePB.Image, TextToEncodeRTB.Text);
                using (SaveFileDialog saveFile = new SaveFileDialog())
                {
                    // Filter copied from "https://stackoverflow.com/questions/2069048/setting-the-filter-to-an-openfiledialog-to-allow-the-typical-image-formats"
                    saveFile.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        Bitmap bitmap = new Bitmap(PictureToEncodePB.Image);
                        bitmap.Save(saveFile.FileName);
                    }
                }
            }
        }
    }
}
