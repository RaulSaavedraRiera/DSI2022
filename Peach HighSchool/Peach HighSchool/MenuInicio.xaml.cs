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

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Peach_HighSchool
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MenuInicio : Page
    {
        
        public MenuInicio()
        {
            this.InitializeComponent();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (options.Visibility == Visibility.Visible)
            {
                options.Visibility = Visibility.Collapsed;
                optionsPanel.Visibility = Visibility.Collapsed;
            }
            else
            {
                options.Visibility = Visibility.Visible;
                optionsPanel.Visibility = Visibility.Visible;
            }
               
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(HudPrincipal));
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            Grid.SetRow(photo, 3);
            Grid.SetRowSpan(photo, 3);
        }

        private void TextBox_TextChanging(TextBox sender, TextBoxTextChangingEventArgs args)
        {
            Grid.SetRow(photo, 2);
            Grid.SetRowSpan(photo, 3);
        }
    }
}
