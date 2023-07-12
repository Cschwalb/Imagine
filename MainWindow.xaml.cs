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

namespace Imagine
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool clicked = false;
        public MainWindow()
        {
            InitializeComponent();
            this.textBlock.Text = "Welcome to ImagineSoftware";
            this.HEK.TextAlignment = TextAlignment.Center;
            this.textBlock.TextAlignment = TextAlignment.Center;

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (clicked == false)
            {
                this.HEK.Text = "ImagineSoftware Is a leading provider of medical billing, revenue cycle, and practice management software";
                this.button.Content = "Exit";
                clicked = true;
            }
            else
            {
                clicked = false;
                this.HEK.Text = "Hit the Enter Key";
                this.button.Content = "Enter";
            }
        }
    }
}
