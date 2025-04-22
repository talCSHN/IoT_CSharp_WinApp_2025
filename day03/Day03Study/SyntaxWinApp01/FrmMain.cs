namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // 기본 생성자
            Person ichikawa = new Person();
            ichikawa.Name = TxtName.Text.Trim();
            ichikawa.Age = int.Parse(TxtAge.Text.Trim());
            ichikawa.Gender = char.Parse(TxtGender.Text.Trim());
            ichikawa.Phone = TxtNum.Text.Trim();

            // 매개변수 생성자
            Person yamada = new Person("안나", 16, 'F', "010-9876-5432");

            TxtResult.Text += ichikawa.ToString();
            ichikawa.GetUp();
            ichikawa.GotoSchool();

            // static일 경우 객체 생성하지 않음
            // 인스턴스명.메서드 X. 타입.메서드 O
            Person.getNumber();
        }
    }
}
