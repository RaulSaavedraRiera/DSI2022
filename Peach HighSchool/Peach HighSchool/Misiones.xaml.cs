﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
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
    public sealed partial class Misiones : Page
    {
        int money = 300;
        int xp = 150;

        int mode = 0;

        public Misiones()
        {
            this.InitializeComponent();
            Window.Current.Dispatcher.AcceleratorKeyActivated += AccelertorKeyActivedHandle;
        }

        private void AccelertorKeyActivedHandle(CoreDispatcher sender, AcceleratorKeyEventArgs args)
        {
            if (args.EventType.ToString().Contains("Down"))
            {

                if (args.VirtualKey == Windows.System.VirtualKey.GamepadB)
                {
                    Frame rootFrame = Window.Current.Content as Frame;
                    if (rootFrame.CanGoBack)
                    {
                        rootFrame.GoBack();
                    }
                }


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

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            if (Information.Visibility == Visibility.Collapsed)
                Information.Visibility = Visibility.Visible;
            else Information.Visibility = Visibility.Collapsed;
        }

        private void Reward_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if(e.Key == Windows.System.VirtualKey.Enter || e.Key == Windows.System.VirtualKey.GamepadX)
            {
                var a = sender as TextBox;
                if(a.PlaceholderText == "REWARD")
                {
                    money += 50;
                    xp += 25;

                    moneyT.PlaceholderText = money.ToString() + "$";
                    expT.PlaceholderText = xp.ToString() + "Xp";

                    a.PlaceholderText = "COMPLETE";
                }
            }
        }

        private void ChangeClass_click(object sender, RoutedEventArgs e)
        {
            if(mode == 0)
            {
                mode = 1;
                student1.PlaceholderText = "MIMOTO";
                student2.PlaceholderText = "SUSANNE";
                student3.PlaceholderText = "ROGER";
                student4.PlaceholderText = "MARA";
            }
            else
            {
                mode = 0;
                student1.PlaceholderText = "LUFFY";
                student2.PlaceholderText = "ROBIN";
                student3.PlaceholderText = "ZORO";
                student4.PlaceholderText = "SANJI";
            }
        }
    }
}
