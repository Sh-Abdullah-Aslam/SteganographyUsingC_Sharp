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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EncodeForm encodeForm = new EncodeForm();
            DecodeForm decodeForm = new DecodeForm();

            encodeForm.TopLevel = false;
            decodeForm.TopLevel = false;
            encodeForm.Parent = this;
            decodeForm.Parent = this;
            encodeForm.Dock = DockStyle.Fill;
            decodeForm.Dock = DockStyle.Fill;

            EncodeControl.Controls.Add(encodeForm);
            DecodeControl.Controls.Add(decodeForm);

            encodeForm.Show();
            decodeForm.Show();
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeLBL_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
