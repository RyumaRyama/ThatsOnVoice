using Microsoft.Win32;
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

namespace ThatsOnVoice
{
    public partial class MainWindow : Window
    {
        private MicVolume mv;
        public MainWindow()
        {
            InitializeComponent();

            mv = new MicVolume();
            DataContext = mv;
            Volume_Mock();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // ダイアログのインスタンスを生成
            var dialog = new OpenFileDialog();

            // ファイルの種類を設定
            dialog.Filter = "雑音|*.mp3";

            // ダイアログを表示する
            if (dialog.ShowDialog() == true)
            {
                // 選択されたファイル名 (ファイルパス) をメッセージボックスに表示
                MessageBox.Show(dialog.FileName);
            }
        }

        private void Volume_Mock()
        {
            Random rand = new Random();
            //while (true)
            //{
            mv.volume_value = rand.Next(1, 100);
            //await Task.Delay(10);
            //}
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
