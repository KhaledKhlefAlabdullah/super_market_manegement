using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_final.Models
{
    internal class Role
    {
        [Required(ErrorMessage = "the role id is required")]
        public string roleId { get; set; }
        [Required(ErrorMessage = "the role is required")]
        public string role { get; set; }
        public ICollection<UserRoles> userRoles { get; set; }
    }
}
