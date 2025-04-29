using MySql.Data.MySqlClient;
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

namespace WpfStudyApp01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // XAML Binding 방식
        public List<KeyValuePair<string, string>> divisionItems { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadDivisionFromDatabase();

            this.DataContext = this;    // 항상 이렇게 사용
        }
        private void LoadDivisionFromDatabase()
        {
            divisionItems = new List<KeyValuePair<string, string>>();   // 반드시 객체 생성 초기화
            // 1. 연결문자열
            string connectionString = "Server=localhost;Database=bookrentalshop;Uid=root;Pwd=12345;Charset=utf8;";
            
            // 2. 쿼리문자열
            string query = "SELECT division, names FROM divtbl";

            // DB연결객체
            using (MySqlConnection conn =  new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    // 4. 명령실행객체
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    // 5. 실행결과 리더 객체
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        var division = reader.GetString("division");
                        var names = reader.GetString("names");

                        divisionItems.Add(new KeyValuePair<string, string>(division, names));
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"DB연결 실패 : {ex.Message}", "오류", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

    }
}