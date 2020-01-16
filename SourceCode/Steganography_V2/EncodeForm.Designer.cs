namespace Steganography_V2
{
    partial class EncodeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BrowseBTN = new System.Windows.Forms.Button();
            this.PictureToEncodePB = new System.Windows.Forms.PictureBox();
            this.SaveToFileBTN = new System.Windows.Forms.Button();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.TextToEncodeRTB = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureToEncodePB)).BeginInit();
            this.SuspendLayout();
            // 
            // BrowseBTN
            // 
            this.BrowseBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.BrowseBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BrowseBTN.FlatAppearance.BorderSize = 2;
            this.BrowseBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(140)))));
            this.BrowseBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.BrowseBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseBTN.Font = new System.Drawing.Font("Segoe UI Historic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseBTN.Location = new System.Drawing.Point(444, 397);
            this.BrowseBTN.Name = "BrowseBTN";
            this.BrowseBTN.Size = new System.Drawing.Size(252, 45);
            this.BrowseBTN.TabIndex = 8;
            this.BrowseBTN.Text = "Browse image";
            this.MainToolTip.SetToolTip(this.BrowseBTN, "Select an image to hide text into it");
            this.BrowseBTN.UseVisualStyleBackColor = false;
            this.BrowseBTN.Click += new System.EventHandler(this.BrowseBTN_Click);
            // 
            // PictureToEncodePB
            // 
            this.PictureToEncodePB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.PictureToEncodePB.Location = new System.Drawing.Point(75, 25);
            this.PictureToEncodePB.Name = "PictureToEncodePB";
            this.PictureToEncodePB.Size = new System.Drawing.Size(621, 355);
            this.PictureToEncodePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureToEncodePB.TabIndex = 7;
            this.PictureToEncodePB.TabStop = false;
            this.MainToolTip.SetToolTip(this.PictureToEncodePB, "Selected image will display here");
            // 
            // SaveToFileBTN
            // 
            this.SaveToFileBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.SaveToFileBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveToFileBTN.Enabled = false;
            this.SaveToFileBTN.FlatAppearance.BorderSize = 2;
            this.SaveToFileBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(140)))));
            this.SaveToFileBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.SaveToFileBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveToFileBTN.Font = new System.Drawing.Font("Segoe UI Historic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveToFileBTN.Location = new System.Drawing.Point(842, 397);
            this.SaveToFileBTN.Name = "SaveToFileBTN";
            this.SaveToFileBTN.Size = new System.Drawing.Size(252, 45);
            this.SaveToFileBTN.TabIndex = 11;
            this.SaveToFileBTN.Text = "Encode and save image";
            this.MainToolTip.SetToolTip(this.SaveToFileBTN, "Export image with encoded text to file");
            this.SaveToFileBTN.UseVisualStyleBackColor = false;
            this.SaveToFileBTN.Click += new System.EventHandler(this.SaveToFileBTN_Click);
            // 
            // TextToEncodeRTB
            // 
            this.TextToEncodeRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.TextToEncodeRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextToEncodeRTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextToEncodeRTB.Enabled = false;
            this.TextToEncodeRTB.ForeColor = System.Drawing.Color.Azure;
            this.TextToEncodeRTB.Location = new System.Drawing.Point(743, 25);
            this.TextToEncodeRTB.Name = "TextToEncodeRTB";
            this.TextToEncodeRTB.Size = new System.Drawing.Size(351, 355);
            this.TextToEncodeRTB.TabIndex = 9;
            this.TextToEncodeRTB.Text = "";
            this.MainToolTip.SetToolTip(this.TextToEncodeRTB, "Write text to hide in the image on the left");
            this.TextToEncodeRTB.TextChanged += new System.EventHandler(this.TextToEncodeRTB_TextChanged);
            // 
            // EncodeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1181, 460);
            this.Controls.Add(this.SaveToFileBTN);
            this.Controls.Add(this.TextToEncodeRTB);
            this.Controls.Add(this.BrowseBTN);
            this.Controls.Add(this.PictureToEncodePB);
            this.Font = new System.Drawing.Font("Segoe UI Historic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Azure;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EncodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EncodeForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureToEncodePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BrowseBTN;
        private System.Windows.Forms.PictureBox PictureToEncodePB;
        private System.Windows.Forms.Button SaveToFileBTN;
        private System.Windows.Forms.ToolTip MainToolTip;
        private System.Windows.Forms.RichTextBox TextToEncodeRTB;
    }
}