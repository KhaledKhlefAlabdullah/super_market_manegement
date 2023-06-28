using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_final.Models
{
    internal class Sales
    {
        [Required(ErrorMessage ="the sales id required")]
        public string id { get; set; }
        [Required(ErrorMessage = "the product name required")]
        [MinLength(5)]
        public string product_name { get; set; }
        [Required(ErrorMessage ="the quintity is required")]
        public int quentity { get; set; }
        public double discount { get; set; }
        public DateTime data_of_sale { get; set; }
        [Required(ErrorMessage = "the user id is required")]
        public string userId { get; set; }
        [ForeignKey(nameof(userId))]
        public User user { get; set; }

    }
}
