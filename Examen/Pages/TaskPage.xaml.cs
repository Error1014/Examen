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
                MainWindow.FIOInfo.Visibility = Visibility.Visible;
                MainWindow.ShowNameExecutor(SelectUser);
            }
        }
    }
}
