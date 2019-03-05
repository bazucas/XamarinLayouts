using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinLayouts.Layout.Absolute;
using XamarinLayouts.Layout.Grid;
using XamarinLayouts.Layout.Relative;
using XamarinLayouts.Layout.Scroll;

namespace XamarinLayouts
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoAbsolutePage(object sender, EventArgs args)
        {
            Navigation.PushAsync(new AbsolutePage());
        }

        private void GoGridPage(object sender, EventArgs args)
        {
            Navigation.PushAsync(new GridPage());
        }

        private void GoRelativePage(object sender, EventArgs args)
        {
            Navigation.PushAsync(new RelativePage());
        }

        private void GoScrollPage(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ScrollPage());
        }
        private void GoStackPage(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Layout.Stack.StackPage());
        }
    }
}
