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
            string result = ConvertHexToBase64(HexString.Text);
        }

        private string ConvertHexToBase64(string hexString)
        {
            // Convert hex string to a byte array so that we can pass it to the ToBase64String method
            byte[] byteArray = new byte[hexString.Length / 2];
            for (int i = 0; i < hexString.Length; i++)
            {
                byteArray[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
            }

            // Convert the byte array to base64
            return Convert.ToBase64String(byteArray);
        }
    }
}
