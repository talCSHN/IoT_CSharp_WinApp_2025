namespace WinControlsApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            // OS 전체 폰트 가져오기
            var Fonts = FontFamily.Families;
            //CboFonts.Items.AddRange(Fonts);
            foreach (var Font in Fonts)
            {
                CboFonts.Items.Add(Font.Name);
            }
            LblState.Text = "상태 : 폰트 로드 완료";

            toolTip1.SetToolTip(BtnModal, "모달창 연습 버튼");
            toolTip1.SetToolTip(TxtYear, "달력 선택 년도 표시");
        }

        private void CboFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void ChkBold_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFont();
        }
        private void ChangeFont()
        {
            if (CboFonts.SelectedIndex < 0) return; // 폰트 선택 안 한 경우
            FontStyle style = FontStyle.Regular;    // 0 대신 Regular
            if (ChkBold.Checked) style |= FontStyle.Bold;   // FontStyle.Regular | FontStyle.Bold => 0000 | 0001 = 0001
            if (checkBox1.Checked) style |= FontStyle.Italic; // 0001 | 0010 => 0011

            // CboFonts에서 선택된 글자, 글자 크기 12, 글자체 스타일 적용
            TxtResult.Font = new Font((string)CboFonts.SelectedItem, 12, style);
        }

        private void TrbProcess_Scroll(object sender, EventArgs e)
        {
            PrgProcess.Value = TrbProcess.Value;
        }

        private void BtnModal_Click(object sender, EventArgs e)
        {
            Form frmModal = new Form();
            frmModal.Text = "모달창";
            frmModal.Width = 300;
            frmModal.Height = 100;
            frmModal.BackColor = Color.Red;
            frmModal.StartPosition = FormStartPosition.CenterParent; // 부모창의 정중앙
            frmModal.ShowDialog(); // 모달창 띄우기
        }

        private void BtnModaless_Click(object sender, EventArgs e)
        {
            Form frmModaless = new Form();
            frmModaless.Text = "모달리스창";
            frmModaless.Width = 300;
            frmModaless.Height = 100;
            frmModaless.BackColor = Color.Green;
            // 모달리스창을 모달창처럼 메인창 정중앙에 위치하려면 계산 필요
            frmModaless.StartPosition = FormStartPosition.Manual;
            frmModaless.Location = new Point(this.Location.X + (this.Width - frmModaless.Width) / 2,
                                             this.Location.Y + (this.Height - frmModaless.Height) / 2);
            frmModaless.Show(this); // 모달리스창 띄우기
        }

        private void BtnMsgBox_Click(object sender, EventArgs e)
        {
            // 메세지박스 -> 모달창
            MessageBox.Show(TxtResult.Text, "텍스트박스문장",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnRoot_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            TrvDummy.Nodes.Add(rand.Next().ToString());
            TreeToList();
        }

        private void BtnNode_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            if (TrvDummy.SelectedNode == null)
            {
                MessageBox.Show("노드를 선택하세요", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            TrvDummy.SelectedNode.Nodes.Add(rand.Next().ToString());
            TrvDummy.SelectedNode.Expand(); // 트리확장 : Expand, 트리축소 Collapse
            TreeToList();
        }
        private void TreeToList()
        {
            LsvDummy.Items.Clear();
            foreach (TreeNode node in TrvDummy.Nodes)
            {
                TreeToList(node);
            }
        }
        private void TreeToList(TreeNode node)
        {
            ListViewItem item = new ListViewItem(new String[] { node.Text, node.FullPath.Count(f => f == '\\').ToString() });
            item.ImageIndex = 0;
            LsvDummy.Items.Add(item);
            foreach (TreeNode subNode in node.Nodes)
            {
                TreeToList(subNode);    // 재귀호출
            }
        }

        private void BtnOpenImage_Click(object sender, EventArgs e)
        {
            DlgOpenImage.Title = "이미지 열기";
            DlgOpenImage.FileName = "";
            DlgOpenImage.Filter = "Image Files(*.bmp;*.jpg;*.png)|*.bmp;*.jpg;*.png";

            if (DlgOpenImage.ShowDialog() == DialogResult.OK)
            {
                PicImage.Image = Bitmap.FromFile(DlgOpenImage.FileName);
                PicImage.SizeMode = PictureBoxSizeMode.Zoom;    // PictureBoxSizeMode.Zoom 이미지 원본대로 볼 수 있는 모드
                // PictureBoxSizeMode.StretchImage; -> 
            }
        }

        private void CalSchedule_DateChanged(object sender, DateRangeEventArgs e)
        {
            //MessageBox.Show(CalSchedule.SelectionStart.ToString());
            TxtYear.Text = CalSchedule.SelectionStart.Year.ToString();
            TxtMonth.Text = CalSchedule.SelectionStart.Month.ToString();
            TxtDay.Text = CalSchedule.SelectionStart.Day.ToString();
        }

        private void DtpBirth_ValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(DtpBirth.Value.ToString(), "생일", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            MessageBox.Show(DtpBirth.Value.ToString(), "생일", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MnuExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료 여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.FormClosing -= FrmMain_FormClosing;    // 폼 클로징 이벤트 삭제
                Application.Exit(); // 프로그램 완전 종료
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "종료 여부", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; // No 누르면 종료 시키지 않음
            }
        }

        private void LblUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo {
                FileName = "https://www.naver.com",
                UseShellExecute = true,
            });
        }
    }
}
