using Cirrious.MvvmCross.Wpf.Platform;
using Cirrious.MvvmCross.Wpf.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace CustomerAppWpf
{
    public class Setup : MvxWpfSetup
    {
        #region .ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="Setup"/> class.
        /// </summary>
        /// <param name="uiThreadDispatcher">The UI thread dispatcher.</param>
        /// <param name="presenter">The presenter.</param>
        public Setup(Dispatcher uiThreadDispatcher, IMvxWpfViewPresenter presenter)
            : base(uiThreadDispatcher, presenter)
        {

        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Creates the application.
        /// </summary>
        /// <returns></returns>
        protected override Cirrious.MvvmCross.ViewModels.IMvxApplication CreateApp()
        {
            return new CustomerAppCore.App();
        }

        #endregion
    }
}
