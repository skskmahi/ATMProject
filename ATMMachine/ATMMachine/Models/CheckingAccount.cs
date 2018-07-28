using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATMMachine.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }
        public string AccountNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Decimal Balance { get; set; }

    }
}