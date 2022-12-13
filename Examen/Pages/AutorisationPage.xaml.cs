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
            DateTime dateTime = DateTime.Today;

            ToDayDate.Text = dateTime.Day.ToString() + "." + dateTime.Month.ToString() + "." + dateTime.Year.ToString();
            int TaskCount = TipoEkzEntities.GetContext().Task.Where(x => x.StatusID == 2).Count();
            TaskActiv.Text = TaskCount.ToString();
            // 5 и 20 числа выдают зп
            if (dateTime.Day>5&&dateTime.Day<=20)
            {
                DoZP.Text=5+"."+dateTime.Month+"."+dateTime.Year.ToString();
            }
            else
            {
                DoZP.Text = 20 + "." + dateTime.Month + "." + dateTime.Year.ToString();
            }

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
