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
    /// Логика взаимодействия для WrapPanelWindow3.xaml
    /// </summary>
    public partial class WrapPanelWindow3 : Window
    {
        public WrapPanelWindow3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WrapPanelWindow4 wrapPanel = new WrapPanelWindow4();
            wrapPanel.Show();
            this.Close();
        }
    }
}
