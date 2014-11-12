using Cirrious.MvvmCross.WindowsPhone.Platform;
using Microsoft.Phone.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppWP
{
    /// <summary>
    /// 
    /// </summary>
    public class Setup : MvxPhoneSetup
    {
        #region .ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="Setup"/> class.
        /// </summary>
        /// <param name="rootFrame">The root frame.</param>
        public Setup(PhoneApplicationFrame rootFrame)
            : base(rootFrame)
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
