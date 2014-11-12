using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAppCore.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Customer
    {
        #region Attributes

        private uint id;
        private string imageUri;
        private string name;
        private string address;
        private string notes;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public uint Id
        {
            get { return id; }
            set { id = value; }
        }

        /// <summary>
        /// Gets or sets the image URI.
        /// </summary>
        /// <value>
        /// The image URI.
        /// </value>
        public string ImageUri
        {
            get { return imageUri; }
            set { imageUri = value; }
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// Gets or sets the notes.
        /// </summary>
        /// <value>
        /// The notes.
        /// </value>
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        #endregion
    }
}
