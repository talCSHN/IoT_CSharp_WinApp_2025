namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        private string filePath = "sample.rtf"; // Rich Text Format(msWord 유사)
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //string filePath = "sample.txt"; // 파일 저장
            // 3. SaveFileDialog 사용
            DlgSave.FileName = string.Empty;
            DlgSave.Filter = "RTF파일 (*.rtf)|*.rtf|Txt파일 (*.txt)|*.txt";
            DlgSave.Title = "문서파일 저장";

            if (DlgSave.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fullPath = DlgSave.FileName;
                    string ext = Path.GetExtension(fullPath);  // .rtf, .txt 

                    if (ext == ".rtf")
                        RtbNote.SaveFile(fullPath, RichTextBoxStreamType.RichText);
                    else if (ext == ".txt")
                        RtbNote.SaveFile(fullPath, RichTextBoxStreamType.PlainText);

                    MessageBox.Show("파일이 저장되었습니다.", "파일저장",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"저장 실패 : {ex.Message}", "파일저장",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //try
            //{
            //    // 1. File 파일관련된 메서드가 포함된 클래스
            //    // 일반 Txt파일 저장
            //    //File.WriteAllText(filePath, RtbNote.Text);

            //    // 2. Rich Text Format으로 저장
            //    RtbNote.SaveFile(filePath, RichTextBoxStreamType.RichText);

            //    MessageBox.Show("파일이 저장되었습니다.", "파일저장",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"저장 실패 : {ex.Message}", "파일저장",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //string filePath = "sample.txt"; //읽어올 파일
            // 3. OpenFileDialog 사용
            DlgOpen.FileName = string.Empty; // == "";
            DlgOpen.Filter = "RTF파일 (*.rtf)|*.rtf|Txt파일 (*.txt)|*.txt";
            DlgOpen.Title = "문서파일 읽기";

            // 다이얼로그창 열기(DialogResult.OK), 취소(DialogResult.Cancel)
            if (DlgOpen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string fullPath = DlgOpen.FileName;
                    string ext = Path.GetExtension(fullPath);  // .rtf, .txt 

                    if (ext == ".rtf")
                        RtbNote.LoadFile(fullPath, RichTextBoxStreamType.RichText);
                    else if (ext == ".txt")
                        RtbNote.LoadFile(fullPath, RichTextBoxStreamType.PlainText);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"읽기 실패 : {ex.Message}", "파일읽기",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //try
            //{
            //    if (File.Exists(filePath))
            //    {
            //        // 1. 일반 텍스트 로드
            //        //string content = File.ReadAllText(filePath);
            //        //RtbNote.Text = content;

            //        // 2. Rich Text Format 로드
            //        RtbNote.LoadFile(filePath, RichTextBoxStreamType.RichText);
            //    }
            //    else
            //    {
            //        MessageBox.Show("파일이 존재하지 않습니다", "파일읽기",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"읽기 실패 : {ex.Message}", "파일읽기",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void BtnRed_Click(object sender, EventArgs e)
        {
            // RtbNote.SelectionColor = Color.Red;
            if (RtbNote.SelectionLength > 0)
            {
                if (DlgColor.ShowDialog() == DialogResult.OK)
                {
                    RtbNote.SelectionColor = DlgColor.Color;
                }
            }
        }

        private void BtnBold_Click(object sender, EventArgs e)
        {
            Font currFont = RtbNote.SelectionFont;
            FontStyle newStyle;

            if (currFont.Bold)
            {
                newStyle = currFont.Style & ~FontStyle.Bold; // Bold 제거
            }
            else
            {
                newStyle = currFont.Style | FontStyle.Bold; // Bold 추가
            }

            RtbNote.SelectionFont = new Font(currFont, newStyle);
        }
    }
}
