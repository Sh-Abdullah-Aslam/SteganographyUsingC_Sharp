namespace Steganography_V2
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.EncodeControl = new System.Windows.Forms.TabPage();
            this.DecodeControl = new System.Windows.Forms.TabPage();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.ExitLBL = new System.Windows.Forms.Label();
            this.MinimizeLBL = new System.Windows.Forms.Label();
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1204, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "STEGANOGRAPHY : Hide text in images";
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.EncodeControl);
            this.MainTabControl.Controls.Add(this.DecodeControl);
            this.MainTabControl.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.Location = new System.Drawing.Point(95, 130);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(1189, 510);
            this.MainTabControl.TabIndex = 1;
            // 
            // EncodeControl
            // 
            this.EncodeControl.Location = new System.Drawing.Point(4, 46);
            this.EncodeControl.Margin = new System.Windows.Forms.Padding(1);
            this.EncodeControl.Name = "EncodeControl";
            this.EncodeControl.Size = new System.Drawing.Size(1181, 460);
            this.EncodeControl.TabIndex = 0;
            this.EncodeControl.Text = "Encode text in image";
            this.EncodeControl.UseVisualStyleBackColor = true;
            // 
            // DecodeControl
            // 
            this.DecodeControl.Location = new System.Drawing.Point(4, 46);
            this.DecodeControl.Margin = new System.Windows.Forms.Padding(1);
            this.DecodeControl.Name = "DecodeControl";
            this.DecodeControl.Size = new System.Drawing.Size(1181, 460);
            this.DecodeControl.TabIndex = 1;
            this.DecodeControl.Text = "Decode text from image";
            this.DecodeControl.UseVisualStyleBackColor = true;
            // 
            // ExitBTN
            // 
            this.ExitBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.ExitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBTN.FlatAppearance.BorderSize = 2;
            this.ExitBTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(140)))));
            this.ExitBTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(120)))));
            this.ExitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBTN.Font = new System.Drawing.Font("Segoe UI Historic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBTN.Location = new System.Drawing.Point(1096, 657);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(188, 55);
            this.ExitBTN.TabIndex = 2;
            this.ExitBTN.Text = "Exit";
            this.ExitBTN.UseVisualStyleBackColor = false;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // ExitLBL
            // 
            this.ExitLBL.AutoSize = true;
            this.ExitLBL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLBL.Font = new System.Drawing.Font("Segoe UI Light", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(200)))));
            this.ExitLBL.Location = new System.Drawing.Point(1309, -7);
            this.ExitLBL.Name = "ExitLBL";
            this.ExitLBL.Size = new System.Drawing.Size(35, 46);
            this.ExitLBL.TabIndex = 3;
            this.ExitLBL.Text = "x";
            this.ExitLBL.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // MinimizeLBL
            // 
            this.MinimizeLBL.AutoSize = true;
            this.MinimizeLBL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeLBL.Font = new System.Drawing.Font("Segoe UI Light", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeLBL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(50)))), ((int)(((byte)(200)))));
            this.MinimizeLBL.Location = new System.Drawing.Point(1268, -7);
            this.MinimizeLBL.Name = "MinimizeLBL";
            this.MinimizeLBL.Size = new System.Drawing.Size(35, 46);
            this.MinimizeLBL.TabIndex = 4;
            this.MinimizeLBL.Text = "-";
            this.MinimizeLBL.Click += new System.EventHandler(this.MinimizeLBL_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.MinimizeLBL);
            this.Controls.Add(this.ExitLBL);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Azure;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SteganographyApplication";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage EncodeControl;
        private System.Windows.Forms.TabPage DecodeControl;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Label ExitLBL;
        private System.Windows.Forms.Label MinimizeLBL;
    }
}

