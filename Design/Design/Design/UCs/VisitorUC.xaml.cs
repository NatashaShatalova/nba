using Design.Windows;
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

namespace Design.UCs
{
    /// <summary>
    /// Логика взаимодействия для VisitorUC.xaml
    /// </summary>
    public partial class VisitorUC : UserControl
    {
        public VisitorUC()
        {
            InitializeComponent();
        }

        private void TeamsButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);
            mainWindow.ChangeUC(mainWindow.teamsMainUC, "Main Teams");
        }
    }
}
