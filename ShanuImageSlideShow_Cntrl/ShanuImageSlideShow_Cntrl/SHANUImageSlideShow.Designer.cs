namespace ShanuImageSlideShow_Cntrl
{
    partial class SHANUImageSlideShow
    {
        
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 

        
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.pic_PlaySound = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.picPrevious = new System.Windows.Forms.PictureBox();
            this.pnlThumb = new System.Windows.Forms.Panel();
            this.picLoadImage = new System.Windows.Forms.PictureBox();
            this.pnlImg = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picImageSlide = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Panel4 = new System.Windows.Forms.Panel();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_PlaySound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrevious)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadImage)).BeginInit();
            this.pnlImg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.BackColor = System.Drawing.Color.Beige;
            this.pnlControls.Controls.Add(this.pic_PlaySound);
            this.pnlControls.Controls.Add(this.picNext);
            this.pnlControls.Controls.Add(this.picPlay);
            this.pnlControls.Controls.Add(this.picPrevious);
            this.pnlControls.Controls.Add(this.pnlThumb);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlControls.Location = new System.Drawing.Point(0, 590);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(857, 277);
            this.pnlControls.TabIndex = 132;
            // 
            // pic_PlaySound
            // 
            this.pic_PlaySound.Image = global::ShanuImageSlideShow_Cntrl.Properties.Resources.soundOFF;
            this.pic_PlaySound.Location = new System.Drawing.Point(26, 223);
            this.pic_PlaySound.Name = "pic_PlaySound";
            this.pic_PlaySound.Size = new System.Drawing.Size(31, 39);
            this.pic_PlaySound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_PlaySound.TabIndex = 18;
            this.pic_PlaySound.TabStop = false;
            this.pic_PlaySound.Click += new System.EventHandler(this.pic_PlaySound_Click);
            // 
            // picNext
            // 
            this.picNext.Image = global::ShanuImageSlideShow_Cntrl.Properties.Resources.Next;
            this.picNext.Location = new System.Drawing.Point(514, 187);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(53, 54);
            this.picNext.TabIndex = 17;
            this.picNext.TabStop = false;
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            // 
            // picPlay
            // 
            this.picPlay.Image = global::ShanuImageSlideShow_Cntrl.Properties.Resources.play;
            this.picPlay.Location = new System.Drawing.Point(433, 187);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(51, 54);
            this.picPlay.TabIndex = 16;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // picPrevious
            // 
            this.picPrevious.Image = global::ShanuImageSlideShow_Cntrl.Properties.Resources.Previous;
            this.picPrevious.Location = new System.Drawing.Point(353, 187);
            this.picPrevious.Name = "picPrevious";
            this.picPrevious.Size = new System.Drawing.Size(51, 54);
            this.picPrevious.TabIndex = 15;
            this.picPrevious.TabStop = false;
            this.picPrevious.Click += new System.EventHandler(this.picPrevious_Click);
            // 
            // pnlThumb
            // 
            this.pnlThumb.AutoScroll = true;
            this.pnlThumb.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlThumb.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThumb.Location = new System.Drawing.Point(0, 0);
            this.pnlThumb.Name = "pnlThumb";
            this.pnlThumb.Size = new System.Drawing.Size(857, 134);
            this.pnlThumb.TabIndex = 5;
            // 
            // picLoadImage
            // 
            this.picLoadImage.Image = global::ShanuImageSlideShow_Cntrl.Properties.Resources.folder_image;
            this.picLoadImage.Location = new System.Drawing.Point(3, 494);
            this.picLoadImage.Name = "picLoadImage";
            this.picLoadImage.Size = new System.Drawing.Size(71, 65);
            this.picLoadImage.TabIndex = 14;
            this.picLoadImage.TabStop = false;
            this.picLoadImage.Click += new System.EventHandler(this.picLoadImage_Click);
            // 
            // pnlImg
            // 
            this.pnlImg.BackColor = System.Drawing.Color.White;
            this.pnlImg.Controls.Add(this.label1);
            this.pnlImg.Controls.Add(this.picImageSlide);
            this.pnlImg.Controls.Add(this.picLoadImage);
            this.pnlImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImg.Location = new System.Drawing.Point(0, 31);
            this.pnlImg.Name = "pnlImg";
            this.pnlImg.Size = new System.Drawing.Size(857, 559);
            this.pnlImg.TabIndex = 133;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Location = new System.Drawing.Point(0, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Chọn folder ảnh";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // picImageSlide
            // 
            this.picImageSlide.BackColor = System.Drawing.Color.White;
            this.picImageSlide.Location = new System.Drawing.Point(245, 24);
            this.picImageSlide.Name = "picImageSlide";
            this.picImageSlide.Size = new System.Drawing.Size(364, 370);
            this.picImageSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImageSlide.TabIndex = 3;
            this.picImageSlide.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 300;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Panel4
            // 
            this.Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel4.Location = new System.Drawing.Point(0, 0);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(857, 31);
            this.Panel4.TabIndex = 131;
            // 
            // SHANUImageSlideShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlImg);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.Panel4);
            this.Name = "SHANUImageSlideShow";
            this.Size = new System.Drawing.Size(857, 867);
            this.Load += new System.EventHandler(this.SHANUImageSlideShow_Load);
            this.pnlControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_PlaySound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPrevious)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLoadImage)).EndInit();
            this.pnlImg.ResumeLayout(false);
            this.pnlImg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImageSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel4;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picPrevious;
        private System.Windows.Forms.PictureBox picLoadImage;
        private System.Windows.Forms.Panel pnlThumb;
        private System.Windows.Forms.Panel pnlImg;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox picImageSlide;
        private System.Windows.Forms.PictureBox pic_PlaySound;
        private System.Windows.Forms.Label label1;
    }
}
