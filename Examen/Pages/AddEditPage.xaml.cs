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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Task SelectTask = new Task();
        private User MyUser = new User();   
        public AddEditPage(Task SelectTask, User MyUser)
        {
            InitializeComponent();
            this.MyUser = MyUser;
            this.SelectTask = SelectTask;
        }

        private void Save(object sender, RoutedEventArgs e)
        {

        }

        private void Back(object sender, RoutedEventArgs e)
        {
            MainWindow.MainWindowFrame.Content = new Pages.TaskPage(MyUser,2);
        }
    }
}
