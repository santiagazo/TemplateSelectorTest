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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MDIXTemplateSelector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Dynamic_Selection_Changed(object sender, SelectionChangedEventArgs e)
        {
            Debug.WriteLine("Change happened.");
            //MessageBox.Show(e.);
        }


        private void MouseDownEvent(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Click happened.");
        }
    }
}
