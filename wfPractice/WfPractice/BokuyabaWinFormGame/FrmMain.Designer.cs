namespace BokuyabaWinFormGame
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            HomeIml = new ImageList(components);
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            BtnStart = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // HomeIml
            // 
            HomeIml.ColorDepth = ColorDepth.Depth32Bit;
            HomeIml.ImageSize = new Size(100, 100);
            HomeIml.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bokuyaba;
            pictureBox1.Location = new Point(0, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(281, 41);
            textBox1.TabIndex = 1;
            textBox1.Text = "내 마음의 위험한 녀석";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnStart
            // 
            BtnStart.BackColor = Color.IndianRed;
            BtnStart.Location = new Point(688, 398);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(100, 40);
            BtnStart.TabIndex = 0;
            BtnStart.Text = "게임 시작";
            BtnStart.UseVisualStyleBackColor = false;
            BtnStart.Click += BtnStart_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnStart);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "FrmMain";
            Text = "내 마음의 위험한 녀석 (프로토타입)";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList HomeIml;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button BtnStart;
    }
}
