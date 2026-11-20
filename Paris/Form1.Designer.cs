namespace Paris
{
    partial class Paris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paris));
            this.close_btn = new System.Windows.Forms.PictureBox();
            this.paris_titlu = new System.Windows.Forms.PictureBox();
            this.test_btn = new System.Windows.Forms.Button();
            this.info_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paris_titlu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // close_btn
            // 
            this.close_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_btn.Image = global::Paris.Properties.Resources.close_button;
            this.close_btn.Location = new System.Drawing.Point(1121, 12);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(107, 101);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close_btn.TabIndex = 1;
            this.close_btn.TabStop = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            this.close_btn.StyleChanged += new System.EventHandler(this.close_btn_StyleChanged);
            // 
            // paris_titlu
            // 
            this.paris_titlu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paris_titlu.BackColor = System.Drawing.Color.Transparent;
            this.paris_titlu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.paris_titlu.Image = global::Paris.Properties.Resources.paris_titlu;
            this.paris_titlu.Location = new System.Drawing.Point(384, 68);
            this.paris_titlu.Name = "paris_titlu";
            this.paris_titlu.Size = new System.Drawing.Size(493, 324);
            this.paris_titlu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paris_titlu.TabIndex = 2;
            this.paris_titlu.TabStop = false;
            // 
            // test_btn
            // 
            this.test_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.test_btn.BackColor = System.Drawing.Color.Transparent;
            this.test_btn.BackgroundImage = global::Paris.Properties.Resources.button1;
            this.test_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.test_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.test_btn.FlatAppearance.BorderSize = 0;
            this.test_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.test_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.test_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.test_btn.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.test_btn.Location = new System.Drawing.Point(127, 563);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(1025, 118);
            this.test_btn.TabIndex = 3;
            this.test_btn.Text = "Test";
            this.test_btn.UseVisualStyleBackColor = false;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // info_btn
            // 
            this.info_btn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.info_btn.BackColor = System.Drawing.Color.Transparent;
            this.info_btn.BackgroundImage = global::Paris.Properties.Resources.button1;
            this.info_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.info_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.info_btn.FlatAppearance.BorderSize = 0;
            this.info_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.info_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.info_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.info_btn.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.info_btn.Location = new System.Drawing.Point(127, 398);
            this.info_btn.Name = "info_btn";
            this.info_btn.Size = new System.Drawing.Size(1025, 118);
            this.info_btn.TabIndex = 4;
            this.info_btn.Text = "Informatii despre oras";
            this.info_btn.UseVisualStyleBackColor = false;
            this.info_btn.Click += new System.EventHandler(this.info_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Paris.Properties.Resources.Info;
            this.pictureBox1.Location = new System.Drawing.Point(34, 594);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Paris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Paris.Properties.Resources.paris_toamna;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 789);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.info_btn);
            this.Controls.Add(this.test_btn);
            this.Controls.Add(this.paris_titlu);
            this.Controls.Add(this.close_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Paris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paris";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Paris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paris_titlu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox close_btn;
        private System.Windows.Forms.PictureBox paris_titlu;
        private System.Windows.Forms.Button test_btn;
        private System.Windows.Forms.Button info_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

