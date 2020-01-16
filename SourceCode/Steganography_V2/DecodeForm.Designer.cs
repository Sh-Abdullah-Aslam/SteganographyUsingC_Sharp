namespace Steganography_V2
{
    partial class DecodeForm
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
            this.PictureToDecodePB = new System.Windows.Forms.PictureBox();
            this.BrowseBTN = new System.Windows.Forms.Button();
            this.DisplayDecodedTextRTB = new System.Windows.Forms.RichTextBox();
            this.DecodeBTN = new System.Windows.Forms.Button();
            this.CopyTextBTN = new System.Windows.Forms.Button();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureToDecodePB)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureToDecodePB
            // 
            this.PictureToDecodePB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(90)))));
            this.PictureToDecodePB.Location = new System.Drawing.Point(75, 26);
            this.PictureToDecodePB.Name = "PictureToDecodePB";
            this.PictureToDecodePB.Size = new System.Drawing.Size(621, 355);
            this.PictureToDecodePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureToDecodePB.TabIndex = 0;
            this.PictureToDecodePB.TabStop = false;
            this.MainToolTip.SetToolTip(this.PictureToDecodePB, "Selected image will display here");
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
            this.BrowseBTN.Location = new System.Drawing.Point(75, 405);
            this.BrowseBTN.Name = "BrowseBTN";
            this.BrowseBTN.Size = new System.Drawing.Size(188, 45);
            this.BrowseBTN.TabIndex = 3;
            this.BrowseBTN.Text = "Browse image";
            this.MainToolTip.SetToolTip(this.BrowseBTN, "Select an image to retrieve hidden text");
            this.BrowseBTN.UseVisualStyleBackColor = false;
            this.BrowseBTN.Click += new System.EventHandler(this.BrowseBTN_Click);
            // 
            // DisplayDecodedTextRTB
            // 
            this.DisplayDecodedTextRTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.DisplayDecodedTextRTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisplayDecodedTextRTB.Cursor = System.Windows.Forms.Cursors.No;
            this.DisplayDecodedTextRTB.Enabled = false;
            this.DisplayDecodedTextRTB.ForeColor = System.Drawing.Color.Azure;
            this.DisplayDecodedTextRTB.Location = new System.Drawing.Point(743, 26);
            this.DisplayDecodedTextRTB.Name = "DisplayDecodedTextRTB";
            this.DisplayDecodedTextRTB.ReadOnly = true;
            this.DisplayDecodedTextRTB.Size = new System.Drawing.Size(351, 355);
            this.DisplayDecodedTextRTB.TabIndex = 4;
            this.DisplayDecodedTextRTB.Text = "";
            this.MainToolTip.SetToolTip(this.DisplayDecodedTextRTB, "Copy the text to clipboard using the button below");
            // 
            // DecodeBTN
            // 
            this.DecodeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.DecodeBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecodeBTN.Enabled = false;
            this.DecodeBTN.FlatAppearance.BorderSize = 2;
            this.DecodeBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(140)))));
            this.DecodeBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.DecodeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecodeBTN.Font = new System.Drawing.Font("Segoe UI Historic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecodeBTN.Location = new System.Drawing.Point(508, 405);
            this.DecodeBTN.Name = "DecodeBTN";
            this.DecodeBTN.Size = new System.Drawing.Size(188, 45);
            this.DecodeBTN.TabIndex = 5;
            this.DecodeBTN.Text = "Decode";
            this.MainToolTip.SetToolTip(this.DecodeBTN, "Retrieve the hidden text from this image");
            this.DecodeBTN.UseVisualStyleBackColor = false;
            this.DecodeBTN.Click += new System.EventHandler(this.DecodeBTN_Click);
            // 
            // CopyTextBTN
            // 
            this.CopyTextBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.CopyTextBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CopyTextBTN.Enabled = false;
            this.CopyTextBTN.FlatAppearance.BorderSize = 2;
            this.CopyTextBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(140)))));
            this.CopyTextBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.CopyTextBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyTextBTN.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyTextBTN.Location = new System.Drawing.Point(982, 412);
            this.CopyTextBTN.Name = "CopyTextBTN";
            this.CopyTextBTN.Size = new System.Drawing.Size(112, 34);
            this.CopyTextBTN.TabIndex = 6;
            this.CopyTextBTN.Text = "Copy Text";
            this.MainToolTip.SetToolTip(this.CopyTextBTN, "Copy to clipboard");
            this.CopyTextBTN.UseVisualStyleBackColor = false;
            this.CopyTextBTN.Click += new System.EventHandler(this.CopyTextBTN_Click);
            // 
            // DecodeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1181, 460);
            this.Controls.Add(this.CopyTextBTN);
            this.Controls.Add(this.DecodeBTN);
            this.Controls.Add(this.DisplayDecodedTextRTB);
            this.Controls.Add(this.BrowseBTN);
            this.Controls.Add(this.PictureToDecodePB);
            this.Font = new System.Drawing.Font("Segoe UI Historic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Azure;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DecodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DecodeForm";
            ((System.ComponentModel.ISupportInitialize)(this.PictureToDecodePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureToDecodePB;
        private System.Windows.Forms.Button BrowseBTN;
        private System.Windows.Forms.RichTextBox DisplayDecodedTextRTB;
        private System.Windows.Forms.Button DecodeBTN;
        private System.Windows.Forms.Button CopyTextBTN;
        private System.Windows.Forms.ToolTip MainToolTip;
    }
}