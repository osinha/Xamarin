using Android.App;
using Cirrious.MvvmCross.Droid.Views;
using CustomerAppCore.ViewModels;

namespace CustomerAppDroid.Views
{
    /// <summary>
    /// 
    /// </summary>
    [Activity(Label = "Customer Details")]
    public class CustomerDetailView : MvxActivity
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
        public new CustomerDetailViewModel ViewModel
        {
            get { return (CustomerDetailViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        #endregion

        #region .ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerDetailView"/> class.
        /// </summary>
        public CustomerDetailView()
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
            this.SetContentView(Resource.Layout.CustomerDetail);
        }

        #endregion
    }
}