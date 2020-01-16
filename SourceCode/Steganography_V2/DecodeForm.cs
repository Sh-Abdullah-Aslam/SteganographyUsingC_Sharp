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
    public partial class DecodeForm : Form
    {
        public DecodeForm()
        {
            InitializeComponent();
        }

        private void BrowseBTN_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (BusinessLogicLayer.SteaganographyEncoding.isImageInfected(Image.FromFile(openFileDialog.FileName)))
                    {
                        PictureToDecodePB.Image = Image.FromFile(openFileDialog.FileName);
                        DecodeBTN.Enabled = true;
                        this.DisplayDecodedTextRTB.Enabled = true;
                        this.DisplayDecodedTextRTB.Cursor = Cursors.IBeam;
                        MainToolTip.SetToolTip(BrowseBTN, "Add another image");
                        MainToolTip.SetToolTip(PictureToDecodePB, "");
                    }
                }
                else
                {
                    MessageBox.Show("This image has no encoded text!", "Error! Can not decode a non-encoded image.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CopyTextBTN.Enabled = false;
                    DisplayDecodedTextRTB.Enabled = false;
                }
            }
        }

        private void DecodeBTN_Click(object sender, EventArgs e)
        {
            this.DisplayDecodedTextRTB.Text = BusinessLogicLayer.SteaganographyEncoding.DeSteganoImage(PictureToDecodePB.Image);
            CopyTextBTN.Enabled = true;
            DisplayDecodedTextRTB.Enabled = true;
        }

        private void CopyTextBTN_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.DisplayDecodedTextRTB.Text);
        }
    }
}
