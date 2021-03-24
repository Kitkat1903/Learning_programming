using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
namespace Neurolab2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public void Window() => InitializeComponent();
        public void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true; //throw new NotImplementedException();
            MessageBoxResult result = MessageBox.Show(
                "Закрыть приложение?\nНесохранённые данные будут утрачены",
                "Neurolab2", MessageBoxButton.OKCancel);
            switch (result)
            {
                case MessageBoxResult.OK: e.Cancel = false; App.Current.Shutdown(); break;
                case MessageBoxResult.Cancel: e.Cancel = true; break;
            }
        }
        public async void Window_Loader(object sender, RoutedEventArgs e)
        {
            await Task.Run(() => Console.WriteLine("Это пример ассинхронного запуска метода."));
            // Core.Class1 q1 = default; Console.WriteLine("C# 9.0, .NET 5 x64");
            // do some other stuff
        }
        async void OnClickTestHelloWorld(object sender, RoutedEventArgs e)
        {
            await Task.Run(() =>
            MessageBox.Show(messageBoxText: "1")
            ); Tester tester = new(); //tester.Foo(/*exception*/);
            //btn1.(Window_Loader);
            MessageBox.Show("Hello, world!", "My App");
            btn0.Background = Brushes.Blue;
            MessageBoxResult result = MessageBox.Show(
                "Would you like to greet the world with a \"Hello, world\"?",
                "My App", MessageBoxButton.YesNoCancel);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Hello to you too!", "My App");
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("Oh well, too bad!", "My App");
                    break;
                case MessageBoxResult.Cancel:
                    MessageBox.Show("Nevermind then...", "My App");
                    break;
            }
            /* 
             Пример открытия второго окна с доступом к первому
            */
            /*
            // Извлечение ссылки на окно, содержащее текущую страницу
            App.Current.MainWindow = (Window)GetWindow(dependencyObject: new TestWindow());
            App.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
            App.Current.MainWindow.Show();
            /* 
             Пример открытия второго окна без доступа к первому
            //*/
            //Скрываем главную форму
            this.Visibility = System.Windows.Visibility.Collapsed;
            Window wind = (Window)new TestWindow();
            wind.Closed += (sender2, e2) => { //Отображаем форму после закрытия Window
                this.Visibility = System.Windows.Visibility.Visible;
            };
            //при отображении формы, материнская форма стаёт в режим ожидания как при отображении MessageBox
            wind.ShowDialog();
        }
    }
}
public class Tester
{
    public string Property { get; set; }
    public void Foo()
    {
        throw new NotImplementedException();
    }
    string Method(dynamic foo){return foo + foo;}
}