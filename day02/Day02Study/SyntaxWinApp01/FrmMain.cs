namespace SyntaxWinApp01
{
    public partial class FrmMain : Form
    {
        //var int05 = 10;   // var는 전역변수 사용 불가

        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            // 정수 자료형
            sbyte byteVal = 127;                            // signed byte : -128 ~ 127 수 저장(1 byte)
            System.SByte sbtVal2 = System.SByte.MinValue;   // -128 할당
            byte btVal = 255;                               // byte : 0 ~ 255(1 byte)
            System.Byte btVal2 = System.Byte.MinValue;      // 0 할당
            short stVal = 32767;                            // short : -32768 ~ 32767
            System.Int16 stVal2 = System.Int16.MinValue;    // -32768 할당
            ushort ustVal = 65535;                          // unsigned short : 0 ~ 65535(2 bytes)
            System.UInt16 ustVal2 = System.UInt16.MinValue; // 0 할당
            int intVal = 2147483647;                        // int : -21억 ~ 21억(4 byte)
            System.Int32 intVal2 = System.Int32.MinValue;   // -21억 할당
            uint uintVal = 4294967295;                      // unsigned int : 0 ~ 42억(4 bytes)
            System.UInt32 uintVal2 = System.UInt32.MinValue;// 0 할당
            long lngVal = 90000000000000000;                // long : -92경 ~ 92경
            ulong ulngVal = 18000000000000000000;           // unsigned long : 1800경(8 bytes)
            System.Int64 longVal02;                         // (8 bytes)
            System.Int128 longVal03;                        // (16 bytes)

            // 실수 자료형
            float fVal = 3.141592f;                         // float : 4bytes 소수점
            System.Single fVal2 = System.Single.MinValue;   // +-1.5e-45 할당
            double dVal = 3.141592;                 // double : 8bytes 소수점
            System.Double dVal2;
            decimal dcVal = 3.141592m;              // decimal : 16bytes 소수점
            System.Decimal dcVal2;

            // 문자형 타입
            char ch01 = 'A';
            System.Char ch03 = 'B';
            Console.WriteLine(ch01);
            char ch02 = '\u25b6';
            Console.WriteLine(ch02);

            string str01 = "Hello\0World";  // \0 : end of line
            System.String str02 = "Hello C#";

            // boolean 타입
            bool bool01 = true;
            System.Boolean bool02 = false;

            // Nullable
            //int int02 = null;   // 기본타입(정수형, 실수형, 불린)은 NULL을 할당할 수 없음
            int? int03 = null;    // 기본타입 뒤에 ? 붙임

            // 상수타입
            const int int04 = 15;
            //int04 = 26;           // const -> 상수. 한 번 할당 후 변경 불가

            // 동적타입 - 컴파일되면서 해당 타입으로 형 결정
            var int05 = false;
            //int05 = string;

            //int int05 = 15;

            //MessageBox.Show(intVal2.ToString() + ch01 + ch02, "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            MessageBox.Show(int03.ToString(), "Variable", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            MessageBox.Show("메시지", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
