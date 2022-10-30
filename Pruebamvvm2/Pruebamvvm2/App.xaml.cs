using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ViewModelBaseMVVM;
using Pruebamvvm2.viewmodel;
using Pruebamvvm2.view;

namespace Pruebamvvm2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Build();
                
            MainPage = new NavigationPage(new MainPage());
        }
        private void Build() 
        {
            ContainerPage.Current.RegisterForNavigation<MainpageVM, MainPage>();
            ContainerPage.Current.RegisterForNavigation<Page1Vm,Page1>();
        } 

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
