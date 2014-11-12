using Cirrious.MvvmCross.ViewModels;
using CustomerAppDAL.Interfaces;
using CustomerAppDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CustomerAppCore.ViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerDetailViewModel : MvxViewModel
    {
        #region Attributes

        private ICustomerManager customerManager = null;
        private uint customerId = 0;
        private Customer selectedCustomer = null;

        #endregion

        #region Properties

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
                this.RaisePropertyChanged(() => this.SelectedCustomer);
            }
        }

        /// <summary>
        /// Gets or sets the back command.
        /// </summary>
        /// <value>
        /// The back command.
        /// </value>
        public ICommand BackCommand
        {
            get;
            set;
        }

        #endregion

        #region .ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerDetailViewModel"/> class.
        /// </summary>
        /// <param name="customerManager">The customer manager.</param>
        public CustomerDetailViewModel(ICustomerManager customerManager)
        {
            this.customerManager = customerManager;
            this.BackCommand = new MvxCommand(GoBack);
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public override void Start()
        {
            var customerList = this.customerManager.GetCustomers();
            if (customerList != null && this.customerId != 0)
                this.SelectedCustomer = customerList.FirstOrDefault(a => a.Id.Equals(this.customerId));

            base.Start();
        }

        /// <summary>
        /// Initializes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public void Init(uint Id)
        {
            this.customerId = Id;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Goes the back.
        /// </summary>
        private void GoBack()
        {
            this.Close(this);
        }

        #endregion
    }
}
