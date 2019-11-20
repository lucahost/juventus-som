using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Foo : ContentPage
    {
        public Foo()
        {
            InitializeComponent();
        }

        private async void FooButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Bar());
        }
    }
}