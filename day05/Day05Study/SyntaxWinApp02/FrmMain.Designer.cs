namespace SyntaxWinApp02
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
            BtnCheck = new Button();
            TxtLog = new TextBox();
            TxtTest = new TextBox();
            BtnGeneric = new Button();
            SuspendLayout();
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(472, 269);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(100, 30);
            BtnCheck.TabIndex = 0;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // TxtLog
            // 
            TxtLog.Location = new Point(12, 12);
            TxtLog.Multiline = true;
            TxtLog.Name = "TxtLog";
            TxtLog.Size = new Size(560, 251);
            TxtLog.TabIndex = 1;
            // 
            // TxtTest
            // 
            TxtTest.Location = new Point(12, 276);
            TxtTest.Name = "TxtTest";
            TxtTest.Size = new Size(161, 23);
            TxtTest.TabIndex = 2;
            // 
            // BtnGeneric
            // 
            BtnGeneric.Location = new Point(366, 269);
            BtnGeneric.Name = "BtnGeneric";
            BtnGeneric.Size = new Size(100, 30);
            BtnGeneric.TabIndex = 0;
            BtnGeneric.Text = "제네릭";
            BtnGeneric.UseVisualStyleBackColor = true;
            BtnGeneric.Click += BtnGeneric_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(TxtTest);
            Controls.Add(TxtLog);
            Controls.Add(BtnGeneric);
            Controls.Add(BtnCheck);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "고급학습 윈앱";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCheck;
        private TextBox TxtLog;
        private TextBox TxtTest;
        private Button BtnGeneric;
    }
}
