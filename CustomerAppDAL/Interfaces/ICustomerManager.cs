using CustomerAppDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppDAL.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICustomerManager
    {
        /// <summary>
        /// Gets the customers.
        /// </summary>
        /// <returns></returns>
        List<Customer> GetCustomers();

        /// <summary>
        /// Adds the customer.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="address">The address.</param>
        /// <param name="notes">The notes.</param>
        /// <param name="imageUri">The image URI.</param>
        /// <returns></returns>
        bool AddCustomer(string name, string address, string notes, string imageUri);

        /// <summary>
        /// Updates the customer.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="address">The address.</param>
        /// <param name="notes">The notes.</param>
        /// <param name="imageUri">The image URI.</param>
        /// <returns></returns>
        bool UpdateCustomer(int id, string name, string address, string notes, string imageUri);

        /// <summary>
        /// Deletes the customer.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        bool DeleteCustomer(int id);
    }
}
