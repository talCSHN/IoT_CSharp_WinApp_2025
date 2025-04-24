namespace SyntaxWinApp01
{
    public partial class FmMain : Form
    {
        // 대리자(delegate) 선언
        delegate void MyDelegate(string msg);
        // 이벤트핸들러 대리자 선언
        delegate void MyEventHandler(object sender, EventArgs e);
        // 이벤트를 선언
        public event EventHandler SomethingHappened;

        // 대리자에서 호출할 메서드 - 대리자와 파라미터가 일치
        void SayHello(string msg)
        {
            MessageBox.Show($"안녕, {msg}", "메시지",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void SayGoodbye(string msg)
        {
            MessageBox.Show($"내일봐~ {msg}", "메시지",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public FmMain()
        {
            InitializeComponent();
            TxtLog.Text += ("1. 폼 생성자 실행\r\n");
        }

        private void FmMain_Load(object sender, EventArgs e) {
            TxtLog.Text += ("2. 폼로드 이벤트 실행\r\n");
        } 
        private void FmMain_Shown(object sender, EventArgs e) {
            TxtLog.Text += ("4. 폼숀 이벤트 실행\r\n");
        }
        private void FmMain_Activated(object sender, EventArgs e) {
            TxtLog.Text += ("3. 폼액티베이트 이벤트 실행\r\n");
        }
        private void FmMain_FormClosing(object sender, FormClosingEventArgs e) {
            TxtLog.Text += ("5. 폼클로징 이벤트 실행\r\n");
        }
        private void FmMain_FormClosed(object sender, FormClosedEventArgs e) {
            TxtLog.Text += ("6. 폼클로즈드 이벤트 실행\r\n");
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            // 1. 직접 호출
            SayHello("Hugo");
            SayGoodbye("Hugo"); // 메서드를 따로 호출

            // 2. 대리자(delegate) 호출(윈앱 개발 핵심!!)
            MyDelegate del = SayHello; // 대리자에 호출할 메서드를 묶어줌
            del += SayGoodbye; // 추가도 가능(대리자 체인 추가)
            del -= SayHello;  // (대리자 체인 삭제)
            del("Ashely");

            // 3. 반환값 없는 대리자 - Action(보기만 하세요)
            Action<string> act = SayHello;
            act("Chris");

            // 4. 반환값 있는 대리자 - Func(보기만 하세요)
            Func<int, int, int> add = (a, b) => a + b;
            int result = add(7, 8);
            Console.WriteLine(result);

            // 이벤트 실행
            if (SomethingHappened != null)
            {
                SomethingHappened(this, new EventArgs()); // 이벤트 실행
            }
        }

       
    }
}
