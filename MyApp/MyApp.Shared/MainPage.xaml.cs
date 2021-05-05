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

using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

using System.Numerics;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.Core;
using Windows.UI.Xaml.Hosting;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //How to build an Elipse
            /*var ellipse1 = new Ellipse();
            ellipse1.Fill = new SolidColorBrush(Windows.UI.Colors.SteelBlue);
            ellipse1.Width = WidthSlider.Value;
            ellipse1.Height =  HeightSlider.Value;
            layoutRoot.Children.Add(ellipse1);*/
        }
        private void OnClick()
        {
            //var dt = DateTime.Now.ToString();
            //txt.Text = dt;
            //var ellipse = ((Ellipse)layoutRoot.Children[layoutRoot.Children.Count - 1]).Width*1.5;
        }

        private void OnSlider()
        {
            //var dt = DateTime.Now.ToString();
            //txt.Text = dt;
            //var ellipse = ((Ellipse)layoutRoot.Children[layoutRoot.Children.Count - 1]);
            //Ellipse.Width = WidthSlider.Value;
            //Ellipse.Height = HeightSlider.Value;
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) 
        {
            string colorName = e.AddedItems[0].ToString();
            Color color;
            switch (colorName)
            {
                case "Yellow":
                    color = Colors.Yellow;
                    break;
                case "Green":
                    color = Colors.Green;
                    break;
                case "Blue":
                    color = Colors.Blue;
                    break;
                case "Red":
                    color = Colors.Red;
                    break;
                default:
                    color = Colors.SteelBlue;
                    break;
            }
            Ellipse.Fill = new SolidColorBrush(color);
            ColorText.Text = colorName;
        }
    }
}
