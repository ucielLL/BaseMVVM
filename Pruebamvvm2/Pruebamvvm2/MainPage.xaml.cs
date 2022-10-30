using Pruebamvvm2.viewmodel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModelBaseMVVM;
using Xamarin.Forms;

namespace Pruebamvvm2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainpageVM();
            ((BaseViewModel)BindingContext).InitializeAsync(Navigation);
        }
    }
}
