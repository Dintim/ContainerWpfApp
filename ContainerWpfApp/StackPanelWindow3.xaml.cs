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
    /// Логика взаимодействия для StackPanelWindow3.xaml
    /// </summary>
    public partial class StackPanelWindow3 : Window
    {
        public StackPanelWindow3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StackPanelWindow4 stackPanel = new StackPanelWindow4();
            stackPanel.Show();
            this.Close();
        }
    }
}
