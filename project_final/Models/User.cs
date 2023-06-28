using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_final.Models
{
    internal class User
    {
        [Required(ErrorMessage = "Id is required")]
        public string userId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [MinLength(2)]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required(ErrorMessage ="Password is rquired")]
        [MinLength(8)]
        public string password { get; set; }
        public ICollection<UserRoles> userRoles { get; set; }
        public ICollection<Store> stores { get; set; }
        public ICollection<Sales> sales { get; set; }
    }
}
