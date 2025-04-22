using SyntaxWinApp02.Properties;

namespace SyntaxWinApp02
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCheck_Click(object sender, EventArgs e)
        {
            //Computer myCom = new Computer();
            //Laptop myLaptop = new Laptop();
            //Server yourServer = new Server();

            //Computer yourCom = new Laptop();        // 부모클래스에 자식 객체 할당. Upcasting
            //Laptop youLaptop = new Computer();    // 자식클래스에 부모 객체 할당 불가. Downcasting
            switch (CboDivision.SelectedIndex)
            {
                case 0: // Computer
                    Computer myCom = new Computer();
                    PicComputer.Image = Resources.computer_case;
                    myCom.Boot();
                    myCom.Reset();
                    myCom.ShutDown();
                    break;
                case 1: // Laptop
                    Laptop myLaptop = new Laptop();
                    PicComputer.Image = Resources.laptop;

                    myLaptop.Boot();
                    myLaptop.Reset();
                    myLaptop.ShutDown();    // 부모와 다르게 동작

                    // Computer sCom = myLaptop;
                    // 부모클래스를 자식클래스로 형변환하면서 문제발생 가능
                    //Laptop myLap2 = (Laptop)new Computer();
                    Computer myComputer = new Laptop();

                    if (myComputer is Laptop)
                    {
                        Console.WriteLine("myComputer는 Laptop입니다.");
                        Laptop myLap2 = myComputer as Laptop;
                        Console.WriteLine("myComputer를 Laptop으로 변경.");
                    }
                    // 지문인식 확인
                    bool hasFinger = myLaptop.HasFingerScanDevice();
                    Console.WriteLine($"최초 지문인식여부 :: {hasFinger}");
                    // 메서드 오버로드
                    hasFinger = myLaptop.HasFingerScanDevice(true);
                    Console.WriteLine($"최종 지문인식여부 :: {hasFinger}");

                    break;

                case 2: // Server
                    Server yourServer = new Server();
                    PicComputer.Image = Resources.server;
                    break;
                default:
                    break;
            }
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Server server1 = new Server();
            server1.Name = "HP서버";

            Server server2 = server1;   // 얕은 복사 : 같은 내용 참조
            server2.Name = "DELL서버";

            bool isSame = server1.Name == server2.Name;
            Console.WriteLine(isSame);
            MessageBox.Show($"{server1.Name}\r\n{server2.Name}", "서버명");

            // 깊은 복사 : 완전 다른 객체로 복사
            Server server3 = server1.DeepCopy();
            server3.Name = "INTEL서버";

            isSame = server2.Equals(server3);
            Console.WriteLine(isSame);

            MessageBox.Show($"{server1.Name}\r\n{server3.Name}", "서버명");


        }
    }
}
