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

        
        struct Item
        {
            public Image o;
            public bool isSold;

            public Item(Image i)
            {
                o = i;
                isSold = false;
            }
        }

        Item[] objects;
        int currentZone = 1;
        int money = 2000;

        public Tienda()
        {
            this.InitializeComponent();

            objects = new Item[15];


            //objetos  de upgrate
            objects[0] = new Item(U1);
            objects[1] = new Item(U2);
            objects[2] = new Item(U3);

            //objetos de ropa
            objects[3] = new Item(F1);
            objects[4] = new Item(F2);
            objects[5] = new Item(F3);

            //objetos de escuela
            objects[6] = new Item(SC1);
            objects[7] = new Item(SC2);
            objects[8] = new Item(SC3);

            //objetos de clubs
            objects[9] = new Item(C1);
            objects[10] = new Item(C2);
            objects[11] = new Item(C3);

            //objetos de materiales
            objects[12] = new Item(ST1);
            objects[13] = new Item(ST2);
            objects[14] = new Item(ST3);

            price.PlaceholderText = money.ToString();

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

            if (money-100 >= 0 && objects[currentZone * 3].o != S1)
            {

                objects[currentZone * 3].o.Visibility = Visibility.Collapsed;
                objects[currentZone * 3].o = S1;
                objects[currentZone * 3].o.Visibility = Visibility.Visible;

                money -= 100;

                price.PlaceholderText = money.ToString();
            }
        }

        private void T2_Click(object sender, RoutedEventArgs e)
        {
            if (money-200 >= 0 && objects[currentZone * 3 + 1].o != S2)
            {
                money -= 200;
                objects[currentZone * 3 + 1].o.Visibility = Visibility.Collapsed;
                objects[currentZone * 3 + 1].o = S2;
                objects[currentZone * 3 + 1].o.Visibility = Visibility.Visible;

               
                price.PlaceholderText = money.ToString();
            }

        }

        private void T3_Click(object sender, RoutedEventArgs e)
        {

            if (money-500 >= 0 && objects[currentZone * 3 + 2].o != S3)
            {
                objects[currentZone * 3 + 2].o.Visibility = Visibility.Collapsed;
                objects[currentZone * 3 + 2].o = S3;
                objects[currentZone * 3 + 2].o.Visibility = Visibility.Visible;


                money -= 500;

                price.PlaceholderText = money.ToString();
            }
               

        }

        private void Button_ClickUpgrate(object sender, RoutedEventArgs e)
        {
            currentZone = 0;
            ActualiceScreen();
        }

        private void Button_ClickSchool(object sender, RoutedEventArgs e)
        {
            currentZone = 2;
            ActualiceScreen();
        }
        private void Button_ClickClub(object sender, RoutedEventArgs e)
        {
            currentZone = 3;
            ActualiceScreen();
        }
        private void Button_ClickClothes(object sender, RoutedEventArgs e)
        {
            currentZone = 1;
            ActualiceScreen();
        }

        private void Button_ClickStudy(object sender, RoutedEventArgs e)
        {
            currentZone = 4;
            ActualiceScreen();
        }

        void ActualiceScreen()
        {
            foreach (Item i in objects)            
                i.o.Visibility = Visibility.Collapsed;

            objects[currentZone * 3].o.Visibility = Visibility.Visible;
            objects[currentZone * 3 + 1].o.Visibility = Visibility.Visible;
            objects[currentZone * 3 + 2].o.Visibility = Visibility.Visible;
            
        }
    }
}
