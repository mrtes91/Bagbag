using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopDevmo2.Models.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class LoginView
    {
        [Display(Name = "Username")]
        public string LoginName { get; set; }

        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberLogin { get; set; }
    }
}