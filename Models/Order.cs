using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothShop.Models
{

    public enum Comfirmation
    {
        Available, Out_of_Stock
    }

    public class Order   // order class 
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int CategoryID { get; set; }
        public int BrandID { get; set; }
        public Comfirmation? Comfirmation { get; set; }

        public Customer Customer { get; set; }   /// <summary>
                                                         ///  cutonmer link as a foriegn key with order class 
        /// </summary>
        public Category Category { get; set; }
        public Brand Brand { get; set; }
    }
}