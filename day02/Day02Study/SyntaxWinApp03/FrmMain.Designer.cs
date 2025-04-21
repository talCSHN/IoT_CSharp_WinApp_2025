namespace SyntaxWinApp03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            BtnMsg = new Button();
            LblPain = new Label();
            TxtPain = new TextBox();
            LblPainPoint = new Label();
            CboPainPoint = new ComboBox();
            TxtResult = new TextBox();
            BtnDisplay = new Button();
            BtnWhile = new Button();
            SuspendLayout();
            // 
            // BtnMsg
            // 
            BtnMsg.Location = new Point(647, 377);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(100, 40);
            BtnMsg.TabIndex = 6;
            BtnMsg.Text = "메시지";
            BtnMsg.UseVisualStyleBackColor = true;
            BtnMsg.Click += BtnMsg_Click;
            // 
            // LblPain
            // 
            LblPain.AutoSize = true;
            LblPain.Location = new Point(12, 9);
            LblPain.Name = "LblPain";
            LblPain.Size = new Size(64, 15);
            LblPain.TabIndex = 1;
            LblPain.Text = "통증여부 -";
            // 
            // TxtPain
            // 
            TxtPain.Location = new Point(82, 6);
            TxtPain.MaxLength = 3;
            TxtPain.Name = "TxtPain";
            TxtPain.PlaceholderText = "네 또는 아니오";
            TxtPain.Size = new Size(100, 23);
            TxtPain.TabIndex = 1;
            TxtPain.KeyPress += TxtPain_KeyPress;
            // 
            // LblPainPoint
            // 
            LblPainPoint.AutoSize = true;
            LblPainPoint.Location = new Point(12, 38);
            LblPainPoint.Name = "LblPainPoint";
            LblPainPoint.Size = new Size(64, 15);
            LblPainPoint.TabIndex = 3;
            LblPainPoint.Text = "통증부위 -";
            LblPainPoint.Click += LblPainPoint_Click;
            // 
            // CboPainPoint
            // 
            CboPainPoint.FormattingEnabled = true;
            CboPainPoint.Items.AddRange(new object[] { "머리", "눈", "코", "목", "가슴", "배" });
            CboPainPoint.Location = new Point(82, 35);
            CboPainPoint.Name = "CboPainPoint";
            CboPainPoint.Size = new Size(121, 23);
            CboPainPoint.TabIndex = 2;
            CboPainPoint.Text = "부위 선택";
            CboPainPoint.SelectedIndexChanged += CboPainPoint_SelectedIndexChanged;
            // 
            // TxtResult
            // 
            TxtResult.BackColor = SystemColors.ButtonHighlight;
            TxtResult.Location = new Point(12, 64);
            TxtResult.Multiline = true;
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(735, 307);
            TxtResult.TabIndex = 3;
            // 
            // BtnDisplay
            // 
            BtnDisplay.Location = new Point(541, 377);
            BtnDisplay.Name = "BtnDisplay";
            BtnDisplay.Size = new Size(100, 40);
            BtnDisplay.TabIndex = 5;
            BtnDisplay.Text = "구구단";
            BtnDisplay.UseVisualStyleBackColor = true;
            BtnDisplay.Click += BtnDisplay_Click;
            // 
            // BtnWhile
            // 
            BtnWhile.Location = new Point(435, 377);
            BtnWhile.Name = "BtnWhile";
            BtnWhile.Size = new Size(100, 40);
            BtnWhile.TabIndex = 4;
            BtnWhile.Text = "반복";
            BtnWhile.UseVisualStyleBackColor = true;
            BtnWhile.Click += BtnWhile_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(759, 429);
            Controls.Add(BtnWhile);
            Controls.Add(BtnDisplay);
            Controls.Add(TxtResult);
            Controls.Add(CboPainPoint);
            Controls.Add(LblPainPoint);
            Controls.Add(TxtPain);
            Controls.Add(LblPain);
            Controls.Add(BtnMsg);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "문법학습 윈앱 03";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnMsg;
        private Label LblPain;
        private TextBox TxtPain;
        private Label LblPainPoint;
        private ComboBox CboPainPoint;
        private TextBox TxtResult;
        private Button BtnDisplay;
        private Button BtnWhile;
    }
}
