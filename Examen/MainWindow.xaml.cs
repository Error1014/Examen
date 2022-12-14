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

namespace Examen
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Frame MainWindowFrame;
        public static TextBlock FIOInfo;
        public static Run NameExecutor;
        public MainWindow()
        {
            InitializeComponent();
            MainWindowFrame = MainFrame;
            MainWindowFrame.Content = new Pages.AutorisationPage();
            FIOInfo = FIOUserBlock;
            NameExecutor = FIOUser;
            FIOInfo.Visibility = Visibility.Hidden;
        }

        public static void ShowNameExecutor(User MyUser)
        {
            var GradeUser = (from a in TipoEkzEntities.GetContext().Executor.ToList()
                            join b in TipoEkzEntities.GetContext().Grade.ToList() on a.ID equals b.ID
                            where b.ID == MyUser.ID
                            select b).First();
            NameExecutor.Text = MyUser.MiddleName + " " + MyUser.FirstName[0] + "." + MyUser.LastName[0] + "./"+ GradeUser.Title;
        }
    }
}
