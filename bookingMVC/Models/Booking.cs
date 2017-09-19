using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace bookingMVC.Models
{
    /// <summary>
    /// test
    /// </summary>
    public class Booking
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public virtual Order Order { get; set; }

        public virtual Room Room { get; set; }

        public virtual ICollection<Option> Options { get; set; }
    }
}