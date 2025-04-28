using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfStudyApp04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> fruitItems { get; set; }
        public Dictionary<string, string> countryItems { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fruitItems = new ObservableCollection<string>
            {
                "호날두",
                "메시",
                "박관호",
                "노무현",
                "이명박"
            };

            countryItems = new Dictionary<string, string>
            {
                { "KR", "대한민국" },
                { "US", "미국" },
                { "JP", "일본" },
                { "CN", "중국" },
                { "IN", "인도" },
                { "PH", "필리핀" },
            };

            // 윈앱의 컨트롤.DataSource와 동일한 속성
            //CboCollection.DataContext = fruits;
            CboCollection.ItemsSource = fruitItems;

            LoadDivisionFromDatabase();

            // WPF xaml의 전체 데이터컨텍스트에 현재값 바인딩
            // this.DataContext = this;와 동일
            // 대신 데이터를 전달하는 레벨은 다름
            this.DataContext = this;   // 반드시 해줘야 함
            //CboFruits.DataContext = this; // 조심해야 함
        }

        private void LoadDivisionFromDatabase()
        {
            // DB연결 문자열(DB연결 정보)
            string connectionString = "Server=localhost;Database=bookrentalshop;Uid=root;Password=12345;Charset=utf8;";
            string query = "SELECT Division, Names FROM divtbl";    // 프로그래밍 언어에서 쿼리 작성 시 ; 사용 x

            List<KeyValuePair<string, string>> divisions = new List<KeyValuePair<string, string>>();

            // DB연결, 처리, 할당. using을 쓰면 db.close()를 using문이 대신 실행
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var division = reader.GetString("Division");    // reader.GetString(0)은 지양
                        var names = reader.GetString("Names");

                        divisions.Add(new KeyValuePair<string, string>(division, names));
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"DB연결 실패 : {ex.Message}", "오류", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                // conn.Close(); // using문 쓰면 할 필요 없음
            }   // 자동으로 conn.close() 실행

            CboDivision.ItemsSource = divisions;
        }

        private void CboCountries_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Debug.WriteLine(CboCountries.SelectedItem);
            string value = ((KeyValuePair<string, string>)CboCountries.SelectedItem).Value;
            MessageBox.Show(value, "선택한 국가", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}