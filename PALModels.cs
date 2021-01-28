/* 
 ACTION:
 in order to get this to work you need to paste the below one line at a time into the Package Manager Console. If you don't see that window below, you can find it under View --> Other Windows.  
 
 install-package Microsoft.EntityFrameworkCore
 install-package Microsoft.EntityFrameworkCore.SqlServer
 install-package Microsoft.Extensions.Configuration
 install-package Microsoft.Extensions.Configuration.FileExtensions
 install-package Microsoft.Extensions.Configuration.Json

 This will bring in all the packages you need to run this.
*/

// make sure to import these after installing the above
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using PALProgramming.Models;

using System;

namespace PALProgramming {

    // this class is a programatic representation of your database. it inherits the DbContext class, which allows you to turn your database into queryable and sortable lists of objects. 
    class PALModels : DbContext {

        // this is a helper function that uses ConfigurationBuilder to extract some settings from appsettings.json, which we created earlier
        public static string GetConnectionString() {
            string applicationDirectory = Environment.CurrentDirectory;
            var builder = new ConfigurationBuilder().SetBasePath(applicationDirectory).AddJsonFile("appsettings.json");
            var settings = builder.Build();
            // look in the ConnectionStrings property for the Students property
            return settings["ConnectionStrings:Students"];
        }

        // this function overrides the OnConfiguring method of the inherited DbContext class and allows you to configure the context.
        protected override void OnConfiguring(DbContextOptionsBuilder builder) {
            builder.UseSqlServer(GetConnectionString());
        }

        // there is a DbSet for each Model which matches a DB table. This allows you to query and list the items using Linq.

        // ACTION: right click on project, click new folder, call it "Models"
        // ACTION: right click on new Models folder and click add new class, and create four classes: Classes.cs, Users.cs, UsersAttendance.cs, UsersGrades.cs
        // ACTION: after creating those files enter Classes.cs and follow from there. after creating the properties from each class come back here.

        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersAttendance> UsersAttendance { get; set; }
        public virtual DbSet<UsersGrades> UsersGrades { get; set; }

        // ACTION: after adding the DbSets, return to Program.cs  


    }
}
