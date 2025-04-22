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
                //LblResult.Text = "뭔가 처리될 거임";
                //TxtResult.Text = "뭔가 처리될 거임";

                string name = TxtName.Text.Trim();  // 앞뒤 여백 제거
                // 파싱 -> 분석해서 형 변환
                DateTime birthdate = DateTime.Parse(TxtAge.Text.Trim());
                int age = DateTime.Now.Year - birthdate.Year;
                // 3항식 분기
                string gender = RdoMale.Checked ? "남" : "여";
                
                // 옛날 방식 문자열 포맷팅
                //TxtResult.Text = "저는" + name + "이고" + birthdate + "에 태어난" + age + "살" + gender + "자 입니다.";
                // 최신 방식 문자열 포맷팅 $""
                //TxtResult.Text = $"저는 {name}이고, {birthdate:yyyy-MM-dd}에 태어난 {age:F2}살 {gender}자입니다.";
                TxtResult.Text = $"{name}군. {birthdate:yyyy-MM-dd}생, {age:F2}살 {gender}자. 기억해둘게!";

            }
        } 

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
