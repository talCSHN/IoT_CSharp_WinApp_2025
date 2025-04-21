namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TxtResult.BackColor = Color.FromArgb(100, 255, 255, 255); // 반투명 흰색
            //TxtPain.BorderStyle = BorderStyle.None; // 테두리 없애기
        }
        private void BtnMsg_Click(object sender, EventArgs e)
        {
            // 분기문
            // if ~ else 문
            if (TxtPain.Text == "아니오")
            {
                MessageBox.Show("쿄타로군, 아프면 안 돼");
            }
            else if (TxtPain.Text == "네")
            {
                string PainPoint = CboPainPoint.SelectedItem.ToString();
                // switch 문
                switch (PainPoint)
                {
                    /*
                     * 머리
                     * 눈
                     * 코
                     * 목
                     * 가슴
                     * 배
                     */
                    case "머리":
                        MessageBox.Show("쿄타로군, 나 머리 아파");
                        break;
                    case "눈":
                        MessageBox.Show("쿄타로군, 나 눈 아파");
                        break;
                    case "코":
                        MessageBox.Show("쿄타로군, 나 코 아파");
                        break;
                    case "가슴":
                        MessageBox.Show("쿄타로군, 나 가슴 아파");
                        break;
                    case "배":
                        MessageBox.Show("쿄타로군, 나 배 아파");
                        break;
                }
            }

        }

        private void TxtPain_KeyPress(object sender, KeyPressEventArgs e)
        {
            // KeyPress에서 엔터를 입력하면. 
            // C, C++ if문과 동일
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show(TxtPain.Text, "입력값");
            }
        }

        private void CboPainPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPoint = CboPainPoint.SelectedItem.ToString();
            MessageBox.Show(selectedPoint, "통증 부위");
        }

        private void LblPainPoint_Click(object sender, EventArgs e)
        {

        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            // for문
            for (int x = 2; x < 10; x++)
            {
                for (int y = 1; y < 10; y++)
                {
                    var result = x + "x" + y + "=" + (x * y);
                    TxtResult.Text += result + " ";
                }
                TxtResult.Text += "\r\n";   // 원래 윈도우는 \r\n 같이 써야함
            }
        }

        int clickNum = 0;

        private void BtnWhile_Click(object sender, EventArgs e)
        {
            // 무한 반복
            while (true)
            {
                MessageBox.Show("계속" + clickNum);
                clickNum++;

                if (clickNum == 10)
                {
                    break;
                }
            }
        }
    }
}
