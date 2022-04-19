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
    public sealed partial class Alumnos : Page
    {
        public Alumnos()
        {
            this.InitializeComponent();
        }

        private void Desplegable_Click(object sender, RoutedEventArgs e)
        {
            if (desplegable.Visibility == Visibility.Collapsed)
                desplegable.Visibility = Visibility.Visible;
            else desplegable.Visibility = Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }

        private void Button_ClickLuffy(object sender, RoutedEventArgs e)
        {
            AlumSearch.PlaceholderText = name.Text = "LUFFY";
        }

        private void Button_ClickSmoothy(object sender, RoutedEventArgs e)
        {
            AlumSearch.PlaceholderText = name.Text = "SMOOTHY";
        }
        private void Button_ClickLaw(object sender, RoutedEventArgs e)
        {
            AlumSearch.PlaceholderText = name.Text = "LAW";
        }
        private void Button_ClickKid(object sender, RoutedEventArgs e)
        {
            AlumSearch.PlaceholderText = name.Text = "KID";
        }
        private void Button_ClickUzumaki(object sender, RoutedEventArgs e)
        {
            AlumSearch.PlaceholderText = name.Text = "UZUMAKI";
        }
        private void Button_ClickRichard(object sender, RoutedEventArgs e)
        {
            AlumSearch.PlaceholderText = name.Text = "RICHARD";
        }

        private void Button_ClickMiracle(object sender, RoutedEventArgs e)
        {
            AlumSearch.PlaceholderText = name.Text = "MIRACLE";
        }
        private void Button_ClickJonny(object sender, RoutedEventArgs e)
        {
            AlumSearch.PlaceholderText = name.Text = "JONNY";
        }
        private void Button_ClickZoro(object sender, RoutedEventArgs e)
        {
            AlumSearch.PlaceholderText = name.Text = "ZORO";
        }

        private void Button_ClickRobin(object sender, RoutedEventArgs e)
        {
            AlumSearch.PlaceholderText = name.Text = "ROBIN";
        }

        private void Button_ClickNami(object sender, RoutedEventArgs e)
        {
            AlumSearch.PlaceholderText = name.Text = "NAMI";
        }
        private void Button_ClickKaguya(object sender, RoutedEventArgs e)
        {
            AlumSearch.PlaceholderText = name.Text = "KAGUYA";
        }

        private void Button_ClickSasuke(object sender, RoutedEventArgs e)
        {
            AlumSearch.PlaceholderText = name.Text = "SASUKE";
        }
        private void Button_ClickKiba(object sender, RoutedEventArgs e)
        {
            AlumSearch.PlaceholderText = name.Text = "KIBA";

        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            if (Information.Visibility == Visibility.Collapsed)
                Information.Visibility = Visibility.Visible;
            else Information.Visibility = Visibility.Collapsed;
        }

        private void Button_ClickBuscar(object sender, RoutedEventArgs e)
        {
            string a = AlumSearch.Text;

            switch (a)
            {
                case "LUFFY":
                    Button_ClickLuffy(sender, e);
                    break;
                case "SMOOTHY":
                    Button_ClickSmoothy(sender, e);
                    break;
                case "LAW":
                    Button_ClickLaw(sender, e);
                    break;
                case "KID":
                    Button_ClickKid(sender, e);
                    break;
                case "MIRACLE":
                    Button_ClickMiracle(sender, e);
                    break;
                case "SASUKE":
                    Button_ClickSasuke(sender, e);
                    break;
                case "KIBA":
                    Button_ClickKiba(sender, e);
                    break;
                case "KAGUYA":
                    Button_ClickKaguya(sender, e);
                    break;
                case "NAMI":
                    Button_ClickNami(sender, e);
                    break;
                case "ROBIN":
                    Button_ClickRobin(sender, e);
                    break;
                case "ZORO":
                    Button_ClickZoro(sender, e);
                    break;
                case "RICHARD":
                    Button_ClickRichard(sender, e);
                    break;
                case "UZUMAKI":
                    Button_ClickUzumaki(sender, e);
                    break;
                case "JONNY":
                    Button_ClickJonny(sender, e);
                    break;
            }

        }

        //private void AlumSearch_KeyDown(object sender, KeyRoutedEventArgs e)
        //{
        //    if (e.Key == Windows.System.VirtualKey.Execute)
        //    {
        //        ChangeName(sender, e);
        //    }

        //}

        //public void ChangeName(object sender, KeyRoutedEventArgs e)
        //{
        //    string a = AlumSearch.PlaceholderText;

        //    switch (a)
        //    {
        //        case "LUFFY":
        //            Button_ClickLuffy(sender, e);
        //            break;
        //        case "SMOOTHY":
        //            Button_ClickSmoothy(sender, e);
        //            break;
        //        case "LAW":
        //            Button_ClickLaw(sender, e);
        //            break;
        //        case "KID":
        //            Button_ClickKid(sender, e);
        //            break;
        //        case "MIRACLE":
        //            Button_ClickMiracle(sender, e);
        //            break;
        //        case "SASUKE":
        //            Button_ClickSasuke(sender, e);
        //            break;
        //        case "KIBA":
        //            Button_ClickKiba(sender, e);
        //            break;
        //        case "KAGUYA":
        //            Button_ClickKaguya(sender, e);
        //            break;
        //        case "NAMI":
        //            Button_ClickNami(sender, e);
        //            break;
        //        case "ROBIN":
        //            Button_ClickRobin(sender, e);
        //            break;
        //        case "ZORO":
        //            Button_ClickZoro(sender, e);
        //            break;
        //        case "RICHARD":
        //            Button_ClickRichard(sender, e);
        //            break;
        //        case "UZUMAKI":
        //            Button_ClickUzumaki(sender, e);
        //            break;
        //        case "JONNY":
        //            Button_ClickJonny(sender, e);
        //            break;
        //    }

        //}
    }
}


