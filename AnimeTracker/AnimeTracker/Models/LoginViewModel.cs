using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeTracker.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Login Name")]
        public string username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
        [Required]
        public bool isAdmin { get; set; }
        [Display(Name = "Remember me?")]
        [DefaultValue(false)]
        public bool rememeberMe { get; set; }

        public LoginViewModel()
        {

        }

        public LoginViewModel(AppUser user)
        {
            this.username = user.username;
            this.password = user.password;
            this.isAdmin = user.admin;
            this.rememeberMe = false;
        }
    }
}
