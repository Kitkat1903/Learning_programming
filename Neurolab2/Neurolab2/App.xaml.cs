using System.Windows;
namespace Neurolab2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /*
         * Вместо того, чтобы оборачивать каждую строчку кода в блок try-catch, можно воспользоваться механизмом WPF,
         * позволяющим глобально обрабатывать исключения - использовать события DispatcherUnhandledException в глобальном App.Xaml
         * Например, throw new NotImplementedException(); не вызовет падение приложения, но будет выведено сообщение об ошибке, а
         * затем приложение продолжит работать дальше как ни в чём ни бывало, не требуя отладки (если запущено без Visual Studio)
         */
        private void Application_DispatcherUnhandledException(object sender,
            System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("An unhandled exception just occurred: " + e.Exception.Message,
                "Exception Sample", MessageBoxButton.OK, MessageBoxImage.Warning);
            e.Handled = true;
        }
    }
}