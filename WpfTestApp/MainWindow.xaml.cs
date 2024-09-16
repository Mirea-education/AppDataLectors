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
using WpfTestApp.DataClassApp;
using WpfTestApp.PagesApp;
using WpfTestApp.WindowsApp;

namespace WpfTestApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private WindowAbout okno = 
        public MainWindow()
        {
            InitializeComponent();
            ClassNavigation.frmContent = FrmMainContent;
            FrmMainContent.Navigate(new PageMain());
        }

        private void BtnAlert_Click(object sender, RoutedEventArgs e)
        {
            new WindowAbout().Show();
        }
    }
}
