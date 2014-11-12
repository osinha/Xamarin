using CustomerAppDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppDAL.Storage
{
    /// <summary>
    /// 
    /// </summary>
    public static class CustomerStore
    {
        #region Attributes

        private static List<Customer> customers = null;

        #endregion

        #region .ctor

        /// <summary>
        /// Initializes the <see cref="CustomerStore" /> class.
        /// </summary>
        static CustomerStore()
        {
            customers = new List<Customer>();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the customers.
        /// </summary>
        /// <value>
        /// The customers.
        /// </value>
        public static List<Customer> Customers
        {
            get { return CustomerStore.customers; }
            set { CustomerStore.customers = value; }
        }

        #endregion
    }
}
