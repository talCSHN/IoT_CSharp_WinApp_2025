namespace WinControlsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            statusStrip1 = new StatusStrip();
            LblState = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            MnuFile = new ToolStripMenuItem();
            MnuNewFile = new ToolStripMenuItem();
            MnuExit = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            TxtResult = new TextBox();
            checkBox1 = new CheckBox();
            ChkBold = new CheckBox();
            CboFonts = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            PicImage = new PictureBox();
            BtnOpenImage = new Button();
            groupBox3 = new GroupBox();
            BtnCheck = new Button();
            DtpBirth = new DateTimePicker();
            LblUrl = new LinkLabel();
            TxtDay = new TextBox();
            TxtMonth = new TextBox();
            TxtYear = new TextBox();
            CalSchedule = new MonthCalendar();
            groupBox4 = new GroupBox();
            PrgProcess = new ProgressBar();
            TrbProcess = new TrackBar();
            groupBox5 = new GroupBox();
            BtnMsgBox = new Button();
            BtnModaless = new Button();
            BtnModal = new Button();
            groupBox6 = new GroupBox();
            BtnNode = new Button();
            BtnRoot = new Button();
            LsvDummy = new ListView();
            imageList1 = new ImageList(components);
            TrvDummy = new TreeView();
            DlgOpenImage = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicImage).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrbProcess).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblState });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1184, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblState
            // 
            LblState.Name = "LblState";
            LblState.Size = new Size(90, 17);
            LblState.Text = "상태 : 일반상태";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MnuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            MnuFile.DropDownItems.AddRange(new ToolStripItem[] { MnuNewFile, MnuExit });
            MnuFile.Name = "MnuFile";
            MnuFile.Size = new Size(57, 20);
            MnuFile.Text = "파일(&F)";
            // 
            // MnuNewFile
            // 
            MnuNewFile.Name = "MnuNewFile";
            MnuNewFile.Size = new Size(119, 22);
            MnuNewFile.Text = "새 글(&N)";
            // 
            // MnuExit
            // 
            MnuExit.Name = "MnuExit";
            MnuExit.Size = new Size(119, 22);
            MnuExit.Text = "종료(&X)";
            MnuExit.Click += MnuExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtResult);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(ChkBold);
            groupBox1.Controls.Add(CboFonts);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 106);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "일반 컨트롤";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(6, 64);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(371, 23);
            TxtResult.TabIndex = 3;
            TxtResult.Text = "Sample Text";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("맑은 고딕", 9F, FontStyle.Italic);
            checkBox1.Location = new Point(282, 18);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(62, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "이탤릭";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ChkBold
            // 
            ChkBold.AutoSize = true;
            ChkBold.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            ChkBold.Location = new Point(226, 18);
            ChkBold.Name = "ChkBold";
            ChkBold.Size = new Size(50, 19);
            ChkBold.TabIndex = 2;
            ChkBold.Text = "굵게";
            ChkBold.UseVisualStyleBackColor = true;
            ChkBold.CheckedChanged += ChkBold_CheckedChanged;
            // 
            // CboFonts
            // 
            CboFonts.FormattingEnabled = true;
            CboFonts.Location = new Point(43, 16);
            CboFonts.Name = "CboFonts";
            CboFonts.Size = new Size(177, 23);
            CboFonts.TabIndex = 1;
            CboFonts.SelectedIndexChanged += CboFonts_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "폰트";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PicImage);
            groupBox2.Controls.Add(BtnOpenImage);
            groupBox2.Location = new Point(399, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(383, 509);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "이미지 박스";
            // 
            // PicImage
            // 
            PicImage.BackColor = SystemColors.AppWorkspace;
            PicImage.Location = new Point(6, 22);
            PicImage.Name = "PicImage";
            PicImage.Size = new Size(371, 445);
            PicImage.SizeMode = PictureBoxSizeMode.StretchImage;
            PicImage.TabIndex = 4;
            PicImage.TabStop = false;
            // 
            // BtnOpenImage
            // 
            BtnOpenImage.Location = new Point(277, 473);
            BtnOpenImage.Name = "BtnOpenImage";
            BtnOpenImage.Size = new Size(100, 30);
            BtnOpenImage.TabIndex = 3;
            BtnOpenImage.Text = "이미지 열기";
            BtnOpenImage.UseVisualStyleBackColor = true;
            BtnOpenImage.Click += BtnOpenImage_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnCheck);
            groupBox3.Controls.Add(DtpBirth);
            groupBox3.Controls.Add(LblUrl);
            groupBox3.Controls.Add(TxtDay);
            groupBox3.Controls.Add(TxtMonth);
            groupBox3.Controls.Add(TxtYear);
            groupBox3.Controls.Add(CalSchedule);
            groupBox3.Location = new Point(786, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(383, 509);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "기타 컨트롤";
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(277, 200);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(100, 30);
            BtnCheck.TabIndex = 4;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // DtpBirth
            // 
            DtpBirth.Location = new Point(8, 202);
            DtpBirth.Name = "DtpBirth";
            DtpBirth.Size = new Size(200, 23);
            DtpBirth.TabIndex = 3;
            DtpBirth.ValueChanged += DtpBirth_ValueChanged;
            // 
            // LblUrl
            // 
            LblUrl.AutoSize = true;
            LblUrl.Location = new Point(8, 239);
            LblUrl.Name = "LblUrl";
            LblUrl.Size = new Size(43, 15);
            LblUrl.TabIndex = 2;
            LblUrl.TabStop = true;
            LblUrl.Text = "네이버";
            LblUrl.LinkClicked += LblUrl_LinkClicked;
            // 
            // TxtDay
            // 
            TxtDay.Location = new Point(277, 86);
            TxtDay.Name = "TxtDay";
            TxtDay.Size = new Size(100, 23);
            TxtDay.TabIndex = 1;
            // 
            // TxtMonth
            // 
            TxtMonth.Location = new Point(277, 57);
            TxtMonth.Name = "TxtMonth";
            TxtMonth.Size = new Size(100, 23);
            TxtMonth.TabIndex = 1;
            // 
            // TxtYear
            // 
            TxtYear.Location = new Point(277, 28);
            TxtYear.Name = "TxtYear";
            TxtYear.Size = new Size(100, 23);
            TxtYear.TabIndex = 1;
            // 
            // CalSchedule
            // 
            CalSchedule.Location = new Point(8, 28);
            CalSchedule.Name = "CalSchedule";
            CalSchedule.TabIndex = 0;
            CalSchedule.DateChanged += CalSchedule_DateChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(PrgProcess);
            groupBox4.Controls.Add(TrbProcess);
            groupBox4.Location = new Point(12, 139);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(383, 121);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "트랙바";
            // 
            // PrgProcess
            // 
            PrgProcess.Location = new Point(6, 73);
            PrgProcess.Maximum = 10;
            PrgProcess.Name = "PrgProcess";
            PrgProcess.Size = new Size(371, 23);
            PrgProcess.TabIndex = 1;
            // 
            // TrbProcess
            // 
            TrbProcess.Location = new Point(6, 22);
            TrbProcess.Name = "TrbProcess";
            TrbProcess.Size = new Size(371, 45);
            TrbProcess.TabIndex = 0;
            TrbProcess.Scroll += TrbProcess_Scroll;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(BtnMsgBox);
            groupBox5.Controls.Add(BtnModaless);
            groupBox5.Controls.Add(BtnModal);
            groupBox5.Location = new Point(12, 266);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(383, 75);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "모달, 모달리스";
            // 
            // BtnMsgBox
            // 
            BtnMsgBox.Location = new Point(246, 22);
            BtnMsgBox.Name = "BtnMsgBox";
            BtnMsgBox.Size = new Size(100, 40);
            BtnMsgBox.TabIndex = 0;
            BtnMsgBox.Text = "MessageBox";
            BtnMsgBox.UseVisualStyleBackColor = true;
            BtnMsgBox.Click += BtnMsgBox_Click;
            // 
            // BtnModaless
            // 
            BtnModaless.Location = new Point(140, 22);
            BtnModaless.Name = "BtnModaless";
            BtnModaless.Size = new Size(100, 40);
            BtnModaless.TabIndex = 0;
            BtnModaless.Text = "Modaless";
            BtnModaless.UseVisualStyleBackColor = true;
            BtnModaless.Click += BtnModaless_Click;
            // 
            // BtnModal
            // 
            BtnModal.Location = new Point(34, 22);
            BtnModal.Name = "BtnModal";
            BtnModal.Size = new Size(100, 40);
            BtnModal.TabIndex = 0;
            BtnModal.Text = "Modal";
            BtnModal.UseVisualStyleBackColor = true;
            BtnModal.Click += BtnModal_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(BtnNode);
            groupBox6.Controls.Add(BtnRoot);
            groupBox6.Controls.Add(LsvDummy);
            groupBox6.Controls.Add(TrvDummy);
            groupBox6.Location = new Point(12, 347);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(383, 189);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "트리뷰, 리스트뷰";
            // 
            // BtnNode
            // 
            BtnNode.Location = new Point(277, 153);
            BtnNode.Name = "BtnNode";
            BtnNode.Size = new Size(100, 30);
            BtnNode.TabIndex = 2;
            BtnNode.Text = "노드추가";
            BtnNode.UseVisualStyleBackColor = true;
            BtnNode.Click += BtnNode_Click;
            // 
            // BtnRoot
            // 
            BtnRoot.Location = new Point(176, 153);
            BtnRoot.Name = "BtnRoot";
            BtnRoot.Size = new Size(100, 30);
            BtnRoot.TabIndex = 2;
            BtnRoot.Text = "루트추가";
            BtnRoot.UseVisualStyleBackColor = true;
            BtnRoot.Click += BtnRoot_Click;
            // 
            // LsvDummy
            // 
            LsvDummy.LargeImageList = imageList1;
            LsvDummy.Location = new Point(195, 22);
            LsvDummy.Name = "LsvDummy";
            LsvDummy.Size = new Size(182, 125);
            LsvDummy.SmallImageList = imageList1;
            LsvDummy.TabIndex = 1;
            LsvDummy.UseCompatibleStateImageBehavior = false;
            LsvDummy.View = View.SmallIcon;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "folder-normal.png");
            // 
            // TrvDummy
            // 
            TrvDummy.ImageIndex = 0;
            TrvDummy.ImageList = imageList1;
            TrvDummy.Location = new Point(6, 22);
            TrvDummy.Name = "TrvDummy";
            TrvDummy.SelectedImageIndex = 0;
            TrvDummy.Size = new Size(183, 125);
            TrvDummy.TabIndex = 0;
            // 
            // DlgOpenImage
            // 
            DlgOpenImage.FileName = "openFileDialog1";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 561);
            Controls.Add(groupBox6);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UI컨트롤 윈앱";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicImage).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrbProcess).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label1;
        private TextBox TxtResult;
        private CheckBox ChkBold;
        private ComboBox CboFonts;
        private CheckBox checkBox1;
        private ToolStripStatusLabel LblState;
        private GroupBox groupBox4;
        private ProgressBar PrgProcess;
        private TrackBar TrbProcess;
        private GroupBox groupBox5;
        private Button BtnMsgBox;
        private Button BtnModaless;
        private Button BtnModal;
        private GroupBox groupBox6;
        private Button BtnNode;
        private Button BtnRoot;
        private ListView LsvDummy;
        private TreeView TrvDummy;
        private ImageList imageList1;
        private PictureBox PicImage;
        private Button BtnOpenImage;
        private OpenFileDialog DlgOpenImage;
        private DateTimePicker DtpBirth;
        private LinkLabel LblUrl;
        private TextBox TxtDay;
        private TextBox TxtMonth;
        private TextBox TxtYear;
        private MonthCalendar CalSchedule;
        private Button BtnCheck;
        private ToolStripMenuItem MnuFile;
        private ToolStripMenuItem MnuNewFile;
        private ToolStripMenuItem MnuExit;
        private ToolTip toolTip1;
    }
}
