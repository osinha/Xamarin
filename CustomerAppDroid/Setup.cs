using Android.Content;
using Cirrious.MvvmCross.Droid.Platform;
using Cirrious.MvvmCross.ViewModels;

namespace CustomerAppDroid
{
    /// <summary>
    /// 
    /// </summary>
    public class Setup : MvxAndroidSetup
    {
        #region .ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="Setup"/> class.
        /// </summary>
        /// <param name="applicationContext">The application context.</param>
        public Setup(Context applicationContext)
            : base(applicationContext)
        {
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Creates the application.
        /// </summary>
        /// <returns></returns>
        protected override IMvxApplication CreateApp()
        {
            return new CustomerAppCore.App();
        }

        #endregion
    }
}