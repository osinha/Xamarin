using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using CustomerAppCore.ViewModels;
using Cirrious.MvvmCross.WindowsPhone.Views;

namespace CustomerAppWP.Views
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CustomerDetails : MvxPhonePage
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
            get
            {
                return (CustomerDetailViewModel)base.ViewModel;
            }
            set
            {
                base.ViewModel = value;
            }
        }

        #endregion

        #region .ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerDetails"/> class.
        /// </summary>
        public CustomerDetails()
        {
            InitializeComponent();
        }

        #endregion
    }
}