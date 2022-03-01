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

namespace SimpleHelloWorldCSWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            resultTextBlock.Text = "...";
        }

        private void sayHelloButton_Click(object sender, RoutedEventArgs e)
        {
            if (!resultTextBlock.Text.Equals("Hello,World"))
            {
                resultTextBlock.Text = "Hello,World!";
            }
            else
            {
                resultTextBlock.Text = "Hello, WPF!!";
            }
            MessageBox.Show("Hello,World! WPF Application", "Simple WPF (C#) Hello, World! Program", MessageBoxButton.OK, MessageBoxImage.Exclamation);

        }
    }
}
