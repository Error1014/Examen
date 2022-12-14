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
            ShowComboBoxExecutor();
            ShowComboBoxStatus();
            ShowComboBoxWorkType();





            DataContext = SelectTask;
        }

        private void ShowComboBoxExecutor()
        {
            ExecutorCombo.ItemsSource = TipoEkzEntities.GetContext().User.Select(x => x).Distinct().ToList();
            ExecutorCombo.SelectedIndex = 0;
            if (SelectTask != null)
            {
                ExecutorCombo.SelectedItem = SelectTask.Executor.User;
            }
        }
        private void ShowComboBoxStatus()
        {
            var status = TipoEkzEntities.GetContext().Status.Select(x => x).Distinct().ToList();
            StatusCombo.ItemsSource = status;
            StatusCombo.SelectedIndex = 0;
            if (SelectTask != null)
            {
                StatusCombo.SelectedItem = status.Where(x=>x.ID== SelectTask.StatusID);
            }
        }

        private void ShowComboBoxWorkType()
        {
            var workType = TipoEkzEntities.GetContext().WorkType.Select(x => x).Distinct().ToList();
            WorkTypeCombo.ItemsSource = workType;
            WorkTypeCombo.SelectedIndex = 0;
            if (SelectTask != null)
            {
                WorkTypeCombo.SelectedItem = workType.Where(x => x.ID == SelectTask.WorkTypeID);
            }
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
