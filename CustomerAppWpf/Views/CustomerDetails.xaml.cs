using Cirrious.MvvmCross.Wpf.Views;
using CustomerAppCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomerAppWpf.Views
{
    /// <summary>
    /// Interaction logic for CustomerDetails.xaml
    /// </summary>
    public partial class CustomerDetails : MvxWpfView
    {
        #region Attributes
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
    }
}
