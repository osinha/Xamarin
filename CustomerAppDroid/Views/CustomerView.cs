using Android.App;
using Cirrious.MvvmCross.Droid.Views;
using CustomerAppCore.ViewModels;

namespace CustomerAppDroid.Views
{
    /// <summary>
    /// 
    /// </summary>
    [Activity(Label = "Customer", MainLauncher = true)]
    public class CustomerView : MvxActivity
    {
        #region Attributes
        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the view model.
        /// </summary>
        /// <value>
        /// The view model.
        /// </value>
        public new CustomerPageViewModel ViewModel
        {
            get { return (CustomerPageViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        #endregion

        #region .ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerView"/> class.
        /// </summary>
        public CustomerView()
        {
        }

        #endregion

        #region Protected Methods

        /// <summary>
        /// Called when [view model set].
        /// </summary>
        protected override void OnViewModelSet()
        {
            base.OnViewModelSet();
            SetContentView(Resource.Layout.Customer);
        }

        #endregion
    }
}