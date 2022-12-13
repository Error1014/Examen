using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Examen.Pages
{
    /// <summary>
    /// Логика взаимодействия для AutorisationPage.xaml
    /// </summary>
    public partial class AutorisationPage : Page
    {
        public AutorisationPage()
        {
            InitializeComponent();
        }

        private void Autorization(object sender, RoutedEventArgs e)
        {
            string Login = LoginBox.Text;
            string Password = PasswordBox.Text;
            if (Login=="1"&&Password=="1111")
            {
                //Менеджер
                MainWindow.MainWindowFrame.Content = new Pages.TaskPage(1);
            }
            else if (Login == "0" && Password == "0000")
            {
                //Исполнитель
                MainWindow.MainWindowFrame.Content = new Pages.TaskPage(2);
            }
        }
    }
}
