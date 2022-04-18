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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Peach_HighSchool
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Tienda : Page
    {
    
        public Tienda()
        {
            this.InitializeComponent();
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }

        private void T1_Click(object sender, RoutedEventArgs e)
        {
            F1.Visibility = Visibility.Collapsed;
            S1.Visibility = Visibility.Visible;
        }

        private void T2_Click(object sender, RoutedEventArgs e)
        {
            F2.Visibility = Visibility.Collapsed;
            S2.Visibility = Visibility.Visible;
        }

        private void T3_Click(object sender, RoutedEventArgs e)
        {
            F3.Visibility = Visibility.Collapsed;
            S3.Visibility = Visibility.Visible;
        }
    }
}
