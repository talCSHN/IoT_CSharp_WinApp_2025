using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyntaxWinApp02
{
    // 아래 메서드들은 인터페이스를 구현(상속의 일종)하는 클래스에서 재정의 해야함
    internal interface IMobile
    {
        // 구현이 없음
        void Call();
        string GetList();
    }
}
