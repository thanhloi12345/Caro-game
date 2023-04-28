namespace CaroGame
{
    partial class caroGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(caroGame));
            this.panelBanCo = new System.Windows.Forms.Panel();
            this.may = new System.Windows.Forms.Button();
            this.nguoi = new System.Windows.Forms.Button();
            this.luatChoi = new System.Windows.Forms.Button();
            this.phienban = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBanCo
            // 
            this.panelBanCo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelBanCo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBanCo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBanCo.Location = new System.Drawing.Point(0, 0);
            this.panelBanCo.Name = "panelBanCo";
            this.panelBanCo.Padding = new System.Windows.Forms.Padding(3);
            this.panelBanCo.Size = new System.Drawing.Size(574, 544);
            this.panelBanCo.TabIndex = 0;
            this.panelBanCo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBanCo_Paint);
            this.panelBanCo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelBanCo_MouseClick);
            // 
            // may
            // 
            this.may.BackColor = System.Drawing.Color.NavajoWhite;
            this.may.Location = new System.Drawing.Point(587, 271);
            this.may.Name = "may";
            this.may.Size = new System.Drawing.Size(207, 45);
            this.may.TabIndex = 2;
            this.may.Text = "Đánh máy";
            this.may.UseVisualStyleBackColor = false;
            this.may.Click += new System.EventHandler(this.may_Click);
            // 
            // nguoi
            // 
            this.nguoi.BackColor = System.Drawing.Color.DarkMagenta;
            this.nguoi.Location = new System.Drawing.Point(587, 348);
            this.nguoi.Name = "nguoi";
            this.nguoi.Size = new System.Drawing.Size(212, 45);
            this.nguoi.TabIndex = 3;
            this.nguoi.Text = "2 Người Chơi";
            this.nguoi.UseVisualStyleBackColor = false;
            this.nguoi.Click += new System.EventHandler(this.nguoi_Click);
            // 
            // luatChoi
            // 
            this.luatChoi.BackColor = System.Drawing.Color.Red;
            this.luatChoi.Location = new System.Drawing.Point(587, 422);
            this.luatChoi.Name = "luatChoi";
            this.luatChoi.Size = new System.Drawing.Size(85, 23);
            this.luatChoi.TabIndex = 4;
            this.luatChoi.Text = "Luật chơi";
            this.luatChoi.UseVisualStyleBackColor = false;
            this.luatChoi.Click += new System.EventHandler(this.luatChoi_Click);
            // 
            // phienban
            // 
            this.phienban.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.phienban.Location = new System.Drawing.Point(695, 421);
            this.phienban.Name = "phienban";
            this.phienban.Size = new System.Drawing.Size(99, 23);
            this.phienban.TabIndex = 5;
            this.phienban.Text = "Phiên bản";
            this.phienban.UseVisualStyleBackColor = false;
            this.phienban.Click += new System.EventHandler(this.phienban_Click);
            // 
            // thoat
            // 
            this.thoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.thoat.Location = new System.Drawing.Point(582, 471);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(211, 42);
            this.thoat.TabIndex = 6;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = false;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CaroGame.Properties.Resources.caro;
            this.pictureBox1.Location = new System.Drawing.Point(586, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 236);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // caroGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(809, 544);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.phienban);
            this.Controls.Add(this.luatChoi);
            this.Controls.Add(this.nguoi);
            this.Controls.Add(this.may);
            this.Controls.Add(this.panelBanCo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "caroGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caro Game";
            this.Load += new System.EventHandler(this.caroGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelBanCo;
        private Button may;
        private Button nguoi;
        private Button luatChoi;
        private Button phienban;
        private Button thoat;
        private PictureBox pictureBox1;
    }
}