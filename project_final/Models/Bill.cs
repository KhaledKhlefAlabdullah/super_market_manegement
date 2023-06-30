using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_final.Models
{
     public enum BillType
        {
            sale=0,
            purchase=1
        }
    internal class Bill
    {
       
        [Required(ErrorMessage = "the bill id required")]
        public string billId { get; set; }
        public DateTime data_of_sale { get; set; }
        [Required(ErrorMessage ="the amount is required")]
        public double amount { get; set; }
        [Required(ErrorMessage ="the quantity is required")]
        public int quantity { get; set; }
        [Required(ErrorMessage ="the bill type is required")]
        public BillType billType { get; set; }
        public ICollection<Sales> sales { get; set; }
    }
}
