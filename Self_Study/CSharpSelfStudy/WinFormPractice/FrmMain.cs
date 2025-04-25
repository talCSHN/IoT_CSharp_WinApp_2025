namespace WinFormPractice
{
    public partial class FrmMain : Form
    {
        private Button[] buttons = new Button[100];
        private int treasurePosition;  // 보물 위치

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++) 
            {
                string btnName = $"button{i + 1}";
                Button btn = this.Controls.Find(btnName, true).FirstOrDefault() as Button;
                if (btn != null)
                {
                    buttons[i] = btn;
                    btn.Tag = i;
                    btn.Click += Btn_Click;
                }
            }
            Random rand = new Random();
            treasurePosition = rand.Next(100);
            Console.WriteLine(treasurePosition);
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int index = (int)btn.Tag;

            if (index == treasurePosition)
            {
                btn.BackColor = Color.Gold;
                btn.Text = "👑";
                MessageBox.Show("보물 발견", "게임 승리", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame();
            }
            else
            {
                btn.Enabled = false;
                btn.Text = "❌";
            }
        }
        private void ResetGame()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i] != null)
                {
                    buttons[i].Enabled = true;
                    buttons[i].Text = "";
                    //buttons[i].BackColor = SystemColors.Control;
                    buttons[i].BackColor = Color.White;
                }
            }

            // 보물 위치 새로 설정
            Random rand = new Random();
            treasurePosition = rand.Next(100);
            Console.WriteLine(treasurePosition);
        }
    }
}
