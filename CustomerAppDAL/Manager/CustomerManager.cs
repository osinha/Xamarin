using CustomerAppDAL.Interfaces;
using CustomerAppDAL.Model;
using CustomerAppDAL.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppDAL.Manager
{
    /// <summary>
    /// 
    /// </summary>
    public class CustomerManager : ICustomerManager
    {
        #region Attributes

        private static uint customerIdCount = 0;

        #endregion

        #region Properties
        #endregion

        #region .ctor

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerManager"/> class.
        /// </summary>
        public CustomerManager()
        {
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the customers.
        /// </summary>
        /// <returns></returns>
        List<Customer> ICustomerManager.GetCustomers()
        {
            return CustomerStore.Customers;
        }

        /// <summary>
        /// Adds the customer.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="address">The address.</param>
        /// <param name="notes">The notes.</param>
        /// <param name="imageUri">The image URI.</param>
        /// <returns></returns>
        bool ICustomerManager.AddCustomer(string name, string address, string notes, string imageUri)
        {
            Customer newCustomer = new Customer();
            newCustomer.Id = ++customerIdCount;
            newCustomer.Name = name;
            newCustomer.Address = address;
            newCustomer.Notes = notes;
            newCustomer.ImageUri = imageUri;
            CustomerStore.Customers.Add(newCustomer);
            return true;
        }

        /// <summary>
        /// Updates the customer.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="address">The address.</param>
        /// <param name="notes">The notes.</param>
        /// <param name="imageUri">The image URI.</param>
        /// <returns></returns>
        bool ICustomerManager.UpdateCustomer(int id, string name, string address, string notes, string imageUri)
        {
            var customerToUpdate = CustomerStore.Customers.FirstOrDefault(a => a.Id.Equals(id));
            if (customerToUpdate != null)
            {
                customerToUpdate.Name = name;
                customerToUpdate.Address = address;
                customerToUpdate.Notes = notes;
                customerToUpdate.ImageUri = imageUri;
                return true;
            }

            return false;
        }

        /// <summary>
        /// Deletes the customer.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        bool ICustomerManager.DeleteCustomer(int id)
        {
            var customerToRemove = CustomerStore.Customers.FirstOrDefault(a => a.Id.Equals(id));
            if (customerToRemove != null)
            {
                CustomerStore.Customers.Remove(customerToRemove);
                return true;
            }

            return false;
        }

        #endregion
    }
}
