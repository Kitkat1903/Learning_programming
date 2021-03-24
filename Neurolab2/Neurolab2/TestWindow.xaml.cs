using System.Windows;
namespace Neurolab2
{
    /// <summary>
    /// Логика взаимодействия для TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        public TestWindow() => InitializeComponent();
        private void MenuItem_Click(object sender, RoutedEventArgs e) => new Tester().Foo();
    }
}