using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace UWP_ExceptionStudy
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        const string CharPlus = "+";
        string _inputStr;

        public MainPage()
        {
            this.InitializeComponent();
            _inputStr = "";
        }

		private void textBox_TextChanged(object sender, TextChangedEventArgs e)
		{
            _inputStr = sender.ToString();
		}
        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = Calc().ToString();
            Console.WriteLine("クリックされた");
        }
        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
        int Calc()
        {
            Console.WriteLine("Calc");
            var split = textBlock.Text.Split(CharPlus);
            return 0;
        }

	}
}
