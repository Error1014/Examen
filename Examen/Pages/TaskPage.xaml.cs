using System;
using System.Collections.Generic;
using System.IO;
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
    /// Логика взаимодействия для TaskPage.xaml
    /// </summary>
    public partial class TaskPage : Page
    {
        private Task SelectTask=new Task();
        private User MyUser =new User();

        public TaskPage(User SelectUser, int typeUser)
        {
            InitializeComponent();
            if (typeUser==1)
            {
                //TitleUser.Text = "Менеджер";
            }
            else
            {
                //TitleUser.Text = "Исполнитель";
                MyUser=SelectUser;
                MainWindow.FIOInfo.Visibility = Visibility.Visible;
                MainWindow.ShowNameExecutor(SelectUser);
                var MyTask = TipoEkzEntities.GetContext().Task.Where(x => x.ExecutorID == SelectUser.ID).ToList();
                ListTask.ItemsSource = MyTask;
            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            MainWindow.MainWindowFrame.Content = new Pages.AutorisationPage();
            MainWindow.FIOInfo.Visibility = Visibility.Hidden;
        }

        private void AddTask(object sender, RoutedEventArgs e)
        {
            MainWindow.MainWindowFrame.Content = new Pages.AddEditPage(null, MyUser);
        }

        private void EditTask(object sender, RoutedEventArgs e)
        {
            MainWindow.MainWindowFrame.Content = new Pages.AddEditPage(SelectTask, MyUser);
        }

        private void SelectTaskDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SelectTask = (e.OriginalSource as FrameworkElement).DataContext as Task;
            MainWindow.MainWindowFrame.Content = new Pages.AddEditPage(SelectTask, MyUser);
        }

        private void SelectTaskLeftClick(object sender, MouseButtonEventArgs e)
        {
            SelectTask = (e.OriginalSource as FrameworkElement).DataContext as Task;
        }

    }
}
