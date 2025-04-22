# IoT_CSharp_WinApp_2025
C#/WinApp 리포지토리

## 1일차

### C# 시작 전
- **Visual Studio Installer 확인**

    - **필수** - `ASP.NET 및 웹 개발`, `.NET 데스크톱 개발`
    - **옵션** - .NET Multi-Platform App Ui(MAUI) 개발

    <img src="./image/cs0001.png" width="700">

### C# 학습

#### C#이란?
- **C#** : **마이크로소프트**가 개발한 객체지향 프로그래밍 언어
    - 1991년 귀도 반 로섬 Python 개발(1989년 개발 시작)
    - 1985년, 비야네 스트롭스트룹 C++ 개발(너무 어려움, 1980년 초 개발 시작)
    - 1995년, 제임스 고슬링 Java 개발(C++ 문법 기반, 좀 더 쉬운 언어, 1991년 개발 시작)
    - Java 인기 폭발
    - MS가 썬 마이크로시스템즈와 라이센스 채결 후 MS용 Java인 J++ 개발. 특허권 소송 발생
    - 1999년, 파스칼과 델파이 개발한 `앤더스 헤일스버그`가 C++, Java 기반으로 C# 개발
    - 2000년, C# 발표
    - 2025년, C# 13.0

- **C# 특징**
    - 닷넷 플랫폼 위에서 동작(Managed C++, C#, Java, Python, ...)
    - 문법이 Java와 상당히 유사. C/C++보다 언어 난이도 낮음
    - Java와 달리 Unsafe mode 사용하면 C/C++ 포인터 기능 사용 가능
    - 런타임 시 `Garbage Collection`으로 자동으로 메모리 관리

- **C# 유머**
    - 1999년 앤더스 헤일스버그가 처음에 Cool(C-like Object Oriented Language)로 이름 지음
    - C# 의미 - C++보다 개선된 언어의 의미로 C++++, 또는 #(반올림)

- **C# 버전**
    - C# 1.x - 2002 ~ 2003년 / .NET Framework 1.x -> 문제 많음
    - C# 2.x - 2006년. / .NET Framework 2.x -> 개선 많이 됨
    - C# 3.x - 2007년. / .NET Framework 2.x ~ 3.5 -> Java와 차이 많아짐
    - C# 4.x - 2010년. / .NET Framework 4.x -> C#의 기반
    .
    .
    - C# 6.x - 2015년 / .NET Framework 4.6, .NET Core 1.x(리눅스)
    - C# 7.x - 2017 ~ 2018년 / .NET Framework 4.7, .NET Core 2.x(리눅스)
    .
    .
    - C# 9.0 - 2020년 / `.NET 5.0`(Framework, Core 통합)
    - C# 10.0 - 2021년 / .NET 6(소수점 삭제)
    - C# 11.0 - 2022년 / .NET 7
    - C# 12.x - 2023년 / .NET 8
    - C# 13.x - 2024 ~ 2025년 / .NET 9 (Visual Studio 2022에서 동작)

- **호환성, 범용성**
    - 초기 - Java는 OS 플랫폼에 독립적인 반면, C#은 Windows OS에서만 동작. 범용성 낮았음
    - 2016년 - Linux 공식 지원. MacOS에서도 사용 가능. 오픈소스 공표
    - 유니티 엔진 기본언어, Xamarin(이후 MAUI로 변경)로 모바일 개발 가능
    - 리눅스 닷넷 개발 프로젝트 Mono -> 이후 MS에 흡수

#### .NET Framework(.NET)
- `CLR(Common Language Runtime)` 클래스 사용하는 가상 머신. 예로 C#과 Java로 동시 개발 가능
- Java의 JVM과 유사한 개념
- 언어가 발전하면서 필요한 기능이 늘기 때문에 .NET Framework도 버전업 계속함
- 2015년 리눅스 지원 개발부터 .NET Framework가 너무 Windows 구조에 토착되다보니 새로운 프레인워크가 필요해짐
- .NET Core - 리눅스 지원용으로 만든 .NET [Framework]
- .NET Core와 .NET Framework 혼용
- 2020년 .NET Core와 .NET Framework 통합 -> .NET 5.0 공표. 이후부터 Framework, Core라는 이름 사라짐
- C# 버전, .NET 버전 숫자 차이나기 시작

- .NET 데스크톱 개발 설치하면 C#, Visual Basic, F# 등 여러 언어 사용 가능

- `C# 12.0` / `.NET 8`, `Visual Studio 2022` Community Edition에서 학습
***
## 2일차
- WinApp으로 문법 학습 - 문법 학습 후 WPF로 이전

### 윈앱 컨트롤 - tabindex
- `Button` : 마우스 클릭을 위한 컨트롤
    - 보통 Btn~으로 시작
    - `(Name)` : 소스코드 상에서 접근, 사용
    - Enabled : 사용여부
    - Location : 폼 상의 위치(x, y)
    - Size : 버튼 크기(w, h)
    - TabIndex : 실행 후 탭으로 포커스가 가는 순서
    - Text : 버튼 표시 글씨
    - Visible : 화면 표현여부
    - **Click** : 버튼 클릭 이벤트 처리 메서드 연결

- `Label` : 화면 상의 글자만 표현하는 컨트롤
    - 보통 Lbl~로 시작
    - Button 컨트롤과 동일
    - 이벤트를 거의 사용하지 않음

- `TextBox` : 텍스트 입력을 위한 컨트롤
    - 보통 Txt~로 시작
    - Button 컨트롤과 동일
    - BorderStyle : 컨트롤 테두리 설정
        - None
        - FixedSingle : 검은색 테두리
        - Fixed3D  : 입체감 있는 테두리
    - MaxLength : 최대 몇 자까지 적을 수 있는지
    - Multiline : 여러 줄 사용 여부. true가 되어야 높이 조절 가능
    - PlaceholderText : 입력 전 입력 내용 표시
    - ReadOnly : 입력 가능 여부. true - 입력불가
    - **TextChanged** : 글자가 변경되면 발생하는 이벤트
    - **KeyPress** : 키보드 입력이 생기면 발생하는 이벤트

- `ComboBox` : 여러 개 중 아이템을 선택하는 컨트롤
    - 보통 Cbo~ 로 시작
    - Button 컨트롤과 속성은 동일
    - Items(Collection) : 필요한 아이템 할당
    - **SelectedIndexChanged** : 선택한 아이템 순번이 바뀔 때 발생하는 이벤트
    - **SelectedValueChanged** : 선택한 아이템 값이 바뀔 때 발생하는 이벤트

- `RadioButton` : 여러 개 중 하나만 선택하는 컨트롤
    - 보통 Rdo~ 로 시작
    - Button 컨트롤과 속성은 동일
    - Checked : 체크 여부
    - 보통 이벤트 사용하지 않음

### C# 문법
- 기본 문법 - C++, Java와 거의 동일. C++와의 차이점만 비교
    1. 기본 구조 및 주석 - [소스](./day02/Day02Study/SyntaxWinApp01/FrmMain.cs)
        - 네임스페이스, 클래스, 메서드

        ```cs
        namespace ConsoleApp2
        {
            /// <summary>
            /// 프로그램 클래스
            /// </summary>
            internal class Program
            {
                static void Main(string[] args)
                {
                    /// <summary>
                    /// 주석 - XML 주석. 소스코드 자동 문서 생성 시 사용
                    /// </summary>
                    /// <param name="args">입력파라미터</param>
                    // 주석 - 한 줄 주석
                    Console.WriteLine("Hello, World!");
                    /*
                    * 주석 - 여러 줄 주석
                    * 여러 줄 작성할 때 편리
                    */
                }
            }
        }
        ```
    2. 자료형과 변수, Nullable
        - 변수 사용은 C++과 동일
        - 자료형도 C++과 유사하지만, 닷넷타입은 차이 존재
        - 닷넷타입은 여러 언어에서 공통으로 사용하기 위해 추가된 기능
        - Nullable : 특수타입. 데이터 타입 뒤에 ? 추가. null 할당 가능
        - var타입 : 지역변수에서 타입을 동적으로 지정. 컴파일 시 해당 타입으로 자동 지정
            - 지역변수만 가능(전역변수 사용불가)
            - 한 번 타입이 지정되면 다른 타입으로 변경 불가

    3. 연산자
        - C, C++과 동일

    4. 분기문, 반복문
        - if 문
        - switch 문
        - for 문
        - while 문

### 새 프로젝트(콘솔) 만들기
- 순서
    1. 새 프로젝트 만들기
        - 언어 : C#
        - 플랫폼 : 모든 플랫폼
        - 프로젝트 : 콘솔 선택(데스크톱, 웹, 콘솔 중中)
    2. 새 프로젝트 구성
        - 프로젝트 이름, 위치, 솔루션 이름
        - 솔루션 및 프로젝트를 같은 디렉토리에 배치 체크박스 해제 : 솔루션 내에 여러 프로젝트를 관리
    3. 추가 정보
        - 프레임워크 : .NET 8.0(장기 지원) 선택
        - 최상위 문 사용 안함 체크
    4. 스케폴딩 후 IDE 오픈

### 새 프로젝트(데스크톱, 윈앱) 만들기
- 아직 멀티플랫폼은 지원 안 됨(Windows만 지원)
- Windows Forms : 가장 오래된 윈앱 개발
- WPF : 디자인적으로 뛰어난 윈앱 개발
- 순서
    1. 언어, 플랫폼, 프로젝트 선택
        - 언어 : C#
        - 플랫폼 : 모든 플랫폼
        - 프로젝트 : 데스크톱 선택
    2. Windows Forms 앱 선택(.NET Framework가 안 적힌 것)
    3. 프로젝트명 입력
    4. 추가 정보
        - 프레임워크 : .NET 8.0 선택
        - LTS(Long Term Support) : 개발자가 기능, 보안 업데이트를 지원

- 프로젝트 구조
    - 종속성 : 필요 모듈 추가, 관리, 삭제
    - Form1.cs : 윈폼 앱 개발 로직
        - Form1.Designer.cs : 실제 디자인 소스
        - Form1.resx : 아이콘, 이미지, 리소스 문자열 관리 파일
    - Program.cs : 시작 프로그램 소스. 지우면 안 됨

### 솔루션 관리
- 하나의 솔루션에 여러 개 프로젝트가 있으면 시작 프로젝트가 선별되어야 함
- 굵은 글씨체로 나오는 프로젝트가 시작 프로젝트
    1. 시작 프로젝트로 변경할 프로젝트 > 마우스 오른쪽 버튼 > 시작 프로젝트로 설정
    2. 전체 솔루션 > 속성 > 속성 페이지
        - 시작 프로젝트 구성 메뉴 > 현재 선택 영역 선택

- 전체 솔루션 : *.sln(전체 솔루션 관리)
    - 프로젝트 파일(C#) : *.csproj
    - 프로젝트 파일(C++) : *.vcxproj

- debug/release 모드
    - debug : 개발 시 사용 모드. 디버깅 로그, 디버깅 위주
    - release : 배포 시 사용 모드. 프로그램 최적화, 성능 up

### 윈폼 앱 / 윈앱 개발 순서
1. Form1.cs 이름 변경 : FrmMain.cs
    - 변경 시 `모든 참조 이름도 바꾸시겠습니까?` 메시지 창
        - 반드시 `예` 선택

2. FrmMain.cs [디자인] 클릭 오픈
    - 마우스로 크기 조정

3. 속성 창(F4) 오픈, 솔루션 탐색기 아래쪽 드래그 후 붙이기

4. PyQt Designer와 거의 유사
    - FrmMain 속성 창 > Text > Form1 글자를 변경 후 엔터
    - Size 속성 > Width, Height를 직접 수정
    - StartPosition > CenterScreen으로 변경
    - MaximizeBox > False
    - FormBorderStyle > Sizable -> FixedSingle로 변경

5. 보기 > 도구 상자 클릭
    - 공용 컨트롤 > Button 드래그
    - 더블클릭, 클릭으로 선택 후 폼에서 왼쪽 버튼 누르고 드래그 등 다양함

6. 속성 창 - 드롭다운 컨트롤 클릭 > 여러 클래스 리스트

7. button1 속성 변경
    - (Name) > button1 -> BtnMsg 로 변경
    - Size 조정
    - Text > button1 -> 메시지 로 변경

8. 속성 창의 이벤트아이콘(번개 표시) 클릭
    - Click 선택 되어 있음
    - 버튼의 경우, 버튼 클릭이 기본 이벤트
    - Click 오른쪽 빈공간을 더블클릭
    - 버튼을 클릭했을 시 처리할 이벤트 메서드가 자동 생성

9. 새로 만든 컨트롤을 더블클릭
    - 이벤트 메서드가 자동 생성
    - 최초에 아무런 이벤트가 없을 때 기본 이벤트 메서드 생성

10. 오류 발생 시
    - 폼 디자인의 컨트롤 이벤트와 로직 코드 상의 이벤트 처리 메서드 생성 불일치로 발생
    - 이벤트 이름은 생성되고, 이벤트 정의 메서드는 생성이 안 된 상황

    <img src="./image/cs0002.png" width="600">

    - FrmMain.Designer.cs 파일 오픈 
    - Windows Form Designer generated code 탭 확장
    - 오류난 이벤트 이름 삭제
        - BtnMsg.Click += ...
        - BtnOK.Click += ...

11. MesasgeBox.Show() 작업
    - MessageBoxIcon.Warning, MesasgeBoxIcon.Error 사용 시 알람 사운드 발생

12. 폼 디자이너 화면과 코드 상 전환
    - F7(소스 코드 보기)
    - Shift + F7(디자인 전환)

13. VS에서 더블클릭 함부로 하지 말 것
    - 이벤트 메서드 생성, 컨트롤 자동 생성, 폼 디자인 표시 등에서만 사용

14. 두 개 이상의 컨트롤 선택 후 Ctrl키 누른 상태에서 드래그하면 그룹으로 복사
***
## 3일차

### Visual Studio Tip
- 가장 많이 사용할 단축키  : Alt + Enter

### 한글문제
- 한글 깨지는 문제
    - 콘솔 > Program.cs : UTF8 BOM 저장
    - 윈앱 > FrmMain.cs : EUC-KR(CP949) -> 깃헙에서 한글이 깨져서 나옴

- 각 IDE별 한글 깨짐 해결 방법
    - VS Code > 오른쪽 하단 상태표시줄 UTF-8 클릭 인코딩 하여 다시 열기 또는 인코딩 하여 저장 실행
    - VS > 다른 이름으로 저장 > 인코딩하여 저장 > UTF-8 선택 후 저장

- 깃 리포지토리
    - .git > config 파일 문서에디터로 오픈
    ```ini
    [i18n]
        commitEncoding = utf-8
        logOutputEncoding = utf-8
    ```

### 윈앱 컨트롤2
- 모든 컨트롤은 `Control` 클래스 상속
- `MaskedTextBox` : 사용자에게 주어진 형태로만 입력을 하도록 강제하는 텍스트 입력 컨트롤
    - 텍스트박스와 동일하게 Txt~ 로 시작
    - Button 컨트롤과 속성 동일
    - Mask : 사용자에게 입력을 제약할 포맷

- `GroupBox` : 관련있는 컨트롤들을 묶어주는 컨트롤
    - 이름을 절대 바꾸지 않음
    - Button 컨트롤과 속성 동일
    - Text 속성만 사용

- Button 이미지 추가
    1. 각 폼 별 리소스 사용
        - 속성 Image : ... 버튼
        - 리소스 선택 > 로컬 리소스 > 가져오기
        - FrmMain.resx에 저장
    2. 폼 위에 ImageLists 컨트롤 사용
        - 도구 상자 ImageList 컨트롤 드래그
        - 폼에 표현되는 컨트롤 아님
        - 이미지 사이즈를 개발자가 조정 가능
    3. 전체 리소스에 추가
        - Properties > Resources.resx
        - 속성 Image : ... 버튼
        - 리소스 선택 > 프로젝트 리소스 파일 > 가져오기
    4. Padding 속성
        - Left : 10 정도 지정
    5. 솔루션 탐색기 > 새 폴더
        - Resources 생성

- `PictureBox` : 이미지를 표현해주는 컨트롤
    - Pic~ 로 시작
    - BorderStyle : FixedSingle로 실선
    - BackColor : 폼색과 다르게 해서 영역표시
    - Enabled : 사용 여부
    - Image : 표시할 이미지 선택
    - Size : 크기
    - SizeMode : 들어가는 이미지 사이즈 형태
        - Normal : 큰 이미지는 잘려서 나옴
        - StretchImage : 픽쳐박스 크기에 맞춰서 표시
        - AutoSize : 이미지 크기에 픽쳐박스 크기 조정
        - Centerimage : 이미지를 중앙에 표시
        - Zoom : 확대
    - 들어갈 이미지 속성
        - 출력 디렉토리로 복사 : 항상 복사 로 변경


### 윈앱 개발기능
1. Debug - 디버깅 시 필요한 기능 담은 클래스
    - Debug.WriteLine() : 디버그 > 창 > `출력`에 디버깅 로그 출력
    - 디버깅 시작으로 실행 시만 출력

2. 프로젝트 속성
    - 출력 유형 : Win 애플리케이션 > 콘솔 애플리케이션으로 변경
    - Console.WriteLine() 사용

### C# 문법
- 기본 문법
    1. 문자열 처리 - [소스](./day02/Day02Study/SyntaxWinApp04/FrmMain.cs)
        - 콘솔에서 입력되는 값 -> 모두 문자열
        - 윈앱에서 TextBox에서 입력되는 값 -> 모두 문자열

        <img src="./image/cs0004.png" width="600">
    2. 클래스와 객체, 메서드 - [소스](./day03/Day03Study/SyntaxWinApp01/Person.cs)
        - 객체를 생성하는 틀
        - 명사(멤버변수, 속성), 동사(멤버메서드)
        - getter/setter
    3. 접근제어자
        - `private` : 클래스 내에서만 접근 가능
        - `public` : 어디서나 접근 가능
        - `protected` : 내부, 자식클래스에서만 접근 가능
        - `internal` : 동일한 네임스페이스에서 public
        - `internal protected` : 동일한 네임스페이스에서 protected 기능
        - internal은 최근에 자동생성에서 자주 사용되고 있음

        <img src="./image/cs0007.png" width="600">

    4. 상속, 다형성, 추상클래스, 인터페이스 - [소스](./day03/Day03Study/SyntaxWinApp02/Computer.cs)
        - Java는 한 파일에 한 클래스 선호
        - C#은 한 파일에 클래스 여러 개 생성 무방
        - 상속
            - 부모클래스에 자식객체 할당 가능
        - sealed : 더 이상 상속하고 싶지 않을 때
        - is, as : 객체 타입을 비교, 형변환 키워드
        - System.Object : 모든 클래스의 조상
        - this : 클래스 자신. 현재는 사용 권장 안 함
        - base : 부모클래스 지칭. 현재는 사용 권장 안 함
        - 다형성 오버라이드 : 부모 메서드를 재정의
            - 부모클래스와는 다르게 동작하고자 함
            - 추상 : 대략적인 틀만 가지고 있음
            - 이름과는 다르게 실행할 수 있는 능력 부여
            - 부모메서드는 virtual 키워드
            - 자식메서드는 override 키워드
        - 다형성 오버로드 : 같은 메서드를 여러 번 사용
            - 파라미터 형태와 갯수에 따라 무한대로 같은 이름의 메서드 생성 가능
        - 인터페이스 : 계약관계 정의하고 구현없이 선언만 포함한 클래스의 일종
            - 추상클래스 개선한 방법
            - 추상클래스는 구현을 가질 필요 없이 하위에서 상속된 자식클래스가 다시 구현
            - 문제는 추상클래스도 구현을 가지고 있음 -> 이해도가 떨어짐
            - 다중 상속을 방지하기 위해 인터페이스 사용
            - I인터페이스명 형태로 명명
            - 내부 메서드만 존재. 형태만 구성(구현 없음)
            - 인터페이스는 직접 코딩하지 말 것
            - Alt + Enter > 인터페이스 구현 선택
            - 인터페이스는 사용 갯수에 제약 없음. 다중 구현 대체

        - 얕은 복사, 깊은 복사
            - 얕은 복사 : 내부를 같이 참조하는 형태
            - 깊은 복사 : 완전히 새로 객체 생성
        
        <img src="./image/cs0006.png" width="600">
        
        - ref, out 키워드
        - 열거형

## 4일차
### C# 기본 문법
- 기본 문법
    5. 상속, 다형성, 추상클래스, 인터페이스
    6. 예외철
    7. 컬렉션
    8. 파일 입출력
    9. 델리게이트, 이벤트
    10. 람다식
    11. LINQ
    12. 비동기
    13. 속성
    14. 제네릭


## 10일차

### 코테