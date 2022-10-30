using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViewModelBaseMVVM;
using Xamarin.Forms;

namespace Pruebamvvm2.viewmodel
{
    public class Page1Vm: BaseViewModel
    {

        private string _val = "default ";
        public string Val
        {
            get { return _val; }
            set
            {
                SetProperty(ref _val, value);
            }
        }

        public override async Task InitializeAsync( NavigationParameters parameters = null)
        {
            await base.InitializeAsync(parameters);

            Val = parameters.GetValue<string>("val 1");

        }
    }
}
