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

namespace Editor.StartupScreen
{
    /// <summary>
    /// Interaction logic for StartupScreen.xaml
    /// </summary>
    public partial class StartupSelector : Window
    {
        public StartupSelector()
        {
            InitializeComponent();
        }

        private void toggleBtn_Click(object sender, RoutedEventArgs e)
        {
            if(sender == loadProjBtn)
            {
                if(createProjBtn.IsChecked == true)
                {
                    createProjBtn.IsChecked = false;
                    screenContent.Margin = new Thickness(0);
                }
                loadProjBtn.IsChecked = true;
            }
            else
            {

                if (loadProjBtn.IsChecked == true)
                {
                    loadProjBtn.IsChecked = false;
                    screenContent.Margin = new Thickness(800,0,0,0);
                }
                createProjBtn.IsChecked= true;
            }
        }
    }
}
