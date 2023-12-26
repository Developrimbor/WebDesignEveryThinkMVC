using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDesignEveryThinkMVC.Identity
{
    public class ApplicationRole:IdentityRole
    {
        public string Desscription { get; set; }

        public ApplicationRole()
        {
            
        } 
        
        public ApplicationRole(string rolname, string description)
        {
            this.Desscription = description;
        }
    }
}