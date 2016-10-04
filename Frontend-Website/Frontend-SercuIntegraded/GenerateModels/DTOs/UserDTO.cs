using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Frontend_SercuIntegraded.GenerateModels;

namespace Frontend_SercuIntegraded.GenerateModels.DTOs
{
    public class UserDTO : User
    {
        public override ICollection<WebpagesRole> WebpagesRoles
        {
            get
            {
                return base.WebpagesRoles;
            }

            set
            {
                base.WebpagesRoles = value;
            }
        }
    }
}