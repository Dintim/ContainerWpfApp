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
using System.Windows.Shapes;

namespace ContainerWpfApp
{
    /// <summary>
    /// Логика взаимодействия для StackPanelWindow.xaml
    /// </summary>
    public partial class StackPanelWindow : Window
    {
        public StackPanelWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StackPanelWindow2 stackPanel = new StackPanelWindow2();
            stackPanel.Show();
            this.Close();
        }
    }
}
