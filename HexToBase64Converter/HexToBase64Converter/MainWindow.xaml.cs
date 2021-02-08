using System;
using System.Windows;
using System.Windows.Controls;

namespace HexToBase64Converter
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Check for an uneven number of characters
            if (HexString.Text.Length % 2 == 1)
            {
                MessageBox.Show("Input string must have an even number of characters", "Alert");
            }
            else
            {
                string result = ConvertHexToBase64(HexString.Text);
                ConversionResult conversionResultWindow = new ConversionResult();
                conversionResultWindow.ResultLabel.Content = result;
                conversionResultWindow.Show();
            }
        }

        private string ConvertHexToBase64(string hexString)
        {
            // Convert hex string to a byte array so that we can pass it to the ToBase64String method
            byte[] byteArray = new byte[hexString.Length / 2];
            for (int i = 0; i < hexString.Length; i += 2)
            {
                byteArray[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }

            // Convert the byte array to base64
            return Convert.ToBase64String(byteArray);
        }
    }
}
