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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Photo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {


        int[] boxValue;

        Image myXImage, myOimage, myEmptyImage;

        void resetBoxes()
        {



            for (int i = 0; i < 10; i++)
                boxValue[i] = 0;

            image1.Source = myEmptyImage.Source;
            image2.Source = myEmptyImage.Source;
            image3.Source = myEmptyImage.Source;
            image4.Source = myEmptyImage.Source;
            image5.Source = myEmptyImage.Source;
            image6.Source = myEmptyImage.Source;
            image7.Source = myEmptyImage.Source;
            image8.Source = myEmptyImage.Source;
            image9.Source = myEmptyImage.Source;


            textBlock1.Text = "Następny ruch ";
            image10.Source = myXImage.Source;

        }

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;




            myXImage = new Image();
            myXImage.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/krzyzyk.png", UriKind.RelativeOrAbsolute));

            myOimage = new Image();
            myOimage.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/kolko.png", UriKind.RelativeOrAbsolute));
            myEmptyImage = new Image();
            myEmptyImage.Source = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/pusto.png", UriKind.RelativeOrAbsolute));
 
            resetBoxes();
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }
    }
}
