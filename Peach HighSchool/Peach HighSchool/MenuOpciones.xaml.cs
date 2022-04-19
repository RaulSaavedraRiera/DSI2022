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
    public sealed partial class MenuOpciones : Page
    {
        public MenuOpciones()
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

        private void autoSave_Toggled(object sender, RoutedEventArgs e)
        {
            Grid.SetRow(photo, 0);
            Grid.SetRowSpan(photo, 1);
        }

        private void music_Toggled(object sender, RoutedEventArgs e)
        {
            Grid.SetRow(photo, 2);
            Grid.SetRowSpan(photo, 2);
        }

        //music
        private void Slider_ValueChanged_1(object sender, RangeBaseValueChangedEventArgs e)
        {
            Grid.SetRow(photo, 2);
            Grid.SetRowSpan(photo, 2);
        }

        private void sound_Toggled(object sender, RoutedEventArgs e)
        {
            Grid.SetRow(photo, 1);
            Grid.SetRowSpan(photo, 2);
        }
        //sound
        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            Grid.SetRow(photo, 1);
            Grid.SetRowSpan(photo, 2);
        }

        private void DropDownButton_Click(object sender, RoutedEventArgs e)
        {
            Grid.SetRow(photo, 4);
            Grid.SetRowSpan(photo, 2);
        }


    }
}
