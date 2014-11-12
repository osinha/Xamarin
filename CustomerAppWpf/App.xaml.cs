using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Wpf.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CustomerAppWpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Attributes

        private bool isSetupComplete = false;

        #endregion

        #region Private Methods

        /// <summary>
        /// Does the setup.
        /// </summary>
        private void DoSetup()
        {
            var presenter = new MvxSimpleWpfViewPresenter(MainWindow);

            var setup = new Setup(Dispatcher, presenter);
            setup.Initialize();

            var start = Mvx.Resolve<IMvxAppStart>();
            start.Start();

            isSetupComplete = true;
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Application.Activated" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> that contains the event data.</param>
        protected override void OnActivated(EventArgs e)
        {
            if (!isSetupComplete)
                DoSetup();

            base.OnActivated(e);
        }

        #endregion
    }
}
