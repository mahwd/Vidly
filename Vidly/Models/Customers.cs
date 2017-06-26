using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool isSubscribed { get; set; }
        public MemberShipType memberShipType { get; set; }
        public int memberShipTypeId { get; set; }
    }
}