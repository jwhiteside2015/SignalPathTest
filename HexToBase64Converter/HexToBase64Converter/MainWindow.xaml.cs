using System;
using System.Windows;
using System.Windows.Controls;

namespace HexToBase64Converter
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ConvertHexToBase64(HexString.Text);
        }

        private void ConvertHexToBase64(string hexString)
        {
            
        }
    }
}
