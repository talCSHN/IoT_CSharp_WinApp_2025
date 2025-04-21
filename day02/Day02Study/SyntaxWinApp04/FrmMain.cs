namespace SyntaxWinApp04
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            if (TxtName.Text == "" || TxtAge.Text == "")
            {
                MessageBox.Show("말을 해, 쿄타로군.");
                return; // 메서드 탈출
            }
            else
            {
                // 위의 문제가 없을 때 동작
                LblResult.Text = "뭔가 처리될 거임";
                TxtResult.Text = "뭔가 처리될 거임";
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
