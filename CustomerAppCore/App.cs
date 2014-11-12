using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using CustomerAppCore.ViewModels;
using CustomerAppDAL.Interfaces;
using CustomerAppDAL.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppCore
{
    /// <summary>
    /// 
    /// </summary>
    public class App : MvxApplication
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App()
        {
            Mvx.RegisterType<ICustomerManager, CustomerManager>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<CustomerPageViewModel>());
        }
    }
}
