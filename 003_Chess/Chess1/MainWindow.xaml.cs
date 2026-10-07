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

namespace Chess1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitGame();
        }
        public void InitGame()
        {
            for(int zeile = 0; zeile < 8; zeile++)
            {
                for(int spalte = 0; spalte < 8; spalte++)
                {
                    Canvas rect = new Canvas();
                    if(zeile%2 ==  spalte % 2)
                    rect.Background = Brushes.Black;
                    else
                    rect.Background = Brushes.White;

                    this.SpielFeldVisualisierung.Children.Add(rect);
                }


            }
            
            

            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new ImageBrush();

        }
    }
}