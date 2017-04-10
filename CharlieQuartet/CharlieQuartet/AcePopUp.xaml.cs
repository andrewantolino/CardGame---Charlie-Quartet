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

namespace CharlieQuartet
{
    /// <summary>
    /// Interaction logic for AcePopUp.xaml
    /// </summary>
    public partial class AcePopUp : Window
    {
        public AcePopUp()
        {
            InitializeComponent();
        }

        public void ButtonOne_Click(object ssender, RoutedEventArgs e)
        {
            object tagValue = (e.Source as Button).Tag;
        }
    }
}
