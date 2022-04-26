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
    public sealed partial class Calendario : Page
    {

        int cMoney = 500;
        struct Activity
        {
           public bool buy;
           public int price;
            public string text;
            public Image icon;

            public Activity(int price, string text, Image icon)
            {
                buy = false;
                this.price = price;
                this.text = text;
                this.icon = icon;
            }
        }
      

        int activityOn = -1;
        Activity[] activies; 

        public Calendario()
        {
            this.InitializeComponent();

            activies = new Activity[2];
            activies[0] = new Activity(100, "Toda la escuela irá a disfrutar del Sakura a las calles de Tokio.", SakuraIcon);
            activies[1] = new Activity(500, "Un viaje a Okinawa para toda la clase, disfrutando de la playa y el sol.", OkinawaIcon);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame.CanGoBack)
            {
                rootFrame.GoBack();
            }
        }

        private void Sakura_Click(object sender, RoutedEventArgs e)
        {
            infoActivity.Text = activies[0].text;
            HideAllActivites();
            activies[0].icon.Visibility = Visibility.Visible;

            activityOn = 0;

            if (!activies[0].buy)
                buyActivity.Content = activies[0].price.ToString() + "k";
            else
                buyActivity.Content = "Acquired";
        }

        private void Okinawa_Click(object sender, RoutedEventArgs e)
        {
            infoActivity.Text = activies[1].text;
            HideAllActivites();
            activies[1].icon.Visibility = Visibility.Visible;

            activityOn = 1;

            if (!activies[1].buy)
                buyActivity.Content = activies[1].price.ToString() + "k";
            else
                buyActivity.Content = "Acquired";
        }

        private void Buy_Click(object sender, RoutedEventArgs e)
        {
            switch (activityOn)
            {
                case 0:
                    if (!activies[0].buy && activies[0].price < cMoney)
                    {
                        activies[0].buy = true;
                        buyActivity.Content = "Acquired";
                        money.Text = (cMoney - activies[0].price).ToString() + "$";
                    }
                    break;
                case 1:
                    if (!activies[1].buy && activies[1].price < cMoney)
                    {
                        activies[1].buy = true;
                        buyActivity.Content = "Acquired";
                        money.Text = (cMoney - activies[1].price).ToString() + "$";
                    }
                    break;
                default:
                    break;
            }
        }

      void HideAllActivites()
        {
            foreach (Activity i in activies)
            {
                i.icon.Visibility = Visibility.Collapsed;
            }
        }
    }
}
