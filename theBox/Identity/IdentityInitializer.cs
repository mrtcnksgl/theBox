using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using theBox.Entity;

namespace theBox.Identity
{
    public class IdentityInitializer : CreateDatabaseIfNotExists<IdentityDataContext>
    {

        protected override void Seed(IdentityDataContext context)
        {
            //Roller 
            if (!context.Roles.Any(i => i.Name == "admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "admin", Description = "admin rolü" };
                manager.Create(role);

            }

            //User

            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "kullanıcı rolü" };
                manager.Create(role);

            }

            if (!context.Users.Any(i => i.Name == "mertcankoseoglu"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name= "Mertcan", Surname = "Köseoğlu", UserName = "mertcan",Email = "mertcank@gmail.com"};
               
                manager.Create(user,"123456");
                manager.AddToRole(user.Id, "admin");
                manager.AddToRole(user.Id, "user");

            }
            
            if (!context.Users.Any(i => i.Name == "alikara"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser() { Name= "Ali", Surname = "Kara", UserName = "alikara",Email = "alikara@gmail.com"};
               
                manager.Create(user,"123456");
                manager.AddToRole(user.Id, "user");

            }
            



            base.Seed(context);
        }
    }
}