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
using Windows.UI.Core;

// La plantilla de elemento Página en blanco está documentada en https://go.microsoft.com/fwlink/?LinkId=234238

namespace Peach_HighSchool
{
    /// <summary>
    /// Una página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class Clubes : Page
    {

        int mode = 0, selectedStudent = 0;

        string[] mode0 = new string[5];
        string[] mode1 = new string[5];

        string currentNewStudent = "";

        public Clubes()
        {
            this.InitializeComponent();
            Window.Current.Dispatcher.AcceleratorKeyActivated += AccelertorKeyActivedHandle;

            mode0[0] = "LUFFY";
            mode0[1] = "NAMI";
            mode0[2] = "ZORO";
            mode0[3] = "SANJI";
            mode0[4] = "ROBIN";

            mode1[0] = "ROB";
            mode1[1] = "SUSUKE";
            mode1[2] = "MANI";
            mode1[3] = "NISSAN";
            mode1[4] = "SUZUKI";
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

        private void student1_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter || e.Key == Windows.System.VirtualKey.GamepadY)
            {
                selectedStudent = 1;
            }
        }

        private void student2_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter || e.Key == Windows.System.VirtualKey.GamepadA)
            {
                selectedStudent = 2;
            }
        }

        private void student3_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter || e.Key == Windows.System.VirtualKey.GamepadA)
            {
                selectedStudent = 3;
            }
        }

        private void student4_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter || e.Key == Windows.System.VirtualKey.GamepadA)
            {
                selectedStudent = 4;
            }
        }

        private void student5_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter || e.Key == Windows.System.VirtualKey.GamepadA)
            {
                selectedStudent = 5;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            bool isEmpty = false;

            
            if (selectedStudent == 0) return;

            if (mode == 0)
                isEmpty = mode0[selectedStudent - 1] == "-----";
            else
                isEmpty = mode1[selectedStudent - 1] == "-----";



            if (isEmpty && currentNewStudent != "")
            {
                if (mode == 0)
                    mode0[selectedStudent - 1] = currentNewStudent;
                else
                    mode1[selectedStudent - 1] = currentNewStudent;

                currentNewStudent = "";

                ActList();
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (selectedStudent == 0) return;


            if (mode == 0)            
                mode0[selectedStudent - 1] = "-----";
            else
                mode1[selectedStudent - 1] = "-----";

            ActList();
          
        }

        void ActList()
        {
            if(mode == 0)
            {
                student1.PlaceholderText = mode0[0];
                student2.PlaceholderText = mode0[1];
                student3.PlaceholderText = mode0[2];
                student4.PlaceholderText = mode0[3];
                student5.PlaceholderText = mode0[4];
            }
            else
            {
                student1.PlaceholderText = mode1[0];
                student2.PlaceholderText = mode1[1];
                student3.PlaceholderText = mode1[2];
                student4.PlaceholderText = mode1[3];
                student5.PlaceholderText = mode1[4];
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            if (selectedStudent == 0) return;

            if (currentNewStudent != "")
            {
                if (mode == 0)
                    mode0[selectedStudent - 1] = currentNewStudent;
                else
                    mode1[selectedStudent - 1] = currentNewStudent;

                currentNewStudent = "";

                ActList();
            }
        }

        private void TextBox_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter || e.Key == Windows.System.VirtualKey.GamepadA)
            {
                var a = sender as TextBox;

                currentNewStudent = a.Text;
            }
        }

        private void Club_Click(object sender, RoutedEventArgs e)
        {
            if (mode == 0)
            {
                mode = 1;

                student1.PlaceholderText = mode1[0];
                student2.PlaceholderText = mode1[1];
                student3.PlaceholderText = mode1[2];
                student4.PlaceholderText = mode1[3];
                student5.PlaceholderText = mode1[4];
            }
            else
            {
                mode = 0;

                student1.PlaceholderText = mode0[0];
                student2.PlaceholderText = mode0[1];
                student3.PlaceholderText = mode0[2];
                student4.PlaceholderText = mode0[3];
                student5.PlaceholderText = mode0[4];
            }
        }

  
    }
}
