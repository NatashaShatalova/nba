using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace Design.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static UserControl actualUC;
        public static Stack<UserControl> pastUC = new Stack<UserControl>();

        public MainWindow()
        {
            InitializeComponent();
            Trace.WriteLine("Инициализация");
            actualUC = mainUC;
            pastUC.Push(mainUC);
        }

        private void mainUC_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (mainUC.Visibility == Visibility.Visible)
                Header.Visibility = Visibility.Collapsed;
            else
                Header.Visibility = Visibility.Visible;
        }

        public static void ChangeUC(UserControl newUC)
        {
            if (newUC == actualUC)
                newUC.Visibility = Visibility.Collapsed;
            else
            {
                actualUC.Visibility = Visibility.Collapsed;
                newUC.Visibility = Visibility.Visible;
            }

            if (pastUC.Peek() == newUC)
                pastUC.Pop();
            else
                pastUC.Push(actualUC);
            CheckStack();
            actualUC = newUC;
        }
        
        public static void CheckStack()
        {
            Trace.WriteLine("---------------");
            foreach (UserControl uc in pastUC)
            {
                Trace.WriteLine(uc.ToString());
            }
        }

        public void ChangeUC(UserControl newUC, string labelContent)
        {
            ChangeUC(newUC);

            headerLabel.Content = labelContent;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            ChangeUC(pastUC.Peek());
        }
    }
}
