namespace SyntaxWinApp04
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
            LblName = new Label();
            TxtName = new TextBox();
            LblAge = new Label();
            LblGender = new Label();
            RdoMale = new RadioButton();
            RdoFemale = new RadioButton();
            BtnMsg = new Button();
            LblResult = new Label();
            TxtResult = new TextBox();
            TxtAge = new MaskedTextBox();
            SuspendLayout();
            // 
            // LblName
            // 
            LblName.AutoSize = true;
            LblName.Location = new Point(12, 9);
            LblName.Name = "LblName";
            LblName.Size = new Size(62, 15);
            LblName.TabIndex = 0;
            LblName.Text = "이름입력 :";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(80, 6);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(182, 23);
            TxtName.TabIndex = 1;
            // 
            // LblAge
            // 
            LblAge.AutoSize = true;
            LblAge.Location = new Point(12, 38);
            LblAge.Name = "LblAge";
            LblAge.Size = new Size(62, 15);
            LblAge.TabIndex = 0;
            LblAge.Text = "생년월일 :";
            // 
            // LblGender
            // 
            LblGender.AutoSize = true;
            LblGender.Location = new Point(12, 67);
            LblGender.Name = "LblGender";
            LblGender.Size = new Size(62, 15);
            LblGender.TabIndex = 0;
            LblGender.Text = "성별입력 :";
            // 
            // RdoMale
            // 
            RdoMale.AutoSize = true;
            RdoMale.Checked = true;
            RdoMale.Location = new Point(80, 64);
            RdoMale.Name = "RdoMale";
            RdoMale.Size = new Size(49, 19);
            RdoMale.TabIndex = 3;
            RdoMale.TabStop = true;
            RdoMale.Text = "남성";
            RdoMale.UseVisualStyleBackColor = true;
            // 
            // RdoFemale
            // 
            RdoFemale.AutoSize = true;
            RdoFemale.Location = new Point(135, 64);
            RdoFemale.Name = "RdoFemale";
            RdoFemale.Size = new Size(49, 19);
            RdoFemale.TabIndex = 3;
            RdoFemale.Text = "여성";
            RdoFemale.UseVisualStyleBackColor = true;
            // 
            // BtnMsg
            // 
            BtnMsg.Location = new Point(648, 374);
            BtnMsg.Name = "BtnMsg";
            BtnMsg.Size = new Size(100, 40);
            BtnMsg.TabIndex = 4;
            BtnMsg.Text = "확인";
            BtnMsg.UseVisualStyleBackColor = true;
            BtnMsg.Click += BtnMsg_Click;
            // 
            // LblResult
            // 
            LblResult.AutoSize = true;
            LblResult.Location = new Point(12, 118);
            LblResult.Name = "LblResult";
            LblResult.Size = new Size(62, 15);
            LblResult.TabIndex = 0;
            LblResult.Text = "결      과 :";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(80, 115);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(492, 23);
            TxtResult.TabIndex = 3;
            // 
            // TxtAge
            // 
            TxtAge.Location = new Point(80, 35);
            TxtAge.Mask = "0000-00-00";
            TxtAge.Name = "TxtAge";
            TxtAge.Size = new Size(182, 23);
            TxtAge.TabIndex = 5;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(760, 426);
            Controls.Add(TxtAge);
            Controls.Add(BtnMsg);
            Controls.Add(RdoFemale);
            Controls.Add(RdoMale);
            Controls.Add(LblGender);
            Controls.Add(TxtResult);
            Controls.Add(LblResult);
            Controls.Add(LblAge);
            Controls.Add(TxtName);
            Controls.Add(LblName);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "문법연습 윈앱 04";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblName;
        private TextBox TxtName;
        private Label LblAge;
        private Label LblGender;
        private RadioButton RdoMale;
        private RadioButton RdoFemale;
        private Button BtnMsg;
        private Label LblResult;
        private TextBox TxtResult;
        private MaskedTextBox TxtAge;
    }
}
