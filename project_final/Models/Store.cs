using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_final.Models
{
    internal class Store
    {
        [Required(ErrorMessage = "the product id required")]
        public string id { get; set; }
        [Required(ErrorMessage = "the product name required")]
        [MinLength(5)]
        public string product_name { get; set; }
        public string product_description { get; set;}
        [Required(ErrorMessage = "the quintity is required")]
        public int quintity { get; set; }
        [Required(ErrorMessage = "the price_of_sale is required")]
        public double price_of_sale { get; set; }
        [Required(ErrorMessage = "the price_of_purchase is required")]
        public double price_of_purchase { get; set; }
        [Required(ErrorMessage = "the profit is required")]
        public double profit { get; set; }
        public DateTime date_of_purchase { get; set; }
        [Required(ErrorMessage = "the user id is required")]
        public string userId { get; set; }
        [ForeignKey(nameof(userId))]
        public User user { get; set; }
        [Required(ErrorMessage = "the bill id is required")]
        public string billId { get; set; }
        [ForeignKey(nameof(billId))]
        public Bill bill { get; set; }
    }
}
