using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;


namespace WebLabNew.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public byte[]? AvatarImage { get; set; }
    }

}
