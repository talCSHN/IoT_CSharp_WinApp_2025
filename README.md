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

## 2일차
- WinApp으로 문법 학습 - 문법 학습 후 WPF로 이전

### C# 문법

## 10일차

### 코테