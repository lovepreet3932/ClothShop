using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace ClothShop.Models
{
    public class Category    // ctaegory clas 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryID { get; set; }   // category id 
        public string Title { get; set; } // category title   


        public ICollection<Order> Orders { get; set; }  // navigatio key with orders

    }
}
