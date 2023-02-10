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
    /// Логика взаимодействия для TeamsMainUC.xaml
    /// </summary>
    public partial class TeamsMainUC : UserControl
    {
        public TeamsMainUC()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            StackPanel stackPanel2 = new StackPanel();
            stackPanel2.Orientation = Orientation.Vertical;
            TextBlock headerTextBlock = new TextBlock();
            headerTextBlock.Text = "header";
            stackPanel2.Children.Add(headerTextBlock);

            StackPanel stackPanel1 = new StackPanel();
            stackPanel1.Orientation = Orientation.Horizontal;
            //for (int i = 0; i < 3; i++)
            //{
                stackPanel1.Children.Add(stackPanel2);
            //}

            EasternTI.Content = stackPanel1;
        }
    }
}
