using Pruebamvvm2.view;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using ViewModelBaseMVVM;
using Xamarin.Forms;

namespace Pruebamvvm2.viewmodel
{
    public class MainpageVM : BaseViewModel
    {
        public ICommand Otherpage => new Command(async () =>
        {
             await NavigationTo(new Page1Vm(), new NavigationParameters("val 1", "THIS IS THE VALUE SENT FROM PREVIOUS PAGE"));
            //NavigateTo(new Page1());

        });
    }
}
