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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Panel
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class TPanel : Page
    {
        public TPanel()
        {
            this.InitializeComponent();
            Window.Current.SizeChanged +=Current_SizeChanged; // kiedy zmieni sie orientation
        }

        private void Current_SizeChanged(object sender, Windows.UI.Core.WindowSizeChangedEventArgs e)
        {
          
            var b = Window.Current.Bounds;
            if (b.Height > b.Width)
            {
                // Portrait
                food1.Margin = new Thickness(0,0,0,0);
                play2.Margin = new Thickness(133, 0, 0, 0);
                stats3.Margin = new Thickness(266, 0, 0, 0);
                micr4.Margin = new Thickness(0, 495, 0, 0);
                med5.Margin = new Thickness(133, 495, 0, 0);
                sleep6.Margin = new Thickness(266, 495, 0, 0);
            }
            else
            {
                // Landscape
                food1.Margin = new Thickness(0, 0, 0, 0);
                play2.Margin = new Thickness(0, 132, 0, 0);
                stats3.Margin = new Thickness(0, 266, 0, 0);
                micr4.Margin = new Thickness(471, 0, 0, 0);
                med5.Margin = new Thickness(471, 132, 0, 0);
                sleep6.Margin = new Thickness(471, 266, 0, 0);
            }
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
    }
}
