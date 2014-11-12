using Cirrious.MvvmCross.ViewModels;
using CustomerAppDAL.Interfaces;
using CustomerAppDAL.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppCore.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerPageViewModel : MvxViewModel
    {
        #region Attributes

        private ObservableCollection<Customer> customers;
        private ICustomerManager customerManager = null;
        private Customer selectedCustomer = null;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the customers.
        /// </summary>
        /// <value>
        /// The customers.
        /// </value>
        public ObservableCollection<Customer> Customers
        {
            get
            {
                return this.customers;
            }
            set
            {
                this.customers = value;
                this.RaisePropertyChanged(() => Customers);
            }
        }

        /// <summary>
        /// Gets or sets the selected customer.
        /// </summary>
        /// <value>
        /// The selected customer.
        /// </value>
        public Customer SelectedCustomer
        {
            get
            {
                return this.selectedCustomer;
            }
            set
            {
                this.selectedCustomer = value;
                this.RaisePropertyChanged(() => SelectedCustomer);
                this.NavigateToDetailsPage(this.selectedCustomer.Id);
            }
        }

        #endregion

        #region .ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerPageViewModel"/> class.
        /// </summary>
        public CustomerPageViewModel(ICustomerManager customerManager)
        {
            this.customerManager = customerManager;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public override void Start()
        {
            this.LoadDummyData();
            var customerList = this.customerManager.GetCustomers();
            if (customerList != null)
                this.Customers = new ObservableCollection<Customer>(customerList);

            base.Start();
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Loads the dummy data.
        /// </summary>
        private void LoadDummyData()
        {
            this.customerManager.AddCustomer("Jon Skeet", "United Kingdom", " Author of C# in Depth.", "https://www.gravatar.com/avatar/6d8ebb117e8d83d74ea95fbdd0f87e13?s=128&d=identicon&r=PG");
            this.customerManager.AddCustomer("Jeff Wilcox", "Seattle, WA, USA", " Principal SDE Architect on the Azure team at Microsoft.", "http://m.c.lnkd.licdn.com/mpr/mpr/shrink_200_200/p/3/005/00a/1dd/1f5b625.jpg");
            this.customerManager.AddCustomer("S. Somasegar", "Redmond USA", "corporate vice president of the Developer Division at Microsoft.", "http://blogs.msdn.com/cfs-file.ashx/__key/communityserver-blogs-components-weblogfiles/00-00-00-36-44/8233.Soma_2D00_thumb.png");
        }

        /// <summary>
        /// Navigates to details page.
        /// </summary>
        /// <param name="id">The identifier.</param>
        private void NavigateToDetailsPage(uint id)
        {
            ShowViewModel<CustomerDetailViewModel>(new IdParameter() { Id = id });
        }

        #endregion

    }

    /// <summary>
    /// 
    /// </summary>
    public class IdParameter
    {
        public uint Id { get; set; }
    }
}
