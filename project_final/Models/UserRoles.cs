using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_final.Models
{
    internal class UserRoles
    {
        [Required(ErrorMessage = "the userRole id is required")]
        public string userRolesId { get; set; }
        [Required(ErrorMessage = "the user id is required")]
        public string userId { get; set; }
        [ForeignKey(nameof(userId))]
        public User user { get; set; }
        [Required(ErrorMessage = "the role id is required")]
        public string roleId { get; set; }
        [ForeignKey(nameof(roleId))]
        public Role role { get; set; }
    }
}
