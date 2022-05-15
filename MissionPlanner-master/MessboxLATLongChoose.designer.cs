namespace MissionPlanner
{
    partial class MessboxLATLongChoose
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
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label_latitude = new System.Windows.Forms.Label();
            this.label_longitude = new System.Windows.Forms.Label();
            this.text_Lat = new System.Windows.Forms.TextBox();
            this.text_long = new System.Windows.Forms.TextBox();
            this.BUT_read = new MissionPlanner.Controls.MyButton();
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            this.label_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::MissionPlanner.Properties.Resources.close_474;
            this.pictureBox4.Location = new System.Drawing.Point(519, 1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(550, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseDown);
            this.pictureBox5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox5_MouseMove);
            // 
            // label_latitude
            // 
            this.label_latitude.AutoSize = true;
            this.label_latitude.BackColor = System.Drawing.Color.Transparent;
            this.label_latitude.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_latitude.Location = new System.Drawing.Point(84, 99);
            this.label_latitude.Name = "label_latitude";
            this.label_latitude.Size = new System.Drawing.Size(68, 21);
            this.label_latitude.TabIndex = 12;
            this.label_latitude.Text = "latitude";
            // 
            // label_longitude
            // 
            this.label_longitude.AutoSize = true;
            this.label_longitude.BackColor = System.Drawing.Color.Transparent;
            this.label_longitude.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_longitude.Location = new System.Drawing.Point(69, 133);
            this.label_longitude.Name = "label_longitude";
            this.label_longitude.Size = new System.Drawing.Size(83, 21);
            this.label_longitude.TabIndex = 13;
            this.label_longitude.Text = "longitude";
            // 
            // text_Lat
            // 
            this.text_Lat.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_Lat.Location = new System.Drawing.Point(154, 95);
            this.text_Lat.Name = "text_Lat";
            this.text_Lat.Size = new System.Drawing.Size(307, 29);
            this.text_Lat.TabIndex = 14;
            // 
            // text_long
            // 
            this.text_long.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.text_long.Location = new System.Drawing.Point(154, 129);
            this.text_long.Name = "text_long";
            this.text_long.Size = new System.Drawing.Size(307, 29);
            this.text_long.TabIndex = 15;
            // 
            // BUT_read
            // 
            this.BUT_read.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUT_read.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.BUT_read.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BUT_read.Location = new System.Drawing.Point(88, 186);
            this.BUT_read.Name = "BUT_read";
            this.BUT_read.Size = new System.Drawing.Size(182, 35);
            this.BUT_read.TabIndex = 16;
            this.BUT_read.Text = "Cancel";
            this.BUT_read.UseVisualStyleBackColor = true;
            this.BUT_read.Click += new System.EventHandler(this.BUT_read_Click);
            // 
            // myButton1
            // 
            this.myButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myButton1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.myButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myButton1.Location = new System.Drawing.Point(279, 186);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(182, 35);
            this.myButton1.TabIndex = 17;
            this.myButton1.Text = "Ok";
            this.myButton1.UseVisualStyleBackColor = true;
            this.myButton1.Click += new System.EventHandler(this.myButton1_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_title.Location = new System.Drawing.Point(6, 35);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(68, 21);
            this.label_title.TabIndex = 18;
            this.label_title.Text = "latitude";
            // 
            // MessboxLATLongChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MissionPlanner.Properties.Resources.底图;
            this.ClientSize = new System.Drawing.Size(552, 261);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.BUT_read);
            this.Controls.Add(this.text_long);
            this.Controls.Add(this.text_Lat);
            this.Controls.Add(this.label_longitude);
            this.Controls.Add(this.label_latitude);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessboxLATLongChoose";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessboxShowInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label_latitude;
        private System.Windows.Forms.Label label_longitude;
        private System.Windows.Forms.TextBox text_Lat;
        private System.Windows.Forms.TextBox text_long;
        public Controls.MyButton BUT_read;
        public Controls.MyButton myButton1;
        private System.Windows.Forms.Label label_title;
    }
}