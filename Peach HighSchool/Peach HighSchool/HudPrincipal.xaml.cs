using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Text;
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
        int currentVelocity;
        public HudPrincipal()
        {
            this.InitializeComponent();
            currentVelocity = 1;
        }

        private void Desplegable_Click(object sender, RoutedEventArgs e)
        {
            instrucciones.Visibility = Visibility.Collapsed;
            menus.Visibility = Visibility.Collapsed;
          
            if (desplegable.Visibility == Visibility.Collapsed)
                desplegable.Visibility = Visibility.Visible;
            else desplegable.Visibility = Visibility.Collapsed;
        }

        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            instrucciones.Visibility = Visibility.Collapsed;
            desplegable.Visibility = Visibility.Collapsed;


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
            instrucciones.Visibility = Visibility.Collapsed;
            menus.Visibility = Visibility.Collapsed;
            desplegable.Visibility = Visibility.Collapsed;


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

        private void n1_Click(object sender, RoutedEventArgs e)
        {
            switch (currentVelocity)
            {
                case 0:
                    n05.Text = "x0.5";
                    n1.Content = "x1.0";
                    n2.Text = "x2.0";
                    currentVelocity = 1;
                    break;
                case 1:
                    n05.Text = "x1.0";
                    n1.Content = "x2.0";
                    n2.Text = "x0.5";
                    currentVelocity = 2;
                    break;
                case 2:
                    n05.Text = "x2.0";
                    n1.Content = "x0.5";
                    n2.Text = "x1.0";
                    currentVelocity = 0;
                    break;
            }
        }

        //private void n25_PointerPressed(object sender, PointerRoutedEventArgs e)
        //{
        //    if (currentVelocity != null)
        //        currentVelocity.FontWeight = FontWeights.Normal;

        //    currentVelocity = n25;
        //    currentVelocity.FontWeight = FontWeights.Bold;
        //}

        //private void n05_PointerPressed(object sender, PointerRoutedEventArgs e)
        //{
        //    if (currentVelocity != null)
        //        currentVelocity.FontWeight = FontWeights.Normal;

        //    currentVelocity = n05;
        //    currentVelocity.FontWeight = FontWeights.Bold;

        //}
        //private void velocity_PointerPressed(object sender, PointerRoutedEventArgs e)
        //{
        //    if (currentVelocity != null)
        //        currentVelocity.FontWeight = FontWeights.Normal;

        //    currentVelocity = n1;
        //    currentVelocity.FontWeight = FontWeights.Bold;

        //}


        //private void n2_PointerPressed(object sender, PointerRoutedEventArgs e)
        //{
        //    if (currentVelocity != null)
        //        currentVelocity.FontWeight = FontWeights.Normal;

        //    currentVelocity = n2;
        //    currentVelocity.FontWeight = FontWeights.Bold;

        //}
        //private void n5_PointerPressed(object sender, PointerRoutedEventArgs e)
        //{
        //    if (currentVelocity != null)
        //        currentVelocity.FontWeight = FontWeights.Normal;

        //    currentVelocity = n5;
        //    currentVelocity.FontWeight = FontWeights.Bold;

        //}
    }
}
