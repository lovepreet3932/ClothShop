using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace ClothShop.Models
{
    public class Brand  // brand class
    {



        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BrandID { get; set; }  // brand id
        public string Title { get; set; } // brand name
       

        public ICollection<Order> Orders { get; set; }  // navigation keyb with orders
    }
}
