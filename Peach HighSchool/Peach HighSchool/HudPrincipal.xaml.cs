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
    public sealed partial class HudPrincipal : Page
    {
        public HudPrincipal()
        {
            this.InitializeComponent();
        }

        private void Desplegable_Click(object sender, RoutedEventArgs e)
        {
            if (desplegable.Visibility == Visibility.Collapsed)
                desplegable.Visibility = Visibility.Visible;
            else desplegable.Visibility = Visibility.Collapsed;
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            if (menus.Visibility == Visibility.Collapsed)
                menus.Visibility = Visibility.Visible;
            else menus.Visibility = Visibility.Collapsed;
        }

        private void Instrucciones_Click(object sender, RoutedEventArgs e)
        {
            if (instrucciones.Visibility == Visibility.Collapsed)
                instrucciones.Visibility = Visibility.Visible;
            else instrucciones.Visibility = Visibility.Collapsed;
        }
        private void AlumInMap_Click(object sender, RoutedEventArgs e)
        {
            if (InfoStudent.Visibility == Visibility.Collapsed)
                InfoStudent.Visibility = Visibility.Visible;
            else InfoStudent.Visibility = Visibility.Collapsed;
        }

        private void ToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void OptionsButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MenuOpciones));
        }

        private void Tienda_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Tienda));
        }

        private void Calendario_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Calendario));
        }

        private void Misiones_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Misiones));
        }

        private void Club_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Clubes));
        }

        private void Alumnos_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Alumnos));
        }

        private void n25_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            n25.FontStyle = Windows.UI.Text.FontStyle.Oblique;
            n05.FontStyle = Windows.UI.Text.FontStyle.Normal;
            n1.FontStyle = Windows.UI.Text.FontStyle.Normal;
            n2.FontStyle = Windows.UI.Text.FontStyle.Normal;
            n5.FontStyle = Windows.UI.Text.FontStyle.Normal;
            
        }

        private void n05_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            n25.FontStyle = Windows.UI.Text.FontStyle.Normal;
            n05.FontStyle = Windows.UI.Text.FontStyle.Oblique;
            n1.FontStyle = Windows.UI.Text.FontStyle.Normal;
            n2.FontStyle = Windows.UI.Text.FontStyle.Normal;
            n5.FontStyle = Windows.UI.Text.FontStyle.Normal;

        }
        private void n1_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            n25.FontStyle = Windows.UI.Text.FontStyle.Normal;
            n05.FontStyle = Windows.UI.Text.FontStyle.Normal;
            n1.FontStyle = Windows.UI.Text.FontStyle.Oblique;
            n2.FontStyle = Windows.UI.Text.FontStyle.Normal;
            n5.FontStyle = Windows.UI.Text.FontStyle.Normal;

        }
        private void n2_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            n25.FontStyle = Windows.UI.Text.FontStyle.Normal;
            n05.FontStyle = Windows.UI.Text.FontStyle.Normal;
            n1.FontStyle = Windows.UI.Text.FontStyle.Normal;
            n2.FontStyle = Windows.UI.Text.FontStyle.Oblique;
            n5.FontStyle = Windows.UI.Text.FontStyle.Normal;

        }
        private void n5_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            n25.FontStyle = Windows.UI.Text.FontStyle.Normal;
            n05.FontStyle = Windows.UI.Text.FontStyle.Normal;
            n1.FontStyle = Windows.UI.Text.FontStyle.Normal;
            n2.FontStyle = Windows.UI.Text.FontStyle.Normal;
            n5.FontStyle = Windows.UI.Text.FontStyle.Oblique;

        }
    }
}
