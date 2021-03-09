using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothShop.Models
{
    public class Customer    // customer class 
    {
          // customer details 
        public string ID { get; set; }
        public string Customer_Name { get; set; }
        public string Gender { get; set; }
        public string Address{ get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }

        public ICollection<Order> Order { get; set; }




    }
}
