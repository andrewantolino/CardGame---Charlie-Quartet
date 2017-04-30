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
    /// Interaction logic for aceWindow.xaml
    /// </summary>
    public partial class aceWindow : Window
    {
        Player thisPlayer;
        MainWindow editForm;

        public aceWindow(Player testPlayer, MainWindow mainForm)
        {
            InitializeComponent();
            thisPlayer = testPlayer;
            editForm = mainForm;
        }

        private void aceOne_Click(object sender, RoutedEventArgs e)
        {
            thisPlayer.hand[thisPlayer.hand.Count - 1].point = 1;
            this.Close();
        }

        private void aceEleven_Click(object sender, RoutedEventArgs e)
        {
            thisPlayer.hand[thisPlayer.hand.Count - 1].point = 11;
            this.Close();
        }
    }
}
