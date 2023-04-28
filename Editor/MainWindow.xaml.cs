using Editor.StartupScreen;
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

namespace Editor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += OnMainWindowLoaded;   //wait for main screen to load
        }

        private void OnMainWindowLoaded(object sender, RoutedEventArgs e)
        {
            Loaded -= OnMainWindowLoaded;
            OpenStartupScreen();    //then call the startup screen
        }

        private void OpenStartupScreen()
        {
            var startupScreen = new StartupSelector();
            if (startupScreen.ShowDialog() == false)    //create dialog & if dialog is closed, close main window
            {
                Application.Current.Shutdown();
            }
            else
            {

            }
        }
    }
}
